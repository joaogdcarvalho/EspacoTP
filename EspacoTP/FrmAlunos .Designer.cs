﻿namespace EspacoTP
{
    partial class FrmAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlunos));
            this.grpAlunosExp = new System.Windows.Forms.GroupBox();
            this.grpTelefonePrincipal = new System.Windows.Forms.GroupBox();
            this.lbTipoTelefone = new System.Windows.Forms.Label();
            this.cboTipoTelefone = new System.Windows.Forms.ComboBox();
            this.lbNumeroTelefone = new System.Windows.Forms.Label();
            this.txtNumeroTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lbSobrenome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnFrequencia = new System.Windows.Forms.Button();
            this.btnBuscarAlunos = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.grpAlunosReg = new System.Windows.Forms.GroupBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lbMunicipio = new System.Windows.Forms.Label();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lbNumeroResidencia = new System.Windows.Forms.Label();
            this.txtNumeroResidencia = new System.Windows.Forms.TextBox();
            this.lbLogradouro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lbCEP = new System.Windows.Forms.Label();
            this.grpPeriodoContrato = new System.Windows.Forms.GroupBox();
            this.dtpDataTerminoContratoAnterior = new System.Windows.Forms.DateTimePicker();
            this.lbDataTerminoContratoAnterior = new System.Windows.Forms.Label();
            this.btnPeriodos = new System.Windows.Forms.Button();
            this.dtpDataTerminoContrato = new System.Windows.Forms.DateTimePicker();
            this.lbDataTerminoContrato = new System.Windows.Forms.Label();
            this.dtpDataInicioContrato = new System.Windows.Forms.DateTimePicker();
            this.lbDataInicioContrato = new System.Windows.Forms.Label();
            this.grpAlunosExp.SuspendLayout();
            this.grpTelefonePrincipal.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.grpAlunosReg.SuspendLayout();
            this.grpPeriodoContrato.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAlunosExp
            // 
            this.grpAlunosExp.Controls.Add(this.grpTelefonePrincipal);
            this.grpAlunosExp.Controls.Add(this.txtEmail);
            this.grpAlunosExp.Controls.Add(this.lbEmail);
            this.grpAlunosExp.Controls.Add(this.lbCPF);
            this.grpAlunosExp.Controls.Add(this.txtCPF);
            this.grpAlunosExp.Controls.Add(this.lbSobrenome);
            this.grpAlunosExp.Controls.Add(this.txtSobrenome);
            this.grpAlunosExp.Controls.Add(this.lbNome);
            this.grpAlunosExp.Controls.Add(this.txtNome);
            this.grpAlunosExp.Controls.Add(this.btnProximo);
            this.grpAlunosExp.Controls.Add(this.btnAnterior);
            this.grpAlunosExp.Controls.Add(this.lbCodigo);
            this.grpAlunosExp.Controls.Add(this.txtCodigo);
            this.grpAlunosExp.Location = new System.Drawing.Point(12, 12);
            this.grpAlunosExp.Name = "grpAlunosExp";
            this.grpAlunosExp.Size = new System.Drawing.Size(546, 201);
            this.grpAlunosExp.TabIndex = 0;
            this.grpAlunosExp.TabStop = false;
            this.grpAlunosExp.Text = "Pré-Cadastro de Alunos";
            // 
            // grpTelefonePrincipal
            // 
            this.grpTelefonePrincipal.Controls.Add(this.lbTipoTelefone);
            this.grpTelefonePrincipal.Controls.Add(this.cboTipoTelefone);
            this.grpTelefonePrincipal.Controls.Add(this.lbNumeroTelefone);
            this.grpTelefonePrincipal.Controls.Add(this.txtNumeroTelefone);
            this.grpTelefonePrincipal.Location = new System.Drawing.Point(232, 74);
            this.grpTelefonePrincipal.Name = "grpTelefonePrincipal";
            this.grpTelefonePrincipal.Size = new System.Drawing.Size(300, 73);
            this.grpTelefonePrincipal.TabIndex = 10;
            this.grpTelefonePrincipal.TabStop = false;
            this.grpTelefonePrincipal.Text = "Telefone Principal";
            // 
            // lbTipoTelefone
            // 
            this.lbTipoTelefone.AutoSize = true;
            this.lbTipoTelefone.Location = new System.Drawing.Point(18, 20);
            this.lbTipoTelefone.Name = "lbTipoTelefone";
            this.lbTipoTelefone.Size = new System.Drawing.Size(28, 13);
            this.lbTipoTelefone.TabIndex = 0;
            this.lbTipoTelefone.Text = "Tipo";
            // 
            // cboTipoTelefone
            // 
            this.cboTipoTelefone.FormattingEnabled = true;
            this.cboTipoTelefone.Location = new System.Drawing.Point(18, 38);
            this.cboTipoTelefone.MaxLength = 10;
            this.cboTipoTelefone.Name = "cboTipoTelefone";
            this.cboTipoTelefone.Size = new System.Drawing.Size(87, 21);
            this.cboTipoTelefone.TabIndex = 1;
            this.cboTipoTelefone.SelectedIndexChanged += new System.EventHandler(this.cboTipoTelefone_SelectedIndexChanged);
            this.cboTipoTelefone.TextChanged += new System.EventHandler(this.cboTipoTelefone_TextChanged);
            this.cboTipoTelefone.Click += new System.EventHandler(this.cboTipoTelefone_Click);
            this.cboTipoTelefone.Leave += new System.EventHandler(this.cboTipoTelefone_Leave);
            // 
            // lbNumeroTelefone
            // 
            this.lbNumeroTelefone.AutoSize = true;
            this.lbNumeroTelefone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNumeroTelefone.Location = new System.Drawing.Point(120, 20);
            this.lbNumeroTelefone.Name = "lbNumeroTelefone";
            this.lbNumeroTelefone.Size = new System.Drawing.Size(49, 13);
            this.lbNumeroTelefone.TabIndex = 2;
            this.lbNumeroTelefone.Text = "Telefone";
            // 
            // txtNumeroTelefone
            // 
            this.txtNumeroTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroTelefone.Location = new System.Drawing.Point(120, 39);
            this.txtNumeroTelefone.MaxLength = 13;
            this.txtNumeroTelefone.Name = "txtNumeroTelefone";
            this.txtNumeroTelefone.Size = new System.Drawing.Size(166, 20);
            this.txtNumeroTelefone.TabIndex = 3;
            this.txtNumeroTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroTelefone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Location = new System.Drawing.Point(11, 169);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(521, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbEmail.Location = new System.Drawing.Point(12, 150);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "E-mail";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCPF.Location = new System.Drawing.Point(11, 95);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(27, 13);
            this.lbCPF.TabIndex = 8;
            this.lbCPF.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCPF.Location = new System.Drawing.Point(11, 114);
            this.txtCPF.MaxLength = 11;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(206, 20);
            this.txtCPF.TabIndex = 9;
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            // 
            // lbSobrenome
            // 
            this.lbSobrenome.AutoSize = true;
            this.lbSobrenome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbSobrenome.Location = new System.Drawing.Point(303, 29);
            this.lbSobrenome.Name = "lbSobrenome";
            this.lbSobrenome.Size = new System.Drawing.Size(61, 13);
            this.lbSobrenome.TabIndex = 6;
            this.lbSobrenome.Text = "Sobrenome";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSobrenome.Location = new System.Drawing.Point(303, 48);
            this.txtSobrenome.MaxLength = 20;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(229, 20);
            this.txtSobrenome.TabIndex = 7;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNome.Location = new System.Drawing.Point(151, 30);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 4;
            this.lbNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(151, 48);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(135, 20);
            this.txtNome.TabIndex = 5;
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.MintCream;
            this.btnProximo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnProximo.Location = new System.Drawing.Point(121, 47);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(23, 23);
            this.btnProximo.TabIndex = 3;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.MintCream;
            this.btnAnterior.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAnterior.Location = new System.Drawing.Point(95, 47);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(23, 23);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCodigo.Location = new System.Drawing.Point(11, 29);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(11, 48);
            this.txtCodigo.MaxLength = 11;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(77, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.BackColor = System.Drawing.Color.MintCream;
            this.pnlBotoes.Controls.Add(this.btnFrequencia);
            this.pnlBotoes.Controls.Add(this.btnBuscarAlunos);
            this.pnlBotoes.Controls.Add(this.btnAlterar);
            this.pnlBotoes.Controls.Add(this.btnIncluir);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Controls.Add(this.btnDesfazer);
            this.pnlBotoes.Location = new System.Drawing.Point(12, 483);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(546, 47);
            this.pnlBotoes.TabIndex = 3;
            // 
            // btnFrequencia
            // 
            this.btnFrequencia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFrequencia.Location = new System.Drawing.Point(263, 12);
            this.btnFrequencia.Name = "btnFrequencia";
            this.btnFrequencia.Size = new System.Drawing.Size(84, 23);
            this.btnFrequencia.TabIndex = 3;
            this.btnFrequencia.Text = "&Frequência";
            this.btnFrequencia.UseVisualStyleBackColor = true;
            this.btnFrequencia.Visible = false;
            this.btnFrequencia.Click += new System.EventHandler(this.btnFrequencia_Click);
            // 
            // btnBuscarAlunos
            // 
            this.btnBuscarAlunos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBuscarAlunos.Location = new System.Drawing.Point(7, 12);
            this.btnBuscarAlunos.Name = "btnBuscarAlunos";
            this.btnBuscarAlunos.Size = new System.Drawing.Size(84, 23);
            this.btnBuscarAlunos.TabIndex = 0;
            this.btnBuscarAlunos.Text = "&Buscar Aluno";
            this.btnBuscarAlunos.UseVisualStyleBackColor = true;
            this.btnBuscarAlunos.Click += new System.EventHandler(this.btnBuscarAlunos_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAlterar.Location = new System.Drawing.Point(177, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(84, 23);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnIncluir.Location = new System.Drawing.Point(92, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(84, 23);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalvar.Location = new System.Drawing.Point(453, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDesfazer.Location = new System.Drawing.Point(366, 12);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(84, 23);
            this.btnDesfazer.TabIndex = 4;
            this.btnDesfazer.Text = "&Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // grpAlunosReg
            // 
            this.grpAlunosReg.Controls.Add(this.txtCEP);
            this.grpAlunosReg.Controls.Add(this.lbEstado);
            this.grpAlunosReg.Controls.Add(this.cboEstado);
            this.grpAlunosReg.Controls.Add(this.lbMunicipio);
            this.grpAlunosReg.Controls.Add(this.txtMunicipio);
            this.grpAlunosReg.Controls.Add(this.lbBairro);
            this.grpAlunosReg.Controls.Add(this.txtBairro);
            this.grpAlunosReg.Controls.Add(this.lbNumeroResidencia);
            this.grpAlunosReg.Controls.Add(this.txtNumeroResidencia);
            this.grpAlunosReg.Controls.Add(this.lbLogradouro);
            this.grpAlunosReg.Controls.Add(this.txtLogradouro);
            this.grpAlunosReg.Controls.Add(this.lbCEP);
            this.grpAlunosReg.Location = new System.Drawing.Point(12, 295);
            this.grpAlunosReg.Name = "grpAlunosReg";
            this.grpAlunosReg.Size = new System.Drawing.Size(546, 174);
            this.grpAlunosReg.TabIndex = 2;
            this.grpAlunosReg.TabStop = false;
            this.grpAlunosReg.Text = "Dados Complementares";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(11, 38);
            this.txtCEP.Mask = "99999-999";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCEP.Size = new System.Drawing.Size(77, 20);
            this.txtCEP.TabIndex = 1;
            this.txtCEP.TextChanged += new System.EventHandler(this.txtCEP_TextChanged);
            this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(481, 66);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(40, 13);
            this.lbEstado.TabIndex = 8;
            this.lbEstado.Text = "Estado";
            // 
            // cboEstado
            // 
            this.cboEstado.Enabled = false;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(481, 82);
            this.cboEstado.MaxLength = 8;
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(51, 21);
            this.cboEstado.TabIndex = 9;
            this.cboEstado.Text = "SP";
            // 
            // lbMunicipio
            // 
            this.lbMunicipio.AutoSize = true;
            this.lbMunicipio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMunicipio.Location = new System.Drawing.Point(14, 117);
            this.lbMunicipio.Name = "lbMunicipio";
            this.lbMunicipio.Size = new System.Drawing.Size(52, 13);
            this.lbMunicipio.TabIndex = 10;
            this.lbMunicipio.Text = "Municipio";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMunicipio.Location = new System.Drawing.Point(11, 133);
            this.txtMunicipio.MaxLength = 30;
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(521, 20);
            this.txtMunicipio.TabIndex = 11;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBairro.Location = new System.Drawing.Point(96, 67);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(34, 13);
            this.lbBairro.TabIndex = 6;
            this.lbBairro.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(96, 83);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(367, 20);
            this.txtBairro.TabIndex = 7;
            // 
            // lbNumeroResidencia
            // 
            this.lbNumeroResidencia.AutoSize = true;
            this.lbNumeroResidencia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbNumeroResidencia.Location = new System.Drawing.Point(13, 67);
            this.lbNumeroResidencia.Name = "lbNumeroResidencia";
            this.lbNumeroResidencia.Size = new System.Drawing.Size(44, 13);
            this.lbNumeroResidencia.TabIndex = 4;
            this.lbNumeroResidencia.Text = "Número";
            // 
            // txtNumeroResidencia
            // 
            this.txtNumeroResidencia.Location = new System.Drawing.Point(11, 83);
            this.txtNumeroResidencia.MaxLength = 6;
            this.txtNumeroResidencia.Name = "txtNumeroResidencia";
            this.txtNumeroResidencia.Size = new System.Drawing.Size(77, 20);
            this.txtNumeroResidencia.TabIndex = 5;
            this.txtNumeroResidencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroResidencia_KeyPress);
            // 
            // lbLogradouro
            // 
            this.lbLogradouro.AutoSize = true;
            this.lbLogradouro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbLogradouro.Location = new System.Drawing.Point(96, 22);
            this.lbLogradouro.Name = "lbLogradouro";
            this.lbLogradouro.Size = new System.Drawing.Size(61, 13);
            this.lbLogradouro.TabIndex = 2;
            this.lbLogradouro.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogradouro.Location = new System.Drawing.Point(96, 38);
            this.txtLogradouro.MaxLength = 120;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(436, 20);
            this.txtLogradouro.TabIndex = 3;
            // 
            // lbCEP
            // 
            this.lbCEP.AutoSize = true;
            this.lbCEP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbCEP.Location = new System.Drawing.Point(11, 22);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(28, 13);
            this.lbCEP.TabIndex = 0;
            this.lbCEP.Text = "CEP";
            // 
            // grpPeriodoContrato
            // 
            this.grpPeriodoContrato.Controls.Add(this.dtpDataTerminoContratoAnterior);
            this.grpPeriodoContrato.Controls.Add(this.lbDataTerminoContratoAnterior);
            this.grpPeriodoContrato.Controls.Add(this.btnPeriodos);
            this.grpPeriodoContrato.Controls.Add(this.dtpDataTerminoContrato);
            this.grpPeriodoContrato.Controls.Add(this.lbDataTerminoContrato);
            this.grpPeriodoContrato.Controls.Add(this.dtpDataInicioContrato);
            this.grpPeriodoContrato.Controls.Add(this.lbDataInicioContrato);
            this.grpPeriodoContrato.Location = new System.Drawing.Point(12, 221);
            this.grpPeriodoContrato.Name = "grpPeriodoContrato";
            this.grpPeriodoContrato.Size = new System.Drawing.Size(546, 66);
            this.grpPeriodoContrato.TabIndex = 1;
            this.grpPeriodoContrato.TabStop = false;
            this.grpPeriodoContrato.Text = "Período Vigência Contrato";
            // 
            // dtpDataTerminoContratoAnterior
            // 
            this.dtpDataTerminoContratoAnterior.Enabled = false;
            this.dtpDataTerminoContratoAnterior.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataTerminoContratoAnterior.Location = new System.Drawing.Point(256, 35);
            this.dtpDataTerminoContratoAnterior.MaxDate = new System.DateTime(2120, 12, 31, 0, 0, 0, 0);
            this.dtpDataTerminoContratoAnterior.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtpDataTerminoContratoAnterior.Name = "dtpDataTerminoContratoAnterior";
            this.dtpDataTerminoContratoAnterior.Size = new System.Drawing.Size(106, 20);
            this.dtpDataTerminoContratoAnterior.TabIndex = 5;
            this.dtpDataTerminoContratoAnterior.Visible = false;
            // 
            // lbDataTerminoContratoAnterior
            // 
            this.lbDataTerminoContratoAnterior.AutoSize = true;
            this.lbDataTerminoContratoAnterior.Enabled = false;
            this.lbDataTerminoContratoAnterior.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDataTerminoContratoAnterior.Location = new System.Drawing.Point(256, 18);
            this.lbDataTerminoContratoAnterior.Name = "lbDataTerminoContratoAnterior";
            this.lbDataTerminoContratoAnterior.Size = new System.Drawing.Size(110, 13);
            this.lbDataTerminoContratoAnterior.TabIndex = 4;
            this.lbDataTerminoContratoAnterior.Text = "Data Término Anterior";
            this.lbDataTerminoContratoAnterior.Visible = false;
            // 
            // btnPeriodos
            // 
            this.btnPeriodos.BackColor = System.Drawing.Color.MintCream;
            this.btnPeriodos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPeriodos.Location = new System.Drawing.Point(448, 25);
            this.btnPeriodos.Name = "btnPeriodos";
            this.btnPeriodos.Size = new System.Drawing.Size(84, 23);
            this.btnPeriodos.TabIndex = 6;
            this.btnPeriodos.Text = "&Períodos";
            this.btnPeriodos.UseVisualStyleBackColor = false;
            this.btnPeriodos.Click += new System.EventHandler(this.btnPeriodos_Click);
            // 
            // dtpDataTerminoContrato
            // 
            this.dtpDataTerminoContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataTerminoContrato.Location = new System.Drawing.Point(137, 35);
            this.dtpDataTerminoContrato.MaxDate = new System.DateTime(2120, 12, 31, 0, 0, 0, 0);
            this.dtpDataTerminoContrato.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtpDataTerminoContrato.Name = "dtpDataTerminoContrato";
            this.dtpDataTerminoContrato.Size = new System.Drawing.Size(106, 20);
            this.dtpDataTerminoContrato.TabIndex = 3;
            // 
            // lbDataTerminoContrato
            // 
            this.lbDataTerminoContrato.AutoSize = true;
            this.lbDataTerminoContrato.Location = new System.Drawing.Point(137, 18);
            this.lbDataTerminoContrato.Name = "lbDataTerminoContrato";
            this.lbDataTerminoContrato.Size = new System.Drawing.Size(23, 13);
            this.lbDataTerminoContrato.TabIndex = 2;
            this.lbDataTerminoContrato.Text = "Até";
            // 
            // dtpDataInicioContrato
            // 
            this.dtpDataInicioContrato.Enabled = false;
            this.dtpDataInicioContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicioContrato.Location = new System.Drawing.Point(19, 35);
            this.dtpDataInicioContrato.MaxDate = new System.DateTime(2120, 12, 31, 0, 0, 0, 0);
            this.dtpDataInicioContrato.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtpDataInicioContrato.Name = "dtpDataInicioContrato";
            this.dtpDataInicioContrato.Size = new System.Drawing.Size(106, 20);
            this.dtpDataInicioContrato.TabIndex = 1;
            // 
            // lbDataInicioContrato
            // 
            this.lbDataInicioContrato.AutoSize = true;
            this.lbDataInicioContrato.Location = new System.Drawing.Point(19, 18);
            this.lbDataInicioContrato.Name = "lbDataInicioContrato";
            this.lbDataInicioContrato.Size = new System.Drawing.Size(21, 13);
            this.lbDataInicioContrato.TabIndex = 0;
            this.lbDataInicioContrato.Text = "De";
            // 
            // FrmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 555);
            this.Controls.Add(this.grpPeriodoContrato);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.grpAlunosReg);
            this.Controls.Add(this.grpAlunosExp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ESPAÇO TP - ALUNOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAlunos_FormClosing);
            this.Load += new System.EventHandler(this.FrmAlunos_Load);
            this.grpAlunosExp.ResumeLayout(false);
            this.grpAlunosExp.PerformLayout();
            this.grpTelefonePrincipal.ResumeLayout(false);
            this.grpTelefonePrincipal.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.grpAlunosReg.ResumeLayout(false);
            this.grpAlunosReg.PerformLayout();
            this.grpPeriodoContrato.ResumeLayout(false);
            this.grpPeriodoContrato.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAlunosExp;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Button btnDesfazer;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.GroupBox grpAlunosReg;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbCEP;
        private System.Windows.Forms.Label lbLogradouro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Label lbSobrenome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNumeroResidencia;
        private System.Windows.Forms.TextBox txtNumeroResidencia;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lbMunicipio;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Button btnFrequencia;
        private System.Windows.Forms.Button btnBuscarAlunos;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox grpPeriodoContrato;
        private System.Windows.Forms.Button btnPeriodos;
        private System.Windows.Forms.DateTimePicker dtpDataTerminoContrato;
        private System.Windows.Forms.Label lbDataTerminoContrato;
        private System.Windows.Forms.DateTimePicker dtpDataInicioContrato;
        private System.Windows.Forms.Label lbDataInicioContrato;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.GroupBox grpTelefonePrincipal;
        private System.Windows.Forms.Label lbTipoTelefone;
        private System.Windows.Forms.ComboBox cboTipoTelefone;
        private System.Windows.Forms.Label lbNumeroTelefone;
        private System.Windows.Forms.TextBox txtNumeroTelefone;
        private System.Windows.Forms.Label lbDataTerminoContratoAnterior;
        private System.Windows.Forms.DateTimePicker dtpDataTerminoContratoAnterior;
        private System.Windows.Forms.MaskedTextBox txtCEP;
    }
}