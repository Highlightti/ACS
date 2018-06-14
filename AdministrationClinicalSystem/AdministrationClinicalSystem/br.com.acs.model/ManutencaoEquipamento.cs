using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationClinicalSystem.br.com.acs.model
{
    class ManutencaoEquipamento
    {
        public int idManutencao { get; set; }
        public Equipamento equipamento { get; set; }
        public DateTime dataProblema { get; set; }
        public DateTime dataEnvio { get; set; }
        public DateTime dataRecebimento { get; set; }
        public string descricaoProblema { get; set; }
        public bool finalizarManutencao { get; set; }
    }
}
