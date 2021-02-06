namespace CamadaUI.Cadastros
{
	partial class frmFuncaoControle
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tspMenu = new System.Windows.Forms.ToolStrip();
			this.btnNovo = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSalvar = new System.Windows.Forms.ToolStripButton();
			this.btnCancelar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnFechar = new System.Windows.Forms.ToolStripButton();
			this.MenuListagem = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuAtivar = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDesativar = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuExcluir = new System.Windows.Forms.ToolStripMenuItem();
			this.dgvListagem = new CamadaUC.ucDataGridView();
			this.clnPosicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnImage = new System.Windows.Forms.DataGridViewImageColumn();
			this.lblAcao = new System.Windows.Forms.Label();
			this.btnSubir = new System.Windows.Forms.Button();
			this.btnDescer = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.tspMenu.SuspendLayout();
			this.MenuListagem.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(266, 0);
			this.lblTitulo.Size = new System.Drawing.Size(224, 50);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Funções Ministeriais";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(490, 0);
			this.btnClose.TabIndex = 1;
			this.btnClose.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblAcao);
			this.panel1.Location = new System.Drawing.Point(2, 2);
			this.panel1.Size = new System.Drawing.Size(530, 50);
			this.panel1.Controls.SetChildIndex(this.btnClose, 0);
			this.panel1.Controls.SetChildIndex(this.lblTitulo, 0);
			this.panel1.Controls.SetChildIndex(this.lblAcao, 0);
			// 
			// tspMenu
			// 
			this.tspMenu.AutoSize = false;
			this.tspMenu.BackColor = System.Drawing.Color.AntiqueWhite;
			this.tspMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tspMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.toolStripSeparator1,
            this.btnSalvar,
            this.btnCancelar,
            this.toolStripSeparator2,
            this.btnFechar});
			this.tspMenu.Location = new System.Drawing.Point(2, 468);
			this.tspMenu.Name = "tspMenu";
			this.tspMenu.Size = new System.Drawing.Size(530, 44);
			this.tspMenu.TabIndex = 2;
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
			this.btnNovo.Text = "&Nova";
			this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			// MenuListagem
			// 
			this.MenuListagem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAtivar,
            this.mnuDesativar,
            this.toolStripSeparator3,
            this.mnuExcluir});
			this.MenuListagem.Name = "MenuFab";
			this.MenuListagem.Size = new System.Drawing.Size(165, 76);
			// 
			// mnuAtivar
			// 
			this.mnuAtivar.Image = global::CamadaUI.Properties.Resources.accept_16;
			this.mnuAtivar.Name = "mnuAtivar";
			this.mnuAtivar.Size = new System.Drawing.Size(164, 22);
			this.mnuAtivar.Text = "Ativar Função";
			this.mnuAtivar.Click += new System.EventHandler(this.AtivarDesativar_Click);
			// 
			// mnuDesativar
			// 
			this.mnuDesativar.Image = global::CamadaUI.Properties.Resources.block_16;
			this.mnuDesativar.Name = "mnuDesativar";
			this.mnuDesativar.Size = new System.Drawing.Size(164, 22);
			this.mnuDesativar.Text = "Desativar Função";
			this.mnuDesativar.Click += new System.EventHandler(this.AtivarDesativar_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
			// 
			// mnuExcluir
			// 
			this.mnuExcluir.Image = global::CamadaUI.Properties.Resources.lixeira_24;
			this.mnuExcluir.Name = "mnuExcluir";
			this.mnuExcluir.Size = new System.Drawing.Size(164, 22);
			this.mnuExcluir.Text = "Excluir Função";
			this.mnuExcluir.Click += new System.EventHandler(this.mnuExcluir_Click);
			// 
			// dgvListagem
			// 
			this.dgvListagem.AllowUserToAddRows = false;
			this.dgvListagem.AllowUserToDeleteRows = false;
			this.dgvListagem.AllowUserToResizeColumns = false;
			this.dgvListagem.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.OldLace;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
			this.dgvListagem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvListagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvListagem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvListagem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Navy;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListagem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvListagem.ColumnHeadersHeight = 33;
			this.dgvListagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvListagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnPosicao,
            this.clnCadastro,
            this.clnImage});
			this.dgvListagem.EnableHeadersVisualStyles = false;
			this.dgvListagem.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvListagem.Location = new System.Drawing.Point(12, 63);
			this.dgvListagem.MultiSelect = false;
			this.dgvListagem.Name = "dgvListagem";
			this.dgvListagem.RowHeadersVisible = false;
			this.dgvListagem.RowHeadersWidth = 45;
			this.dgvListagem.RowTemplate.Height = 30;
			this.dgvListagem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvListagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvListagem.Size = new System.Drawing.Size(472, 391);
			this.dgvListagem.StandardTab = true;
			this.dgvListagem.TabIndex = 1;
			this.dgvListagem.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvListagem_CellBeginEdit);
			this.dgvListagem.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListagem_CellFormatting);
			this.dgvListagem.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvListagem_CellValidating);
			this.dgvListagem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListagem_KeyDown);
			this.dgvListagem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvListagem_MouseDown);
			// 
			// clnPosicao
			// 
			this.clnPosicao.Frozen = true;
			this.clnPosicao.HeaderText = "Pos.";
			this.clnPosicao.MaxInputLength = 10;
			this.clnPosicao.Name = "clnPosicao";
			this.clnPosicao.Width = 50;
			// 
			// clnCadastro
			// 
			this.clnCadastro.Frozen = true;
			this.clnCadastro.HeaderText = "Função";
			this.clnCadastro.Name = "clnCadastro";
			this.clnCadastro.Width = 300;
			// 
			// clnImage
			// 
			this.clnImage.Frozen = true;
			this.clnImage.HeaderText = "Ativo";
			this.clnImage.Name = "clnImage";
			this.clnImage.ReadOnly = true;
			this.clnImage.Width = 70;
			// 
			// lblAcao
			// 
			this.lblAcao.AutoSize = true;
			this.lblAcao.Font = new System.Drawing.Font("Geometr706 BlkCn BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAcao.ForeColor = System.Drawing.Color.Cornsilk;
			this.lblAcao.Location = new System.Drawing.Point(15, 14);
			this.lblAcao.Name = "lblAcao";
			this.lblAcao.Size = new System.Drawing.Size(210, 22);
			this.lblAcao.TabIndex = 3;
			this.lblAcao.Text = "Adicionando Novo Registro";
			this.lblAcao.Visible = false;
			// 
			// btnSubir
			// 
			this.btnSubir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSubir.FlatAppearance.BorderSize = 0;
			this.btnSubir.Image = global::CamadaUI.Properties.Resources.top_arrow_32;
			this.btnSubir.Location = new System.Drawing.Point(490, 362);
			this.btnSubir.Name = "btnSubir";
			this.btnSubir.Size = new System.Drawing.Size(38, 43);
			this.btnSubir.TabIndex = 3;
			this.btnSubir.TabStop = false;
			this.btnSubir.UseVisualStyleBackColor = true;
			this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
			// 
			// btnDescer
			// 
			this.btnDescer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDescer.FlatAppearance.BorderSize = 0;
			this.btnDescer.Image = global::CamadaUI.Properties.Resources.down_arrow_32;
			this.btnDescer.Location = new System.Drawing.Point(489, 411);
			this.btnDescer.Name = "btnDescer";
			this.btnDescer.Size = new System.Drawing.Size(38, 43);
			this.btnDescer.TabIndex = 4;
			this.btnDescer.TabStop = false;
			this.btnDescer.UseVisualStyleBackColor = true;
			this.btnDescer.Click += new System.EventHandler(this.btnDescer_Click);
			// 
			// frmFuncaoControle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(534, 514);
			this.Controls.Add(this.btnDescer);
			this.Controls.Add(this.btnSubir);
			this.Controls.Add(this.dgvListagem);
			this.Controls.Add(this.tspMenu);
			this.Name = "frmFuncaoControle";
			this.Padding = new System.Windows.Forms.Padding(2);
			this.Shown += new System.EventHandler(this.frmFuncaoControle_Shown);
			this.Controls.SetChildIndex(this.tspMenu, 0);
			this.Controls.SetChildIndex(this.dgvListagem, 0);
			this.Controls.SetChildIndex(this.btnSubir, 0);
			this.Controls.SetChildIndex(this.btnDescer, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tspMenu.ResumeLayout(false);
			this.tspMenu.PerformLayout();
			this.MenuListagem.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ToolStrip tspMenu;
		private System.Windows.Forms.ToolStripButton btnNovo;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnSalvar;
		private System.Windows.Forms.ToolStripButton btnCancelar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnFechar;
		internal System.Windows.Forms.ContextMenuStrip MenuListagem;
		internal System.Windows.Forms.ToolStripMenuItem mnuAtivar;
		internal System.Windows.Forms.ToolStripMenuItem mnuDesativar;
		internal CamadaUC.ucDataGridView dgvListagem;
		private System.Windows.Forms.Label lblAcao;
		private System.Windows.Forms.Button btnSubir;
		private System.Windows.Forms.Button btnDescer;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnPosicao;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnCadastro;
		private System.Windows.Forms.DataGridViewImageColumn clnImage;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem mnuExcluir;
	}
}
