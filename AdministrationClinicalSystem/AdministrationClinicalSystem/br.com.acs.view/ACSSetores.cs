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
    public partial class ACSSetores : Form
    {
        public ACSSetores()
        {
            InitializeComponent();
        }

        private void BtnDetalhesLocalidade_Click(object sender, EventArgs e)
        {
            //adicionar verificação para não permitir abrir mais de uma tela.
            ACSWindowSetor acswLocalidades = new ACSWindowSetor();
            acswLocalidades.Show();
        }
    }
}
