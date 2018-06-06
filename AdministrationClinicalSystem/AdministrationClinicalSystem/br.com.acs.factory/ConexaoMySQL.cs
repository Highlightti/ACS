using AdministrationClinicalSystem.br.com.acs.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AdministrationClinicalSystem.br.com.acs.factory
{
    class ConexaoMySQL : ConexaoDB
    {
        private MySqlConnection connection = null;

        #region Instâncias (Singleton Pattern).

        SystemExceptionsMessages systemExMessages = SystemExceptionsMessages.getInstance();

        #endregion

        public ConexaoMySQL() { }

        public MySqlConnection GetConnection()
        {
            try
            {
                string urlConexaoMySQL = "server=highlightti.com.br; port=3306; userid=highligh_devhml; database=highligh_ACS_Homologacao; password=bdhml@18";

                this.connection = new MySqlConnection(urlConexaoMySQL);
                this.connection.Open();
            }
            catch(MySqlException mySqlEx)
            {
                this.connection = null;
                throw (mySqlEx);
            }

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
                    throw (ex);
                }
            }
        }
    }
}
