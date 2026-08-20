namespace Northwind.WinForms
{
    partial class FrmProductoLista
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
            panelToolbar = new Panel();
            btnRefrescar = new Button();
            btnNuevo = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            dgvProductos = new DataGridView();
            panelFooter = new Panel();
            lblTotalDescontinuados = new Label();
            lblTotalProductos = new Label();
            panelHeader.SuspendLayout();
            panelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panelFooter.SuspendLayout();
            SuspendLayout();
            //
            // panelHeader
            //
            panelHeader.BackColor = Color.FromArgb(255, 255, 255);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(25, 18, 25, 15);
            panelHeader.Size = new Size(1100, 85);
            panelHeader.TabIndex = 0;
            //
            // lblSubtitulo
            //
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(91, 100, 116);
            lblSubtitulo.Location = new Point(25, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(462, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Catálogo de productos, precios y existencias";
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(22, 26, 36);
            lblTitulo.Location = new Point(23, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(265, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Productos";
            //
            // panelToolbar
            //
            panelToolbar.BackColor = Color.FromArgb(255, 255, 255);
            panelToolbar.Controls.Add(btnRefrescar);
            panelToolbar.Controls.Add(btnNuevo);
            panelToolbar.Controls.Add(txtBuscar);
            panelToolbar.Controls.Add(lblBuscar);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 85);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Padding = new Padding(20, 14, 20, 14);
            panelToolbar.Size = new Size(1100, 68);
            panelToolbar.TabIndex = 1;
            //
            // btnRefrescar
            //
            btnRefrescar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefrescar.BackColor = Color.FromArgb(241, 245, 249);
            btnRefrescar.Cursor = Cursors.Hand;
            btnRefrescar.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Segoe UI", 9.5F);
            btnRefrescar.ForeColor = Color.FromArgb(71, 85, 105);
            btnRefrescar.Location = new Point(975, 16);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(95, 35);
            btnRefrescar.TabIndex = 4;
            btnRefrescar.Text = "Recargar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            //
            // btnNuevo
            //
            btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevo.BackColor = Color.FromArgb(44, 78, 130);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(860, 16);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(125, 35);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "+ Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            //
            // txtBuscar
            //
            txtBuscar.BackColor = Color.FromArgb(248, 250, 252);
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 10F);
            txtBuscar.ForeColor = Color.FromArgb(22, 26, 36);
            txtBuscar.Location = new Point(85, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por nombre, categoría, suplidor...";
            txtBuscar.Size = new Size(300, 30);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            //
            // lblBuscar
            //
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.FromArgb(71, 85, 105);
            lblBuscar.Location = new Point(20, 23);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(64, 21);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar:";
            //
            // dgvProductos
            //
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.Padding = new Padding(10, 8, 10, 8);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.Padding = new Padding(8, 6, 8, 6);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = Color.FromArgb(226, 232, 240);
            dgvProductos.Location = new Point(0, 153);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.RowTemplate.Height = 36;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(1100, 397);
            dgvProductos.TabIndex = 2;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
            //
            // panelFooter
            //
            panelFooter.BackColor = Color.FromArgb(241, 245, 249);
            panelFooter.Controls.Add(lblTotalDescontinuados);
            panelFooter.Controls.Add(lblTotalProductos);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 550);
            panelFooter.Name = "panelFooter";
            panelFooter.Padding = new Padding(25, 12, 25, 12);
            panelFooter.Size = new Size(1100, 50);
            panelFooter.TabIndex = 3;
            //
            // lblTotalDescontinuados
            //
            lblTotalDescontinuados.AutoSize = true;
            lblTotalDescontinuados.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalDescontinuados.ForeColor = Color.FromArgb(91, 100, 116);
            lblTotalDescontinuados.Location = new Point(250, 14);
            lblTotalDescontinuados.Name = "lblTotalDescontinuados";
            lblTotalDescontinuados.Size = new Size(200, 21);
            lblTotalDescontinuados.TabIndex = 1;
            lblTotalDescontinuados.Text = "Descontinuados: 0";
            //
            // lblTotalProductos
            //
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalProductos.ForeColor = Color.FromArgb(44, 78, 130);
            lblTotalProductos.Location = new Point(25, 14);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(171, 21);
            lblTotalProductos.TabIndex = 0;
            lblTotalProductos.Text = "Total Productos: 0";
            //
            // FrmProductoLista
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(1100, 600);
            Controls.Add(dgvProductos);
            Controls.Add(panelFooter);
            Controls.Add(panelToolbar);
            Controls.Add(panelHeader);
            MinimumSize = new Size(900, 500);
            Name = "FrmProductoLista";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de Productos";
            Load += FrmProductoLista_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelToolbar.ResumeLayout(false);
            panelToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel panelToolbar;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnNuevo;
        private Button btnRefrescar;
        private DataGridView dgvProductos;
        private Panel panelFooter;
        private Label lblTotalProductos;
        private Label lblTotalDescontinuados;
    }
}
