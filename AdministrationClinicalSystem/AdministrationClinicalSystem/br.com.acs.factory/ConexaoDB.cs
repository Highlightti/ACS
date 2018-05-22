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
        MySqlConnection getConnection();
        
        void close();

        void commit();

        void rollback();
    }
}
