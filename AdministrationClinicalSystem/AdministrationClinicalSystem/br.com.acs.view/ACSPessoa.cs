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
    public partial class ACSPessoa : Form
    {
        public ACSPessoa()
        {
            InitializeComponent();
        }

        bool opcoesAvancadasClick = false;

        private void BtnOpcoesAvancadas_Click(object sender, EventArgs e)
        {
            if (opcoesAvancadasClick == false)
            {
                opcoesAvancadasClick = true;
                opcoesAvancadasPessoas.Visible = true;

                while (opcoesAvancadasPessoas.Width <= 200)
                {
                    opcoesAvancadasPessoas.Width += 4;
                }

                BtnOpcoesAvancadas.Text = "Fechar";
            }
            else
            {
                opcoesAvancadasClick = false;

                while (opcoesAvancadasPessoas.Width > 10)
                {
                    opcoesAvancadasPessoas.Width -= 4;
                }

                opcoesAvancadasPessoas.Visible = false;

                BtnOpcoesAvancadas.Text = "Opções Avançadas";
            }
        }

        private void BtnAtribuirUsuarioSistema_Click(object sender, EventArgs e)
        {
            //adicionar verificação para não permitir abrir mais de uma tela.
            ACSWindowPessoaUsuario acswPessoaUsuario = new ACSWindowPessoaUsuario();
            acswPessoaUsuario.Show();
        }

        private void BtnCadastrarTipoUsuario_Click(object sender, EventArgs e)
        {
            //adicionar verificação para não permitir abrir mais de uma tela.
            ACSWindowUsuarioNivelAcesso acswUsuarioNivelAcesso = new ACSWindowUsuarioNivelAcesso();
            acswUsuarioNivelAcesso.Show();
        }

        private void BtnDetalhesPessoa_Click(object sender, EventArgs e)
        {
            //adicionar verificação para não permitir abrir mais de uma tela.
            ACSWindowPessoa acswPessoa = new ACSWindowPessoa();
            acswPessoa.Show();
        }
    }
}
