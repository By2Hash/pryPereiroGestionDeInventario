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
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(34, 260);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(117, 50);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(171, 260);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 50);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += this.btnSalir_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 15F);
            lblCodigo.Location = new Point(34, 62);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(77, 28);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15F);
            lblNombre.Location = new Point(34, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(85, 28);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripción
            // 
            lblDescripción.AutoSize = true;
            lblDescripción.Font = new Font("Segoe UI", 15F);
            lblDescripción.Location = new Point(34, 175);
            lblDescripción.Name = "lblDescripción";
            lblDescripción.Size = new Size(114, 28);
            lblDescripción.TabIndex = 4;
            lblDescripción.Text = "Descripción";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 15F);
            lblPrecio.Location = new Point(34, 97);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(66, 28);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 15F);
            lblStock.Location = new Point(34, 133);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(60, 28);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stock";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.Info;
            txtCodigo.ForeColor = SystemColors.AppWorkspace;
            txtCodigo.Location = new Point(163, 62);
            txtCodigo.MaxLength = 25;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(120, 23);
            txtCodigo.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = SystemColors.AppWorkspace;
            txtNombre.Location = new Point(213, 29);
            txtNombre.MaxLength = 25;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(70, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtPrecio
            // 
            txtPrecio.ForeColor = SystemColors.AppWorkspace;
            txtPrecio.Location = new Point(213, 102);
            txtPrecio.MaxLength = 25;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(70, 23);
            txtPrecio.TabIndex = 9;
            txtPrecio.TextChanged += this.txtPrecio_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(213, 138);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(70, 23);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(163, 180);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(120, 59);
            textBox5.TabIndex = 11;
            // 
            // frmAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 329);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblDescripción);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Name = "frmAgregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Producto";
            Load += this.frmAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox textBox5;
    }
}