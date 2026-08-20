using FluentValidation;
using Northwind.Application.DTOs;
using Northwind.Application.UseCases.Categorias;
using Northwind.Application.UseCases.Productos;

namespace Northwind.WinForms
{
    public partial class FrmIncrementoPrecios : Form
    {
        private readonly IncreasePricesByCategory _incrementarPrecios;
        private readonly GetAllCategories _getAllCategories;
        private readonly IValidator<IncrementarPrecioCategoriaRequest> _validator;

        public FrmIncrementoPrecios(
            IncreasePricesByCategory incrementarPrecios,
            GetAllCategories getAllCategories,
            IValidator<IncrementarPrecioCategoriaRequest> validator)
        {
            InitializeComponent();
            _incrementarPrecios = incrementarPrecios;
            _getAllCategories = getAllCategories;
            _validator = validator;
        }

        private async void FrmIncrementoPrecios_Load(object sender, EventArgs e)
        {
            await CargarCategoriasAsync();
        }

        private async Task CargarCategoriasAsync()
        {
            try
            {
                var resultado = await _getAllCategories.EjecutarAsync();
                if (!resultado.IsSuccess)
                {
                    MessageBox.Show(resultado.Error, "Categorías", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cmbCategoria.DataSource = resultado.Value?.ToList();
                cmbCategoria.DisplayMember = nameof(CategoriaDto.CategoryName);
                cmbCategoria.ValueMember = nameof(CategoriaDto.CategoryId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAplicar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (cmbCategoria.SelectedValue == null)
            {
                errorProvider.SetError(cmbCategoria, "Debe seleccionar una categoría.");
                return;
            }

            var request = new IncrementarPrecioCategoriaRequest(
                (int)cmbCategoria.SelectedValue,
                nudPorcentaje.Value);

            var validacion = _validator.Validate(request);
            if (!validacion.IsValid)
            {
                foreach (var error in validacion.Errors)
                {
                    if (error.PropertyName == nameof(request.CategoriaId))
                        errorProvider.SetError(cmbCategoria, error.ErrorMessage);
                    if (error.PropertyName == nameof(request.Porcentaje))
                        errorProvider.SetError(nudPorcentaje, error.ErrorMessage);
                }

                MessageBox.Show("Corrija los campos señalados.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resultado = await _incrementarPrecios.EjecutarAsync(request);
            if (!resultado.IsSuccess)
            {
                MessageBox.Show(resultado.Error, "Incremento de Precios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Precios incrementados correctamente.", "Incremento de Precios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nudPorcentaje.Value = nudPorcentaje.Minimum;
            cmbCategoria.SelectedIndex = -1;
        }
    }
}