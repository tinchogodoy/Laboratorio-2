using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio_56
{
    public partial class Form1 : Form
    {
        string ruta = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            //Se debe informar el total de caracteres del archivo.
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
                        
            // Al pulsar en el menú "Abrir" o "Guardar como...", se deberá abrir una ventana para
            //seleccionar los archivos(ver nota al pie).
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                ruta = openFileDialog1.FileName;
            StreamReader streamReader = new StreamReader(ruta);
            richTextBox1.Text = streamReader.ReadToEnd();
            streamReader.Close();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                ruta = saveFileDialog1.FileName;
            StreamWriter streamWriter = new StreamWriter(ruta);
            streamWriter.Write(richTextBox1.Text);
            streamWriter.Close();
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ruta != null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                ruta = saveFileDialog1.FileName;
                StreamWriter streamWriter = new StreamWriter(ruta);
                streamWriter.Write(richTextBox1.Text);
                streamWriter.Close();
            }
            else
            {
                this.guardarComoToolStripMenuItem_Click(sender, e);
            }
        }
    }
}
