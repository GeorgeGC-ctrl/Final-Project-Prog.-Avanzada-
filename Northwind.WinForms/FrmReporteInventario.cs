using Northwind.Application.DTOs;
using Northwind.Application.UseCases.Categorias;
using Northwind.Application.UseCases.Productos;
using System.Globalization;

namespace Northwind.WinForms
{
    public partial class FrmReporteInventario : Form
    {
        private readonly GetProducts _getProducts;
        private readonly GetAllCategories _getAllCategories;
        private bool _inicializando = true;
        private bool _cargandoReporte = false;

        public record FilaReporteInventario(
            string Categoria,
            int TotalProductos,
            int UnidadesEnStock,
            int UnidadesEnOrden,
            string ValorInventario);

        public FrmReporteInventario(GetProducts getProducts, GetAllCategories getAllCategories)
        {
            InitializeComponent();
            _getProducts = getProducts;
            _getAllCategories = getAllCategories;
        }

        private async void FrmReporteInventario_Load(object sender, EventArgs e)
        {
            try
            {
                _inicializando = true;
                await CargarFiltrosCategoriasAsync();
            }
            finally
            {
                _inicializando = false;
            }

            await CargarReporteAsync();
        }

        private async Task CargarFiltrosCategoriasAsync()
        {
            try
            {
                var result = await _getAllCategories.EjecutarAsync();
                if (!result.IsSuccess || result.Value == null)
                {
                    MessageBox.Show(result.Error ?? "Error al cargar categorías.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var categorias = new List<KeyValuePair<int?, string>>
                {
                    new KeyValuePair<int?, string>(null, "-- Todas las Categorías --")
                };

                categorias.AddRange(result.Value.Select(c => new KeyValuePair<int?, string>(c.CategoryId, c.CategoryName)));

                cmbCategorias.DataSource = categorias;
                cmbCategorias.DisplayMember = "Value";
                cmbCategorias.ValueMember = "Key";
                cmbCategorias.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar filtros de categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarReporteAsync()
        {
            if (_cargandoReporte)
                return;

            _cargandoReporte = true;

            try
            {
                btnGenerar.Enabled = false;
                btnGenerar.Text = "Cargando...";

                int? categoriaSeleccionada = null;
                if (cmbCategorias.SelectedValue is int catId)
                {
                    categoriaSeleccionada = catId;
                }
                else if (cmbCategorias.SelectedItem is KeyValuePair<int?, string> pair)
                {
                    categoriaSeleccionada = pair.Key;
                }

                var result = await _getProducts.EjecutarAsync(categoriaSeleccionada);
                if (!result.IsSuccess || result.Value == null)
                {
                    MessageBox.Show(result.Error ?? "Error al obtener datos del inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var productos = result.Value.ToList();

                var reporte = productos
                    .GroupBy(p => p.CategoryName ?? "Sin Categoría")
                    .Select(g => new
                    {
                        Categoria = g.Key,
                        TotalProductos = g.Count(),
                        UnidadesEnStock = g.Sum(p => (int)(p.UnitsInStock ?? 0)),
                        UnidadesEnOrden = g.Sum(p => (int)(p.UnitsOnOrder ?? 0)),
                        ValorInventarioDecimal = g.Sum(p => (p.UnitPrice ?? 0m) * (p.UnitsInStock ?? 0)),
                        ValorInventario = g.Sum(p => (p.UnitPrice ?? 0m) * (p.UnitsInStock ?? 0)).ToString("C2", CultureInfo.CurrentCulture)
                    })
                    .OrderByDescending(r => r.ValorInventarioDecimal)
                    .ToList();

                dgvReporte.DataSource = reporte.Select(r => new FilaReporteInventario(
                    r.Categoria,
                    r.TotalProductos,
                    r.UnidadesEnStock,
                    r.UnidadesEnOrden,
                    r.ValorInventario
                )).ToList();

                int totalProductos = productos.Count;
                int totalUnidades = productos.Sum(p => (int)(p.UnitsInStock ?? 0));
                decimal totalValor = productos.Sum(p => (p.UnitPrice ?? 0m) * (p.UnitsInStock ?? 0));

                lblTotalProductos.Text = totalProductos.ToString("N0");
                lblTotalUnidades.Text = totalUnidades.ToString("N0");
                lblTotalValor.Text = totalValor.ToString("C2", CultureInfo.CurrentCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte de inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _cargandoReporte = false;
                btnGenerar.Enabled = true;
                btnGenerar.Text = "Actualizar";
            }
        }

        private async void btnGenerar_Click(object sender, EventArgs e)
        {
            if (_inicializando)
                return;

            await CargarReporteAsync();
        }

        private async void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_inicializando)
                return;

            if (cmbCategorias.SelectedIndex >= 0)
            {
                await CargarReporteAsync();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
