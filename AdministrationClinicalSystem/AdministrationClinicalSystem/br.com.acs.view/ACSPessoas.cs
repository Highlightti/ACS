using AdministrationClinicalSystem.br.com.acs.controller;
using AdministrationClinicalSystem.br.com.acs.model;
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
    public partial class ACSPessoas : Form
    {
        public ACSPessoas()
        {
            InitializeComponent();
        }

        #region Instâncias (Singleton Pattern). + Variáveis

        PessoaController pessoaController = PessoaController.getInstance();
        UsuarioController usuarioController = UsuarioController.getInstance();
        SystemExceptionsMessages systemExMessages = SystemExceptionsMessages.getInstance();

        #endregion





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

        private void BtnCadastrarPessoa_Click(object sender, EventArgs e)
        {
            if (!(txtNome.Text.Equals("") || txtSobrenome.Text.Equals("") || dateNascimento.Value == DateTime.Now || txtRg.Text.Equals("") || txtTelefone.Text.Equals("")))
            {
                Pessoa pessoa = new Pessoa();
                pessoa.nome = txtNome.Text;
                pessoa.sobrenome = txtSobrenome.Text;

                // Operadores Ternários.
                pessoa.estadoCivil = comboEstadoCivil.SelectedItem == null ? null : comboEstadoCivil.SelectedItem.ToString();

                pessoa.sexo = chkFeminino.Checked ? "F" : "M";

                pessoa.dataNascimento = dateNascimento.Value;


                DocumentoPF documentoPF = new DocumentoPF();
                documentoPF.registroGeral = txtRg.Text;
                documentoPF.cadastroPessoaFisica = txtCpf.Text;

                Endereco endereco = new Endereco();
                endereco.cep = txtCep.Text;
                endereco.logradouro = txtRua.Text;
                endereco.numero = txtNumero.Text;
                endereco.complemento = txtComplemento.Text;
                endereco.bairro = txtBairro.Text;
                endereco.estado = comboEstado.Text;
                endereco.cidade = comboCidade.Text;

                Contato contato = new Contato();
                contato.telefone = txtTelefone.Text;
                contato.celular = txtCelular.Text;
                contato.email = txtEmailPessoal.Text;

                pessoa.documentoPF = documentoPF;
                pessoa.endereco = endereco;
                pessoa.contato = contato;

                pessoa = pessoaController.CadastrarPessoa(pessoa);

                if (pessoa != null)
                {
                    MetroFramework.MetroMessageBox.Show(this, systemExMessages.MESSAGE_DADOS_CADASTRADOS, systemExMessages.TITLE_DADOS_CADASTRADOS, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, systemExMessages.MESSAGE_FALHA_CONEXAO, systemExMessages.TITLE_FALHA_CONEXAO, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, systemExMessages.MESSAGE_DADOS_INVALIDOS_CADASTRO, systemExMessages.TITLE_DADOS_INVALIDOS_CADASTRO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


  

     
        /// <summary>
        /// //FORM LOAD PARA FAZER O CONTROLE DE CARREGAMENTO DE LISTA QUANDO SAI DA PAGINA E VOLTA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void ACSPessoas_Load(object sender, EventArgs e)
        //{
        //    if(MainTabsPessoas.SelectedIndex == 1)
        //    {
        //        MessageBox.Show("You are in the TabControl.SelectedIndexChanged event.");
        //    }
        //}

        private void MainTabsPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTabsPessoas.SelectedIndex == 1)
            {
                List<Pessoa> pessoas = new List<Pessoa>();

                pessoas = pessoaController.ListarPessoas();


                //Fill DataGrid


                MessageBox.Show("You are in the TabControl.SelectedIndexChanged event.");
            }
        }
    }
}
