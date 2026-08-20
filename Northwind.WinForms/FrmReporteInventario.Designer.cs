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
            panelHeader.BackColor = Color.FromArgb(26, 29, 39);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(25, 18, 25, 15);
            panelHeader.Size = new Size(960, 85);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(148, 163, 184);
            lblSubtitulo.Location = new Point(25, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(393, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Análisis consolidado del valor de existencias por categoría";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(226, 232, 240);
            lblTitulo.Location = new Point(23, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(516, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reporte de Valor de Inventario por Categoría";
            // 
            // panelFiltros
            // 
            panelFiltros.BackColor = Color.FromArgb(33, 37, 58);
            panelFiltros.Controls.Add(cmbCategorias);
            panelFiltros.Controls.Add(lblFiltroCategoria);
            panelFiltros.Controls.Add(btnGenerar);
            panelFiltros.Controls.Add(btnCerrar);
            panelFiltros.Dock = DockStyle.Top;
            panelFiltros.Location = new Point(0, 85);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Padding = new Padding(25, 15, 25, 15);
            panelFiltros.Size = new Size(960, 68);
            panelFiltros.TabIndex = 1;
            // 
            // cmbCategorias
            // 
            cmbCategorias.BackColor = Color.FromArgb(26, 29, 39);
            cmbCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategorias.FlatStyle = FlatStyle.Flat;
            cmbCategorias.Font = new Font("Segoe UI", 10F);
            cmbCategorias.ForeColor = Color.FromArgb(226, 232, 240);
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
            lblFiltroCategoria.ForeColor = Color.FromArgb(226, 232, 240);
            lblFiltroCategoria.Location = new Point(25, 22);
            lblFiltroCategoria.Name = "lblFiltroCategoria";
            lblFiltroCategoria.Size = new Size(90, 21);
            lblFiltroCategoria.TabIndex = 0;
            lblFiltroCategoria.Text = "Categoría:";
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(99, 102, 241);
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
            btnCerrar.BackColor = Color.FromArgb(26, 29, 39);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderColor = Color.FromArgb(46, 51, 80);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 9.5F);
            btnCerrar.ForeColor = Color.FromArgb(148, 163, 184);
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
            dgvReporte.BackgroundColor = Color.FromArgb(15, 17, 23);
            dgvReporte.BorderStyle = BorderStyle.None;
            dgvReporte.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReporte.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 29, 39);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(129, 140, 248);
            dataGridViewCellStyle1.Padding = new Padding(10, 8, 10, 8);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(26, 29, 39);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(129, 140, 248);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(21, 24, 34);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(226, 232, 240);
            dataGridViewCellStyle2.Padding = new Padding(8, 6, 8, 6);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(99, 102, 241);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReporte.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReporte.Dock = DockStyle.Fill;
            dgvReporte.EnableHeadersVisualStyles = false;
            dgvReporte.GridColor = Color.FromArgb(46, 51, 80);
            dgvReporte.Location = new Point(0, 153);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(21, 24, 34);
            dgvReporte.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvReporte.RowTemplate.Height = 36;
            dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporte.Size = new Size(960, 362);
            dgvReporte.TabIndex = 2;
            // 
            // panelStats
            // 
            panelStats.BackColor = Color.FromArgb(26, 29, 39);
            panelStats.Controls.Add(cardValor);
            panelStats.Controls.Add(cardUnidades);
            panelStats.Controls.Add(cardProductos);
            panelStats.Dock = DockStyle.Bottom;
            panelStats.Location = new Point(0, 515);
            panelStats.Name = "panelStats";
            panelStats.Padding = new Padding(20, 12, 20, 12);
            panelStats.Size = new Size(960, 85);
            panelStats.TabIndex = 3;
            // 
            // cardValor
            // 
            cardValor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cardValor.BackColor = Color.FromArgb(33, 37, 58);
            cardValor.Controls.Add(lblTotalValor);
            cardValor.Controls.Add(lblTagValor);
            cardValor.Location = new Point(640, 12);
            cardValor.Name = "cardValor";
            cardValor.Padding = new Padding(15, 8, 15, 8);
            cardValor.Size = new Size(295, 60);
            cardValor.TabIndex = 2;
            // 
            // lblTotalValor
            // 
            lblTotalValor.AutoSize = true;
            lblTotalValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalValor.ForeColor = Color.FromArgb(34, 197, 94);
            lblTotalValor.Location = new Point(12, 26);
            lblTotalValor.Name = "lblTotalValor";
            lblTotalValor.Size = new Size(62, 28);
            lblTotalValor.TabIndex = 1;
            lblTotalValor.Text = "$0.00";
            // 
            // lblTagValor
            // 
            lblTagValor.AutoSize = true;
            lblTagValor.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTagValor.ForeColor = Color.FromArgb(148, 163, 184);
            lblTagValor.Location = new Point(12, 8);
            lblTagValor.Name = "lblTagValor";
            lblTagValor.Size = new Size(183, 19);
            lblTagValor.TabIndex = 0;
            lblTagValor.Text = "VALOR TOTAL INVENTARIO";
            // 
            // cardUnidades
            // 
            cardUnidades.BackColor = Color.FromArgb(33, 37, 58);
            cardUnidades.Controls.Add(lblTotalUnidades);
            cardUnidades.Controls.Add(lblTagUnidades);
            cardUnidades.Location = new Point(290, 12);
            cardUnidades.Name = "cardUnidades";
            cardUnidades.Padding = new Padding(15, 8, 15, 8);
            cardUnidades.Size = new Size(240, 60);
            cardUnidades.TabIndex = 1;
            // 
            // lblTotalUnidades
            // 
            lblTotalUnidades.AutoSize = true;
            lblTotalUnidades.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalUnidades.ForeColor = Color.FromArgb(226, 232, 240);
            lblTotalUnidades.Location = new Point(12, 26);
            lblTotalUnidades.Name = "lblTotalUnidades";
            lblTotalUnidades.Size = new Size(24, 28);
            lblTotalUnidades.TabIndex = 1;
            lblTotalUnidades.Text = "0";
            // 
            // lblTagUnidades
            // 
            lblTagUnidades.AutoSize = true;
            lblTagUnidades.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTagUnidades.ForeColor = Color.FromArgb(148, 163, 184);
            lblTagUnidades.Location = new Point(12, 8);
            lblTagUnidades.Name = "lblTagUnidades";
            lblTagUnidades.Size = new Size(125, 19);
            lblTagUnidades.TabIndex = 0;
            lblTagUnidades.Text = "TOTAL UNIDADES";
            // 
            // cardProductos
            // 
            cardProductos.BackColor = Color.FromArgb(33, 37, 58);
            cardProductos.Controls.Add(lblTotalProductos);
            cardProductos.Controls.Add(lblTagProductos);
            cardProductos.Location = new Point(25, 12);
            cardProductos.Name = "cardProductos";
            cardProductos.Padding = new Padding(15, 8, 15, 8);
            cardProductos.Size = new Size(240, 60);
            cardProductos.TabIndex = 0;
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotalProductos.ForeColor = Color.FromArgb(226, 232, 240);
            lblTotalProductos.Location = new Point(12, 26);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(24, 28);
            lblTotalProductos.TabIndex = 1;
            lblTotalProductos.Text = "0";
            // 
            // lblTagProductos
            // 
            lblTagProductos.AutoSize = true;
            lblTagProductos.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTagProductos.ForeColor = Color.FromArgb(148, 163, 184);
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
            BackColor = Color.FromArgb(15, 17, 23);
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
