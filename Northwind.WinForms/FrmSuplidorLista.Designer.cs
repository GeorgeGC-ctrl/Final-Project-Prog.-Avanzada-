namespace Northwind.WinForms
{
    partial class FrmSuplidorLista
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
            panelToolbar = new Panel();
            btnCerrar = new Button();
            btnRefrescar = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            dgvSuplidores = new DataGridView();
            panelFooter = new Panel();
            lblTotalPaises = new Label();
            lblTotalSuplidores = new Label();
            errorProvider = new ErrorProvider(components);
            panelHeader.SuspendLayout();
            panelToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuplidores).BeginInit();
            panelFooter.SuspendLayout();
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
            panelHeader.Size = new Size(1020, 90);
            panelHeader.TabIndex = 0;
            // 
            // lblEyebrow
            // 
            lblEyebrow.AutoSize = true;
            lblEyebrow.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblEyebrow.ForeColor = Color.FromArgb(136, 144, 160);
            lblEyebrow.Location = new Point(25, 12);
            lblEyebrow.Name = "lblEyebrow";
            lblEyebrow.Size = new Size(81, 19);
            lblEyebrow.TabIndex = 3;
            lblEyebrow.Text = "CATÁLOGO";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(91, 100, 116);
            lblSubtitulo.Location = new Point(25, 58);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(462, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Administración, consulta y eliminación con validación de dependencias";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(22, 26, 36);
            lblTitulo.Location = new Point(23, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(256, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Suplidores";
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = Color.White;
            panelToolbar.BorderStyle = BorderStyle.FixedSingle;
            panelToolbar.Controls.Add(btnCerrar);
            panelToolbar.Controls.Add(btnRefrescar);
            panelToolbar.Controls.Add(btnEliminar);
            panelToolbar.Controls.Add(btnEditar);
            panelToolbar.Controls.Add(btnNuevo);
            panelToolbar.Controls.Add(txtBuscar);
            panelToolbar.Controls.Add(lblBuscar);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 90);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Padding = new Padding(20, 14, 20, 14);
            panelToolbar.Size = new Size(1020, 68);
            panelToolbar.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.White;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderColor = Color.FromArgb(227, 231, 239);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 9.5F);
            btnCerrar.ForeColor = Color.FromArgb(22, 26, 36);
            btnCerrar.Location = new Point(915, 16);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(85, 35);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.BackColor = Color.White;
            btnRefrescar.Cursor = Cursors.Hand;
            btnRefrescar.FlatAppearance.BorderColor = Color.FromArgb(227, 231, 239);
            btnRefrescar.FlatStyle = FlatStyle.Flat;
            btnRefrescar.Font = new Font("Segoe UI", 9.5F);
            btnRefrescar.ForeColor = Color.FromArgb(22, 26, 36);
            btnRefrescar.Location = new Point(695, 16);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(95, 35);
            btnRefrescar.TabIndex = 5;
            btnRefrescar.Text = "Recargar";
            btnRefrescar.UseVisualStyleBackColor = false;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(192, 57, 43);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(585, 16);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 35);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(227, 231, 239);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEditar.ForeColor = Color.FromArgb(44, 78, 130);
            btnEditar.Location = new Point(480, 16);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(95, 35);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(44, 78, 130);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(345, 16);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(125, 35);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "+ Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.White;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 10F);
            txtBuscar.ForeColor = Color.FromArgb(22, 26, 36);
            txtBuscar.Location = new Point(85, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por nombre, país...";
            txtBuscar.Size = new Size(245, 30);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBuscar.ForeColor = Color.FromArgb(22, 26, 36);
            lblBuscar.Location = new Point(20, 23);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(64, 21);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar:";
            // 
            // dgvSuplidores
            // 
            dgvSuplidores.AllowUserToAddRows = false;
            dgvSuplidores.AllowUserToDeleteRows = false;
            dgvSuplidores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuplidores.BackgroundColor = Color.White;
            dgvSuplidores.BorderStyle = BorderStyle.None;
            dgvSuplidores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSuplidores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 247, 251);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(91, 100, 116);
            dataGridViewCellStyle1.Padding = new Padding(10, 8, 10, 8);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(245, 247, 251);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(91, 100, 116);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSuplidores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSuplidores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(22, 26, 36);
            dataGridViewCellStyle2.Padding = new Padding(8, 6, 8, 6);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(231, 237, 246);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 58, 99);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSuplidores.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSuplidores.Dock = DockStyle.Fill;
            dgvSuplidores.EnableHeadersVisualStyles = false;
            dgvSuplidores.GridColor = Color.FromArgb(227, 231, 239);
            dgvSuplidores.Location = new Point(0, 158);
            dgvSuplidores.MultiSelect = false;
            dgvSuplidores.Name = "dgvSuplidores";
            dgvSuplidores.ReadOnly = true;
            dgvSuplidores.RowHeadersVisible = false;
            dgvSuplidores.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(248, 250, 252);
            dgvSuplidores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvSuplidores.RowTemplate.Height = 36;
            dgvSuplidores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuplidores.Size = new Size(1020, 422);
            dgvSuplidores.TabIndex = 2;
            dgvSuplidores.CellDoubleClick += dgvSuplidores_CellDoubleClick;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(238, 241, 247);
            panelFooter.Controls.Add(lblTotalPaises);
            panelFooter.Controls.Add(lblTotalSuplidores);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 580);
            panelFooter.Name = "panelFooter";
            panelFooter.Padding = new Padding(25, 12, 25, 12);
            panelFooter.Size = new Size(1020, 50);
            panelFooter.TabIndex = 3;
            // 
            // lblTotalPaises
            // 
            lblTotalPaises.AutoSize = true;
            lblTotalPaises.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalPaises.ForeColor = Color.FromArgb(91, 100, 116);
            lblTotalPaises.Location = new Point(250, 14);
            lblTotalPaises.Name = "lblTotalPaises";
            lblTotalPaises.Size = new Size(160, 21);
            lblTotalPaises.TabIndex = 1;
            lblTotalPaises.Text = "Países Cubiertos: 0";
            // 
            // lblTotalSuplidores
            // 
            lblTotalSuplidores.AutoSize = true;
            lblTotalSuplidores.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalSuplidores.ForeColor = Color.FromArgb(44, 78, 130);
            lblTotalSuplidores.Location = new Point(25, 14);
            lblTotalSuplidores.Name = "lblTotalSuplidores";
            lblTotalSuplidores.Size = new Size(171, 21);
            lblTotalSuplidores.TabIndex = 0;
            lblTotalSuplidores.Text = "Total Suplidores: 0";
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // FrmSuplidorLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(1020, 630);
            Controls.Add(dgvSuplidores);
            Controls.Add(panelFooter);
            Controls.Add(panelToolbar);
            Controls.Add(panelHeader);
            Name = "FrmSuplidorLista";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de Suplidores";
            Load += FrmSuplidorLista_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelToolbar.ResumeLayout(false);
            panelToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuplidores).EndInit();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblEyebrow;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel panelToolbar;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnRefrescar;
        private Button btnCerrar;
        private DataGridView dgvSuplidores;
        private Panel panelFooter;
        private Label lblTotalSuplidores;
        private Label lblTotalPaises;
        private ErrorProvider errorProvider;
    }
}
