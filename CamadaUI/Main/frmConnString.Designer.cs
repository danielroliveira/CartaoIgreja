namespace CamadaUI.Main
{
	partial class frmConnString
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
			this.Label1 = new System.Windows.Forms.Label();
			this.btnSalvarArquivo = new System.Windows.Forms.Button();
			this.btnRemoverString = new System.Windows.Forms.Button();
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.btnNovaString = new System.Windows.Forms.Button();
			this.lstConn = new ComponentOwl.BetterListView.BetterListView();
			this.clnNome = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.clnString = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.lblCaminho = new System.Windows.Forms.Label();
			this.txtConnString = new System.Windows.Forms.TextBox();
			this.btnUsar = new System.Windows.Forms.Button();
			this.btnCriarArquivo = new System.Windows.Forms.Button();
			this.btnObterArquivo = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lstConn)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(298, 0);
			this.lblTitulo.Size = new System.Drawing.Size(377, 50);
			this.lblTitulo.Text = "Definir Servidor do Banco de Dados";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(675, 0);
			this.btnClose.Size = new System.Drawing.Size(32, 50);
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(707, 50);
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(15, 310);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(126, 19);
			this.Label1.TabIndex = 18;
			this.Label1.Text = "String de Conexão";
			// 
			// btnSalvarArquivo
			// 
			this.btnSalvarArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSalvarArquivo.Enabled = false;
			this.btnSalvarArquivo.Image = global::CamadaUI.Properties.Resources.save_24;
			this.btnSalvarArquivo.Location = new System.Drawing.Point(347, 458);
			this.btnSalvarArquivo.Name = "btnSalvarArquivo";
			this.btnSalvarArquivo.Size = new System.Drawing.Size(159, 46);
			this.btnSalvarArquivo.TabIndex = 14;
			this.btnSalvarArquivo.Text = "Salvar Arquivo";
			this.btnSalvarArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvarArquivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvarArquivo.UseVisualStyleBackColor = true;
			this.btnSalvarArquivo.Click += new System.EventHandler(this.btnSalvarArquivo_Click);
			// 
			// btnRemoverString
			// 
			this.btnRemoverString.Image = global::CamadaUI.Properties.Resources.delete_16;
			this.btnRemoverString.Location = new System.Drawing.Point(567, 412);
			this.btnRemoverString.Name = "btnRemoverString";
			this.btnRemoverString.Size = new System.Drawing.Size(124, 34);
			this.btnRemoverString.TabIndex = 15;
			this.btnRemoverString.Text = "Remover";
			this.btnRemoverString.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRemoverString.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRemoverString.UseVisualStyleBackColor = true;
			this.btnRemoverString.Click += new System.EventHandler(this.btnRemoverString_Click);
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.Image = global::CamadaUI.Properties.Resources.refresh_16;
			this.btnAtualizar.Location = new System.Drawing.Point(567, 372);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(124, 34);
			this.btnAtualizar.TabIndex = 16;
			this.btnAtualizar.Text = "Atualizar";
			this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAtualizar.UseVisualStyleBackColor = true;
			this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
			// 
			// btnNovaString
			// 
			this.btnNovaString.Image = global::CamadaUI.Properties.Resources.add_16;
			this.btnNovaString.Location = new System.Drawing.Point(567, 332);
			this.btnNovaString.Name = "btnNovaString";
			this.btnNovaString.Size = new System.Drawing.Size(124, 34);
			this.btnNovaString.TabIndex = 17;
			this.btnNovaString.Text = "Nova";
			this.btnNovaString.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNovaString.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNovaString.UseVisualStyleBackColor = true;
			this.btnNovaString.Click += new System.EventHandler(this.btnNovaString_Click);
			// 
			// lstConn
			// 
			this.lstConn.Columns.Add(this.clnNome);
			this.lstConn.Columns.Add(this.clnString);
			this.lstConn.DisplayMember = "Nome";
			this.lstConn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstConn.HideSelectionMode = ComponentOwl.BetterListView.BetterListViewHideSelectionMode.KeepSelection;
			this.lstConn.Location = new System.Drawing.Point(15, 98);
			this.lstConn.Name = "lstConn";
			this.lstConn.Size = new System.Drawing.Size(676, 199);
			this.lstConn.TabIndex = 13;
			this.lstConn.DrawColumnHeader += new ComponentOwl.BetterListView.BetterListViewDrawColumnHeaderEventHandler(this.lstConn_DrawColumnHeader);
			this.lstConn.SelectedIndexChanged += new System.EventHandler(this.lstConn_SelectedIndexChanged);
			// 
			// clnNome
			// 
			this.clnNome.DisplayMember = "Nome";
			this.clnNome.Name = "clnNome";
			this.clnNome.Text = "Nome";
			// 
			// clnString
			// 
			this.clnString.DisplayMember = "connString";
			this.clnString.Name = "clnString";
			this.clnString.Text = "String Conexão";
			this.clnString.Width = 500;
			// 
			// lblCaminho
			// 
			this.lblCaminho.Location = new System.Drawing.Point(15, 65);
			this.lblCaminho.Name = "lblCaminho";
			this.lblCaminho.Size = new System.Drawing.Size(336, 30);
			this.lblCaminho.TabIndex = 12;
			this.lblCaminho.Text = "Caminho do Arquivo";
			// 
			// txtConnString
			// 
			this.txtConnString.Location = new System.Drawing.Point(15, 332);
			this.txtConnString.Multiline = true;
			this.txtConnString.Name = "txtConnString";
			this.txtConnString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtConnString.Size = new System.Drawing.Size(537, 74);
			this.txtConnString.TabIndex = 11;
			// 
			// btnUsar
			// 
			this.btnUsar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnUsar.Image = global::CamadaUI.Properties.Resources.refresh_32;
			this.btnUsar.Location = new System.Drawing.Point(512, 458);
			this.btnUsar.Name = "btnUsar";
			this.btnUsar.Size = new System.Drawing.Size(179, 46);
			this.btnUsar.TabIndex = 8;
			this.btnUsar.Text = "USAR Conexão";
			this.btnUsar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnUsar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUsar.UseVisualStyleBackColor = true;
			this.btnUsar.Click += new System.EventHandler(this.btnUsar_Click);
			// 
			// btnCriarArquivo
			// 
			this.btnCriarArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCriarArquivo.Image = global::CamadaUI.Properties.Resources.add_24;
			this.btnCriarArquivo.Location = new System.Drawing.Point(181, 458);
			this.btnCriarArquivo.Name = "btnCriarArquivo";
			this.btnCriarArquivo.Size = new System.Drawing.Size(160, 46);
			this.btnCriarArquivo.TabIndex = 9;
			this.btnCriarArquivo.Text = "Criar Arquivo";
			this.btnCriarArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCriarArquivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCriarArquivo.UseVisualStyleBackColor = true;
			this.btnCriarArquivo.Click += new System.EventHandler(this.btnCriarArquivo_Click);
			// 
			// btnObterArquivo
			// 
			this.btnObterArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnObterArquivo.Image = global::CamadaUI.Properties.Resources.download_24;
			this.btnObterArquivo.Location = new System.Drawing.Point(15, 458);
			this.btnObterArquivo.Name = "btnObterArquivo";
			this.btnObterArquivo.Size = new System.Drawing.Size(160, 46);
			this.btnObterArquivo.TabIndex = 10;
			this.btnObterArquivo.Text = "Abrir Arquivo";
			this.btnObterArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnObterArquivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnObterArquivo.UseVisualStyleBackColor = true;
			this.btnObterArquivo.Click += new System.EventHandler(this.btnObterArquivo_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(150, 417);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(152, 27);
			this.txtPassword.TabIndex = 19;
			this.txtPassword.Visible = false;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(15, 420);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(129, 19);
			this.lblPassword.TabIndex = 18;
			this.lblPassword.Text = "Entre com a Senha";
			this.lblPassword.Visible = false;
			// 
			// frmConnString
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(707, 517);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.lblPassword);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.btnSalvarArquivo);
			this.Controls.Add(this.btnRemoverString);
			this.Controls.Add(this.btnAtualizar);
			this.Controls.Add(this.btnNovaString);
			this.Controls.Add(this.lstConn);
			this.Controls.Add(this.lblCaminho);
			this.Controls.Add(this.txtConnString);
			this.Controls.Add(this.btnUsar);
			this.Controls.Add(this.btnCriarArquivo);
			this.Controls.Add(this.btnObterArquivo);
			this.Name = "frmConnString";
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.btnObterArquivo, 0);
			this.Controls.SetChildIndex(this.btnCriarArquivo, 0);
			this.Controls.SetChildIndex(this.btnUsar, 0);
			this.Controls.SetChildIndex(this.txtConnString, 0);
			this.Controls.SetChildIndex(this.lblCaminho, 0);
			this.Controls.SetChildIndex(this.lstConn, 0);
			this.Controls.SetChildIndex(this.btnNovaString, 0);
			this.Controls.SetChildIndex(this.btnAtualizar, 0);
			this.Controls.SetChildIndex(this.btnRemoverString, 0);
			this.Controls.SetChildIndex(this.btnSalvarArquivo, 0);
			this.Controls.SetChildIndex(this.Label1, 0);
			this.Controls.SetChildIndex(this.lblPassword, 0);
			this.Controls.SetChildIndex(this.txtPassword, 0);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lstConn)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button btnSalvarArquivo;
		internal System.Windows.Forms.Button btnRemoverString;
		internal System.Windows.Forms.Button btnAtualizar;
		internal System.Windows.Forms.Button btnNovaString;
		internal ComponentOwl.BetterListView.BetterListView lstConn;
		internal ComponentOwl.BetterListView.BetterListViewColumnHeader clnNome;
		internal ComponentOwl.BetterListView.BetterListViewColumnHeader clnString;
		internal System.Windows.Forms.Label lblCaminho;
		internal System.Windows.Forms.TextBox txtConnString;
		internal System.Windows.Forms.Button btnUsar;
		internal System.Windows.Forms.Button btnCriarArquivo;
		internal System.Windows.Forms.Button btnObterArquivo;
		private System.Windows.Forms.TextBox txtPassword;
		internal System.Windows.Forms.Label lblPassword;
	}
}
