using System;
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
    public partial class ACSFinalidades : Form
    {
        public ACSFinalidades()
        {
            InitializeComponent();
        }

        private void BtnDetalhesFinalidade_Click(object sender, EventArgs e)
        {
            //adicionar verificação para não permitir abrir mais de uma tela.
            ACSWindowUpdateFinalidades acswfinalidades = new ACSWindowUpdateFinalidades();
            acswfinalidades.Show();
        }
    }
}
