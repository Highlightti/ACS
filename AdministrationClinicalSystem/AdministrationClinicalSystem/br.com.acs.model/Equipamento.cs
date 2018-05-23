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
        private string nome;
        private int numeroSerie;
        private string patrimonio;
        private string modelo;
        private string finalidade;
        private string localizacaoNaClinica;
        private DateTime dataManutencaoPreventiva;
        private DateTime dataPeriodicidadeManutencaoPreventiva;
        private DateTime dataCalibracao;
        private string periodicidadeCalibracao;
        private bool statusEquipamento;
        private string observacoes;

        public Equipamento() { }

        public Equipamento(int idEquipamento, string nome, int numeroSerie, string patrimonio, string modelo, string finalidade, string localizacaoNaClinica, DateTime dataManutencaoPreventiva, DateTime dataPeriodicidadeManutencaoPreventiva, DateTime dataCalibracao, string periodicidadeCalibracao, bool statusEquipamento, string observacoes)
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

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int NumeroSerie
        {
            get { return numeroSerie; }
            set { numeroSerie = value; }
        }

        public string Patrimonio
        {
            get { return patrimonio; }
            set { patrimonio = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Finalidade
        {
            get { return finalidade; }
            set { finalidade = value; }
        }

        public string LocalizacaoNaClinica
        {
            get { return localizacaoNaClinica; }
            set { localizacaoNaClinica = value; }
        }

        public DateTime DataManutencaoPreventiva
        {
            get { return dataManutencaoPreventiva; }
            set { dataManutencaoPreventiva = value; }
        }

        public DateTime DataPeriodicidadeManutencaoPreventiva
        {
            get { return dataPeriodicidadeManutencaoPreventiva; }
            set { dataPeriodicidadeManutencaoPreventiva = value; }
        }

        public DateTime DataCalibracao
        {
            get { return dataCalibracao; }
            set { dataCalibracao = value; }
        }

        public string PeriodicidadeCalibracao
        {
            get { return periodicidadeCalibracao; }
            set { periodicidadeCalibracao = value; }
        }

        public bool StatusEquipamento
        {
            get { return statusEquipamento; }
            set { statusEquipamento = value; }
        }

        public string Observacoes
        {
            get { return observacoes; }
            set { observacoes = value; }
        }
    }
}
