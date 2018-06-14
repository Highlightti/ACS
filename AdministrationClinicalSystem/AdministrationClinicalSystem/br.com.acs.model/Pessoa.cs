using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationClinicalSystem.br.com.acs.model
{
    class Pessoa
    {
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public DocumentoPF documentoPF { get; set; }
        public DocumentoPJ documentoPJ { get; set; }

        public Pessoa() { }
    }
}
