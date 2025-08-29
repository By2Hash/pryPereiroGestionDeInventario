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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(204, 277);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(170, 96);
            txtDescripcion.TabIndex = 23;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(269, 207);
            txtStock.Margin = new Padding(4, 5, 4, 5);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(105, 31);
            txtStock.TabIndex = 22;
            // 
            // txtPrecio
            // 
            txtPrecio.ForeColor = SystemColors.ActiveCaptionText;
            txtPrecio.Location = new Point(269, 147);
            txtPrecio.Margin = new Padding(4, 5, 4, 5);
            txtPrecio.MaxLength = 25;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(105, 31);
            txtPrecio.TabIndex = 21;
            // 
            // txtNombre
            // 
            txtNombre.ForeColor = SystemColors.ActiveCaptionText;
            txtNombre.Location = new Point(269, 25);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 25;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(105, 31);
            txtNombre.TabIndex = 20;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = SystemColors.Info;
            txtCodigo.ForeColor = SystemColors.ActiveCaptionText;
            txtCodigo.Location = new Point(204, 80);
            txtCodigo.Margin = new Padding(4, 5, 4, 5);
            txtCodigo.MaxLength = 25;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(170, 31);
            txtCodigo.TabIndex = 19;
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
            lblDescripción.Location = new Point(20, 268);
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
            lblNombre.Location = new Point(20, 17);
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
            btnSalir.Location = new Point(216, 410);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(160, 83);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(20, 410);
            btnModificar.Margin = new Padding(4, 5, 4, 5);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(167, 83);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(btnModificar);
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
            panel1.Size = new Size(395, 511);
            panel1.TabIndex = 24;
            // 
            // frmModificar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 537);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmModificar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Producto";
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
        private Button btnModificar;
        private Panel panel1;
    }
}