using AdministrationClinicalSystem.br.com.acs.factory;
using AdministrationClinicalSystem.br.com.acs.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using AdministrationClinicalSystem.br.com.acs.controller;

namespace AdministrationClinicalSystem.br.com.acs.dao
{
    class PessoaDAO
    {
        private static PessoaDAO instance;
        private static ConexaoMySQL connection;
        private static MySqlCommand command;
        private static MySqlTransaction transaction;

        #region Singleton Pattern DAO

        /// <summary>
        ///  Método responsável por criar uma instância da classe PessoaDAO (Singleton Pattern).
        /// </summary>
        public static PessoaDAO getInstance()
        {
            if (instance == null)
            {
                instance = new PessoaDAO();
            }
            return instance;
        }

        #endregion

        #region Instâncias (Singleton Pattern)

        UsuarioController usuarioController = UsuarioController.getInstance();

        #endregion

        private static string CADASTRAR_ENDERECO = "INSERT INTO endereco (cep, logradouro, numero, complemento, bairro, pais, estado, cidade, data_cadastro, usuario_cadastro) VALUES (?, ?, ?, ?, ?, ?, ?, ?, SYSDATE(), ?)";
        private static string CADASTRAR_CONTATO = "INSERT INTO contato (telefone, celular, email, data_cadastro, usuario_cadastro) VALUES (?, ?, ?, SYSDATE(), ?)";
        private static string CADASTRAR_PESSOA = "INSERT INTO pessoa (nome, sobrenome, estado_civil, sexo, data_nascimento, rg, cpf, endereco, contato, data_cadastro, usuario_cadastro) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, SYSDATE(), ?)";
        private static string CONSULTAR_PESSOAS = "SELECT pessoa.id_pessoa, pessoa.nome, pessoa.sobrenome, pessoa.estado_civil, pessoa.sexo, pessoa.datanascimento, pessoa.rg, pessoa.cpf, endereco.id_endereco, endereco.cep, endereco.logradouro, endereco.numero, endereco.complemento, endereco.bairro, endereco.cidade, endereco.estado, contato.id_contato, contato.telefone, contato.celular, contato.email FROM pessoa JOIN endereco ON pessoa.endereco = endereco.id_endereco JOIN contato ON pessoa.contato = contato.id_contato  ORDER BY pessoa.nome ASC LIMIT 50";



        //SELECT usuario.id_usuario, usuario.nome, nivel_acesso.nome_perfil FROM usuario JOIN usuario_acesso ON usuario.id_usuario= usuario_acesso.id_usuario JOIN nivel_acesso ON nivel_acesso.id_nivel_acesso= usuario_acesso.id_nivel_acesso WHERE usuario = ? AND senha = MD5(?)"



        /*
         * limitar a consulta a 50 pessoas
         * fazer um count de pessoas e retornar esse valor
         */


        /// <summary>
        /// Método responsável por cadastrar os dados de pessoa no Banco de Dados.
        /// </summary>
        /// <param name="pessoa"></param>
        /// <returns>Pessoa</returns>
        public Pessoa CadastrarPessoa(Pessoa pessoa)
        {
            long idEndereco, idContato = 0;
            int idUsuarioSessao = usuarioController.idUsuarioSessao;

            try
            {
                command = new MySqlCommand(CADASTRAR_ENDERECO, connection.GetConnection());
                command.Parameters.AddWithValue("?cep", pessoa.endereco.cep);
                command.Parameters.AddWithValue("?logradouro", pessoa.endereco.logradouro);
                command.Parameters.AddWithValue("?numero", pessoa.endereco.numero);
                command.Parameters.AddWithValue("?complemento", pessoa.endereco.complemento);
                command.Parameters.AddWithValue("?bairro", pessoa.endereco.bairro);
                command.Parameters.AddWithValue("?pais", pessoa.endereco.pais);
                command.Parameters.AddWithValue("?estado", pessoa.endereco.estado);
                command.Parameters.AddWithValue("?cidade", pessoa.endereco.cidade);
                command.Parameters.AddWithValue("?usuario_cadastro", idUsuarioSessao);

                try
                {
                    transaction = command.Connection.BeginTransaction();

                    command.CommandText = "SET autocommit = 0";
                    command.ExecuteNonQuery();

                    idEndereco = command.LastInsertedId;

                    command.Parameters.Clear();

                    command = new MySqlCommand(CADASTRAR_CONTATO, connection.GetConnection());
                    command.Parameters.AddWithValue("?telefone", pessoa.contato.telefone);
                    command.Parameters.AddWithValue("?celular", pessoa.contato.celular);
                    command.Parameters.AddWithValue("?email", pessoa.contato.email);
                    command.Parameters.AddWithValue("?usuario_cadastro", idUsuarioSessao);

                    try
                    {
                        transaction = command.Connection.BeginTransaction();

                        command.CommandText = "SET autocommit = 0";
                        command.ExecuteNonQuery();

                        idContato = command.LastInsertedId;

                        command.Parameters.Clear();

                        command = new MySqlCommand(CADASTRAR_PESSOA, connection.GetConnection());
                        command.Parameters.AddWithValue("?nome", pessoa.nome);
                        command.Parameters.AddWithValue("?sobrenome", pessoa.sobrenome);
                        command.Parameters.AddWithValue("?estado_civil", pessoa.estadoCivil);
                        command.Parameters.AddWithValue("?sexo", pessoa.sexo);
                        command.Parameters.AddWithValue("?data_nascimento", pessoa.dataNascimento);
                        command.Parameters.AddWithValue("?rg", pessoa.documentoPF.registroGeral);
                        command.Parameters.AddWithValue("?cpf", pessoa.documentoPF.cadastroPessoaFisica);
                        command.Parameters.AddWithValue("?endereco", idEndereco);
                        command.Parameters.AddWithValue("?contato", idContato);
                        command.Parameters.AddWithValue("?usuario_cadastro", idUsuarioSessao);

                        try
                        {
                            transaction = command.Connection.BeginTransaction();

                            command.CommandText = "SET autocommit = 0";
                            command.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            transaction.Rollback();
                            pessoa = null;
                            Trace.TraceError(ex.ToString());
                        }
                    }
                    catch (MySqlException ex)
                    {
                        transaction.Rollback();
                        pessoa = null;
                        Trace.TraceError(ex.ToString());
                    }
                }
                catch (MySqlException ex)
                {
                    transaction.Rollback();
                    pessoa = null;
                    Trace.TraceError(ex.ToString());
                }
                
                transaction.Commit();
            }
            catch (MySqlException ex)
            {
                transaction.Rollback();
                pessoa = null;
                Trace.TraceError(ex.ToString());
            }
            finally
            {
                command.Parameters.Clear();
                connection.Close();
            }

            return pessoa;
        }



        /// <summary>
        /// Método responsável por retornar os dados de pessoas cadastradas no Banco de Dados.
        /// </summary>
        /// <returns>List<Pessoa></returns>
        public List<Pessoa> ListarPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            try
            {
                command = new MySqlCommand(CONSULTAR_PESSOAS, connection.GetConnection());
            }
            catch
            {

            }
            finally
            {

            }

            return pessoas;
        }

    }
}
