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
        private static readonly Color ColorBotonActivo = Color.FromArgb(99, 102, 241);
        private static readonly Color ColorBotonInactivo = Color.FromArgb(20, 23, 34);
        private static readonly Color ColorTextoActivo = Color.White;
        private static readonly Color ColorTextoInactivo = Color.FromArgb(226, 232, 240);

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
                BackColor = Color.FromArgb(244, 246, 251),
                AutoScroll = true,
                Padding = new Padding(32)
            };

            var lblBienvenida = new Label
            {
                Text = "Panel Principal",
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 23, 42),
                AutoSize = true,
                Location = new Point(32, 24)
            };

            var lblDescripcion = new Label
            {
                Text = "Resumen general del catálogo y accesos directos a los módulos.",
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(100, 116, 139),
                AutoSize = true,
                Location = new Point(32, 62)
            };

            var stats = new (string Icono, string Titulo, Color Acento, Action<Label> Bind)[]
            {
                ("🏷️", "CATEGORÍAS", Color.FromArgb(99, 102, 241), l => _lblStatCategorias = l),
                ("📦", "PRODUCTOS", Color.FromArgb(34, 197, 94), l => _lblStatProductos = l),
                ("🚚", "SUPLIDORES", Color.FromArgb(249, 115, 22), l => _lblStatSuplidores = l),
                ("⚠️", "STOCK BAJO", Color.FromArgb(239, 68, 68), l => _lblStatStockBajo = l),
            };

            int cardWidth = 250, cardHeight = 120, gap = 20, startX = 32, startY = 105;
            for (int i = 0; i < stats.Length; i++)
            {
                var (icono, titulo, acento, bind) = stats[i];
                var card = new Panel
                {
                    Location = new Point(startX + i * (cardWidth + gap), startY),
                    Size = new Size(cardWidth, cardHeight),
                    BackColor = Color.White
                };

                var lblIcono = new Label
                {
                    Text = icono,
                    Font = new Font("Segoe UI", 16F),
                    Location = new Point(16, 14),
                    AutoSize = true
                };

                var lblValor = new Label
                {
                    Text = "0",
                    Font = new Font("Segoe UI", 24F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(15, 23, 42),
                    Location = new Point(16, 48),
                    AutoSize = true
                };

                var lblTitulo = new Label
                {
                    Text = titulo,
                    Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                    ForeColor = acento,
                    Location = new Point(16, 92),
                    AutoSize = true
                };

                card.Controls.Add(lblTitulo);
                card.Controls.Add(lblValor);
                card.Controls.Add(lblIcono);
                bind(lblValor);
                panel.Controls.Add(card);
            }

            var panelAccesos = new Panel
            {
                Location = new Point(32, 245),
                Size = new Size(360, 340),
                BackColor = Color.White,
                Padding = new Padding(20)
            };
            var lblAccesosTitulo = new Label
            {
                Text = "Accesos Rápidos",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 23, 42),
                Location = new Point(20, 16),
                AutoSize = true
            };
            panelAccesos.Controls.Add(lblAccesosTitulo);

            var accesos = new (string Texto, EventHandler Handler)[]
            {
                ("🏷️  Gestionar Categorías", btnNavCategorias_Click),
                ("📦  Gestionar Productos", btnNavProductos_Click),
                ("🚚  Gestionar Suplidores", btnNavSuplidores_Click),
                ("💲  Incremento de Precios", btnNavIncremento_Click),
                ("🔄  Reasignar Productos", btnNavReasignar_Click),
                ("📊  Ver Reportes", btnNavReporte_Click),
            };

            int y = 58;
            foreach (var (texto, handler) in accesos)
            {
                var link = new Button
                {
                    Text = texto,
                    Location = new Point(20, y),
                    Size = new Size(320, 40),
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
                panelAccesos.Controls.Add(link);
                y += 46;
            }

            var panelTopPrecios = new Panel
            {
                Location = new Point(412, 245),
                Size = new Size(600, 340),
                BackColor = Color.White,
                Padding = new Padding(20)
            };
            var lblTopTitulo = new Label
            {
                Text = "Productos con Mayor Precio",
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 23, 42),
                Location = new Point(20, 16),
                AutoSize = true
            };

            _flowTopPrecios = new FlowLayoutPanel
            {
                Location = new Point(20, 56),
                Size = new Size(560, 264),
                FlowDirection = FlowDirection.TopDown,
                WrapContents = false,
                AutoScroll = true
            };

            panelTopPrecios.Controls.Add(_flowTopPrecios);
            panelTopPrecios.Controls.Add(lblTopTitulo);

            panel.Controls.Add(panelTopPrecios);
            panel.Controls.Add(panelAccesos);
            panel.Controls.Add(lblDescripcion);
            panel.Controls.Add(lblBienvenida);

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
                    foreach (var p in topProductos)
                    {
                        var fila = new Panel { Size = new Size(540, 34), Margin = new Padding(0, 0, 0, 4) };
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
                            ForeColor = Color.FromArgb(34, 197, 94),
                            Location = new Point(460, 6),
                            AutoSize = true
                        };
                        fila.Controls.Add(lblPrecio);
                        fila.Controls.Add(lblNombre);
                        _flowTopPrecios.Controls.Add(fila);
                    }
                }
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"Error al cargar el dashboard: {ex.Message}";
                ActualizarEstadoConexion(false);
            }
        }
    }
}
