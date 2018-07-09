namespace AdministrationClinicalSystem.br.com.acs.view
{
    partial class ACSWindowEquipamentos
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
            this.dateCalibracao = new MetroFramework.Controls.MetroDateTime();
            this.dateManutencaoPreventiva = new MetroFramework.Controls.MetroDateTime();
            this.BtnInativarEquipamento = new System.Windows.Forms.Button();
            this.toggleStatusEquipamento = new MetroFramework.Controls.MetroToggle();
            this.labelStatusEquipamento = new MetroFramework.Controls.MetroLabel();
            this.labelTempoCAL = new MetroFramework.Controls.MetroLabel();
            this.comboTempoCAL = new MetroFramework.Controls.MetroComboBox();
            this.labelCalibracao = new MetroFramework.Controls.MetroLabel();
            this.labelObservacoes = new MetroFramework.Controls.MetroLabel();
            this.txtObservacoes = new MetroFramework.Controls.MetroTextBox();
            this.labelPeriodicidadeCAL = new MetroFramework.Controls.MetroLabel();
            this.txtPeriodicidadeCAL = new MetroFramework.Controls.MetroTextBox();
            this.labelTempoPeriodicidade = new MetroFramework.Controls.MetroLabel();
            this.comboTempoPeriodicidade = new MetroFramework.Controls.MetroComboBox();
            this.labelManutencaoPreventiva = new MetroFramework.Controls.MetroLabel();
            this.labelPeriodicidadeMP = new MetroFramework.Controls.MetroLabel();
            this.txtPeriodicidadeMP = new MetroFramework.Controls.MetroTextBox();
            this.comboSetor = new MetroFramework.Controls.MetroComboBox();
            this.labelSetor = new MetroFramework.Controls.MetroLabel();
            this.txtModelo = new MetroFramework.Controls.MetroTextBox();
            this.labelModelo = new MetroFramework.Controls.MetroLabel();
            this.labelFinalidade = new MetroFramework.Controls.MetroLabel();
            this.comboFinalidade = new MetroFramework.Controls.MetroComboBox();
            this.comboPatrimonio = new MetroFramework.Controls.MetroComboBox();
            this.txtNumeroSerie = new MetroFramework.Controls.MetroTextBox();
            this.labelNumeroSerie = new MetroFramework.Controls.MetroLabel();
            this.labelNomeEquipamento = new MetroFramework.Controls.MetroLabel();
            this.labelPatrimonio = new MetroFramework.Controls.MetroLabel();
            this.txtNomeEquipamento = new MetroFramework.Controls.MetroTextBox();
            this.BtnAtualizarDadosEquipamento = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel1.Location = new System.Drawing.Point(67, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(204, 25);
            this.metroLabel1.TabIndex = 82;
            this.metroLabel1.Text = "Detalhes Equipamento";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dateCalibracao);
            this.panel1.Controls.Add(this.dateManutencaoPreventiva);
            this.panel1.Controls.Add(this.BtnInativarEquipamento);
            this.panel1.Controls.Add(this.toggleStatusEquipamento);
            this.panel1.Controls.Add(this.labelStatusEquipamento);
            this.panel1.Controls.Add(this.labelTempoCAL);
            this.panel1.Controls.Add(this.comboTempoCAL);
            this.panel1.Controls.Add(this.labelCalibracao);
            this.panel1.Controls.Add(this.labelObservacoes);
            this.panel1.Controls.Add(this.txtObservacoes);
            this.panel1.Controls.Add(this.labelPeriodicidadeCAL);
            this.panel1.Controls.Add(this.txtPeriodicidadeCAL);
            this.panel1.Controls.Add(this.labelTempoPeriodicidade);
            this.panel1.Controls.Add(this.comboTempoPeriodicidade);
            this.panel1.Controls.Add(this.labelManutencaoPreventiva);
            this.panel1.Controls.Add(this.labelPeriodicidadeMP);
            this.panel1.Controls.Add(this.txtPeriodicidadeMP);
            this.panel1.Controls.Add(this.comboSetor);
            this.panel1.Controls.Add(this.labelSetor);
            this.panel1.Controls.Add(this.txtModelo);
            this.panel1.Controls.Add(this.labelModelo);
            this.panel1.Controls.Add(this.labelFinalidade);
            this.panel1.Controls.Add(this.comboFinalidade);
            this.panel1.Controls.Add(this.comboPatrimonio);
            this.panel1.Controls.Add(this.txtNumeroSerie);
            this.panel1.Controls.Add(this.labelNumeroSerie);
            this.panel1.Controls.Add(this.labelNomeEquipamento);
            this.panel1.Controls.Add(this.labelPatrimonio);
            this.panel1.Controls.Add(this.txtNomeEquipamento);
            this.panel1.Controls.Add(this.BtnAtualizarDadosEquipamento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 420);
            this.panel1.TabIndex = 83;
            // 
            // dateCalibracao
            // 
            this.dateCalibracao.CustomFormat = "dd/MM/yyyy";
            this.dateCalibracao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateCalibracao.Location = new System.Drawing.Point(17, 585);
            this.dateCalibracao.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateCalibracao.Name = "dateCalibracao";
            this.dateCalibracao.Size = new System.Drawing.Size(125, 29);
            this.dateCalibracao.TabIndex = 97;
            // 
            // dateManutencaoPreventiva
            // 
            this.dateManutencaoPreventiva.CustomFormat = "dd/MM/yyyy";
            this.dateManutencaoPreventiva.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateManutencaoPreventiva.Location = new System.Drawing.Point(17, 463);
            this.dateManutencaoPreventiva.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateManutencaoPreventiva.Name = "dateManutencaoPreventiva";
            this.dateManutencaoPreventiva.Size = new System.Drawing.Size(125, 29);
            this.dateManutencaoPreventiva.TabIndex = 96;
            // 
            // BtnInativarEquipamento
            // 
            this.BtnInativarEquipamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnInativarEquipamento.FlatAppearance.BorderSize = 0;
            this.BtnInativarEquipamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnInativarEquipamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnInativarEquipamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInativarEquipamento.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.BtnInativarEquipamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnInativarEquipamento.Location = new System.Drawing.Point(149, 839);
            this.BtnInativarEquipamento.Name = "BtnInativarEquipamento";
            this.BtnInativarEquipamento.Size = new System.Drawing.Size(126, 35);
            this.BtnInativarEquipamento.TabIndex = 95;
            this.BtnInativarEquipamento.Text = "Excluir";
            this.BtnInativarEquipamento.UseVisualStyleBackColor = false;
            // 
            // toggleStatusEquipamento
            // 
            this.toggleStatusEquipamento.AutoSize = true;
            this.toggleStatusEquipamento.DisplayStatus = false;
            this.toggleStatusEquipamento.Location = new System.Drawing.Point(48, 40);
            this.toggleStatusEquipamento.Name = "toggleStatusEquipamento";
            this.toggleStatusEquipamento.Size = new System.Drawing.Size(50, 17);
            this.toggleStatusEquipamento.TabIndex = 84;
            this.toggleStatusEquipamento.Text = "Off";
            this.toggleStatusEquipamento.UseSelectable = true;
            // 
            // labelStatusEquipamento
            // 
            this.labelStatusEquipamento.AutoSize = true;
            this.labelStatusEquipamento.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelStatusEquipamento.Location = new System.Drawing.Point(19, 22);
            this.labelStatusEquipamento.Name = "labelStatusEquipamento";
            this.labelStatusEquipamento.Size = new System.Drawing.Size(108, 15);
            this.labelStatusEquipamento.TabIndex = 94;
            this.labelStatusEquipamento.Text = "Status Equipamento";
            // 
            // labelTempoCAL
            // 
            this.labelTempoCAL.AutoSize = true;
            this.labelTempoCAL.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelTempoCAL.Location = new System.Drawing.Point(151, 629);
            this.labelTempoCAL.Name = "labelTempoCAL";
            this.labelTempoCAL.Size = new System.Drawing.Size(41, 15);
            this.labelTempoCAL.TabIndex = 89;
            this.labelTempoCAL.Text = "Tempo";
            // 
            // comboTempoCAL
            // 
            this.comboTempoCAL.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboTempoCAL.FormattingEnabled = true;
            this.comboTempoCAL.ItemHeight = 23;
            this.comboTempoCAL.Items.AddRange(new object[] {
            "estado"});
            this.comboTempoCAL.Location = new System.Drawing.Point(149, 645);
            this.comboTempoCAL.Name = "comboTempoCAL";
            this.comboTempoCAL.Size = new System.Drawing.Size(126, 29);
            this.comboTempoCAL.Style = MetroFramework.MetroColorStyle.Blue;
            this.comboTempoCAL.TabIndex = 88;
            this.comboTempoCAL.UseCustomForeColor = true;
            this.comboTempoCAL.UseSelectable = true;
            // 
            // labelCalibracao
            // 
            this.labelCalibracao.AutoSize = true;
            this.labelCalibracao.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelCalibracao.Location = new System.Drawing.Point(19, 569);
            this.labelCalibracao.Name = "labelCalibracao";
            this.labelCalibracao.Size = new System.Drawing.Size(59, 15);
            this.labelCalibracao.TabIndex = 93;
            this.labelCalibracao.Text = "Calibração";
            // 
            // labelObservacoes
            // 
            this.labelObservacoes.AutoSize = true;
            this.labelObservacoes.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelObservacoes.Location = new System.Drawing.Point(19, 691);
            this.labelObservacoes.Name = "labelObservacoes";
            this.labelObservacoes.Size = new System.Drawing.Size(73, 15);
            this.labelObservacoes.TabIndex = 81;
            this.labelObservacoes.Text = "Observações";
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
            this.txtObservacoes.Location = new System.Drawing.Point(17, 707);
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
            this.txtObservacoes.TabIndex = 80;
            this.txtObservacoes.UseCustomForeColor = true;
            this.txtObservacoes.UseSelectable = true;
            this.txtObservacoes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtObservacoes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelPeriodicidadeCAL
            // 
            this.labelPeriodicidadeCAL.AutoSize = true;
            this.labelPeriodicidadeCAL.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelPeriodicidadeCAL.Location = new System.Drawing.Point(19, 631);
            this.labelPeriodicidadeCAL.Name = "labelPeriodicidadeCAL";
            this.labelPeriodicidadeCAL.Size = new System.Drawing.Size(97, 15);
            this.labelPeriodicidadeCAL.TabIndex = 90;
            this.labelPeriodicidadeCAL.Text = "Periodicidade CAL";
            // 
            // txtPeriodicidadeCAL
            // 
            // 
            // 
            // 
            this.txtPeriodicidadeCAL.CustomButton.Image = null;
            this.txtPeriodicidadeCAL.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txtPeriodicidadeCAL.CustomButton.Name = "";
            this.txtPeriodicidadeCAL.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPeriodicidadeCAL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPeriodicidadeCAL.CustomButton.TabIndex = 1;
            this.txtPeriodicidadeCAL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPeriodicidadeCAL.CustomButton.UseSelectable = true;
            this.txtPeriodicidadeCAL.CustomButton.Visible = false;
            this.txtPeriodicidadeCAL.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPeriodicidadeCAL.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPeriodicidadeCAL.Lines = new string[0];
            this.txtPeriodicidadeCAL.Location = new System.Drawing.Point(17, 647);
            this.txtPeriodicidadeCAL.MaxLength = 32767;
            this.txtPeriodicidadeCAL.Name = "txtPeriodicidadeCAL";
            this.txtPeriodicidadeCAL.PasswordChar = '\0';
            this.txtPeriodicidadeCAL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPeriodicidadeCAL.SelectedText = "";
            this.txtPeriodicidadeCAL.SelectionLength = 0;
            this.txtPeriodicidadeCAL.SelectionStart = 0;
            this.txtPeriodicidadeCAL.ShortcutsEnabled = true;
            this.txtPeriodicidadeCAL.Size = new System.Drawing.Size(96, 23);
            this.txtPeriodicidadeCAL.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPeriodicidadeCAL.TabIndex = 91;
            this.txtPeriodicidadeCAL.UseCustomForeColor = true;
            this.txtPeriodicidadeCAL.UseSelectable = true;
            this.txtPeriodicidadeCAL.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPeriodicidadeCAL.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelTempoPeriodicidade
            // 
            this.labelTempoPeriodicidade.AutoSize = true;
            this.labelTempoPeriodicidade.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelTempoPeriodicidade.Location = new System.Drawing.Point(151, 507);
            this.labelTempoPeriodicidade.Name = "labelTempoPeriodicidade";
            this.labelTempoPeriodicidade.Size = new System.Drawing.Size(41, 15);
            this.labelTempoPeriodicidade.TabIndex = 83;
            this.labelTempoPeriodicidade.Text = "Tempo";
            // 
            // comboTempoPeriodicidade
            // 
            this.comboTempoPeriodicidade.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboTempoPeriodicidade.FormattingEnabled = true;
            this.comboTempoPeriodicidade.ItemHeight = 23;
            this.comboTempoPeriodicidade.Items.AddRange(new object[] {
            "estado"});
            this.comboTempoPeriodicidade.Location = new System.Drawing.Point(149, 523);
            this.comboTempoPeriodicidade.Name = "comboTempoPeriodicidade";
            this.comboTempoPeriodicidade.Size = new System.Drawing.Size(126, 29);
            this.comboTempoPeriodicidade.Style = MetroFramework.MetroColorStyle.Blue;
            this.comboTempoPeriodicidade.TabIndex = 82;
            this.comboTempoPeriodicidade.UseCustomForeColor = true;
            this.comboTempoPeriodicidade.UseSelectable = true;
            // 
            // labelManutencaoPreventiva
            // 
            this.labelManutencaoPreventiva.AutoSize = true;
            this.labelManutencaoPreventiva.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelManutencaoPreventiva.Location = new System.Drawing.Point(19, 447);
            this.labelManutencaoPreventiva.Name = "labelManutencaoPreventiva";
            this.labelManutencaoPreventiva.Size = new System.Drawing.Size(123, 15);
            this.labelManutencaoPreventiva.TabIndex = 87;
            this.labelManutencaoPreventiva.Text = "Manutenção preventiva";
            // 
            // labelPeriodicidadeMP
            // 
            this.labelPeriodicidadeMP.AutoSize = true;
            this.labelPeriodicidadeMP.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelPeriodicidadeMP.Location = new System.Drawing.Point(19, 509);
            this.labelPeriodicidadeMP.Name = "labelPeriodicidadeMP";
            this.labelPeriodicidadeMP.Size = new System.Drawing.Size(94, 15);
            this.labelPeriodicidadeMP.TabIndex = 84;
            this.labelPeriodicidadeMP.Text = "Periodicidade MP";
            // 
            // txtPeriodicidadeMP
            // 
            // 
            // 
            // 
            this.txtPeriodicidadeMP.CustomButton.Image = null;
            this.txtPeriodicidadeMP.CustomButton.Location = new System.Drawing.Point(74, 1);
            this.txtPeriodicidadeMP.CustomButton.Name = "";
            this.txtPeriodicidadeMP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPeriodicidadeMP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPeriodicidadeMP.CustomButton.TabIndex = 1;
            this.txtPeriodicidadeMP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPeriodicidadeMP.CustomButton.UseSelectable = true;
            this.txtPeriodicidadeMP.CustomButton.Visible = false;
            this.txtPeriodicidadeMP.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPeriodicidadeMP.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtPeriodicidadeMP.Lines = new string[0];
            this.txtPeriodicidadeMP.Location = new System.Drawing.Point(17, 525);
            this.txtPeriodicidadeMP.MaxLength = 32767;
            this.txtPeriodicidadeMP.Name = "txtPeriodicidadeMP";
            this.txtPeriodicidadeMP.PasswordChar = '\0';
            this.txtPeriodicidadeMP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPeriodicidadeMP.SelectedText = "";
            this.txtPeriodicidadeMP.SelectionLength = 0;
            this.txtPeriodicidadeMP.SelectionStart = 0;
            this.txtPeriodicidadeMP.ShortcutsEnabled = true;
            this.txtPeriodicidadeMP.Size = new System.Drawing.Size(96, 23);
            this.txtPeriodicidadeMP.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPeriodicidadeMP.TabIndex = 85;
            this.txtPeriodicidadeMP.UseCustomForeColor = true;
            this.txtPeriodicidadeMP.UseSelectable = true;
            this.txtPeriodicidadeMP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPeriodicidadeMP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comboSetor
            // 
            this.comboSetor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboSetor.FormattingEnabled = true;
            this.comboSetor.ItemHeight = 23;
            this.comboSetor.Items.AddRange(new object[] {
            "cidade"});
            this.comboSetor.Location = new System.Drawing.Point(17, 397);
            this.comboSetor.Name = "comboSetor";
            this.comboSetor.Size = new System.Drawing.Size(258, 29);
            this.comboSetor.Style = MetroFramework.MetroColorStyle.Blue;
            this.comboSetor.TabIndex = 79;
            this.comboSetor.UseCustomForeColor = true;
            this.comboSetor.UseSelectable = true;
            // 
            // labelSetor
            // 
            this.labelSetor.AutoSize = true;
            this.labelSetor.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelSetor.Location = new System.Drawing.Point(19, 381);
            this.labelSetor.Name = "labelSetor";
            this.labelSetor.Size = new System.Drawing.Size(34, 15);
            this.labelSetor.TabIndex = 78;
            this.labelSetor.Text = "Setor";
            // 
            // txtModelo
            // 
            // 
            // 
            // 
            this.txtModelo.CustomButton.Image = null;
            this.txtModelo.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtModelo.CustomButton.Name = "";
            this.txtModelo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtModelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtModelo.CustomButton.TabIndex = 1;
            this.txtModelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtModelo.CustomButton.UseSelectable = true;
            this.txtModelo.CustomButton.Visible = false;
            this.txtModelo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtModelo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtModelo.Lines = new string[0];
            this.txtModelo.Location = new System.Drawing.Point(17, 276);
            this.txtModelo.MaxLength = 32767;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.PasswordChar = '\0';
            this.txtModelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtModelo.SelectedText = "";
            this.txtModelo.SelectionLength = 0;
            this.txtModelo.SelectionStart = 0;
            this.txtModelo.ShortcutsEnabled = true;
            this.txtModelo.Size = new System.Drawing.Size(258, 23);
            this.txtModelo.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtModelo.TabIndex = 77;
            this.txtModelo.UseCustomForeColor = true;
            this.txtModelo.UseSelectable = true;
            this.txtModelo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtModelo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelModelo.Location = new System.Drawing.Point(19, 260);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(46, 15);
            this.labelModelo.TabIndex = 76;
            this.labelModelo.Text = "Modelo";
            // 
            // labelFinalidade
            // 
            this.labelFinalidade.AutoSize = true;
            this.labelFinalidade.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelFinalidade.Location = new System.Drawing.Point(19, 315);
            this.labelFinalidade.Name = "labelFinalidade";
            this.labelFinalidade.Size = new System.Drawing.Size(57, 15);
            this.labelFinalidade.TabIndex = 75;
            this.labelFinalidade.Text = "Finalidade";
            // 
            // comboFinalidade
            // 
            this.comboFinalidade.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboFinalidade.FormattingEnabled = true;
            this.comboFinalidade.ItemHeight = 23;
            this.comboFinalidade.Items.AddRange(new object[] {
            "cidade"});
            this.comboFinalidade.Location = new System.Drawing.Point(17, 331);
            this.comboFinalidade.Name = "comboFinalidade";
            this.comboFinalidade.Size = new System.Drawing.Size(258, 29);
            this.comboFinalidade.Style = MetroFramework.MetroColorStyle.Blue;
            this.comboFinalidade.TabIndex = 74;
            this.comboFinalidade.UseCustomForeColor = true;
            this.comboFinalidade.UseSelectable = true;
            // 
            // comboPatrimonio
            // 
            this.comboPatrimonio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboPatrimonio.FormattingEnabled = true;
            this.comboPatrimonio.ItemHeight = 23;
            this.comboPatrimonio.Items.AddRange(new object[] {
            "cidade"});
            this.comboPatrimonio.Location = new System.Drawing.Point(17, 96);
            this.comboPatrimonio.Name = "comboPatrimonio";
            this.comboPatrimonio.Size = new System.Drawing.Size(258, 29);
            this.comboPatrimonio.Style = MetroFramework.MetroColorStyle.Blue;
            this.comboPatrimonio.TabIndex = 73;
            this.comboPatrimonio.UseCustomForeColor = true;
            this.comboPatrimonio.UseSelectable = true;
            // 
            // txtNumeroSerie
            // 
            // 
            // 
            // 
            this.txtNumeroSerie.CustomButton.Image = null;
            this.txtNumeroSerie.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtNumeroSerie.CustomButton.Name = "";
            this.txtNumeroSerie.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumeroSerie.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumeroSerie.CustomButton.TabIndex = 1;
            this.txtNumeroSerie.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumeroSerie.CustomButton.UseSelectable = true;
            this.txtNumeroSerie.CustomButton.Visible = false;
            this.txtNumeroSerie.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNumeroSerie.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNumeroSerie.Lines = new string[0];
            this.txtNumeroSerie.Location = new System.Drawing.Point(17, 216);
            this.txtNumeroSerie.MaxLength = 32767;
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.PasswordChar = '\0';
            this.txtNumeroSerie.ReadOnly = true;
            this.txtNumeroSerie.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumeroSerie.SelectedText = "";
            this.txtNumeroSerie.SelectionLength = 0;
            this.txtNumeroSerie.SelectionStart = 0;
            this.txtNumeroSerie.ShortcutsEnabled = true;
            this.txtNumeroSerie.Size = new System.Drawing.Size(258, 23);
            this.txtNumeroSerie.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumeroSerie.TabIndex = 72;
            this.txtNumeroSerie.UseCustomForeColor = true;
            this.txtNumeroSerie.UseSelectable = true;
            this.txtNumeroSerie.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumeroSerie.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // labelNumeroSerie
            // 
            this.labelNumeroSerie.AutoSize = true;
            this.labelNumeroSerie.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelNumeroSerie.Location = new System.Drawing.Point(19, 200);
            this.labelNumeroSerie.Name = "labelNumeroSerie";
            this.labelNumeroSerie.Size = new System.Drawing.Size(63, 15);
            this.labelNumeroSerie.TabIndex = 71;
            this.labelNumeroSerie.Text = "Nº de série";
            // 
            // labelNomeEquipamento
            // 
            this.labelNomeEquipamento.AutoSize = true;
            this.labelNomeEquipamento.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelNomeEquipamento.Location = new System.Drawing.Point(19, 140);
            this.labelNomeEquipamento.Name = "labelNomeEquipamento";
            this.labelNomeEquipamento.Size = new System.Drawing.Size(109, 15);
            this.labelNomeEquipamento.TabIndex = 70;
            this.labelNomeEquipamento.Text = "Nome equipamento";
            // 
            // labelPatrimonio
            // 
            this.labelPatrimonio.AutoSize = true;
            this.labelPatrimonio.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelPatrimonio.Location = new System.Drawing.Point(19, 80);
            this.labelPatrimonio.Name = "labelPatrimonio";
            this.labelPatrimonio.Size = new System.Drawing.Size(61, 15);
            this.labelPatrimonio.TabIndex = 69;
            this.labelPatrimonio.Text = "Patrimônio";
            // 
            // txtNomeEquipamento
            // 
            // 
            // 
            // 
            this.txtNomeEquipamento.CustomButton.Image = null;
            this.txtNomeEquipamento.CustomButton.Location = new System.Drawing.Point(236, 1);
            this.txtNomeEquipamento.CustomButton.Name = "";
            this.txtNomeEquipamento.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeEquipamento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeEquipamento.CustomButton.TabIndex = 1;
            this.txtNomeEquipamento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeEquipamento.CustomButton.UseSelectable = true;
            this.txtNomeEquipamento.CustomButton.Visible = false;
            this.txtNomeEquipamento.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNomeEquipamento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNomeEquipamento.Lines = new string[0];
            this.txtNomeEquipamento.Location = new System.Drawing.Point(17, 156);
            this.txtNomeEquipamento.MaxLength = 32767;
            this.txtNomeEquipamento.Name = "txtNomeEquipamento";
            this.txtNomeEquipamento.PasswordChar = '\0';
            this.txtNomeEquipamento.ReadOnly = true;
            this.txtNomeEquipamento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeEquipamento.SelectedText = "";
            this.txtNomeEquipamento.SelectionLength = 0;
            this.txtNomeEquipamento.SelectionStart = 0;
            this.txtNomeEquipamento.ShortcutsEnabled = true;
            this.txtNomeEquipamento.Size = new System.Drawing.Size(258, 23);
            this.txtNomeEquipamento.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeEquipamento.TabIndex = 68;
            this.txtNomeEquipamento.UseCustomForeColor = true;
            this.txtNomeEquipamento.UseSelectable = true;
            this.txtNomeEquipamento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeEquipamento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnAtualizarDadosEquipamento
            // 
            this.BtnAtualizarDadosEquipamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(181)))));
            this.BtnAtualizarDadosEquipamento.FlatAppearance.BorderSize = 0;
            this.BtnAtualizarDadosEquipamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnAtualizarDadosEquipamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.BtnAtualizarDadosEquipamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizarDadosEquipamento.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.BtnAtualizarDadosEquipamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAtualizarDadosEquipamento.Location = new System.Drawing.Point(17, 839);
            this.BtnAtualizarDadosEquipamento.Name = "BtnAtualizarDadosEquipamento";
            this.BtnAtualizarDadosEquipamento.Size = new System.Drawing.Size(125, 35);
            this.BtnAtualizarDadosEquipamento.TabIndex = 67;
            this.BtnAtualizarDadosEquipamento.Text = "Atualizar";
            this.BtnAtualizarDadosEquipamento.UseVisualStyleBackColor = false;
            // 
            // ACSWindowEquipamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 500);
            this.MinimumSize = new System.Drawing.Size(350, 500);
            this.Name = "ACSWindowEquipamentos";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAtualizarDadosEquipamento;
        private MetroFramework.Controls.MetroComboBox comboSetor;
        private MetroFramework.Controls.MetroLabel labelSetor;
        private MetroFramework.Controls.MetroTextBox txtModelo;
        private MetroFramework.Controls.MetroLabel labelModelo;
        private MetroFramework.Controls.MetroLabel labelFinalidade;
        private MetroFramework.Controls.MetroComboBox comboFinalidade;
        private MetroFramework.Controls.MetroComboBox comboPatrimonio;
        private MetroFramework.Controls.MetroTextBox txtNumeroSerie;
        private MetroFramework.Controls.MetroLabel labelNumeroSerie;
        private MetroFramework.Controls.MetroLabel labelNomeEquipamento;
        private MetroFramework.Controls.MetroLabel labelPatrimonio;
        private MetroFramework.Controls.MetroTextBox txtNomeEquipamento;
        private MetroFramework.Controls.MetroLabel labelTempoCAL;
        private MetroFramework.Controls.MetroComboBox comboTempoCAL;
        private MetroFramework.Controls.MetroLabel labelCalibracao;
        private MetroFramework.Controls.MetroLabel labelObservacoes;
        private MetroFramework.Controls.MetroTextBox txtObservacoes;
        private MetroFramework.Controls.MetroLabel labelPeriodicidadeCAL;
        private MetroFramework.Controls.MetroTextBox txtPeriodicidadeCAL;
        private MetroFramework.Controls.MetroLabel labelTempoPeriodicidade;
        private MetroFramework.Controls.MetroComboBox comboTempoPeriodicidade;
        private MetroFramework.Controls.MetroLabel labelManutencaoPreventiva;
        private MetroFramework.Controls.MetroLabel labelPeriodicidadeMP;
        private MetroFramework.Controls.MetroTextBox txtPeriodicidadeMP;
        private MetroFramework.Controls.MetroToggle toggleStatusEquipamento;
        private MetroFramework.Controls.MetroLabel labelStatusEquipamento;
        private System.Windows.Forms.Button BtnInativarEquipamento;
        private MetroFramework.Controls.MetroDateTime dateManutencaoPreventiva;
        private MetroFramework.Controls.MetroDateTime dateCalibracao;
    }
}