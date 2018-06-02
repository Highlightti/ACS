using AdministrationClinicalSystem.br.com.acs.controller;
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

        UsuarioController uController = UsuarioController.getInstance();

        public ACSMainPanel()
        {
            InitializeComponent();
            
            this.StyleManager = metroStyleManagerMain;

            // Caso o evento tenha ocorrido, termine toda a aplicação.
            this.Closed += (s, ev) => Application.Exit();
        }

        private void ACSLogin_Load(object sender, EventArgs e)
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

        #region Menu Slide and Navigation Screen


        bool btnMenuClick = false;

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

        private void btnHome_Click(object sender, EventArgs e)
        {
            ACSHome home = new ACSHome();
            NavigationScreen(home, contentPanel);
        }

        private void btnEquipamentos_Click(object sender, EventArgs e)
        {
            ACSEquipamentos equipamentos = new ACSEquipamentos();
            NavigationScreen(equipamentos, contentPanel);
        }

        private void btnMeusDados_Click(object sender, EventArgs e)
        {
            if (uController.tipoUsuarioLogado.Equals("Administrador"))
            {
                ACSDadosUsuarioAdministrador dadosUsuarioAdministrador = new ACSDadosUsuarioAdministrador();
                NavigationScreen(dadosUsuarioAdministrador, contentPanel);
                //uController.ConsultarUsuario(uController.tipoUsuarioLogado);
            }
            else
            {
                ACSDadosUsuario dadosUsuario = new ACSDadosUsuario();
                NavigationScreen(dadosUsuario, contentPanel);
                uController.ConsultarUsuario(uController.tipoUsuarioLogado);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Yes/No", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();

                //limpar o nome do usuário instanciado na sessão quando fazer o logout.
            }
            
        }

        #endregion
    }
}
