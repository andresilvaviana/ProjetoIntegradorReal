namespace ProjetoIntegradorReal
{
    partial class StatusDoacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusDoacao));
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.rdbAguardando = new System.Windows.Forms.RadioButton();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.txtCPFRecebedor = new System.Windows.Forms.TextBox();
            this.lblCPFDoador = new System.Windows.Forms.Label();
            this.lblCPFRecebedor = new System.Windows.Forms.Label();
            this.txtCPFDoador = new System.Windows.Forms.TextBox();
            this.lblCesta = new System.Windows.Forms.Label();
            this.lblEletro3 = new System.Windows.Forms.Label();
            this.lblEletro2 = new System.Windows.Forms.Label();
            this.lblEletro1 = new System.Windows.Forms.Label();
            this.cbxCestaBasica = new System.Windows.Forms.ComboBox();
            this.cbxEletrodomestico3 = new System.Windows.Forms.ComboBox();
            this.cbxEletrodomestico2 = new System.Windows.Forms.ComboBox();
            this.cbxEletrodomestico = new System.Windows.Forms.ComboBox();
            this.lblLivro2 = new System.Windows.Forms.Label();
            this.lblLivro1 = new System.Windows.Forms.Label();
            this.cbxLivro2 = new System.Windows.Forms.ComboBox();
            this.cbxLivro1 = new System.Windows.Forms.ComboBox();
            this.lblBrinq2 = new System.Windows.Forms.Label();
            this.cbxBrinq2 = new System.Windows.Forms.ComboBox();
            this.cbxBrinq1 = new System.Windows.Forms.ComboBox();
            this.lblBrinq1 = new System.Windows.Forms.Label();
            this.lblRoupa2 = new System.Windows.Forms.Label();
            this.lblRoupa3 = new System.Windows.Forms.Label();
            this.cbxRoupa2 = new System.Windows.Forms.ComboBox();
            this.cbxRoupa3 = new System.Windows.Forms.ComboBox();
            this.cbxRoupa1 = new System.Windows.Forms.ComboBox();
            this.lblRoupa1 = new System.Windows.Forms.Label();
            this.lblLinha = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistro.Font = new System.Drawing.Font("Candara", 12F);
            this.lblRegistro.Location = new System.Drawing.Point(45, 26);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(67, 19);
            this.lblRegistro.TabIndex = 2;
            this.lblRegistro.Text = "Registro";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Candara", 12F);
            this.lblDescricao.Location = new System.Drawing.Point(38, 204);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(74, 19);
            this.lblDescricao.TabIndex = 35;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Candara", 12F);
            this.txtDescricao.Location = new System.Drawing.Point(42, 226);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(412, 99);
            this.txtDescricao.TabIndex = 34;
            // 
            // grbStatus
            // 
            this.grbStatus.BackColor = System.Drawing.Color.Transparent;
            this.grbStatus.Controls.Add(this.rdbAtivo);
            this.grbStatus.Controls.Add(this.rdbAguardando);
            this.grbStatus.Font = new System.Drawing.Font("Candara", 12F);
            this.grbStatus.Location = new System.Drawing.Point(205, 22);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Size = new System.Drawing.Size(241, 69);
            this.grbStatus.TabIndex = 36;
            this.grbStatus.TabStop = false;
            this.grbStatus.Text = "Status do Pedido";
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Location = new System.Drawing.Point(6, 26);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(63, 23);
            this.rdbAtivo.TabIndex = 38;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            this.rdbAtivo.CheckedChanged += new System.EventHandler(this.rdbAtivo_CheckedChanged);
            // 
            // rdbAguardando
            // 
            this.rdbAguardando.AutoSize = true;
            this.rdbAguardando.Location = new System.Drawing.Point(122, 26);
            this.rdbAguardando.Name = "rdbAguardando";
            this.rdbAguardando.Size = new System.Drawing.Size(113, 23);
            this.rdbAguardando.TabIndex = 39;
            this.rdbAguardando.TabStop = true;
            this.rdbAguardando.Text = "Aguardando";
            this.rdbAguardando.UseVisualStyleBackColor = true;
            this.rdbAguardando.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // txtRegistro
            // 
            this.txtRegistro.Font = new System.Drawing.Font("Candara", 12F);
            this.txtRegistro.Location = new System.Drawing.Point(49, 48);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(145, 27);
            this.txtRegistro.TabIndex = 37;
            // 
            // txtCPFRecebedor
            // 
            this.txtCPFRecebedor.Font = new System.Drawing.Font("Candara", 12F);
            this.txtCPFRecebedor.Location = new System.Drawing.Point(309, 369);
            this.txtCPFRecebedor.Name = "txtCPFRecebedor";
            this.txtCPFRecebedor.Size = new System.Drawing.Size(145, 27);
            this.txtCPFRecebedor.TabIndex = 39;
            // 
            // lblCPFDoador
            // 
            this.lblCPFDoador.AutoSize = true;
            this.lblCPFDoador.BackColor = System.Drawing.Color.Transparent;
            this.lblCPFDoador.Font = new System.Drawing.Font("Candara", 12F);
            this.lblCPFDoador.Location = new System.Drawing.Point(38, 347);
            this.lblCPFDoador.Name = "lblCPFDoador";
            this.lblCPFDoador.Size = new System.Drawing.Size(110, 19);
            this.lblCPFDoador.TabIndex = 40;
            this.lblCPFDoador.Text = "CPF do Doador";
            // 
            // lblCPFRecebedor
            // 
            this.lblCPFRecebedor.AutoSize = true;
            this.lblCPFRecebedor.BackColor = System.Drawing.Color.Transparent;
            this.lblCPFRecebedor.Font = new System.Drawing.Font("Candara", 12F);
            this.lblCPFRecebedor.Location = new System.Drawing.Point(318, 347);
            this.lblCPFRecebedor.Name = "lblCPFRecebedor";
            this.lblCPFRecebedor.Size = new System.Drawing.Size(136, 19);
            this.lblCPFRecebedor.TabIndex = 41;
            this.lblCPFRecebedor.Text = "CPF do Recebedor ";
            // 
            // txtCPFDoador
            // 
            this.txtCPFDoador.Font = new System.Drawing.Font("Candara", 12F);
            this.txtCPFDoador.Location = new System.Drawing.Point(42, 369);
            this.txtCPFDoador.Name = "txtCPFDoador";
            this.txtCPFDoador.Size = new System.Drawing.Size(145, 27);
            this.txtCPFDoador.TabIndex = 38;
            // 
            // lblCesta
            // 
            this.lblCesta.AutoSize = true;
            this.lblCesta.BackColor = System.Drawing.Color.Transparent;
            this.lblCesta.Enabled = false;
            this.lblCesta.Font = new System.Drawing.Font("Candara", 12F);
            this.lblCesta.Location = new System.Drawing.Point(60, 129);
            this.lblCesta.Name = "lblCesta";
            this.lblCesta.Size = new System.Drawing.Size(42, 19);
            this.lblCesta.TabIndex = 109;
            this.lblCesta.Text = "Tipo:";
            this.lblCesta.Visible = false;
            // 
            // lblEletro3
            // 
            this.lblEletro3.AutoSize = true;
            this.lblEletro3.BackColor = System.Drawing.Color.Transparent;
            this.lblEletro3.Enabled = false;
            this.lblEletro3.Font = new System.Drawing.Font("Candara", 12F);
            this.lblEletro3.Location = new System.Drawing.Point(384, 129);
            this.lblEletro3.Name = "lblEletro3";
            this.lblEletro3.Size = new System.Drawing.Size(60, 19);
            this.lblEletro3.TabIndex = 108;
            this.lblEletro3.Text = "Estado:";
            this.lblEletro3.Visible = false;
            // 
            // lblEletro2
            // 
            this.lblEletro2.AutoSize = true;
            this.lblEletro2.BackColor = System.Drawing.Color.Transparent;
            this.lblEletro2.Enabled = false;
            this.lblEletro2.Font = new System.Drawing.Font("Candara", 12F);
            this.lblEletro2.Location = new System.Drawing.Point(215, 129);
            this.lblEletro2.Name = "lblEletro2";
            this.lblEletro2.Size = new System.Drawing.Size(79, 19);
            this.lblEletro2.TabIndex = 107;
            this.lblEletro2.Text = "Voltagem:";
            this.lblEletro2.Visible = false;
            // 
            // lblEletro1
            // 
            this.lblEletro1.AutoSize = true;
            this.lblEletro1.BackColor = System.Drawing.Color.Transparent;
            this.lblEletro1.Enabled = false;
            this.lblEletro1.Font = new System.Drawing.Font("Candara", 12F);
            this.lblEletro1.Location = new System.Drawing.Point(60, 129);
            this.lblEletro1.Name = "lblEletro1";
            this.lblEletro1.Size = new System.Drawing.Size(42, 19);
            this.lblEletro1.TabIndex = 106;
            this.lblEletro1.Text = "Tipo:";
            this.lblEletro1.Visible = false;
            // 
            // cbxCestaBasica
            // 
            this.cbxCestaBasica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCestaBasica.Enabled = false;
            this.cbxCestaBasica.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxCestaBasica.FormattingEnabled = true;
            this.cbxCestaBasica.Items.AddRange(new object[] {
            "Cesta Básica",
            "Congelados",
            "Produtos de Limpeza",
            "Produtos de Higiene"});
            this.cbxCestaBasica.Location = new System.Drawing.Point(20, 151);
            this.cbxCestaBasica.Name = "cbxCestaBasica";
            this.cbxCestaBasica.Size = new System.Drawing.Size(150, 27);
            this.cbxCestaBasica.TabIndex = 105;
            this.cbxCestaBasica.Visible = false;
            // 
            // cbxEletrodomestico3
            // 
            this.cbxEletrodomestico3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEletrodomestico3.Enabled = false;
            this.cbxEletrodomestico3.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxEletrodomestico3.FormattingEnabled = true;
            this.cbxEletrodomestico3.Items.AddRange(new object[] {
            "Semi-novo",
            "Usado"});
            this.cbxEletrodomestico3.Location = new System.Drawing.Point(332, 151);
            this.cbxEletrodomestico3.Name = "cbxEletrodomestico3";
            this.cbxEletrodomestico3.Size = new System.Drawing.Size(150, 27);
            this.cbxEletrodomestico3.TabIndex = 104;
            this.cbxEletrodomestico3.Visible = false;
            // 
            // cbxEletrodomestico2
            // 
            this.cbxEletrodomestico2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEletrodomestico2.Enabled = false;
            this.cbxEletrodomestico2.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxEletrodomestico2.FormattingEnabled = true;
            this.cbxEletrodomestico2.Items.AddRange(new object[] {
            "110V",
            "220V",
            "Bivolt"});
            this.cbxEletrodomestico2.Location = new System.Drawing.Point(176, 151);
            this.cbxEletrodomestico2.Name = "cbxEletrodomestico2";
            this.cbxEletrodomestico2.Size = new System.Drawing.Size(150, 27);
            this.cbxEletrodomestico2.TabIndex = 103;
            this.cbxEletrodomestico2.Visible = false;
            // 
            // cbxEletrodomestico
            // 
            this.cbxEletrodomestico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEletrodomestico.Enabled = false;
            this.cbxEletrodomestico.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxEletrodomestico.FormattingEnabled = true;
            this.cbxEletrodomestico.Items.AddRange(new object[] {
            "Aspirador",
            "Batedeira",
            "Fogão",
            "Geladeira",
            "Liquidificador",
            "Máquina de lavar",
            "Televisão",
            "Ventilador"});
            this.cbxEletrodomestico.Location = new System.Drawing.Point(20, 151);
            this.cbxEletrodomestico.Name = "cbxEletrodomestico";
            this.cbxEletrodomestico.Size = new System.Drawing.Size(150, 27);
            this.cbxEletrodomestico.TabIndex = 102;
            this.cbxEletrodomestico.Visible = false;
            // 
            // lblLivro2
            // 
            this.lblLivro2.AutoSize = true;
            this.lblLivro2.BackColor = System.Drawing.Color.Transparent;
            this.lblLivro2.Enabled = false;
            this.lblLivro2.Font = new System.Drawing.Font("Candara", 12F);
            this.lblLivro2.Location = new System.Drawing.Point(215, 129);
            this.lblLivro2.Name = "lblLivro2";
            this.lblLivro2.Size = new System.Drawing.Size(60, 19);
            this.lblLivro2.TabIndex = 101;
            this.lblLivro2.Text = "Estado:";
            this.lblLivro2.Visible = false;
            // 
            // lblLivro1
            // 
            this.lblLivro1.AutoSize = true;
            this.lblLivro1.BackColor = System.Drawing.Color.Transparent;
            this.lblLivro1.Enabled = false;
            this.lblLivro1.Font = new System.Drawing.Font("Candara", 12F);
            this.lblLivro1.Location = new System.Drawing.Point(60, 129);
            this.lblLivro1.Name = "lblLivro1";
            this.lblLivro1.Size = new System.Drawing.Size(63, 19);
            this.lblLivro1.TabIndex = 100;
            this.lblLivro1.Text = "Gênero:";
            this.lblLivro1.Visible = false;
            // 
            // cbxLivro2
            // 
            this.cbxLivro2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLivro2.Enabled = false;
            this.cbxLivro2.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxLivro2.FormattingEnabled = true;
            this.cbxLivro2.Items.AddRange(new object[] {
            "Novo",
            "Semi-novo",
            "Usado"});
            this.cbxLivro2.Location = new System.Drawing.Point(176, 151);
            this.cbxLivro2.Name = "cbxLivro2";
            this.cbxLivro2.Size = new System.Drawing.Size(150, 27);
            this.cbxLivro2.TabIndex = 99;
            this.cbxLivro2.Visible = false;
            // 
            // cbxLivro1
            // 
            this.cbxLivro1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLivro1.Enabled = false;
            this.cbxLivro1.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxLivro1.FormattingEnabled = true;
            this.cbxLivro1.Items.AddRange(new object[] {
            "Aventura",
            "Biografia",
            "Clássicos",
            "Contos",
            "Crônica",
            "Didático",
            "Drama",
            "Fantasia",
            "Ficção Científica",
            "Infantil",
            "Mistério",
            "Poesia",
            "Religioso",
            "Romance",
            "Suspense",
            "Terror"});
            this.cbxLivro1.Location = new System.Drawing.Point(20, 151);
            this.cbxLivro1.Name = "cbxLivro1";
            this.cbxLivro1.Size = new System.Drawing.Size(150, 27);
            this.cbxLivro1.TabIndex = 98;
            this.cbxLivro1.Visible = false;
            // 
            // lblBrinq2
            // 
            this.lblBrinq2.AutoSize = true;
            this.lblBrinq2.BackColor = System.Drawing.Color.Transparent;
            this.lblBrinq2.Enabled = false;
            this.lblBrinq2.Font = new System.Drawing.Font("Candara", 12F);
            this.lblBrinq2.Location = new System.Drawing.Point(215, 129);
            this.lblBrinq2.Name = "lblBrinq2";
            this.lblBrinq2.Size = new System.Drawing.Size(51, 19);
            this.lblBrinq2.TabIndex = 97;
            this.lblBrinq2.Text = "Idade:";
            this.lblBrinq2.Visible = false;
            // 
            // cbxBrinq2
            // 
            this.cbxBrinq2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBrinq2.Enabled = false;
            this.cbxBrinq2.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxBrinq2.FormattingEnabled = true;
            this.cbxBrinq2.Items.AddRange(new object[] {
            "0 - 12 Meses",
            "1 - 3 Anos",
            "4 - 6 Anos",
            "1 - 12 Anos",
            "13+ Anos"});
            this.cbxBrinq2.Location = new System.Drawing.Point(176, 151);
            this.cbxBrinq2.Name = "cbxBrinq2";
            this.cbxBrinq2.Size = new System.Drawing.Size(150, 27);
            this.cbxBrinq2.TabIndex = 96;
            this.cbxBrinq2.Visible = false;
            // 
            // cbxBrinq1
            // 
            this.cbxBrinq1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBrinq1.Enabled = false;
            this.cbxBrinq1.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxBrinq1.FormattingEnabled = true;
            this.cbxBrinq1.Items.AddRange(new object[] {
            "Bonecos",
            "Cartas",
            "Construção",
            "Criativo",
            "Educativo",
            "Eletrônico",
            "Esporte",
            "Musical",
            "Tabuleiro",
            "Veículos"});
            this.cbxBrinq1.Location = new System.Drawing.Point(20, 151);
            this.cbxBrinq1.Name = "cbxBrinq1";
            this.cbxBrinq1.Size = new System.Drawing.Size(150, 27);
            this.cbxBrinq1.TabIndex = 95;
            this.cbxBrinq1.Visible = false;
            // 
            // lblBrinq1
            // 
            this.lblBrinq1.AutoSize = true;
            this.lblBrinq1.BackColor = System.Drawing.Color.Transparent;
            this.lblBrinq1.Enabled = false;
            this.lblBrinq1.Font = new System.Drawing.Font("Candara", 12F);
            this.lblBrinq1.Location = new System.Drawing.Point(60, 129);
            this.lblBrinq1.Name = "lblBrinq1";
            this.lblBrinq1.Size = new System.Drawing.Size(42, 19);
            this.lblBrinq1.TabIndex = 94;
            this.lblBrinq1.Text = "Tipo:";
            this.lblBrinq1.Visible = false;
            // 
            // lblRoupa2
            // 
            this.lblRoupa2.AutoSize = true;
            this.lblRoupa2.BackColor = System.Drawing.Color.Transparent;
            this.lblRoupa2.Enabled = false;
            this.lblRoupa2.Font = new System.Drawing.Font("Candara", 12F);
            this.lblRoupa2.Location = new System.Drawing.Point(215, 129);
            this.lblRoupa2.Name = "lblRoupa2";
            this.lblRoupa2.Size = new System.Drawing.Size(76, 19);
            this.lblRoupa2.TabIndex = 93;
            this.lblRoupa2.Text = "Tamanho:";
            this.lblRoupa2.Visible = false;
            // 
            // lblRoupa3
            // 
            this.lblRoupa3.AutoSize = true;
            this.lblRoupa3.BackColor = System.Drawing.Color.Transparent;
            this.lblRoupa3.Enabled = false;
            this.lblRoupa3.Font = new System.Drawing.Font("Candara", 12F);
            this.lblRoupa3.Location = new System.Drawing.Point(384, 129);
            this.lblRoupa3.Name = "lblRoupa3";
            this.lblRoupa3.Size = new System.Drawing.Size(45, 19);
            this.lblRoupa3.TabIndex = 92;
            this.lblRoupa3.Text = "Peça:";
            this.lblRoupa3.Visible = false;
            // 
            // cbxRoupa2
            // 
            this.cbxRoupa2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoupa2.Enabled = false;
            this.cbxRoupa2.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxRoupa2.FormattingEnabled = true;
            this.cbxRoupa2.Items.AddRange(new object[] {
            "Infantil - RN",
            "Infantil - 0 a 6 meses",
            "Infantil - 6 meses a 1 ano",
            "Infantil - 1 a 5 anos",
            "infantil - 6 a 12 anos",
            "PP",
            "P",
            "M",
            "G",
            "GG",
            "XG"});
            this.cbxRoupa2.Location = new System.Drawing.Point(176, 151);
            this.cbxRoupa2.Name = "cbxRoupa2";
            this.cbxRoupa2.Size = new System.Drawing.Size(150, 27);
            this.cbxRoupa2.TabIndex = 91;
            this.cbxRoupa2.Visible = false;
            // 
            // cbxRoupa3
            // 
            this.cbxRoupa3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoupa3.Enabled = false;
            this.cbxRoupa3.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxRoupa3.FormattingEnabled = true;
            this.cbxRoupa3.Items.AddRange(new object[] {
            "Camiseta",
            "Calça",
            "Bermuda",
            "Vestido",
            "Blusa",
            "Roupa Íntima"});
            this.cbxRoupa3.Location = new System.Drawing.Point(332, 151);
            this.cbxRoupa3.Name = "cbxRoupa3";
            this.cbxRoupa3.Size = new System.Drawing.Size(150, 27);
            this.cbxRoupa3.TabIndex = 90;
            this.cbxRoupa3.Visible = false;
            // 
            // cbxRoupa1
            // 
            this.cbxRoupa1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoupa1.Enabled = false;
            this.cbxRoupa1.Font = new System.Drawing.Font("Candara", 12F);
            this.cbxRoupa1.FormattingEnabled = true;
            this.cbxRoupa1.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Infantil Feminino",
            "Infantil Masculino"});
            this.cbxRoupa1.Location = new System.Drawing.Point(20, 151);
            this.cbxRoupa1.Name = "cbxRoupa1";
            this.cbxRoupa1.Size = new System.Drawing.Size(150, 27);
            this.cbxRoupa1.TabIndex = 89;
            this.cbxRoupa1.Visible = false;
            // 
            // lblRoupa1
            // 
            this.lblRoupa1.AutoSize = true;
            this.lblRoupa1.BackColor = System.Drawing.Color.Transparent;
            this.lblRoupa1.Enabled = false;
            this.lblRoupa1.Font = new System.Drawing.Font("Candara", 12F);
            this.lblRoupa1.Location = new System.Drawing.Point(60, 129);
            this.lblRoupa1.Name = "lblRoupa1";
            this.lblRoupa1.Size = new System.Drawing.Size(63, 19);
            this.lblRoupa1.TabIndex = 88;
            this.lblRoupa1.Text = "Gênero:";
            this.lblRoupa1.Visible = false;
            // 
            // lblLinha
            // 
            this.lblLinha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLinha.Enabled = false;
            this.lblLinha.Location = new System.Drawing.Point(42, 107);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(412, 2);
            this.lblLinha.TabIndex = 110;
            this.lblLinha.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.Window;
            this.btnVoltar.Font = new System.Drawing.Font("Candara", 12F);
            this.btnVoltar.Image = global::ProjetoIntegradorReal.Properties.Resources.voltar;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(42, 428);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(111, 34);
            this.btnVoltar.TabIndex = 111;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Window;
            this.btnCadastrar.Font = new System.Drawing.Font("Candara", 12F);
            this.btnCadastrar.Image = global::ProjetoIntegradorReal.Properties.Resources.salvar;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.Location = new System.Drawing.Point(343, 428);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(111, 34);
            this.btnCadastrar.TabIndex = 51;
            this.btnCadastrar.Text = "Confirmar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Window;
            this.btnExcluir.Font = new System.Drawing.Font("Candara", 12F);
            this.btnExcluir.Image = global::ProjetoIntegradorReal.Properties.Resources.Excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(195, 428);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(111, 34);
            this.btnExcluir.TabIndex = 112;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // StatusDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoIntegradorReal.Properties.Resources.fundo2;
            this.ClientSize = new System.Drawing.Size(504, 495);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblLinha);
            this.Controls.Add(this.lblCesta);
            this.Controls.Add(this.lblEletro3);
            this.Controls.Add(this.lblEletro2);
            this.Controls.Add(this.lblEletro1);
            this.Controls.Add(this.cbxCestaBasica);
            this.Controls.Add(this.cbxEletrodomestico3);
            this.Controls.Add(this.cbxEletrodomestico2);
            this.Controls.Add(this.cbxEletrodomestico);
            this.Controls.Add(this.lblLivro2);
            this.Controls.Add(this.lblLivro1);
            this.Controls.Add(this.cbxLivro2);
            this.Controls.Add(this.cbxLivro1);
            this.Controls.Add(this.lblBrinq2);
            this.Controls.Add(this.cbxBrinq2);
            this.Controls.Add(this.cbxBrinq1);
            this.Controls.Add(this.lblBrinq1);
            this.Controls.Add(this.lblRoupa2);
            this.Controls.Add(this.lblRoupa3);
            this.Controls.Add(this.cbxRoupa2);
            this.Controls.Add(this.cbxRoupa3);
            this.Controls.Add(this.cbxRoupa1);
            this.Controls.Add(this.lblRoupa1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblCPFRecebedor);
            this.Controls.Add(this.lblCPFDoador);
            this.Controls.Add(this.txtCPFRecebedor);
            this.Controls.Add(this.txtCPFDoador);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.grbStatus);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatusDoacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatusDoacao";
            this.Load += new System.EventHandler(this.StatusDoacao_Load);
            this.grbStatus.ResumeLayout(false);
            this.grbStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.GroupBox grbStatus;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.RadioButton rdbAguardando;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.TextBox txtCPFRecebedor;
        private System.Windows.Forms.Label lblCPFDoador;
        private System.Windows.Forms.Label lblCPFRecebedor;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtCPFDoador;
        private System.Windows.Forms.Label lblCesta;
        private System.Windows.Forms.Label lblEletro3;
        private System.Windows.Forms.Label lblEletro2;
        private System.Windows.Forms.Label lblEletro1;
        private System.Windows.Forms.ComboBox cbxCestaBasica;
        private System.Windows.Forms.ComboBox cbxEletrodomestico3;
        private System.Windows.Forms.ComboBox cbxEletrodomestico2;
        private System.Windows.Forms.ComboBox cbxEletrodomestico;
        private System.Windows.Forms.Label lblLivro2;
        private System.Windows.Forms.Label lblLivro1;
        private System.Windows.Forms.ComboBox cbxLivro2;
        private System.Windows.Forms.ComboBox cbxLivro1;
        private System.Windows.Forms.Label lblBrinq2;
        private System.Windows.Forms.ComboBox cbxBrinq2;
        private System.Windows.Forms.ComboBox cbxBrinq1;
        private System.Windows.Forms.Label lblBrinq1;
        private System.Windows.Forms.Label lblRoupa2;
        private System.Windows.Forms.Label lblRoupa3;
        private System.Windows.Forms.ComboBox cbxRoupa2;
        private System.Windows.Forms.ComboBox cbxRoupa3;
        private System.Windows.Forms.ComboBox cbxRoupa1;
        private System.Windows.Forms.Label lblRoupa1;
        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExcluir;
    }
}