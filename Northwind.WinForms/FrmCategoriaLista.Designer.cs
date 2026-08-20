namespace Northwind.WinForms
{
    partial class FrmCategoriaLista
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            panelToolbar = new Panel();
            btnActualizar = new Button();
            btnNuevo = new Button();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            panelGrid = new Panel();
            dgvCategorias = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colEditar = new DataGridViewButtonColumn();
            colEliminar = new DataGridViewButtonColumn();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            panelHeader.SuspendLayout();
            panelToolbar.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(30, 41, 59);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(20, 15, 20, 15);
            panelHeader.Size = new Size(884, 75);
            panelHeader.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubtitulo.ForeColor = Color.FromArgb(148, 163, 184);
            lblSubtitulo.Location = new Point(20, 42);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(244, 15);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gestión y administración de categorías de productos";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(213, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Catálogo de Categorías";
            // 
            // panelToolbar
            // 
            panelToolbar.BackColor = Color.White;
            panelToolbar.Controls.Add(btnActualizar);
            panelToolbar.Controls.Add(btnNuevo);
            panelToolbar.Controls.Add(txtBuscar);
            panelToolbar.Controls.Add(lblBuscar);
            panelToolbar.Dock = DockStyle.Top;
            panelToolbar.Location = new Point(0, 75);
            panelToolbar.Name = "panelToolbar";
            panelToolbar.Padding = new Padding(20, 12, 20, 12);
            panelToolbar.Size = new Size(884, 55);
            panelToolbar.TabIndex = 1;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.BackColor = Color.FromArgb(241, 245, 249);
            btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnActualizar.ForeColor = Color.FromArgb(51, 65, 85);
            btnActualizar.Location = new Point(774, 12);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 30);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "🔄 Refrescar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            //
            // btnNuevo
            //
            btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevo.BackColor = Color.FromArgb(37, 99, 235);
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(664, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 30);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "➕ Nueva";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(78, 15);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Filtrar por nombre o descripción...";
            txtBuscar.Size = new Size(280, 25);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscar.ForeColor = Color.FromArgb(71, 85, 105);
            lblBuscar.Location = new Point(20, 18);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(49, 17);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar:";
            // 
            // panelGrid
            // 
            panelGrid.BackColor = Color.FromArgb(248, 250, 252);
            panelGrid.Controls.Add(dgvCategorias);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 130);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(20);
            panelGrid.Size = new Size(884, 381);
            panelGrid.TabIndex = 2;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.AllowUserToResizeRows = false;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.BackgroundColor = Color.White;
            dgvCategorias.BorderStyle = BorderStyle.None;
            dgvCategorias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(241, 245, 249);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategorias.ColumnHeadersHeight = 40;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { colId, colNombre, colDescripcion, colEditar, colEliminar });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 65, 85);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 231, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategorias.Dock = DockStyle.Fill;
            dgvCategorias.EnableHeadersVisualStyles = false;
            dgvCategorias.Location = new Point(20, 20);
            dgvCategorias.MultiSelect = false;
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowTemplate.Height = 36;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(844, 341);
            dgvCategorias.TabIndex = 0;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            dgvCategorias.CellDoubleClick += dgvCategorias_CellDoubleClick;
            //
            // colId
            // 
            colId.DataPropertyName = "CategoryId";
            colId.FillWeight = 25F;
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "CategoryName";
            colNombre.FillWeight = 75F;
            colNombre.HeaderText = "Nombre de Categoría";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colDescripcion
            // 
            colDescripcion.DataPropertyName = "Description";
            colDescripcion.FillWeight = 150F;
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.Name = "colDescripcion";
            colDescripcion.ReadOnly = true;
            //
            // colEditar
            //
            colEditar.FillWeight = 45F;
            colEditar.HeaderText = "";
            colEditar.Name = "colEditar";
            colEditar.ReadOnly = true;
            colEditar.Resizable = DataGridViewTriState.False;
            colEditar.SortMode = DataGridViewColumnSortMode.NotSortable;
            colEditar.Text = "✏️ Editar";
            colEditar.UseColumnTextForButtonValue = true;
            //
            // colEliminar
            //
            colEliminar.FillWeight = 45F;
            colEliminar.HeaderText = "";
            colEliminar.Name = "colEliminar";
            colEliminar.ReadOnly = true;
            colEliminar.Resizable = DataGridViewTriState.False;
            colEliminar.SortMode = DataGridViewColumnSortMode.NotSortable;
            colEliminar.Text = "🗑️ Eliminar";
            colEliminar.UseColumnTextForButtonValue = true;
            //
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 511);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(884, 22);
            statusStrip1.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.FromArgb(100, 116, 139);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(118, 17);
            lblStatus.Text = "Cargando categorías...";
            // 
            // FrmCategoriaLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 533);
            Controls.Add(panelGrid);
            Controls.Add(panelToolbar);
            Controls.Add(panelHeader);
            Controls.Add(statusStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(700, 450);
            Name = "FrmCategoriaLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Categorías";
            Load += FrmCategoriaLista_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelToolbar.ResumeLayout(false);
            panelToolbar.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label lblSubtitulo;
        private Label lblTitulo;
        private Panel panelToolbar;
        private Button btnActualizar;
        private Button btnNuevo;
        private TextBox txtBuscar;
        private Label lblBuscar;
        private Panel panelGrid;
        private DataGridView dgvCategorias;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewButtonColumn colEditar;
        private DataGridViewButtonColumn colEliminar;
    }
}
