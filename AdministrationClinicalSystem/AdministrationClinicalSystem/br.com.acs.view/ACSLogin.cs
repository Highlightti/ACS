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
    public partial class ACSLogin : MetroFramework.Forms.MetroForm
    {
        public ACSLogin()
        {
            InitializeComponent();
        }

        private void ACSLogin_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManagerLogin;
            metroStyleManagerLogin.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManagerLogin.Style = MetroFramework.MetroColorStyle.White;

            this.Closed += (s, ev) => Application.Exit();
        }

        #region Instâncias (Singleton Pattern).

        UsuarioController usuarioController = UsuarioController.getInstance();
        SystemExceptionsMessages systemExMessages = SystemExceptionsMessages.getInstance();

        #endregion



        /// <summary>
        /// Método do evento Click do botão de Login.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(usuarioTextLogin.Text.Equals("") || senhaTextLogin.Text.Equals(""))
            {
                MetroFramework.MetroMessageBox.Show(this, systemExMessages.MESSAGE_CAMPOS_VAZIOS, systemExMessages.TITLE_LOGIN_INVALIDO, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.usuario = usuarioTextLogin.Text;
                usuario.senha = senhaTextLogin.Text;

                usuario = usuarioController.LoginUsuario(usuario);

                if (usuario.usuarioException != systemExMessages.ERRO_CONEXÃO_BANCO)
                {
                    if (usuario.usuarioException == null)
                    {
                        this.Hide();

                        ACSMainPanel acsMainPanel = new ACSMainPanel();
                        acsMainPanel.Show();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, systemExMessages.MESSAGE_LOGIN_INVALIDO, systemExMessages.TITLE_LOGIN_INVALIDO, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }

        /**
         * Possível método que irá receber a ação de uma checkbox para salvar os dados do login
         */
    }
}
