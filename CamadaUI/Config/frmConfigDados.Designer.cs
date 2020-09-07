namespace CamadaUI.Config
{
	partial class frmConfigDados
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
			this.label3 = new System.Windows.Forms.Label();
			this.pnlPastas = new System.Windows.Forms.Panel();
			this.txtCEP = new System.Windows.Forms.MaskedTextBox();
			this.txtTelefoneFinanceiro = new CamadaUC.ucTelefone();
			this.txtTelefoneFixo = new CamadaUC.ucTelefone();
			this.Label24 = new System.Windows.Forms.Label();
			this.Label27 = new System.Windows.Forms.Label();
			this.Label28 = new System.Windows.Forms.Label();
			this.Label26 = new System.Windows.Forms.Label();
			this.Label25 = new System.Windows.Forms.Label();
			this.txtUF = new System.Windows.Forms.TextBox();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.txtCNPJ = new System.Windows.Forms.MaskedTextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtContatoFinanceiro = new System.Windows.Forms.TextBox();
			this.txtRazao = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.pnlPastas.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.BackColor = System.Drawing.Color.SlateBlue;
			this.lblTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 4);
			this.lblTitulo.Size = new System.Drawing.Size(704, 30);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Configuração dos Dados da Igreja";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.SlateBlue;
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
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(10, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(185, 23);
			this.label3.TabIndex = 0;
			this.label3.Text = "Informações da Igreja:";
			// 
			// pnlPastas
			// 
			this.pnlPastas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(221)))), ((int)(((byte)(234)))));
			this.pnlPastas.Controls.Add(this.txtCEP);
			this.pnlPastas.Controls.Add(this.txtTelefoneFinanceiro);
			this.pnlPastas.Controls.Add(this.txtTelefoneFixo);
			this.pnlPastas.Controls.Add(this.Label24);
			this.pnlPastas.Controls.Add(this.Label27);
			this.pnlPastas.Controls.Add(this.Label28);
			this.pnlPastas.Controls.Add(this.Label26);
			this.pnlPastas.Controls.Add(this.Label25);
			this.pnlPastas.Controls.Add(this.txtUF);
			this.pnlPastas.Controls.Add(this.txtEndereco);
			this.pnlPastas.Controls.Add(this.txtBairro);
			this.pnlPastas.Controls.Add(this.txtCidade);
			this.pnlPastas.Controls.Add(this.txtCNPJ);
			this.pnlPastas.Controls.Add(this.Label10);
			this.pnlPastas.Controls.Add(this.Label4);
			this.pnlPastas.Controls.Add(this.Label6);
			this.pnlPastas.Controls.Add(this.Label8);
			this.pnlPastas.Controls.Add(this.Label2);
			this.pnlPastas.Controls.Add(this.txtContatoFinanceiro);
			this.pnlPastas.Controls.Add(this.txtRazao);
			this.pnlPastas.Controls.Add(this.label3);
			this.pnlPastas.Location = new System.Drawing.Point(12, 42);
			this.pnlPastas.Name = "pnlPastas";
			this.pnlPastas.Size = new System.Drawing.Size(720, 357);
			this.pnlPastas.TabIndex = 1;
			// 
			// txtCEP
			// 
			this.txtCEP.Font = new System.Drawing.Font("Verdana", 12F);
			this.txtCEP.Location = new System.Drawing.Point(218, 293);
			this.txtCEP.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtCEP.Mask = "00000-000";
			this.txtCEP.Name = "txtCEP";
			this.txtCEP.Size = new System.Drawing.Size(106, 27);
			this.txtCEP.TabIndex = 20;
			this.txtCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTelefoneFinanceiro
			// 
			this.txtTelefoneFinanceiro.Font = new System.Drawing.Font("Verdana", 12F);
			this.txtTelefoneFinanceiro.Location = new System.Drawing.Point(218, 176);
			this.txtTelefoneFinanceiro.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtTelefoneFinanceiro.Mask = "(99) 99000-0000";
			this.txtTelefoneFinanceiro.Name = "txtTelefoneFinanceiro";
			this.txtTelefoneFinanceiro.Size = new System.Drawing.Size(163, 27);
			this.txtTelefoneFinanceiro.TabIndex = 10;
			// 
			// txtTelefoneFixo
			// 
			this.txtTelefoneFixo.Font = new System.Drawing.Font("Verdana", 12F);
			this.txtTelefoneFixo.Location = new System.Drawing.Point(218, 137);
			this.txtTelefoneFixo.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtTelefoneFixo.Mask = "(99) 99000-0000";
			this.txtTelefoneFixo.Name = "txtTelefoneFixo";
			this.txtTelefoneFixo.Size = new System.Drawing.Size(163, 27);
			this.txtTelefoneFixo.TabIndex = 8;
			// 
			// Label24
			// 
			this.Label24.AutoSize = true;
			this.Label24.BackColor = System.Drawing.Color.Transparent;
			this.Label24.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label24.Location = new System.Drawing.Point(446, 296);
			this.Label24.Name = "Label24";
			this.Label24.Size = new System.Drawing.Size(36, 18);
			this.Label24.TabIndex = 21;
			this.Label24.Text = "UF:";
			// 
			// Label27
			// 
			this.Label27.AutoSize = true;
			this.Label27.BackColor = System.Drawing.Color.Transparent;
			this.Label27.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label27.Location = new System.Drawing.Point(163, 296);
			this.Label27.Name = "Label27";
			this.Label27.Size = new System.Drawing.Size(46, 18);
			this.Label27.TabIndex = 19;
			this.Label27.Text = "CEP:";
			// 
			// Label28
			// 
			this.Label28.AutoSize = true;
			this.Label28.BackColor = System.Drawing.Color.Transparent;
			this.Label28.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label28.Location = new System.Drawing.Point(120, 218);
			this.Label28.Name = "Label28";
			this.Label28.Size = new System.Drawing.Size(89, 18);
			this.Label28.TabIndex = 13;
			this.Label28.Text = "Endereço:";
			// 
			// Label26
			// 
			this.Label26.AutoSize = true;
			this.Label26.BackColor = System.Drawing.Color.Transparent;
			this.Label26.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label26.Location = new System.Drawing.Point(146, 257);
			this.Label26.Name = "Label26";
			this.Label26.Size = new System.Drawing.Size(63, 18);
			this.Label26.TabIndex = 15;
			this.Label26.Text = "Bairro:";
			// 
			// Label25
			// 
			this.Label25.AutoSize = true;
			this.Label25.BackColor = System.Drawing.Color.Transparent;
			this.Label25.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label25.Location = new System.Drawing.Point(408, 257);
			this.Label25.Name = "Label25";
			this.Label25.Size = new System.Drawing.Size(71, 18);
			this.Label25.TabIndex = 18;
			this.Label25.Text = "Cidade:";
			// 
			// txtUF
			// 
			this.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUF.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUF.Location = new System.Drawing.Point(488, 293);
			this.txtUF.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtUF.MaxLength = 2;
			this.txtUF.Name = "txtUF";
			this.txtUF.Size = new System.Drawing.Size(51, 27);
			this.txtUF.TabIndex = 22;
			// 
			// txtEndereco
			// 
			this.txtEndereco.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEndereco.Location = new System.Drawing.Point(218, 215);
			this.txtEndereco.Margin = new System.Windows.Forms.Padding(6);
			this.txtEndereco.MaxLength = 50;
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(457, 27);
			this.txtEndereco.TabIndex = 14;
			// 
			// txtBairro
			// 
			this.txtBairro.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBairro.Location = new System.Drawing.Point(218, 254);
			this.txtBairro.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtBairro.MaxLength = 50;
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(175, 27);
			this.txtBairro.TabIndex = 16;
			// 
			// txtCidade
			// 
			this.txtCidade.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCidade.Location = new System.Drawing.Point(488, 254);
			this.txtCidade.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtCidade.MaxLength = 50;
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(187, 27);
			this.txtCidade.TabIndex = 17;
			// 
			// txtCNPJ
			// 
			this.txtCNPJ.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCNPJ.Location = new System.Drawing.Point(218, 98);
			this.txtCNPJ.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtCNPJ.Mask = "00,000,000/0000-00";
			this.txtCNPJ.Name = "txtCNPJ";
			this.txtCNPJ.Size = new System.Drawing.Size(214, 27);
			this.txtCNPJ.TabIndex = 6;
			// 
			// Label10
			// 
			this.Label10.AutoSize = true;
			this.Label10.BackColor = System.Drawing.Color.Transparent;
			this.Label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label10.Location = new System.Drawing.Point(36, 179);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(173, 18);
			this.Label10.TabIndex = 9;
			this.Label10.Text = "Telefone Financeiro:";
			// 
			// Label4
			// 
			this.Label4.AutoSize = true;
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label4.Location = new System.Drawing.Point(154, 101);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(55, 18);
			this.Label4.TabIndex = 5;
			this.Label4.Text = "CNPJ:";
			// 
			// Label6
			// 
			this.Label6.AutoSize = true;
			this.Label6.BackColor = System.Drawing.Color.Transparent;
			this.Label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label6.Location = new System.Drawing.Point(50, 140);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(159, 18);
			this.Label6.TabIndex = 7;
			this.Label6.Text = "Telefone Principal:";
			// 
			// Label8
			// 
			this.Label8.AutoSize = true;
			this.Label8.BackColor = System.Drawing.Color.Transparent;
			this.Label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label8.Location = new System.Drawing.Point(416, 179);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(96, 18);
			this.Label8.TabIndex = 11;
			this.Label8.Text = "Falar Com:";
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label2.Location = new System.Drawing.Point(90, 62);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(119, 18);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Razão Social:";
			// 
			// txtContatoFinanceiro
			// 
			this.txtContatoFinanceiro.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContatoFinanceiro.Location = new System.Drawing.Point(518, 176);
			this.txtContatoFinanceiro.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtContatoFinanceiro.MaxLength = 30;
			this.txtContatoFinanceiro.Name = "txtContatoFinanceiro";
			this.txtContatoFinanceiro.Size = new System.Drawing.Size(157, 27);
			this.txtContatoFinanceiro.TabIndex = 12;
			// 
			// txtRazao
			// 
			this.txtRazao.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRazao.Location = new System.Drawing.Point(218, 59);
			this.txtRazao.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtRazao.MaxLength = 100;
			this.txtRazao.Name = "txtRazao";
			this.txtRazao.Size = new System.Drawing.Size(457, 27);
			this.txtRazao.TabIndex = 2;
			// 
			// frmConfigDados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(744, 579);
			this.Controls.Add(this.pnlPastas);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvarConfig);
			this.Name = "frmConfigDados";
			this.Load += new System.EventHandler(this.frmConfigDados_Load);
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
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel pnlPastas;
		internal System.Windows.Forms.Label Label24;
		internal System.Windows.Forms.Label Label27;
		internal System.Windows.Forms.Label Label28;
		internal System.Windows.Forms.Label Label26;
		internal System.Windows.Forms.Label Label25;
		internal System.Windows.Forms.TextBox txtUF;
		internal System.Windows.Forms.TextBox txtEndereco;
		internal System.Windows.Forms.TextBox txtBairro;
		internal System.Windows.Forms.TextBox txtCidade;
		internal System.Windows.Forms.MaskedTextBox txtCNPJ;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtContatoFinanceiro;
		internal System.Windows.Forms.TextBox txtRazao;
		private CamadaUC.ucTelefone txtTelefoneFinanceiro;
		private CamadaUC.ucTelefone txtTelefoneFixo;
		internal System.Windows.Forms.MaskedTextBox txtCEP;
	}
}
