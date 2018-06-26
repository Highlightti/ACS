using AdministrationClinicalSystem.br.com.acs.controller;
using AdministrationClinicalSystem.br.com.acs.factory;
using AdministrationClinicalSystem.br.com.acs.model;
using AdministrationClinicalSystem.br.com.acs.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrationClinicalSystem
{
    public partial class ACSMainPanel : MetroFramework.Forms.MetroForm
    {
        public ACSMainPanel()
        {
            InitializeComponent();
            
            this.StyleManager = metroStyleManagerMain;

            // Caso o evento tenha ocorrido, termine toda a aplicação.
            this.Closed += (s, ev) => Application.Exit();
        }

        private void ACSMainPanel_Load(object sender, EventArgs e)
        {
            // Estilizando as cores da janela.
            this.StyleManager = metroStyleManagerMain;
            metroStyleManagerMain.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManagerMain.Style = MetroFramework.MetroColorStyle.Blue;

            // Iniciando a aplicação com a página Home.
            ACSHome home = new ACSHome();
            NavigationScreen(home, contentPanel);

            // Atribuindo o nome do usuário logado á sessão iniciada.
            BtnMeusDados.Text = "Olá, " + uController.usuarioSessao;
        }

        #region Instâncias (Singleton Pattern).

        UsuarioController uController = UsuarioController.getInstance();
        SystemExceptionsMessages systemExMessages = SystemExceptionsMessages.getInstance();

        #endregion

        #region Menu

        #region Menu, Sub menu Slide and Navigation Screen

        // Variáveis para fazer o controle de ações do menu e sub menu.
        bool btnMenuClick = false;
        bool btnSubMenuClick = false;



        /// <summary>
        /// Método responsável por fazer o controle de animação do menu principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            // Verifica se o menu está fechado.
            if (btnMenuClick == false)
            {
                // Se sim, deixa o menu visível e aplica o efeito de slide para apresentá-lo.
                btnMenuClick = true;
                menu.Visible = true;

                while (menu.Width <= 200)
                {
                    menu.Width += 4;
                }
            }
            else
            {
                // Se não, verifica se o sub menu está aberto.
                if(btnSubMenuClick == true)
                {
                    // E então fecha o sub menu, e em seguida fecha o menu principal.
                    btnSubMenuClick = false;
                    subMenu.Visible = false;
                    while (subMenu.Width > 12)
                    {
                        subMenu.Width -= 4;
                    }
                    

                    btnMenuClick = false;
                    menu.Visible = false;
                    while (menu.Width > 10)
                    {
                        menu.Width -= 4;
                    }
                    
                }
                else
                {
                    // Se não, se somente o menu principal está aberto, só ele será fechado.
                    btnMenuClick = false;
                    menu.Visible = false;
                    while (menu.Width > 10)
                    {
                        menu.Width -= 4;
                    }

                    
                }
            }
        }



        /// <summary>
        /// Método responsável por fazer o controle de animação do sub menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="tipoSubMenu"></param>
        private void BtnSubMenu_Click(object sender, EventArgs e, string tipoSubMenu)
        {
            // Verifica se o sub menu e o menu principal estão fechados.
            if(btnSubMenuClick == false && btnMenuClick == false)
            {
                // Se for verdadeiro, quando um menu tiver um sub menu, ele também poderá ser aberto clicando apenas no ícone.
                btnMenuClick = true;
                menu.Visible = true;

                while (menu.Width <= 200)
                {
                    menu.Width += 4;
                }

                btnSubMenuClick = true;
                subMenu.Visible = true;

                while (subMenu.Width <= 200)
                {
                    subMenu.Width += 4;
                }

                VerificaSubMenuParaAtivar(tipoSubMenu);
            }
            // Verifica se o sub menu está fechado.
            else if (btnSubMenuClick == false)
            {
                // Se sim, irá executar a ação para abrí-lo.
                btnSubMenuClick = true;
                subMenu.Visible = true;

                while (subMenu.Width <= 200)
                {
                    subMenu.Width += 4;
                }

                // E irá chamar as opções do sub menu de acordo com o menu clicado.
                VerificaSubMenuParaAtivar(tipoSubMenu);
            }
            // Verifica se o sub menu está aberto.
            else if (btnSubMenuClick == true)
            {
                // Se sim, alterna entre os sub menus de acordo com o menu principal clicado.
                VerificaSubMenuParaAtivar(tipoSubMenu);
            }
        }



        /// <summary>
        /// Método responsável por alternar entre os sub menus de acordo com o botão clicado do menu principal
        /// 
        /// Sempre que adicionar uma nova opção ao menu, e essa opção obter várias outras interna, terá de adicionar a 
        /// sua verificação abaixo, para poder ser visualizada no mecanismo de funcionamento do menu do sistema.
        /// </summary>
        /// <param name="tipoSubMenu"></param>
        public void VerificaSubMenuParaAtivar(string tipoSubMenu)
        {
            // Verifica qual sub menu está ativo, para poder desativá-lo e ativar outro.
            if (tipoSubMenu.Equals("GestaoAdministrativa"))
            {
                //Ativa o sub menu selecionado.
                subMenuGestaoAdministrativa.Visible = true;

                //Desativa os outros sub menus.
                subMenuPessoas.Visible = false;
            }
            else if (tipoSubMenu.Equals("Pessoas"))
            {
                subMenuPessoas.Visible = true;

                subMenuGestaoAdministrativa.Visible = false;
            }
        }



        /// <summary>
        /// Método responsável por realizar a verificação se o menu está ou não aberto, para poder fechá-lo.
        /// </summary>
        public void VerificarFechamentoMenu(object sender, EventArgs e)
        {
            if (btnMenuClick == true)
            {
                BtnMenu_Click(sender, e);
            }
        }



        /// <summary>
        /// Método responsável por fazer o controle de navegação de telas.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="panel"></param>
        public void NavigationScreen(Form form, Panel panel)
        {
            form.TopLevel = false;
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

        #endregion

        private void BtnMeusDados_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario = uController.VerificaConexãoBanco();

            if (usuario != null)
            {
                ACSDadosUsuario dadosUsuario = new ACSDadosUsuario();
                NavigationScreen(dadosUsuario, contentPanel);

                if (btnMenuClick == true)
                {
                    BtnMenu_Click(sender, e);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, systemExMessages.ERRO_CONEXÃO_BANCO, "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ACSHome home = new ACSHome();
            NavigationScreen(home, contentPanel);

            VerificarFechamentoMenu(sender, e);
        }

        #region Menu e Sub menu Gestão Administrativa

        private void BtnGestaoAdministrativa_Click(object sender, EventArgs e)
        {
            //Esse botão possui um sub menu, portanto tenho que ativá-lo.
            string subMenu = "GestaoAdministrativa";
            BtnSubMenu_Click(sender, e, subMenu);
        }

        private void SubBtnLocalidades_Click(object sender, EventArgs e)
        {
            ACSLocalidades locais = new ACSLocalidades();
            NavigationScreen(locais, contentPanel);

            VerificarFechamentoMenu(sender, e);
        }

        private void SubBtnFornecedores_Click(object sender, EventArgs e)
        {
            ACSFornecedor fornecedor = new ACSFornecedor();
            NavigationScreen(fornecedor, contentPanel);

            VerificarFechamentoMenu(sender, e);
        }

        private void SubBtnPatrimonio_Click(object sender, EventArgs e)
        {
            ACSPatrimonio patrimonio = new ACSPatrimonio();
            NavigationScreen(patrimonio, contentPanel);

            VerificarFechamentoMenu(sender, e);
        }

        private void SubBtnEquipamentos_Click(object sender, EventArgs e)
        {
            ACSEquipamentos equipamentos = new ACSEquipamentos();
            NavigationScreen(equipamentos, contentPanel);

            VerificarFechamentoMenu(sender, e);
        }

        #endregion



        private void SubBtnGestãoPessoas_Click(object sender, EventArgs e)
        {
            ACSPessoas pessoas = new ACSPessoas();
            NavigationScreen(pessoas, contentPanel);

            VerificarFechamentoMenu(sender, e);
        }



        private void BtnPessoas_Click(object sender, EventArgs e)
        {
            //Esse botão possui um sub menu, portanto tenho que ativá-lo.
            string subMenu = "Pessoas";
            BtnSubMenu_Click(sender, e, subMenu);
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario = uController.VerificaConexãoBanco();

            if (usuario != null)
            {
                ACSDadosUsuarioAdministrador dadosUsuarioAdministrador = new ACSDadosUsuarioAdministrador();
                NavigationScreen(dadosUsuarioAdministrador, contentPanel);

                if (btnMenuClick == true)
                {
                    BtnMenu_Click(sender, e);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, systemExMessages.ERRO_CONEXÃO_BANCO, "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Yes/No", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Usuario usuario = new Usuario();
                usuario = uController.LogoutUsuario();

                if (usuario.usuarioException == null)
                {
                    uController.idUsuarioSessao = 0;

                    this.Hide();
                    ACSLogin acsLogin = new ACSLogin();
                    acsLogin.Show();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, systemExMessages.MESSAGE_ERRO_LOGOUT, systemExMessages.TITLE_ERRO_LOGOUT, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }


        #endregion

        
    }
}
