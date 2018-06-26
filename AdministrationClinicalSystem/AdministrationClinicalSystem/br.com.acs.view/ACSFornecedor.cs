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
    public partial class ACSFornecedor : Form
    {
        public ACSFornecedor()
        {
            InitializeComponent();
        }

        private void BtnDetalhesFornecedor_Click(object sender, EventArgs e)
        {
            //adicionar verificação para não permitir abrir mais de uma tela.
            ACSWindowUpdateFornecedor acswFornecedor = new ACSWindowUpdateFornecedor();
            acswFornecedor.Show();
        }
    }
}
