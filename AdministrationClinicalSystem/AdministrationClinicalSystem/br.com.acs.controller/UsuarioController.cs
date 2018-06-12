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
        public string emailUsuarioLogado = "";
        public string localReadUsuario = "";
        public string localReadNome = "";
        public string localReadEmail = "";

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
        /// Método responsável por verificar a conexão com o banco de dados.
        /// </summary>
        /// <returns>usuario</returns>
        public Usuario VerificaConexãoBanco()
        {
            Usuario usuario = new Usuario();
            usuario.idUsuario = idUsuarioSessao;

            UsuarioDAO uDAO = UsuarioDAO.getInstance();

            usuario = uDAO.VerificaConexaoBanco(usuario);

            return usuario;
        }



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
                    tipoUsuarioLogado = usuario.nivelAcesso.nomePerfil;
                }
                else
                {
                    usuario.usuarioException = systemExMessages.MESSAGE_LOGIN_INVALIDO;
                }
            }
            
            return usuario;
        }



        /// <summary>
        /// Método controller responsável por receber a requisição da view e realizar o Logout do usuário logado.
        /// </summary>
        /// <param name="usuario"></param>
        public Usuario LogoutUsuario()
        {
            Usuario usuario = new Usuario();
            usuario.idUsuario = idUsuarioSessao;

            UsuarioDAO uDAO = UsuarioDAO.getInstance();

            usuario = uDAO.LogoutUsuario(usuario);

            if(usuario.idUsuarioLogado == 0)
            {
                usuario.usuarioException = systemExMessages.MESSAGE_ERRO_LOGOUT;
            }

            return usuario;
        }



        /// <summary>
        /// Método controller para cadastrar tipo usuário (Disponível apenas para usuário Administrativo do sistema, ou seja, HIGHLIGHTTI).
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>usuario</returns>
        public Usuario CadastrarTipoUsuario(Usuario usuario)
        {
            UsuarioDAO uDAO = UsuarioDAO.getInstance();
            usuario = uDAO.CadastrarTipoUsuario(usuario);

            return usuario;
        }



        /// <summary>
        /// Método controller para cadastrar usuário (Disponível apenas para usuário Administrativo do sistema, ou seja, HIGHLIGHTTI).
        /// </summary>
        /// <param name="usuario"></param>
        public Usuario CadastrarUsuario(Usuario usuario)
        {
            UsuarioDAO uDAO = UsuarioDAO.getInstance();
            usuario = uDAO.CadastrarUsuario(usuario);

            return usuario;
        }



        /// <summary>
        /// Método controller responsável por receber a requisição da view para consultar os dados do usuário logado.
        /// </summary>
        /// <param name="tipoUsuarioLogado"></param>
        public void ConsultarUsuario(string tipoUsuarioLogado)
        {
            Usuario usuario = new Usuario();
            usuario.idUsuario = idUsuarioSessao;

            UsuarioDAO uDAO = UsuarioDAO.getInstance();
            usuario = uDAO.ConsultarUsuario(usuario);

            if (tipoUsuarioLogado.Equals("Administrador"))
            {
                emailUsuarioLogado = usuario.email;

                localReadUsuario = usuario.usuario;
                localReadNome = usuario.nome;
                localReadEmail = usuario.email;
            }
            else
            {
                emailUsuarioLogado = usuario.email;

                localReadUsuario = usuario.usuario;
                localReadNome = usuario.nome;
                localReadEmail = usuario.email;
            }
        }



        /// <summary>
        /// Método controller para atualizar os dados do usuário.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public Usuario atualizarUsuario(Usuario usuario)
        {
            UsuarioDAO uDAO = UsuarioDAO.getInstance();

            // Verifica se o e-mail que está sendo é igual ao do momento da consulta, se sim, libera a alteração direto.
            if (usuario.email.Equals(emailUsuarioLogado))
            {
                usuario = uDAO.AtualizarDadosUsuario(usuario);
            }
            else
            {
                string novoEmail = usuario.email;

                // Caso o e-mail seja diferente do passado no momento da consulta, faz uma verificação de todos os e-mails cadastrados para não ter conflito.
                usuario = uDAO.VerificarEmailUsuario(usuario);

                if(usuario != null)
                {
                    // Caso não retorne nada do banco de dados, significa que esse novo e-mail pode er cadastrado.
                    if (usuario.email == null)
                    {
                        usuario.email = novoEmail;
                        usuario = uDAO.AtualizarDadosUsuario(usuario);
                    }
                    else
                    {
                        //exibir mensagem ou atribuir mensagem alegando que não pode usar esse e-mail, pois já existe no banco.
                        usuario.usuarioException = systemExMessages.MESSAGE_EMAIL_INVALIDO;
                    }
                }
            }

            return usuario;
        }



        /// <summary>
        /// Método controller para verificar a autenticidade da senha antiga do usuário.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public Usuario VerificarSenhaUsuario(Usuario usuario)
        {
            UsuarioDAO uDAO = UsuarioDAO.getInstance();

            usuario = uDAO.VerificarSenhaUsuario(usuario);

            return usuario;
        }


        /// <summary>
        /// Método controller para realizar a alteração da senha do usuário.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>usuario</returns>
        public Usuario AtualizarSenhaUsuario(Usuario usuario)
        {
            UsuarioDAO uDAO = UsuarioDAO.getInstance();

            usuario = uDAO.AtualizarSenhaUsuario(usuario);

            if(usuario == null)
            {
                usuario.usuarioException = systemExMessages.MESSAGE_ERRO_ATUALIZAR_SENHA;
            }

            return usuario;
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
