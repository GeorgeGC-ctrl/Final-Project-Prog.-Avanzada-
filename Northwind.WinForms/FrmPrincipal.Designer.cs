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
            mnuOperaciones = new ToolStripMenuItem();
            mnuIncrementoPrecios = new ToolStripMenuItem();
            mnuSalir = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { mnuInicio, mnuOperaciones, mnuSalir });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1280, 33);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // mnuInicio
            // 
            mnuInicio.Name = "mnuInicio";
            mnuInicio.Size = new Size(83, 29);
            mnuInicio.Text = "Inicio";
            mnuInicio.Click += mnuInicio_Click;
            // 
            // mnuOperaciones
            // 
            mnuOperaciones.DropDownItems.AddRange(new ToolStripItem[] { mnuIncrementoPrecios });
            mnuOperaciones.Name = "mnuOperaciones";
            mnuOperaciones.Size = new Size(127, 29);
            mnuOperaciones.Text = "Operaciones";
            // 
            // mnuIncrementoPrecios
            // 
            mnuIncrementoPrecios.Name = "mnuIncrementoPrecios";
            mnuIncrementoPrecios.Size = new Size(270, 34);
            mnuIncrementoPrecios.Text = "Incremento de Precios";
            mnuIncrementoPrecios.Click += mnuIncrementoPrecios_Click;
            // 
            // mnuSalir
            // 
            mnuSalir.Name = "mnuSalir";
            mnuSalir.Size = new Size(74, 29);
            mnuSalir.Text = "Salir";
            mnuSalir.Click += mnuSalir_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip.Location = new Point(0, 768);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1280, 32);
            statusStrip.TabIndex = 1;
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(60, 25);
            statusLabel.Text = "Listo";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 800);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "FrmPrincipal";
            Text = "Northwind Manager - Principal";
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
        private ToolStripMenuItem mnuOperaciones;
        private ToolStripMenuItem mnuIncrementoPrecios;
        private ToolStripMenuItem mnuSalir;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
    }
}