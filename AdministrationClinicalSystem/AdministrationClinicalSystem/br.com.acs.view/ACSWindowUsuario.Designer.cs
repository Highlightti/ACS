namespace AdministrationClinicalSystem.br.com.acs.view
{
    partial class ACSWindowUsuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboNivelAcesso = new MetroFramework.Controls.MetroComboBox();
            this.lavelNivelAcesso = new MetroFramework.Controls.MetroLabel();
            this.BtnAtualizarDadosUsuario = new System.Windows.Forms.Button();
            this.labelNomeUsuario = new MetroFramework.Controls.MetroLabel();
            this.labelEmail = new MetroFramework.Controls.MetroLabel();
            this.txtNomeUsuario = new MetroFramework.Controls.MetroTextBox();
            this.txtSobrenome = new MetroFramework.Controls.MetroTextBox();
            this.labelAtribuirUsuario = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboNivelAcesso);
            this.panel1.Controls.Add(this.lavelNivelAcesso);
            this.panel1.Controls.Add(this.BtnAtualizarDadosUsuario);
            this.panel1.Controls.Add(this.labelNomeUsuario);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.txtNomeUsuario);
            this.panel1.Controls.Add(this.txtSobrenome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 270);
            this.panel1.TabIndex = 88;
            // 
            // comboNivelAcesso
            // 
            this.comboNivelAcesso.FormattingEnabled = true;
            this.comboNivelAcesso.ItemHeight = 23;
            this.comboNivelAcesso.Location = new System.Drawing.Point(24, 140);
            this.comboNivelAcesso.Name = "comboNivelAcesso";
            this.comboNivelAcesso.Size = new System.Drawing.Size(258, 29);
            this.comboNivelAcesso.TabIndex = 50;
            this.comboNivelAcesso.UseSelectable = true;
            // 
            // lavelNivelAcesso
            // 
            this.lavelNivelAcesso.AutoSize = true;
            this.lavelNivelAcesso.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lavelNivelAcesso.Location = new System.Drawing.Point(26, 124);
            this.lavelNivelAcesso.Name = "lavelNivelAcesso";
            this.lavelNivelAcesso.Size = new System.Drawing.Size(70, 15);
            this.lavelNivelAcesso.TabIndex = 49;
            this.lavelNivelAcesso.Text = "Nivel Acesso";
            // 
            // BtnAtualizarDadosUsuario
            // 
            this.BtnAtualizarDadosUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(181)))));
            this.BtnAtualizarDadosUsuario.FlatAppearance.BorderSize = 0;
            this.BtnAtualizarDadosUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnAtualizarDadosUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnAtualizarDadosUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizarDadosUsuario.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.BtnAtualizarDadosUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAtualizarDadosUsuario.Location = new System.Drawing.Point(91, 200);
            this.BtnAtualizarDadosUsuario.Name = "BtnAtualizarDadosUsuario";
            this.BtnAtualizarDadosUsuario.Size = new System.Drawing.Size(125, 35);
            this.BtnAtualizarDadosUsuario.TabIndex = 48;
            this.BtnAtualizarDadosUsuario.Text = "Atualizar";
            this.BtnAtualizarDadosUsuario.UseVisualStyleBackColor = false;
            // 
            // labelNomeUsuario
            // 
            this.labelNomeUsuario.AutoSize = true;
            this.labelNomeUsuario.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelNomeUsuario.Location = new System.Drawing.Point(26, 24);
            this.labelNomeUsuario.Name = "labelNomeUsuario";
            this.labelNomeUsuario.Size = new System.Drawing.Size(80, 15);
            this.labelNomeUsuario.TabIndex = 25;
            this.labelNomeUsuario.Text = "Nome Usuário";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelEmail.Location = new System.Drawing.Point(26, 74);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 15);
            this.labelEmail.TabIndex = 26;
            this.labelEmail.Text = "E-mail ";
            // 
            // txtNomeUsuario
            // 
            // 
            // 
            // 
            this.txtNomeUsuario.CustomButton.Image = null;
            this.txtNomeUsuario.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtNomeUsuario.CustomButton.Name = "";
            this.txtNomeUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeUsuario.CustomButton.TabIndex = 1;
            this.txtNomeUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeUsuario.CustomButton.UseSelectable = true;
            this.txtNomeUsuario.CustomButton.Visible = false;
            this.txtNomeUsuario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNomeUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNomeUsuario.Lines = new string[0];
            this.txtNomeUsuario.Location = new System.Drawing.Point(24, 42);
            this.txtNomeUsuario.MaxLength = 32767;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.PasswordChar = '\0';
            this.txtNomeUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeUsuario.SelectedText = "";
            this.txtNomeUsuario.SelectionLength = 0;
            this.txtNomeUsuario.SelectionStart = 0;
            this.txtNomeUsuario.ShortcutsEnabled = true;
            this.txtNomeUsuario.Size = new System.Drawing.Size(258, 23);
            this.txtNomeUsuario.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeUsuario.TabIndex = 23;
            this.txtNomeUsuario.UseCustomForeColor = true;
            this.txtNomeUsuario.UseSelectable = true;
            this.txtNomeUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSobrenome
            // 
            // 
            // 
            // 
            this.txtSobrenome.CustomButton.Image = null;
            this.txtSobrenome.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtSobrenome.CustomButton.Name = "";
            this.txtSobrenome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSobrenome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSobrenome.CustomButton.TabIndex = 1;
            this.txtSobrenome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSobrenome.CustomButton.UseSelectable = true;
            this.txtSobrenome.CustomButton.Visible = false;
            this.txtSobrenome.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSobrenome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSobrenome.Lines = new string[0];
            this.txtSobrenome.Location = new System.Drawing.Point(24, 90);
            this.txtSobrenome.MaxLength = 32767;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.PasswordChar = '\0';
            this.txtSobrenome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSobrenome.SelectedText = "";
            this.txtSobrenome.SelectionLength = 0;
            this.txtSobrenome.SelectionStart = 0;
            this.txtSobrenome.ShortcutsEnabled = true;
            this.txtSobrenome.Size = new System.Drawing.Size(258, 23);
            this.txtSobrenome.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSobrenome.TabIndex = 24;
            this.txtSobrenome.UseCustomForeColor = true;
            this.txtSobrenome.UseSelectable = true;
            this.txtSobrenome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSobrenome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelAtribuirUsuario
            // 
            this.labelAtribuirUsuario.AutoSize = true;
            this.labelAtribuirUsuario.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelAtribuirUsuario.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelAtribuirUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelAtribuirUsuario.Location = new System.Drawing.Point(97, 21);
            this.labelAtribuirUsuario.Name = "labelAtribuirUsuario";
            this.labelAtribuirUsuario.Size = new System.Drawing.Size(135, 25);
            this.labelAtribuirUsuario.TabIndex = 87;
            this.labelAtribuirUsuario.Text = "Dados Usuário";
            this.labelAtribuirUsuario.UseCustomForeColor = true;
            // 
            // ACSWindowUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelAtribuirUsuario);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "ACSWindowUsuario";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroComboBox comboNivelAcesso;
        private MetroFramework.Controls.MetroLabel lavelNivelAcesso;
        private System.Windows.Forms.Button BtnAtualizarDadosUsuario;
        private MetroFramework.Controls.MetroLabel labelNomeUsuario;
        private MetroFramework.Controls.MetroLabel labelEmail;
        private MetroFramework.Controls.MetroTextBox txtNomeUsuario;
        private MetroFramework.Controls.MetroTextBox txtSobrenome;
        private MetroFramework.Controls.MetroLabel labelAtribuirUsuario;
    }
}