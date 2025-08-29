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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(436, 56);
            label1.TabIndex = 3;
            label1.Text = "Gestion De Inventario";
            label1.UseWaitCursor = true;
            // 
            // chkEliminar
            // 
            chkEliminar.AutoSize = true;
            chkEliminar.Font = new Font("Segoe UI", 15F);
            chkEliminar.Location = new Point(12, 172);
            chkEliminar.Name = "chkEliminar";
            chkEliminar.Size = new Size(187, 32);
            chkEliminar.TabIndex = 2;
            chkEliminar.Text = "Eliminar Producto";
            chkEliminar.UseVisualStyleBackColor = true;
            chkEliminar.UseWaitCursor = true;
            // 
            // chkModificar
            // 
            chkModificar.AutoSize = true;
            chkModificar.Font = new Font("Segoe UI", 15F);
            chkModificar.Location = new Point(12, 134);
            chkModificar.Name = "chkModificar";
            chkModificar.Size = new Size(201, 32);
            chkModificar.TabIndex = 1;
            chkModificar.Text = "Modificar Producto";
            chkModificar.UseVisualStyleBackColor = true;
            chkModificar.UseWaitCursor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(344, 96);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(104, 40);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Acpetar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.UseWaitCursor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(344, 164);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(104, 40);
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
            chkAgregar.Location = new Point(12, 96);
            chkAgregar.Name = "chkAgregar";
            chkAgregar.Size = new Size(188, 32);
            chkAgregar.TabIndex = 0;
            chkAgregar.Text = "Agregar Producto";
            chkAgregar.UseVisualStyleBackColor = true;
            chkAgregar.UseWaitCursor = true;
            // 
            // frmInventario
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 240);
            Controls.Add(btnSalir);
            Controls.Add(btnAceptar);
            Controls.Add(chkAgregar);
            Controls.Add(label1);
            Controls.Add(chkModificar);
            Controls.Add(chkEliminar);
            Name = "frmInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            TopMost = true;
            UseWaitCursor = true;
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
    }
}
