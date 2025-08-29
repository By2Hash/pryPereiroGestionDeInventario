namespace pryPereiroGestionDeInventario
{
    partial class frmAgregar
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
            btnAgregar = new Button();
            btnSalir = new Button();
            lblCodigo = new Label();
            lblNombre = new Label();
            lblDescripción = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            textBox4 = new TextBox();
            txtDescripcion = new TextBox();
            pnlAgregar = new Panel();
            pnlAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(23, 420);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(167, 83);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(218, 420);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(160, 83);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 15F);
            lblCodigo.Location = new Point(23, 90);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(116, 41);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15F);
            lblNombre.Location = new Point(23, 27);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(128, 41);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripción
            // 
            lblDescripción.AutoSize = true;
            lblDescripción.Font = new Font("Segoe UI", 15F);
            lblDescripción.Location = new Point(23, 279);
            lblDescripción.Margin = new Padding(4, 0, 4, 0);
            lblDescripción.Name = "lblDescripción";
            lblDescripción.Size = new Size(173, 41);
            lblDescripción.TabIndex = 4;
            lblDescripción.Text = "Descripción";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 15F);
            lblPrecio.Location = new Point(23, 149);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(100, 41);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 15F);
            lblStock.Location = new Point(23, 209);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(90, 41);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stock";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.Info;
            txtCodigo.ForeColor = SystemColors.ActiveCaptionText;
            txtCodigo.Location = new Point(207, 90);
            txtCodigo.Margin = new Padding(4, 5, 4, 5);
            txtCodigo.MaxLength = 25;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(170, 31);
            txtCodigo.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = SystemColors.ActiveCaptionText;
            txtNombre.Location = new Point(271, 35);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 25;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(105, 31);
            txtNombre.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.ForeColor = SystemColors.ActiveCaptionText;
            txtPrecio.Location = new Point(271, 157);
            txtPrecio.Margin = new Padding(4, 5, 4, 5);
            txtPrecio.MaxLength = 25;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(105, 31);
            txtPrecio.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(271, 217);
            textBox4.Margin = new Padding(4, 5, 4, 5);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(105, 31);
            textBox4.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(207, 287);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(170, 96);
            txtDescripcion.TabIndex = 11;
            // 
            // pnlAgregar
            // 
            pnlAgregar.BackColor = SystemColors.AppWorkspace;
            pnlAgregar.Controls.Add(lblNombre);
            pnlAgregar.Controls.Add(txtDescripcion);
            pnlAgregar.Controls.Add(btnAgregar);
            pnlAgregar.Controls.Add(textBox4);
            pnlAgregar.Controls.Add(btnSalir);
            pnlAgregar.Controls.Add(txtPrecio);
            pnlAgregar.Controls.Add(lblCodigo);
            pnlAgregar.Controls.Add(txtNombre);
            pnlAgregar.Controls.Add(lblDescripción);
            pnlAgregar.Controls.Add(txtCodigo);
            pnlAgregar.Controls.Add(lblPrecio);
            pnlAgregar.Controls.Add(lblStock);
            pnlAgregar.Location = new Point(12, 12);
            pnlAgregar.Name = "pnlAgregar";
            pnlAgregar.Size = new Size(387, 520);
            pnlAgregar.TabIndex = 12;
            // 
            // frmAgregar
            // 
            AcceptButton = btnAgregar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 543);
            ControlBox = false;
            Controls.Add(pnlAgregar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmAgregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Producto";
            pnlAgregar.ResumeLayout(false);
            pnlAgregar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private Button btnSalir;
        private Label lblCodigo;
        private Label lblNombre;
        private Label lblDescripción;
        private Label lblPrecio;
        private Label lblStock;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox textBox4;
        private TextBox txtDescripcion;
        private Panel pnlAgregar;
    }
}