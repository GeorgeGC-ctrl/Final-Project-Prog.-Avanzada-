using FluentValidation;
using Microsoft.Extensions.Logging;
using Northwind.Application.DTOs;
using Northwind.Application.UseCases.Categorias;

namespace Northwind.WinForms
{
    public partial class FrmCategoriaForm : Form
    {
        private readonly CreateCategory _createCategory;
        private readonly UpdateCategory _updateCategory;
        private readonly IValidator<CrearCategoriaRequest> _createValidator;
        private readonly IValidator<EditarCategoriaRequest> _updateValidator;
        private readonly ILogger<FrmCategoriaForm> _logger;

        private bool _isEditing;
        private int _categoriaId;

        public FrmCategoriaForm(
            CreateCategory createCategory,
            UpdateCategory updateCategory,
            IValidator<CrearCategoriaRequest> createValidator,
            IValidator<EditarCategoriaRequest> updateValidator,
            ILogger<FrmCategoriaForm> logger)
        {
            InitializeComponent();
            _createCategory = createCategory;
            _updateCategory = updateCategory;
            _createValidator = createValidator;
            _updateValidator = updateValidator;
            _logger = logger;
        }

        public void PrepararCrear()
        {
            _isEditing = false;
            _categoriaId = 0;

            lblTitulo.Text = "Nueva Categoría";
            lblSubtitulo.Text = "Ingrese los datos para registrar una nueva categoría.";
            this.Text = "Nueva Categoría";

            txtId.Text = "(Automático)";
            txtNombre.Clear();
            txtDescripcion.Clear();
            errorProvider.Clear();

            txtNombre.Focus();
        }

        public void PrepararEditar(CategoriaDto categoria)
        {
            _isEditing = true;
            _categoriaId = categoria.CategoryId;

            lblTitulo.Text = "Editar Categoría";
            lblSubtitulo.Text = $"Modificando información de la categoría #{categoria.CategoryId}.";
            this.Text = $"Editar Categoría - #{categoria.CategoryId}";

            txtId.Text = categoria.CategoryId.ToString();
            txtNombre.Text = categoria.CategoryName;
            txtDescripcion.Text = categoria.Description ?? string.Empty;
            errorProvider.Clear();

            txtNombre.Focus();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            var nombre = txtNombre.Text.Trim();
            var descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? null : txtDescripcion.Text.Trim();

            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnGuardar.Enabled = false;

                if (!_isEditing)
                {
                    var request = new CrearCategoriaRequest(nombre, descripcion);
                    var validationResult = await _createValidator.ValidateAsync(request);

                    if (!validationResult.IsValid)
                    {
                        foreach (var error in validationResult.Errors)
                        {
                            if (error.PropertyName.Contains("CategoryName", StringComparison.OrdinalIgnoreCase))
                                errorProvider.SetError(txtNombre, error.ErrorMessage);
                            else if (error.PropertyName.Contains("Description", StringComparison.OrdinalIgnoreCase))
                                errorProvider.SetError(txtDescripcion, error.ErrorMessage);
                        }

                        var errores = string.Join("\n• ", validationResult.Errors.Select(x => x.ErrorMessage));
                        MessageBox.Show(
                            $"Por favor corrija los siguientes errores:\n\n• {errores}",
                            "Validación de Datos",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    var result = await _createCategory.EjecurarAsync(request);

                    if (result.IsSuccess)
                    {
                        MessageBox.Show(
                            $"Categoría \"{nombre}\" creada exitosamente con ID #{result.Value}.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            result.Error ?? "Error al crear la categoría.",
                            "Error de Aplicación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var request = new EditarCategoriaRequest(_categoriaId, nombre, descripcion);
                    var validationResult = await _updateValidator.ValidateAsync(request);

                    if (!validationResult.IsValid)
                    {
                        foreach (var error in validationResult.Errors)
                        {
                            if (error.PropertyName.Contains("CategoryName", StringComparison.OrdinalIgnoreCase))
                                errorProvider.SetError(txtNombre, error.ErrorMessage);
                            else if (error.PropertyName.Contains("Description", StringComparison.OrdinalIgnoreCase))
                                errorProvider.SetError(txtDescripcion, error.ErrorMessage);
                        }

                        var errores = string.Join("\n• ", validationResult.Errors.Select(x => x.ErrorMessage));
                        MessageBox.Show(
                            $"Por favor corrija los siguientes errores:\n\n• {errores}",
                            "Validación de Datos",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    var result = await _updateCategory.EjecutarAsync(request);

                    if (result.IsSuccess)
                    {
                        MessageBox.Show(
                            $"Categoría \"{nombre}\" actualizada correctamente.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            result.Error ?? "Error al actualizar la categoría.",
                            "Error de Aplicación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error no controlado al guardar categoría");
                MessageBox.Show(
                    $"Error inesperado: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnGuardar.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtNombre, string.Empty);
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtDescripcion, string.Empty);
        }
    }
}
