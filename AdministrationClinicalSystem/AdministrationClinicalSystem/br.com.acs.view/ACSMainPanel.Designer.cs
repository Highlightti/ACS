namespace AdministrationClinicalSystem
{
    partial class ACSMainPanel
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACSMainPanel));
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroStyleManagerMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMeusDadosIcon = new System.Windows.Forms.Button();
            this.btnLogoutIcon = new System.Windows.Forms.Button();
            this.btnHomeIcon = new System.Windows.Forms.Button();
            this.btnEquipamentosIcon = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.btnMeusDados = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnEquipamentos = new System.Windows.Forms.Button();
            this.nomeUsuario = new MetroFramework.Controls.MetroLabel();
            this.Ola = new MetroFramework.Controls.MetroLabel();
            this.contentPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.metroComboBox1.Location = new System.Drawing.Point(183, 23);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(117, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(128, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Theme";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(328, 27);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Color";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Items.AddRange(new object[] {
            "Default",
            "Black",
            "White",
            "Silver",
            "Blue",
            "Green",
            "Lime",
            "Teal",
            "Orange",
            "Brown",
            "Pink",
            "Magenta",
            "Purple",
            "Red",
            "Yellow"});
            this.metroComboBox2.Location = new System.Drawing.Point(385, 23);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox2.TabIndex = 13;
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // metroStyleManagerMain
            // 
            this.metroStyleManagerMain.Owner = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(202)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.btnMeusDadosIcon);
            this.panel1.Controls.Add(this.btnLogoutIcon);
            this.panel1.Controls.Add(this.btnHomeIcon);
            this.panel1.Controls.Add(this.btnEquipamentosIcon);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 520);
            this.panel1.TabIndex = 15;
            // 
            // btnMeusDadosIcon
            // 
            this.btnMeusDadosIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnMeusDadosIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMeusDadosIcon.BackgroundImage")));
            this.btnMeusDadosIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMeusDadosIcon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMeusDadosIcon.FlatAppearance.BorderSize = 0;
            this.btnMeusDadosIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(188)))), ((int)(((byte)(105)))));
            this.btnMeusDadosIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(188)))), ((int)(((byte)(105)))));
            this.btnMeusDadosIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeusDadosIcon.Location = new System.Drawing.Point(0, 440);
            this.btnMeusDadosIcon.Name = "btnMeusDadosIcon";
            this.btnMeusDadosIcon.Size = new System.Drawing.Size(40, 40);
            this.btnMeusDadosIcon.TabIndex = 23;
            this.btnMeusDadosIcon.UseVisualStyleBackColor = false;
            this.btnMeusDadosIcon.Click += new System.EventHandler(this.btnMeusDados_Click);
            // 
            // btnLogoutIcon
            // 
            this.btnLogoutIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnLogoutIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogoutIcon.BackgroundImage")));
            this.btnLogoutIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogoutIcon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogoutIcon.FlatAppearance.BorderSize = 0;
            this.btnLogoutIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(188)))), ((int)(((byte)(105)))));
            this.btnLogoutIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(188)))), ((int)(((byte)(105)))));
            this.btnLogoutIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutIcon.Location = new System.Drawing.Point(0, 480);
            this.btnLogoutIcon.Name = "btnLogoutIcon";
            this.btnLogoutIcon.Size = new System.Drawing.Size(40, 40);
            this.btnLogoutIcon.TabIndex = 22;
            this.btnLogoutIcon.UseVisualStyleBackColor = false;
            this.btnLogoutIcon.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHomeIcon
            // 
            this.btnHomeIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHomeIcon.BackgroundImage")));
            this.btnHomeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHomeIcon.FlatAppearance.BorderSize = 0;
            this.btnHomeIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(188)))), ((int)(((byte)(105)))));
            this.btnHomeIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(188)))), ((int)(((byte)(105)))));
            this.btnHomeIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeIcon.Location = new System.Drawing.Point(0, 40);
            this.btnHomeIcon.Name = "btnHomeIcon";
            this.btnHomeIcon.Size = new System.Drawing.Size(40, 40);
            this.btnHomeIcon.TabIndex = 21;
            this.btnHomeIcon.UseVisualStyleBackColor = false;
            this.btnHomeIcon.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEquipamentosIcon
            // 
            this.btnEquipamentosIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnEquipamentosIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEquipamentosIcon.BackgroundImage")));
            this.btnEquipamentosIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEquipamentosIcon.FlatAppearance.BorderSize = 0;
            this.btnEquipamentosIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(188)))), ((int)(((byte)(105)))));
            this.btnEquipamentosIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(188)))), ((int)(((byte)(105)))));
            this.btnEquipamentosIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipamentosIcon.Location = new System.Drawing.Point(0, 80);
            this.btnEquipamentosIcon.Name = "btnEquipamentosIcon";
            this.btnEquipamentosIcon.Size = new System.Drawing.Size(40, 40);
            this.btnEquipamentosIcon.TabIndex = 18;
            this.btnEquipamentosIcon.UseVisualStyleBackColor = false;
            this.btnEquipamentosIcon.Click += new System.EventHandler(this.btnEquipamentos_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(188)))), ((int)(((byte)(105)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 40);
            this.btnMenu.TabIndex = 17;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(188)))), ((int)(((byte)(105)))));
            this.menu.Controls.Add(this.btnMeusDados);
            this.menu.Controls.Add(this.btnLogout);
            this.menu.Controls.Add(this.btnHome);
            this.menu.Controls.Add(this.btnEquipamentos);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(60, 60);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(200, 520);
            this.menu.TabIndex = 16;
            this.menu.Visible = false;
            // 
            // btnMeusDados
            // 
            this.btnMeusDados.BackColor = System.Drawing.Color.Transparent;
            this.btnMeusDados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMeusDados.FlatAppearance.BorderSize = 0;
            this.btnMeusDados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(202)))), ((int)(((byte)(127)))));
            this.btnMeusDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(202)))), ((int)(((byte)(127)))));
            this.btnMeusDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeusDados.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeusDados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMeusDados.Location = new System.Drawing.Point(0, 440);
            this.btnMeusDados.Name = "btnMeusDados";
            this.btnMeusDados.Size = new System.Drawing.Size(200, 40);
            this.btnMeusDados.TabIndex = 22;
            this.btnMeusDados.Text = "Meus Dados";
            this.btnMeusDados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeusDados.UseVisualStyleBackColor = false;
            this.btnMeusDados.Click += new System.EventHandler(this.btnMeusDados_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(202)))), ((int)(((byte)(127)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(202)))), ((int)(((byte)(127)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(0, 480);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 40);
            this.btnLogout.TabIndex = 21;
            this.btnLogout.Text = "Sair";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(202)))), ((int)(((byte)(127)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(202)))), ((int)(((byte)(127)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.Location = new System.Drawing.Point(0, 40);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 40);
            this.btnHome.TabIndex = 20;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnEquipamentos
            // 
            this.btnEquipamentos.BackColor = System.Drawing.Color.Transparent;
            this.btnEquipamentos.FlatAppearance.BorderSize = 0;
            this.btnEquipamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(202)))), ((int)(((byte)(127)))));
            this.btnEquipamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(202)))), ((int)(((byte)(127)))));
            this.btnEquipamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipamentos.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipamentos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEquipamentos.Location = new System.Drawing.Point(0, 80);
            this.btnEquipamentos.Name = "btnEquipamentos";
            this.btnEquipamentos.Size = new System.Drawing.Size(200, 40);
            this.btnEquipamentos.TabIndex = 17;
            this.btnEquipamentos.Text = "Equipamentos";
            this.btnEquipamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEquipamentos.UseVisualStyleBackColor = false;
            this.btnEquipamentos.Click += new System.EventHandler(this.btnEquipamentos_Click);
            // 
            // nomeUsuario
            // 
            this.nomeUsuario.AutoSize = true;
            this.nomeUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nomeUsuario.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.nomeUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nomeUsuario.Location = new System.Drawing.Point(613, 27);
            this.nomeUsuario.Name = "nomeUsuario";
            this.nomeUsuario.Size = new System.Drawing.Size(46, 19);
            this.nomeUsuario.TabIndex = 19;
            this.nomeUsuario.Text = "Nome";
            this.nomeUsuario.UseCustomBackColor = true;
            this.nomeUsuario.UseCustomForeColor = true;
            this.nomeUsuario.UseStyleColors = true;
            this.nomeUsuario.Click += new System.EventHandler(this.nomeUsuario_Click);
            // 
            // Ola
            // 
            this.Ola.AutoSize = true;
            this.Ola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Ola.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Ola.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ola.Location = new System.Drawing.Point(583, 27);
            this.Ola.Name = "Ola";
            this.Ola.Size = new System.Drawing.Size(33, 19);
            this.Ola.TabIndex = 17;
            this.Ola.Text = "Olá,";
            this.Ola.UseCustomBackColor = true;
            this.Ola.UseCustomForeColor = true;
            this.Ola.UseStyleColors = true;
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(60, 60);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(938, 520);
            this.contentPanel.TabIndex = 17;
            // 
            // ACSMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 600);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.nomeUsuario);
            this.Controls.Add(this.Ola);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroComboBox1);
            this.Name = "ACSMainPanel";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Painel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ACSLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Components.MetroStyleManager metroStyleManagerMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button btnMenu;
        private MetroFramework.Controls.MetroLabel Ola;
        private MetroFramework.Controls.MetroLabel nomeUsuario;
        private System.Windows.Forms.Button btnEquipamentos;
        private System.Windows.Forms.Button btnEquipamentosIcon;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnHomeIcon;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button btnMeusDadosIcon;
        private System.Windows.Forms.Button btnLogoutIcon;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMeusDados;
    }
}

