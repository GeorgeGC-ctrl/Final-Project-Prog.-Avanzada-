using Microsoft.Extensions.DependencyInjection;

namespace Northwind.WinForms
{
    public partial class FrmPrincipal : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public FrmPrincipal(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void AbrirFormularioHijo(Form formulario)
        {
            foreach (Form hijo in MdiChildren)
            {
                if (hijo.GetType() == formulario.GetType())
                {
                    hijo.Activate();
                    return;
                }
            }

            formulario.MdiParent = this;
            formulario.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormularioHijo(_serviceProvider.GetRequiredService<Form1>());
        }

        private void mnuInicio_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(_serviceProvider.GetRequiredService<Form1>());
        }

        private void mnuCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(_serviceProvider.GetRequiredService<FrmCategoriaLista>());
        }

        private void mnuSuplidores_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(_serviceProvider.GetRequiredService<FrmSuplidorLista>());
        }

        private void mnuIncrementoPrecios_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(_serviceProvider.GetRequiredService<FrmIncrementoPrecios>());
        }

        private void mnuReasignarProductos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(_serviceProvider.GetRequiredService<FrmReasignarProductos>());
        }

        private void mnuReporteInventario_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(_serviceProvider.GetRequiredService<FrmReporteInventario>());
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}