using AdministrationClinicalSystem.br.com.acs.controller;
using AdministrationClinicalSystem.br.com.acs.factory;
using AdministrationClinicalSystem.br.com.acs.model;
using AdministrationClinicalSystem.br.com.acs.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrationClinicalSystem
{
    public partial class ACSMainPanel : MetroFramework.Forms.MetroForm
    {
        public ACSMainPanel()
        {
            InitializeComponent();
            
            this.StyleManager = metroStyleManagerMain;

            // Caso o evento tenha ocorrido, termine toda a aplicação.
            this.Closed += (s, ev) => Application.Exit();
        }

        private void ACSMainPanel_Load(object sender, EventArgs e)
        {
            // Estilizando as cores da janela.
            this.StyleManager = metroStyleManagerMain;
            metroStyleManagerMain.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManagerMain.Style = MetroFramework.MetroColorStyle.Blue;

            // Iniciando a aplicação com a página Home.
            ACSHome home = new ACSHome();
            NavigationScreen(home, contentPanel);

            // Atribuindo o nome do usuário logado á sessão iniciada.
            nomeUsuario.Text = uController.usuarioSessao;
        }

        #region Instâncias (Singleton Pattern).

        UsuarioController uController = UsuarioController.getInstance();
        SystemExceptionsMessages systemExMessages = SystemExceptionsMessages.getInstance();

        #endregion

        #region Menu Slide and Navigation Screen

        bool btnMenuClick = false;
        bool btnSubMenuHover = false;

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (btnMenuClick == false)
            {
                btnMenuClick = true;
                menu.Visible = true;

                while (menu.Width <= 200)
                {
                    menu.Width += 4;
                }
            }
            else
            {
                btnMenuClick = false;

                while (menu.Width > 10)
                {
                    menu.Width -= 4;
                }

                menu.Visible = false;
            }
        }

        public void NavigationScreen(Form form, Panel panel)
        {
            form.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ACSHome home = new ACSHome();
            NavigationScreen(home, contentPanel);

            if(btnMenuClick == true)
            {
                btnMenu_Click(sender, e);
            }
        }

        private void BtnEquipamentos_Click(object sender, EventArgs e)
        {
            ACSEquipamentos equipamentos = new ACSEquipamentos();
            NavigationScreen(equipamentos, contentPanel);

            if (btnMenuClick == true)
            {
                btnMenu_Click(sender, e);
            }
        }

        private void BtnEquipamentos_Hover(object sender, EventArgs e)
        {
            if (btnSubMenuHover == false)
            {
                btnSubMenuHover = true;
                subMenu.Visible = true;

                while (subMenu.Width <= 400)
                {
                    subMenu.Width += 4;
                }
            }
            else
            {
                btnSubMenuHover = false;

                while (subMenu.Width > 200)
                {
                    subMenu.Width -= 4;
                }

                subMenu.Visible = false;
            }
        }

        private void BtnMeusDados_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario = uController.VerificaConexãoBanco();

            if (usuario != null)
            {
                if (uController.tipoUsuarioLogado.Equals("Administrador"))
                {
                    ACSDadosUsuarioAdministrador dadosUsuarioAdministrador = new ACSDadosUsuarioAdministrador();
                    NavigationScreen(dadosUsuarioAdministrador, contentPanel);

                    if (btnMenuClick == true)
                    {
                        btnMenu_Click(sender, e);
                    }
                }
                else if(uController.tipoUsuarioLogado.Equals("Gestor"))
                {
                    ACSDadosUsuario dadosUsuario = new ACSDadosUsuario();
                    NavigationScreen(dadosUsuario, contentPanel);

                    if (btnMenuClick == true)
                    {
                        btnMenu_Click(sender, e);
                    }
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, systemExMessages.ERRO_CONEXÃO_BANCO, "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Yes/No", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Usuario usuario = new Usuario();
                usuario = uController.LogoutUsuario();

                if (usuario.usuarioException == null)
                {
                    uController.idUsuarioSessao = 0;

                    this.Hide();
                    ACSLogin acsLogin = new ACSLogin();
                    acsLogin.Show();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, systemExMessages.MESSAGE_ERRO_LOGOUT, systemExMessages.TITLE_ERRO_LOGOUT, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        #endregion
    }
}
