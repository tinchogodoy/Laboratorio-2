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
    public partial class FrmVista : Form
    {
        Divisiones division;
        Curso curso;
        Profesor profe;

        public FrmVista()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivisionCurso.DataSource = Enum.GetValues(typeof(Divisiones));

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void cmbDivisionCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
           
        }

        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            Enum.TryParse<Divisiones>(cmbDivisionCurso.SelectedValue.ToString(), out division);
            txtNombreProfe.Text = division.ToString();
        }

        private void txtNombreProfe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreProfe_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            short anio;

            string nombre = this.txtNombreProfe.Text;
            string apellido = this.txtApellidoProfe.Text;
            string doc = this.txtDocumentoProfe.Text;
            if (!String.IsNullOrEmpty(nombre.Trim()) && !String.IsNullOrEmpty(apellido.Trim()) &&
                short.TryParse(nudAnioCurso.Value.ToString(), out anio) && (anio > 2007 && anio < 2019))
            {
                this.profe = new Profesor(nombre, apellido, doc);
                curso = new Curso(anio, division,this.profe);
                
            }

        }

      
    }
}
