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
    class UsuarioDAO
    {
        #region Variáveis de Funcionamento

        private static ConexaoMySQL connection;
        private static UsuarioDAO instance;
        private static MySqlCommand command;

        #endregion

        #region Querys para operações no Banco de Dados

        private static string CADASTRAR_USUARIO = "INSERT INTO usuario (usuario, nome, email, email_grupo, senha, status_usuario, data_modificacao, usuario_modificacao) VALUES (?, ?, ?, ?, ?, 1, SYSDATE(), ?)";//
        private static string CONSULTAR_USUARIO = "SELECT usuario, nome, email, email_grupo FROM usuario WHERE id_usuario = ?";//
        private static string CONSULTAR_TODOS_USUARIOS_ATIVOS = "SELECT usuario, nome, email, email_grupo, status_usuario FROM usuario WHERE status_usuario = 1";//
        private static string CONSULTAR_TODOS_USUARIOS_INATIVOS = "SELECT usuario, nome, email, email_grupo, status_usuario FROM usuario WHERE status_usuario = 0";//
        private static string ATUALIZAR_USUARIO = "UPDATE usuario SET nome = ? WHERE id_usuario = ?";//
        private static string VERIFICAR_SENHA_USUARIO = "SELECT email FROM usuario WHERE senha = CRYPT(?, senha) AND id_usuario = ?";//
        private static string ATUALIZAR_SENHA_USUARIO = "UPDATE usuario SET senha = ? WHERE id_usuario = ?";//
        private static string VERIFICAR_EMAIL_USUARIO = "SELECT email FROM usuario WHERE email = ?";//
        private static string ATUALIZAR_DADOS_USUARIO = "UPDATE usuario SET email = ?, email_grupo = ? WHERE id_usuario = ?";//
        private static string DESATIVAR_USUARIO = "UPDATE usuario SET status_usuario = 0 WHERE id_usuario = ?";//
        private static string INGRESSAR_USUARIO = "SELECT id_usuario, nome FROM usuario WHERE email = ? AND senha = ?";
        
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
        /// Método responsável por cadastrar usuários no Banco de Dados.
        /// </summary>
        /// <param name="usuario"></param>
        public void CadastrarUsuario(Usuario usuario)
        {
            try
            {
                command = new MySqlCommand(CADASTRAR_USUARIO, connection.GetConnection());
                command.Parameters.Add("@usuario", MySqlDbType.VarChar, 25).Value = usuario.tipoUsuario;
                command.Parameters.Add("@nome", MySqlDbType.VarChar, 70).Value = usuario.nome;
                command.Parameters.Add("@email", MySqlDbType.VarChar, 70).Value = usuario.email;
                command.Parameters.Add("@email_grupo", MySqlDbType.VarChar, 70).Value = usuario.emailGrupo;
                command.Parameters.Add("@senha", MySqlDbType.VarChar, 25).Value = usuario.senha;
                command.Parameters.Add("@usuario_modificacao", MySqlDbType.UInt32).Value = usuario.idUsuarioLogado;
                command.ExecuteNonQuery();

                connection.Commit();
            }
            catch(MySqlException ex)
            {
                connection.Rollback();
                MessageBox.Show("Erro de comunicação com o Banco de Dados." + ex);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }
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
                command.Parameters.Add("@id_usuario", MySqlDbType.UInt32).Value = usuario.idUsuario;
                command.CommandType = CommandType.Text;

                MySqlDataReader myDataReader;
                myDataReader = command.ExecuteReader();
                myDataReader.Read();

                usuario.nome = myDataReader.GetString(0);
                usuario.email = myDataReader.GetString(1);
                usuario.emailGrupo = myDataReader.GetString("email_grupo");
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

            return usuario;
        }

        /// <summary>
        /// Método responsável por consultar todos os usuários com o status ativo no Banco de Dados.
        /// </summary>
        /// <returns>List<Usuario></Usuario></returns>
        public List<Usuario> ConsultarTodosUsuariosAtivos()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                command = new MySqlCommand(CONSULTAR_TODOS_USUARIOS_ATIVOS, connection.GetConnection());
                command.CommandType = CommandType.Text;

                MySqlDataReader myDataReader;
                myDataReader = command.ExecuteReader();
                
                while (myDataReader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.tipoUsuario = myDataReader.GetString("usuario");
                    usuario.nome = myDataReader.GetString("nome");
                    usuario.email = myDataReader.GetString("email");
                    usuario.emailGrupo = myDataReader.GetString("email_grupo");
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
        /// Método responsável por consultar todos os usuários com o status inativo no Banco de Dados.
        /// </summary>
        /// <returns>List<Usuario></Usuario></returns>
        public List<Usuario> ConsultarTodosUsuariosInativos()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                command = new MySqlCommand(CONSULTAR_TODOS_USUARIOS_INATIVOS, connection.GetConnection());
                command.CommandType = CommandType.Text;

                MySqlDataReader myDataReader;
                myDataReader = command.ExecuteReader();

                while (myDataReader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.tipoUsuario = myDataReader.GetString("usuario");
                    usuario.nome = myDataReader.GetString("nome");
                    usuario.email = myDataReader.GetString("email");
                    usuario.emailGrupo = myDataReader.GetString("email_grupo");
                    usuario.statusUsuario = myDataReader.GetInt16("status_usuario");

                    usuarios.Add(usuario);
                }

            }
            catch (MySqlException ex)
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
        /// Método responsável por atualizar somente o nome do usuário logado.
        /// </summary>
        /// <param name="usuario"></param>
        public void AtualizarUsuario(Usuario usuario)
        {
            try
            {
                command = new MySqlCommand(ATUALIZAR_USUARIO, connection.GetConnection());
                command.Parameters.Add("@nome", MySqlDbType.VarChar, 70).Value = usuario.nome;
                command.Parameters.Add("@id_usuario", MySqlDbType.UInt32).Value = usuario.idUsuario;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                connection.Commit();
            }
            catch(MySqlException ex)
            {
                connection.Rollback();
                MessageBox.Show("Erro de comunicação com o Banco de Dados." + ex);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }
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
                command.Parameters.Add("@senha", MySqlDbType.VarChar, 25).Value = usuario.senha;
                command.Parameters.Add("@id_usuario", MySqlDbType.UInt32).Value = usuario.idUsuario;
                command.CommandType = CommandType.Text;

                MySqlDataReader myDataReader;
                myDataReader = command.ExecuteReader();
                myDataReader.Read();

                usuario.email = myDataReader.GetString(0);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro de comunicação com o Banco de Dados." + ex);
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
        public void AtualizarSenhaUsuario(Usuario usuario)
        {
            try
            {
                command = new MySqlCommand(ATUALIZAR_SENHA_USUARIO, connection.GetConnection());
                command.Parameters.Add("@senha", MySqlDbType.VarChar, 25).Value = usuario.senha;
                command.Parameters.Add("@id_usuario", MySqlDbType.UInt32).Value = usuario.idUsuario;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                connection.Commit();
            }
            catch(MySqlException ex)
            {
                connection.Rollback();
                MessageBox.Show("Erro de comunicação com o Banco de Dados." + ex);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }
        }

        /// <summary>
        /// Método responsável por verificar se já existe e-mails cadastrado no Banco de Dados.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>usuario</returns>
        public Usuario VerificarEmailUsuario(Usuario usuario)
        {
            try
            {
                command = new MySqlCommand(VERIFICAR_EMAIL_USUARIO, connection.GetConnection());
                command.Parameters.Add("@email", MySqlDbType.VarChar, 70).Value = usuario.email;
                command.CommandType = CommandType.Text;

                MySqlDataReader myDataReader;
                myDataReader = command.ExecuteReader();
                myDataReader.Read();

                usuario.email = myDataReader.GetString(0);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro de comunicação com o Banco de Dados." + ex);
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
        public void AtualizarDadosUsuario(Usuario usuario)
        {
            try
            {
                command = new MySqlCommand(ATUALIZAR_DADOS_USUARIO, connection.GetConnection());
                command.Parameters.Add("@email", MySqlDbType.VarChar, 70).Value = usuario.email;
                command.Parameters.Add("@email_grupo", MySqlDbType.VarChar, 70).Value = usuario.emailGrupo;
                command.Parameters.Add("@id_usuario", MySqlDbType.UInt32).Value = usuario.idUsuario;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                connection.Commit();
            }
            catch (MySqlException ex)
            {
                connection.Rollback();
                MessageBox.Show("Erro de comunicação com o Banco de Dados." + ex);
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }
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

                connection.Commit();
            }
            catch(MySqlException ex)
            {
                connection.Rollback();
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
            }
            catch
            {

            }
            finally
            {

            }
            return usuario;
        }

        #endregion


        /*DAO
         comando = select * from usuario;

         MySqlAdapter Da = new MySqlAdapter();
         Da.SelectCommand = comando;

        DataTable Dt = new DataTable();

        Da.Fill(Dt);

        return Dt;
         */

        /*CONTROLLER
         * 
         * Classe dal = null;
         * 
         * 
         public DataTable ExibirDadosDal()
         {
            try{
                
                DataTable dt = new DataTable();
                dal = new ClasseDAL();

                DataT = dal.ExibirDados();

                return DataT;
            }
            catch(Exception erro)
            {
                throw erro;
            }
         }
         */


        /* View que estará chamando a controller
         * 
         * exibir dados
         * 
         * ClasseBLL bll = new ClasseBLL();
         * 
         * try{
         *      dataGridView.DataSource = bll.ExibirDadosDal();
         * }
         * 
         */
        
    }
}
