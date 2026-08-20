namespace Northwind.WinForms
{
    partial class Form1
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
            panelHeader = new Panel();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            panelStats = new Panel();
            cardStockBajo = new Panel();
            lblValStock = new Label();
            lblTagStock = new Label();
            cardSuplidores = new Panel();
            lblValSuplidores = new Label();
            lblTagSuplidores = new Label();
            cardProductos = new Panel();
            lblValProductos = new Label();
            lblTagProductos = new Label();
            cardCategorias = new Panel();
            lblValCategorias = new Label();
            lblTagCategorias = new Label();
            panelBody = new Panel();
            panelAccesos = new Panel();
            btnAccReporte = new Button();
            btnAccReasignar = new Button();
            btnAccPrecios = new Button();
            btnAccSuplidores = new Button();
            btnAccCategorias = new Button();
            panelAccesosHeader = new Panel();
            lblAccesosTitulo = new Label();
            panelHeader.SuspendLayout();
            panelStats.SuspendLayout();
            cardStockBajo.SuspendLayout();
            cardSuplidores.SuspendLayout();
            cardProductos.SuspendLayout();
            cardCategorias.SuspendLayout();
            panelBody.SuspendLayout();
            panelAccesos.SuspendLayout();
            panelAccesosHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(30, 20, 30, 16);
            panelHeader.Size = new Size(1100, 85);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(91, 100, 116);
            lblSubtitulo.Location = new Point(30, 52);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(494, 21);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Resumen general del catálogo y accesos directos a los módulos del sistema";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(22, 26, 36);
            lblTitulo.Location = new Point(28, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(207, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Panel Principal";
            // 
            // panelStats
            // 
            panelStats.Controls.Add(cardStockBajo);
            panelStats.Controls.Add(cardSuplidores);
            panelStats.Controls.Add(cardProductos);
            panelStats.Controls.Add(cardCategorias);
            panelStats.Dock = DockStyle.Top;
            panelStats.Location = new Point(0, 85);
            panelStats.Name = "panelStats";
            panelStats.Padding = new Padding(30, 20, 30, 10);
            panelStats.Size = new Size(1100, 125);
            panelStats.TabIndex = 1;
            // 
            // cardStockBajo
            // 
            cardStockBajo.BackColor = Color.White;
            cardStockBajo.BorderStyle = BorderStyle.FixedSingle;
            cardStockBajo.Controls.Add(lblValStock);
            cardStockBajo.Controls.Add(lblTagStock);
            cardStockBajo.Location = new Point(780, 20);
            cardStockBajo.Name = "cardStockBajo";
            cardStockBajo.Padding = new Padding(16, 12, 16, 12);
            cardStockBajo.Size = new Size(230, 85);
            cardStockBajo.TabIndex = 3;
            // 
            // lblValStock
            // 
            lblValStock.AutoSize = true;
            lblValStock.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblValStock.ForeColor = Color.FromArgb(180, 83, 9);
            lblValStock.Location = new Point(14, 38);
            lblValStock.Name = "lblValStock";
            lblValStock.Size = new Size(32, 37);
            lblValStock.TabIndex = 1;
            lblValStock.Text = "6";
            // 
            // lblTagStock
            // 
            lblTagStock.AutoSize = true;
            lblTagStock.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTagStock.ForeColor = Color.FromArgb(136, 144, 160);
            lblTagStock.Location = new Point(14, 12);
            lblTagStock.Name = "lblTagStock";
            lblTagStock.Size = new Size(91, 19);
            lblTagStock.TabIndex = 0;
            lblTagStock.Text = "STOCK BAJO";
            // 
            // cardSuplidores
            // 
            cardSuplidores.BackColor = Color.White;
            cardSuplidores.BorderStyle = BorderStyle.FixedSingle;
            cardSuplidores.Controls.Add(lblValSuplidores);
            cardSuplidores.Controls.Add(lblTagSuplidores);
            cardSuplidores.Location = new Point(530, 20);
            cardSuplidores.Name = "cardSuplidores";
            cardSuplidores.Padding = new Padding(16, 12, 16, 12);
            cardSuplidores.Size = new Size(230, 85);
            cardSuplidores.TabIndex = 2;
            // 
            // lblValSuplidores
            // 
            lblValSuplidores.AutoSize = true;
            lblValSuplidores.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblValSuplidores.ForeColor = Color.FromArgb(193, 121, 31);
            lblValSuplidores.Location = new Point(14, 38);
            lblValSuplidores.Name = "lblValSuplidores";
            lblValSuplidores.Size = new Size(48, 37);
            lblValSuplidores.TabIndex = 1;
            lblValSuplidores.Text = "29";
            // 
            // lblTagSuplidores
            // 
            lblTagSuplidores.AutoSize = true;
            lblTagSuplidores.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTagSuplidores.ForeColor = Color.FromArgb(136, 144, 160);
            lblTagSuplidores.Location = new Point(14, 12);
            lblTagSuplidores.Name = "lblTagSuplidores";
            lblTagSuplidores.Size = new Size(90, 19);
            lblTagSuplidores.TabIndex = 0;
            lblTagSuplidores.Text = "SUPLIDORES";
            // 
            // cardProductos
            // 
            cardProductos.BackColor = Color.White;
            cardProductos.BorderStyle = BorderStyle.FixedSingle;
            cardProductos.Controls.Add(lblValProductos);
            cardProductos.Controls.Add(lblTagProductos);
            cardProductos.Location = new Point(280, 20);
            cardProductos.Name = "cardProductos";
            cardProductos.Padding = new Padding(16, 12, 16, 12);
            cardProductos.Size = new Size(230, 85);
            cardProductos.TabIndex = 1;
            // 
            // lblValProductos
            // 
            lblValProductos.AutoSize = true;
            lblValProductos.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblValProductos.ForeColor = Color.FromArgb(31, 138, 95);
            lblValProductos.Location = new Point(14, 38);
            lblValProductos.Name = "lblValProductos";
            lblValProductos.Size = new Size(48, 37);
            lblValProductos.TabIndex = 1;
            lblValProductos.Text = "77";
            // 
            // lblTagProductos
            // 
            lblTagProductos.AutoSize = true;
            lblTagProductos.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTagProductos.ForeColor = Color.FromArgb(136, 144, 160);
            lblTagProductos.Location = new Point(14, 12);
            lblTagProductos.Name = "lblTagProductos";
            lblTagProductos.Size = new Size(94, 19);
            lblTagProductos.TabIndex = 0;
            lblTagProductos.Text = "PRODUCTOS";
            // 
            // cardCategorias
            // 
            cardCategorias.BackColor = Color.White;
            cardCategorias.BorderStyle = BorderStyle.FixedSingle;
            cardCategorias.Controls.Add(lblValCategorias);
            cardCategorias.Controls.Add(lblTagCategorias);
            cardCategorias.Location = new Point(30, 20);
            cardCategorias.Name = "cardCategorias";
            cardCategorias.Padding = new Padding(16, 12, 16, 12);
            cardCategorias.Size = new Size(230, 85);
            cardCategorias.TabIndex = 0;
            // 
            // lblValCategorias
            // 
            lblValCategorias.AutoSize = true;
            lblValCategorias.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblValCategorias.ForeColor = Color.FromArgb(44, 78, 130);
            lblValCategorias.Location = new Point(14, 38);
            lblValCategorias.Name = "lblValCategorias";
            lblValCategorias.Size = new Size(32, 37);
            lblValCategorias.TabIndex = 1;
            lblValCategorias.Text = "8";
            // 
            // lblTagCategorias
            // 
            lblTagCategorias.AutoSize = true;
            lblTagCategorias.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTagCategorias.ForeColor = Color.FromArgb(136, 144, 160);
            lblTagCategorias.Location = new Point(14, 12);
            lblTagCategorias.Name = "lblTagCategorias";
            lblTagCategorias.Size = new Size(93, 19);
            lblTagCategorias.TabIndex = 0;
            lblTagCategorias.Text = "CATEGORÍAS";
            // 
            // panelBody
            // 
            panelBody.Controls.Add(panelAccesos);
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(0, 210);
            panelBody.Name = "panelBody";
            panelBody.Padding = new Padding(30, 10, 30, 30);
            panelBody.Size = new Size(1100, 440);
            panelBody.TabIndex = 2;
            // 
            // panelAccesos
            // 
            panelAccesos.BackColor = Color.White;
            panelAccesos.BorderStyle = BorderStyle.FixedSingle;
            panelAccesos.Controls.Add(btnAccReporte);
            panelAccesos.Controls.Add(btnAccReasignar);
            panelAccesos.Controls.Add(btnAccPrecios);
            panelAccesos.Controls.Add(btnAccSuplidores);
            panelAccesos.Controls.Add(btnAccCategorias);
            panelAccesos.Controls.Add(panelAccesosHeader);
            panelAccesos.Location = new Point(30, 10);
            panelAccesos.Name = "panelAccesos";
            panelAccesos.Size = new Size(500, 380);
            panelAccesos.TabIndex = 0;
            // 
            // btnAccReporte
            // 
            btnAccReporte.BackColor = Color.White;
            btnAccReporte.Cursor = Cursors.Hand;
            btnAccReporte.Dock = DockStyle.Top;
            btnAccReporte.FlatAppearance.BorderSize = 0;
            btnAccReporte.FlatStyle = FlatStyle.Flat;
            btnAccReporte.Font = new Font("Segoe UI", 10F);
            btnAccReporte.ForeColor = Color.FromArgb(22, 26, 36);
            btnAccReporte.Location = new Point(0, 250);
            btnAccReporte.Name = "btnAccReporte";
            btnAccReporte.Padding = new Padding(20, 0, 20, 0);
            btnAccReporte.Size = new Size(498, 50);
            btnAccReporte.TabIndex = 5;
            btnAccReporte.Text = "📊  Reportes de Valor de Inventario";
            btnAccReporte.TextAlign = ContentAlignment.MiddleLeft;
            btnAccReporte.UseVisualStyleBackColor = false;
            btnAccReporte.Click += btnAccReporte_Click;
            // 
            // btnAccReasignar
            // 
            btnAccReasignar.BackColor = Color.White;
            btnAccReasignar.Cursor = Cursors.Hand;
            btnAccReasignar.Dock = DockStyle.Top;
            btnAccReasignar.FlatAppearance.BorderSize = 0;
            btnAccReasignar.FlatStyle = FlatStyle.Flat;
            btnAccReasignar.Font = new Font("Segoe UI", 10F);
            btnAccReasignar.ForeColor = Color.FromArgb(22, 26, 36);
            btnAccReasignar.Location = new Point(0, 200);
            btnAccReasignar.Name = "btnAccReasignar";
            btnAccReasignar.Padding = new Padding(20, 0, 20, 0);
            btnAccReasignar.Size = new Size(498, 50);
            btnAccReasignar.TabIndex = 4;
            btnAccReasignar.Text = "🔄  Reasignación de Productos por Suplidor";
            btnAccReasignar.TextAlign = ContentAlignment.MiddleLeft;
            btnAccReasignar.UseVisualStyleBackColor = false;
            btnAccReasignar.Click += btnAccReasignar_Click;
            // 
            // btnAccPrecios
            // 
            btnAccPrecios.BackColor = Color.White;
            btnAccPrecios.Cursor = Cursors.Hand;
            btnAccPrecios.Dock = DockStyle.Top;
            btnAccPrecios.FlatAppearance.BorderSize = 0;
            btnAccPrecios.FlatStyle = FlatStyle.Flat;
            btnAccPrecios.Font = new Font("Segoe UI", 10F);
            btnAccPrecios.ForeColor = Color.FromArgb(22, 26, 36);
            btnAccPrecios.Location = new Point(0, 150);
            btnAccPrecios.Name = "btnAccPrecios";
            btnAccPrecios.Padding = new Padding(20, 0, 20, 0);
            btnAccPrecios.Size = new Size(498, 50);
            btnAccPrecios.TabIndex = 3;
            btnAccPrecios.Text = "📈  Incremento Porcentual de Precios";
            btnAccPrecios.TextAlign = ContentAlignment.MiddleLeft;
            btnAccPrecios.UseVisualStyleBackColor = false;
            btnAccPrecios.Click += btnAccPrecios_Click;
            // 
            // btnAccSuplidores
            // 
            btnAccSuplidores.BackColor = Color.White;
            btnAccSuplidores.Cursor = Cursors.Hand;
            btnAccSuplidores.Dock = DockStyle.Top;
            btnAccSuplidores.FlatAppearance.BorderSize = 0;
            btnAccSuplidores.FlatStyle = FlatStyle.Flat;
            btnAccSuplidores.Font = new Font("Segoe UI", 10F);
            btnAccSuplidores.ForeColor = Color.FromArgb(22, 26, 36);
            btnAccSuplidores.Location = new Point(0, 100);
            btnAccSuplidores.Name = "btnAccSuplidores";
            btnAccSuplidores.Padding = new Padding(20, 0, 20, 0);
            btnAccSuplidores.Size = new Size(498, 50);
            btnAccSuplidores.TabIndex = 2;
            btnAccSuplidores.Text = "🚚  Gestión de Suplidores";
            btnAccSuplidores.TextAlign = ContentAlignment.MiddleLeft;
            btnAccSuplidores.UseVisualStyleBackColor = false;
            btnAccSuplidores.Click += btnAccSuplidores_Click;
            // 
            // btnAccCategorias
            // 
            btnAccCategorias.BackColor = Color.White;
            btnAccCategorias.Cursor = Cursors.Hand;
            btnAccCategorias.Dock = DockStyle.Top;
            btnAccCategorias.FlatAppearance.BorderSize = 0;
            btnAccCategorias.FlatStyle = FlatStyle.Flat;
            btnAccCategorias.Font = new Font("Segoe UI", 10F);
            btnAccCategorias.ForeColor = Color.FromArgb(22, 26, 36);
            btnAccCategorias.Location = new Point(0, 50);
            btnAccCategorias.Name = "btnAccCategorias";
            btnAccCategorias.Padding = new Padding(20, 0, 20, 0);
            btnAccCategorias.Size = new Size(498, 50);
            btnAccCategorias.TabIndex = 1;
            btnAccCategorias.Text = "🏷️  Gestión de Categorías";
            btnAccCategorias.TextAlign = ContentAlignment.MiddleLeft;
            btnAccCategorias.UseVisualStyleBackColor = false;
            btnAccCategorias.Click += btnAccCategorias_Click;
            // 
            // panelAccesosHeader
            // 
            panelAccesosHeader.BackColor = Color.FromArgb(245, 247, 251);
            panelAccesosHeader.Controls.Add(lblAccesosTitulo);
            panelAccesosHeader.Dock = DockStyle.Top;
            panelAccesosHeader.Location = new Point(0, 0);
            panelAccesosHeader.Name = "panelAccesosHeader";
            panelAccesosHeader.Padding = new Padding(20, 14, 20, 12);
            panelAccesosHeader.Size = new Size(498, 50);
            panelAccesosHeader.TabIndex = 0;
            // 
            // lblAccesosTitulo
            // 
            lblAccesosTitulo.AutoSize = true;
            lblAccesosTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAccesosTitulo.ForeColor = Color.FromArgb(22, 26, 36);
            lblAccesosTitulo.Location = new Point(18, 14);
            lblAccesosTitulo.Name = "lblAccesosTitulo";
            lblAccesosTitulo.Size = new Size(141, 23);
            lblAccesosTitulo.TabIndex = 0;
            lblAccesosTitulo.Text = "Accesos Rápidos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(1100, 650);
            Controls.Add(panelBody);
            Controls.Add(panelStats);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Dashboard";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelStats.ResumeLayout(false);
            cardStockBajo.ResumeLayout(false);
            cardStockBajo.PerformLayout();
            cardSuplidores.ResumeLayout(false);
            cardSuplidores.PerformLayout();
            cardProductos.ResumeLayout(false);
            cardProductos.PerformLayout();
            cardCategorias.ResumeLayout(false);
            cardCategorias.PerformLayout();
            panelBody.ResumeLayout(false);
            panelAccesos.ResumeLayout(false);
            panelAccesosHeader.ResumeLayout(false);
            panelAccesosHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel panelStats;
        private Panel cardCategorias;
        private Label lblTagCategorias;
        private Label lblValCategorias;
        private Panel cardProductos;
        private Label lblValProductos;
        private Label lblTagProductos;
        private Panel cardSuplidores;
        private Label lblValSuplidores;
        private Label lblTagSuplidores;
        private Panel cardStockBajo;
        private Label lblValStock;
        private Label lblTagStock;
        private Panel panelBody;
        private Panel panelAccesos;
        private Panel panelAccesosHeader;
        private Label lblAccesosTitulo;
        private Button btnAccCategorias;
        private Button btnAccSuplidores;
        private Button btnAccPrecios;
        private Button btnAccReasignar;
        private Button btnAccReporte;
    }
}
