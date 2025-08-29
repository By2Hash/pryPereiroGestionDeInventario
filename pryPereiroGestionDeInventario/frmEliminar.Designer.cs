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
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(141, 176);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(120, 59);
            txtDescripcion.TabIndex = 35;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(186, 134);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(75, 23);
            txtStock.TabIndex = 34;
            // 
            // txtPrecio
            // 
            txtPrecio.ForeColor = SystemColors.AppWorkspace;
            txtPrecio.Location = new Point(186, 98);
            txtPrecio.MaxLength = 25;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(75, 23);
            txtPrecio.TabIndex = 33;
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = SystemColors.AppWorkspace;
            txtNombre.Location = new Point(186, 25);
            txtNombre.MaxLength = 25;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(75, 23);
            txtNombre.TabIndex = 32;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.Info;
            txtCodigo.ForeColor = SystemColors.AppWorkspace;
            txtCodigo.Location = new Point(141, 58);
            txtCodigo.MaxLength = 25;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(120, 23);
            txtCodigo.TabIndex = 31;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 15F);
            lblStock.Location = new Point(12, 129);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(60, 28);
            lblStock.TabIndex = 30;
            lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 15F);
            lblPrecio.Location = new Point(12, 93);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(66, 28);
            lblPrecio.TabIndex = 29;
            lblPrecio.Text = "Precio";
            // 
            // lblDescripción
            // 
            lblDescripción.AutoSize = true;
            lblDescripción.Font = new Font("Segoe UI", 15F);
            lblDescripción.Location = new Point(12, 171);
            lblDescripción.Name = "lblDescripción";
            lblDescripción.Size = new Size(114, 28);
            lblDescripción.TabIndex = 28;
            lblDescripción.Text = "Descripción";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15F);
            lblNombre.Location = new Point(12, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(85, 28);
            lblNombre.TabIndex = 27;
            lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 15F);
            lblCodigo.Location = new Point(12, 58);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(77, 28);
            lblCodigo.TabIndex = 26;
            lblCodigo.Text = "Código";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(149, 256);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 50);
            btnSalir.TabIndex = 25;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 256);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(117, 50);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 326);
            Controls.Add(txtDescripcion);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblDescripción);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Name = "frmEliminar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar Producto";
            ResumeLayout(false);
            PerformLayout();
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
    }
}