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
            uController.ConsultarUsuario(uController.tipoUsuarioLogado);

            usuarioTextMy.Text = uController.readUsuario.ToString();
            nomeTextMy.Text = uController.readNome.ToString();
            emailTextMy.Text = uController.readEmail.ToString();

            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.usuario = usuarioTextMy.Text;
            usuario.nome = nomeTextMy.Text;
            usuario.email = emailTextMy.Text;
            usuario.idUsuario = uController.idUsuarioSessao;

            usuario = uController.atualizarUsuario(usuario);

            if(usuario != null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Dados atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
