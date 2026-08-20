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

        private void button1_Click(object sender, EventArgs e)
        {
            var frmCategorias = _serviceProvider.GetRequiredService<FrmCategoriaLista>();
            frmCategorias.ShowDialog(this);
        }
    }
}
