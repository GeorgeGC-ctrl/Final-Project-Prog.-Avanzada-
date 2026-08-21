namespace Northwind.WinForms
{
    partial class FrmIncrementoPrecios
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
            lblAfectados = new Label();
            nudPorcentaje = new NumericUpDown();
            lblPorcentaje = new Label();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            panelActions = new Panel();
            btnAplicar = new Button();
            btnCancelar = new Button();
            errorProvider = new ErrorProvider(components);
            panelHeader.SuspendLayout();
            panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPorcentaje).BeginInit();
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
            panelHeader.Size = new Size(520, 85);
            panelHeader.TabIndex = 0;
            //
            // lblSubtitulo
            //
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(91, 100, 116);
            lblSubtitulo.Location = new Point(25, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(360, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Aplique un incremento porcentual a una categoría";
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(22, 26, 36);
            lblTitulo.Location = new Point(23, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Incremento de Precios";
            //
            // panelCard
            //
            panelCard.BackColor = Color.FromArgb(255, 255, 255);
            panelCard.Controls.Add(lblAfectados);
            panelCard.Controls.Add(nudPorcentaje);
            panelCard.Controls.Add(lblPorcentaje);
            panelCard.Controls.Add(cmbCategoria);
            panelCard.Controls.Add(lblCategoria);
            panelCard.Location = new Point(25, 105);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(20);
            panelCard.Size = new Size(470, 230);
            panelCard.TabIndex = 1;
            //
            // lblCategoria
            //
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCategoria.ForeColor = Color.FromArgb(51, 65, 85);
            lblCategoria.Location = new Point(20, 20);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(78, 21);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = "Categoría *";
            //
            // cmbCategoria
            //
            cmbCategoria.BackColor = Color.FromArgb(248, 250, 252);
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FlatStyle = FlatStyle.Flat;
            cmbCategoria.Font = new Font("Segoe UI", 10F);
            cmbCategoria.ForeColor = Color.FromArgb(22, 26, 36);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(20, 48);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(425, 31);
            cmbCategoria.TabIndex = 1;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            //
            // lblPorcentaje
            //
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPorcentaje.ForeColor = Color.FromArgb(51, 65, 85);
            lblPorcentaje.Location = new Point(20, 98);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(140, 21);
            lblPorcentaje.TabIndex = 2;
            lblPorcentaje.Text = "Porcentaje de Incremento *";
            //
            // nudPorcentaje
            //
            nudPorcentaje.BackColor = Color.FromArgb(248, 250, 252);
            nudPorcentaje.BorderStyle = BorderStyle.FixedSingle;
            nudPorcentaje.DecimalPlaces = 2;
            nudPorcentaje.Font = new Font("Segoe UI", 10F);
            nudPorcentaje.ForeColor = Color.FromArgb(22, 26, 36);
            nudPorcentaje.Location = new Point(20, 126);
            nudPorcentaje.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudPorcentaje.Name = "nudPorcentaje";
            nudPorcentaje.Size = new Size(180, 30);
            nudPorcentaje.TabIndex = 3;
            nudPorcentaje.Value = new decimal(new int[] { 10, 0, 0, 0 });
            //
            // lblAfectados
            //
            lblAfectados.AutoSize = true;
            lblAfectados.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblAfectados.ForeColor = Color.FromArgb(44, 78, 130);
            lblAfectados.Location = new Point(20, 172);
            lblAfectados.Name = "lblAfectados";
            lblAfectados.Size = new Size(300, 20);
            lblAfectados.TabIndex = 4;
            lblAfectados.Text = "Seleccione una categoría para ver los productos afectados.";
            //
            // panelActions
            //
            panelActions.BackColor = Color.FromArgb(248, 250, 252);
            panelActions.Controls.Add(btnAplicar);
            panelActions.Controls.Add(btnCancelar);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(0, 335);
            panelActions.Name = "panelActions";
            panelActions.Padding = new Padding(25, 10, 25, 15);
            panelActions.Size = new Size(520, 75);
            panelActions.TabIndex = 2;
            //
            // btnAplicar
            //
            btnAplicar.BackColor = Color.FromArgb(44, 78, 130);
            btnAplicar.Cursor = Cursors.Hand;
            btnAplicar.FlatAppearance.BorderSize = 0;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAplicar.ForeColor = Color.White;
            btnAplicar.Location = new Point(235, 15);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(160, 42);
            btnAplicar.TabIndex = 0;
            btnAplicar.Text = "Aplicar Incremento";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            //
            // btnCancelar
            //
            btnCancelar.BackColor = Color.FromArgb(241, 245, 249);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ForeColor = Color.FromArgb(71, 85, 105);
            btnCancelar.Location = new Point(405, 15);
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
            // FrmIncrementoPrecios
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(520, 410);
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
            ((System.ComponentModel.ISupportInitialize)nudPorcentaje).EndInit();
            panelActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel panelCard;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Label lblPorcentaje;
        private NumericUpDown nudPorcentaje;
        private Label lblAfectados;
        private Panel panelActions;
        private Button btnAplicar;
        private Button btnCancelar;
        private ErrorProvider errorProvider;
    }
}
