namespace Northwind.WinForms
{
    partial class FrmReasignarProductos
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
            panelCard = new Panel();
            panelInfo = new Panel();
            lblInfoProductos = new Label();
            panelAviso = new Panel();
            lblAviso = new Label();
            cmbDestino = new ComboBox();
            lblDestino = new Label();
            cmbOrigen = new ComboBox();
            lblOrigen = new Label();
            panelActions = new Panel();
            btnReasignar = new Button();
            btnCerrar = new Button();
            errorProvider = new ErrorProvider(components);
            panelHeader.SuspendLayout();
            panelCard.SuspendLayout();
            panelInfo.SuspendLayout();
            panelAviso.SuspendLayout();
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
            panelHeader.Size = new Size(580, 90);
            panelHeader.TabIndex = 0;
            // 
            // lblEyebrow
            // 
            lblEyebrow.AutoSize = true;
            lblEyebrow.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblEyebrow.ForeColor = Color.FromArgb(136, 144, 160);
            lblEyebrow.Location = new Point(25, 12);
            lblEyebrow.Name = "lblEyebrow";
            lblEyebrow.Size = new Size(183, 19);
            lblEyebrow.TabIndex = 2;
            lblEyebrow.Text = "OPERACIONES DE CATÁLOGO";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(91, 100, 116);
            lblSubtitulo.Location = new Point(25, 58);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(337, 20);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Transfiera en lote el catálogo entre dos suplidores";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.5F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(22, 26, 36);
            lblTitulo.Location = new Point(23, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(372, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reasignar Productos de Suplidor";
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.White;
            panelCard.BorderStyle = BorderStyle.FixedSingle;
            panelCard.Controls.Add(panelInfo);
            panelCard.Controls.Add(panelAviso);
            panelCard.Controls.Add(cmbDestino);
            panelCard.Controls.Add(lblDestino);
            panelCard.Controls.Add(cmbOrigen);
            panelCard.Controls.Add(lblOrigen);
            panelCard.Location = new Point(25, 108);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(20);
            panelCard.Size = new Size(530, 320);
            panelCard.TabIndex = 1;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(231, 237, 246);
            panelInfo.Controls.Add(lblInfoProductos);
            panelInfo.Location = new Point(20, 96);
            panelInfo.Name = "panelInfo";
            panelInfo.Padding = new Padding(10, 6, 10, 6);
            panelInfo.Size = new Size(490, 32);
            panelInfo.TabIndex = 6;
            // 
            // lblInfoProductos
            // 
            lblInfoProductos.Dock = DockStyle.Fill;
            lblInfoProductos.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblInfoProductos.ForeColor = Color.FromArgb(44, 78, 130);
            lblInfoProductos.Location = new Point(10, 6);
            lblInfoProductos.Name = "lblInfoProductos";
            lblInfoProductos.Size = new Size(470, 20);
            lblInfoProductos.TabIndex = 2;
            lblInfoProductos.Text = "Seleccione un suplidor para ver sus productos asociados";
            // 
            // panelAviso
            // 
            panelAviso.BackColor = Color.FromArgb(251, 238, 223);
            panelAviso.Controls.Add(lblAviso);
            panelAviso.Location = new Point(20, 235);
            panelAviso.Name = "panelAviso";
            panelAviso.Padding = new Padding(12, 8, 12, 8);
            panelAviso.Size = new Size(490, 65);
            panelAviso.TabIndex = 5;
            // 
            // lblAviso
            // 
            lblAviso.Dock = DockStyle.Fill;
            lblAviso.Font = new Font("Segoe UI", 8.5F);
            lblAviso.ForeColor = Color.FromArgb(180, 83, 9);
            lblAviso.Location = new Point(12, 8);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(466, 49);
            lblAviso.TabIndex = 0;
            lblAviso.Text = "⚠ Advertencia: Todos los productos del suplidor de origen serán transferidos al destino seleccionado.";
            // 
            // cmbDestino
            // 
            cmbDestino.BackColor = Color.White;
            cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestino.FlatStyle = FlatStyle.Flat;
            cmbDestino.Font = new Font("Segoe UI", 10F);
            cmbDestino.ForeColor = Color.FromArgb(22, 26, 36);
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(20, 180);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(490, 31);
            cmbDestino.TabIndex = 4;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDestino.ForeColor = Color.FromArgb(22, 26, 36);
            lblDestino.Location = new Point(20, 150);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(168, 21);
            lblDestino.TabIndex = 3;
            lblDestino.Text = "Suplidor de Destino *";
            // 
            // cmbOrigen
            // 
            cmbOrigen.BackColor = Color.White;
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrigen.FlatStyle = FlatStyle.Flat;
            cmbOrigen.Font = new Font("Segoe UI", 10F);
            cmbOrigen.ForeColor = Color.FromArgb(22, 26, 36);
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Location = new Point(20, 52);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(490, 31);
            cmbOrigen.TabIndex = 1;
            cmbOrigen.SelectedIndexChanged += cmbOrigen_SelectedIndexChanged;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblOrigen.ForeColor = Color.FromArgb(22, 26, 36);
            lblOrigen.Location = new Point(20, 22);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(160, 21);
            lblOrigen.TabIndex = 0;
            lblOrigen.Text = "Suplidor de Origen *";
            // 
            // panelActions
            // 
            panelActions.BackColor = Color.FromArgb(238, 241, 247);
            panelActions.Controls.Add(btnReasignar);
            panelActions.Controls.Add(btnCerrar);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(0, 448);
            panelActions.Name = "panelActions";
            panelActions.Padding = new Padding(25, 10, 25, 14);
            panelActions.Size = new Size(580, 72);
            panelActions.TabIndex = 2;
            // 
            // btnReasignar
            // 
            btnReasignar.BackColor = Color.FromArgb(44, 78, 130);
            btnReasignar.Cursor = Cursors.Hand;
            btnReasignar.FlatAppearance.BorderSize = 0;
            btnReasignar.FlatStyle = FlatStyle.Flat;
            btnReasignar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReasignar.ForeColor = Color.White;
            btnReasignar.Location = new Point(265, 14);
            btnReasignar.Name = "btnReasignar";
            btnReasignar.Size = new Size(185, 42);
            btnReasignar.TabIndex = 0;
            btnReasignar.Text = "Reasignar Lote";
            btnReasignar.UseVisualStyleBackColor = false;
            btnReasignar.Click += btnReasignar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.White;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderColor = Color.FromArgb(227, 231, 239);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.FromArgb(22, 26, 36);
            btnCerrar.Location = new Point(460, 14);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(95, 42);
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
            // FrmReasignarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            ClientSize = new Size(580, 520);
            Controls.Add(panelActions);
            Controls.Add(panelCard);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmReasignarProductos";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Reasignación de Productos por Suplidor";
            Load += FrmReasignarProductos_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            panelInfo.ResumeLayout(false);
            panelAviso.ResumeLayout(false);
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
        private Label lblOrigen;
        private ComboBox cmbOrigen;
        private Label lblDestino;
        private ComboBox cmbDestino;
        private Panel panelInfo;
        private Label lblInfoProductos;
        private Panel panelAviso;
        private Label lblAviso;
        private Panel panelActions;
        private Button btnReasignar;
        private Button btnCerrar;
        private ErrorProvider errorProvider;
    }
}
