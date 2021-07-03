namespace CamadaUI.Membros
{
	partial class frmMembro
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
			this.txtCongregacao = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.lblCongregacao = new System.Windows.Forms.Label();
			this.txtMembroNome = new System.Windows.Forms.TextBox();
			this.lblID = new System.Windows.Forms.Label();
			this.lbl_IdTexto = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtRGMembro = new System.Windows.Forms.TextBox();
			this.tspMenu = new System.Windows.Forms.ToolStrip();
			this.btnNovo = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSalvar = new System.Windows.Forms.ToolStripButton();
			this.btnCancelar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnFechar = new System.Windows.Forms.ToolStripButton();
			this.btnCongregacaoEscolher = new System.Windows.Forms.Button();
			this.line1 = new AwesomeShapeControl.Line();
			this.cmbSexo = new CamadaUC.ucComboLimitedValues();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpNascimentoData = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpMembresiaData = new System.Windows.Forms.DateTimePicker();
			this.txtEstadoCivil = new System.Windows.Forms.TextBox();
			this.lblEstCivil = new System.Windows.Forms.Label();
			this.btnSetEstadoCivil = new System.Windows.Forms.Button();
			this.btnSetFuncao = new System.Windows.Forms.Button();
			this.lblFunção = new System.Windows.Forms.Label();
			this.txtFuncao = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.picFoto = new System.Windows.Forms.PictureBox();
			this.btnAnexarFoto = new System.Windows.Forms.Button();
			this.lblProgress = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.panel1.SuspendLayout();
			this.tspMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(417, 0);
			this.lblTitulo.Size = new System.Drawing.Size(299, 50);
			this.lblTitulo.TabIndex = 2;
			this.lblTitulo.Text = "Cadastro de Membro";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(716, 0);
			this.btnClose.TabIndex = 3;
			this.btnClose.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblID);
			this.panel1.Controls.Add(this.lbl_IdTexto);
			this.panel1.Size = new System.Drawing.Size(756, 50);
			this.panel1.Controls.SetChildIndex(this.btnClose, 0);
			this.panel1.Controls.SetChildIndex(this.lblTitulo, 0);
			this.panel1.Controls.SetChildIndex(this.lbl_IdTexto, 0);
			this.panel1.Controls.SetChildIndex(this.lblID, 0);
			// 
			// txtCongregacao
			// 
			this.txtCongregacao.Location = new System.Drawing.Point(127, 231);
			this.txtCongregacao.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtCongregacao.MaxLength = 30;
			this.txtCongregacao.Name = "txtCongregacao";
			this.txtCongregacao.Size = new System.Drawing.Size(265, 27);
			this.txtCongregacao.TabIndex = 11;
			this.txtCongregacao.Tag = "Pressione a tecla (+) para procurar";
			this.txtCongregacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
			// 
			// Label6
			// 
			this.Label6.AutoSize = true;
			this.Label6.BackColor = System.Drawing.Color.Transparent;
			this.Label6.ForeColor = System.Drawing.Color.Black;
			this.Label6.Location = new System.Drawing.Point(27, 235);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(94, 19);
			this.Label6.TabIndex = 10;
			this.Label6.Text = "Congregação";
			// 
			// Label15
			// 
			this.Label15.AutoSize = true;
			this.Label15.BackColor = System.Drawing.Color.Transparent;
			this.Label15.ForeColor = System.Drawing.Color.Black;
			this.Label15.Location = new System.Drawing.Point(240, 148);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(105, 19);
			this.Label15.TabIndex = 7;
			this.Label15.Text = "Dt Nascimento";
			// 
			// lblCongregacao
			// 
			this.lblCongregacao.AutoSize = true;
			this.lblCongregacao.BackColor = System.Drawing.Color.Transparent;
			this.lblCongregacao.ForeColor = System.Drawing.Color.Black;
			this.lblCongregacao.Location = new System.Drawing.Point(58, 112);
			this.lblCongregacao.Name = "lblCongregacao";
			this.lblCongregacao.Size = new System.Drawing.Size(63, 19);
			this.lblCongregacao.TabIndex = 3;
			this.lblCongregacao.Text = "Membro";
			// 
			// txtMembroNome
			// 
			this.txtMembroNome.BackColor = System.Drawing.Color.White;
			this.txtMembroNome.Location = new System.Drawing.Point(127, 109);
			this.txtMembroNome.MaxLength = 100;
			this.txtMembroNome.Name = "txtMembroNome";
			this.txtMembroNome.Size = new System.Drawing.Size(348, 27);
			this.txtMembroNome.TabIndex = 4;
			// 
			// lblID
			// 
			this.lblID.BackColor = System.Drawing.Color.Transparent;
			this.lblID.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblID.ForeColor = System.Drawing.Color.AliceBlue;
			this.lblID.Location = new System.Drawing.Point(4, 18);
			this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(94, 30);
			this.lblID.TabIndex = 0;
			this.lblID.Text = "0001";
			this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_IdTexto
			// 
			this.lbl_IdTexto.AutoSize = true;
			this.lbl_IdTexto.BackColor = System.Drawing.Color.Transparent;
			this.lbl_IdTexto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_IdTexto.ForeColor = System.Drawing.Color.LightGray;
			this.lbl_IdTexto.Location = new System.Drawing.Point(31, 5);
			this.lbl_IdTexto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_IdTexto.Name = "lbl_IdTexto";
			this.lbl_IdTexto.Size = new System.Drawing.Size(35, 13);
			this.lbl_IdTexto.TabIndex = 1;
			this.lbl_IdTexto.Text = "Reg.";
			this.lbl_IdTexto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(82, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 19);
			this.label3.TabIndex = 1;
			this.label3.Text = "Reg.";
			// 
			// txtRGMembro
			// 
			this.txtRGMembro.BackColor = System.Drawing.Color.White;
			this.txtRGMembro.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRGMembro.Location = new System.Drawing.Point(127, 69);
			this.txtRGMembro.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtRGMembro.MaxLength = 50;
			this.txtRGMembro.Name = "txtRGMembro";
			this.txtRGMembro.Size = new System.Drawing.Size(81, 31);
			this.txtRGMembro.TabIndex = 2;
			this.txtRGMembro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDMembro_KeyPress);
			this.txtRGMembro.Validating += new System.ComponentModel.CancelEventHandler(this.txtIDMembro_Validating);
			// 
			// tspMenu
			// 
			this.tspMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tspMenu.AutoSize = false;
			this.tspMenu.BackColor = System.Drawing.Color.AntiqueWhite;
			this.tspMenu.Dock = System.Windows.Forms.DockStyle.None;
			this.tspMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.toolStripSeparator1,
            this.btnSalvar,
            this.btnCancelar,
            this.toolStripSeparator2,
            this.btnFechar});
			this.tspMenu.Location = new System.Drawing.Point(2, 416);
			this.tspMenu.Name = "tspMenu";
			this.tspMenu.Size = new System.Drawing.Size(751, 44);
			this.tspMenu.TabIndex = 21;
			this.tspMenu.TabStop = true;
			this.tspMenu.Text = "toolStrip1";
			// 
			// btnNovo
			// 
			this.btnNovo.Image = global::CamadaUI.Properties.Resources.adicionar_30;
			this.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNovo.Name = "btnNovo";
			this.btnNovo.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnNovo.Size = new System.Drawing.Size(86, 41);
			this.btnNovo.Text = "&Novo";
			this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNovo.ToolTipText = "Novo Membro";
			this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Image = global::CamadaUI.Properties.Resources.salvar_30;
			this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnSalvar.Size = new System.Drawing.Size(92, 41);
			this.btnSalvar.Text = "&Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Image = global::CamadaUI.Properties.Resources.delete_page_30;
			this.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnCancelar.Size = new System.Drawing.Size(110, 41);
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 44);
			// 
			// btnFechar
			// 
			this.btnFechar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnFechar.Image = global::CamadaUI.Properties.Resources.fechar_30;
			this.btnFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.btnFechar.Size = new System.Drawing.Size(96, 41);
			this.btnFechar.Text = "&Fechar";
			this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// btnCongregacaoEscolher
			// 
			this.btnCongregacaoEscolher.BackColor = System.Drawing.Color.Transparent;
			this.btnCongregacaoEscolher.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCongregacaoEscolher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCongregacaoEscolher.Location = new System.Drawing.Point(398, 231);
			this.btnCongregacaoEscolher.Name = "btnCongregacaoEscolher";
			this.btnCongregacaoEscolher.Size = new System.Drawing.Size(34, 27);
			this.btnCongregacaoEscolher.TabIndex = 12;
			this.btnCongregacaoEscolher.TabStop = false;
			this.btnCongregacaoEscolher.Text = "...";
			this.btnCongregacaoEscolher.UseCompatibleTextRendering = true;
			this.btnCongregacaoEscolher.UseVisualStyleBackColor = false;
			this.btnCongregacaoEscolher.Click += new System.EventHandler(this.btnCongregacaoEscolher_Click);
			// 
			// line1
			// 
			this.line1.EndPoint = new System.Drawing.Point(495, 5);
			this.line1.LineColor = System.Drawing.Color.SlateGray;
			this.line1.LineWidth = 3F;
			this.line1.Location = new System.Drawing.Point(20, 196);
			this.line1.Name = "line1";
			this.line1.Size = new System.Drawing.Size(500, 10);
			this.line1.StartPoint = new System.Drawing.Point(5, 5);
			this.line1.TabIndex = 9;
			this.line1.TabStop = false;
			// 
			// cmbSexo
			// 
			this.cmbSexo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbSexo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbSexo.FormattingEnabled = true;
			this.cmbSexo.Location = new System.Drawing.Point(127, 145);
			this.cmbSexo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.cmbSexo.Name = "cmbSexo";
			this.cmbSexo.Size = new System.Drawing.Size(75, 27);
			this.cmbSexo.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(82, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "Sexo";
			// 
			// dtpNascimentoData
			// 
			this.dtpNascimentoData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpNascimentoData.Location = new System.Drawing.Point(351, 145);
			this.dtpNascimentoData.Name = "dtpNascimentoData";
			this.dtpNascimentoData.Size = new System.Drawing.Size(124, 27);
			this.dtpNascimentoData.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(20, 369);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 19);
			this.label4.TabIndex = 19;
			this.label4.Text = "Dt Membresia";
			// 
			// dtpMembresiaData
			// 
			this.dtpMembresiaData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpMembresiaData.Location = new System.Drawing.Point(127, 365);
			this.dtpMembresiaData.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtpMembresiaData.Name = "dtpMembresiaData";
			this.dtpMembresiaData.Size = new System.Drawing.Size(124, 27);
			this.dtpMembresiaData.TabIndex = 20;
			// 
			// txtEstadoCivil
			// 
			this.txtEstadoCivil.Location = new System.Drawing.Point(127, 268);
			this.txtEstadoCivil.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtEstadoCivil.MaxLength = 30;
			this.txtEstadoCivil.Name = "txtEstadoCivil";
			this.txtEstadoCivil.Size = new System.Drawing.Size(153, 27);
			this.txtEstadoCivil.TabIndex = 14;
			this.txtEstadoCivil.Tag = "Pressione a tecla (+) para procurar";
			this.txtEstadoCivil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
			this.txtEstadoCivil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_KeyPress);
			// 
			// lblEstCivil
			// 
			this.lblEstCivil.AutoSize = true;
			this.lblEstCivil.BackColor = System.Drawing.Color.Transparent;
			this.lblEstCivil.ForeColor = System.Drawing.Color.Black;
			this.lblEstCivil.Location = new System.Drawing.Point(36, 272);
			this.lblEstCivil.Name = "lblEstCivil";
			this.lblEstCivil.Size = new System.Drawing.Size(85, 19);
			this.lblEstCivil.TabIndex = 13;
			this.lblEstCivil.Text = "Estado Civil";
			// 
			// btnSetEstadoCivil
			// 
			this.btnSetEstadoCivil.BackColor = System.Drawing.Color.Transparent;
			this.btnSetEstadoCivil.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSetEstadoCivil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSetEstadoCivil.Location = new System.Drawing.Point(289, 268);
			this.btnSetEstadoCivil.Name = "btnSetEstadoCivil";
			this.btnSetEstadoCivil.Size = new System.Drawing.Size(34, 27);
			this.btnSetEstadoCivil.TabIndex = 15;
			this.btnSetEstadoCivil.TabStop = false;
			this.btnSetEstadoCivil.Text = "...";
			this.btnSetEstadoCivil.UseCompatibleTextRendering = true;
			this.btnSetEstadoCivil.UseVisualStyleBackColor = false;
			this.btnSetEstadoCivil.Click += new System.EventHandler(this.btnSetEstadoCivil_Click);
			// 
			// btnSetFuncao
			// 
			this.btnSetFuncao.BackColor = System.Drawing.Color.Transparent;
			this.btnSetFuncao.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSetFuncao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSetFuncao.Location = new System.Drawing.Point(289, 307);
			this.btnSetFuncao.Name = "btnSetFuncao";
			this.btnSetFuncao.Size = new System.Drawing.Size(34, 27);
			this.btnSetFuncao.TabIndex = 18;
			this.btnSetFuncao.TabStop = false;
			this.btnSetFuncao.Text = "...";
			this.btnSetFuncao.UseCompatibleTextRendering = true;
			this.btnSetFuncao.UseVisualStyleBackColor = false;
			this.btnSetFuncao.Click += new System.EventHandler(this.btnSetFuncao_Click);
			// 
			// lblFunção
			// 
			this.lblFunção.AutoSize = true;
			this.lblFunção.BackColor = System.Drawing.Color.Transparent;
			this.lblFunção.ForeColor = System.Drawing.Color.Black;
			this.lblFunção.Location = new System.Drawing.Point(65, 311);
			this.lblFunção.Name = "lblFunção";
			this.lblFunção.Size = new System.Drawing.Size(55, 19);
			this.lblFunção.TabIndex = 16;
			this.lblFunção.Text = "Função";
			// 
			// txtFuncao
			// 
			this.txtFuncao.Location = new System.Drawing.Point(127, 307);
			this.txtFuncao.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtFuncao.MaxLength = 30;
			this.txtFuncao.Name = "txtFuncao";
			this.txtFuncao.Size = new System.Drawing.Size(153, 27);
			this.txtFuncao.TabIndex = 17;
			this.txtFuncao.Tag = "Pressione a tecla (+) para procurar";
			this.txtFuncao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
			this.txtFuncao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(328, 274);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "(nº 1 a 4)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(328, 313);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "(nº 1 a 8)";
			// 
			// picFoto
			// 
			this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picFoto.Image = global::CamadaUI.Properties.Resources.loading;
			this.picFoto.InitialImage = null;
			this.picFoto.Location = new System.Drawing.Point(545, 92);
			this.picFoto.Name = "picFoto";
			this.picFoto.Size = new System.Drawing.Size(180, 240);
			this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picFoto.TabIndex = 22;
			this.picFoto.TabStop = false;
			// 
			// btnAnexarFoto
			// 
			this.btnAnexarFoto.BackColor = System.Drawing.Color.White;
			this.btnAnexarFoto.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnAnexarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAnexarFoto.Image = global::CamadaUI.Properties.Resources.attachment;
			this.btnAnexarFoto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAnexarFoto.Location = new System.Drawing.Point(545, 338);
			this.btnAnexarFoto.Name = "btnAnexarFoto";
			this.btnAnexarFoto.Size = new System.Drawing.Size(180, 35);
			this.btnAnexarFoto.TabIndex = 12;
			this.btnAnexarFoto.TabStop = false;
			this.btnAnexarFoto.Text = "Anexar Foto";
			this.btnAnexarFoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAnexarFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAnexarFoto.UseCompatibleTextRendering = true;
			this.btnAnexarFoto.UseVisualStyleBackColor = false;
			this.btnAnexarFoto.Click += new System.EventHandler(this.btnAnexarFoto_Click);
			// 
			// lblProgress
			// 
			this.lblProgress.AutoSize = true;
			this.lblProgress.BackColor = System.Drawing.Color.Transparent;
			this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.lblProgress.ForeColor = System.Drawing.Color.Black;
			this.lblProgress.Location = new System.Drawing.Point(344, 383);
			this.lblProgress.Name = "lblProgress";
			this.lblProgress.Size = new System.Drawing.Size(120, 17);
			this.lblProgress.TabIndex = 104;
			this.lblProgress.Text = "DownLoading...";
			// 
			// progressBar
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar.Location = new System.Drawing.Point(473, 379);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(252, 23);
			this.progressBar.TabIndex = 103;
			// 
			// frmMembro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(756, 462);
			this.Controls.Add(this.lblProgress);
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.picFoto);
			this.Controls.Add(this.txtFuncao);
			this.Controls.Add(this.lblFunção);
			this.Controls.Add(this.txtEstadoCivil);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblEstCivil);
			this.Controls.Add(this.dtpMembresiaData);
			this.Controls.Add(this.dtpNascimentoData);
			this.Controls.Add(this.cmbSexo);
			this.Controls.Add(this.btnSetFuncao);
			this.Controls.Add(this.line1);
			this.Controls.Add(this.btnSetEstadoCivil);
			this.Controls.Add(this.btnAnexarFoto);
			this.Controls.Add(this.btnCongregacaoEscolher);
			this.Controls.Add(this.tspMenu);
			this.Controls.Add(this.txtMembroNome);
			this.Controls.Add(this.txtRGMembro);
			this.Controls.Add(this.txtCongregacao);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Label15);
			this.Controls.Add(this.lblCongregacao);
			this.Controls.Add(this.label3);
			this.KeyPreview = true;
			this.Name = "frmMembro";
			this.Activated += new System.EventHandler(this.form_Activated);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_FormClosed);
			this.Shown += new System.EventHandler(this.frmMembro_Shown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMembro_KeyPress);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.lblCongregacao, 0);
			this.Controls.SetChildIndex(this.Label15, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.Label6, 0);
			this.Controls.SetChildIndex(this.txtCongregacao, 0);
			this.Controls.SetChildIndex(this.txtRGMembro, 0);
			this.Controls.SetChildIndex(this.txtMembroNome, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.tspMenu, 0);
			this.Controls.SetChildIndex(this.btnCongregacaoEscolher, 0);
			this.Controls.SetChildIndex(this.btnAnexarFoto, 0);
			this.Controls.SetChildIndex(this.btnSetEstadoCivil, 0);
			this.Controls.SetChildIndex(this.line1, 0);
			this.Controls.SetChildIndex(this.btnSetFuncao, 0);
			this.Controls.SetChildIndex(this.cmbSexo, 0);
			this.Controls.SetChildIndex(this.dtpNascimentoData, 0);
			this.Controls.SetChildIndex(this.dtpMembresiaData, 0);
			this.Controls.SetChildIndex(this.lblEstCivil, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.txtEstadoCivil, 0);
			this.Controls.SetChildIndex(this.lblFunção, 0);
			this.Controls.SetChildIndex(this.txtFuncao, 0);
			this.Controls.SetChildIndex(this.picFoto, 0);
			this.Controls.SetChildIndex(this.progressBar, 0);
			this.Controls.SetChildIndex(this.lblProgress, 0);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tspMenu.ResumeLayout(false);
			this.tspMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		internal System.Windows.Forms.TextBox txtCongregacao;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Label lblCongregacao;
		internal System.Windows.Forms.TextBox txtMembroNome;
		internal System.Windows.Forms.Label lblID;
		internal System.Windows.Forms.Label lbl_IdTexto;
		internal System.Windows.Forms.Label label3;
		internal System.Windows.Forms.TextBox txtRGMembro;
		private System.Windows.Forms.ToolStrip tspMenu;
		private System.Windows.Forms.ToolStripButton btnNovo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnSalvar;
		private System.Windows.Forms.ToolStripButton btnCancelar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnFechar;
		internal System.Windows.Forms.Button btnCongregacaoEscolher;
		private AwesomeShapeControl.Line line1;
		private CamadaUC.ucComboLimitedValues cmbSexo;
		internal System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpNascimentoData;
		internal System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpMembresiaData;
		internal System.Windows.Forms.TextBox txtEstadoCivil;
		internal System.Windows.Forms.Label lblEstCivil;
		internal System.Windows.Forms.Button btnSetEstadoCivil;
		internal System.Windows.Forms.Button btnSetFuncao;
		internal System.Windows.Forms.Label lblFunção;
		internal System.Windows.Forms.TextBox txtFuncao;
		internal System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox picFoto;
		internal System.Windows.Forms.Button btnAnexarFoto;
		private System.Windows.Forms.Label lblProgress;
		private System.Windows.Forms.ProgressBar progressBar;
	}
}
