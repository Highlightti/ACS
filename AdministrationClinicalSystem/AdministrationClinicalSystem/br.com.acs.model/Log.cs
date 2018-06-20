using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationClinicalSystem.br.com.acs.model
{
    class Log
    {
        public int idLog { get; set; }
        public int idUsuario { get; set; }
        public string nomeTabela { get; set; }
        public string tipoAcao { get; set; }
        public int idRegistro { get; set; }
        public DateTime dataAcao { get; set; }

        public Log() { }
    }
}
