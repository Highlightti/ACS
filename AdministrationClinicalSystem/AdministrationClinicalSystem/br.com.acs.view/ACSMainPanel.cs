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

            //Iniciando a aplicação com a página Home.
            ACSHome home = new ACSHome();
            NavigationScreen(home, contentPanel);

            //Caso o evento tenha ocorrido, termine toda a aplicação.
            this.Closed += (s, ev) => Application.Exit();
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

        #endregion

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroComboBox1.SelectedIndex)
            {
                case 0:
                    metroStyleManagerMain.Theme = MetroFramework.MetroThemeStyle.Dark;
                    break;
                case 1:
                    metroStyleManagerMain.Theme = MetroFramework.MetroThemeStyle.Light;
                    break;
            }
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManagerMain.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(metroComboBox2.SelectedIndex);
        }

        private void ACSLogin_Load(object sender, EventArgs e)
        {
            metroComboBox1.SelectedIndex = 1;
            metroComboBox2.SelectedIndex = 5;
        }

        private void btnEquipamentos_Click(object sender, EventArgs e)
        {
            ACSEquipamentos equipamentos = new ACSEquipamentos();
            NavigationScreen(equipamentos, contentPanel);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ACSHome home = new ACSHome();
            NavigationScreen(home, contentPanel);
        }

        private void btnMeusDados_Click(object sender, EventArgs e)
        {
            ACSUsuario usuario = new ACSUsuario();
            NavigationScreen(usuario, contentPanel);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nomeUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
