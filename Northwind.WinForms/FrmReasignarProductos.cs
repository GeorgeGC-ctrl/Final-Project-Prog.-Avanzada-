using Northwind.Application.DTOs;
using Northwind.Application.UseCases.Productos;
using Northwind.Application.UseCases.Suplidores;

namespace Northwind.WinForms
{
    public partial class FrmReasignarProductos : Form
    {
        private readonly GetSuppliers _getSuppliers;
        private readonly ReassignSupplier _reassignSupplier;
        private readonly GetProducts _getProducts;

        public FrmReasignarProductos(GetSuppliers getSuppliers, ReassignSupplier reassignSupplier, GetProducts getProducts)
        {
            InitializeComponent();
            _getSuppliers = getSuppliers;
            _reassignSupplier = reassignSupplier;
            _getProducts = getProducts;
        }

        private async void FrmReasignarProductos_Load(object sender, EventArgs e)
        {
            await CargarSuplidoresAsync();
        }

        private async Task CargarSuplidoresAsync()
        {
            try
            {
                var result = await _getSuppliers.EjecutarAsync();
                if (!result.IsSuccess || result.Value == null)
                {
                    MessageBox.Show(result.Error ?? "Error al cargar los suplidores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var listaOrigen = result.Value.ToList();
                var listaDestino = result.Value.ToList();

                cmbOrigen.DataSource = listaOrigen;
                cmbOrigen.DisplayMember = nameof(SuplidorDto.CompanyName);
                cmbOrigen.ValueMember = nameof(SuplidorDto.SupplierId);
                cmbOrigen.SelectedIndex = -1;

                cmbDestino.DataSource = listaDestino;
                cmbDestino.DisplayMember = nameof(SuplidorDto.CompanyName);
                cmbDestino.ValueMember = nameof(SuplidorDto.SupplierId);
                cmbDestino.SelectedIndex = -1;

                lblInfoProductos.Text = "Seleccione un suplidor para ver sus productos.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar suplidores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrigen.SelectedValue is int suplidorId)
            {
                try
                {
                    var productosResult = await _getProducts.EjecutarAsync(suplidorId: suplidorId);
                    if (productosResult.IsSuccess && productosResult.Value != null)
                    {
                        int cantidad = productosResult.Value.Count();
                        lblInfoProductos.Text = $"ℹ Este suplidor tiene {cantidad} producto(s) asociado(s).";
                    }
                    else
                    {
                        lblInfoProductos.Text = "ℹ No se pudieron consultar los productos.";
                    }
                }
                catch
                {
                    lblInfoProductos.Text = "ℹ Error al verificar productos del suplidor.";
                }
            }
            else
            {
                lblInfoProductos.Text = "Seleccione un suplidor para ver sus productos.";
            }
        }

        private async void btnReasignar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
                return;

            var origenId = (int)cmbOrigen.SelectedValue!;
            var destinoId = (int)cmbDestino.SelectedValue!;

            var confirmacion = MessageBox.Show(
                $"¿Está seguro de reasignar todos los productos del suplidor:\n\n• Origen: {cmbOrigen.Text}\n• Destino: {cmbDestino.Text}\n\nEsta operación no se puede deshacer.",
                "Confirmación de Reasignación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            try
            {
                btnReasignar.Enabled = false;
                btnReasignar.Text = "Reasignando...";

                var request = new ReasignarSuplidorRequest(origenId, destinoId);
                var result = await _reassignSupplier.EjecutarAsync(request);

                if (result.IsSuccess)
                {
                    MessageBox.Show("Productos reasignados correctamente al nuevo suplidor.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CargarSuplidoresAsync();
                }
                else
                {
                    MessageBox.Show(result.Error ?? "No se pudo completar la reasignación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error durante la reasignación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnReasignar.Enabled = true;
                btnReasignar.Text = "Reasignar Lote";
            }
        }

        private bool ValidarFormulario()
        {
            errorProvider.Clear();
            bool esValido = true;

            if (cmbOrigen.SelectedValue == null)
            {
                errorProvider.SetError(cmbOrigen, "Debe seleccionar un suplidor de origen.");
                esValido = false;
            }

            if (cmbDestino.SelectedValue == null)
            {
                errorProvider.SetError(cmbDestino, "Debe seleccionar un suplidor de destino.");
                esValido = false;
            }

            if (esValido && cmbOrigen.SelectedValue != null && cmbDestino.SelectedValue != null)
            {
                if ((int)cmbOrigen.SelectedValue == (int)cmbDestino.SelectedValue)
                {
                    errorProvider.SetError(cmbDestino, "El suplidor de destino no puede ser igual al de origen.");
                    esValido = false;
                }
            }

            return esValido;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
