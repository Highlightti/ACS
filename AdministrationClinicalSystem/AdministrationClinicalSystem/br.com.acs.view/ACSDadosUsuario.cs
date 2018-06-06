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
    public partial class ACSDadosUsuario : Form
    {
        public ACSDadosUsuario()
        {
            InitializeComponent();
        }

        private void ACSDadosUsuario_Load(object sender, EventArgs e)
        {
            uController.ConsultarUsuario(uController.tipoUsuarioLogado);

            usuarioTextMy.Text = uController.localReadUsuario.ToString();
            nomeTextMy.Text = uController.localReadNome.ToString();
            emailTextMy.Text = uController.localReadEmail.ToString();
        }

        #region Instâncias (Singleton Pattern). + Variáveis

        UsuarioController uController = UsuarioController.getInstance();
        SystemExceptionsMessages systemExMessages = SystemExceptionsMessages.getInstance();

        bool btnAlterarSenhaClick = false;

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
            string repeatNewPass = newPassword.Text;

            if (!(oldPassword.Text.Equals("") || newPassword.Text.Equals("") || newPassword.Text.Equals("")))
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
                            newPassword.Clear();

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
                    MetroFramework.MetroMessageBox.Show(this, systemExMessages.MESSAGE_NOVA_SENHA_ERRO_REPETICAO, systemExMessages.TITLE_NOVA_SENHA_ERRO_REPETICAO, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
