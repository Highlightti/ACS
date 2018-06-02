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
        

        public void CarregaDadosUsuarioAdministrador(Usuario usuario)
        {
            //passar a foto
            usuarioTextMy.Text = usuario.usuario.ToString();
            nomeTextMy.Text = usuario.nome.ToString();
            emailTextMy.Text = usuario.email.ToString();
            textBox1.Text = "Testeee caralho, meu ovo esquerdo  porrrraaaaaa";
        }
    }
}
