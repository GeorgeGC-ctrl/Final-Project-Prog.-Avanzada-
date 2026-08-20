namespace Northwind.WinForms
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            mnuInicio = new ToolStripMenuItem();
            mnuCatalogo = new ToolStripMenuItem();
            mnuCategorias = new ToolStripMenuItem();
            mnuSuplidores = new ToolStripMenuItem();
            mnuOperaciones = new ToolStripMenuItem();
            mnuIncrementoPrecios = new ToolStripMenuItem();
            mnuReasignarProductos = new ToolStripMenuItem();
            mnuReportes = new ToolStripMenuItem();
            mnuReporteInventario = new ToolStripMenuItem();
            mnuSalir = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            statusConn = new ToolStripStatusLabel();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = Color.White;
            menuStrip.Font = new Font("Segoe UI", 9.5F);
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuInicio, mnuCatalogo, mnuOperaciones, mnuReportes, mnuSalir });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(12, 6, 12, 6);
            menuStrip.Size = new Size(1300, 37);
            menuStrip.TabIndex = 0;
            // 
            // mnuInicio
            // 
            mnuInicio.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            mnuInicio.ForeColor = Color.FromArgb(44, 78, 130);
            mnuInicio.Name = "mnuInicio";
            mnuInicio.Size = new Size(97, 25);
            mnuInicio.Text = "Dashboard";
            mnuInicio.Click += mnuInicio_Click;
            // 
            // mnuCatalogo
            // 
            mnuCatalogo.DropDownItems.AddRange(new ToolStripItem[] { mnuCategorias, mnuSuplidores });
            mnuCatalogo.ForeColor = Color.FromArgb(22, 26, 36);
            mnuCatalogo.Name = "mnuCatalogo";
            mnuCatalogo.Size = new Size(84, 25);
            mnuCatalogo.Text = "Catálogo";
            // 
            // mnuCategorias
            // 
            mnuCategorias.Name = "mnuCategorias";
            mnuCategorias.Size = new Size(167, 26);
            mnuCategorias.Text = "Categorías";
            mnuCategorias.Click += mnuCategorias_Click;
            // 
            // mnuSuplidores
            // 
            mnuSuplidores.Name = "mnuSuplidores";
            mnuSuplidores.Size = new Size(167, 26);
            mnuSuplidores.Text = "Suplidores";
            mnuSuplidores.Click += mnuSuplidores_Click;
            // 
            // mnuOperaciones
            // 
            mnuOperaciones.DropDownItems.AddRange(new ToolStripItem[] { mnuIncrementoPrecios, mnuReasignarProductos });
            mnuOperaciones.ForeColor = Color.FromArgb(22, 26, 36);
            mnuOperaciones.Name = "mnuOperaciones";
            mnuOperaciones.Size = new Size(110, 25);
            mnuOperaciones.Text = "Operaciones";
            // 
            // mnuIncrementoPrecios
            // 
            mnuIncrementoPrecios.Name = "mnuIncrementoPrecios";
            mnuIncrementoPrecios.Size = new Size(238, 26);
            mnuIncrementoPrecios.Text = "Incremento de Precios";
            mnuIncrementoPrecios.Click += mnuIncrementoPrecios_Click;
            // 
            // mnuReasignarProductos
            // 
            mnuReasignarProductos.Name = "mnuReasignarProductos";
            mnuReasignarProductos.Size = new Size(238, 26);
            mnuReasignarProductos.Text = "Reasignar Productos";
            mnuReasignarProductos.Click += mnuReasignarProductos_Click;
            // 
            // mnuReportes
            // 
            mnuReportes.DropDownItems.AddRange(new ToolStripItem[] { mnuReporteInventario });
            mnuReportes.ForeColor = Color.FromArgb(22, 26, 36);
            mnuReportes.Name = "mnuReportes";
            mnuReportes.Size = new Size(85, 25);
            mnuReportes.Text = "Reportes";
            // 
            // mnuReporteInventario
            // 
            mnuReporteInventario.Name = "mnuReporteInventario";
            mnuReporteInventario.Size = new Size(318, 26);
            mnuReporteInventario.Text = "Valor de Inventario por Categoría";
            mnuReporteInventario.Click += mnuReporteInventario_Click;
            // 
            // mnuSalir
            // 
            mnuSalir.ForeColor = Color.FromArgb(192, 57, 43);
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new Size(53, 25);
            mnuSalir.Text = "Salir";
            mnuSalir.Click += mnuSalir_Click;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(238, 241, 247);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel, statusConn });
            statusStrip.Location = new Point(0, 774);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 19, 0);
            statusStrip.Size = new Size(1300, 26);
            statusStrip.TabIndex = 1;
            // 
            // statusLabel
            // 
            statusLabel.Font = new Font("Segoe UI", 9F);
            statusLabel.ForeColor = Color.FromArgb(91, 100, 116);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(198, 21);
            statusLabel.Text = "Northwind Manager — Listo";
            // 
            // statusConn
            // 
            statusConn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            statusConn.ForeColor = Color.FromArgb(31, 138, 95);
            statusConn.Name = "statusConn";
            statusConn.Size = new Size(1082, 21);
            statusConn.Spring = true;
            statusConn.Text = "● Conectado · SQL Server";
            statusConn.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(1300, 800);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Northwind — Sistema de Gestión";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem mnuInicio;
        private ToolStripMenuItem mnuCatalogo;
        private ToolStripMenuItem mnuCategorias;
        private ToolStripMenuItem mnuSuplidores;
        private ToolStripMenuItem mnuOperaciones;
        private ToolStripMenuItem mnuIncrementoPrecios;
        private ToolStripMenuItem mnuReasignarProductos;
        private ToolStripMenuItem mnuReportes;
        private ToolStripMenuItem mnuReporteInventario;
        private ToolStripMenuItem mnuSalir;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
        private ToolStripStatusLabel statusConn;
    }
}