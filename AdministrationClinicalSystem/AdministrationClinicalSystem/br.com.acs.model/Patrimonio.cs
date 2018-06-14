using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationClinicalSystem.br.com.acs.model
{
    class Patrimonio
    {
        public int idPatrimonio { get; set; }
        public int numeroPatrimonio { get; set; }
        public string nomePatrimonio { get; set; }
        public int numeroSerie { get; set; }
        public DateTime dataCompra { get; set; }
        public string vidaUtil { get; set; }
        public int numeroNotaFiscal { get; set; }
        public string fornecedor { get; set; }
        public string local { get; set; }
        public double valor { get; set; }
        public string observacao { get; set; }

        public Patrimonio() { }


    }
}
