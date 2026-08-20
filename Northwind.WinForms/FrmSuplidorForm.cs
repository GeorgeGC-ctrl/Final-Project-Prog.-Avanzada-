using Northwind.Application.DTOs;
using Northwind.Application.UseCases.Suplidores;

namespace Northwind.WinForms
{
    public partial class FrmSuplidorForm : Form
    {
        private readonly CreateSupplier _createSupplier;
        private readonly UpdateSupplier _updateSupplier;
        private readonly GetSupplierById _getSupplierById;

        private int? _supplierId;

        public FrmSuplidorForm(CreateSupplier createSupplier, UpdateSupplier updateSupplier, GetSupplierById getSupplierById)
        {
            InitializeComponent();
            _createSupplier = createSupplier;
            _updateSupplier = updateSupplier;
            _getSupplierById = getSupplierById;
        }

        public void ConfigurarNuevo()
        {
            _supplierId = null;
            lblTitulo.Text = "Nuevo Suplidor";
            lblSubtitulo.Text = "Complete la información para registrar un nuevo suplidor";
            btnGuardar.Text = "Crear Suplidor";

            txtCompanyName.Clear();
            txtContactName.Clear();
            txtContactTitle.Clear();
            txtCountry.Clear();
            txtCity.Clear();
            txtPhone.Clear();
            errorProvider.Clear();
        }

        public async Task ConfigurarEdicionAsync(int supplierId)
        {
            _supplierId = supplierId;
            lblTitulo.Text = $"Editar Suplidor #{supplierId}";
            lblSubtitulo.Text = "Modifique los datos del suplidor seleccionado";
            btnGuardar.Text = "Guardar Cambios";
            errorProvider.Clear();

            try
            {
                var result = await _getSupplierById.EjecutarAsync(supplierId);
                if (result.IsSuccess && result.Value != null)
                {
                    var s = result.Value;
                    txtCompanyName.Text = s.CompanyName;
                    txtContactName.Text = s.ContactName ?? string.Empty;
                    txtContactTitle.Text = s.ContactTitle ?? string.Empty;
                    txtCountry.Text = s.Country ?? string.Empty;
                    txtCity.Text = s.city ?? string.Empty;
                    txtPhone.Text = s.Phone ?? string.Empty;
                }
                else
                {
                    MessageBox.Show(result.Error ?? "No se encontró la información del suplidor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos del suplidor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
                return;

            try
            {
                btnGuardar.Enabled = false;
                btnGuardar.Text = "Guardando...";

                if (_supplierId.HasValue)
                {
                    var request = new EditarSuplidorRequest(
                        _supplierId.Value,
                        txtCompanyName.Text.Trim(),
                        string.IsNullOrWhiteSpace(txtContactName.Text) ? null : txtContactName.Text.Trim(),
                        string.IsNullOrWhiteSpace(txtContactTitle.Text) ? null : txtContactTitle.Text.Trim(),
                        string.IsNullOrWhiteSpace(txtPhone.Text) ? null : txtPhone.Text.Trim(),
                        string.IsNullOrWhiteSpace(txtCountry.Text) ? null : txtCountry.Text.Trim(),
                        txtCity.Text.Trim()
                    );

                    var result = await _updateSupplier.EjecutarAsync(request);
                    if (result.IsSuccess)
                    {
                        MessageBox.Show("Suplidor actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(result.Error ?? "Error al actualizar suplidor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    var request = new CrearSuplidorRequest(
                        txtCompanyName.Text.Trim(),
                        string.IsNullOrWhiteSpace(txtContactName.Text) ? null : txtContactName.Text.Trim(),
                        string.IsNullOrWhiteSpace(txtContactTitle.Text) ? null : txtContactTitle.Text.Trim(),
                        string.IsNullOrWhiteSpace(txtPhone.Text) ? null : txtPhone.Text.Trim(),
                        string.IsNullOrWhiteSpace(txtCountry.Text) ? null : txtCountry.Text.Trim(),
                        txtCity.Text.Trim()
                    );

                    var result = await _createSupplier.EjecutarAsync(request);
                    if (result.IsSuccess)
                    {
                        MessageBox.Show($"Suplidor creado exitosamente con ID #{result.Value}.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(result.Error ?? "Error al crear suplidor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la solicitud: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
                btnGuardar.Text = _supplierId.HasValue ? "Guardar Cambios" : "Crear Suplidor";
            }
        }

        private bool ValidarFormulario()
        {
            errorProvider.Clear();
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
            {
                errorProvider.SetError(txtCompanyName, "El nombre de la compañía es obligatorio.");
                esValido = false;
            }
            else if (txtCompanyName.Text.Length > 40)
            {
                errorProvider.SetError(txtCompanyName, "No puede superar los 40 caracteres.");
                esValido = false;
            }

            if (string.IsNullOrWhiteSpace(txtContactName.Text))
            {
                errorProvider.SetError(txtContactName, "El nombre del contacto no puede estar vacío.");
                esValido = false;
            }
            else if (txtContactName.Text.Length > 30)
            {
                errorProvider.SetError(txtContactName, "No puede superar los 30 caracteres.");
                esValido = false;
            }

            if (txtCountry.Text.Length > 15)
            {
                errorProvider.SetError(txtCountry, "El país no puede superar los 15 caracteres.");
                esValido = false;
            }

            if (txtCity.Text.Length > 15)
            {
                errorProvider.SetError(txtCity, "La ciudad no puede superar los 15 caracteres.");
                esValido = false;
            }

            if (txtPhone.Text.Length > 24)
            {
                errorProvider.SetError(txtPhone, "El teléfono no puede superar los 24 caracteres.");
                esValido = false;
            }

            return esValido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
