using Microsoft.Extensions.DependencyInjection;

namespace Northwind.WinForms
{
    public partial class FrmPrincipal : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private Form? _formularioActual;
        private Button? _botonActivo;

        private readonly Color ColorActivo = Color.FromArgb(44, 78, 130);
        private readonly Color ColorTextoActivo = Color.White;
        private readonly Color ColorInactivo = Color.Transparent;
        private readonly Color ColorTextoInactivo = Color.FromArgb(91, 100, 116);

        public FrmPrincipal(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            NavegarA<Form1>(btnNavDashboard, "Dashboard", "Resumen general del catálogo y accesos rápidos");
        }

        public void NavegarA<T>(Button botonMenu, string titulo, string descripcion) where T : Form
        {
            ResaltarBoton(botonMenu);
            lblPageTitle.Text = titulo;
            lblPageDescription.Text = descripcion;

            if (_formularioActual is T)
                return;

            if (_formularioActual != null)
            {
                panelContenido.Controls.Remove(_formularioActual);
                _formularioActual.Dispose();
                _formularioActual = null;
            }

            var nuevoFormulario = _serviceProvider.GetRequiredService<T>();
            _formularioActual = nuevoFormulario;

            nuevoFormulario.TopLevel = false;
            nuevoFormulario.FormBorderStyle = FormBorderStyle.None;
            nuevoFormulario.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(nuevoFormulario);
            panelContenido.Tag = nuevoFormulario;
            nuevoFormulario.Show();
            nuevoFormulario.BringToFront();
        }

        private void ResaltarBoton(Button botonSeleccionado)
        {
            var botones = new[]
            {
                btnNavDashboard,
                btnNavCategorias,
                btnNavSuplidores,
                btnNavIncrementoPrecios,
                btnNavReasignarProductos,
                btnNavReporteInventario
            };

            foreach (var btn in botones)
            {
                if (btn == botonSeleccionado)
                {
                    btn.BackColor = ColorActivo;
                    btn.ForeColor = ColorTextoActivo;
                    btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                }
                else
                {
                    btn.BackColor = ColorInactivo;
                    btn.ForeColor = ColorTextoInactivo;
                    btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                }
            }

            _botonActivo = botonSeleccionado;
        }

        internal void btnNavDashboard_Click(object sender, EventArgs e)
        {
            NavegarA<Form1>(btnNavDashboard, "Dashboard", "Resumen general del catálogo y accesos rápidos");
        }

        internal void btnNavCategorias_Click(object sender, EventArgs e)
        {
            NavegarA<FrmCategoriaLista>(btnNavCategorias, "Gestión de Categorías", "Clasificación y catálogo de categorías");
        }

        internal void btnNavSuplidores_Click(object sender, EventArgs e)
        {
            NavegarA<FrmSuplidorLista>(btnNavSuplidores, "Gestión de Suplidores", "Administración de proveedores y contactos");
        }

        internal void btnNavIncrementoPrecios_Click(object sender, EventArgs e)
        {
            NavegarA<FrmIncrementoPrecios>(btnNavIncrementoPrecios, "Incremento de Precios", "Ajuste porcentual de precios por categoría");
        }

        internal void btnNavReasignarProductos_Click(object sender, EventArgs e)
        {
            NavegarA<FrmReasignarProductos>(btnNavReasignarProductos, "Reasignar Productos", "Transferencia de catálogo entre suplidores");
        }

        internal void btnNavReporteInventario_Click(object sender, EventArgs e)
        {
            NavegarA<FrmReporteInventario>(btnNavReporteInventario, "Reporte de Inventario", "Análisis de valorización y existencias");
        }

        private void btnNavSalir_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show(
                "¿Está seguro de que desea salir del sistema Northwind Manager?",
                "Confirmación de Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}