using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProgramaWindowsForm
{
    public partial class FrmPantalla2 : Form
    {
        public string atributoString = "Atributo Clase FrmPantalla2 ";

        public FrmPantalla2()
        {
            InitializeComponent();
        }

        private void FrmPantalla2_Load(object sender, EventArgs e)
        {
            this.cmbPais.SelectedIndex = 5;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            foreach(Control  radio in grbEstadoCivil.Controls)
            {
                if(radio is RadioButton && ((RadioButton)radio).Checked)
                {
                    MessageBox.Show("radio = " + radio.Text);
                }


            }


            string salida ="";
            foreach (object item in this.lstPosicion.SelectedItems)
                {
                salida += item.ToString()  + " ";
            };
            MessageBox.Show("Listbox= " + salida);
            MessageBox.Show("CheckBox= " + this.chkEnviaPublicidad.Checked.ToString());

            MessageBox.Show("Radio= " + (this.rdoArgentino.Checked ? "Argentino" : "Extranjero"));

            MessageBox.Show("TextBox= " + this.txtNombre.Text);

        }
    }
}
