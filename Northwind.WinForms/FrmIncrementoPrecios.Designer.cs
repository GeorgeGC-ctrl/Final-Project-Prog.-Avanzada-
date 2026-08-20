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
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            lblPorcentaje = new Label();
            nudPorcentaje = new NumericUpDown();
            btnAplicar = new Button();
            errorProvider = new ErrorProvider(components);
            grpDatos = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudPorcentaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(24, 28);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(96, 25);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = "Categoría";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(24, 56);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(320, 33);
            cmbCategoria.TabIndex = 1;
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Location = new Point(24, 112);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(228, 25);
            lblPorcentaje.TabIndex = 2;
            lblPorcentaje.Text = "Porcentaje de incremento (%)";
            // 
            // nudPorcentaje
            // 
            nudPorcentaje.DecimalPlaces = 2;
            nudPorcentaje.Location = new Point(24, 140);
            nudPorcentaje.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPorcentaje.Name = "nudPorcentaje";
            nudPorcentaje.Size = new Size(150, 31);
            nudPorcentaje.TabIndex = 3;
            nudPorcentaje.TextAlign = HorizontalAlignment.Right;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(24, 208);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(180, 44);
            btnAplicar.TabIndex = 4;
            btnAplicar.Text = "Aplicar incremento";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(lblCategoria);
            grpDatos.Controls.Add(btnAplicar);
            grpDatos.Controls.Add(cmbCategoria);
            grpDatos.Controls.Add(lblPorcentaje);
            grpDatos.Controls.Add(nudPorcentaje);
            grpDatos.Dock = DockStyle.Fill;
            grpDatos.Location = new Point(0, 0);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(724, 300);
            grpDatos.TabIndex = 5;
            grpDatos.TabStop = false;
            grpDatos.Text = "Incremento de precios por categoría";
            // 
            // FrmIncrementoPrecios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 300);
            Controls.Add(grpDatos);
            MinimumSize = new Size(500, 320);
            Name = "FrmIncrementoPrecios";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Incremento de Precios";
            Load += FrmIncrementoPrecios_Load;
            ((System.ComponentModel.ISupportInitialize)nudPorcentaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Label lblPorcentaje;
        private NumericUpDown nudPorcentaje;
        private Button btnAplicar;
        private ErrorProvider errorProvider;
        private GroupBox grpDatos;
    }
}