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
        private readonly GetProducts _getProducts;
        private readonly IValidator<IncrementarPrecioCategoriaRequest> _validator;

        public FrmIncrementoPrecios(
            IncreasePricesByCategory incrementarPrecios,
            GetAllCategories getAllCategories,
            GetProducts getProducts,
            IValidator<IncrementarPrecioCategoriaRequest> validator)
        {
            InitializeComponent();
            _incrementarPrecios = incrementarPrecios;
            _getAllCategories = getAllCategories;
            _getProducts = getProducts;
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
                cmbCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedValue is not int categoriaId)
            {
                lblAfectados.Text = "Seleccione una categoría para ver los productos afectados.";
                return;
            }

            try
            {
                var productosResult = await _getProducts.EjecutarAsync(categoriaId: categoriaId);
                if (productosResult.IsSuccess && productosResult.Value is not null)
                {
                    var cantidad = productosResult.Value.Count();
                    lblAfectados.Text = cantidad == 1
                        ? "Se verá afectado 1 producto de esta categoría."
                        : $"Se verán afectados {cantidad} productos de esta categoría.";
                }
                else
                {
                    lblAfectados.Text = "No se pudo consultar los productos de la categoría.";
                }
            }
            catch
            {
                lblAfectados.Text = "Error al verificar productos de la categoría.";
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

            try
            {
                btnAplicar.Enabled = false;
                btnAplicar.Text = "Aplicando...";

                var resultado = await _incrementarPrecios.EjecutarAsync(request);
                if (!resultado.IsSuccess)
                {
                    MessageBox.Show(resultado.Error, "Incremento de Precios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Precios incrementados correctamente.", "Incremento de Precios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nudPorcentaje.Value = 10;
                cmbCategoria.SelectedIndex = -1;
            }
            finally
            {
                btnAplicar.Enabled = true;
                btnAplicar.Text = "Aplicar Incremento";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
