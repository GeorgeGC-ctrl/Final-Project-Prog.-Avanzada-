using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Northwind.Application.DTOs;
using Northwind.Application.UseCases.Categorias;

namespace Northwind.WinForms
{
    public partial class FrmCategoriaLista : Form
    {
        private readonly GetAllCategories _getAllCategories;
        private readonly DeleteCategory _deleteCategory;
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<FrmCategoriaLista> _logger;

        private List<CategoriaDto> _categorias = new();

        public FrmCategoriaLista(
            GetAllCategories getAllCategories,
            DeleteCategory deleteCategory,
            IServiceProvider serviceProvider,
            ILogger<FrmCategoriaLista> logger)
        {
            InitializeComponent();
            _getAllCategories = getAllCategories;
            _deleteCategory = deleteCategory;
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        private async void FrmCategoriaLista_Load(object sender, EventArgs e)
        {
            await CargarCategoriasAsync();
        }

        private async Task CargarCategoriasAsync()
        {
            try
            {
                lblStatus.Text = "Cargando categorías...";
                this.Cursor = Cursors.WaitCursor;

                var result = await _getAllCategories.EjecutarAsync();

                if (result.IsSuccess && result.Value is not null)
                {
                    _categorias = result.Value.ToList();
                    AplicarFiltro();
                    lblStatus.Text = $"Total de categorías: {_categorias.Count}";
                }
                else
                {
                    lblStatus.Text = "Error al cargar categorías.";
                    MessageBox.Show(
                        result.Error ?? "Ocurrió un error al obtener las categorías.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error no controlado al cargar categorías");
                lblStatus.Text = "Error al cargar categorías.";
                MessageBox.Show(
                    $"Error inesperado: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void AplicarFiltro()
        {
            var texto = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(texto))
            {
                dgvCategorias.DataSource = _categorias.ToList();
            }
            else
            {
                var filtradas = _categorias
                    .Where(c => (!string.IsNullOrEmpty(c.CategoryName) && c.CategoryName.ToLower().Contains(texto)) ||
                                (!string.IsNullOrEmpty(c.Description) && c.Description.ToLower().Contains(texto)) ||
                                c.CategoryId.ToString().Contains(texto))
                    .ToList();

                dgvCategorias.DataSource = filtradas;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await CargarCategoriasAsync();
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                var form = _serviceProvider.GetRequiredService<FrmCategoriaForm>();
                form.PrepararCrear();

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    await CargarCategoriasAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al abrir formulario de creación de categoría");
                MessageBox.Show(
                    $"No se pudo abrir el formulario: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                await EditarSeleccionadoAsync();
            }
        }

        private async void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            dgvCategorias.CurrentCell = dgvCategorias.Rows[e.RowIndex].Cells[0];

            if (e.ColumnIndex == colEditar.Index)
            {
                await EditarSeleccionadoAsync();
            }
            else if (e.ColumnIndex == colEliminar.Index)
            {
                await EliminarSeleccionadoAsync();
            }
        }

        private async Task EditarSeleccionadoAsync()
        {
            if (dgvCategorias.CurrentRow?.DataBoundItem is not CategoriaDto seleccionada)
            {
                MessageBox.Show(
                    "Por favor, seleccione una categoría de la lista.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            try
            {
                var form = _serviceProvider.GetRequiredService<FrmCategoriaForm>();
                form.PrepararEditar(seleccionada);

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    await CargarCategoriasAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al abrir formulario de edición para ID: {Id}", seleccionada.CategoryId);
                MessageBox.Show(
                    $"No se pudo abrir el formulario: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async Task EliminarSeleccionadoAsync()
        {
            if (dgvCategorias.CurrentRow?.DataBoundItem is not CategoriaDto seleccionada)
            {
                MessageBox.Show(
                    "Por favor, seleccione una categoría para eliminar.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea eliminar la categoría \"{seleccionada.CategoryName}\" (ID: {seleccionada.CategoryId})?\n\nEsta acción no se puede deshacer.",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (confirmacion != DialogResult.Yes)
                return;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                lblStatus.Text = $"Eliminando categoría ID {seleccionada.CategoryId}...";

                var result = await _deleteCategory.EjecutarAsync(seleccionada.CategoryId);

                if (result.IsSuccess)
                {
                    MessageBox.Show(
                        $"La categoría \"{seleccionada.CategoryName}\" fue eliminada correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    await CargarCategoriasAsync();
                }
                else
                {
                    _logger.LogWarning("Fallo al eliminar categoría ID {Id}: {Error}", seleccionada.CategoryId, result.Error);
                    MessageBox.Show(
                        result.Error ?? "No se pudo eliminar la categoría.",
                        "Validación al Eliminar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    lblStatus.Text = "No se pudo eliminar la categoría.";
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error no controlado al eliminar categoría ID {Id}", seleccionada.CategoryId);
                MessageBox.Show(
                    $"Error inesperado al eliminar: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
    }
}
