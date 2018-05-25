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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            ACSMainPanel acsMainPanel = new ACSMainPanel();
            acsMainPanel.Show();
        }

        
    }
}
