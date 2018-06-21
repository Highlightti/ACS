using AdministrationClinicalSystem.br.com.acs.controller;
using AdministrationClinicalSystem.br.com.acs.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        private void BtnCadastrarPessoa_Click(object sender, EventArgs e)
        {
            /*TO-DO
             * Verificação para não perminir caracters especiais
             * Aplicar máscara aos campos de documentos e contatos
             * 
             * 
             */

            if(!(labelNome.Text.Equals("") || labelSobrenome.Text.Equals("") || labelDataNascimento.Text.Equals("") || labelRg.Text.Equals("") || labelTelefone.Text.Equals("")))
            {
                Pessoa pessoa = new Pessoa();
                pessoa.nome = labelNome.Text;
                pessoa.sobrenome = labelSobrenome.Text;
                pessoa.estadoCivil = comboEstadoCivil.SelectedItem.ToString();

                if (chkFeminino.Checked)
                {
                    pessoa.sexo = "F";
                }
                else if (chkMasculino.Checked)
                {
                    pessoa.sexo = "M";
                }

                pessoa.dataNascimento = DateTime.Parse(labelDataNascimento.Text, new CultureInfo("pt-BR", true));

                DocumentoPF documentoPF = new DocumentoPF();
                documentoPF.registroGeral = labelRg.Text;
                documentoPF.cadastroPessoaFisica = labelCpf.Text;
                documentoPF.carteiraNacionalHabilitacao = labelCnh.Text;
                documentoPF.programaIntegracaoSocial = labelPis.Text;

                Endereco endereco = new Endereco();
                endereco.cep = labelCep.Text;
                endereco.logradouro = labelRua.Text;
                endereco.numero = labelNumero.Text;
                endereco.complemento = labelComplemento.Text;
                endereco.bairro = labelBairro.Text;
                endereco.estado = comboEstado.Text;
                endereco.cidade = comboCidade.Text;
                endereco.tipoEndereco = comboTipoEndereco.SelectedIndex;

                Contato contato = new Contato();
                contato.telefone = labelTelefone.Text;
                contato.celular = labelCelular.Text;
                contato.email = labelEmailPessoal.Text;

                pessoa.documentoPF = documentoPF;
                pessoa.endereco = endereco;
                pessoa.contato = contato;

                pessoa = pessoaController.CadastrarPessoa(pessoa);

                if(pessoa != null)
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

        private void TabConsultarPessoas_Paint(object sender, PaintEventArgs e)
        {
            // Recuperar todos os registros de pessoas cadastradas no sistema.


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
            }
            else
            {
                opcoesAvancadasClick = false;

                while (opcoesAvancadasPessoas.Width > 10)
                {
                    opcoesAvancadasPessoas.Width -= 4;
                }

                opcoesAvancadasPessoas.Visible = false;
            }
        }
    }
}
