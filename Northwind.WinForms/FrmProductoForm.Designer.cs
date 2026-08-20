namespace Northwind.WinForms
{
    partial class FrmProductoForm
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
            panelHeader = new Panel();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            panelCard = new Panel();
            chkDescontinuado = new CheckBox();
            txtReorden = new TextBox();
            lblReorden = new Label();
            txtEnOrden = new TextBox();
            lblEnOrden = new Label();
            txtStock = new TextBox();
            lblStock = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtCantidadPorUnidad = new TextBox();
            lblCantidadPorUnidad = new Label();
            cmbSuplidor = new ComboBox();
            lblSuplidor = new Label();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            panelActions = new Panel();
            btnGuardar = new Button();
            btnCancelar = new Button();
            errorProvider = new ErrorProvider(components);
            panelHeader.SuspendLayout();
            panelCard.SuspendLayout();
            panelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
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
            panelHeader.Size = new Size(560, 85);
            panelHeader.TabIndex = 0;
            //
            // lblSubtitulo
            //
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(91, 100, 116);
            lblSubtitulo.Location = new Point(25, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(300, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Complete la información del producto";
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(22, 26, 36);
            lblTitulo.Location = new Point(23, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(200, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nuevo Producto";
            //
            // panelCard
            //
            panelCard.BackColor = Color.FromArgb(255, 255, 255);
            panelCard.Controls.Add(chkDescontinuado);
            panelCard.Controls.Add(txtReorden);
            panelCard.Controls.Add(lblReorden);
            panelCard.Controls.Add(txtEnOrden);
            panelCard.Controls.Add(lblEnOrden);
            panelCard.Controls.Add(txtStock);
            panelCard.Controls.Add(lblStock);
            panelCard.Controls.Add(txtPrecio);
            panelCard.Controls.Add(lblPrecio);
            panelCard.Controls.Add(txtCantidadPorUnidad);
            panelCard.Controls.Add(lblCantidadPorUnidad);
            panelCard.Controls.Add(cmbSuplidor);
            panelCard.Controls.Add(lblSuplidor);
            panelCard.Controls.Add(cmbCategoria);
            panelCard.Controls.Add(lblCategoria);
            panelCard.Controls.Add(txtNombre);
            panelCard.Controls.Add(lblNombre);
            panelCard.Location = new Point(25, 105);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(20);
            panelCard.Size = new Size(510, 420);
            panelCard.TabIndex = 1;
            //
            // lblNombre
            //
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(51, 65, 85);
            lblNombre.Location = new Point(20, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(160, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre del Producto *";
            //
            // txtNombre
            //
            txtNombre.BackColor = Color.FromArgb(248, 250, 252);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.ForeColor = Color.FromArgb(22, 26, 36);
            txtNombre.Location = new Point(20, 48);
            txtNombre.MaxLength = 40;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(465, 30);
            txtNombre.TabIndex = 1;
            //
            // lblCategoria
            //
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCategoria.ForeColor = Color.FromArgb(51, 65, 85);
            lblCategoria.Location = new Point(20, 88);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(78, 21);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoría";
            //
            // cmbCategoria
            //
            cmbCategoria.BackColor = Color.FromArgb(248, 250, 252);
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FlatStyle = FlatStyle.Flat;
            cmbCategoria.Font = new Font("Segoe UI", 10F);
            cmbCategoria.ForeColor = Color.FromArgb(22, 26, 36);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(20, 116);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(225, 31);
            cmbCategoria.TabIndex = 3;
            //
            // lblSuplidor
            //
            lblSuplidor.AutoSize = true;
            lblSuplidor.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSuplidor.ForeColor = Color.FromArgb(51, 65, 85);
            lblSuplidor.Location = new Point(260, 88);
            lblSuplidor.Name = "lblSuplidor";
            lblSuplidor.Size = new Size(68, 21);
            lblSuplidor.TabIndex = 4;
            lblSuplidor.Text = "Suplidor";
            //
            // cmbSuplidor
            //
            cmbSuplidor.BackColor = Color.FromArgb(248, 250, 252);
            cmbSuplidor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSuplidor.FlatStyle = FlatStyle.Flat;
            cmbSuplidor.Font = new Font("Segoe UI", 10F);
            cmbSuplidor.ForeColor = Color.FromArgb(22, 26, 36);
            cmbSuplidor.FormattingEnabled = true;
            cmbSuplidor.Location = new Point(260, 116);
            cmbSuplidor.Name = "cmbSuplidor";
            cmbSuplidor.Size = new Size(225, 31);
            cmbSuplidor.TabIndex = 5;
            //
            // lblCantidadPorUnidad
            //
            lblCantidadPorUnidad.AutoSize = true;
            lblCantidadPorUnidad.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCantidadPorUnidad.ForeColor = Color.FromArgb(51, 65, 85);
            lblCantidadPorUnidad.Location = new Point(20, 158);
            lblCantidadPorUnidad.Name = "lblCantidadPorUnidad";
            lblCantidadPorUnidad.Size = new Size(140, 21);
            lblCantidadPorUnidad.TabIndex = 6;
            lblCantidadPorUnidad.Text = "Cantidad por Unidad";
            //
            // txtCantidadPorUnidad
            //
            txtCantidadPorUnidad.BackColor = Color.FromArgb(248, 250, 252);
            txtCantidadPorUnidad.BorderStyle = BorderStyle.FixedSingle;
            txtCantidadPorUnidad.Font = new Font("Segoe UI", 10F);
            txtCantidadPorUnidad.ForeColor = Color.FromArgb(22, 26, 36);
            txtCantidadPorUnidad.Location = new Point(20, 186);
            txtCantidadPorUnidad.MaxLength = 20;
            txtCantidadPorUnidad.Name = "txtCantidadPorUnidad";
            txtCantidadPorUnidad.PlaceholderText = "Ej. 10 boxes x 20 bags";
            txtCantidadPorUnidad.Size = new Size(465, 30);
            txtCantidadPorUnidad.TabIndex = 7;
            //
            // lblPrecio
            //
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPrecio.ForeColor = Color.FromArgb(51, 65, 85);
            lblPrecio.Location = new Point(20, 228);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(110, 21);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio Unitario";
            //
            // txtPrecio
            //
            txtPrecio.BackColor = Color.FromArgb(248, 250, 252);
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Font = new Font("Segoe UI", 10F);
            txtPrecio.ForeColor = Color.FromArgb(22, 26, 36);
            txtPrecio.Location = new Point(20, 256);
            txtPrecio.MaxLength = 12;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(225, 30);
            txtPrecio.TabIndex = 9;
            //
            // lblStock
            //
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblStock.ForeColor = Color.FromArgb(51, 65, 85);
            lblStock.Location = new Point(260, 228);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(120, 21);
            lblStock.TabIndex = 10;
            lblStock.Text = "Unidades en Stock";
            //
            // txtStock
            //
            txtStock.BackColor = Color.FromArgb(248, 250, 252);
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Font = new Font("Segoe UI", 10F);
            txtStock.ForeColor = Color.FromArgb(22, 26, 36);
            txtStock.Location = new Point(260, 256);
            txtStock.MaxLength = 6;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(225, 30);
            txtStock.TabIndex = 11;
            //
            // lblEnOrden
            //
            lblEnOrden.AutoSize = true;
            lblEnOrden.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEnOrden.ForeColor = Color.FromArgb(51, 65, 85);
            lblEnOrden.Location = new Point(20, 298);
            lblEnOrden.Name = "lblEnOrden";
            lblEnOrden.Size = new Size(120, 21);
            lblEnOrden.TabIndex = 12;
            lblEnOrden.Text = "Unidades en Orden";
            //
            // txtEnOrden
            //
            txtEnOrden.BackColor = Color.FromArgb(248, 250, 252);
            txtEnOrden.BorderStyle = BorderStyle.FixedSingle;
            txtEnOrden.Font = new Font("Segoe UI", 10F);
            txtEnOrden.ForeColor = Color.FromArgb(22, 26, 36);
            txtEnOrden.Location = new Point(20, 326);
            txtEnOrden.MaxLength = 6;
            txtEnOrden.Name = "txtEnOrden";
            txtEnOrden.Size = new Size(225, 30);
            txtEnOrden.TabIndex = 13;
            //
            // lblReorden
            //
            lblReorden.AutoSize = true;
            lblReorden.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblReorden.ForeColor = Color.FromArgb(51, 65, 85);
            lblReorden.Location = new Point(260, 298);
            lblReorden.Name = "lblReorden";
            lblReorden.Size = new Size(120, 21);
            lblReorden.TabIndex = 14;
            lblReorden.Text = "Nivel de Reorden";
            //
            // txtReorden
            //
            txtReorden.BackColor = Color.FromArgb(248, 250, 252);
            txtReorden.BorderStyle = BorderStyle.FixedSingle;
            txtReorden.Font = new Font("Segoe UI", 10F);
            txtReorden.ForeColor = Color.FromArgb(22, 26, 36);
            txtReorden.Location = new Point(260, 326);
            txtReorden.MaxLength = 6;
            txtReorden.Name = "txtReorden";
            txtReorden.Size = new Size(225, 30);
            txtReorden.TabIndex = 15;
            //
            // chkDescontinuado
            //
            chkDescontinuado.AutoSize = true;
            chkDescontinuado.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            chkDescontinuado.ForeColor = Color.FromArgb(51, 65, 85);
            chkDescontinuado.Location = new Point(20, 372);
            chkDescontinuado.Name = "chkDescontinuado";
            chkDescontinuado.Size = new Size(150, 25);
            chkDescontinuado.TabIndex = 16;
            chkDescontinuado.Text = "Producto Descontinuado";
            //
            // panelActions
            //
            panelActions.BackColor = Color.FromArgb(248, 250, 252);
            panelActions.Controls.Add(btnGuardar);
            panelActions.Controls.Add(btnCancelar);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(0, 525);
            panelActions.Name = "panelActions";
            panelActions.Padding = new Padding(25, 10, 25, 15);
            panelActions.Size = new Size(560, 75);
            panelActions.TabIndex = 2;
            //
            // btnGuardar
            //
            btnGuardar.BackColor = Color.FromArgb(44, 78, 130);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(275, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 42);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            //
            // btnCancelar
            //
            btnCancelar.BackColor = Color.FromArgb(241, 245, 249);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ForeColor = Color.FromArgb(71, 85, 105);
            btnCancelar.Location = new Point(445, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 42);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            //
            // errorProvider
            //
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            //
            // FrmProductoForm
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(560, 600);
            Controls.Add(panelActions);
            Controls.Add(panelCard);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmProductoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Formulario de Producto";
            Load += FrmProductoForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            panelActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel panelCard;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Label lblSuplidor;
        private ComboBox cmbSuplidor;
        private Label lblCantidadPorUnidad;
        private TextBox txtCantidadPorUnidad;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblStock;
        private TextBox txtStock;
        private Label lblEnOrden;
        private TextBox txtEnOrden;
        private Label lblReorden;
        private TextBox txtReorden;
        private CheckBox chkDescontinuado;
        private Panel panelActions;
        private Button btnGuardar;
        private Button btnCancelar;
        private ErrorProvider errorProvider;
    }
}
