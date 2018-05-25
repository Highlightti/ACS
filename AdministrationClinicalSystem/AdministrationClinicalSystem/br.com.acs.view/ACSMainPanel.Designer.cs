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
            this.btnEquipamentosIcon = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.btnEquipamentos = new System.Windows.Forms.Button();
            this.nomeUsuario = new MetroFramework.Controls.MetroLabel();
            this.Ola = new MetroFramework.Controls.MetroLabel();
            this.btnHomeIcon = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.btnHomeIcon);
            this.panel1.Controls.Add(this.btnEquipamentosIcon);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 444);
            this.panel1.TabIndex = 15;
            // 
            // btnEquipamentosIcon
            // 
            this.btnEquipamentosIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnEquipamentosIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEquipamentosIcon.BackgroundImage")));
            this.btnEquipamentosIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEquipamentosIcon.FlatAppearance.BorderSize = 0;
            this.btnEquipamentosIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(211)))), ((int)(((byte)(152)))));
            this.btnEquipamentosIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(188)))), ((int)(((byte)(105)))));
            this.btnEquipamentosIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipamentosIcon.Location = new System.Drawing.Point(0, 158);
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
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(188)))), ((int)(((byte)(105)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Location = new System.Drawing.Point(5, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(30, 30);
            this.btnMenu.TabIndex = 17;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(188)))), ((int)(((byte)(105)))));
            this.menu.Controls.Add(this.btnHome);
            this.menu.Controls.Add(this.btnEquipamentos);
            this.menu.Controls.Add(this.nomeUsuario);
            this.menu.Controls.Add(this.Ola);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(60, 60);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(200, 444);
            this.menu.TabIndex = 16;
            this.menu.Visible = false;
            // 
            // btnEquipamentos
            // 
            this.btnEquipamentos.BackColor = System.Drawing.Color.Transparent;
            this.btnEquipamentos.FlatAppearance.BorderSize = 0;
            this.btnEquipamentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(211)))), ((int)(((byte)(152)))));
            this.btnEquipamentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(202)))), ((int)(((byte)(127)))));
            this.btnEquipamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquipamentos.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipamentos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEquipamentos.Location = new System.Drawing.Point(0, 158);
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
            this.nomeUsuario.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.nomeUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nomeUsuario.Location = new System.Drawing.Point(45, 15);
            this.nomeUsuario.Name = "nomeUsuario";
            this.nomeUsuario.Size = new System.Drawing.Size(87, 19);
            this.nomeUsuario.TabIndex = 19;
            this.nomeUsuario.Text = "Lenno Sousa";
            this.nomeUsuario.UseCustomBackColor = true;
            this.nomeUsuario.UseCustomForeColor = true;
            this.nomeUsuario.UseStyleColors = true;
            // 
            // Ola
            // 
            this.Ola.AutoSize = true;
            this.Ola.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Ola.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ola.Location = new System.Drawing.Point(15, 15);
            this.Ola.Name = "Ola";
            this.Ola.Size = new System.Drawing.Size(33, 19);
            this.Ola.TabIndex = 17;
            this.Ola.Text = "Olá,";
            this.Ola.UseCustomBackColor = true;
            this.Ola.UseCustomForeColor = true;
            this.Ola.UseStyleColors = true;
            // 
            // btnHomeIcon
            // 
            this.btnHomeIcon.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHomeIcon.BackgroundImage")));
            this.btnHomeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHomeIcon.FlatAppearance.BorderSize = 0;
            this.btnHomeIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(211)))), ((int)(((byte)(152)))));
            this.btnHomeIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(188)))), ((int)(((byte)(105)))));
            this.btnHomeIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeIcon.Location = new System.Drawing.Point(0, 101);
            this.btnHomeIcon.Name = "btnHomeIcon";
            this.btnHomeIcon.Size = new System.Drawing.Size(40, 40);
            this.btnHomeIcon.TabIndex = 21;
            this.btnHomeIcon.UseVisualStyleBackColor = false;
            this.btnHomeIcon.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(211)))), ((int)(((byte)(152)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(202)))), ((int)(((byte)(127)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semilight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.Location = new System.Drawing.Point(0, 101);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 40);
            this.btnHome.TabIndex = 20;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(60, 60);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(879, 444);
            this.contentPanel.TabIndex = 17;
            // 
            // ACSMainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 524);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroComboBox2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroComboBox1);
            this.Name = "ACSMainPanel";
            this.Text = "Painel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ACSLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
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
    }
}

