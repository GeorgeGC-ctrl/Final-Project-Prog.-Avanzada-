using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Northwind.Application.DTOs;
using Northwind.Application.UseCases.Productos;

namespace Northwind.WinForms
{
    public partial class FrmProductoLista : Form
    {
        private readonly GetProducts _getProducts;
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<FrmProductoLista> _logger;

        private List<ProductoDto> _productos = new();

        public FrmProductoLista(
            GetProducts getProducts,
            IServiceProvider serviceProvider,
            ILogger<FrmProductoLista> logger)
        {
            InitializeComponent();
            _getProducts = getProducts;
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        private async void FrmProductoLista_Load(object sender, EventArgs e)
        {
            await CargarProductosAsync();
        }

        private async Task CargarProductosAsync()
        {
            try
            {
                btnRefrescar.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                var result = await _getProducts.EjecutarAsync();

                if (result.IsSuccess && result.Value is not null)
                {
                    _productos = result.Value.ToList();
                    AplicarFiltro();
                }
                else
                {
                    MessageBox.Show(
                        result.Error ?? "Ocurrió un error al obtener los productos.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error no controlado al cargar productos");
                MessageBox.Show(
                    $"Error inesperado: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnRefrescar.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        private void AplicarFiltro()
        {
            var texto = txtBuscar.Text.Trim().ToLowerInvariant();

            var filtrados = string.IsNullOrWhiteSpace(texto)
                ? _productos
                : _productos.Where(p =>
                    p.ProductName.ToLowerInvariant().Contains(texto) ||
                    (p.CategoryName != null && p.CategoryName.ToLowerInvariant().Contains(texto)) ||
                    (p.SupplierName != null && p.SupplierName.ToLowerInvariant().Contains(texto)) ||
                    p.ProductId.ToString().Contains(texto)).ToList();

            dgvProductos.DataSource = filtrados;

            if (dgvProductos.Columns["ProductId"] != null)
                dgvProductos.Columns["ProductId"].HeaderText = "ID";
            if (dgvProductos.Columns["ProductName"] != null)
                dgvProductos.Columns["ProductName"].HeaderText = "Producto";
            if (dgvProductos.Columns["CategoryName"] != null)
                dgvProductos.Columns["CategoryName"].HeaderText = "Categoría";
            if (dgvProductos.Columns["SupplierName"] != null)
                dgvProductos.Columns["SupplierName"].HeaderText = "Suplidor";
            if (dgvProductos.Columns["QuantityPerUnit"] != null)
                dgvProductos.Columns["QuantityPerUnit"].HeaderText = "Cant. por Unidad";
            if (dgvProductos.Columns["UnitPrice"] != null)
                dgvProductos.Columns["UnitPrice"].HeaderText = "Precio";
            if (dgvProductos.Columns["UnitsInStock"] != null)
                dgvProductos.Columns["UnitsInStock"].HeaderText = "Stock";
            if (dgvProductos.Columns["UnitsOnOrder"] != null)
                dgvProductos.Columns["UnitsOnOrder"].HeaderText = "En Orden";
            if (dgvProductos.Columns["ReorderLevel"] != null)
                dgvProductos.Columns["ReorderLevel"].HeaderText = "Nivel Reorden";
            if (dgvProductos.Columns["Discontinued"] != null)
                dgvProductos.Columns["Discontinued"].HeaderText = "Descontinuado";
            if (dgvProductos.Columns["SupplierId"] != null)
                dgvProductos.Columns["SupplierId"].Visible = false;
            if (dgvProductos.Columns["CategoryId"] != null)
                dgvProductos.Columns["CategoryId"].Visible = false;

            lblTotalProductos.Text = $"Total Productos: {filtrados.Count}";
            lblTotalDescontinuados.Text = $"Descontinuados: {filtrados.Count(p => p.Discontinued)}";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private async void btnRefrescar_Click(object sender, EventArgs e)
        {
            await CargarProductosAsync();
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                var form = _serviceProvider.GetRequiredService<FrmProductoForm>();
                form.PrepararCrear();

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    await CargarProductosAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al abrir formulario de creación de producto");
                MessageBox.Show(
                    $"No se pudo abrir el formulario: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            await EditarSeleccionadoAsync();
        }

        private async void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                await EditarSeleccionadoAsync();
            }
        }

        private async Task EditarSeleccionadoAsync()
        {
            if (dgvProductos.CurrentRow?.DataBoundItem is not ProductoDto seleccionado)
            {
                MessageBox.Show(
                    "Por favor, seleccione un producto de la lista.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            try
            {
                var form = _serviceProvider.GetRequiredService<FrmProductoForm>();
                form.PrepararEditar(seleccionado);

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    await CargarProductosAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al abrir formulario de edición para producto ID: {Id}", seleccionado.ProductId);
                MessageBox.Show(
                    $"No se pudo abrir el formulario: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
