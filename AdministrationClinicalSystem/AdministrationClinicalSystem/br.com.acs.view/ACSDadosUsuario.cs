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

        bool btnAlterarSenhaClick = false;

        private void btnAlterarSenhaSlide_Click(object sender, EventArgs e)
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
    }
}
