namespace AdministrationClinicalSystem.br.com.acs.view
{
    partial class ACSUsuarios
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.ListaPatrimonios = new MetroFramework.Controls.MetroGrid();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NivelAcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.BottomOptionsPanel = new System.Windows.Forms.Panel();
            this.BtnRedefinirSenha = new System.Windows.Forms.Button();
            this.BtnDetalhesUsuario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaPatrimonios)).BeginInit();
            this.panel2.SuspendLayout();
            this.BottomOptionsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(907, 533);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.ListaPatrimonios);
            this.metroTabPage1.Controls.Add(this.panel2);
            this.metroTabPage1.Controls.Add(this.BottomOptionsPanel);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(899, 491);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "     Usuários     ";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // ListaPatrimonios
            // 
            this.ListaPatrimonios.AllowUserToAddRows = false;
            this.ListaPatrimonios.AllowUserToDeleteRows = false;
            this.ListaPatrimonios.AllowUserToResizeRows = false;
            this.ListaPatrimonios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListaPatrimonios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaPatrimonios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ListaPatrimonios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaPatrimonios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListaPatrimonios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaPatrimonios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuario,
            this.Email,
            this.NivelAcesso});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListaPatrimonios.DefaultCellStyle = dataGridViewCellStyle5;
            this.ListaPatrimonios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListaPatrimonios.EnableHeadersVisualStyles = false;
            this.ListaPatrimonios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ListaPatrimonios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListaPatrimonios.Location = new System.Drawing.Point(0, 35);
            this.ListaPatrimonios.Name = "ListaPatrimonios";
            this.ListaPatrimonios.ReadOnly = true;
            this.ListaPatrimonios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaPatrimonios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ListaPatrimonios.RowHeadersWidth = 10;
            this.ListaPatrimonios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ListaPatrimonios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaPatrimonios.Size = new System.Drawing.Size(899, 421);
            this.ListaPatrimonios.Style = MetroFramework.MetroColorStyle.Silver;
            this.ListaPatrimonios.TabIndex = 8;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuário";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "E-mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // NivelAcesso
            // 
            this.NivelAcesso.HeaderText = "Nível de Acesso";
            this.NivelAcesso.Name = "NivelAcesso";
            this.NivelAcesso.ReadOnly = true;
            this.NivelAcesso.Width = 150;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.metroLabel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 35);
            this.panel2.TabIndex = 6;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.metroLabel2.Location = new System.Drawing.Point(38, 6);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(155, 25);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Lista de Usuários";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // BottomOptionsPanel
            // 
            this.BottomOptionsPanel.BackColor = System.Drawing.Color.Transparent;
            this.BottomOptionsPanel.Controls.Add(this.BtnRedefinirSenha);
            this.BottomOptionsPanel.Controls.Add(this.BtnDetalhesUsuario);
            this.BottomOptionsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomOptionsPanel.Location = new System.Drawing.Point(0, 456);
            this.BottomOptionsPanel.Name = "BottomOptionsPanel";
            this.BottomOptionsPanel.Size = new System.Drawing.Size(899, 35);
            this.BottomOptionsPanel.TabIndex = 4;
            // 
            // BtnRedefinirSenha
            // 
            this.BtnRedefinirSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnRedefinirSenha.FlatAppearance.BorderSize = 0;
            this.BtnRedefinirSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnRedefinirSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnRedefinirSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRedefinirSenha.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.BtnRedefinirSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnRedefinirSenha.Location = new System.Drawing.Point(113, 0);
            this.BtnRedefinirSenha.Name = "BtnRedefinirSenha";
            this.BtnRedefinirSenha.Size = new System.Drawing.Size(125, 35);
            this.BtnRedefinirSenha.TabIndex = 3;
            this.BtnRedefinirSenha.Text = "Redefinir Senha";
            this.BtnRedefinirSenha.UseVisualStyleBackColor = false;
            this.BtnRedefinirSenha.Click += new System.EventHandler(this.BtnRedefinirSenha_Click);
            // 
            // BtnDetalhesUsuario
            // 
            this.BtnDetalhesUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnDetalhesUsuario.FlatAppearance.BorderSize = 0;
            this.BtnDetalhesUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnDetalhesUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnDetalhesUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDetalhesUsuario.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.BtnDetalhesUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDetalhesUsuario.Location = new System.Drawing.Point(1, 1);
            this.BtnDetalhesUsuario.Name = "BtnDetalhesUsuario";
            this.BtnDetalhesUsuario.Size = new System.Drawing.Size(100, 35);
            this.BtnDetalhesUsuario.TabIndex = 0;
            this.BtnDetalhesUsuario.Text = "Detalhes";
            this.BtnDetalhesUsuario.UseVisualStyleBackColor = false;
            this.BtnDetalhesUsuario.Click += new System.EventHandler(this.BtnDetalhesUsuario_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroTabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 533);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 568);
            this.panel3.TabIndex = 46;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.metroLabel10);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(10, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(907, 35);
            this.topPanel.TabIndex = 49;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel10.Location = new System.Drawing.Point(6, 5);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(175, 25);
            this.metroLabel10.TabIndex = 15;
            this.metroLabel10.Text = "Gestão de Usuários";
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // ACSUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ACSUsuarios";
            this.Text = "ACSUsuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListaPatrimonios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.BottomOptionsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel BottomOptionsPanel;
        private System.Windows.Forms.Button BtnRedefinirSenha;
        private System.Windows.Forms.Button BtnDetalhesUsuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel topPanel;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid ListaPatrimonios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn NivelAcesso;
    }
}