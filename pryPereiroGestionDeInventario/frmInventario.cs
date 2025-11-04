namespace pryPereiroGestionDeInventario
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
            btnAceptar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (chkAgregar.Checked)
            {
                this.Hide();
                frmAgregar f = new frmAgregar();
                f.ShowDialog();
                this.Close();
                ActivarBoton();
            }
            else if (chkModificar.Checked)
            {
                this.Hide();
                frmModificar f = new frmModificar();
                f.ShowDialog();
                this.Close();
                ActivarBoton();
            }
            else if (chkEliminar.Checked)
            {
                ActivarBoton();
                this.Hide();
                frmEliminar f = new frmEliminar();
                f.ShowDialog();
                this.Close();

            }


        }

        public void ActivarBoton()
        {
            if (chkAgregar.Checked || chkEliminar.Checked || chkModificar.Checked)
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void chkAgregar_CheckedChanged(object sender, EventArgs e)
        {
            ActivarBoton();
        }

        
        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            ActivarBoton();
        }

        private void chkModificar_CheckedChanged_1(object sender, EventArgs e)
        {
            ActivarBoton();
        }
    }
}
