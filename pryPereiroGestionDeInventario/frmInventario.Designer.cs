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
            chkAgregar = new CheckBox();
            chkModificar = new CheckBox();
            checkBox3 = new CheckBox();
            label1 = new Label();
            btnSalir = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // chkAgregar
            // 
            chkAgregar.AutoSize = true;
            chkAgregar.Font = new Font("Segoe UI", 9F);
            chkAgregar.Location = new Point(12, 118);
            chkAgregar.Name = "chkAgregar";
            chkAgregar.Size = new Size(120, 19);
            chkAgregar.TabIndex = 0;
            chkAgregar.Text = "Agregar Producto";
            chkAgregar.UseVisualStyleBackColor = true;
            chkAgregar.UseWaitCursor = true;
            // 
            // chkModificar
            // 
            chkModificar.AutoSize = true;
            chkModificar.Font = new Font("Segoe UI", 9F);
            chkModificar.Location = new Point(161, 118);
            chkModificar.Name = "chkModificar";
            chkModificar.Size = new Size(129, 19);
            chkModificar.TabIndex = 1;
            chkModificar.Text = "Modificar Producto";
            chkModificar.UseVisualStyleBackColor = true;
            chkModificar.UseWaitCursor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 9F);
            checkBox3.Location = new Point(312, 118);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(121, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Eliminar Producto";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.UseWaitCursor = true;
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
            // btnSalir
            // 
            btnSalir.Location = new Point(312, 179);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 32);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.UseWaitCursor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(44, 179);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(88, 32);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Acpetar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.UseWaitCursor = true;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 290);
            Controls.Add(btnAceptar);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Controls.Add(checkBox3);
            Controls.Add(chkModificar);
            Controls.Add(chkAgregar);
            Name = "frmInventario";
            Text = "Inventario";
            TopMost = true;
            UseWaitCursor = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkAgregar;
        private CheckBox chkModificar;
        private CheckBox checkBox3;
        private Label label1;
        private Button btnSalir;
        private Button btnAceptar;
    }
}
