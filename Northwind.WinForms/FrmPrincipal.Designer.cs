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
            lblSeccionOperaciones = new Label();
            btnNavSuplidores = new Button();
            btnNavProductos = new Button();
            btnNavCategorias = new Button();
            lblSeccionCatalogo = new Label();
            btnNavInicio = new Button();
            lblSeccionPrincipal = new Label();
            lblConexion = new Label();
            panelSidebarHeader = new Panel();
            lblLogoSubtitulo = new Label();
            lblLogoTitulo = new Label();
            panelTopbar = new Panel();
            txtBuscarGlobal = new TextBox();
            lblSeccionActual = new Label();
            panelTopbarRight = new Panel();
            lblUsuario = new Label();
            lblNotificaciones = new Label();
            lblFecha = new Label();
            panelContent = new Panel();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            panelSidebar.SuspendLayout();
            panelSidebarHeader.SuspendLayout();
            panelTopbar.SuspendLayout();
            panelTopbarRight.SuspendLayout();
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
            panelSidebar.Controls.Add(lblSeccionOperaciones);
            panelSidebar.Controls.Add(btnNavSuplidores);
            panelSidebar.Controls.Add(btnNavProductos);
            panelSidebar.Controls.Add(btnNavCategorias);
            panelSidebar.Controls.Add(lblSeccionCatalogo);
            panelSidebar.Controls.Add(btnNavInicio);
            panelSidebar.Controls.Add(lblSeccionPrincipal);
            panelSidebar.Controls.Add(lblConexion);
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
            panelSidebarHeader.Size = new Size(240, 80);
            panelSidebarHeader.TabIndex = 0;
            //
            // lblLogoSubtitulo
            //
            lblLogoSubtitulo.AutoSize = true;
            lblLogoSubtitulo.Font = new Font("Segoe UI", 8.5F);
            lblLogoSubtitulo.ForeColor = Color.FromArgb(129, 140, 248);
            lblLogoSubtitulo.Location = new Point(20, 46);
            lblLogoSubtitulo.Name = "lblLogoSubtitulo";
            lblLogoSubtitulo.Size = new Size(140, 19);
            lblLogoSubtitulo.TabIndex = 1;
            lblLogoSubtitulo.Text = "SISTEMA · GESTIÓN";
            //
            // lblLogoTitulo
            //
            lblLogoTitulo.AutoSize = true;
            lblLogoTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLogoTitulo.ForeColor = Color.White;
            lblLogoTitulo.Location = new Point(18, 14);
            lblLogoTitulo.Name = "lblLogoTitulo";
            lblLogoTitulo.Size = new Size(180, 32);
            lblLogoTitulo.TabIndex = 0;
            lblLogoTitulo.Text = "🏢 Northwind";
            //
            // lblConexion
            //
            lblConexion.AutoSize = true;
            lblConexion.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblConexion.ForeColor = Color.FromArgb(100, 116, 139);
            lblConexion.Location = new Point(20, 92);
            lblConexion.Name = "lblConexion";
            lblConexion.Size = new Size(160, 19);
            lblConexion.TabIndex = 1;
            lblConexion.Text = "●  Verificando conexión...";
            //
            // lblSeccionPrincipal
            //
            lblSeccionPrincipal.AutoSize = true;
            lblSeccionPrincipal.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSeccionPrincipal.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionPrincipal.Location = new Point(24, 128);
            lblSeccionPrincipal.Name = "lblSeccionPrincipal";
            lblSeccionPrincipal.Size = new Size(80, 19);
            lblSeccionPrincipal.TabIndex = 2;
            lblSeccionPrincipal.Text = "PRINCIPAL";
            //
            // btnNavInicio
            //
            btnNavInicio.BackColor = Color.FromArgb(20, 23, 34);
            btnNavInicio.Cursor = Cursors.Hand;
            btnNavInicio.FlatAppearance.BorderSize = 0;
            btnNavInicio.FlatStyle = FlatStyle.Flat;
            btnNavInicio.Font = new Font("Segoe UI", 10.5F);
            btnNavInicio.ForeColor = Color.FromArgb(226, 232, 240);
            btnNavInicio.Location = new Point(0, 152);
            btnNavInicio.Name = "btnNavInicio";
            btnNavInicio.Padding = new Padding(24, 0, 0, 0);
            btnNavInicio.Size = new Size(240, 44);
            btnNavInicio.TabIndex = 3;
            btnNavInicio.Text = "🏠   Dashboard";
            btnNavInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnNavInicio.UseVisualStyleBackColor = false;
            btnNavInicio.Click += btnNavInicio_Click;
            //
            // lblSeccionCatalogo
            //
            lblSeccionCatalogo.AutoSize = true;
            lblSeccionCatalogo.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSeccionCatalogo.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionCatalogo.Location = new Point(24, 204);
            lblSeccionCatalogo.Name = "lblSeccionCatalogo";
            lblSeccionCatalogo.Size = new Size(80, 19);
            lblSeccionCatalogo.TabIndex = 4;
            lblSeccionCatalogo.Text = "CATÁLOGO";
            //
            // btnNavCategorias
            //
            btnNavCategorias.BackColor = Color.FromArgb(20, 23, 34);
            btnNavCategorias.Cursor = Cursors.Hand;
            btnNavCategorias.FlatAppearance.BorderSize = 0;
            btnNavCategorias.FlatStyle = FlatStyle.Flat;
            btnNavCategorias.Font = new Font("Segoe UI", 10.5F);
            btnNavCategorias.ForeColor = Color.FromArgb(226, 232, 240);
            btnNavCategorias.Location = new Point(0, 228);
            btnNavCategorias.Name = "btnNavCategorias";
            btnNavCategorias.Padding = new Padding(24, 0, 0, 0);
            btnNavCategorias.Size = new Size(240, 44);
            btnNavCategorias.TabIndex = 5;
            btnNavCategorias.Text = "🏷️   Categorías";
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
            btnNavProductos.Location = new Point(0, 272);
            btnNavProductos.Name = "btnNavProductos";
            btnNavProductos.Padding = new Padding(24, 0, 0, 0);
            btnNavProductos.Size = new Size(240, 44);
            btnNavProductos.TabIndex = 6;
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
            btnNavSuplidores.Location = new Point(0, 316);
            btnNavSuplidores.Name = "btnNavSuplidores";
            btnNavSuplidores.Padding = new Padding(24, 0, 0, 0);
            btnNavSuplidores.Size = new Size(240, 44);
            btnNavSuplidores.TabIndex = 7;
            btnNavSuplidores.Text = "🚚   Suplidores";
            btnNavSuplidores.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSuplidores.UseVisualStyleBackColor = false;
            btnNavSuplidores.Click += btnNavSuplidores_Click;
            //
            // lblSeccionOperaciones
            //
            lblSeccionOperaciones.AutoSize = true;
            lblSeccionOperaciones.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblSeccionOperaciones.ForeColor = Color.FromArgb(71, 85, 105);
            lblSeccionOperaciones.Location = new Point(24, 372);
            lblSeccionOperaciones.Name = "lblSeccionOperaciones";
            lblSeccionOperaciones.Size = new Size(110, 19);
            lblSeccionOperaciones.TabIndex = 8;
            lblSeccionOperaciones.Text = "OPERACIONES";
            //
            // btnNavIncremento
            //
            btnNavIncremento.BackColor = Color.FromArgb(20, 23, 34);
            btnNavIncremento.Cursor = Cursors.Hand;
            btnNavIncremento.FlatAppearance.BorderSize = 0;
            btnNavIncremento.FlatStyle = FlatStyle.Flat;
            btnNavIncremento.Font = new Font("Segoe UI", 10.5F);
            btnNavIncremento.ForeColor = Color.FromArgb(226, 232, 240);
            btnNavIncremento.Location = new Point(0, 396);
            btnNavIncremento.Name = "btnNavIncremento";
            btnNavIncremento.Padding = new Padding(24, 0, 0, 0);
            btnNavIncremento.Size = new Size(240, 44);
            btnNavIncremento.TabIndex = 9;
            btnNavIncremento.Text = "💲   Incremento Precios";
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
            btnNavReasignar.Location = new Point(0, 440);
            btnNavReasignar.Name = "btnNavReasignar";
            btnNavReasignar.Padding = new Padding(24, 0, 0, 0);
            btnNavReasignar.Size = new Size(240, 44);
            btnNavReasignar.TabIndex = 10;
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
            btnNavReporte.Location = new Point(0, 484);
            btnNavReporte.Name = "btnNavReporte";
            btnNavReporte.Padding = new Padding(24, 0, 0, 0);
            btnNavReporte.Size = new Size(240, 44);
            btnNavReporte.TabIndex = 11;
            btnNavReporte.Text = "📊   Reportes";
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
            btnNavSalir.TabIndex = 12;
            btnNavSalir.Text = "🚪   Salir";
            btnNavSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSalir.UseVisualStyleBackColor = false;
            btnNavSalir.Click += btnNavSalir_Click;
            //
            // panelTopbar
            //
            panelTopbar.BackColor = Color.FromArgb(26, 29, 39);
            panelTopbar.Controls.Add(txtBuscarGlobal);
            panelTopbar.Controls.Add(lblSeccionActual);
            panelTopbar.Controls.Add(panelTopbarRight);
            panelTopbar.Dock = DockStyle.Top;
            panelTopbar.Location = new Point(240, 0);
            panelTopbar.Name = "panelTopbar";
            panelTopbar.Padding = new Padding(28, 0, 0, 0);
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
            lblSeccionActual.Size = new Size(120, 28);
            lblSeccionActual.TabIndex = 0;
            lblSeccionActual.Text = "Dashboard";
            //
            // txtBuscarGlobal
            //
            txtBuscarGlobal.BackColor = Color.FromArgb(20, 23, 34);
            txtBuscarGlobal.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarGlobal.Font = new Font("Segoe UI", 9.5F);
            txtBuscarGlobal.ForeColor = Color.FromArgb(226, 232, 240);
            txtBuscarGlobal.Location = new Point(300, 17);
            txtBuscarGlobal.Name = "txtBuscarGlobal";
            txtBuscarGlobal.PlaceholderText = "🔍  Buscar productos y presionar Enter...";
            txtBuscarGlobal.Size = new Size(300, 29);
            txtBuscarGlobal.TabIndex = 1;
            txtBuscarGlobal.KeyDown += txtBuscarGlobal_KeyDown;
            //
            // panelTopbarRight
            //
            panelTopbarRight.Controls.Add(lblUsuario);
            panelTopbarRight.Controls.Add(lblNotificaciones);
            panelTopbarRight.Controls.Add(lblFecha);
            panelTopbarRight.Dock = DockStyle.Right;
            panelTopbarRight.Location = new Point(730, 0);
            panelTopbarRight.Name = "panelTopbarRight";
            panelTopbarRight.Size = new Size(430, 64);
            panelTopbarRight.TabIndex = 2;
            //
            // lblFecha
            //
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.5F);
            lblFecha.ForeColor = Color.FromArgb(148, 163, 184);
            lblFecha.Location = new Point(20, 22);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(160, 21);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "—";
            //
            // lblNotificaciones
            //
            lblNotificaciones.AutoSize = true;
            lblNotificaciones.Cursor = Cursors.Hand;
            lblNotificaciones.Font = new Font("Segoe UI", 11F);
            lblNotificaciones.ForeColor = Color.FromArgb(226, 232, 240);
            lblNotificaciones.Location = new Point(230, 19);
            lblNotificaciones.Name = "lblNotificaciones";
            lblNotificaciones.Size = new Size(40, 25);
            lblNotificaciones.TabIndex = 1;
            lblNotificaciones.Text = "🔔";
            lblNotificaciones.Click += lblNotificaciones_Click;
            //
            // lblUsuario
            //
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9.5F);
            lblUsuario.ForeColor = Color.FromArgb(148, 163, 184);
            lblUsuario.Location = new Point(290, 22);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(176, 21);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "👤  Administrador";
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
            MinimumSize = new Size(1300, 750);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Northwind Manager";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelSidebarHeader.ResumeLayout(false);
            panelSidebarHeader.PerformLayout();
            panelTopbar.ResumeLayout(false);
            panelTopbar.PerformLayout();
            panelTopbarRight.ResumeLayout(false);
            panelTopbarRight.PerformLayout();
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
        private Label lblConexion;
        private Label lblSeccionPrincipal;
        private Button btnNavInicio;
        private Label lblSeccionCatalogo;
        private Button btnNavCategorias;
        private Button btnNavProductos;
        private Button btnNavSuplidores;
        private Label lblSeccionOperaciones;
        private Button btnNavIncremento;
        private Button btnNavReasignar;
        private Button btnNavReporte;
        private Button btnNavSalir;
        private Panel panelTopbar;
        private Label lblSeccionActual;
        private TextBox txtBuscarGlobal;
        private Panel panelTopbarRight;
        private Label lblFecha;
        private Label lblNotificaciones;
        private Label lblUsuario;
        private Panel panelContent;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
    }
}
