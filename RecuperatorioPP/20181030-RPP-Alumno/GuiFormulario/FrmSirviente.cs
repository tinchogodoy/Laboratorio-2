﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace GuiFormulario
{
    public partial class FrmSirviente : Form
    {
        public FrmSirviente()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            RobotSirviente robotSirviente;

            
                robotSirviente = new RobotSirviente();
                MessageBox.Show(robotSirviente.ServirHumanidad());
            
        }

        private void txtEnergia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
