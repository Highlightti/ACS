using AdministrationClinicalSystem.br.com.acs.factory;
using AdministrationClinicalSystem.br.com.acs.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace AdministrationClinicalSystem.br.com.acs.dao
{
    class UsuarioDAO : MetroFramework.Forms.MetroForm
    {
        #region Variáveis de Funcionamento

        private static ConexaoMySQL connection;
        private static UsuarioDAO instance;
        private static MySqlCommand command;

        #endregion

        #region Instâncias (Singleton Pattern).

        SystemExceptionsMessages systemExMessages = SystemExceptionsMessages.getInstance();

        #endregion

        #region Querys para operações no Banco de Dados

        /*->*/private static string CADASTRAR_TIPO_USUARIO = "INSERT INTO nivel_acesso (nome_perfil, nivel_acesso, data_modificacao, usuario_modificacao) VALUES (?, ?, SYSDATE(), ?)";
        /*Agrupar a atribuição de acesso para um usuário junto da query de cadastro*/
        /*->*/private static string CADASTRAR_USUARIO = "INSERT INTO usuario (usuario, nome, email, senha, status_usuario, data_modificacao, usuario_modificacao) VALUES (?, ?, ?, MD5(?), ?, SYSDATE(), ?)";
        /*->*/private static string CADASTRAR_USUARIO_ACESSO = "INSERT INTO usuario_acesso (id_usuario, id_nivel_acesso) VALUES (?, ?)";
        /*->*/private static string CONSULTAR_USUARIO = "SELECT usuario, nome, email FROM usuario WHERE id_usuario = ?";
        private static string CONSULTAR_TODOS_USUARIOS = "SELECT usuario, nome, email, status_usuario FROM usuario WHERE status_usuario = 1";
        /*Recuperar apenas para o adm os dados mais sensiveis para realizar alterações quando necessário daquele usuário específico*/
        /*->*/private static string VERIFICAR_EMAIL_USUARIO = "SELECT email FROM usuario WHERE email = ?";
        /*->*/private static string ATUALIZAR_USUARIO = "UPDATE usuario SET usuario = ?, nome = ?, email = ? WHERE id_usuario = ?";
        /*->*/private static string VERIFICAR_SENHA_USUARIO = "SELECT nome FROM usuario WHERE senha = MD5(?) AND id_usuario = ?";
        /*->*/private static string ATUALIZAR_SENHA_USUARIO = "UPDATE usuario SET senha = MD5(?) WHERE id_usuario = ?";
        private static string DESATIVAR_USUARIO = "UPDATE usuario SET status_usuario = 0 WHERE id_usuario = ?";
        /*->*/private static string INGRESSAR_USUARIO = "SELECT usuario.id_usuario, usuario.nome, nivel_acesso.nome_perfil FROM usuario JOIN usuario_acesso ON usuario.id_usuario=usuario_acesso.id_usuario JOIN nivel_acesso ON nivel_acesso.id_nivel_acesso=usuario_acesso.id_nivel_acesso WHERE usuario = ? AND senha = MD5(?)";
        /*->*/private static string REGISTRAR_ACAO_USUARIO_LOGIN_LOGOUT = "INSERT INTO login (id_usuario, acao, data_hora) VALUES (?, ?, SYSDATE())";
        /*->*/private static string VERIFICAR_CONEXAO = "SELECT nome FROM usuario WHERE id_usuario = ?";

        #endregion

        #region Métodos de Funcionamento

        /// <summary>
        /// Construtor da classe UsuarioDAO e já estabelece a conexão com o banco de dados.
        /// </summary>
        public UsuarioDAO()
        {
            connection = new ConexaoMySQL();
        }

        /// <summary>
        ///  Método responsável por criar uma instância da classe ConsumidorDAO (Singleton Pattern).
        /// </summary>
        public static UsuarioDAO getInstance()
        {
            if(instance == null)
            {
                instance = new UsuarioDAO();
            }
            return instance;
        }

        #endregion

        #region Métodos para operações no Banco de Dados



        /// <summary>
        /// Método responsável por fazer a verificação se existe conexão com o Banco de Dados, para poder exibir o message box adequado.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>usuario</returns>
        public Usuario VerificaConexaoBanco(Usuario usuario)
        {
            try
            {
                command = new MySqlCommand(VERIFICAR_CONEXAO, connection.GetConnection());
                command.Parameters.AddWithValue("?id_usuario", usuario.idUsuario);
                command.CommandType = CommandType.Text;

                MySqlDataReader myDataReader;
                try
                {
                    myDataReader = command.ExecuteReader();
                    myDataReader.Read();

                    usuario.nome = myDataReader.GetString(0);
                }
                catch
                {
                    usuario = null;
                }
            }
            catch (MySqlException ex)
            {
                throw (ex);
                //MessageBox.Show("Erro de comunicação com o Banco de Dados." + ex);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            return usuario;
        }



        /// <summary>
        /// Método responsável por cadastrar o tipo de usuário no Banco de Dados, para saber o seu nível de acesso no sistema.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        internal Usuario CadastrarTipoUsuario(Usuario usuario)
        {
            try
            {
                command = new MySqlCommand(CADASTRAR_TIPO_USUARIO, connection.GetConnection());
                command.Parameters.AddWithValue("?nome_perfil", usuario.nivelAcesso.nomePerfil);
                command.Parameters.AddWithValue("?nivel_acesso", usuario.nivelAcesso.nivelAcesso);
                command.Parameters.AddWithValue("?usuario_modificacao", usuario.idUsuarioLogado);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    usuario = null;
                    throw (ex);
                }
            }
            catch (MySqlException ex)
            {
                usuario = null;
                throw (ex);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            return usuario;
        }



        /// <summary>
        /// Método responsável por cadastrar usuários no Banco de Dados.
        /// </summary>
        /// <param name="usuario"></param>
        public Usuario CadastrarUsuario(Usuario usuario)
        {
            long idUsuario = 0;
            long idNivelAcesso = 0;
            int statusNovoUsurio = 1;

            try
            {
                command = new MySqlCommand(CADASTRAR_USUARIO, connection.GetConnection());
                command.Parameters.AddWithValue("?usuario", usuario.usuario);
                command.Parameters.AddWithValue("?nome", usuario.nome);
                command.Parameters.AddWithValue("?email", usuario.email);
                command.Parameters.AddWithValue("?senha", usuario.senha);
                command.Parameters.AddWithValue("?status_usuario", statusNovoUsurio.ToString());
                command.Parameters.AddWithValue("?usuario_modificacao", usuario.idUsuarioLogado);

                try
                {
                    command.ExecuteNonQuery();

                    idUsuario = command.LastInsertedId;

                    command = new MySqlCommand(CADASTRAR_USUARIO_ACESSO, connection.GetConnection());
                    command.Parameters.AddWithValue("?id_usuario", idUsuario);
                    command.Parameters.AddWithValue("?id_nivel_acesso", usuario.nivelAcesso.nivelAcessoUsuario);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        usuario = null;
                        throw (ex);
                    }
                }
                catch (MySqlException ex)
                {
                    usuario = null;
                    throw (ex);
                }
            }
            catch(MySqlException ex)
            {
                usuario = null;
                throw (ex);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            return usuario;
        }



        /// <summary>
        /// Método responsável por consultar os dados do usuário logado.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>usuario</returns>
        public Usuario ConsultarUsuario(Usuario usuario)
        {
            try
            {
                command = new MySqlCommand(CONSULTAR_USUARIO, connection.GetConnection());
                command.Parameters.AddWithValue("?id_usuario", usuario.idUsuario);
                command.CommandType = CommandType.Text;

                MySqlDataReader myDataReader;
                try
                {
                    myDataReader = command.ExecuteReader();
                    myDataReader.Read();

                    usuario.usuario = myDataReader.GetString(0);
                    usuario.nome = myDataReader.GetString(1);
                    usuario.email = myDataReader.GetString(2);
                }
                catch
                {
                    usuario = null;
                }
                
            }
            catch(MySqlException ex)
            {
                throw (ex);
                //MessageBox.Show("Erro de comunicação com o Banco de Dados." + ex);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            return usuario;
        }



        /// <summary>
        /// Método responsável por consultar todos os usuários no Banco de Dados.
        /// </summary>
        /// <returns>List<Usuario></Usuario></returns>
        public List<Usuario> ConsultarTodosUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                command = new MySqlCommand(CONSULTAR_TODOS_USUARIOS, connection.GetConnection());
                command.CommandType = CommandType.Text;

                MySqlDataReader myDataReader;
                myDataReader = command.ExecuteReader();
                
                while (myDataReader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.usuario = myDataReader.GetString("usuario");
                    usuario.nome = myDataReader.GetString("nome");
                    usuario.email = myDataReader.GetString("email");
                    //usuario.emailGrupo = myDataReader.GetString("email_grupo");
                    usuario.statusUsuario = myDataReader.GetInt16("status_usuario");

                    usuarios.Add(usuario);
                }
                
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Erro de comunicação com o Banco de Dados." + ex);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            return usuarios;
        }



        /// <summary>
        /// Método responsável por verificar se já existe o novo e-mail cadastrado no Banco de Dados.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>usuario</returns>
        public Usuario VerificarEmailUsuario(Usuario usuario)
        {
            try
            {
                command = new MySqlCommand(VERIFICAR_EMAIL_USUARIO, connection.GetConnection());
                command.Parameters.AddWithValue("?email", usuario.email);
                command.CommandType = CommandType.Text;

                MySqlDataReader myDataReader;

                try {
                    
                    myDataReader = command.ExecuteReader();

                    if (myDataReader.Read())
                    {
                        usuario.email = myDataReader.GetString(0);
                    }
                    else
                    {
                        usuario.email = null;
                    }
                }
                catch
                {
                    usuario = null;
                }
            }
            catch (MySqlException ex)
            {
                throw (ex);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            return usuario;
        }



        /// <summary>
        /// Método responsável por atualizar dados dos usuários somente pelo usuário Administrador.
        /// </summary>
        /// <param name="usuario"></param>
        public Usuario AtualizarDadosUsuario(Usuario usuario)
        {
            try
            {
                command = new MySqlCommand(ATUALIZAR_USUARIO, connection.GetConnection());

                command.Parameters.AddWithValue("?usuario", usuario.usuario);
                command.Parameters.AddWithValue("?nome", usuario.nome);
                command.Parameters.AddWithValue("?email", usuario.email);
                command.Parameters.AddWithValue("?id_usuario", usuario.idUsuario);

                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro de comunicação com o Banco de Dados." + ex);
                usuario = null;
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            return usuario;
        }



        /// <summary>
        /// Mátodo responsável por verificar se a senha existe no Banco de Dados.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>usuario</returns>
        public Usuario VerificarSenhaUsuario(Usuario usuario)
        {
            try
            {
                command = new MySqlCommand(VERIFICAR_SENHA_USUARIO, connection.GetConnection());
                command.Parameters.Add("@senha", MySqlDbType.VarChar).Value = usuario.senha;
                command.Parameters.Add("@id_usuario", MySqlDbType.UInt32).Value = usuario.idUsuario;
                command.CommandType = CommandType.Text;

                MySqlDataReader myDataReader;

                myDataReader = command.ExecuteReader();

                if (myDataReader.Read())
                {
                    usuario.nome = myDataReader.GetString(0);
                }
                else
                {
                    usuario = null;
                }
            }
            catch (MySqlException ex)
            {
                throw (ex);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            return usuario;
        }



        /// <summary>
        /// Método responsável por atualizar a senha do usuário logado.
        /// </summary>
        /// <param name="usuario"></param>
        public Usuario AtualizarSenhaUsuario(Usuario usuario)
        {
            try
            {
                command = new MySqlCommand(ATUALIZAR_SENHA_USUARIO, connection.GetConnection());
                command.Parameters.AddWithValue("?senha", usuario.senha);
                command.Parameters.AddWithValue("?id_usuario", usuario.idUsuario);
                command.CommandType = CommandType.Text;

                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    usuario = null;
                }
                
            }
            catch(MySqlException ex)
            {
                throw (ex);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }
            return usuario;
        }



        /// <summary>
        /// Método responsável por desativar o usuário logado.
        /// </summary>
        /// <param name="usuario"></param>
        public void DesativarUsuario(Usuario usuario)
        {
            try
            {
                command = new MySqlCommand(DESATIVAR_USUARIO, connection.GetConnection());
                command.Parameters.Add("@id_usuario", MySqlDbType.UInt32).Value = usuario.idUsuario;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Erro de comunicação com o Banco de Dados." + ex);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }
        }



        /// <summary>
        /// Método responsável por fazer o login do usuário.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>usuario</returns>
        public Usuario LoginUsuario(Usuario usuario)
        {
            try
            {
                command = new MySqlCommand(INGRESSAR_USUARIO, connection.GetConnection());
                command.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = usuario.usuario;
                command.Parameters.Add("@senha", MySqlDbType.VarChar).Value = usuario.senha;
                command.CommandType = CommandType.Text;

                MySqlDataReader myDataReader;
                try
                {
                    myDataReader = command.ExecuteReader();

                    if (myDataReader.Read())
                    {
                        usuario.idUsuario = myDataReader.GetInt32(0);
                        usuario.nome = myDataReader.GetString(1);

                        NivelAcesso nivelAcesso = new NivelAcesso();
                        nivelAcesso.nomePerfil = myDataReader.GetString(2);

                        usuario.nivelAcesso = nivelAcesso;

                        int acaoLogin = 1;

                        command = new MySqlCommand(REGISTRAR_ACAO_USUARIO_LOGIN_LOGOUT, connection.GetConnection());
                        command.Parameters.AddWithValue("?id_usuario", usuario.idUsuario);
                        command.Parameters.AddWithValue("?acao", acaoLogin);
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        usuario.nome = null;
                    }

                    myDataReader.Close();
                }
                catch
                {
                    Application.Restart();
                }
            }
            catch (MySqlException ex)
            {
                usuario.usuarioException = systemExMessages.ERRO_CONEXÃO_BANCO;
                throw (ex);
                //MetroFramework.MetroMessageBox.Show(this, systemExMessages.ERRO_CONEXÃO_BANCO, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            return usuario;
        }



        /// <summary>
        /// Método responsável por fazer o logout do usuário.
        /// </summary>
        /// <param name="usuario"></param>
        public Usuario LogoutUsuario(Usuario usuario)
        {
            try
            {
                int acaoLogout = 0;

                command = new MySqlCommand(REGISTRAR_ACAO_USUARIO_LOGIN_LOGOUT, connection.GetConnection());
                command.Parameters.AddWithValue("?id_usuario", usuario.idUsuario);
                command.Parameters.AddWithValue("?acao", acaoLogout);
                command.ExecuteNonQuery();

                usuario.idUsuarioLogado = (int)command.LastInsertedId;
            }
            catch (MySqlException ex)
            {
                throw (ex);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            return usuario;
        }

        #endregion
 
    }
}
