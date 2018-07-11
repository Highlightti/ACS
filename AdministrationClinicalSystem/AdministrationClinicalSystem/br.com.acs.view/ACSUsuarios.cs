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
    public partial class ACSUsuarios : Form
    {
        public ACSUsuarios()
        {
            InitializeComponent();
        }

        private void BtnDetalhesUsuario_Click(object sender, EventArgs e)
        {
            //adicionar verificação para não permitir abrir mais de uma tela.
            ACSWindowUsuario acswUsuario = new ACSWindowUsuario();
            acswUsuario.Show();
        }

        private void BtnRedefinirSenha_Click(object sender, EventArgs e)
        {
            //adicionar verificação para não permitir abrir mais de uma tela.
            ACSWindowUsuarioRedefinirSenha acswRedefinirSenha = new ACSWindowUsuarioRedefinirSenha();
            acswRedefinirSenha.Show();
        }
    }
}
