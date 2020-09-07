namespace CamadaUI.Config
{
	partial class frmConfigGeral
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
			this.btnSalvarConfig = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.pnlPastas = new System.Windows.Forms.Panel();
			this.btnBackupProjecoes = new System.Windows.Forms.Button();
			this.txtImageFolder = new System.Windows.Forms.TextBox();
			this.btnProcImageFolder = new System.Windows.Forms.Button();
			this.Label18 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtIgrejaTitulo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSetorEditar = new System.Windows.Forms.Button();
			this.btnContaEditar = new System.Windows.Forms.Button();
			this.Label34 = new System.Windows.Forms.Label();
			this.btnSetorAlterar = new System.Windows.Forms.Button();
			this.btnContaAlterar = new System.Windows.Forms.Button();
			this.lblCongregacao = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Label35 = new System.Windows.Forms.Label();
			this.dtpDataPadrao = new System.Windows.Forms.DateTimePicker();
			this.lblDataBloqueio = new System.Windows.Forms.Label();
			this.Label22 = new System.Windows.Forms.Label();
			this.txtUFPadrao = new System.Windows.Forms.TextBox();
			this.txtSetorPadrao = new System.Windows.Forms.TextBox();
			this.txtCidadePadrao = new System.Windows.Forms.TextBox();
			this.txtContaPadrao = new System.Windows.Forms.TextBox();
			this.glassButton1 = new Glass.GlassButton();
			this.mbGlassButton1 = new MBGlassStyleButton.MBGlassButton();
			this.panel1.SuspendLayout();
			this.pnlPastas.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.BackColor = System.Drawing.Color.SlateGray;
			this.lblTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 4);
			this.lblTitulo.Size = new System.Drawing.Size(704, 30);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Configuração Geral";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.SlateGray;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(704, 0);
			this.btnClose.TabIndex = 1;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(744, 30);
			// 
			// btnSalvarConfig
			// 
			this.btnSalvarConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSalvarConfig.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnSalvarConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnSalvarConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnSalvarConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvarConfig.Image = global::CamadaUI.Properties.Resources.save_24;
			this.btnSalvarConfig.Location = new System.Drawing.Point(484, 531);
			this.btnSalvarConfig.Margin = new System.Windows.Forms.Padding(6);
			this.btnSalvarConfig.Name = "btnSalvarConfig";
			this.btnSalvarConfig.Size = new System.Drawing.Size(121, 36);
			this.btnSalvarConfig.TabIndex = 2;
			this.btnSalvarConfig.Text = "&Salvar";
			this.btnSalvarConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvarConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvarConfig.UseVisualStyleBackColor = true;
			this.btnSalvarConfig.Click += new System.EventHandler(this.btnSalvarConfig_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Image = global::CamadaUI.Properties.Resources.delete_24;
			this.btnCancelar.Location = new System.Drawing.Point(611, 531);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(121, 36);
			this.btnCancelar.TabIndex = 3;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// pnlPastas
			// 
			this.pnlPastas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(221)))), ((int)(((byte)(234)))));
			this.pnlPastas.Controls.Add(this.glassButton1);
			this.pnlPastas.Controls.Add(this.btnBackupProjecoes);
			this.pnlPastas.Controls.Add(this.txtImageFolder);
			this.pnlPastas.Controls.Add(this.Label18);
			this.pnlPastas.Controls.Add(this.label4);
			this.pnlPastas.Controls.Add(this.txtIgrejaTitulo);
			this.pnlPastas.Controls.Add(this.label3);
			this.pnlPastas.Controls.Add(this.label1);
			this.pnlPastas.Controls.Add(this.btnSetorEditar);
			this.pnlPastas.Controls.Add(this.btnContaEditar);
			this.pnlPastas.Controls.Add(this.Label34);
			this.pnlPastas.Controls.Add(this.btnSetorAlterar);
			this.pnlPastas.Controls.Add(this.btnContaAlterar);
			this.pnlPastas.Controls.Add(this.lblCongregacao);
			this.pnlPastas.Controls.Add(this.Label15);
			this.pnlPastas.Controls.Add(this.label5);
			this.pnlPastas.Controls.Add(this.label6);
			this.pnlPastas.Controls.Add(this.label2);
			this.pnlPastas.Controls.Add(this.Label35);
			this.pnlPastas.Controls.Add(this.dtpDataPadrao);
			this.pnlPastas.Controls.Add(this.lblDataBloqueio);
			this.pnlPastas.Controls.Add(this.Label22);
			this.pnlPastas.Controls.Add(this.txtUFPadrao);
			this.pnlPastas.Controls.Add(this.txtSetorPadrao);
			this.pnlPastas.Controls.Add(this.txtCidadePadrao);
			this.pnlPastas.Controls.Add(this.txtContaPadrao);
			this.pnlPastas.Location = new System.Drawing.Point(12, 42);
			this.pnlPastas.Margin = new System.Windows.Forms.Padding(6);
			this.pnlPastas.Name = "pnlPastas";
			this.pnlPastas.Size = new System.Drawing.Size(720, 477);
			this.pnlPastas.TabIndex = 1;
			// 
			// btnBackupProjecoes
			// 
			this.btnBackupProjecoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBackupProjecoes.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnBackupProjecoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnBackupProjecoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnBackupProjecoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBackupProjecoes.Image = global::CamadaUI.Properties.Resources.backup_24;
			this.btnBackupProjecoes.Location = new System.Drawing.Point(429, 389);
			this.btnBackupProjecoes.Name = "btnBackupProjecoes";
			this.btnBackupProjecoes.Size = new System.Drawing.Size(208, 36);
			this.btnBackupProjecoes.TabIndex = 25;
			this.btnBackupProjecoes.Text = " &Backup Documentos";
			this.btnBackupProjecoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBackupProjecoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBackupProjecoes.UseVisualStyleBackColor = true;
			// 
			// txtImageFolder
			// 
			this.txtImageFolder.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtImageFolder.Location = new System.Drawing.Point(72, 357);
			this.txtImageFolder.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtImageFolder.MaxLength = 200;
			this.txtImageFolder.Name = "txtImageFolder";
			this.txtImageFolder.Size = new System.Drawing.Size(565, 27);
			this.txtImageFolder.TabIndex = 23;
			this.txtImageFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
			// 
			// btnProcImageFolder
			// 
			this.btnProcImageFolder.BackColor = System.Drawing.Color.Transparent;
			this.btnProcImageFolder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnProcImageFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProcImageFolder.Location = new System.Drawing.Point(288, 540);
			this.btnProcImageFolder.Name = "btnProcImageFolder";
			this.btnProcImageFolder.Size = new System.Drawing.Size(34, 27);
			this.btnProcImageFolder.TabIndex = 24;
			this.btnProcImageFolder.TabStop = false;
			this.btnProcImageFolder.Text = "...";
			this.btnProcImageFolder.UseCompatibleTextRendering = true;
			this.btnProcImageFolder.UseVisualStyleBackColor = false;
			this.btnProcImageFolder.Click += new System.EventHandler(this.btnProcImageFolder_Click);
			// 
			// Label18
			// 
			this.Label18.AutoSize = true;
			this.Label18.BackColor = System.Drawing.Color.Transparent;
			this.Label18.Font = new System.Drawing.Font("Calibri", 12F);
			this.Label18.Location = new System.Drawing.Point(19, 360);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(49, 19);
			this.Label18.TabIndex = 22;
			this.Label18.Text = "Pasta:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(70, 53);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 19);
			this.label4.TabIndex = 1;
			this.label4.Text = "Título da Igreja:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtIgrejaTitulo
			// 
			this.txtIgrejaTitulo.Font = new System.Drawing.Font("Verdana", 12F);
			this.txtIgrejaTitulo.Location = new System.Drawing.Point(187, 50);
			this.txtIgrejaTitulo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtIgrejaTitulo.Name = "txtIgrejaTitulo";
			this.txtIgrejaTitulo.Size = new System.Drawing.Size(490, 27);
			this.txtIgrejaTitulo.TabIndex = 2;
			this.txtIgrejaTitulo.Validating += new System.ComponentModel.CancelEventHandler(this.txtIgrejaTitulo_Validating);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(9, 319);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(287, 23);
			this.label3.TabIndex = 21;
			this.label3.Text = "Pasta das Imagens de Documentos:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Valores Padrão:";
			// 
			// btnSetorEditar
			// 
			this.btnSetorEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(221)))), ((int)(((byte)(234)))));
			this.btnSetorEditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSetorEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnSetorEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnSetorEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSetorEditar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSetorEditar.Image = global::CamadaUI.Properties.Resources.editar_16;
			this.btnSetorEditar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
			this.btnSetorEditar.Location = new System.Drawing.Point(605, 218);
			this.btnSetorEditar.Name = "btnSetorEditar";
			this.btnSetorEditar.Size = new System.Drawing.Size(72, 30);
			this.btnSetorEditar.TabIndex = 16;
			this.btnSetorEditar.TabStop = false;
			this.btnSetorEditar.Text = "Editar";
			this.btnSetorEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSetorEditar.UseVisualStyleBackColor = false;
			// 
			// btnContaEditar
			// 
			this.btnContaEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(221)))), ((int)(((byte)(234)))));
			this.btnContaEditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnContaEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnContaEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnContaEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnContaEditar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnContaEditar.Image = global::CamadaUI.Properties.Resources.editar_16;
			this.btnContaEditar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
			this.btnContaEditar.Location = new System.Drawing.Point(605, 126);
			this.btnContaEditar.Name = "btnContaEditar";
			this.btnContaEditar.Size = new System.Drawing.Size(72, 30);
			this.btnContaEditar.TabIndex = 8;
			this.btnContaEditar.TabStop = false;
			this.btnContaEditar.Text = "Editar";
			this.btnContaEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnContaEditar.UseVisualStyleBackColor = false;
			// 
			// Label34
			// 
			this.Label34.AutoSize = true;
			this.Label34.BackColor = System.Drawing.Color.Transparent;
			this.Label34.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label34.Location = new System.Drawing.Point(88, 93);
			this.Label34.Name = "Label34";
			this.Label34.Size = new System.Drawing.Size(93, 19);
			this.Label34.TabIndex = 3;
			this.Label34.Text = "Data Padrão:";
			this.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnSetorAlterar
			// 
			this.btnSetorAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(221)))), ((int)(((byte)(234)))));
			this.btnSetorAlterar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSetorAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnSetorAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnSetorAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSetorAlterar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSetorAlterar.Image = global::CamadaUI.Properties.Resources.refresh_16;
			this.btnSetorAlterar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
			this.btnSetorAlterar.Location = new System.Drawing.Point(527, 218);
			this.btnSetorAlterar.Name = "btnSetorAlterar";
			this.btnSetorAlterar.Size = new System.Drawing.Size(72, 30);
			this.btnSetorAlterar.TabIndex = 15;
			this.btnSetorAlterar.TabStop = false;
			this.btnSetorAlterar.Text = "Alterar";
			this.btnSetorAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSetorAlterar.UseVisualStyleBackColor = false;
			// 
			// btnContaAlterar
			// 
			this.btnContaAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(221)))), ((int)(((byte)(234)))));
			this.btnContaAlterar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnContaAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnContaAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnContaAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnContaAlterar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnContaAlterar.Image = global::CamadaUI.Properties.Resources.refresh_16;
			this.btnContaAlterar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
			this.btnContaAlterar.Location = new System.Drawing.Point(527, 126);
			this.btnContaAlterar.Name = "btnContaAlterar";
			this.btnContaAlterar.Size = new System.Drawing.Size(72, 30);
			this.btnContaAlterar.TabIndex = 7;
			this.btnContaAlterar.TabStop = false;
			this.btnContaAlterar.Text = "Alterar";
			this.btnContaAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnContaAlterar.UseVisualStyleBackColor = false;
			// 
			// lblCongregacao
			// 
			this.lblCongregacao.AutoSize = true;
			this.lblCongregacao.BackColor = System.Drawing.Color.Transparent;
			this.lblCongregacao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCongregacao.Location = new System.Drawing.Point(307, 162);
			this.lblCongregacao.Name = "lblCongregacao";
			this.lblCongregacao.Size = new System.Drawing.Size(94, 19);
			this.lblCongregacao.TabIndex = 9;
			this.lblCongregacao.Text = "Congregação";
			this.lblCongregacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label15
			// 
			this.Label15.AutoSize = true;
			this.Label15.BackColor = System.Drawing.Color.Transparent;
			this.Label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label15.Location = new System.Drawing.Point(203, 162);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(98, 19);
			this.Label15.TabIndex = 10;
			this.Label15.Text = "Congregação:";
			this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(418, 262);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 19);
			this.label5.TabIndex = 19;
			this.label5.Text = "UF Padrão:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(86, 223);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 19);
			this.label6.TabIndex = 13;
			this.label6.Text = "Setor Padrão:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(74, 262);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 19);
			this.label2.TabIndex = 17;
			this.label2.Text = "Cidade Padrão:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label35
			// 
			this.Label35.AutoSize = true;
			this.Label35.BackColor = System.Drawing.Color.Transparent;
			this.Label35.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label35.Location = new System.Drawing.Point(81, 131);
			this.Label35.Name = "Label35";
			this.Label35.Size = new System.Drawing.Size(100, 19);
			this.Label35.TabIndex = 5;
			this.Label35.Text = "Conta Padrão:";
			this.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpDataPadrao
			// 
			this.dtpDataPadrao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDataPadrao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDataPadrao.Location = new System.Drawing.Point(187, 89);
			this.dtpDataPadrao.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.dtpDataPadrao.Name = "dtpDataPadrao";
			this.dtpDataPadrao.Size = new System.Drawing.Size(155, 27);
			this.dtpDataPadrao.TabIndex = 4;
			// 
			// lblDataBloqueio
			// 
			this.lblDataBloqueio.BackColor = System.Drawing.Color.Transparent;
			this.lblDataBloqueio.Location = new System.Drawing.Point(307, 189);
			this.lblDataBloqueio.Name = "lblDataBloqueio";
			this.lblDataBloqueio.Size = new System.Drawing.Size(92, 18);
			this.lblDataBloqueio.TabIndex = 12;
			this.lblDataBloqueio.Text = "01/01/2018";
			// 
			// Label22
			// 
			this.Label22.AutoSize = true;
			this.Label22.BackColor = System.Drawing.Color.Transparent;
			this.Label22.Location = new System.Drawing.Point(184, 189);
			this.Label22.Name = "Label22";
			this.Label22.Size = new System.Drawing.Size(117, 19);
			this.Label22.TabIndex = 11;
			this.Label22.Text = "Data Bloqueada:";
			// 
			// txtUFPadrao
			// 
			this.txtUFPadrao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUFPadrao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUFPadrao.Location = new System.Drawing.Point(503, 259);
			this.txtUFPadrao.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtUFPadrao.MaxLength = 2;
			this.txtUFPadrao.Name = "txtUFPadrao";
			this.txtUFPadrao.Size = new System.Drawing.Size(46, 27);
			this.txtUFPadrao.TabIndex = 20;
			// 
			// txtSetorPadrao
			// 
			this.txtSetorPadrao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSetorPadrao.Location = new System.Drawing.Point(187, 220);
			this.txtSetorPadrao.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtSetorPadrao.Name = "txtSetorPadrao";
			this.txtSetorPadrao.Size = new System.Drawing.Size(334, 27);
			this.txtSetorPadrao.TabIndex = 14;
			this.txtSetorPadrao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
			// 
			// txtCidadePadrao
			// 
			this.txtCidadePadrao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCidadePadrao.Location = new System.Drawing.Point(187, 259);
			this.txtCidadePadrao.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtCidadePadrao.MaxLength = 50;
			this.txtCidadePadrao.Name = "txtCidadePadrao";
			this.txtCidadePadrao.Size = new System.Drawing.Size(212, 27);
			this.txtCidadePadrao.TabIndex = 18;
			// 
			// txtContaPadrao
			// 
			this.txtContaPadrao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContaPadrao.Location = new System.Drawing.Point(187, 128);
			this.txtContaPadrao.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtContaPadrao.Name = "txtContaPadrao";
			this.txtContaPadrao.Size = new System.Drawing.Size(334, 27);
			this.txtContaPadrao.TabIndex = 6;
			this.txtContaPadrao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
			// 
			// glassButton1
			// 
			this.glassButton1.BackColor = System.Drawing.Color.LightSlateGray;
			this.glassButton1.Location = new System.Drawing.Point(643, 355);
			this.glassButton1.Name = "glassButton1";
			this.glassButton1.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(221)))), ((int)(((byte)(234)))));
			this.glassButton1.Size = new System.Drawing.Size(38, 32);
			this.glassButton1.TabIndex = 4;
			this.glassButton1.Text = "...";
			this.glassButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// mbGlassButton1
			// 
			this.mbGlassButton1.BackColor = System.Drawing.Color.Transparent;
			this.mbGlassButton1.BaseColor = System.Drawing.Color.LightSteelBlue;
			this.mbGlassButton1.BaseStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(222)))));
			this.mbGlassButton1.FlatAppearance.BorderSize = 0;
			this.mbGlassButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.mbGlassButton1.ImageSize = new System.Drawing.Size(24, 24);
			this.mbGlassButton1.Location = new System.Drawing.Point(62, 533);
			this.mbGlassButton1.MenuListPosition = new System.Drawing.Point(0, 0);
			this.mbGlassButton1.Name = "mbGlassButton1";
			this.mbGlassButton1.OnColor = System.Drawing.Color.White;
			this.mbGlassButton1.OnStrokeColor = System.Drawing.Color.White;
			this.mbGlassButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.mbGlassButton1.PressStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.mbGlassButton1.Size = new System.Drawing.Size(162, 32);
			this.mbGlassButton1.SplitLocation = MBGlassStyleButton.MBGlassButton.MB_SplitLocation.Right;
			this.mbGlassButton1.TabIndex = 25;
			this.mbGlassButton1.Text = "...";
			this.mbGlassButton1.UseVisualStyleBackColor = false;
			// 
			// frmConfigGeral
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(744, 579);
			this.Controls.Add(this.mbGlassButton1);
			this.Controls.Add(this.pnlPastas);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnProcImageFolder);
			this.Controls.Add(this.btnSalvarConfig);
			this.KeyPreview = true;
			this.Name = "frmConfigGeral";
			this.Load += new System.EventHandler(this.frmConfigGeral_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_KeyPress);
			this.Controls.SetChildIndex(this.btnSalvarConfig, 0);
			this.Controls.SetChildIndex(this.btnProcImageFolder, 0);
			this.Controls.SetChildIndex(this.btnCancelar, 0);
			this.Controls.SetChildIndex(this.pnlPastas, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.mbGlassButton1, 0);
			this.panel1.ResumeLayout(false);
			this.pnlPastas.ResumeLayout(false);
			this.pnlPastas.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnSalvarConfig;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Panel pnlPastas;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtIgrejaTitulo;
		private System.Windows.Forms.Label label4;
		internal System.Windows.Forms.Button btnContaEditar;
		internal System.Windows.Forms.Button btnContaAlterar;
		internal System.Windows.Forms.Label lblDataBloqueio;
		internal System.Windows.Forms.Label Label22;
		internal System.Windows.Forms.TextBox txtContaPadrao;
		internal System.Windows.Forms.DateTimePicker dtpDataPadrao;
		internal System.Windows.Forms.Label Label35;
		internal System.Windows.Forms.Label Label34;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Label label5;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.TextBox txtUFPadrao;
		internal System.Windows.Forms.TextBox txtCidadePadrao;
		internal System.Windows.Forms.Button btnSetorEditar;
		internal System.Windows.Forms.Button btnSetorAlterar;
		internal System.Windows.Forms.Label label6;
		internal System.Windows.Forms.TextBox txtSetorPadrao;
		internal System.Windows.Forms.Label lblCongregacao;
		internal System.Windows.Forms.TextBox txtImageFolder;
		internal System.Windows.Forms.Button btnProcImageFolder;
		internal System.Windows.Forms.Label Label18;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnBackupProjecoes;
		private Glass.GlassButton glassButton1;
		private MBGlassStyleButton.MBGlassButton mbGlassButton1;
	}
}
