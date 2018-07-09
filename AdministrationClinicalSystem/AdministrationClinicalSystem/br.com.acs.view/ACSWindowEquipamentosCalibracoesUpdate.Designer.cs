namespace AdministrationClinicalSystem.br.com.acs.view
{
    partial class ACSWindowEquipamentosCalibracoesUpdate
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDataEnvio = new MetroFramework.Controls.MetroLabel();
            this.labelDataRetorno = new MetroFramework.Controls.MetroLabel();
            this.labelObservacoes = new MetroFramework.Controls.MetroLabel();
            this.BtnAtualizarCalibracao = new System.Windows.Forms.Button();
            this.txtObservacoes = new MetroFramework.Controls.MetroTextBox();
            this.dateEnvio = new MetroFramework.Controls.MetroDateTime();
            this.dateRetorno = new MetroFramework.Controls.MetroDateTime();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel1.Location = new System.Drawing.Point(44, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(263, 25);
            this.metroLabel1.TabIndex = 84;
            this.metroLabel1.Text = "Atualizar dados da calibração";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dateRetorno);
            this.panel1.Controls.Add(this.dateEnvio);
            this.panel1.Controls.Add(this.labelDataEnvio);
            this.panel1.Controls.Add(this.labelDataRetorno);
            this.panel1.Controls.Add(this.labelObservacoes);
            this.panel1.Controls.Add(this.BtnAtualizarCalibracao);
            this.panel1.Controls.Add(this.txtObservacoes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 345);
            this.panel1.TabIndex = 88;
            // 
            // labelDataEnvio
            // 
            this.labelDataEnvio.AutoSize = true;
            this.labelDataEnvio.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelDataEnvio.Location = new System.Drawing.Point(27, 22);
            this.labelDataEnvio.Name = "labelDataEnvio";
            this.labelDataEnvio.Size = new System.Drawing.Size(76, 15);
            this.labelDataEnvio.TabIndex = 88;
            this.labelDataEnvio.Text = "Data de Envio";
            // 
            // labelDataRetorno
            // 
            this.labelDataRetorno.AutoSize = true;
            this.labelDataRetorno.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelDataRetorno.Location = new System.Drawing.Point(27, 84);
            this.labelDataRetorno.Name = "labelDataRetorno";
            this.labelDataRetorno.Size = new System.Drawing.Size(91, 15);
            this.labelDataRetorno.TabIndex = 87;
            this.labelDataRetorno.Text = "Data de Retorno";
            // 
            // labelObservacoes
            // 
            this.labelObservacoes.AutoSize = true;
            this.labelObservacoes.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelObservacoes.Location = new System.Drawing.Point(27, 150);
            this.labelObservacoes.Name = "labelObservacoes";
            this.labelObservacoes.Size = new System.Drawing.Size(73, 15);
            this.labelObservacoes.TabIndex = 86;
            this.labelObservacoes.Text = "Observações";
            // 
            // BtnAtualizarCalibracao
            // 
            this.BtnAtualizarCalibracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(181)))));
            this.BtnAtualizarCalibracao.FlatAppearance.BorderSize = 0;
            this.BtnAtualizarCalibracao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnAtualizarCalibracao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnAtualizarCalibracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizarCalibracao.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.BtnAtualizarCalibracao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAtualizarCalibracao.Location = new System.Drawing.Point(77, 279);
            this.BtnAtualizarCalibracao.Name = "BtnAtualizarCalibracao";
            this.BtnAtualizarCalibracao.Size = new System.Drawing.Size(150, 35);
            this.BtnAtualizarCalibracao.TabIndex = 84;
            this.BtnAtualizarCalibracao.Text = "Atualizar Dados";
            this.BtnAtualizarCalibracao.UseVisualStyleBackColor = false;
            // 
            // txtObservacoes
            // 
            // 
            // 
            // 
            this.txtObservacoes.CustomButton.Image = null;
            this.txtObservacoes.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.txtObservacoes.CustomButton.Name = "";
            this.txtObservacoes.CustomButton.Size = new System.Drawing.Size(81, 81);
            this.txtObservacoes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObservacoes.CustomButton.TabIndex = 1;
            this.txtObservacoes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtObservacoes.CustomButton.UseSelectable = true;
            this.txtObservacoes.CustomButton.Visible = false;
            this.txtObservacoes.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtObservacoes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtObservacoes.Lines = new string[0];
            this.txtObservacoes.Location = new System.Drawing.Point(25, 166);
            this.txtObservacoes.MaxLength = 32767;
            this.txtObservacoes.Multiline = true;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.PasswordChar = '\0';
            this.txtObservacoes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservacoes.SelectedText = "";
            this.txtObservacoes.SelectionLength = 0;
            this.txtObservacoes.SelectionStart = 0;
            this.txtObservacoes.ShortcutsEnabled = true;
            this.txtObservacoes.Size = new System.Drawing.Size(258, 86);
            this.txtObservacoes.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtObservacoes.TabIndex = 85;
            this.txtObservacoes.UseCustomForeColor = true;
            this.txtObservacoes.UseSelectable = true;
            this.txtObservacoes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObservacoes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dateEnvio
            // 
            this.dateEnvio.CustomFormat = "dd/MM/yyyy";
            this.dateEnvio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnvio.Location = new System.Drawing.Point(25, 38);
            this.dateEnvio.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateEnvio.Name = "dateEnvio";
            this.dateEnvio.Size = new System.Drawing.Size(125, 29);
            this.dateEnvio.TabIndex = 97;
            // 
            // dateRetorno
            // 
            this.dateRetorno.CustomFormat = "dd/MM/yyyy";
            this.dateRetorno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateRetorno.Location = new System.Drawing.Point(25, 100);
            this.dateRetorno.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateRetorno.Name = "dateRetorno";
            this.dateRetorno.Size = new System.Drawing.Size(125, 29);
            this.dateRetorno.TabIndex = 98;
            // 
            // ACSWindowEquipamentosCalibracoesUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel1);
            this.MaximumSize = new System.Drawing.Size(350, 425);
            this.MinimumSize = new System.Drawing.Size(350, 425);
            this.Name = "ACSWindowEquipamentosCalibracoesUpdate";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel labelObservacoes;
        private System.Windows.Forms.Button BtnAtualizarCalibracao;
        private MetroFramework.Controls.MetroTextBox txtObservacoes;
        private MetroFramework.Controls.MetroLabel labelDataEnvio;
        private MetroFramework.Controls.MetroLabel labelDataRetorno;
        private MetroFramework.Controls.MetroDateTime dateRetorno;
        private MetroFramework.Controls.MetroDateTime dateEnvio;
    }
}