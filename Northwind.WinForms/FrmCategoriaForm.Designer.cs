namespace Northwind.WinForms
{
    partial class FrmCategoriaForm
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
            lblEyebrow = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            panelContent = new Panel();
            lblId = new Label();
            txtId = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            panelFooter = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            errorProvider = new ErrorProvider(components);
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
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
            panelHeader.Size = new Size(500, 90);
            panelHeader.TabIndex = 0;
            // 
            // lblEyebrow
            // 
            lblEyebrow.AutoSize = true;
            lblEyebrow.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblEyebrow.ForeColor = Color.FromArgb(136, 144, 160);
            lblEyebrow.Location = new Point(25, 12);
            lblEyebrow.Name = "lblEyebrow";
            lblEyebrow.Size = new Size(160, 19);
            lblEyebrow.TabIndex = 2;
            lblEyebrow.Text = "DETALLE DE CATEGORÍA";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(91, 100, 116);
            lblSubtitulo.Location = new Point(25, 58);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(295, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Complete los campos para guardar la categoría";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(22, 26, 36);
            lblTitulo.Location = new Point(23, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(188, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nueva Categoría";
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.BorderStyle = BorderStyle.FixedSingle;
            panelContent.Controls.Add(lblId);
            panelContent.Controls.Add(txtId);
            panelContent.Controls.Add(lblNombre);
            panelContent.Controls.Add(txtNombre);
            panelContent.Controls.Add(lblDescripcion);
            panelContent.Controls.Add(txtDescripcion);
            panelContent.Location = new Point(25, 108);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(20);
            panelContent.Size = new Size(450, 310);
            panelContent.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblId.ForeColor = Color.FromArgb(22, 26, 36);
            lblId.Location = new Point(20, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 21);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(245, 247, 251);
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Font = new Font("Segoe UI", 10F);
            txtId.ForeColor = Color.FromArgb(91, 100, 116);
            txtId.Location = new Point(20, 48);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 30);
            txtId.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(22, 26, 36);
            lblNombre.Location = new Point(20, 90);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(84, 21);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre *";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.ForeColor = Color.FromArgb(22, 26, 36);
            txtNombre.Location = new Point(20, 118);
            txtNombre.MaxLength = 15;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(390, 30);
            txtNombre.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDescripcion.ForeColor = Color.FromArgb(22, 26, 36);
            lblDescripcion.Location = new Point(20, 160);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(100, 21);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.White;
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.ForeColor = Color.FromArgb(22, 26, 36);
            txtDescripcion.Location = new Point(20, 188);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(390, 90);
            txtDescripcion.TabIndex = 5;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(238, 241, 247);
            panelFooter.Controls.Add(btnCancelar);
            panelFooter.Controls.Add(btnGuardar);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 438);
            panelFooter.Name = "panelFooter";
            panelFooter.Padding = new Padding(20, 10, 20, 14);
            panelFooter.Size = new Size(500, 72);
            panelFooter.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(227, 231, 239);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(22, 26, 36);
            btnCancelar.Location = new Point(370, 14);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 42);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(44, 78, 130);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(250, 14);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 42);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // FrmCategoriaForm
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            CancelButton = btnCancelar;
            ClientSize = new Size(500, 510);
            Controls.Add(panelFooter);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCategoriaForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Categoría";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            panelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblEyebrow;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel panelContent;
        private Label lblId;
        private TextBox txtId;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Panel panelFooter;
        private Button btnGuardar;
        private Button btnCancelar;
        private ErrorProvider errorProvider;
    }
}
