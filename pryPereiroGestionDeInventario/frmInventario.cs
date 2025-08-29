namespace pryPereiroGestionDeInventario
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
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
            }
            else if (chkModificar.Checked)
            {
                this.Hide();
                frmModificar f = new frmModificar();
                f.ShowDialog();
                this.Close();
            }
            else if (chkEliminar.Checked)
            {
                this.Hide();
                frmEliminar f = new frmEliminar();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Elija una opción");
            }

        }
    }
}
