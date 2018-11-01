using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class frmPickUp : Form
    {
        public frmPickUp()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            PickUp pickUp;

            if(txtPatente.Text.Trim() != "" && txtModelo.Text.Trim() != "")
            {
                pickUp = new PickUp(txtPatente.Text.Trim(), txtModelo.Text.Trim());
                MessageBox.Show(pickUp.ConsultarDatos());
            }
        }

        private void txtPatente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
