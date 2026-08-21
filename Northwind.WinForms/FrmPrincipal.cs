using Microsoft.Extensions.DependencyInjection;
using Northwind.Application.DTOs;
using Northwind.Application.UseCases.Categorias;
using Northwind.Application.UseCases.Productos;
using Northwind.Application.UseCases.Suplidores;
using System.Globalization;

namespace Northwind.WinForms
{
    public partial class FrmPrincipal : Form
    {
        private static readonly Color ColorBotonActivo = Color.FromArgb(44, 78, 130);
        private static readonly Color ColorBotonInactivo = Color.FromArgb(238, 241, 247);
        private static readonly Color ColorTextoActivo = Color.White;
        private static readonly Color ColorTextoInactivo = Color.FromArgb(51, 65, 85);

        private readonly IServiceProvider _serviceProvider;
        private readonly GetAllCategories _getAllCategories;
        private readonly GetProducts _getProducts;
        private readonly GetSuppliers _getSuppliers;
        private readonly GetLowStockProducts _getLowStockProducts;

        private Control? _contenidoActual;
        private Button? _botonActivo;
        private string? _busquedaPendienteProductos;

        public FrmPrincipal(
            IServiceProvider serviceProvider,
            GetAllCategories getAllCategories,
            GetProducts getProducts,
            GetSuppliers getSuppliers,
            GetLowStockProducts getLowStockProducts)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _getAllCategories = getAllCategories;
            _getProducts = getProducts;
            _getSuppliers = getSuppliers;
            _getLowStockProducts = getLowStockProducts;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            var culturaEs = new CultureInfo("es-ES");
            lblFecha.Text = DateTime.Now.ToString("ddd, d MMM yyyy", culturaEs);

            MostrarInicio(btnNavInicio);
        }

        private void ActualizarEstadoConexion(bool conectado)
        {
            if (conectado)
            {
                lblConexion.Text = "●  Conectado · SQL Server";
                lblConexion.ForeColor = Color.FromArgb(74, 222, 128);
            }
            else
            {
                lblConexion.Text = "●  Sin conexión a la base de datos";
                lblConexion.ForeColor = Color.FromArgb(239, 68, 68);
            }
        }

        private async void lblNotificaciones_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = await _getLowStockProducts.EjecutarAsync();
                if (!resultado.IsSuccess || resultado.Value is null || !resultado.Value.Any())
                {
                    MessageBox.Show("No hay productos con stock bajo el nivel de reorden.", "Notificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var detalle = string.Join("\n", resultado.Value.Select(p => $"• {p.ProductName} — Stock: {p.UnitsInStock ?? 0} (Reorden: {p.ReorderLevel ?? 0})"));
                MessageBox.Show(detalle, "Productos con Stock Bajo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo consultar el stock bajo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarGlobal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.SuppressKeyPress = true;
            var texto = txtBuscarGlobal.Text.Trim();
            if (string.IsNullOrEmpty(texto))
                return;

            _busquedaPendienteProductos = texto;
            MostrarModulo("Productos", () => _serviceProvider.GetRequiredService<FrmProductoLista>(), btnNavProductos);
        }

        private void btnNavInicio_Click(object sender, EventArgs e) => MostrarInicio(btnNavInicio);

        private void btnNavCategorias_Click(object sender, EventArgs e) =>
            MostrarModulo("Categorías", () => _serviceProvider.GetRequiredService<FrmCategoriaLista>(), btnNavCategorias);

        private void btnNavProductos_Click(object sender, EventArgs e) =>
            MostrarModulo("Productos", () => _serviceProvider.GetRequiredService<FrmProductoLista>(), btnNavProductos);

        private void btnNavSuplidores_Click(object sender, EventArgs e) =>
            MostrarModulo("Suplidores", () => _serviceProvider.GetRequiredService<FrmSuplidorLista>(), btnNavSuplidores);

        private void btnNavIncremento_Click(object sender, EventArgs e) =>
            MostrarModulo("Incremento de Precios", () => _serviceProvider.GetRequiredService<FrmIncrementoPrecios>(), btnNavIncremento);

        private void btnNavReasignar_Click(object sender, EventArgs e) =>
            MostrarModulo("Reasignar Productos", () => _serviceProvider.GetRequiredService<FrmReasignarProductos>(), btnNavReasignar);

        private void btnNavReporte_Click(object sender, EventArgs e) =>
            MostrarModulo("Reporte de Inventario", () => _serviceProvider.GetRequiredService<FrmReporteInventario>(), btnNavReporte);

        private void btnNavSalir_Click(object sender, EventArgs e) => Close();

        private void MostrarInicio(Button botonNav)
        {
            MarcarBotonActivo(botonNav);
            lblSeccionActual.Text = "Dashboard";
            statusLabel.Text = "Listo";

            LimpiarContenido();

            var panelInicio = ConstruirPanelInicio();
            _contenidoActual = panelInicio;
            panelContent.Controls.Add(panelInicio);

            _ = CargarDashboardAsync(panelInicio);
        }

        private void MostrarModulo(string titulo, Func<Form> factory, Button botonNav)
        {
            MarcarBotonActivo(botonNav);
            lblSeccionActual.Text = titulo;
            statusLabel.Text = $"Mostrando: {titulo}";

            LimpiarContenido();

            var formulario = factory();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.FormClosing += (s, e) => e.Cancel = true;

            _contenidoActual = formulario;
            panelContent.Controls.Add(formulario);
            formulario.Show();

            if (formulario is FrmProductoLista productoLista && _busquedaPendienteProductos is not null)
            {
                productoLista.AplicarBusquedaExterna(_busquedaPendienteProductos);
                _busquedaPendienteProductos = null;
            }
        }

        private void LimpiarContenido()
        {
            panelContent.Controls.Clear();
            _contenidoActual?.Dispose();
            _contenidoActual = null;
        }

        private void MarcarBotonActivo(Button botonNav)
        {
            if (_botonActivo is not null)
            {
                _botonActivo.BackColor = ColorBotonInactivo;
                _botonActivo.ForeColor = ColorTextoInactivo;
                _botonActivo.Font = new Font(_botonActivo.Font, FontStyle.Regular);
            }

            botonNav.BackColor = ColorBotonActivo;
            botonNav.ForeColor = ColorTextoActivo;
            botonNav.Font = new Font(botonNav.Font, FontStyle.Bold);
            _botonActivo = botonNav;
        }

        // ----- Dashboard (Inicio) -----

        private Label _lblStatCategorias = null!;
        private Label _lblStatProductos = null!;
        private Label _lblStatSuplidores = null!;
        private Label _lblStatStockBajo = null!;
        private FlowLayoutPanel _flowTopPrecios = null!;

        private Panel ConstruirPanelInicio()
        {
            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(245, 247, 251),
                Padding = new Padding(28)
            };

            // Layout raíz: 3 filas, todas ajustadas al ancho disponible del panel de contenido.
            var raiz = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3,
                BackColor = Color.Transparent
            };
            raiz.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            raiz.RowStyles.Add(new RowStyle(SizeType.Absolute, 128));
            raiz.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            panel.Controls.Add(raiz);

            // --- Encabezado ---
            var encabezado = new TableLayoutPanel { AutoSize = true, ColumnCount = 1, Dock = DockStyle.Fill, Margin = new Padding(0, 0, 0, 18) };
            encabezado.Controls.Add(new Label
            {
                Text = "Panel Principal",
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Color.FromArgb(22, 26, 36),
                AutoSize = true,
                Margin = new Padding(0)
            });
            encabezado.Controls.Add(new Label
            {
                Text = "Resumen general del catálogo y accesos directos a los módulos.",
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(100, 116, 139),
                AutoSize = true,
                Margin = new Padding(0, 4, 0, 0)
            });
            raiz.Controls.Add(encabezado, 0, 0);

            // --- Fila de estadísticas: 4 columnas iguales que se reparten el ancho disponible ---
            var filaStats = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 4, RowCount = 1, Margin = new Padding(0, 0, 0, 18) };
            for (int i = 0; i < 4; i++)
                filaStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));
            filaStats.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            var stats = new (string Icono, string Titulo, Color Acento, Action<Label> Bind)[]
            {
                ("🏷️", "CATEGORÍAS", Color.FromArgb(44, 78, 130), l => _lblStatCategorias = l),
                ("📦", "PRODUCTOS", Color.FromArgb(31, 138, 95), l => _lblStatProductos = l),
                ("🚚", "SUPLIDORES", Color.FromArgb(193, 121, 31), l => _lblStatSuplidores = l),
                ("⚠️", "STOCK BAJO", Color.FromArgb(180, 83, 9), l => _lblStatStockBajo = l),
            };

            for (int i = 0; i < stats.Length; i++)
            {
                var (icono, titulo, acento, bind) = stats[i];
                var card = new Panel
                {
                    Dock = DockStyle.Fill,
                    Margin = new Padding(i == 0 ? 0 : 8, 0, i == stats.Length - 1 ? 0 : 8, 0),
                    BackColor = Color.White
                };
                card.Controls.Add(new Label { Text = icono, Font = new Font("Segoe UI", 16F), Location = new Point(18, 14), AutoSize = true });
                var lblValor = new Label { Text = "0", Font = new Font("Segoe UI", 24F, FontStyle.Bold), ForeColor = Color.FromArgb(22, 26, 36), Location = new Point(18, 48), AutoSize = true };
                card.Controls.Add(lblValor);
                card.Controls.Add(new Label { Text = titulo, Font = new Font("Segoe UI", 8.5F, FontStyle.Bold), ForeColor = acento, Location = new Point(18, 94), AutoSize = true });
                bind(lblValor);
                filaStats.Controls.Add(card, i, 0);
            }
            raiz.Controls.Add(filaStats, 0, 1);

            // --- Fila inferior: accesos rápidos (35%) + top de precios (65%), ambos Dock=Fill ---
            var filaInferior = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 1 };
            filaInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35));
            filaInferior.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65));
            filaInferior.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            var panelAccesos = new Panel { Dock = DockStyle.Fill, Margin = new Padding(0, 0, 8, 0), BackColor = Color.White, Padding = new Padding(20) };
            var accesosLayout = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1 };
            accesosLayout.Controls.Add(new Label
            {
                Text = "Accesos Rápidos",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(22, 26, 36),
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 12)
            });

            var accesos = new (string Texto, EventHandler Handler)[]
            {
                ("🏷️  Gestionar Categorías", btnNavCategorias_Click),
                ("📦  Gestionar Productos", btnNavProductos_Click),
                ("🚚  Gestionar Suplidores", btnNavSuplidores_Click),
                ("💲  Incremento de Precios", btnNavIncremento_Click),
                ("🔄  Reasignar Productos", btnNavReasignar_Click),
                ("📊  Ver Reportes", btnNavReporte_Click),
            };
            foreach (var (texto, handler) in accesos)
            {
                var link = new Button
                {
                    Text = texto,
                    Dock = DockStyle.Top,
                    Height = 40,
                    Margin = new Padding(0, 0, 0, 6),
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(248, 250, 252),
                    ForeColor = Color.FromArgb(30, 41, 59),
                    Font = new Font("Segoe UI", 9.75F),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(12, 0, 0, 0),
                    Cursor = Cursors.Hand
                };
                link.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
                link.Click += handler;
                accesosLayout.Controls.Add(link);
            }
            panelAccesos.Controls.Add(accesosLayout);

            var panelTopPrecios = new Panel { Dock = DockStyle.Fill, Margin = new Padding(8, 0, 0, 0), BackColor = Color.White, Padding = new Padding(20) };
            var topLayout = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 2 };
            topLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            topLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            topLayout.Controls.Add(new Label
            {
                Text = "Productos con Mayor Precio",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(22, 26, 36),
                AutoSize = true,
                Margin = new Padding(0, 0, 0, 10)
            }, 0, 0);

            _flowTopPrecios = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true
            };
            topLayout.Controls.Add(_flowTopPrecios, 0, 1);
            panelTopPrecios.Controls.Add(topLayout);

            filaInferior.Controls.Add(panelAccesos, 0, 0);
            filaInferior.Controls.Add(panelTopPrecios, 1, 0);
            raiz.Controls.Add(filaInferior, 0, 2);

            return panel;
        }

        private async Task CargarDashboardAsync(Panel panelInicio)
        {
            try
            {
                // Las consultas se ejecutan secuencialmente: el DbContext subyacente
                // no admite operaciones concurrentes sobre la misma instancia.
                var categorias = await _getAllCategories.EjecutarAsync();
                var productos = await _getProducts.EjecutarAsync();
                var suplidores = await _getSuppliers.EjecutarAsync();
                var stockBajo = await _getLowStockProducts.EjecutarAsync();

                if (!ReferenceEquals(_contenidoActual, panelInicio))
                    return; // el usuario navegó a otro módulo mientras se cargaba

                ActualizarEstadoConexion(categorias.IsSuccess);

                var cantidadStockBajo = stockBajo.IsSuccess ? stockBajo.Value?.Count() ?? 0 : 0;
                lblNotificaciones.Text = cantidadStockBajo > 0 ? $"🔔 {cantidadStockBajo}" : "🔔";

                if (categorias.IsSuccess)
                    _lblStatCategorias.Text = (categorias.Value?.Count() ?? 0).ToString();

                List<ProductoDto> listaProductos = new();
                if (productos.IsSuccess && productos.Value is not null)
                {
                    listaProductos = productos.Value.ToList();
                    _lblStatProductos.Text = listaProductos.Count.ToString();
                }

                if (suplidores.IsSuccess)
                    _lblStatSuplidores.Text = (suplidores.Value?.Count() ?? 0).ToString();

                if (stockBajo.IsSuccess)
                    _lblStatStockBajo.Text = (stockBajo.Value?.Count() ?? 0).ToString();

                _flowTopPrecios.Controls.Clear();
                var topProductos = listaProductos
                    .Where(p => p.UnitPrice.HasValue)
                    .OrderByDescending(p => p.UnitPrice)
                    .Take(8)
                    .ToList();

                if (topProductos.Count == 0)
                {
                    _flowTopPrecios.Controls.Add(new Label
                    {
                        Text = "No hay productos con precio registrado.",
                        Font = new Font("Segoe UI", 9.5F),
                        ForeColor = Color.FromArgb(100, 116, 139),
                        AutoSize = true
                    });
                }
                else
                {
                    int filaWidth = Math.Max(300, _flowTopPrecios.ClientSize.Width);
                    foreach (var p in topProductos)
                    {
                        var fila = new Panel { Width = filaWidth, Height = 34, Margin = new Padding(0, 0, 0, 4) };
                        var lblNombre = new Label
                        {
                            Text = p.ProductName,
                            Font = new Font("Segoe UI", 9.75F),
                            ForeColor = Color.FromArgb(30, 41, 59),
                            Location = new Point(0, 6),
                            AutoSize = true
                        };
                        var lblPrecio = new Label
                        {
                            Text = p.UnitPrice?.ToString("C2", CultureInfo.GetCultureInfo("en-US")),
                            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold),
                            ForeColor = Color.FromArgb(31, 138, 95),
                            Anchor = AnchorStyles.Top | AnchorStyles.Right,
                            AutoSize = true
                        };
                        lblPrecio.Location = new Point(fila.Width - lblPrecio.PreferredWidth - 4, 6);
                        fila.Controls.Add(lblPrecio);
                        fila.Controls.Add(lblNombre);
                        _flowTopPrecios.Controls.Add(fila);
                    }

                    _flowTopPrecios.Resize -= FlowTopPrecios_Resize;
                    _flowTopPrecios.Resize += FlowTopPrecios_Resize;
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"Error al cargar el dashboard: {ex.Message}";
                ActualizarEstadoConexion(false);
            }
        }

        private void FlowTopPrecios_Resize(object? sender, EventArgs e)
        {
            int filaWidth = Math.Max(300, _flowTopPrecios.ClientSize.Width);
            foreach (Control fila in _flowTopPrecios.Controls)
            {
                fila.Width = filaWidth;
                if (fila.Controls.Count > 0 && fila.Controls[0] is Label lblPrecio)
                {
                    lblPrecio.Location = new Point(fila.Width - lblPrecio.PreferredWidth - 4, lblPrecio.Location.Y);
                }
            }
        }
    }
}
