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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing
            (object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Esta seguro", " Guardar", 
                MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            FrmPantalla2 frmPantalla2 = new FrmPantalla2();
            frmPantalla2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmPantalla2 frmPantalla2 = new FrmPantalla2();
            frmPantalla2.MdiParent = this;
            frmPantalla2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

  

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOrden_Click(object sender, EventArgs e)
        {
            if (rdoArrangeIcons.Checked)
                this.LayoutMdi(MdiLayout.ArrangeIcons);
            if (rdoTileVertical.Checked)
                this.LayoutMdi(MdiLayout.TileVertical);
            if (rdoTileHorizontal.Checked)
                this.LayoutMdi(MdiLayout.TileHorizontal);
            if (rdoCascade.Checked)
                this.LayoutMdi(MdiLayout.Cascade);
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            FrmOwner frmOwner = new FrmOwner();
            frmOwner.Show();
            FrmPantalla2 frmPantalla2 = new FrmPantalla2();
            frmPantalla2.Show(frmOwner);
            this.btnMostrar.Text = frmPantalla2.atributoString;
            frmPantalla2.Owner.Text = "";
        }

        private void btnMDI_Click(object sender, EventArgs e)
        {
            FrmPantalla2 frmPantalla2 = new FrmPantalla2();
            frmPantalla2.MdiParent = this;
            frmPantalla2.Show();
            
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            FrmPantalla2 frmPantalla2 = new FrmPantalla2();
            frmPantalla2.ShowDialog();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Hola Mundo", "titulo",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                this.btnSalir.Text = "Si";
            }
            else
            {
                this.btnSalir.Text = "No";
            }
        }
    }
}
