using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrationClinicalSystem.br.com.acs.view
{
    public partial class ACSEquipamentos : Form
    {
        public ACSEquipamentos()
        {
            InitializeComponent();
        }

        bool opcoesAvancadasClick = false;

        private void BtnOpcoesAvancadas_Click(object sender, EventArgs e)
        {
            if (opcoesAvancadasClick == false)
            {
                opcoesAvancadasClick = true;
                opcoesAvancadasEquipamentos.Visible = true;

                while (opcoesAvancadasEquipamentos.Width <= 160)
                {
                    opcoesAvancadasEquipamentos.Width += 4;
                }

                BtnOpcoesAvancadas.Text = "Fechar";
            }
            else
            {
                opcoesAvancadasClick = false;

                while (opcoesAvancadasEquipamentos.Width > 10)
                {
                    opcoesAvancadasEquipamentos.Width -= 4;
                }

                opcoesAvancadasEquipamentos.Visible = false;

                BtnOpcoesAvancadas.Text = "Opções Avançadas";
            }
        }

        private void BtnDetalhesEquipamento_Click(object sender, EventArgs e)
        {
            //adicionar verificação para não permitir abrir mais de uma tela.
            ACSWindowEquipamentos acswEquipamento = new ACSWindowEquipamentos();
            acswEquipamento.Show();
        }

        private void BtnCalibrarEquipamento_Click(object sender, EventArgs e)
        {
            //adicionar verificação para não permitir abrir mais de uma tela.
            ACSWindowEquipamentosCalibracoes acswEquipamentoCalibracao = new ACSWindowEquipamentosCalibracoes();
            acswEquipamentoCalibracao.Show();
        }

        private void BtnDetalheCalibracao_Click(object sender, EventArgs e)
        {
            //adicionar verificação para não permitir abrir mais de uma tela.
            ACSWindowEquipamentosCalibracoesUpdate acswEquipamentoCalibracaoUpdate = new ACSWindowEquipamentosCalibracoesUpdate();
            acswEquipamentoCalibracaoUpdate.Show();
        }

        private void BtnManutencaoPreventiva_Click(object sender, EventArgs e)
        {
            //adicionar verificação para não permitir abrir mais de uma tela.
            ACSWindowEquipamentosPreventivas acswEquipamentoPreventiva = new ACSWindowEquipamentosPreventivas();
            acswEquipamentoPreventiva.Show();
        }

        private void BtnDetalhePreventivas_Click(object sender, EventArgs e)
        {
            //adicionar verificação para não permitir abrir mais de uma tela.
            ACSWindowEquipamentosPreventivasUpdate acswEquipamentoPreventivaUpdate = new ACSWindowEquipamentosPreventivasUpdate();
            acswEquipamentoPreventivaUpdate.Show();
        }

        private void BtnManutencaoCorretiva_Click(object sender, EventArgs e)
        {
            //adicionar verificação para não permitir abrir mais de uma tela.
            ACSWindowEquipamentosCorretivas acswEquipamentoCorretiva = new ACSWindowEquipamentosCorretivas();
            acswEquipamentoCorretiva.Show();
        }

        private void BtnDetalheCorretivas_Click(object sender, EventArgs e)
        {
            //adicionar verificação para não permitir abrir mais de uma tela.
            ACSWindowEquipamentosCorretivasUpdate acswEquipamentoCorretivasUpdate = new ACSWindowEquipamentosCorretivasUpdate();
            acswEquipamentoCorretivasUpdate.Show();
        }


        bool novaFinalidade = false; 

        private void BtnNovaFinalidade_Click(object sender, EventArgs e)
        {
            if(novaFinalidade == false)
            {
                novaFinalidade = true;

                panelNovaFinalidade.Visible = true;

                BtnNovaFinalidade.Text = "Fechar";
            }
            else
            {
                novaFinalidade = false;

                panelNovaFinalidade.Visible = false;

                BtnNovaFinalidade.Text = "Nova Finalidade";
            } 
        }

        private void BtnDetalhesFinalidade_Click(object sender, EventArgs e)
        {
            //adicionar verificação para não permitir abrir mais de uma tela.
            ACSWindowEquipamentosFinalidades acswfinalidades = new ACSWindowEquipamentosFinalidades();
            acswfinalidades.Show();
        }
    }
}
