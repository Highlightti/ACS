using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationClinicalSystem.br.com.acs.model
{
    class ManutencaoEquipamento
    {
        private int idManutencao { get; set; }
        private Equipamento equipamento { get; set; }
        private DateTime dataProblema { get; set; }
        private DateTime dataEnvio { get; set; }
        private DateTime dataRecebimento { get; set; }
        private string descricaoProblema { get; set; }
        private bool finalizarManutencao { get; set; }
    }
}
