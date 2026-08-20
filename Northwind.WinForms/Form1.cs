using Microsoft.Extensions.DependencyInjection;

namespace Northwind.WinForms
{
    public partial class Form1 : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public Form1(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void AbrirFormulario<T>() where T : Form
        {
            if (MdiParent is FrmPrincipal principal)
            {
                foreach (Form hijo in principal.MdiChildren)
                {
                    if (hijo is T)
                    {
                        hijo.Activate();
                        return;
                    }
                }

                var form = _serviceProvider.GetRequiredService<T>();
                form.MdiParent = principal;
                form.Show();
            }
            else
            {
                var form = _serviceProvider.GetRequiredService<T>();
                form.Show();
            }
        }

        private void btnAccCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmCategoriaLista>();
        }

        private void btnAccSuplidores_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmSuplidorLista>();
        }

        private void btnAccPrecios_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmIncrementoPrecios>();
        }

        private void btnAccReasignar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmReasignarProductos>();
        }

        private void btnAccReporte_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmReporteInventario>();
        }
    }
}
