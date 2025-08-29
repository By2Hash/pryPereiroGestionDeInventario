namespace pryPereiroGestionDeInventario
{
    partial class frmEliminar
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
            txtDescripcion = new TextBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            lblStock = new Label();
            lblPrecio = new Label();
            lblDescripción = new Label();
            lblNombre = new Label();
            lblCodigo = new Label();
            btnSalir = new Button();
            btnEliminar = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(224, 299);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(170, 96);
            txtDescripcion.TabIndex = 35;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(289, 229);
            txtStock.Margin = new Padding(4, 5, 4, 5);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(105, 31);
            txtStock.TabIndex = 34;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = SystemColors.HighlightText;
            txtPrecio.ForeColor = SystemColors.WindowText;
            txtPrecio.Location = new Point(289, 169);
            txtPrecio.Margin = new Padding(4, 5, 4, 5);
            txtPrecio.MaxLength = 25;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(105, 31);
            txtPrecio.TabIndex = 33;
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = SystemColors.ActiveCaptionText;
            txtNombre.Location = new Point(289, 48);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 25;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(105, 31);
            txtNombre.TabIndex = 32;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.Info;
            txtCodigo.ForeColor = SystemColors.ActiveCaptionText;
            txtCodigo.Location = new Point(224, 103);
            txtCodigo.Margin = new Padding(4, 5, 4, 5);
            txtCodigo.MaxLength = 25;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(170, 31);
            txtCodigo.TabIndex = 31;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 15F);
            lblStock.Location = new Point(40, 221);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(90, 41);
            lblStock.TabIndex = 30;
            lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 15F);
            lblPrecio.Location = new Point(40, 161);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(100, 41);
            lblPrecio.TabIndex = 29;
            lblPrecio.Text = "Precio";
            // 
            // lblDescripción
            // 
            lblDescripción.AutoSize = true;
            lblDescripción.Font = new Font("Segoe UI", 15F);
            lblDescripción.Location = new Point(40, 291);
            lblDescripción.Margin = new Padding(4, 0, 4, 0);
            lblDescripción.Name = "lblDescripción";
            lblDescripción.Size = new Size(173, 41);
            lblDescripción.TabIndex = 28;
            lblDescripción.Text = "Descripción";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15F);
            lblNombre.Location = new Point(40, 39);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(128, 41);
            lblNombre.TabIndex = 27;
            lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 15F);
            lblCodigo.Location = new Point(40, 103);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(116, 41);
            lblCodigo.TabIndex = 26;
            lblCodigo.Text = "Código";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(236, 433);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(160, 83);
            btnSalir.TabIndex = 25;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(40, 433);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(167, 83);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(txtStock);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(txtPrecio);
            panel1.Controls.Add(lblCodigo);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(lblDescripción);
            panel1.Controls.Add(txtCodigo);
            panel1.Controls.Add(lblPrecio);
            panel1.Controls.Add(lblStock);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 572);
            panel1.TabIndex = 36;
            // 
            // frmEliminar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 597);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmEliminar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar Producto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtDescripcion;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private Label lblStock;
        private Label lblPrecio;
        private Label lblDescripción;
        private Label lblNombre;
        private Label lblCodigo;
        private Button btnSalir;
        private Button btnEliminar;
        private Panel panel1;
    }
}