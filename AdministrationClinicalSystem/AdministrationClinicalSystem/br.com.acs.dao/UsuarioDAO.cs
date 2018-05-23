using AdministrationClinicalSystem.br.com.acs.factory;
using AdministrationClinicalSystem.br.com.acs.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace AdministrationClinicalSystem.br.com.acs.dao
{
    class UsuarioDAO
    {
        #region Variáveis de Funcionamento

        private ConexaoMySQL connection;
        private static UsuarioDAO instance;
        private static MySqlCommand command;

        #endregion

        #region Querys para operações no Banco de Dados

        private static string CADASTRAR_USUARIO = "INSERT INTO usuario (usuario, nome, email, email_grupo, senha, status_usuario, data_modificacao, usuario_modificacao) VALUES (?, ?, ?, ?, ?, ?, SYSDATE(), ?)";

        #endregion

        #region Métodos de Funcionamento

        /// <summary>
        /// Construtor da classe UsuarioDAO e já estabelece a conexão com o banco de dados.
        /// </summary>
        public UsuarioDAO()
        {
            this.connection = new ConexaoMySQL();
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
        public void cadastrarUsuario(Usuario usuario)
        {
            try
            {
                command = new MySqlCommand(CADASTRAR_USUARIO);
                command.Parameters.Add("@usuario", MySqlDbType.VarChar, 25).Value = usuario.tipoUsuario;
                command.Parameters.Add("@nome", MySqlDbType.VarChar, 70).Value = usuario.nome;
                command.Parameters.Add("@email", MySqlDbType.VarChar, 70).Value = usuario.email;
                command.Parameters.Add("@email_grupo", MySqlDbType.VarChar, 70).Value = usuario.emailGrupo;
                command.Parameters.Add("@senha", MySqlDbType.VarChar, 25).Value = usuario.senha;
                command.Parameters.Add("@status_usuario", MySqlDbType.Enum).Value = usuario.statusUsuario;
                command.Parameters.Add("@usuario_modificacao", MySqlDbType.UInt32).Value = usuario.idUsuarioLogado;
                command.ExecuteNonQuery();

                connection.commit();
            }
            catch(MySqlException ex)
            {
                connection.rollback();
                MessageBox.Show("Erro de comunicação com o Banco de Dados." + ex);
            }
            finally
            {
                connection.close();
            }
        }

        public Usuario consultarUsuario(Usuario usuario)
        {
            try
            {

            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Erro de comunicação com o Banco de Dados." + ex);
            }
            finally
            {
                connection.close();
            }

            return usuario;
        }

        public void alterarUsuario(Usuario usuario)
        {
            try
            {

            }
            catch
            {

            }
            finally
            {

            }
        }

        public void alterarSenhaUsuario(Usuario usuario)
        {
            try
            {

            }
            catch
            {

            }
            finally
            {

            }
        }

        public void inativarUsuario(Usuario usuario)
        {
            try
            {

            }
            catch
            {

            }
            finally
            {

            }
        }

        #endregion
        
    }
}
