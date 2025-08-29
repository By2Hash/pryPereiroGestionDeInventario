namespace pryPereiroGestionDeInventario
{
    partial class frmInventario
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
            label1 = new Label();
            chkEliminar = new CheckBox();
            chkModificar = new CheckBox();
            btnAceptar = new Button();
            btnSalir = new Button();
            chkAgregar = new CheckBox();
            pnlFondo = new Panel();
            pnlFondo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(17, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(649, 83);
            label1.TabIndex = 3;
            label1.Text = "Gestion De Inventario";
            label1.UseWaitCursor = true;
            // 
            // chkEliminar
            // 
            chkEliminar.AutoSize = true;
            chkEliminar.Font = new Font("Segoe UI", 15F);
            chkEliminar.Location = new Point(17, 151);
            chkEliminar.Margin = new Padding(4, 5, 4, 5);
            chkEliminar.Name = "chkEliminar";
            chkEliminar.Size = new Size(278, 45);
            chkEliminar.TabIndex = 2;
            chkEliminar.Text = "Eliminar Producto";
            chkEliminar.UseVisualStyleBackColor = true;
            chkEliminar.UseWaitCursor = true;
            // 
            // chkModificar
            // 
            chkModificar.AutoSize = true;
            chkModificar.Font = new Font("Segoe UI", 15F);
            chkModificar.Location = new Point(17, 87);
            chkModificar.Margin = new Padding(4, 5, 4, 5);
            chkModificar.Name = "chkModificar";
            chkModificar.Size = new Size(299, 45);
            chkModificar.TabIndex = 1;
            chkModificar.Text = "Modificar Producto";
            chkModificar.UseVisualStyleBackColor = true;
            chkModificar.UseWaitCursor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(457, 24);
            btnAceptar.Margin = new Padding(4, 5, 4, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(149, 67);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Acpetar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.UseWaitCursor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(457, 137);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(149, 67);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.UseWaitCursor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // chkAgregar
            // 
            chkAgregar.AutoSize = true;
            chkAgregar.Font = new Font("Segoe UI", 15F);
            chkAgregar.Location = new Point(17, 24);
            chkAgregar.Margin = new Padding(4, 5, 4, 5);
            chkAgregar.Name = "chkAgregar";
            chkAgregar.Size = new Size(280, 45);
            chkAgregar.TabIndex = 0;
            chkAgregar.Text = "Agregar Producto";
            chkAgregar.UseVisualStyleBackColor = true;
            chkAgregar.UseWaitCursor = true;
            // 
            // pnlFondo
            // 
            pnlFondo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlFondo.BackColor = SystemColors.AppWorkspace;
            pnlFondo.Controls.Add(chkAgregar);
            pnlFondo.Controls.Add(btnSalir);
            pnlFondo.Controls.Add(chkEliminar);
            pnlFondo.Controls.Add(btnAceptar);
            pnlFondo.Controls.Add(chkModificar);
            pnlFondo.Location = new Point(27, 121);
            pnlFondo.Name = "pnlFondo";
            pnlFondo.Size = new Size(639, 226);
            pnlFondo.TabIndex = 7;
            // 
            // frmInventario
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 372);
            ControlBox = false;
            Controls.Add(pnlFondo);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            TopMost = true;
            UseWaitCursor = true;
            pnlFondo.ResumeLayout(false);
            pnlFondo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private CheckBox chkEliminar;
        private CheckBox chkModificar;
        private Button btnAceptar;
        private Button btnSalir;
        private CheckBox chkAgregar;
        private Panel pnlFondo;
    }
}
