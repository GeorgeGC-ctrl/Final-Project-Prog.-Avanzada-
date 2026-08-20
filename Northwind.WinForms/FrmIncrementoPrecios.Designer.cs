namespace Northwind.WinForms
{
    partial class FrmIncrementoPrecios
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
            components = new System.ComponentModel.Container();
            panelHeader = new Panel();
            lblEyebrow = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            panelCard = new Panel();
            panelInfo = new Panel();
            lblInfo = new Label();
            nudPorcentaje = new NumericUpDown();
            lblPorcentaje = new Label();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            panelActions = new Panel();
            btnAplicar = new Button();
            btnCerrar = new Button();
            errorProvider = new ErrorProvider(components);
            panelHeader.SuspendLayout();
            panelCard.SuspendLayout();
            panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPorcentaje).BeginInit();
            panelActions.SuspendLayout();
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
            panelHeader.Size = new Size(520, 90);
            panelHeader.TabIndex = 0;
            // 
            // lblEyebrow
            // 
            lblEyebrow.AutoSize = true;
            lblEyebrow.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblEyebrow.ForeColor = Color.FromArgb(136, 144, 160);
            lblEyebrow.Location = new Point(25, 12);
            lblEyebrow.Name = "lblEyebrow";
            lblEyebrow.Size = new Size(173, 19);
            lblEyebrow.TabIndex = 2;
            lblEyebrow.Text = "OPERACIONES DE PRECIOS";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(91, 100, 116);
            lblSubtitulo.Location = new Point(25, 58);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(335, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Ajuste porcentual de precios en lote por categoría";
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
            lblTitulo.Text = "Incremento de Precios";
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.White;
            panelCard.BorderStyle = BorderStyle.FixedSingle;
            panelCard.Controls.Add(panelInfo);
            panelCard.Controls.Add(nudPorcentaje);
            panelCard.Controls.Add(lblPorcentaje);
            panelCard.Controls.Add(cmbCategoria);
            panelCard.Controls.Add(lblCategoria);
            panelCard.Location = new Point(25, 108);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(20);
            panelCard.Size = new Size(470, 260);
            panelCard.TabIndex = 1;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(231, 237, 246);
            panelInfo.Controls.Add(lblInfo);
            panelInfo.Location = new Point(20, 185);
            panelInfo.Name = "panelInfo";
            panelInfo.Padding = new Padding(12, 8, 12, 8);
            panelInfo.Size = new Size(425, 50);
            panelInfo.TabIndex = 4;
            // 
            // lblInfo
            // 
            lblInfo.Dock = DockStyle.Fill;
            lblInfo.Font = new Font("Segoe UI", 8.5F);
            lblInfo.ForeColor = Color.FromArgb(44, 78, 130);
            lblInfo.Location = new Point(12, 8);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(401, 34);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "ℹ El porcentaje ingresado se aplicará al precio unitario actual de todos los productos de la categoría.";
            // 
            // nudPorcentaje
            // 
            nudPorcentaje.BackColor = Color.White;
            nudPorcentaje.BorderStyle = BorderStyle.FixedSingle;
            nudPorcentaje.DecimalPlaces = 2;
            nudPorcentaje.Font = new Font("Segoe UI", 10F);
            nudPorcentaje.ForeColor = Color.FromArgb(22, 26, 36);
            nudPorcentaje.Location = new Point(20, 135);
            nudPorcentaje.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudPorcentaje.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPorcentaje.Name = "nudPorcentaje";
            nudPorcentaje.Size = new Size(200, 30);
            nudPorcentaje.TabIndex = 3;
            nudPorcentaje.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPorcentaje.ForeColor = Color.FromArgb(22, 26, 36);
            lblPorcentaje.Location = new Point(20, 105);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(130, 21);
            lblPorcentaje.TabIndex = 2;
            lblPorcentaje.Text = "Porcentaje (%) *";
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.White;
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FlatStyle = FlatStyle.Flat;
            cmbCategoria.Font = new Font("Segoe UI", 10F);
            cmbCategoria.ForeColor = Color.FromArgb(22, 26, 36);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(20, 50);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(425, 31);
            cmbCategoria.TabIndex = 1;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCategoria.ForeColor = Color.FromArgb(22, 26, 36);
            lblCategoria.Location = new Point(20, 20);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(100, 21);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = "Categoría *";
            // 
            // panelActions
            // 
            panelActions.BackColor = Color.FromArgb(238, 241, 247);
            panelActions.Controls.Add(btnAplicar);
            panelActions.Controls.Add(btnCerrar);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(0, 388);
            panelActions.Name = "panelActions";
            panelActions.Padding = new Padding(20, 10, 20, 14);
            panelActions.Size = new Size(520, 72);
            panelActions.TabIndex = 2;
            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = Color.FromArgb(44, 78, 130);
            btnAplicar.Cursor = Cursors.Hand;
            btnAplicar.FlatAppearance.BorderSize = 0;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAplicar.ForeColor = Color.White;
            btnAplicar.Location = new Point(235, 14);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(165, 42);
            btnAplicar.TabIndex = 0;
            btnAplicar.Text = "Aplicar Incremento";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.White;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderColor = Color.FromArgb(227, 231, 239);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.FromArgb(22, 26, 36);
            btnCerrar.Location = new Point(410, 14);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(85, 42);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // FrmIncrementoPrecios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(520, 460);
            Controls.Add(panelActions);
            Controls.Add(panelCard);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmIncrementoPrecios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Incremento de Precios por Categoría";
            Load += FrmIncrementoPrecios_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudPorcentaje).EndInit();
            panelActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblEyebrow;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel panelCard;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Label lblPorcentaje;
        private NumericUpDown nudPorcentaje;
        private Panel panelInfo;
        private Label lblInfo;
        private Panel panelActions;
        private Button btnAplicar;
        private Button btnCerrar;
        private ErrorProvider errorProvider;
    }
}