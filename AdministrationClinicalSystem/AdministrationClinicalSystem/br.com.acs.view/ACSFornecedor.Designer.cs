namespace AdministrationClinicalSystem.br.com.acs.view
{
    partial class ACSFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.leftSidePanel = new System.Windows.Forms.Panel();
            this.MainTabsFornecedor = new MetroFramework.Controls.MetroTabControl();
            this.TabCadastrarPessoa = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSite = new MetroFramework.Controls.MetroLabel();
            this.txtSite = new MetroFramework.Controls.MetroTextBox();
            this.labelEmail = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.labelCelular = new MetroFramework.Controls.MetroLabel();
            this.txtCelular = new MetroFramework.Controls.MetroTextBox();
            this.txtTelefone = new MetroFramework.Controls.MetroTextBox();
            this.BtnCadastrarFornecedor = new System.Windows.Forms.Button();
            this.labelTelefone = new MetroFramework.Controls.MetroLabel();
            this.labelCNPJ = new MetroFramework.Controls.MetroLabel();
            this.labelRazaoSocial = new MetroFramework.Controls.MetroLabel();
            this.txtRazaoSocial = new MetroFramework.Controls.MetroTextBox();
            this.txtCNPJ = new MetroFramework.Controls.MetroTextBox();
            this.TabConsultarPessoas = new MetroFramework.Controls.MetroTabPage();
            this.ListPessoasPanel = new System.Windows.Forms.Panel();
            this.ListaFornecedores = new MetroFramework.Controls.MetroGrid();
            this.RazaoSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.BottomOptionsPanel = new System.Windows.Forms.Panel();
            this.BtnDetalhesFornecedor = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.MainTabsFornecedor.SuspendLayout();
            this.TabCadastrarPessoa.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TabConsultarPessoas.SuspendLayout();
            this.ListPessoasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaFornecedores)).BeginInit();
            this.panel1.SuspendLayout();
            this.BottomOptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.metroLabel1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(10, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(955, 35);
            this.topPanel.TabIndex = 51;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel1.Location = new System.Drawing.Point(6, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(126, 25);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Fornecedores";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // leftSidePanel
            // 
            this.leftSidePanel.BackColor = System.Drawing.Color.Transparent;
            this.leftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftSidePanel.Location = new System.Drawing.Point(0, 0);
            this.leftSidePanel.Name = "leftSidePanel";
            this.leftSidePanel.Size = new System.Drawing.Size(10, 582);
            this.leftSidePanel.TabIndex = 50;
            // 
            // MainTabsFornecedor
            // 
            this.MainTabsFornecedor.Controls.Add(this.TabCadastrarPessoa);
            this.MainTabsFornecedor.Controls.Add(this.TabConsultarPessoas);
            this.MainTabsFornecedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabsFornecedor.Location = new System.Drawing.Point(10, 35);
            this.MainTabsFornecedor.Name = "MainTabsFornecedor";
            this.MainTabsFornecedor.SelectedIndex = 0;
            this.MainTabsFornecedor.Size = new System.Drawing.Size(955, 547);
            this.MainTabsFornecedor.TabIndex = 52;
            this.MainTabsFornecedor.UseSelectable = true;
            // 
            // TabCadastrarPessoa
            // 
            this.TabCadastrarPessoa.AutoScroll = true;
            this.TabCadastrarPessoa.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.TabCadastrarPessoa.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.TabCadastrarPessoa.Controls.Add(this.metroLabel25);
            this.TabCadastrarPessoa.Controls.Add(this.panel2);
            this.TabCadastrarPessoa.HorizontalScrollbar = true;
            this.TabCadastrarPessoa.HorizontalScrollbarBarColor = false;
            this.TabCadastrarPessoa.HorizontalScrollbarHighlightOnWheel = false;
            this.TabCadastrarPessoa.HorizontalScrollbarSize = 10;
            this.TabCadastrarPessoa.Location = new System.Drawing.Point(4, 38);
            this.TabCadastrarPessoa.Name = "TabCadastrarPessoa";
            this.TabCadastrarPessoa.Size = new System.Drawing.Size(947, 505);
            this.TabCadastrarPessoa.TabIndex = 0;
            this.TabCadastrarPessoa.Text = "     Cadastrar     ";
            this.TabCadastrarPessoa.VerticalScrollbar = true;
            this.TabCadastrarPessoa.VerticalScrollbarBarColor = true;
            this.TabCadastrarPessoa.VerticalScrollbarHighlightOnWheel = true;
            this.TabCadastrarPessoa.VerticalScrollbarSize = 10;
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel25.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabel25.Location = new System.Drawing.Point(38, 6);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(193, 25);
            this.metroLabel25.TabIndex = 14;
            this.metroLabel25.Text = "Dados do Fornecedor";
            this.metroLabel25.UseCustomForeColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.labelSite);
            this.panel2.Controls.Add(this.txtSite);
            this.panel2.Controls.Add(this.labelEmail);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.labelCelular);
            this.panel2.Controls.Add(this.txtCelular);
            this.panel2.Controls.Add(this.txtTelefone);
            this.panel2.Controls.Add(this.BtnCadastrarFornecedor);
            this.panel2.Controls.Add(this.labelTelefone);
            this.panel2.Controls.Add(this.labelCNPJ);
            this.panel2.Controls.Add(this.labelRazaoSocial);
            this.panel2.Controls.Add(this.txtRazaoSocial);
            this.panel2.Controls.Add(this.txtCNPJ);
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 489);
            this.panel2.TabIndex = 13;
            // 
            // labelSite
            // 
            this.labelSite.AutoSize = true;
            this.labelSite.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelSite.Location = new System.Drawing.Point(43, 325);
            this.labelSite.Name = "labelSite";
            this.labelSite.Size = new System.Drawing.Size(25, 15);
            this.labelSite.TabIndex = 61;
            this.labelSite.Text = "Site";
            // 
            // txtSite
            // 
            // 
            // 
            // 
            this.txtSite.CustomButton.Image = null;
            this.txtSite.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtSite.CustomButton.Name = "";
            this.txtSite.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSite.CustomButton.TabIndex = 1;
            this.txtSite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSite.CustomButton.UseSelectable = true;
            this.txtSite.CustomButton.Visible = false;
            this.txtSite.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSite.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSite.Lines = new string[0];
            this.txtSite.Location = new System.Drawing.Point(41, 341);
            this.txtSite.MaxLength = 32767;
            this.txtSite.Name = "txtSite";
            this.txtSite.PasswordChar = '\0';
            this.txtSite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSite.SelectedText = "";
            this.txtSite.SelectionLength = 0;
            this.txtSite.SelectionStart = 0;
            this.txtSite.ShortcutsEnabled = true;
            this.txtSite.Size = new System.Drawing.Size(258, 23);
            this.txtSite.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSite.TabIndex = 60;
            this.txtSite.UseCustomForeColor = true;
            this.txtSite.UseSelectable = true;
            this.txtSite.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSite.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelEmail.Location = new System.Drawing.Point(41, 265);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 15);
            this.labelEmail.TabIndex = 59;
            this.labelEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(39, 281);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(258, 23);
            this.txtEmail.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.TabIndex = 58;
            this.txtEmail.UseCustomForeColor = true;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelCelular.Location = new System.Drawing.Point(39, 205);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(40, 15);
            this.labelCelular.TabIndex = 49;
            this.labelCelular.Text = "Celular";
            // 
            // txtCelular
            // 
            // 
            // 
            // 
            this.txtCelular.CustomButton.Image = null;
            this.txtCelular.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtCelular.CustomButton.Name = "";
            this.txtCelular.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCelular.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCelular.CustomButton.TabIndex = 1;
            this.txtCelular.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCelular.CustomButton.UseSelectable = true;
            this.txtCelular.CustomButton.Visible = false;
            this.txtCelular.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCelular.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCelular.Lines = new string[0];
            this.txtCelular.Location = new System.Drawing.Point(37, 221);
            this.txtCelular.MaxLength = 32767;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.PasswordChar = '\0';
            this.txtCelular.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCelular.SelectedText = "";
            this.txtCelular.SelectionLength = 0;
            this.txtCelular.SelectionStart = 0;
            this.txtCelular.ShortcutsEnabled = true;
            this.txtCelular.Size = new System.Drawing.Size(258, 23);
            this.txtCelular.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCelular.TabIndex = 48;
            this.txtCelular.UseCustomForeColor = true;
            this.txtCelular.UseSelectable = true;
            this.txtCelular.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCelular.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTelefone
            // 
            // 
            // 
            // 
            this.txtTelefone.CustomButton.Image = null;
            this.txtTelefone.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtTelefone.CustomButton.Name = "";
            this.txtTelefone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelefone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefone.CustomButton.TabIndex = 1;
            this.txtTelefone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefone.CustomButton.UseSelectable = true;
            this.txtTelefone.CustomButton.Visible = false;
            this.txtTelefone.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTelefone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTelefone.Lines = new string[0];
            this.txtTelefone.Location = new System.Drawing.Point(37, 161);
            this.txtTelefone.MaxLength = 32767;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.SelectionLength = 0;
            this.txtTelefone.SelectionStart = 0;
            this.txtTelefone.ShortcutsEnabled = true;
            this.txtTelefone.Size = new System.Drawing.Size(258, 23);
            this.txtTelefone.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefone.TabIndex = 45;
            this.txtTelefone.UseCustomForeColor = true;
            this.txtTelefone.UseSelectable = true;
            this.txtTelefone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnCadastrarFornecedor
            // 
            this.BtnCadastrarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(181)))));
            this.BtnCadastrarFornecedor.FlatAppearance.BorderSize = 0;
            this.BtnCadastrarFornecedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnCadastrarFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnCadastrarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastrarFornecedor.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.BtnCadastrarFornecedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCadastrarFornecedor.Location = new System.Drawing.Point(91, 412);
            this.BtnCadastrarFornecedor.Name = "BtnCadastrarFornecedor";
            this.BtnCadastrarFornecedor.Size = new System.Drawing.Size(150, 35);
            this.BtnCadastrarFornecedor.TabIndex = 44;
            this.BtnCadastrarFornecedor.Text = "Cadastrar";
            this.BtnCadastrarFornecedor.UseVisualStyleBackColor = false;
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelTelefone.Location = new System.Drawing.Point(39, 145);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(47, 15);
            this.labelTelefone.TabIndex = 23;
            this.labelTelefone.Text = "Telefone";
            // 
            // labelCNPJ
            // 
            this.labelCNPJ.AutoSize = true;
            this.labelCNPJ.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelCNPJ.Location = new System.Drawing.Point(39, 85);
            this.labelCNPJ.Name = "labelCNPJ";
            this.labelCNPJ.Size = new System.Drawing.Size(33, 15);
            this.labelCNPJ.TabIndex = 22;
            this.labelCNPJ.Text = "CNPJ";
            // 
            // labelRazaoSocial
            // 
            this.labelRazaoSocial.AutoSize = true;
            this.labelRazaoSocial.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelRazaoSocial.Location = new System.Drawing.Point(39, 25);
            this.labelRazaoSocial.Name = "labelRazaoSocial";
            this.labelRazaoSocial.Size = new System.Drawing.Size(69, 15);
            this.labelRazaoSocial.TabIndex = 14;
            this.labelRazaoSocial.Text = "Razão social";
            // 
            // txtRazaoSocial
            // 
            // 
            // 
            // 
            this.txtRazaoSocial.CustomButton.Image = null;
            this.txtRazaoSocial.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtRazaoSocial.CustomButton.Name = "";
            this.txtRazaoSocial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRazaoSocial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRazaoSocial.CustomButton.TabIndex = 1;
            this.txtRazaoSocial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRazaoSocial.CustomButton.UseSelectable = true;
            this.txtRazaoSocial.CustomButton.Visible = false;
            this.txtRazaoSocial.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRazaoSocial.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRazaoSocial.Lines = new string[0];
            this.txtRazaoSocial.Location = new System.Drawing.Point(37, 41);
            this.txtRazaoSocial.MaxLength = 32767;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.PasswordChar = '\0';
            this.txtRazaoSocial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRazaoSocial.SelectedText = "";
            this.txtRazaoSocial.SelectionLength = 0;
            this.txtRazaoSocial.SelectionStart = 0;
            this.txtRazaoSocial.ShortcutsEnabled = true;
            this.txtRazaoSocial.Size = new System.Drawing.Size(258, 23);
            this.txtRazaoSocial.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRazaoSocial.TabIndex = 0;
            this.txtRazaoSocial.UseCustomForeColor = true;
            this.txtRazaoSocial.UseSelectable = true;
            this.txtRazaoSocial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRazaoSocial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCNPJ
            // 
            // 
            // 
            // 
            this.txtCNPJ.CustomButton.Image = null;
            this.txtCNPJ.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtCNPJ.CustomButton.Name = "";
            this.txtCNPJ.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCNPJ.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCNPJ.CustomButton.TabIndex = 1;
            this.txtCNPJ.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCNPJ.CustomButton.UseSelectable = true;
            this.txtCNPJ.CustomButton.Visible = false;
            this.txtCNPJ.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCNPJ.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtCNPJ.Lines = new string[0];
            this.txtCNPJ.Location = new System.Drawing.Point(37, 101);
            this.txtCNPJ.MaxLength = 32767;
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.PasswordChar = '\0';
            this.txtCNPJ.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCNPJ.SelectedText = "";
            this.txtCNPJ.SelectionLength = 0;
            this.txtCNPJ.SelectionStart = 0;
            this.txtCNPJ.ShortcutsEnabled = true;
            this.txtCNPJ.Size = new System.Drawing.Size(258, 23);
            this.txtCNPJ.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCNPJ.TabIndex = 1;
            this.txtCNPJ.UseCustomForeColor = true;
            this.txtCNPJ.UseSelectable = true;
            this.txtCNPJ.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCNPJ.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TabConsultarPessoas
            // 
            this.TabConsultarPessoas.Controls.Add(this.ListPessoasPanel);
            this.TabConsultarPessoas.Controls.Add(this.panel1);
            this.TabConsultarPessoas.Controls.Add(this.BottomOptionsPanel);
            this.TabConsultarPessoas.HorizontalScrollbarBarColor = true;
            this.TabConsultarPessoas.HorizontalScrollbarHighlightOnWheel = false;
            this.TabConsultarPessoas.HorizontalScrollbarSize = 10;
            this.TabConsultarPessoas.Location = new System.Drawing.Point(4, 38);
            this.TabConsultarPessoas.Name = "TabConsultarPessoas";
            this.TabConsultarPessoas.Size = new System.Drawing.Size(947, 505);
            this.TabConsultarPessoas.TabIndex = 1;
            this.TabConsultarPessoas.Text = "     Consultar     ";
            this.TabConsultarPessoas.VerticalScrollbarBarColor = true;
            this.TabConsultarPessoas.VerticalScrollbarHighlightOnWheel = false;
            this.TabConsultarPessoas.VerticalScrollbarSize = 10;
            // 
            // ListPessoasPanel
            // 
            this.ListPessoasPanel.BackColor = System.Drawing.Color.Transparent;
            this.ListPessoasPanel.Controls.Add(this.ListaFornecedores);
            this.ListPessoasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPessoasPanel.Location = new System.Drawing.Point(0, 35);
            this.ListPessoasPanel.Name = "ListPessoasPanel";
            this.ListPessoasPanel.Size = new System.Drawing.Size(947, 435);
            this.ListPessoasPanel.TabIndex = 4;
            // 
            // ListaFornecedores
            // 
            this.ListaFornecedores.AllowUserToAddRows = false;
            this.ListaFornecedores.AllowUserToDeleteRows = false;
            this.ListaFornecedores.AllowUserToResizeRows = false;
            this.ListaFornecedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListaFornecedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaFornecedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ListaFornecedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaFornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListaFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaFornecedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RazaoSocial,
            this.Cnpj,
            this.Telefone,
            this.Celular,
            this.Email,
            this.Site});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaFornecedores.DefaultCellStyle = dataGridViewCellStyle5;
            this.ListaFornecedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaFornecedores.EnableHeadersVisualStyles = false;
            this.ListaFornecedores.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ListaFornecedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListaFornecedores.Location = new System.Drawing.Point(0, 0);
            this.ListaFornecedores.Name = "ListaFornecedores";
            this.ListaFornecedores.ReadOnly = true;
            this.ListaFornecedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaFornecedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ListaFornecedores.RowHeadersWidth = 10;
            this.ListaFornecedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ListaFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaFornecedores.Size = new System.Drawing.Size(947, 435);
            this.ListaFornecedores.Style = MetroFramework.MetroColorStyle.Silver;
            this.ListaFornecedores.TabIndex = 2;
            // 
            // RazaoSocial
            // 
            this.RazaoSocial.HeaderText = "Razão Social";
            this.RazaoSocial.Name = "RazaoSocial";
            this.RazaoSocial.ReadOnly = true;
            // 
            // Cnpj
            // 
            this.Cnpj.HeaderText = "CNPJ";
            this.Cnpj.Name = "Cnpj";
            this.Cnpj.ReadOnly = true;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Site
            // 
            this.Site.HeaderText = "Site";
            this.Site.Name = "Site";
            this.Site.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 35);
            this.panel1.TabIndex = 5;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabel2.Location = new System.Drawing.Point(38, 6);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(196, 25);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Lista de Fornecedores";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // BottomOptionsPanel
            // 
            this.BottomOptionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.BottomOptionsPanel.Controls.Add(this.BtnDetalhesFornecedor);
            this.BottomOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomOptionsPanel.Location = new System.Drawing.Point(0, 470);
            this.BottomOptionsPanel.Name = "BottomOptionsPanel";
            this.BottomOptionsPanel.Size = new System.Drawing.Size(947, 35);
            this.BottomOptionsPanel.TabIndex = 3;
            // 
            // BtnDetalhesFornecedor
            // 
            this.BtnDetalhesFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDetalhesFornecedor.FlatAppearance.BorderSize = 0;
            this.BtnDetalhesFornecedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(251)))));
            this.BtnDetalhesFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnDetalhesFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDetalhesFornecedor.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.BtnDetalhesFornecedor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDetalhesFornecedor.Location = new System.Drawing.Point(0, 1);
            this.BtnDetalhesFornecedor.Name = "BtnDetalhesFornecedor";
            this.BtnDetalhesFornecedor.Size = new System.Drawing.Size(100, 35);
            this.BtnDetalhesFornecedor.TabIndex = 0;
            this.BtnDetalhesFornecedor.Text = "Detalhes";
            this.BtnDetalhesFornecedor.UseVisualStyleBackColor = false;
            this.BtnDetalhesFornecedor.Click += new System.EventHandler(this.BtnDetalhesFornecedor_Click);
            // 
            // ACSFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 582);
            this.Controls.Add(this.MainTabsFornecedor);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftSidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ACSFornecedor";
            this.Text = "ACSFornecedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.MainTabsFornecedor.ResumeLayout(false);
            this.TabCadastrarPessoa.ResumeLayout(false);
            this.TabCadastrarPessoa.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TabConsultarPessoas.ResumeLayout(false);
            this.ListPessoasPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListaFornecedores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BottomOptionsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel leftSidePanel;
        private MetroFramework.Controls.MetroTabControl MainTabsFornecedor;
        private MetroFramework.Controls.MetroTabPage TabCadastrarPessoa;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel labelSite;
        private MetroFramework.Controls.MetroTextBox txtSite;
        private MetroFramework.Controls.MetroLabel labelEmail;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel labelCelular;
        private MetroFramework.Controls.MetroTextBox txtCelular;
        private MetroFramework.Controls.MetroTextBox txtTelefone;
        private System.Windows.Forms.Button BtnCadastrarFornecedor;
        private MetroFramework.Controls.MetroLabel labelTelefone;
        private MetroFramework.Controls.MetroLabel labelCNPJ;
        private MetroFramework.Controls.MetroLabel labelRazaoSocial;
        private MetroFramework.Controls.MetroTextBox txtRazaoSocial;
        private MetroFramework.Controls.MetroTextBox txtCNPJ;
        private MetroFramework.Controls.MetroTabPage TabConsultarPessoas;
        private System.Windows.Forms.Panel ListPessoasPanel;
        private MetroFramework.Controls.MetroGrid ListaFornecedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazaoSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Site;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Panel BottomOptionsPanel;
        private System.Windows.Forms.Button BtnDetalhesFornecedor;
    }
}