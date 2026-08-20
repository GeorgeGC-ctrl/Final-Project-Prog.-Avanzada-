namespace Northwind.WinForms
{
    partial class FrmSuplidorForm
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
            txtPhone = new TextBox();
            lblPhone = new Label();
            txtCity = new TextBox();
            lblCity = new Label();
            txtCountry = new TextBox();
            lblCountry = new Label();
            txtContactTitle = new TextBox();
            lblContactTitle = new Label();
            txtContactName = new TextBox();
            lblContactName = new Label();
            txtCompanyName = new TextBox();
            lblCompanyName = new Label();
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
            panelHeader.BackColor = Color.FromArgb(26, 29, 39);
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
            lblSubtitulo.ForeColor = Color.FromArgb(148, 163, 184);
            lblSubtitulo.Location = new Point(25, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(318, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Complete la información del suplidor comercial";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(226, 232, 240);
            lblTitulo.Location = new Point(23, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(207, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro Suplidor";
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.FromArgb(33, 37, 58);
            panelCard.Controls.Add(txtPhone);
            panelCard.Controls.Add(lblPhone);
            panelCard.Controls.Add(txtCity);
            panelCard.Controls.Add(lblCity);
            panelCard.Controls.Add(txtCountry);
            panelCard.Controls.Add(lblCountry);
            panelCard.Controls.Add(txtContactTitle);
            panelCard.Controls.Add(lblContactTitle);
            panelCard.Controls.Add(txtContactName);
            panelCard.Controls.Add(lblContactName);
            panelCard.Controls.Add(txtCompanyName);
            panelCard.Controls.Add(lblCompanyName);
            panelCard.Location = new Point(25, 105);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(20);
            panelCard.Size = new Size(510, 390);
            panelCard.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.FromArgb(26, 29, 39);
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.ForeColor = Color.FromArgb(226, 232, 240);
            txtPhone.Location = new Point(260, 325);
            txtPhone.MaxLength = 24;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(225, 30);
            txtPhone.TabIndex = 11;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(226, 232, 240);
            lblPhone.Location = new Point(260, 298);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(77, 21);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Teléfono";
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.FromArgb(26, 29, 39);
            txtCity.BorderStyle = BorderStyle.FixedSingle;
            txtCity.Font = new Font("Segoe UI", 10F);
            txtCity.ForeColor = Color.FromArgb(226, 232, 240);
            txtCity.Location = new Point(20, 325);
            txtCity.MaxLength = 15;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(225, 30);
            txtCity.TabIndex = 9;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCity.ForeColor = Color.FromArgb(226, 232, 240);
            lblCity.Location = new Point(20, 298);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(64, 21);
            lblCity.TabIndex = 8;
            lblCity.Text = "Ciudad";
            // 
            // txtCountry
            // 
            txtCountry.BackColor = Color.FromArgb(26, 29, 39);
            txtCountry.BorderStyle = BorderStyle.FixedSingle;
            txtCountry.Font = new Font("Segoe UI", 10F);
            txtCountry.ForeColor = Color.FromArgb(226, 232, 240);
            txtCountry.Location = new Point(20, 255);
            txtCountry.MaxLength = 15;
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(465, 30);
            txtCountry.TabIndex = 7;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCountry.ForeColor = Color.FromArgb(226, 232, 240);
            lblCountry.Location = new Point(20, 228);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(41, 21);
            lblCountry.TabIndex = 6;
            lblCountry.Text = "País";
            // 
            // txtContactTitle
            // 
            txtContactTitle.BackColor = Color.FromArgb(26, 29, 39);
            txtContactTitle.BorderStyle = BorderStyle.FixedSingle;
            txtContactTitle.Font = new Font("Segoe UI", 10F);
            txtContactTitle.ForeColor = Color.FromArgb(226, 232, 240);
            txtContactTitle.Location = new Point(20, 185);
            txtContactTitle.MaxLength = 30;
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(465, 30);
            txtContactTitle.TabIndex = 5;
            // 
            // lblContactTitle
            // 
            lblContactTitle.AutoSize = true;
            lblContactTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblContactTitle.ForeColor = Color.FromArgb(226, 232, 240);
            lblContactTitle.Location = new Point(20, 158);
            lblContactTitle.Name = "lblContactTitle";
            lblContactTitle.Size = new Size(150, 21);
            lblContactTitle.TabIndex = 4;
            lblContactTitle.Text = "Título del Contacto";
            // 
            // txtContactName
            // 
            txtContactName.BackColor = Color.FromArgb(26, 29, 39);
            txtContactName.BorderStyle = BorderStyle.FixedSingle;
            txtContactName.Font = new Font("Segoe UI", 10F);
            txtContactName.ForeColor = Color.FromArgb(226, 232, 240);
            txtContactName.Location = new Point(20, 115);
            txtContactName.MaxLength = 30;
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(465, 30);
            txtContactName.TabIndex = 3;
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblContactName.ForeColor = Color.FromArgb(226, 232, 240);
            lblContactName.Location = new Point(20, 88);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(181, 21);
            lblContactName.TabIndex = 2;
            lblContactName.Text = "Nombre del Contacto *";
            // 
            // txtCompanyName
            // 
            txtCompanyName.BackColor = Color.FromArgb(26, 29, 39);
            txtCompanyName.BorderStyle = BorderStyle.FixedSingle;
            txtCompanyName.Font = new Font("Segoe UI", 10F);
            txtCompanyName.ForeColor = Color.FromArgb(226, 232, 240);
            txtCompanyName.Location = new Point(20, 48);
            txtCompanyName.MaxLength = 40;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(465, 30);
            txtCompanyName.TabIndex = 1;
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCompanyName.ForeColor = Color.FromArgb(226, 232, 240);
            lblCompanyName.Location = new Point(20, 20);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(207, 21);
            lblCompanyName.TabIndex = 0;
            lblCompanyName.Text = "Nombre de la Compañía *";
            // 
            // panelActions
            // 
            panelActions.BackColor = Color.FromArgb(15, 17, 23);
            panelActions.Controls.Add(btnGuardar);
            panelActions.Controls.Add(btnCancelar);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(0, 515);
            panelActions.Name = "panelActions";
            panelActions.Padding = new Padding(25, 10, 25, 15);
            panelActions.Size = new Size(560, 75);
            panelActions.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(99, 102, 241);
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
            btnCancelar.BackColor = Color.FromArgb(33, 37, 58);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(46, 51, 80);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ForeColor = Color.FromArgb(148, 163, 184);
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
            // FrmSuplidorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 17, 23);
            ClientSize = new Size(560, 590);
            Controls.Add(panelActions);
            Controls.Add(panelCard);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSuplidorForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Formulario de Suplidor";
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
        private Label lblCompanyName;
        private TextBox txtCompanyName;
        private Label lblContactName;
        private TextBox txtContactName;
        private Label lblContactTitle;
        private TextBox txtContactTitle;
        private Label lblCountry;
        private TextBox txtCountry;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblPhone;
        private TextBox txtPhone;
        private Panel panelActions;
        private Button btnGuardar;
        private Button btnCancelar;
        private ErrorProvider errorProvider;
    }
}
