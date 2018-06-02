using AdministrationClinicalSystem.br.com.acs.dao;
using AdministrationClinicalSystem.br.com.acs.model;
using AdministrationClinicalSystem.br.com.acs.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrationClinicalSystem.br.com.acs.controller
{
    class UsuarioController
    {
        #region Variáveis

        private static UsuarioController instance;
        public int idUsuarioSessao = 0;
        public string usuarioSessao = "";
        public string tipoUsuarioLogado = "";

        #endregion

        #region Singleton Pattern Controller

        /// <summary>
        ///  Método responsável por criar uma instância da classe UsuarioController (Singleton Pattern).
        /// </summary>
        public static UsuarioController getInstance()
        {
            if (instance == null)
            {
                instance = new UsuarioController();
            }
            return instance;
        }

        #endregion

        #region Instâncias (Singleton Pattern).
        
        SystemExceptionsMessages systemExMessages = SystemExceptionsMessages.getInstance();

        #endregion

        #region Métodos Controllers

        /// <summary>
        /// Método controller responsável por receber a requisição da view e gerenciar as chamadas a classe UsuarioDAO.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>login</returns>
        public Usuario LoginUsuario(Usuario usuario)
        {
            UsuarioDAO uDAO = UsuarioDAO.getInstance();
            usuario = uDAO.LoginUsuario(usuario);

            if(usuario.usuarioException == null)
            {
                if (usuario.nome != null)
                {
                    idUsuarioSessao = usuario.idUsuario;
                    usuarioSessao = usuario.nome;
                    //tipoUsuarioLogado = usuario.tipoUsuarioLogado;
                    tipoUsuarioLogado = "Administrador";
                }
                else
                {
                    usuario.usuarioException = systemExMessages.MESSAGE_LOGIN_INVALIDO;
                }
            }
            
            return usuario;
        }


        public void LogoutUsuario(Usuario usuario)
        {
            
        }

        /// <summary>
        /// Método controller para cadastrar usuário (Disponível apenas para usuário Administrativo do sistema, ou seja, HIGHLIGHTTI).
        /// </summary>
        /// <param name="usuario"></param>
        public void cadastrarUsuario(Usuario usuario)
        {

        }

        public void ConsultarUsuario(string tipoUsuarioLogado)
        {
            Usuario usuario = new Usuario();
            usuario.idUsuario = idUsuarioSessao;

            UsuarioDAO uDAO = UsuarioDAO.getInstance();
            usuario = uDAO.ConsultarUsuario(usuario);

            if (tipoUsuarioLogado.Equals("Administrador"))
            {
                ACSDadosUsuarioAdministrador dadosUsuarioAdministrador = new ACSDadosUsuarioAdministrador();
                
                dadosUsuarioAdministrador.CarregaDadosUsuarioAdministrador(usuario);
            }
            else
            {
                ACSDadosUsuario dadosUsuario = new ACSDadosUsuario();
                //passar a foto
                dadosUsuario.usuarioTextMy.Text = usuario.usuario;
                dadosUsuario.nomeTextMy.Text = usuario.nome;
                dadosUsuario.emailTextMy.Text = usuario.email;
            }
        }

        public void atualizarUsuario(Usuario usuario)
        {

        }

        /// <summary>
        /// Método controller para desativar usuário (Disponível apenas para usuário Administrativo do sistema, ou seja, HIGHLIGHTTI).
        /// </summary>
        /// <param name="usuario"></param>
        public void desativarUsuario(Usuario usuario)
        {

        }

        #endregion
    }
}
