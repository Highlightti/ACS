﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrationClinicalSystem.br.com.acs.view
{
    public partial class ACSPatrimonio : Form
    {
        public ACSPatrimonio()
        {
            InitializeComponent();
        }

        private void BtnDetalhesPatrimonio_Click(object sender, EventArgs e)
        {
            //adicionar verificação para não permitir abrir mais de uma tela.
            ACSWindowUpdatePatrimonio acs = new ACSWindowUpdatePatrimonio();
            acs.Show();
        }
    }
}