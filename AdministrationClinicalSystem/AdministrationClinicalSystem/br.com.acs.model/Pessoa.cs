using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationClinicalSystem.br.com.acs.model
{
    public class Pessoa
    {
        public int idPessoa { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public DateTime dataNascimento { get; set; }
        public string estadoCivil { get; set; }
        public string sexo { get; set; }
        public DocumentoPF documentoPF { get; set; }
        public Endereco endereco { get; set; }
        public Contato contato { get; set; }

        public Pessoa() { }
    }
}
