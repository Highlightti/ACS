using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationClinicalSystem.br.com.acs.model
{
    class Fornecedor
    {
        public int idFornecedor { get; set; }
        public string razaoSocial { get; set; }
        public DocumentoPJ documentoPJ { get; set; }
        public Endereco endereco { get; set; }
        public Contato contato { get; set; }
    }
}
