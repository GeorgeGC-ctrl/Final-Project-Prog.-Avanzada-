using Microsoft.Extensions.DependencyInjection;

namespace Northwind.WinForms
{
    public partial class FrmPrincipal : Form
    {
        private static readonly Color ColorBotonActivo = Color.FromArgb(99, 102, 241);
        private static readonly Color ColorBotonInactivo = Color.FromArgb(20, 23, 34);
        private static readonly Color ColorTextoActivo = Color.White;
        private static readonly Color ColorTextoInactivo = Color.FromArgb(226, 232, 240);

        private readonly IServiceProvider _serviceProvider;
        private Control? _contenidoActual;
        private Button? _botonActivo;

        public FrmPrincipal(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MostrarInicio(btnNavInicio);
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
            lblSeccionActual.Text = "Inicio";
            statusLabel.Text = "Listo";

            LimpiarContenido();

            var panelInicio = ConstruirPanelInicio();
            _contenidoActual = panelInicio;
            panelContent.Controls.Add(panelInicio);
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

        private Panel ConstruirPanelInicio()
        {
            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(21, 24, 34),
                Padding = new Padding(40)
            };

            var lblBienvenida = new Label
            {
                Text = "Bienvenido a Northwind Manager",
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(40, 40)
            };

            var lblDescripcion = new Label
            {
                Text = "Seleccione una opción del menú lateral para comenzar a administrar categorías, productos y suplidores.",
                Font = new Font("Segoe UI", 10.5F),
                ForeColor = Color.FromArgb(148, 163, 184),
                AutoSize = true,
                Location = new Point(40, 85)
            };

            var accesos = new (string Texto, EventHandler Handler)[]
            {
                ("📂  Categorías", btnNavCategorias_Click),
                ("📦  Productos", btnNavProductos_Click),
                ("🏭  Suplidores", btnNavSuplidores_Click),
                ("💲  Incremento de Precios", btnNavIncremento_Click),
                ("🔄  Reasignar Productos", btnNavReasignar_Click),
                ("📊  Reporte de Inventario", btnNavReporte_Click),
            };

            var flow = new FlowLayoutPanel
            {
                Location = new Point(40, 135),
                Size = new Size(1000, 260),
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                AutoScroll = true
            };

            foreach (var (texto, handler) in accesos)
            {
                var card = new Button
                {
                    Text = texto,
                    Size = new Size(230, 90),
                    Margin = new Padding(0, 0, 20, 20),
                    BackColor = Color.FromArgb(33, 37, 58),
                    ForeColor = Color.FromArgb(226, 232, 240),
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    FlatStyle = FlatStyle.Flat,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Cursor = Cursors.Hand
                };
                card.FlatAppearance.BorderColor = Color.FromArgb(46, 51, 80);
                card.FlatAppearance.BorderSize = 1;
                card.Click += handler;
                flow.Controls.Add(card);
            }

            panel.Controls.Add(flow);
            panel.Controls.Add(lblDescripcion);
            panel.Controls.Add(lblBienvenida);

            return panel;
        }
    }
}
