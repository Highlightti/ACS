using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationClinicalSystem.br.com.acs.model
{
    public class Contato
    {
        public int idContato { get; set; }
        public int tipoContato { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string site { get; set; }

        public Contato() { }
    }
}
