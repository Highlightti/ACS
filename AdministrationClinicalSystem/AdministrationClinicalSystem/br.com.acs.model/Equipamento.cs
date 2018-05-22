using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationClinicalSystem.br.com.acs.model
{
    class Equipamento
    {
        private int idEquipamento;
        private string nome { get; set; }
        private int numeroSerie { get; set; }
        private string patrimonio { get; set; }
        private string modelo { get; set; }
        private string finalidade { get; set; }
        private string localizacaoNaClinica { get; set; }
        private DateTime dataManutencaoPreventiva { get; set; }
        private DateTime dataPeriodicidadeManutencaoPreventiva { get; set; }
        private DateTime dataCalibracao { get; set; }
        private string periodicidadeCalibracao { get; set; }
        private bool statusEquipamento { get; set; }
        private string observacoes { get; set; }

        public Equipamento() { }

        public Equipamento(int idEquipamento, String nome, int numeroSerie, String patrimonio, string modelo, string finalidade, string localizacaoNaClinica, DateTime dataManutencaoPreventiva, DateTime dataPeriodicidadeManutencaoPreventiva, DateTime dataCalibracao, string periodicidadeCalibracao, bool statusEquipamento, string observacoes)
        {
            this.idEquipamento = idEquipamento;
            this.nome = nome;
            this.numeroSerie = numeroSerie;
            this.patrimonio = patrimonio;
            this.modelo = modelo;
            this.finalidade = finalidade;
            this.localizacaoNaClinica = localizacaoNaClinica;
            this.dataManutencaoPreventiva = dataManutencaoPreventiva;
            this.dataPeriodicidadeManutencaoPreventiva = dataPeriodicidadeManutencaoPreventiva;
            this.dataCalibracao = dataCalibracao;
            this.periodicidadeCalibracao = periodicidadeCalibracao;
            this.statusEquipamento = statusEquipamento;
            this.observacoes = observacoes;
        }

        public int IdEquipamento
        {
            get { return idEquipamento; }
            set { idEquipamento = value; }
        }

    }
}
