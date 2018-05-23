using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AdministrationClinicalSystem.br.com.acs.factory
{
    interface ConexaoDB
    {
        MySqlConnection GetConnection();
        
        void Close();

        void Commit();

        void Rollback();
    }
}
