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
    public partial class ACSDadosUsuarioAdministrador : Form
    {
        public ACSDadosUsuarioAdministrador()
        {
            InitializeComponent();
        }

        private void ACSDadosUsuarioAdministrador_Load(object sender, EventArgs e)
        {
            uController.ConsultarUsuario(uController.tipoUsuarioLogado);

            usuarioTextMy.Text = uController.localReadUsuario.ToString();
            nomeTextMy.Text = uController.localReadNome.ToString();
            emailTextMy.Text = uController.localReadEmail.ToString();

            #region Carregando valores na comboBox de nível de usuário.

            // Popular comboBox pelo Banco

            //selecionar o id do nivel para ser usado quando cadastrar um usuário
            this.descricaoCombo.Items.Add("Administrador");
            this.descricaoCombo.Items.Add("Gestor");

            #endregion

        }

        #region Instâncias (Singleton Pattern). + Variáveis

        UsuarioController uController = UsuarioController.getInstance();
        SystemExceptionsMessages systemExMessages = SystemExceptionsMessages.getInstance();

        bool btnAlterarSenhaClick = false;
        bool btnCadastrarTipoUsuarioClick = false;

        #endregion

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (!(usuarioTextMy.Text.Equals("") || nomeTextMy.Text.Equals("") || emailTextMy.Text.Equals("")))
            {
                if (!(usuarioTextMy.Text.Equals(uController.localReadUsuario.ToString()) && nomeTextMy.Text.Equals(uController.localReadNome.ToString()) && emailTextMy.Text.Equals(uController.localReadEmail.ToString())))
                {
                    Usuario usuario = new Usuario();
                    usuario.usuario = usuarioTextMy.Text;
                    usuario.nome = nomeTextMy.Text;
                    usuario.email = emailTextMy.Text;
                    usuario.idUsuario = uController.idUsuarioSessao;

                    usuario = uController.atualizarUsuario(usuario);

                    if (usuario != null)
                    {
                        if (usuario.usuarioException == systemExMessages.MESSAGE_EMAIL_INVALIDO)
                        {
                            MetroFramework.MetroMessageBox.Show(this, systemExMessages.MESSAGE_EMAIL_INVALIDO, systemExMessages.TITLE_EMAIL_INVALIDO, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, systemExMessages.MESSAGE_DADOS_ATUALIZADOS, systemExMessages.TITLE_DADOS_ATUALIZADOS, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, systemExMessages.MESSAGE_ERRO_ATUALIZAR_DADOS, systemExMessages.TITLE_ERRO_ATUALIZAR_DADOS, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, systemExMessages.MESSAGE_MESMOS_DADOS, systemExMessages.TITLE_MESMOS_DADOS, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, systemExMessages.MESSAGE_DADOS_INVALIDOS, systemExMessages.TITLE_DADOS_INVALIDOS, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void BtnAlterarSenhaSlide_Click(object sender, EventArgs e)
        {
            if (btnAlterarSenhaClick == false)
            {
                btnAlterarSenhaClick = true;
                alterarSenhaPanel.Visible = true;

                while (alterarSenhaPanel.Width <= 250)
                {
                    alterarSenhaPanel.Width += 4;
                }
            }
            else
            {
                btnAlterarSenhaClick = false;

                while (alterarSenhaPanel.Width > 10)
                {
                    alterarSenhaPanel.Width -= 4;
                }

                alterarSenhaPanel.Visible = false;
            }
        }

        private void BtnAlterarSenha_Click(object sender, EventArgs e)
        {
            string newPass = newPassword.Text;
            string repeatNewPass = repeatNewPassword.Text;

            if (!(oldPassword.Text.Equals("") || newPassword.Text.Equals("") || repeatNewPassword.Text.Equals("")))
            {
                if (newPass.Equals(repeatNewPass))
                {
                    Usuario usuario = new Usuario();
                    usuario.idUsuario = uController.idUsuarioSessao;
                    usuario.senha = oldPassword.Text;

                    usuario = uController.VerificarSenhaUsuario(usuario);

                    if (usuario != null)
                    {
                        usuario.senha = newPass;

                        usuario = uController.AtualizarSenhaUsuario(usuario);

                        if (usuario.usuarioException == null)
                        {
                            MetroFramework.MetroMessageBox.Show(this, systemExMessages.MESSAGE_SENHA_ATUALIZADA, systemExMessages.TITLE_SENHA_ATUALIZADA, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            oldPassword.Clear();
                            newPassword.Clear();
                            repeatNewPassword.Clear();

                            BtnAlterarSenhaSlide_Click(sender, e);
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, systemExMessages.MESSAGE_ERRO_ATUALIZAR_SENHA, systemExMessages.TITLE_ERRO_ATUALIZAR_SENHA, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, systemExMessages.MESSAGE_SENHA_ANTIGA_ERRADA, systemExMessages.TITLE_SENHA_ANTIGA_ERRADA, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, systemExMessages.MESSAGE_MESMOS_DADOS, systemExMessages.TITLE_MESMOS_DADOS, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, systemExMessages.MESSAGE_DADOS_INVALIDOS, systemExMessages.TITLE_DADOS_INVALIDOS, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnTrocarFoto_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            if(!(newUsuarioText.Text.Equals("") || newNomeText.Text.Equals("") || newEmailText.Text.Equals("") || newSenhaText.Text.Equals("")))
            {
                NivelAcesso nivelAcesso = new NivelAcesso();
                nivelAcesso.nomePerfil = descricaoCombo.SelectedItem.ToString();

                if (nivelAcesso.nomePerfil.Equals("Administrador"))
                {
                    nivelAcesso.nivelAcessoUsuario = 1;
                }
                else if (nivelAcesso.nomePerfil.Equals("Gestor"))
                {
                    nivelAcesso.nivelAcessoUsuario = 2;
                }

                Usuario usuario = new Usuario();
                usuario.usuario = newUsuarioText.Text;
                usuario.nome = newNomeText.Text;
                usuario.email = newEmailText.Text;
                usuario.senha = newSenhaText.Text;
                usuario.idUsuarioLogado = uController.idUsuarioSessao;
                usuario.nivelAcesso = nivelAcesso;

                usuario = uController.CadastrarUsuario(usuario);

                if(usuario != null)
                {
                    //mensagem de sucesso.
                    MetroFramework.MetroMessageBox.Show(this, "Foi", "Ae", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //mensagem de erro com o banco.
                    MetroFramework.MetroMessageBox.Show(this, "Deu pau no banco", "vish", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
            else
            {
                // informar que os campos estão vazios, por favor preencher
                MetroFramework.MetroMessageBox.Show(this, "Preenche os campos ae fera", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnCadastrarTipoUsuarioSlide_Click(object sender, EventArgs e)
        {
            if (btnCadastrarTipoUsuarioClick == false)
            {
                btnCadastrarTipoUsuarioClick = true;

                while (panelRegister.Width <= 600)
                {
                    panelRegister.Width += 4;
                }

                panelUserTypeRegister.Visible = true;
            }
            else
            {
                btnCadastrarTipoUsuarioClick = false;

                panelUserTypeRegister.Visible = false;

                while (panelRegister.Width > 300)
                {
                    panelRegister.Width -= 4;
                }
            }
        }

        private void BtnCadastrarTipoUsuario_Click(object sender, EventArgs e)
        {
            if (!(newTipoUsuarioText.Text.Equals("") || newNivelAcessoText.Text.Equals("")))
            {
                NivelAcesso nivelAcesso = new NivelAcesso();
                nivelAcesso.nomePerfil = newTipoUsuarioText.Text;
                nivelAcesso.nivelAcesso = newNivelAcessoText.Text;

                Usuario usuario = new Usuario();
                usuario.idUsuarioLogado = uController.idUsuarioSessao;
                usuario.nivelAcesso = nivelAcesso;

                usuario = uController.CadastrarTipoUsuario(usuario);

                if (usuario != null)
                {
                    //mensagem de sucesso.
                    MetroFramework.MetroMessageBox.Show(this, "Foi", "Ae", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    newTipoUsuarioText.Clear();
                    newNivelAcessoText.Clear();

                    BtnCadastrarTipoUsuarioSlide_Click(sender, e);
                }
                else
                {
                    //mensagem de erro com o banco.
                    MetroFramework.MetroMessageBox.Show(this, "Deu pau no banco", "vish", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                // informar que os campos estão vazios, por favor preencher
                MetroFramework.MetroMessageBox.Show(this, "Preenche os campos ae fera", "Ops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }




        bool value = false;

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if(value == false)
            {
                MessageBox.Show("Ta ativo");
                value = true;
            }
            else
            {
                MessageBox.Show("Ta inativo");
                value = false;
            }
        }


    }
}
