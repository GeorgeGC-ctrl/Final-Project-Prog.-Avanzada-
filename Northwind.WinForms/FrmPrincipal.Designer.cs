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
            panelSidebar = new Panel();
            btnNavSalir = new Button();
            btnNavReporte = new Button();
            btnNavReasignar = new Button();
            btnNavIncremento = new Button();
            btnNavSuplidores = new Button();
            btnNavProductos = new Button();
            btnNavCategorias = new Button();
            btnNavInicio = new Button();
            panelSidebarHeader = new Panel();
            lblLogoSubtitulo = new Label();
            lblLogoTitulo = new Label();
            panelTopbar = new Panel();
            lblUsuario = new Label();
            lblSeccionActual = new Label();
            panelContent = new Panel();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            panelSidebar.SuspendLayout();
            panelSidebarHeader.SuspendLayout();
            panelTopbar.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            //
            // panelSidebar
            //
            panelSidebar.BackColor = Color.FromArgb(20, 23, 34);
            panelSidebar.Controls.Add(btnNavSalir);
            panelSidebar.Controls.Add(btnNavReporte);
            panelSidebar.Controls.Add(btnNavReasignar);
            panelSidebar.Controls.Add(btnNavIncremento);
            panelSidebar.Controls.Add(btnNavSuplidores);
            panelSidebar.Controls.Add(btnNavProductos);
            panelSidebar.Controls.Add(btnNavCategorias);
            panelSidebar.Controls.Add(btnNavInicio);
            panelSidebar.Controls.Add(panelSidebarHeader);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(240, 800);
            panelSidebar.TabIndex = 0;
            //
            // panelSidebarHeader
            //
            panelSidebarHeader.BackColor = Color.FromArgb(15, 17, 23);
            panelSidebarHeader.Controls.Add(lblLogoSubtitulo);
            panelSidebarHeader.Controls.Add(lblLogoTitulo);
            panelSidebarHeader.Dock = DockStyle.Top;
            panelSidebarHeader.Location = new Point(0, 0);
            panelSidebarHeader.Name = "panelSidebarHeader";
            panelSidebarHeader.Padding = new Padding(20, 18, 20, 15);
            panelSidebarHeader.Size = new Size(240, 90);
            panelSidebarHeader.TabIndex = 0;
            //
            // lblLogoSubtitulo
            //
            lblLogoSubtitulo.AutoSize = true;
            lblLogoSubtitulo.Font = new Font("Segoe UI", 8.5F);
            lblLogoSubtitulo.ForeColor = Color.FromArgb(129, 140, 248);
            lblLogoSubtitulo.Location = new Point(20, 48);
            lblLogoSubtitulo.Name = "lblLogoSubtitulo";
            lblLogoSubtitulo.Size = new Size(140, 19);
            lblLogoSubtitulo.TabIndex = 1;
            lblLogoSubtitulo.Text = "Sistema de Gestión";
            //
            // lblLogoTitulo
            //
            lblLogoTitulo.AutoSize = true;
            lblLogoTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLogoTitulo.ForeColor = Color.White;
            lblLogoTitulo.Location = new Point(18, 16);
            lblLogoTitulo.Name = "lblLogoTitulo";
            lblLogoTitulo.Size = new Size(180, 32);
            lblLogoTitulo.TabIndex = 0;
            lblLogoTitulo.Text = "🌐 Northwind";
            //
            // btnNavInicio
            //
            btnNavInicio.BackColor = Color.FromArgb(20, 23, 34);
            btnNavInicio.Cursor = Cursors.Hand;
            btnNavInicio.FlatAppearance.BorderSize = 0;
            btnNavInicio.FlatStyle = FlatStyle.Flat;
            btnNavInicio.Font = new Font("Segoe UI", 10.5F);
            btnNavInicio.ForeColor = Color.FromArgb(226, 232, 240);
            btnNavInicio.Location = new Point(0, 100);
            btnNavInicio.Name = "btnNavInicio";
            btnNavInicio.Padding = new Padding(24, 0, 0, 0);
            btnNavInicio.Size = new Size(240, 48);
            btnNavInicio.TabIndex = 1;
            btnNavInicio.Text = "🏠   Inicio";
            btnNavInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnNavInicio.UseVisualStyleBackColor = false;
            btnNavInicio.Click += btnNavInicio_Click;
            //
            // btnNavCategorias
            //
            btnNavCategorias.BackColor = Color.FromArgb(20, 23, 34);
            btnNavCategorias.Cursor = Cursors.Hand;
            btnNavCategorias.FlatAppearance.BorderSize = 0;
            btnNavCategorias.FlatStyle = FlatStyle.Flat;
            btnNavCategorias.Font = new Font("Segoe UI", 10.5F);
            btnNavCategorias.ForeColor = Color.FromArgb(226, 232, 240);
            btnNavCategorias.Location = new Point(0, 148);
            btnNavCategorias.Name = "btnNavCategorias";
            btnNavCategorias.Padding = new Padding(24, 0, 0, 0);
            btnNavCategorias.Size = new Size(240, 48);
            btnNavCategorias.TabIndex = 2;
            btnNavCategorias.Text = "📂   Categorías";
            btnNavCategorias.TextAlign = ContentAlignment.MiddleLeft;
            btnNavCategorias.UseVisualStyleBackColor = false;
            btnNavCategorias.Click += btnNavCategorias_Click;
            //
            // btnNavProductos
            //
            btnNavProductos.BackColor = Color.FromArgb(20, 23, 34);
            btnNavProductos.Cursor = Cursors.Hand;
            btnNavProductos.FlatAppearance.BorderSize = 0;
            btnNavProductos.FlatStyle = FlatStyle.Flat;
            btnNavProductos.Font = new Font("Segoe UI", 10.5F);
            btnNavProductos.ForeColor = Color.FromArgb(226, 232, 240);
            btnNavProductos.Location = new Point(0, 196);
            btnNavProductos.Name = "btnNavProductos";
            btnNavProductos.Padding = new Padding(24, 0, 0, 0);
            btnNavProductos.Size = new Size(240, 48);
            btnNavProductos.TabIndex = 3;
            btnNavProductos.Text = "📦   Productos";
            btnNavProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnNavProductos.UseVisualStyleBackColor = false;
            btnNavProductos.Click += btnNavProductos_Click;
            //
            // btnNavSuplidores
            //
            btnNavSuplidores.BackColor = Color.FromArgb(20, 23, 34);
            btnNavSuplidores.Cursor = Cursors.Hand;
            btnNavSuplidores.FlatAppearance.BorderSize = 0;
            btnNavSuplidores.FlatStyle = FlatStyle.Flat;
            btnNavSuplidores.Font = new Font("Segoe UI", 10.5F);
            btnNavSuplidores.ForeColor = Color.FromArgb(226, 232, 240);
            btnNavSuplidores.Location = new Point(0, 244);
            btnNavSuplidores.Name = "btnNavSuplidores";
            btnNavSuplidores.Padding = new Padding(24, 0, 0, 0);
            btnNavSuplidores.Size = new Size(240, 48);
            btnNavSuplidores.TabIndex = 4;
            btnNavSuplidores.Text = "🏭   Suplidores";
            btnNavSuplidores.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSuplidores.UseVisualStyleBackColor = false;
            btnNavSuplidores.Click += btnNavSuplidores_Click;
            //
            // btnNavIncremento
            //
            btnNavIncremento.BackColor = Color.FromArgb(20, 23, 34);
            btnNavIncremento.Cursor = Cursors.Hand;
            btnNavIncremento.FlatAppearance.BorderSize = 0;
            btnNavIncremento.FlatStyle = FlatStyle.Flat;
            btnNavIncremento.Font = new Font("Segoe UI", 10.5F);
            btnNavIncremento.ForeColor = Color.FromArgb(226, 232, 240);
            btnNavIncremento.Location = new Point(0, 292);
            btnNavIncremento.Name = "btnNavIncremento";
            btnNavIncremento.Padding = new Padding(24, 0, 0, 0);
            btnNavIncremento.Size = new Size(240, 48);
            btnNavIncremento.TabIndex = 5;
            btnNavIncremento.Text = "💲   Incremento de Precios";
            btnNavIncremento.TextAlign = ContentAlignment.MiddleLeft;
            btnNavIncremento.UseVisualStyleBackColor = false;
            btnNavIncremento.Click += btnNavIncremento_Click;
            //
            // btnNavReasignar
            //
            btnNavReasignar.BackColor = Color.FromArgb(20, 23, 34);
            btnNavReasignar.Cursor = Cursors.Hand;
            btnNavReasignar.FlatAppearance.BorderSize = 0;
            btnNavReasignar.FlatStyle = FlatStyle.Flat;
            btnNavReasignar.Font = new Font("Segoe UI", 10.5F);
            btnNavReasignar.ForeColor = Color.FromArgb(226, 232, 240);
            btnNavReasignar.Location = new Point(0, 340);
            btnNavReasignar.Name = "btnNavReasignar";
            btnNavReasignar.Padding = new Padding(24, 0, 0, 0);
            btnNavReasignar.Size = new Size(240, 48);
            btnNavReasignar.TabIndex = 6;
            btnNavReasignar.Text = "🔄   Reasignar Productos";
            btnNavReasignar.TextAlign = ContentAlignment.MiddleLeft;
            btnNavReasignar.UseVisualStyleBackColor = false;
            btnNavReasignar.Click += btnNavReasignar_Click;
            //
            // btnNavReporte
            //
            btnNavReporte.BackColor = Color.FromArgb(20, 23, 34);
            btnNavReporte.Cursor = Cursors.Hand;
            btnNavReporte.FlatAppearance.BorderSize = 0;
            btnNavReporte.FlatStyle = FlatStyle.Flat;
            btnNavReporte.Font = new Font("Segoe UI", 10.5F);
            btnNavReporte.ForeColor = Color.FromArgb(226, 232, 240);
            btnNavReporte.Location = new Point(0, 388);
            btnNavReporte.Name = "btnNavReporte";
            btnNavReporte.Padding = new Padding(24, 0, 0, 0);
            btnNavReporte.Size = new Size(240, 48);
            btnNavReporte.TabIndex = 7;
            btnNavReporte.Text = "📊   Reporte de Inventario";
            btnNavReporte.TextAlign = ContentAlignment.MiddleLeft;
            btnNavReporte.UseVisualStyleBackColor = false;
            btnNavReporte.Click += btnNavReporte_Click;
            //
            // btnNavSalir
            //
            btnNavSalir.BackColor = Color.FromArgb(20, 23, 34);
            btnNavSalir.Cursor = Cursors.Hand;
            btnNavSalir.Dock = DockStyle.Bottom;
            btnNavSalir.FlatAppearance.BorderSize = 0;
            btnNavSalir.Font = new Font("Segoe UI", 10.5F);
            btnNavSalir.FlatStyle = FlatStyle.Flat;
            btnNavSalir.ForeColor = Color.FromArgb(148, 163, 184);
            btnNavSalir.Location = new Point(0, 744);
            btnNavSalir.Name = "btnNavSalir";
            btnNavSalir.Padding = new Padding(24, 0, 0, 0);
            btnNavSalir.Size = new Size(240, 56);
            btnNavSalir.TabIndex = 8;
            btnNavSalir.Text = "🚪   Salir";
            btnNavSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSalir.UseVisualStyleBackColor = false;
            btnNavSalir.Click += btnNavSalir_Click;
            //
            // panelTopbar
            //
            panelTopbar.BackColor = Color.FromArgb(26, 29, 39);
            panelTopbar.Controls.Add(lblUsuario);
            panelTopbar.Controls.Add(lblSeccionActual);
            panelTopbar.Dock = DockStyle.Top;
            panelTopbar.Location = new Point(240, 0);
            panelTopbar.Name = "panelTopbar";
            panelTopbar.Padding = new Padding(28, 0, 28, 0);
            panelTopbar.Size = new Size(1160, 64);
            panelTopbar.TabIndex = 1;
            //
            // lblSeccionActual
            //
            lblSeccionActual.AutoSize = true;
            lblSeccionActual.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblSeccionActual.ForeColor = Color.FromArgb(226, 232, 240);
            lblSeccionActual.Location = new Point(28, 18);
            lblSeccionActual.Name = "lblSeccionActual";
            lblSeccionActual.Size = new Size(80, 28);
            lblSeccionActual.TabIndex = 0;
            lblSeccionActual.Text = "Inicio";
            //
            // lblUsuario
            //
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9.5F);
            lblUsuario.ForeColor = Color.FromArgb(148, 163, 184);
            lblUsuario.Location = new Point(956, 22);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(176, 21);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "👤  Northwind Manager";
            //
            // panelContent
            //
            panelContent.BackColor = Color.FromArgb(21, 24, 34);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(240, 64);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(0);
            panelContent.Size = new Size(1160, 704);
            panelContent.TabIndex = 2;
            //
            // statusStrip
            //
            statusStrip.BackColor = Color.FromArgb(26, 29, 39);
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip.Location = new Point(240, 768);
            statusStrip.Name = "statusStrip";
            statusStrip.SizingGrip = false;
            statusStrip.Size = new Size(1160, 32);
            statusStrip.TabIndex = 3;
            //
            // statusLabel
            //
            statusLabel.ForeColor = Color.FromArgb(148, 163, 184);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(60, 25);
            statusLabel.Text = "Listo";
            //
            // FrmPrincipal
            //
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 24, 34);
            ClientSize = new Size(1400, 800);
            Controls.Add(panelContent);
            Controls.Add(statusStrip);
            Controls.Add(panelTopbar);
            Controls.Add(panelSidebar);
            MinimumSize = new Size(1100, 700);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Northwind Manager";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebarHeader.ResumeLayout(false);
            panelSidebarHeader.PerformLayout();
            panelTopbar.ResumeLayout(false);
            panelTopbar.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelSidebarHeader;
        private Label lblLogoTitulo;
        private Label lblLogoSubtitulo;
        private Button btnNavInicio;
        private Button btnNavCategorias;
        private Button btnNavProductos;
        private Button btnNavSuplidores;
        private Button btnNavIncremento;
        private Button btnNavReasignar;
        private Button btnNavReporte;
        private Button btnNavSalir;
        private Panel panelTopbar;
        private Label lblSeccionActual;
        private Label lblUsuario;
        private Panel panelContent;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
    }
}
