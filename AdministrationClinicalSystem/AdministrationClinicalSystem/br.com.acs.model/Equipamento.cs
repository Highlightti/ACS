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
