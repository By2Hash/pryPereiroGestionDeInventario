namespace pryPereiroGestionDeInventario
{
    partial class frmModificar
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
            btnModificar = new Button();
            pnlModificar = new Panel();
            pnlModificar.SuspendLayout();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(260, 252);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.MaxLength = 50;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(273, 96);
            txtDescripcion.TabIndex = 23;
            txtDescripcion.TextChanged += txtDescripcion_TextChanged;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(426, 198);
            txtStock.Margin = new Padding(4, 5, 4, 5);
            txtStock.MaxLength = 5;
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(107, 31);
            txtStock.TabIndex = 22;
            txtStock.TextChanged += txtStock_TextChanged;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // txtPrecio
            // 
            txtPrecio.ForeColor = SystemColors.ActiveCaptionText;
            txtPrecio.Location = new Point(428, 138);
            txtPrecio.Margin = new Padding(4, 5, 4, 5);
            txtPrecio.MaxLength = 5;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(105, 31);
            txtPrecio.TabIndex = 21;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = SystemColors.ActiveCaptionText;
            txtNombre.Location = new Point(260, 27);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 25;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(273, 31);
            txtNombre.TabIndex = 20;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.Info;
            txtCodigo.ForeColor = SystemColors.ActiveCaptionText;
            txtCodigo.Location = new Point(388, 80);
            txtCodigo.Margin = new Padding(4, 5, 4, 5);
            txtCodigo.MaxLength = 13;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(145, 31);
            txtCodigo.TabIndex = 19;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 15F);
            lblStock.Location = new Point(20, 198);
            lblStock.Margin = new Padding(4, 0, 4, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(90, 41);
            lblStock.TabIndex = 18;
            lblStock.Text = "Stock";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 15F);
            lblPrecio.Location = new Point(20, 138);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(100, 41);
            lblPrecio.TabIndex = 17;
            lblPrecio.Text = "Precio";
            // 
            // lblDescripción
            // 
            lblDescripción.AutoSize = true;
            lblDescripción.Font = new Font("Segoe UI", 15F);
            lblDescripción.Location = new Point(20, 252);
            lblDescripción.Margin = new Padding(4, 0, 4, 0);
            lblDescripción.Name = "lblDescripción";
            lblDescripción.Size = new Size(173, 41);
            lblDescripción.TabIndex = 16;
            lblDescripción.Text = "Descripción";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 15F);
            lblNombre.Location = new Point(20, 27);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(128, 41);
            lblNombre.TabIndex = 15;
            lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 15F);
            lblCodigo.Location = new Point(20, 80);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(116, 41);
            lblCodigo.TabIndex = 14;
            lblCodigo.Text = "Código";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(20, 389);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(116, 46);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(417, 389);
            btnModificar.Margin = new Padding(4, 5, 4, 5);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(116, 46);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // pnlModificar
            // 
            pnlModificar.BackColor = SystemColors.AppWorkspace;
            pnlModificar.Controls.Add(lblNombre);
            pnlModificar.Controls.Add(txtDescripcion);
            pnlModificar.Controls.Add(btnModificar);
            pnlModificar.Controls.Add(txtStock);
            pnlModificar.Controls.Add(btnSalir);
            pnlModificar.Controls.Add(txtPrecio);
            pnlModificar.Controls.Add(lblCodigo);
            pnlModificar.Controls.Add(txtNombre);
            pnlModificar.Controls.Add(lblDescripción);
            pnlModificar.Controls.Add(txtCodigo);
            pnlModificar.Controls.Add(lblPrecio);
            pnlModificar.Controls.Add(lblStock);
            pnlModificar.Location = new Point(12, 12);
            pnlModificar.Name = "pnlModificar";
            pnlModificar.Size = new Size(554, 475);
            pnlModificar.TabIndex = 24;
            // 
            // frmModificar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 504);
            Controls.Add(pnlModificar);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmModificar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Producto";
            Load += frmModificar_Load;
            pnlModificar.ResumeLayout(false);
            pnlModificar.PerformLayout();
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
        private Button btnModificar;
        private Panel pnlModificar;
    }
}