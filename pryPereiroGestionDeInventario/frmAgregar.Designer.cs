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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregar));
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
            txtStock = new TextBox();
            txtDescripcion = new TextBox();
            pnlAgregar = new Panel();
            pnlAgregar.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(436, 371);
            btnAgregar.Margin = new Padding(4, 5, 4, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 40);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(23, 371);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 40);
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
            lblNombre.Font = new Font("Segoe UI", 15F);
            lblNombre.Location = new Point(23, 27);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(156, 39);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripción
            // 
            lblDescripción.AutoSize = true;
            lblDescripción.Font = new Font("Segoe UI", 15F);
            lblDescripción.Location = new Point(23, 246);
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
            lblPrecio.Location = new Point(23, 137);
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
            lblStock.Location = new Point(23, 189);
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
            txtCodigo.Location = new Point(390, 90);
            txtCodigo.Margin = new Padding(4, 5, 4, 5);
            txtCodigo.MaxLength = 13;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(151, 31);
            txtCodigo.TabIndex = 7;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = SystemColors.ActiveCaptionText;
            txtNombre.Location = new Point(258, 37);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 40;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(283, 31);
            txtNombre.TabIndex = 8;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.ForeColor = SystemColors.ActiveCaptionText;
            txtPrecio.Location = new Point(436, 137);
            txtPrecio.Margin = new Padding(4, 5, 4, 5);
            txtPrecio.MaxLength = 10;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(105, 31);
            txtPrecio.TabIndex = 9;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(436, 192);
            txtStock.Margin = new Padding(4, 5, 4, 5);
            txtStock.MaxLength = 5;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(105, 31);
            txtStock.TabIndex = 10;
            txtStock.TextChanged += textBox4_TextChanged;
            txtStock.KeyPress += textBox4_KeyPress;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(258, 246);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.MaxLength = 100;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(283, 96);
            txtDescripcion.TabIndex = 11;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // pnlAgregar
            // 
            pnlAgregar.BackColor = SystemColors.AppWorkspace;
            pnlAgregar.Controls.Add(lblNombre);
            pnlAgregar.Controls.Add(txtDescripcion);
            pnlAgregar.Controls.Add(btnAgregar);
            pnlAgregar.Controls.Add(txtStock);
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
            pnlAgregar.Size = new Size(554, 450);
            pnlAgregar.TabIndex = 12;
            // 
            // frmAgregar
            // 
            AcceptButton = btnAgregar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 474);
            ControlBox = false;
            Controls.Add(pnlAgregar);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private TextBox txtStock;
        private TextBox txtDescripcion;
        private Panel pnlAgregar;
    }
}