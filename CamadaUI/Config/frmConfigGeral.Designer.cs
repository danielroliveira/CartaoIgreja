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
			this.btnBackupFotos = new MBGlassStyleButton.MBGlassButton();
			this.btnProcDesignFolder = new MBGlassStyleButton.MBGlassButton();
			this.btnProcFotosFolder = new MBGlassStyleButton.MBGlassButton();
			this.txtDesignFolder = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtFotosFolder = new System.Windows.Forms.TextBox();
			this.Label18 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtIgrejaTitulo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUFPadrao = new System.Windows.Forms.TextBox();
			this.txtCidadePadrao = new System.Windows.Forms.TextBox();
			this.btnBackupDesign = new MBGlassStyleButton.MBGlassButton();
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
			this.pnlPastas.Controls.Add(this.btnBackupDesign);
			this.pnlPastas.Controls.Add(this.btnBackupFotos);
			this.pnlPastas.Controls.Add(this.btnProcDesignFolder);
			this.pnlPastas.Controls.Add(this.btnProcFotosFolder);
			this.pnlPastas.Controls.Add(this.txtDesignFolder);
			this.pnlPastas.Controls.Add(this.label6);
			this.pnlPastas.Controls.Add(this.label7);
			this.pnlPastas.Controls.Add(this.txtFotosFolder);
			this.pnlPastas.Controls.Add(this.Label18);
			this.pnlPastas.Controls.Add(this.label4);
			this.pnlPastas.Controls.Add(this.txtIgrejaTitulo);
			this.pnlPastas.Controls.Add(this.label3);
			this.pnlPastas.Controls.Add(this.label1);
			this.pnlPastas.Controls.Add(this.label5);
			this.pnlPastas.Controls.Add(this.label2);
			this.pnlPastas.Controls.Add(this.txtUFPadrao);
			this.pnlPastas.Controls.Add(this.txtCidadePadrao);
			this.pnlPastas.Location = new System.Drawing.Point(12, 42);
			this.pnlPastas.Margin = new System.Windows.Forms.Padding(6);
			this.pnlPastas.Name = "pnlPastas";
			this.pnlPastas.Size = new System.Drawing.Size(720, 477);
			this.pnlPastas.TabIndex = 1;
			// 
			// btnBackupFotos
			// 
			this.btnBackupFotos.BackColor = System.Drawing.Color.Transparent;
			this.btnBackupFotos.BaseColor = System.Drawing.Color.LightSteelBlue;
			this.btnBackupFotos.BaseStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(222)))));
			this.btnBackupFotos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnBackupFotos.FlatAppearance.BorderSize = 0;
			this.btnBackupFotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBackupFotos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBackupFotos.Image = global::CamadaUI.Properties.Resources.backup_24;
			this.btnBackupFotos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBackupFotos.ImageSize = new System.Drawing.Size(24, 24);
			this.btnBackupFotos.Location = new System.Drawing.Point(484, 223);
			this.btnBackupFotos.MenuListPosition = new System.Drawing.Point(0, 0);
			this.btnBackupFotos.Name = "btnBackupFotos";
			this.btnBackupFotos.OnColor = System.Drawing.Color.LightSlateGray;
			this.btnBackupFotos.OnStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))), ((int)(((byte)(153)))));
			this.btnBackupFotos.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnBackupFotos.PressStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnBackupFotos.Size = new System.Drawing.Size(153, 45);
			this.btnBackupFotos.SplitLocation = MBGlassStyleButton.MBGlassButton.MB_SplitLocation.Right;
			this.btnBackupFotos.TabIndex = 25;
			this.btnBackupFotos.Text = "Backup Fotos";
			this.btnBackupFotos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBackupFotos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBackupFotos.UseCompatibleTextRendering = true;
			this.btnBackupFotos.UseMnemonic = false;
			this.btnBackupFotos.UseVisualStyleBackColor = true;
			// 
			// btnProcDesignFolder
			// 
			this.btnProcDesignFolder.BackColor = System.Drawing.Color.Transparent;
			this.btnProcDesignFolder.BaseColor = System.Drawing.Color.LightSteelBlue;
			this.btnProcDesignFolder.BaseStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(222)))));
			this.btnProcDesignFolder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnProcDesignFolder.FlatAppearance.BorderSize = 0;
			this.btnProcDesignFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProcDesignFolder.ImageSize = new System.Drawing.Size(24, 24);
			this.btnProcDesignFolder.Location = new System.Drawing.Point(643, 292);
			this.btnProcDesignFolder.MenuListPosition = new System.Drawing.Point(0, 0);
			this.btnProcDesignFolder.Name = "btnProcDesignFolder";
			this.btnProcDesignFolder.OnColor = System.Drawing.Color.LightSlateGray;
			this.btnProcDesignFolder.OnStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))), ((int)(((byte)(153)))));
			this.btnProcDesignFolder.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnProcDesignFolder.PressStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnProcDesignFolder.Size = new System.Drawing.Size(38, 28);
			this.btnProcDesignFolder.SplitLocation = MBGlassStyleButton.MBGlassButton.MB_SplitLocation.Right;
			this.btnProcDesignFolder.TabIndex = 25;
			this.btnProcDesignFolder.Text = "...";
			this.btnProcDesignFolder.UseVisualStyleBackColor = false;
			this.btnProcDesignFolder.Click += new System.EventHandler(this.btnProcDesignFolder_Click);
			// 
			// btnProcFotosFolder
			// 
			this.btnProcFotosFolder.BackColor = System.Drawing.Color.Transparent;
			this.btnProcFotosFolder.BaseColor = System.Drawing.Color.LightSteelBlue;
			this.btnProcFotosFolder.BaseStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(222)))));
			this.btnProcFotosFolder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnProcFotosFolder.FlatAppearance.BorderSize = 0;
			this.btnProcFotosFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProcFotosFolder.ImageSize = new System.Drawing.Size(24, 24);
			this.btnProcFotosFolder.Location = new System.Drawing.Point(643, 187);
			this.btnProcFotosFolder.MenuListPosition = new System.Drawing.Point(0, 0);
			this.btnProcFotosFolder.Name = "btnProcFotosFolder";
			this.btnProcFotosFolder.OnColor = System.Drawing.Color.LightSlateGray;
			this.btnProcFotosFolder.OnStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))), ((int)(((byte)(153)))));
			this.btnProcFotosFolder.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnProcFotosFolder.PressStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnProcFotosFolder.Size = new System.Drawing.Size(38, 28);
			this.btnProcFotosFolder.SplitLocation = MBGlassStyleButton.MBGlassButton.MB_SplitLocation.Right;
			this.btnProcFotosFolder.TabIndex = 25;
			this.btnProcFotosFolder.Text = "...";
			this.btnProcFotosFolder.UseVisualStyleBackColor = false;
			this.btnProcFotosFolder.Click += new System.EventHandler(this.btnProcFotosFolder_Click);
			// 
			// txtDesignFolder
			// 
			this.txtDesignFolder.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDesignFolder.Location = new System.Drawing.Point(72, 292);
			this.txtDesignFolder.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtDesignFolder.MaxLength = 200;
			this.txtDesignFolder.Name = "txtDesignFolder";
			this.txtDesignFolder.Size = new System.Drawing.Size(565, 27);
			this.txtDesignFolder.TabIndex = 29;
			this.txtDesignFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Calibri", 12F);
			this.label6.Location = new System.Drawing.Point(19, 295);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(49, 19);
			this.label6.TabIndex = 28;
			this.label6.Text = "Pasta:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(9, 254);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(237, 23);
			this.label7.TabIndex = 27;
			this.label7.Text = "Pasta do Design dos Cartões:";
			// 
			// txtFotosFolder
			// 
			this.txtFotosFolder.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFotosFolder.Location = new System.Drawing.Point(72, 187);
			this.txtFotosFolder.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtFotosFolder.MaxLength = 200;
			this.txtFotosFolder.Name = "txtFotosFolder";
			this.txtFotosFolder.Size = new System.Drawing.Size(565, 27);
			this.txtFotosFolder.TabIndex = 23;
			this.txtFotosFolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
			// 
			// Label18
			// 
			this.Label18.AutoSize = true;
			this.Label18.BackColor = System.Drawing.Color.Transparent;
			this.Label18.Font = new System.Drawing.Font("Calibri", 12F);
			this.Label18.Location = new System.Drawing.Point(19, 190);
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
			this.label3.Location = new System.Drawing.Point(9, 149);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(242, 23);
			this.label3.TabIndex = 21;
			this.label3.Text = "Pasta das Fotos de Membros:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(9, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(283, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Valores Padrão de Preenchimento:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(418, 92);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 19);
			this.label5.TabIndex = 19;
			this.label5.Text = "UF Padrão:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(74, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(107, 19);
			this.label2.TabIndex = 17;
			this.label2.Text = "Cidade Padrão:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUFPadrao
			// 
			this.txtUFPadrao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUFPadrao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUFPadrao.Location = new System.Drawing.Point(503, 89);
			this.txtUFPadrao.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtUFPadrao.MaxLength = 2;
			this.txtUFPadrao.Name = "txtUFPadrao";
			this.txtUFPadrao.Size = new System.Drawing.Size(46, 27);
			this.txtUFPadrao.TabIndex = 20;
			// 
			// txtCidadePadrao
			// 
			this.txtCidadePadrao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCidadePadrao.Location = new System.Drawing.Point(187, 89);
			this.txtCidadePadrao.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtCidadePadrao.MaxLength = 50;
			this.txtCidadePadrao.Name = "txtCidadePadrao";
			this.txtCidadePadrao.Size = new System.Drawing.Size(212, 27);
			this.txtCidadePadrao.TabIndex = 18;
			// 
			// btnBackupDesign
			// 
			this.btnBackupDesign.BackColor = System.Drawing.Color.Transparent;
			this.btnBackupDesign.BaseColor = System.Drawing.Color.LightSteelBlue;
			this.btnBackupDesign.BaseStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(176)))), ((int)(((byte)(196)))), ((int)(((byte)(222)))));
			this.btnBackupDesign.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnBackupDesign.FlatAppearance.BorderSize = 0;
			this.btnBackupDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBackupDesign.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBackupDesign.Image = global::CamadaUI.Properties.Resources.backup_24;
			this.btnBackupDesign.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBackupDesign.ImageSize = new System.Drawing.Size(24, 24);
			this.btnBackupDesign.Location = new System.Drawing.Point(484, 328);
			this.btnBackupDesign.MenuListPosition = new System.Drawing.Point(0, 0);
			this.btnBackupDesign.Name = "btnBackupDesign";
			this.btnBackupDesign.OnColor = System.Drawing.Color.LightSlateGray;
			this.btnBackupDesign.OnStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(136)))), ((int)(((byte)(153)))));
			this.btnBackupDesign.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnBackupDesign.PressStrokeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnBackupDesign.Size = new System.Drawing.Size(153, 45);
			this.btnBackupDesign.SplitLocation = MBGlassStyleButton.MBGlassButton.MB_SplitLocation.Right;
			this.btnBackupDesign.TabIndex = 25;
			this.btnBackupDesign.Text = "Backup Design";
			this.btnBackupDesign.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBackupDesign.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBackupDesign.UseCompatibleTextRendering = true;
			this.btnBackupDesign.UseMnemonic = false;
			this.btnBackupDesign.UseVisualStyleBackColor = true;
			// 
			// frmConfigGeral
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(744, 579);
			this.Controls.Add(this.pnlPastas);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvarConfig);
			this.KeyPreview = true;
			this.Name = "frmConfigGeral";
			this.Load += new System.EventHandler(this.frmConfigGeral_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_KeyPress);
			this.Controls.SetChildIndex(this.btnSalvarConfig, 0);
			this.Controls.SetChildIndex(this.btnCancelar, 0);
			this.Controls.SetChildIndex(this.pnlPastas, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
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
		internal System.Windows.Forms.Label label5;
		internal System.Windows.Forms.Label label2;
		internal System.Windows.Forms.TextBox txtUFPadrao;
		internal System.Windows.Forms.TextBox txtCidadePadrao;
		internal System.Windows.Forms.TextBox txtFotosFolder;
		internal System.Windows.Forms.Label Label18;
		private System.Windows.Forms.Label label3;
		internal System.Windows.Forms.TextBox txtDesignFolder;
		internal System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private MBGlassStyleButton.MBGlassButton btnProcFotosFolder;
		private MBGlassStyleButton.MBGlassButton btnBackupFotos;
		private MBGlassStyleButton.MBGlassButton btnProcDesignFolder;
		private MBGlassStyleButton.MBGlassButton btnBackupDesign;
	}
}
