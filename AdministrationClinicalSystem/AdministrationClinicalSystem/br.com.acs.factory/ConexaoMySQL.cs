using AdministrationClinicalSystem.br.com.acs.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AdministrationClinicalSystem.br.com.acs.factory
{
    class ConexaoMySQL : MetroFramework.Forms.MetroForm, ConexaoDB
    {
        private MySqlConnection connection = null;
        private MySqlTransaction transaction;

        #region Instâncias (Singleton Pattern).

        SystemExceptionsMessages systemExMessages = SystemExceptionsMessages.getInstance();

        #endregion

        public ConexaoMySQL()
        {
            try
            {
                string urlConexaoMySQL = "server=highlightti.com.br; port=3306; userid=highligh_devhml; database=highligh_ACS_Homologacao; password=bdhml@18";

                this.connection = new MySqlConnection(urlConexaoMySQL);
                this.connection.Open();
            }
            catch
            {
                //deixar a menssagem explicita para desenvolvedores;
                MetroFramework.MetroMessageBox.Show(this, systemExMessages.ERRO_CONEXÃO_BANCO, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            
        }

        public MySqlConnection GetConnection()
        {
            return this.connection;
        }

        public void Close()
        {
            if (this.connection != null)
            {
                try
                {
                    this.connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro de comunicação com o Banco de Dados." + ex);
                    //Logger.getLogger(ConexaoMySQL.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        }

        public void Commit()
        {
            transaction.Commit();
            this.Close();
        }

        public void Rollback()
        {
            if (this.connection != null)
            {
                try
                {
                    this.transaction.Rollback();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro de comunicação com o Banco de Dados." + ex);
                    //Logger.getLogger(ConexaoPostgreJDBC.class.getName()).log(Level.SEVERE, null, ex);
                }
                finally
                {
                    this.Close();
                }
            }
        }
    }
}
