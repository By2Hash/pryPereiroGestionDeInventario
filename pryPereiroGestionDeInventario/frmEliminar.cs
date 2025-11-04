using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPereiroGestionDeInventario
{
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
            btnEliminar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            ActivarBoton();
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        public void ActivarBoton()
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) &&
               !string.IsNullOrWhiteSpace(txtCodigo.Text) &&
               !string.IsNullOrWhiteSpace(txtStock.Text) &&
               !string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ActivarBoton();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ActivarBoton();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ActivarBoton();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            ActivarBoton();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
        }
    }
}
