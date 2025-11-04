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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            lblBienvenida = new Label();
            chkEliminar = new CheckBox();
            chkModificar = new CheckBox();
            btnAceptar = new Button();
            btnSalir = new Button();
            chkAgregar = new CheckBox();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.BorderStyle = BorderStyle.Fixed3D;
            lblBienvenida.Font = new Font("MS PGothic", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(44, 36);
            lblBienvenida.Margin = new Padding(4, 0, 4, 0);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(594, 62);
            lblBienvenida.TabIndex = 3;
            lblBienvenida.Text = "Gestion De Inventario";
            lblBienvenida.UseWaitCursor = true;
            // 
            // chkEliminar
            // 
            chkEliminar.AutoSize = true;
            chkEliminar.Font = new Font("Segoe UI", 15F);
            chkEliminar.Location = new Point(44, 279);
            chkEliminar.Margin = new Padding(4, 5, 4, 5);
            chkEliminar.Name = "chkEliminar";
            chkEliminar.Size = new Size(278, 45);
            chkEliminar.TabIndex = 2;
            chkEliminar.Text = "Eliminar Producto";
            chkEliminar.UseVisualStyleBackColor = true;
            chkEliminar.UseWaitCursor = true;
            chkEliminar.CheckedChanged += chkEliminar_CheckedChanged;
            // 
            // chkModificar
            // 
            chkModificar.AutoSize = true;
            chkModificar.Font = new Font("Segoe UI", 15F);
            chkModificar.Location = new Point(44, 208);
            chkModificar.Margin = new Padding(4, 5, 4, 5);
            chkModificar.Name = "chkModificar";
            chkModificar.Size = new Size(299, 45);
            chkModificar.TabIndex = 1;
            chkModificar.Text = "Modificar Producto";
            chkModificar.UseVisualStyleBackColor = true;
            chkModificar.UseWaitCursor = true;
            chkModificar.CheckedChanged += chkModificar_CheckedChanged_1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(482, 212);
            btnAceptar.Margin = new Padding(4, 5, 4, 5);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(125, 45);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Acpetar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.UseWaitCursor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(482, 279);
            btnSalir.Margin = new Padding(4, 5, 4, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(125, 45);
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
            chkAgregar.Location = new Point(44, 136);
            chkAgregar.Margin = new Padding(4, 5, 4, 5);
            chkAgregar.Name = "chkAgregar";
            chkAgregar.Size = new Size(280, 45);
            chkAgregar.TabIndex = 0;
            chkAgregar.Text = "Agregar Producto";
            chkAgregar.UseVisualStyleBackColor = true;
            chkAgregar.UseWaitCursor = true;
            chkAgregar.CheckedChanged += chkAgregar_CheckedChanged;
            // 
            // frmInventario
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 376);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(chkAgregar);
            Controls.Add(btnAceptar);
            Controls.Add(chkEliminar);
            Controls.Add(lblBienvenida);
            Controls.Add(chkModificar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            TopMost = true;
            UseWaitCursor = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBienvenida;
        private CheckBox chkEliminar;
        private CheckBox chkModificar;
        private Button btnAceptar;
        private Button btnSalir;
        private CheckBox chkAgregar;
    }
}
