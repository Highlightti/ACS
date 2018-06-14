using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationClinicalSystem.br.com.acs.model
{
    class Equipamento
    {
        public int idEquipamento;
        public string nome;
        public int numeroSerie;
        public string patrimonio;
        public string modelo;
        public string finalidade;
        public string localizacaoNaClinica;
        public DateTime dataManutencaoPreventiva;
        public DateTime dataPeriodicidadeManutencaoPreventiva;
        public DateTime dataCalibracao;
        public string periodicidadeCalibracao;
        public bool statusEquipamento;
        public string observacoes;

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
