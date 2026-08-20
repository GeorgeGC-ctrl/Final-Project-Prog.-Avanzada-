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

        private FrmPrincipal? ObtenerFormularioPrincipal()
        {
            return TopLevelControl as FrmPrincipal ?? ParentForm as FrmPrincipal;
        }

        private void btnAccCategorias_Click(object sender, EventArgs e)
        {
            var principal = ObtenerFormularioPrincipal();
            if (principal != null)
            {
                principal.btnNavCategorias_Click(sender, e);
            }
            else
            {
                var form = _serviceProvider.GetRequiredService<FrmCategoriaLista>();
                form.ShowDialog();
            }
        }

        private void btnAccSuplidores_Click(object sender, EventArgs e)
        {
            var principal = ObtenerFormularioPrincipal();
            if (principal != null)
            {
                principal.btnNavSuplidores_Click(sender, e);
            }
            else
            {
                var form = _serviceProvider.GetRequiredService<FrmSuplidorLista>();
                form.ShowDialog();
            }
        }

        private void btnAccPrecios_Click(object sender, EventArgs e)
        {
            var principal = ObtenerFormularioPrincipal();
            if (principal != null)
            {
                principal.btnNavIncrementoPrecios_Click(sender, e);
            }
            else
            {
                var form = _serviceProvider.GetRequiredService<FrmIncrementoPrecios>();
                form.ShowDialog();
            }
        }

        private void btnAccReasignar_Click(object sender, EventArgs e)
        {
            var principal = ObtenerFormularioPrincipal();
            if (principal != null)
            {
                principal.btnNavReasignarProductos_Click(sender, e);
            }
            else
            {
                var form = _serviceProvider.GetRequiredService<FrmReasignarProductos>();
                form.ShowDialog();
            }
        }

        private void btnAccReporte_Click(object sender, EventArgs e)
        {
            var principal = ObtenerFormularioPrincipal();
            if (principal != null)
            {
                principal.btnNavReporteInventario_Click(sender, e);
            }
            else
            {
                var form = _serviceProvider.GetRequiredService<FrmReporteInventario>();
                form.ShowDialog();
            }
        }
    }
}
