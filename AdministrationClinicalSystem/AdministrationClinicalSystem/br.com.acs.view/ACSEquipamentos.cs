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
    public partial class ACSEquipamentos : Form
    {
        public ACSEquipamentos()
        {
            InitializeComponent();
        }

        bool opcoesAvancadasClick = false;

        private void BtnOpcoesAvancadas_Click(object sender, EventArgs e)
        {
            if (opcoesAvancadasClick == false)
            {
                opcoesAvancadasClick = true;
                opcoesAvancadasEquipamentos.Visible = true;

                while (opcoesAvancadasEquipamentos.Width <= 160)
                {
                    opcoesAvancadasEquipamentos.Width += 4;
                }
            }
            else
            {
                opcoesAvancadasClick = false;

                while (opcoesAvancadasEquipamentos.Width > 10)
                {
                    opcoesAvancadasEquipamentos.Width -= 4;
                }

                opcoesAvancadasEquipamentos.Visible = false;
            }
        }

        private void BtnDetalhesEquipamento_Click(object sender, EventArgs e)
        {
            //adicionar verificação para não permitir abrir mais de uma tela.
            ACSWindowEquipamentos acswEquipamento = new ACSWindowEquipamentos();
            acswEquipamento.Show();
        }
    }
}
