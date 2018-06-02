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

        UsuarioController uController = UsuarioController.getInstance();

        string user = "";
        string nome = "";
        string email = "";

        Usuario usuario = new Usuario();

        private void ACSDadosUsuarioAdministrador_Load(object sender, EventArgs e)
        {
            usuarioTextMy.Text = uController.readUsuario.ToString();
            nomeTextMy.Text = uController.readNome.ToString();
            emailTextMy.Text = uController.readEmail.ToString();
            textBox1.Text = "Testeee caralho, meu ovo esquerdo  porrrraaaaaa";
            //textBox1.Text = uController.readEmail;
        }
    }
}
