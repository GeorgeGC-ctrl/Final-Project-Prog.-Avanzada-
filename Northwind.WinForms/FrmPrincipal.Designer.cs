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
            panelMenu = new Panel();
            btnNavSalir = new Button();
            lblSectionReportes = new Label();
            btnNavReporteInventario = new Button();
            lblSectionOperaciones = new Label();
            btnNavReasignarProductos = new Button();
            btnNavIncrementoPrecios = new Button();
            lblSectionCatalogo = new Label();
            btnNavSuplidores = new Button();
            btnNavCategorias = new Button();
            lblSectionGeneral = new Label();
            btnNavDashboard = new Button();
            panelSidebarFooter = new Panel();
            lblUserRole = new Label();
            lblUserName = new Label();
            panelBrand = new Panel();
            lblConnStatus = new Label();
            lblBrandSubtitle = new Label();
            lblBrandTitle = new Label();
            panelLogo = new Panel();
            lblLogoLetter = new Label();
            panelMainContainer = new Panel();
            panelContenido = new Panel();
            panelTopBar = new Panel();
            lblPageDescription = new Label();
            lblPageTitle = new Label();
            panelSidebar.SuspendLayout();
            panelMenu.SuspendLayout();
            panelSidebarFooter.SuspendLayout();
            panelBrand.SuspendLayout();
            panelLogo.SuspendLayout();
            panelMainContainer.SuspendLayout();
            panelTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(238, 241, 247);
            panelSidebar.Controls.Add(panelMenu);
            panelSidebar.Controls.Add(panelSidebarFooter);
            panelSidebar.Controls.Add(panelBrand);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Padding = new Padding(12, 16, 12, 16);
            panelSidebar.Size = new Size(260, 800);
            panelSidebar.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.Controls.Add(btnNavSalir);
            panelMenu.Controls.Add(lblSectionReportes);
            panelMenu.Controls.Add(btnNavReporteInventario);
            panelMenu.Controls.Add(lblSectionOperaciones);
            panelMenu.Controls.Add(btnNavReasignarProductos);
            panelMenu.Controls.Add(btnNavIncrementoPrecios);
            panelMenu.Controls.Add(lblSectionCatalogo);
            panelMenu.Controls.Add(btnNavSuplidores);
            panelMenu.Controls.Add(btnNavCategorias);
            panelMenu.Controls.Add(lblSectionGeneral);
            panelMenu.Controls.Add(btnNavDashboard);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(12, 116);
            panelMenu.Name = "panelMenu";
            panelMenu.Padding = new Padding(0, 8, 0, 8);
            panelMenu.Size = new Size(236, 608);
            panelMenu.TabIndex = 1;
            // 
            // btnNavSalir
            // 
            btnNavSalir.BackColor = Color.Transparent;
            btnNavSalir.Cursor = Cursors.Hand;
            btnNavSalir.Dock = DockStyle.Top;
            btnNavSalir.FlatAppearance.BorderSize = 0;
            btnNavSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(251, 234, 232);
            btnNavSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 242, 242);
            btnNavSalir.FlatStyle = FlatStyle.Flat;
            btnNavSalir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNavSalir.ForeColor = Color.FromArgb(192, 57, 43);
            btnNavSalir.Location = new Point(0, 396);
            btnNavSalir.Margin = new Padding(0, 2, 0, 2);
            btnNavSalir.Name = "btnNavSalir";
            btnNavSalir.Padding = new Padding(12, 0, 12, 0);
            btnNavSalir.Size = new Size(236, 42);
            btnNavSalir.TabIndex = 10;
            btnNavSalir.Text = "🚪   Salir del Sistema";
            btnNavSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSalir.UseVisualStyleBackColor = false;
            btnNavSalir.Click += btnNavSalir_Click;
            // 
            // lblSectionReportes
            // 
            lblSectionReportes.Dock = DockStyle.Top;
            lblSectionReportes.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSectionReportes.ForeColor = Color.FromArgb(136, 144, 160);
            lblSectionReportes.Location = new Point(0, 368);
            lblSectionReportes.Name = "lblSectionReportes";
            lblSectionReportes.Padding = new Padding(10, 10, 0, 0);
            lblSectionReportes.Size = new Size(236, 28);
            lblSectionReportes.TabIndex = 8;
            lblSectionReportes.Text = "REPORTES";
            // 
            // btnNavReporteInventario
            // 
            btnNavReporteInventario.BackColor = Color.Transparent;
            btnNavReporteInventario.Cursor = Cursors.Hand;
            btnNavReporteInventario.Dock = DockStyle.Top;
            btnNavReporteInventario.FlatAppearance.BorderSize = 0;
            btnNavReporteInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 231, 239);
            btnNavReporteInventario.FlatStyle = FlatStyle.Flat;
            btnNavReporteInventario.Font = new Font("Segoe UI", 9.5F);
            btnNavReporteInventario.ForeColor = Color.FromArgb(91, 100, 116);
            btnNavReporteInventario.Location = new Point(0, 326);
            btnNavReporteInventario.Margin = new Padding(0, 2, 0, 2);
            btnNavReporteInventario.Name = "btnNavReporteInventario";
            btnNavReporteInventario.Padding = new Padding(12, 0, 12, 0);
            btnNavReporteInventario.Size = new Size(236, 42);
            btnNavReporteInventario.TabIndex = 9;
            btnNavReporteInventario.Text = "📋   Valor de Inventario";
            btnNavReporteInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnNavReporteInventario.UseVisualStyleBackColor = false;
            btnNavReporteInventario.Click += btnNavReporteInventario_Click;
            // 
            // lblSectionOperaciones
            // 
            lblSectionOperaciones.Dock = DockStyle.Top;
            lblSectionOperaciones.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSectionOperaciones.ForeColor = Color.FromArgb(136, 144, 160);
            lblSectionOperaciones.Location = new Point(0, 244);
            lblSectionOperaciones.Name = "lblSectionOperaciones";
            lblSectionOperaciones.Padding = new Padding(10, 10, 0, 0);
            lblSectionOperaciones.Size = new Size(236, 28);
            lblSectionOperaciones.TabIndex = 5;
            lblSectionOperaciones.Text = "OPERACIONES";
            // 
            // btnNavReasignarProductos
            // 
            btnNavReasignarProductos.BackColor = Color.Transparent;
            btnNavReasignarProductos.Cursor = Cursors.Hand;
            btnNavReasignarProductos.Dock = DockStyle.Top;
            btnNavReasignarProductos.FlatAppearance.BorderSize = 0;
            btnNavReasignarProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 231, 239);
            btnNavReasignarProductos.FlatStyle = FlatStyle.Flat;
            btnNavReasignarProductos.Font = new Font("Segoe UI", 9.5F);
            btnNavReasignarProductos.ForeColor = Color.FromArgb(91, 100, 116);
            btnNavReasignarProductos.Location = new Point(0, 202);
            btnNavReasignarProductos.Margin = new Padding(0, 2, 0, 2);
            btnNavReasignarProductos.Name = "btnNavReasignarProductos";
            btnNavReasignarProductos.Padding = new Padding(12, 0, 12, 0);
            btnNavReasignarProductos.Size = new Size(236, 42);
            btnNavReasignarProductos.TabIndex = 7;
            btnNavReasignarProductos.Text = "🔄   Reasignar Productos";
            btnNavReasignarProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnNavReasignarProductos.UseVisualStyleBackColor = false;
            btnNavReasignarProductos.Click += btnNavReasignarProductos_Click;
            // 
            // btnNavIncrementoPrecios
            // 
            btnNavIncrementoPrecios.BackColor = Color.Transparent;
            btnNavIncrementoPrecios.Cursor = Cursors.Hand;
            btnNavIncrementoPrecios.Dock = DockStyle.Top;
            btnNavIncrementoPrecios.FlatAppearance.BorderSize = 0;
            btnNavIncrementoPrecios.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 231, 239);
            btnNavIncrementoPrecios.FlatStyle = FlatStyle.Flat;
            btnNavIncrementoPrecios.Font = new Font("Segoe UI", 9.5F);
            btnNavIncrementoPrecios.ForeColor = Color.FromArgb(91, 100, 116);
            btnNavIncrementoPrecios.Location = new Point(0, 160);
            btnNavIncrementoPrecios.Margin = new Padding(0, 2, 0, 2);
            btnNavIncrementoPrecios.Name = "btnNavIncrementoPrecios";
            btnNavIncrementoPrecios.Padding = new Padding(12, 0, 12, 0);
            btnNavIncrementoPrecios.Size = new Size(236, 42);
            btnNavIncrementoPrecios.TabIndex = 6;
            btnNavIncrementoPrecios.Text = "📈   Incremento Precios";
            btnNavIncrementoPrecios.TextAlign = ContentAlignment.MiddleLeft;
            btnNavIncrementoPrecios.UseVisualStyleBackColor = false;
            btnNavIncrementoPrecios.Click += btnNavIncrementoPrecios_Click;
            // 
            // lblSectionCatalogo
            // 
            lblSectionCatalogo.Dock = DockStyle.Top;
            lblSectionCatalogo.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSectionCatalogo.ForeColor = Color.FromArgb(136, 144, 160);
            lblSectionCatalogo.Location = new Point(0, 132);
            lblSectionCatalogo.Name = "lblSectionCatalogo";
            lblSectionCatalogo.Padding = new Padding(10, 10, 0, 0);
            lblSectionCatalogo.Size = new Size(236, 28);
            lblSectionCatalogo.TabIndex = 2;
            lblSectionCatalogo.Text = "CATÁLOGO";
            // 
            // btnNavSuplidores
            // 
            btnNavSuplidores.BackColor = Color.Transparent;
            btnNavSuplidores.Cursor = Cursors.Hand;
            btnNavSuplidores.Dock = DockStyle.Top;
            btnNavSuplidores.FlatAppearance.BorderSize = 0;
            btnNavSuplidores.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 231, 239);
            btnNavSuplidores.FlatStyle = FlatStyle.Flat;
            btnNavSuplidores.Font = new Font("Segoe UI", 9.5F);
            btnNavSuplidores.ForeColor = Color.FromArgb(91, 100, 116);
            btnNavSuplidores.Location = new Point(0, 90);
            btnNavSuplidores.Margin = new Padding(0, 2, 0, 2);
            btnNavSuplidores.Name = "btnNavSuplidores";
            btnNavSuplidores.Padding = new Padding(12, 0, 12, 0);
            btnNavSuplidores.Size = new Size(236, 42);
            btnNavSuplidores.TabIndex = 4;
            btnNavSuplidores.Text = "🚚   Suplidores";
            btnNavSuplidores.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSuplidores.UseVisualStyleBackColor = false;
            btnNavSuplidores.Click += btnNavSuplidores_Click;
            // 
            // btnNavCategorias
            // 
            btnNavCategorias.BackColor = Color.Transparent;
            btnNavCategorias.Cursor = Cursors.Hand;
            btnNavCategorias.Dock = DockStyle.Top;
            btnNavCategorias.FlatAppearance.BorderSize = 0;
            btnNavCategorias.FlatAppearance.MouseOverBackColor = Color.FromArgb(227, 231, 239);
            btnNavCategorias.FlatStyle = FlatStyle.Flat;
            btnNavCategorias.Font = new Font("Segoe UI", 9.5F);
            btnNavCategorias.ForeColor = Color.FromArgb(91, 100, 116);
            btnNavCategorias.Location = new Point(0, 48);
            btnNavCategorias.Margin = new Padding(0, 2, 0, 2);
            btnNavCategorias.Name = "btnNavCategorias";
            btnNavCategorias.Padding = new Padding(12, 0, 12, 0);
            btnNavCategorias.Size = new Size(236, 42);
            btnNavCategorias.TabIndex = 3;
            btnNavCategorias.Text = "🏷️   Categorías";
            btnNavCategorias.TextAlign = ContentAlignment.MiddleLeft;
            btnNavCategorias.UseVisualStyleBackColor = false;
            btnNavCategorias.Click += btnNavCategorias_Click;
            // 
            // lblSectionGeneral
            // 
            lblSectionGeneral.Dock = DockStyle.Top;
            lblSectionGeneral.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblSectionGeneral.ForeColor = Color.FromArgb(136, 144, 160);
            lblSectionGeneral.Location = new Point(0, 8);
            lblSectionGeneral.Name = "lblSectionGeneral";
            lblSectionGeneral.Padding = new Padding(10, 0, 0, 0);
            lblSectionGeneral.Size = new Size(236, 20);
            lblSectionGeneral.TabIndex = 0;
            lblSectionGeneral.Text = "GENERAL";
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.BackColor = Color.FromArgb(44, 78, 130);
            btnNavDashboard.Cursor = Cursors.Hand;
            btnNavDashboard.Dock = DockStyle.Top;
            btnNavDashboard.FlatAppearance.BorderSize = 0;
            btnNavDashboard.FlatStyle = FlatStyle.Flat;
            btnNavDashboard.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNavDashboard.ForeColor = Color.White;
            btnNavDashboard.Location = new Point(0, 28);
            btnNavDashboard.Margin = new Padding(0, 2, 0, 2);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Padding = new Padding(12, 0, 12, 0);
            btnNavDashboard.Size = new Size(236, 42);
            btnNavDashboard.TabIndex = 1;
            btnNavDashboard.Text = "📊   Dashboard";
            btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnNavDashboard.UseVisualStyleBackColor = false;
            btnNavDashboard.Click += btnNavDashboard_Click;
            // 
            // panelSidebarFooter
            // 
            panelSidebarFooter.BackColor = Color.FromArgb(231, 235, 243);
            panelSidebarFooter.Controls.Add(lblUserRole);
            panelSidebarFooter.Controls.Add(lblUserName);
            panelSidebarFooter.Dock = DockStyle.Bottom;
            panelSidebarFooter.Location = new Point(12, 724);
            panelSidebarFooter.Name = "panelSidebarFooter";
            panelSidebarFooter.Padding = new Padding(12, 10, 12, 10);
            panelSidebarFooter.Size = new Size(236, 60);
            panelSidebarFooter.TabIndex = 2;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Font = new Font("Segoe UI", 8F);
            lblUserRole.ForeColor = Color.FromArgb(91, 100, 116);
            lblUserRole.Location = new Point(10, 32);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(98, 19);
            lblUserRole.TabIndex = 1;
            lblUserRole.Text = "Administrador";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblUserName.ForeColor = Color.FromArgb(22, 26, 36);
            lblUserName.Location = new Point(10, 10);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(107, 21);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "manugardon";
            // 
            // panelBrand
            // 
            panelBrand.Controls.Add(lblConnStatus);
            panelBrand.Controls.Add(lblBrandSubtitle);
            panelBrand.Controls.Add(lblBrandTitle);
            panelBrand.Controls.Add(panelLogo);
            panelBrand.Dock = DockStyle.Top;
            panelBrand.Location = new Point(12, 16);
            panelBrand.Name = "panelBrand";
            panelBrand.Size = new Size(236, 100);
            panelBrand.TabIndex = 0;
            // 
            // lblConnStatus
            // 
            lblConnStatus.AutoSize = true;
            lblConnStatus.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblConnStatus.ForeColor = Color.FromArgb(31, 138, 95);
            lblConnStatus.Location = new Point(6, 68);
            lblConnStatus.Name = "lblConnStatus";
            lblConnStatus.Size = new Size(169, 19);
            lblConnStatus.TabIndex = 3;
            lblConnStatus.Text = "● Conectado · SQL Server";
            // 
            // lblBrandSubtitle
            // 
            lblBrandSubtitle.AutoSize = true;
            lblBrandSubtitle.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblBrandSubtitle.ForeColor = Color.FromArgb(136, 144, 160);
            lblBrandSubtitle.Location = new Point(60, 35);
            lblBrandSubtitle.Name = "lblBrandSubtitle";
            lblBrandSubtitle.Size = new Size(99, 17);
            lblBrandSubtitle.TabIndex = 2;
            lblBrandSubtitle.Text = "MANAGER v1.0";
            // 
            // lblBrandTitle
            // 
            lblBrandTitle.AutoSize = true;
            lblBrandTitle.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblBrandTitle.ForeColor = Color.FromArgb(22, 26, 36);
            lblBrandTitle.Location = new Point(56, 10);
            lblBrandTitle.Name = "lblBrandTitle";
            lblBrandTitle.Size = new Size(130, 31);
            lblBrandTitle.TabIndex = 1;
            lblBrandTitle.Text = "Northwind";
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(44, 78, 130);
            panelLogo.Controls.Add(lblLogoLetter);
            panelLogo.Location = new Point(6, 12);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(42, 42);
            panelLogo.TabIndex = 0;
            // 
            // lblLogoLetter
            // 
            lblLogoLetter.Dock = DockStyle.Fill;
            lblLogoLetter.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLogoLetter.ForeColor = Color.White;
            lblLogoLetter.Location = new Point(0, 0);
            lblLogoLetter.Name = "lblLogoLetter";
            lblLogoLetter.Size = new Size(42, 42);
            lblLogoLetter.TabIndex = 0;
            lblLogoLetter.Text = "N";
            lblLogoLetter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMainContainer
            // 
            panelMainContainer.BackColor = Color.FromArgb(245, 247, 251);
            panelMainContainer.Controls.Add(panelContenido);
            panelMainContainer.Controls.Add(panelTopBar);
            panelMainContainer.Dock = DockStyle.Fill;
            panelMainContainer.Location = new Point(260, 0);
            panelMainContainer.Name = "panelMainContainer";
            panelMainContainer.Size = new Size(1040, 800);
            panelMainContainer.TabIndex = 1;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.FromArgb(245, 247, 251);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 60);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1040, 740);
            panelContenido.TabIndex = 1;
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.White;
            panelTopBar.BorderStyle = BorderStyle.FixedSingle;
            panelTopBar.Controls.Add(lblPageDescription);
            panelTopBar.Controls.Add(lblPageTitle);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Padding = new Padding(25, 10, 25, 10);
            panelTopBar.Size = new Size(1040, 60);
            panelTopBar.TabIndex = 0;
            // 
            // lblPageDescription
            // 
            lblPageDescription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPageDescription.AutoSize = true;
            lblPageDescription.Font = new Font("Segoe UI", 8.5F);
            lblPageDescription.ForeColor = Color.FromArgb(136, 144, 160);
            lblPageDescription.Location = new Point(780, 20);
            lblPageDescription.Name = "lblPageDescription";
            lblPageDescription.Size = new Size(224, 20);
            lblPageDescription.TabIndex = 1;
            lblPageDescription.Text = "Sistema de Gestión Empresarial";
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(22, 26, 36);
            lblPageTitle.Location = new Point(20, 14);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(122, 30);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(1300, 800);
            Controls.Add(panelMainContainer);
            Controls.Add(panelSidebar);
            MinimumSize = new Size(1000, 650);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Northwind — Sistema de Gestión";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            panelSidebar.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelSidebarFooter.ResumeLayout(false);
            panelSidebarFooter.PerformLayout();
            panelBrand.ResumeLayout(false);
            panelBrand.PerformLayout();
            panelLogo.ResumeLayout(false);
            panelMainContainer.ResumeLayout(false);
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelBrand;
        private Panel panelLogo;
        private Label lblLogoLetter;
        private Label lblBrandTitle;
        private Label lblBrandSubtitle;
        private Label lblConnStatus;
        private Panel panelMenu;
        private Label lblSectionGeneral;
        private Button btnNavDashboard;
        private Label lblSectionCatalogo;
        private Button btnNavCategorias;
        private Button btnNavSuplidores;
        private Label lblSectionOperaciones;
        private Button btnNavIncrementoPrecios;
        private Button btnNavReasignarProductos;
        private Label lblSectionReportes;
        private Button btnNavReporteInventario;
        private Button btnNavSalir;
        private Panel panelSidebarFooter;
        private Label lblUserName;
        private Label lblUserRole;
        private Panel panelMainContainer;
        private Panel panelTopBar;
        private Label lblPageTitle;
        private Label lblPageDescription;
        private Panel panelContenido;
    }
}