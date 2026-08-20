using Microsoft.Extensions.DependencyInjection;
using Northwind.Application.DTOs;
using Northwind.Application.UseCases.Suplidores;

namespace Northwind.WinForms
{
    public partial class FrmSuplidorLista : Form
    {
        private readonly GetSuppliers _getSuppliers;
        private readonly DeleteSupplier _deleteSupplier;
        private readonly IServiceProvider _serviceProvider;

        private List<SuplidorDto> _suplidoresCompletos = new();

        public FrmSuplidorLista(
            GetSuppliers getSuppliers,
            DeleteSupplier deleteSupplier,
            IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _getSuppliers = getSuppliers;
            _deleteSupplier = deleteSupplier;
            _serviceProvider = serviceProvider;
        }

        private async void FrmSuplidorLista_Load(object sender, EventArgs e)
        {
            await CargarSuplidoresAsync();
        }

        private async Task CargarSuplidoresAsync()
        {
            try
            {
                btnRefrescar.Enabled = false;

                var result = await _getSuppliers.EjecutarAsync();
                if (!result.IsSuccess || result.Value == null)
                {
                    MessageBox.Show(result.Error ?? "Error al consultar los suplidores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _suplidoresCompletos = result.Value.ToList();
                AplicarFiltro();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de suplidores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRefrescar.Enabled = true;
            }
        }

        private void AplicarFiltro()
        {
            var texto = txtBuscar.Text.Trim().ToLowerInvariant();

            var filtrados = string.IsNullOrWhiteSpace(texto)
                ? _suplidoresCompletos
                : _suplidoresCompletos.Where(s =>
                    s.CompanyName.ToLowerInvariant().Contains(texto) ||
                    (s.ContactName != null && s.ContactName.ToLowerInvariant().Contains(texto)) ||
                    (s.Country != null && s.Country.ToLowerInvariant().Contains(texto)) ||
                    s.city.ToLowerInvariant().Contains(texto)).ToList();

            dgvSuplidores.DataSource = filtrados;

            if (dgvSuplidores.Columns["SupplierId"] != null)
                dgvSuplidores.Columns["SupplierId"].HeaderText = "ID";
            if (dgvSuplidores.Columns["CompanyName"] != null)
                dgvSuplidores.Columns["CompanyName"].HeaderText = "Compañía";
            if (dgvSuplidores.Columns["ContactName"] != null)
                dgvSuplidores.Columns["ContactName"].HeaderText = "Contacto";
            if (dgvSuplidores.Columns["ContactTitle"] != null)
                dgvSuplidores.Columns["ContactTitle"].HeaderText = "Cargo";
            if (dgvSuplidores.Columns["Country"] != null)
                dgvSuplidores.Columns["Country"].HeaderText = "País";
            if (dgvSuplidores.Columns["city"] != null)
                dgvSuplidores.Columns["city"].HeaderText = "Ciudad";
            if (dgvSuplidores.Columns["Phone"] != null)
                dgvSuplidores.Columns["Phone"].HeaderText = "Teléfono";

            int total = filtrados.Count;
            int paises = filtrados.Where(s => !string.IsNullOrWhiteSpace(s.Country)).Select(s => s.Country).Distinct().Count();

            lblTotalSuplidores.Text = $"Total Suplidores: {total}";
            lblTotalPaises.Text = $"Países Cubiertos: {paises}";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private async void btnRefrescar_Click(object sender, EventArgs e)
        {
            await CargarSuplidoresAsync();
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<FrmSuplidorForm>();
            form.ConfigurarNuevo();

            if (form.ShowDialog(this) == DialogResult.OK)
            {
                await CargarSuplidoresAsync();
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            await EditarSeleccionadoAsync();
        }

        private async void dgvSuplidores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                await EditarSeleccionadoAsync();
            }
        }

        private async Task EditarSeleccionadoAsync()
        {
            if (dgvSuplidores.CurrentRow?.DataBoundItem is SuplidorDto suplidor)
            {
                var form = _serviceProvider.GetRequiredService<FrmSuplidorForm>();
                await form.ConfigurarEdicionAsync(suplidor.SupplierId);

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    await CargarSuplidoresAsync();
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un suplidor de la lista para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvSuplidores.CurrentRow?.DataBoundItem is not SuplidorDto suplidor)
            {
                MessageBox.Show("Por favor seleccione un suplidor de la lista para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea eliminar al suplidor '{suplidor.CompanyName}' (ID: {suplidor.SupplierId})?",
                "Confirmación de Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion != DialogResult.Yes)
                return;

            try
            {
                btnEliminar.Enabled = false;

                var result = await _deleteSupplier.EjecutarAsync(suplidor.SupplierId);
                if (result.IsSuccess)
                {
                    MessageBox.Show("Suplidor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CargarSuplidoresAsync();
                }
                else
                {
                    MessageBox.Show(result.Error ?? "No se pudo eliminar el suplidor.", "Validación de Eliminación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error durante la eliminación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnEliminar.Enabled = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
