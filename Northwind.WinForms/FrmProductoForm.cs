using FluentValidation;
using Microsoft.Extensions.Logging;
using Northwind.Application.DTOs;
using Northwind.Application.UseCases.Categorias;
using Northwind.Application.UseCases.Productos;
using Northwind.Application.UseCases.Suplidores;

namespace Northwind.WinForms
{
    public partial class FrmProductoForm : Form
    {
        private readonly CreateProduct _createProduct;
        private readonly UpdateProduct _updateProduct;
        private readonly GetAllCategories _getAllCategories;
        private readonly GetSuppliers _getSuppliers;
        private readonly IValidator<CrearProductoRequest> _createValidator;
        private readonly IValidator<EditarProductoRequest> _updateValidator;
        private readonly ILogger<FrmProductoForm> _logger;

        private bool _isEditing;
        private int _productId;
        private int? _categoriaSeleccionada;
        private int? _suplidorSeleccionado;

        public FrmProductoForm(
            CreateProduct createProduct,
            UpdateProduct updateProduct,
            GetAllCategories getAllCategories,
            GetSuppliers getSuppliers,
            IValidator<CrearProductoRequest> createValidator,
            IValidator<EditarProductoRequest> updateValidator,
            ILogger<FrmProductoForm> logger)
        {
            InitializeComponent();
            _createProduct = createProduct;
            _updateProduct = updateProduct;
            _getAllCategories = getAllCategories;
            _getSuppliers = getSuppliers;
            _createValidator = createValidator;
            _updateValidator = updateValidator;
            _logger = logger;
        }

        public void PrepararCrear()
        {
            _isEditing = false;
            _productId = 0;
            _categoriaSeleccionada = null;
            _suplidorSeleccionado = null;

            lblTitulo.Text = "Nuevo Producto";
            lblSubtitulo.Text = "Complete la información para registrar un nuevo producto";
            btnGuardar.Text = "Crear Producto";
            this.Text = "Nuevo Producto";

            txtNombre.Clear();
            txtCantidadPorUnidad.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtEnOrden.Clear();
            txtReorden.Clear();
            chkDescontinuado.Checked = false;
            chkDescontinuado.Enabled = false;
            errorProvider.Clear();
        }

        public void PrepararEditar(ProductoDto producto)
        {
            _isEditing = true;
            _productId = producto.ProductId;
            _categoriaSeleccionada = producto.CategoryId;
            _suplidorSeleccionado = producto.SupplierId;

            lblTitulo.Text = $"Editar Producto #{producto.ProductId}";
            lblSubtitulo.Text = "Modifique los datos del producto seleccionado";
            btnGuardar.Text = "Guardar Cambios";
            this.Text = $"Editar Producto - #{producto.ProductId}";

            txtNombre.Text = producto.ProductName;
            txtCantidadPorUnidad.Text = producto.QuantityPerUnit ?? string.Empty;
            txtPrecio.Text = producto.UnitPrice?.ToString() ?? string.Empty;
            txtStock.Text = producto.UnitsInStock?.ToString() ?? string.Empty;
            txtEnOrden.Text = producto.UnitsOnOrder?.ToString() ?? string.Empty;
            txtReorden.Text = producto.ReorderLevel?.ToString() ?? string.Empty;
            chkDescontinuado.Checked = producto.Discontinued;
            chkDescontinuado.Enabled = true;
            errorProvider.Clear();
        }

        private async void FrmProductoForm_Load(object sender, EventArgs e)
        {
            await CargarListasAsync();
        }

        private async Task CargarListasAsync()
        {
            try
            {
                var categoriasResult = await _getAllCategories.EjecutarAsync();
                if (categoriasResult.IsSuccess && categoriasResult.Value is not null)
                {
                    var categorias = categoriasResult.Value.ToList();
                    cmbCategoria.DataSource = categorias;
                    cmbCategoria.DisplayMember = nameof(CategoriaDto.CategoryName);
                    cmbCategoria.ValueMember = nameof(CategoriaDto.CategoryId);
                    cmbCategoria.SelectedValue = _categoriaSeleccionada ?? 0;
                    if (_categoriaSeleccionada is null)
                        cmbCategoria.SelectedIndex = -1;
                }

                var suplidoresResult = await _getSuppliers.EjecutarAsync();
                if (suplidoresResult.IsSuccess && suplidoresResult.Value is not null)
                {
                    var suplidores = suplidoresResult.Value.ToList();
                    cmbSuplidor.DataSource = suplidores;
                    cmbSuplidor.DisplayMember = nameof(SuplidorDto.CompanyName);
                    cmbSuplidor.ValueMember = nameof(SuplidorDto.SupplierId);
                    cmbSuplidor.SelectedValue = _suplidorSeleccionado ?? 0;
                    if (_suplidorSeleccionado is null)
                        cmbSuplidor.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al cargar categorías/suplidores para el formulario de producto");
                MessageBox.Show(
                    $"Error al cargar listas de referencia: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            var nombre = txtNombre.Text.Trim();
            int? categoriaId = cmbCategoria.SelectedValue is int cId ? cId : null;
            int? suplidorId = cmbSuplidor.SelectedValue is int sId ? sId : null;
            var cantidadPorUnidad = string.IsNullOrWhiteSpace(txtCantidadPorUnidad.Text) ? null : txtCantidadPorUnidad.Text.Trim();

            if (!TryParseCampos(out var precio, out var stock, out var enOrden, out var reorden))
                return;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnGuardar.Enabled = false;

                if (!_isEditing)
                {
                    var request = new CrearProductoRequest(nombre, suplidorId, categoriaId, cantidadPorUnidad, precio, stock, enOrden, reorden);
                    var validationResult = await _createValidator.ValidateAsync(request);

                    if (!validationResult.IsValid)
                    {
                        MostrarErroresValidacion(validationResult.Errors);
                        return;
                    }

                    var result = await _createProduct.EjecutarAsync(request);

                    if (result.IsSuccess)
                    {
                        MessageBox.Show(
                            $"Producto \"{nombre}\" creado exitosamente con ID #{result.Value}.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            result.Error ?? "Error al crear el producto.",
                            "Error de Aplicación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    var request = new EditarProductoRequest(_productId, nombre, suplidorId, categoriaId, cantidadPorUnidad, precio, stock, enOrden, reorden, chkDescontinuado.Checked);
                    var validationResult = await _updateValidator.ValidateAsync(request);

                    if (!validationResult.IsValid)
                    {
                        MostrarErroresValidacion(validationResult.Errors);
                        return;
                    }

                    var result = await _updateProduct.EjecutarAsync(request);

                    if (result.IsSuccess)
                    {
                        MessageBox.Show(
                            $"Producto \"{nombre}\" actualizado correctamente.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            result.Error ?? "Error al actualizar el producto.",
                            "Error de Aplicación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error no controlado al guardar producto");
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

        private bool TryParseCampos(out decimal? precio, out short? stock, out short? enOrden, out short? reorden)
        {
            precio = null;
            stock = null;
            enOrden = null;
            reorden = null;
            bool esValido = true;

            if (!string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                if (decimal.TryParse(txtPrecio.Text.Trim(), out var precioValor))
                    precio = precioValor;
                else
                {
                    errorProvider.SetError(txtPrecio, "El precio debe ser un número válido.");
                    esValido = false;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtStock.Text))
            {
                if (short.TryParse(txtStock.Text.Trim(), out var stockValor))
                    stock = stockValor;
                else
                {
                    errorProvider.SetError(txtStock, "Las unidades en stock deben ser un número entero válido.");
                    esValido = false;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtEnOrden.Text))
            {
                if (short.TryParse(txtEnOrden.Text.Trim(), out var enOrdenValor))
                    enOrden = enOrdenValor;
                else
                {
                    errorProvider.SetError(txtEnOrden, "Las unidades en orden deben ser un número entero válido.");
                    esValido = false;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtReorden.Text))
            {
                if (short.TryParse(txtReorden.Text.Trim(), out var reordenValor))
                    reorden = reordenValor;
                else
                {
                    errorProvider.SetError(txtReorden, "El nivel de reorden debe ser un número entero válido.");
                    esValido = false;
                }
            }

            return esValido;
        }

        private void MostrarErroresValidacion(IEnumerable<FluentValidation.Results.ValidationFailure> errores)
        {
            foreach (var error in errores)
            {
                if (error.PropertyName.Contains("ProductName", StringComparison.OrdinalIgnoreCase))
                    errorProvider.SetError(txtNombre, error.ErrorMessage);
                else if (error.PropertyName.Contains("UnitPrice", StringComparison.OrdinalIgnoreCase))
                    errorProvider.SetError(txtPrecio, error.ErrorMessage);
                else if (error.PropertyName.Contains("UnitsInStock", StringComparison.OrdinalIgnoreCase))
                    errorProvider.SetError(txtStock, error.ErrorMessage);
            }

            var mensaje = string.Join("\n• ", errores.Select(x => x.ErrorMessage));
            MessageBox.Show(
                $"Por favor corrija los siguientes errores:\n\n• {mensaje}",
                "Validación de Datos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
