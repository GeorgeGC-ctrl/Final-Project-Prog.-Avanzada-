namespace Northwind.WinForms
{
    partial class FrmReporteInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lblEyebrow = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            panelFiltros = new Panel();
            cmbCategorias = new ComboBox();
            lblFiltroCategoria = new Label();
            btnGenerar = new Button();
            btnCerrar = new Button();
            dgvReporte = new DataGridView();
            panelStats = new Panel();
            cardValor = new Panel();
            lblTotalValor = new Label();
            lblTagValor = new Label();
            cardUnidades = new Panel();
            lblTotalUnidades = new Label();
            lblTagUnidades = new Label();
            cardProductos = new Panel();
            lblTotalProductos = new Label();
            lblTagProductos = new Label();
            errorProvider = new ErrorProvider(components);
            panelHeader.SuspendLayout();
            panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            panelStats.SuspendLayout();
            cardValor.SuspendLayout();
            cardUnidades.SuspendLayout();
            cardProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(lblEyebrow);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(25, 16, 25, 14);
            panelHeader.Size = new Size(960, 90);
            panelHeader.TabIndex = 0;
            // 
            // lblEyebrow
            // 
            lblEyebrow.AutoSize = true;
            lblEyebrow.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblEyebrow.ForeColor = Color.FromArgb(136, 144, 160);
            lblEyebrow.Location = new Point(25, 12);
            lblEyebrow.Name = "lblEyebrow";
            lblEyebrow.Size = new Size(153, 19);
            lblEyebrow.TabIndex = 2;
            lblEyebrow.Text = "REPORTES Y ANÁLISIS";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(91, 100, 116);
            lblSubtitulo.Location = new Point(25, 58);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(393, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Análisis consolidado del valor de existencias por categoría";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(22, 26, 36);
            lblTitulo.Location = new Point(23, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(504, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reporte de Valor de Inventario por Categoría";
            // 
            // panelFiltros
            // 
            panelFiltros.BackColor = Color.White;
            panelFiltros.BorderStyle = BorderStyle.FixedSingle;
            panelFiltros.Controls.Add(cmbCategorias);
            panelFiltros.Controls.Add(lblFiltroCategoria);
            panelFiltros.Controls.Add(btnGenerar);
            panelFiltros.Controls.Add(btnCerrar);
            panelFiltros.Dock = DockStyle.Top;
            panelFiltros.Location = new Point(0, 90);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Padding = new Padding(25, 14, 25, 14);
            panelFiltros.Size = new Size(960, 68);
            panelFiltros.TabIndex = 1;
            // 
            // cmbCategorias
            // 
            cmbCategorias.BackColor = Color.White;
            cmbCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategorias.FlatStyle = FlatStyle.Flat;
            cmbCategorias.Font = new Font("Segoe UI", 10F);
            cmbCategorias.ForeColor = Color.FromArgb(22, 26, 36);
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(125, 18);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(340, 31);
            cmbCategorias.TabIndex = 1;
            cmbCategorias.SelectedIndexChanged += cmbCategorias_SelectedIndexChanged;
            // 
            // lblFiltroCategoria
            // 
            lblFiltroCategoria.AutoSize = true;
            lblFiltroCategoria.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblFiltroCategoria.ForeColor = Color.FromArgb(22, 26, 36);
            lblFiltroCategoria.Location = new Point(25, 22);
            lblFiltroCategoria.Name = "lblFiltroCategoria";
            lblFiltroCategoria.Size = new Size(90, 21);
            lblFiltroCategoria.TabIndex = 0;
            lblFiltroCategoria.Text = "Categoría:";
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(44, 78, 130);
            btnGenerar.Cursor = Cursors.Hand;
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(480, 16);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(130, 35);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Actualizar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.White;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderColor = Color.FromArgb(227, 231, 239);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.FromArgb(22, 26, 36);
            btnCerrar.Location = new Point(835, 16);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 35);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // dgvReporte
            // 
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AllowUserToDeleteRows = false;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.BackgroundColor = Color.White;
            dgvReporte.BorderStyle = BorderStyle.None;
            dgvReporte.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReporte.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 247, 251);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(91, 100, 116);
            dataGridViewCellStyle1.Padding = new Padding(10, 8, 10, 8);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(245, 247, 251);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(91, 100, 116);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(22, 26, 36);
            dataGridViewCellStyle2.Padding = new Padding(8, 6, 8, 6);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 237, 246);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 58, 99);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReporte.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReporte.Dock = DockStyle.Fill;
            dgvReporte.EnableHeadersVisualStyles = false;
            dgvReporte.GridColor = Color.FromArgb(227, 231, 239);
            dgvReporte.Location = new Point(0, 158);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(248, 250, 252);
            dgvReporte.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvReporte.RowTemplate.Height = 36;
            dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporte.Size = new Size(960, 347);
            dgvReporte.TabIndex = 2;
            // 
            // panelStats
            // 
            panelStats.BackColor = Color.FromArgb(238, 241, 247);
            panelStats.Controls.Add(cardValor);
            panelStats.Controls.Add(cardUnidades);
            panelStats.Controls.Add(cardProductos);
            panelStats.Dock = DockStyle.Bottom;
            panelStats.Location = new Point(0, 505);
            panelStats.Name = "panelStats";
            panelStats.Padding = new Padding(20, 12, 20, 12);
            panelStats.Size = new Size(960, 95);
            panelStats.TabIndex = 3;
            // 
            // cardValor
            // 
            cardValor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cardValor.BackColor = Color.White;
            cardValor.BorderStyle = BorderStyle.FixedSingle;
            cardValor.Controls.Add(lblTotalValor);
            cardValor.Controls.Add(lblTagValor);
            cardValor.Location = new Point(640, 12);
            cardValor.Name = "cardValor";
            cardValor.Padding = new Padding(15, 8, 15, 8);
            cardValor.Size = new Size(295, 68);
            cardValor.TabIndex = 2;
            // 
            // lblTotalValor
            // 
            lblTotalValor.AutoSize = true;
            lblTotalValor.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTotalValor.ForeColor = Color.FromArgb(31, 138, 95);
            lblTotalValor.Location = new Point(12, 28);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(70, 30);
            lblTotalValor.TabIndex = 1;
            lblTotalValor.Text = "$0.00";
            // 
            // lblTagValor
            // 
            lblTagValor.AutoSize = true;
            lblTagValor.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTagValor.ForeColor = Color.FromArgb(136, 144, 160);
            lblTagValor.Location = new Point(12, 8);
            lblTagValor.Name = "lblTagValor";
            lblTagValor.Size = new Size(183, 19);
            lblTagValor.TabIndex = 0;
            lblTagValor.Text = "VALOR TOTAL INVENTARIO";
            // 
            // cardUnidades
            // 
            cardUnidades.BackColor = Color.White;
            cardUnidades.BorderStyle = BorderStyle.FixedSingle;
            cardUnidades.Controls.Add(lblTotalUnidades);
            cardUnidades.Controls.Add(lblTagUnidades);
            cardUnidades.Location = new Point(290, 12);
            cardUnidades.Name = "cardUnidades";
            cardUnidades.Padding = new Padding(15, 8, 15, 8);
            cardUnidades.Size = new Size(240, 68);
            cardUnidades.TabIndex = 1;
            // 
            // lblTotalUnidades
            // 
            lblTotalUnidades.AutoSize = true;
            lblTotalUnidades.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTotalUnidades.ForeColor = Color.FromArgb(22, 26, 36);
            lblTotalUnidades.Location = new Point(12, 28);
            lblTotalUnidades.Name = "lblTotalUnidades";
            lblTotalUnidades.Size = new Size(26, 30);
            lblTotalUnidades.TabIndex = 1;
            lblTotalUnidades.Text = "0";
            // 
            // lblTagUnidades
            // 
            lblTagUnidades.AutoSize = true;
            lblTagUnidades.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTagUnidades.ForeColor = Color.FromArgb(136, 144, 160);
            lblTagUnidades.Location = new Point(12, 8);
            lblTagUnidades.Name = "lblTagUnidades";
            lblTagUnidades.Size = new Size(125, 19);
            lblTagUnidades.TabIndex = 0;
            lblTagUnidades.Text = "TOTAL UNIDADES";
            // 
            // cardProductos
            // 
            cardProductos.BackColor = Color.White;
            cardProductos.BorderStyle = BorderStyle.FixedSingle;
            cardProductos.Controls.Add(lblTotalProductos);
            cardProductos.Controls.Add(lblTagProductos);
            cardProductos.Location = new Point(25, 12);
            cardProductos.Name = "cardProductos";
            cardProductos.Padding = new Padding(15, 8, 15, 8);
            cardProductos.Size = new Size(240, 68);
            cardProductos.TabIndex = 0;
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTotalProductos.ForeColor = Color.FromArgb(22, 26, 36);
            lblTotalProductos.Location = new Point(12, 28);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(26, 30);
            lblTotalProductos.TabIndex = 1;
            lblTotalProductos.Text = "0";
            // 
            // lblTagProductos
            // 
            lblTagProductos.AutoSize = true;
            lblTagProductos.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTagProductos.ForeColor = Color.FromArgb(136, 144, 160);
            lblTagProductos.Location = new Point(12, 8);
            lblTagProductos.Name = "lblTagProductos";
            lblTagProductos.Size = new Size(140, 19);
            lblTagProductos.TabIndex = 0;
            lblTagProductos.Text = "TOTAL PRODUCTOS";
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // FrmReporteInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(960, 600);
            Controls.Add(dgvReporte);
            Controls.Add(panelStats);
            Controls.Add(panelFiltros);
            Controls.Add(panelHeader);
            Name = "FrmReporteInventario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reporte de Valor de Inventario por Categoría";
            Load += FrmReporteInventario_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            panelStats.ResumeLayout(false);
            cardValor.ResumeLayout(false);
            cardValor.PerformLayout();
            cardUnidades.ResumeLayout(false);
            cardUnidades.PerformLayout();
            cardProductos.ResumeLayout(false);
            cardProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblEyebrow;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel panelFiltros;
        private Label lblFiltroCategoria;
        private ComboBox cmbCategorias;
        private Button btnGenerar;
        private Button btnCerrar;
        private DataGridView dgvReporte;
        private Panel panelStats;
        private Panel cardProductos;
        private Label lblTotalProductos;
        private Label lblTagProductos;
        private Panel cardUnidades;
        private Label lblTotalUnidades;
        private Label lblTagUnidades;
        private Panel cardValor;
        private Label lblTotalValor;
        private Label lblTagValor;
        private ErrorProvider errorProvider;
    }
}
