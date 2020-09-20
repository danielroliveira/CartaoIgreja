namespace CamadaUI.Membros
{
	partial class frmMembroListagem
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
			this.btnFechar = new System.Windows.Forms.Button();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.txtProcura = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.dgvListagem = new System.Windows.Forms.DataGridView();
			this.clnRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnMembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnFuncao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnCongregacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnImprimir = new System.Windows.Forms.DataGridViewImageColumn();
			this.clnEmissaoData = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnValidadeData = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MenuListagem = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuImprimir = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuNaoImprimir = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuAtivar = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDesativar = new System.Windows.Forms.ToolStripMenuItem();
			this.transferênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.desligamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.falecimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnCongregacaoEscolher = new System.Windows.Forms.Button();
			this.txtCongregacao = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.txtFuncao = new System.Windows.Forms.TextBox();
			this.lblFunção = new System.Windows.Forms.Label();
			this.btnSetFuncao = new System.Windows.Forms.Button();
			this.btnEscolher = new System.Windows.Forms.Button();
			this.btnSetSituacao = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSituacao = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).BeginInit();
			this.MenuListagem.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(698, 0);
			this.lblTitulo.Size = new System.Drawing.Size(374, 50);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Membros";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(1072, 0);
			this.btnClose.TabIndex = 1;
			this.btnClose.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(1112, 50);
			// 
			// btnFechar
			// 
			this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFechar.Image = global::CamadaUI.Properties.Resources.delete_16;
			this.btnFechar.Location = new System.Drawing.Point(964, 541);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(126, 42);
			this.btnFechar.TabIndex = 16;
			this.btnFechar.Text = "&Fechar";
			this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAdicionar.Image = global::CamadaUI.Properties.Resources.add_16;
			this.btnAdicionar.Location = new System.Drawing.Point(165, 541);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(126, 42);
			this.btnAdicionar.TabIndex = 14;
			this.btnAdicionar.Text = "&Adicionar";
			this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEditar.Image = global::CamadaUI.Properties.Resources.editar_16;
			this.btnEditar.Location = new System.Drawing.Point(22, 541);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(126, 42);
			this.btnEditar.TabIndex = 13;
			this.btnEditar.Text = "&Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// txtProcura
			// 
			this.txtProcura.Location = new System.Drawing.Point(22, 80);
			this.txtProcura.Margin = new System.Windows.Forms.Padding(6);
			this.txtProcura.Name = "txtProcura";
			this.txtProcura.Size = new System.Drawing.Size(282, 27);
			this.txtProcura.TabIndex = 2;
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(18, 58);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(100, 19);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Procura Nome";
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
            this.clnRG,
            this.clnMembro,
            this.clnFuncao,
            this.clnCongregacao,
            this.clnImprimir,
            this.clnEmissaoData,
            this.clnValidadeData});
			this.dgvListagem.EnableHeadersVisualStyles = false;
			this.dgvListagem.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvListagem.Location = new System.Drawing.Point(22, 124);
			this.dgvListagem.MultiSelect = false;
			this.dgvListagem.Name = "dgvListagem";
			this.dgvListagem.ReadOnly = true;
			this.dgvListagem.RowHeadersVisible = false;
			this.dgvListagem.RowHeadersWidth = 45;
			this.dgvListagem.RowTemplate.Height = 30;
			this.dgvListagem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvListagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListagem.Size = new System.Drawing.Size(1068, 404);
			this.dgvListagem.TabIndex = 12;
			this.dgvListagem.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListagem_CellFormatting);
			this.dgvListagem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListagem_KeyDown);
			this.dgvListagem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvListagem_MouseDown);
			// 
			// clnRG
			// 
			this.clnRG.HeaderText = "Reg.";
			this.clnRG.Name = "clnRG";
			this.clnRG.ReadOnly = true;
			this.clnRG.Width = 70;
			// 
			// clnMembro
			// 
			this.clnMembro.HeaderText = "Nome do Membro";
			this.clnMembro.Name = "clnMembro";
			this.clnMembro.ReadOnly = true;
			this.clnMembro.Width = 350;
			// 
			// clnFuncao
			// 
			this.clnFuncao.HeaderText = "Função";
			this.clnFuncao.Name = "clnFuncao";
			this.clnFuncao.ReadOnly = true;
			this.clnFuncao.Width = 120;
			// 
			// clnCongregacao
			// 
			this.clnCongregacao.HeaderText = "Congregacão";
			this.clnCongregacao.Name = "clnCongregacao";
			this.clnCongregacao.ReadOnly = true;
			this.clnCongregacao.Width = 200;
			// 
			// clnImprimir
			// 
			this.clnImprimir.HeaderText = "Print";
			this.clnImprimir.Name = "clnImprimir";
			this.clnImprimir.ReadOnly = true;
			this.clnImprimir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.clnImprimir.Width = 70;
			// 
			// clnEmissaoData
			// 
			this.clnEmissaoData.HeaderText = "E.Data";
			this.clnEmissaoData.Name = "clnEmissaoData";
			this.clnEmissaoData.ReadOnly = true;
			// 
			// clnValidadeData
			// 
			this.clnValidadeData.HeaderText = "V.Data";
			this.clnValidadeData.Name = "clnValidadeData";
			this.clnValidadeData.ReadOnly = true;
			// 
			// MenuListagem
			// 
			this.MenuListagem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MenuListagem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuImprimir,
            this.mnuNaoImprimir,
            this.toolStripSeparator1,
            this.mnuAtivar,
            this.mnuDesativar});
			this.MenuListagem.Name = "MenuFab";
			this.MenuListagem.Size = new System.Drawing.Size(230, 114);
			// 
			// mnuImprimir
			// 
			this.mnuImprimir.Image = global::CamadaUI.Properties.Resources.print_16;
			this.mnuImprimir.Name = "mnuImprimir";
			this.mnuImprimir.Size = new System.Drawing.Size(229, 26);
			this.mnuImprimir.Tag = "True";
			this.mnuImprimir.Text = "Marcar para Imprimir";
			this.mnuImprimir.Click += new System.EventHandler(this.ImprimirMarcarDesmarcar_Click);
			// 
			// mnuNaoImprimir
			// 
			this.mnuNaoImprimir.Image = global::CamadaUI.Properties.Resources.block_16;
			this.mnuNaoImprimir.Name = "mnuNaoImprimir";
			this.mnuNaoImprimir.Size = new System.Drawing.Size(229, 26);
			this.mnuNaoImprimir.Tag = "False";
			this.mnuNaoImprimir.Text = "Desmarcar Imprimir";
			this.mnuNaoImprimir.Click += new System.EventHandler(this.ImprimirMarcarDesmarcar_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
			// 
			// mnuAtivar
			// 
			this.mnuAtivar.Image = global::CamadaUI.Properties.Resources.accept_16;
			this.mnuAtivar.Name = "mnuAtivar";
			this.mnuAtivar.Size = new System.Drawing.Size(229, 26);
			this.mnuAtivar.Tag = "1";
			this.mnuAtivar.Text = "Ativar Membro";
			this.mnuAtivar.Click += new System.EventHandler(this.mnuAlterarSituacao_Click);
			// 
			// mnuDesativar
			// 
			this.mnuDesativar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferênciaToolStripMenuItem,
            this.desligamentoToolStripMenuItem,
            this.falecimentoToolStripMenuItem});
			this.mnuDesativar.Name = "mnuDesativar";
			this.mnuDesativar.Size = new System.Drawing.Size(229, 26);
			this.mnuDesativar.Text = "Desativar";
			// 
			// transferênciaToolStripMenuItem
			// 
			this.transferênciaToolStripMenuItem.Image = global::CamadaUI.Properties.Resources.refresh_16;
			this.transferênciaToolStripMenuItem.Name = "transferênciaToolStripMenuItem";
			this.transferênciaToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
			this.transferênciaToolStripMenuItem.Tag = "3";
			this.transferênciaToolStripMenuItem.Text = "Transferência";
			this.transferênciaToolStripMenuItem.Click += new System.EventHandler(this.mnuAlterarSituacao_Click);
			// 
			// desligamentoToolStripMenuItem
			// 
			this.desligamentoToolStripMenuItem.Image = global::CamadaUI.Properties.Resources.refresh_16;
			this.desligamentoToolStripMenuItem.Name = "desligamentoToolStripMenuItem";
			this.desligamentoToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
			this.desligamentoToolStripMenuItem.Tag = "2";
			this.desligamentoToolStripMenuItem.Text = "Desligamento";
			this.desligamentoToolStripMenuItem.Click += new System.EventHandler(this.mnuAlterarSituacao_Click);
			// 
			// falecimentoToolStripMenuItem
			// 
			this.falecimentoToolStripMenuItem.Image = global::CamadaUI.Properties.Resources.refresh_16;
			this.falecimentoToolStripMenuItem.Name = "falecimentoToolStripMenuItem";
			this.falecimentoToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
			this.falecimentoToolStripMenuItem.Tag = "4";
			this.falecimentoToolStripMenuItem.Text = "Falecimento";
			this.falecimentoToolStripMenuItem.Click += new System.EventHandler(this.mnuAlterarSituacao_Click);
			// 
			// btnCongregacaoEscolher
			// 
			this.btnCongregacaoEscolher.BackColor = System.Drawing.Color.Transparent;
			this.btnCongregacaoEscolher.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCongregacaoEscolher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCongregacaoEscolher.Location = new System.Drawing.Point(627, 80);
			this.btnCongregacaoEscolher.Name = "btnCongregacaoEscolher";
			this.btnCongregacaoEscolher.Size = new System.Drawing.Size(34, 27);
			this.btnCongregacaoEscolher.TabIndex = 5;
			this.btnCongregacaoEscolher.TabStop = false;
			this.btnCongregacaoEscolher.Text = "...";
			this.btnCongregacaoEscolher.UseCompatibleTextRendering = true;
			this.btnCongregacaoEscolher.UseVisualStyleBackColor = false;
			this.btnCongregacaoEscolher.Click += new System.EventHandler(this.btnCongregacaoEscolher_Click);
			// 
			// txtCongregacao
			// 
			this.txtCongregacao.Location = new System.Drawing.Point(318, 80);
			this.txtCongregacao.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtCongregacao.MaxLength = 30;
			this.txtCongregacao.Name = "txtCongregacao";
			this.txtCongregacao.Size = new System.Drawing.Size(303, 27);
			this.txtCongregacao.TabIndex = 4;
			this.txtCongregacao.Tag = "Pressione a tecla (+) para procurar";
			this.txtCongregacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
			// 
			// Label6
			// 
			this.Label6.AutoSize = true;
			this.Label6.BackColor = System.Drawing.Color.Transparent;
			this.Label6.ForeColor = System.Drawing.Color.Black;
			this.Label6.Location = new System.Drawing.Point(314, 58);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(94, 19);
			this.Label6.TabIndex = 3;
			this.Label6.Text = "Congregação";
			// 
			// txtFuncao
			// 
			this.txtFuncao.Location = new System.Drawing.Point(678, 80);
			this.txtFuncao.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtFuncao.MaxLength = 30;
			this.txtFuncao.Name = "txtFuncao";
			this.txtFuncao.Size = new System.Drawing.Size(153, 27);
			this.txtFuncao.TabIndex = 7;
			this.txtFuncao.Tag = "Pressione a tecla (+) para procurar";
			this.txtFuncao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
			// 
			// lblFunção
			// 
			this.lblFunção.AutoSize = true;
			this.lblFunção.BackColor = System.Drawing.Color.Transparent;
			this.lblFunção.ForeColor = System.Drawing.Color.Black;
			this.lblFunção.Location = new System.Drawing.Point(674, 58);
			this.lblFunção.Name = "lblFunção";
			this.lblFunção.Size = new System.Drawing.Size(55, 19);
			this.lblFunção.TabIndex = 6;
			this.lblFunção.Text = "Função";
			// 
			// btnSetFuncao
			// 
			this.btnSetFuncao.BackColor = System.Drawing.Color.Transparent;
			this.btnSetFuncao.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSetFuncao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSetFuncao.Location = new System.Drawing.Point(837, 80);
			this.btnSetFuncao.Name = "btnSetFuncao";
			this.btnSetFuncao.Size = new System.Drawing.Size(34, 27);
			this.btnSetFuncao.TabIndex = 8;
			this.btnSetFuncao.TabStop = false;
			this.btnSetFuncao.Text = "...";
			this.btnSetFuncao.UseCompatibleTextRendering = true;
			this.btnSetFuncao.UseVisualStyleBackColor = false;
			this.btnSetFuncao.Click += new System.EventHandler(this.btnSetFuncao_Click);
			// 
			// btnEscolher
			// 
			this.btnEscolher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEscolher.Image = global::CamadaUI.Properties.Resources.accept_24;
			this.btnEscolher.Location = new System.Drawing.Point(422, 541);
			this.btnEscolher.Name = "btnEscolher";
			this.btnEscolher.Size = new System.Drawing.Size(276, 42);
			this.btnEscolher.TabIndex = 15;
			this.btnEscolher.Text = "&Escolher";
			this.btnEscolher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEscolher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEscolher.UseVisualStyleBackColor = true;
			this.btnEscolher.Visible = false;
			this.btnEscolher.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnSetSituacao
			// 
			this.btnSetSituacao.BackColor = System.Drawing.Color.Transparent;
			this.btnSetSituacao.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSetSituacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSetSituacao.Location = new System.Drawing.Point(1055, 80);
			this.btnSetSituacao.Name = "btnSetSituacao";
			this.btnSetSituacao.Size = new System.Drawing.Size(34, 27);
			this.btnSetSituacao.TabIndex = 11;
			this.btnSetSituacao.TabStop = false;
			this.btnSetSituacao.Text = "...";
			this.btnSetSituacao.UseCompatibleTextRendering = true;
			this.btnSetSituacao.UseVisualStyleBackColor = false;
			this.btnSetSituacao.Click += new System.EventHandler(this.btnSetSituacao_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(892, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 19);
			this.label3.TabIndex = 9;
			this.label3.Text = "Situação";
			// 
			// txtSituacao
			// 
			this.txtSituacao.Location = new System.Drawing.Point(896, 80);
			this.txtSituacao.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.txtSituacao.MaxLength = 30;
			this.txtSituacao.Name = "txtSituacao";
			this.txtSituacao.Size = new System.Drawing.Size(153, 27);
			this.txtSituacao.TabIndex = 10;
			this.txtSituacao.Tag = "Pressione a tecla (+) para procurar";
			this.txtSituacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
			// 
			// frmMembroListagem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(1112, 595);
			this.Controls.Add(this.txtSituacao);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtFuncao);
			this.Controls.Add(this.btnSetSituacao);
			this.Controls.Add(this.lblFunção);
			this.Controls.Add(this.btnSetFuncao);
			this.Controls.Add(this.btnCongregacaoEscolher);
			this.Controls.Add(this.txtCongregacao);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.dgvListagem);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.btnEscolher);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.txtProcura);
			this.Controls.Add(this.Label1);
			this.KeyPreview = true;
			this.Name = "frmMembroListagem";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMembroListagem_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_KeyPress);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.Label1, 0);
			this.Controls.SetChildIndex(this.txtProcura, 0);
			this.Controls.SetChildIndex(this.btnEditar, 0);
			this.Controls.SetChildIndex(this.btnAdicionar, 0);
			this.Controls.SetChildIndex(this.btnEscolher, 0);
			this.Controls.SetChildIndex(this.btnFechar, 0);
			this.Controls.SetChildIndex(this.dgvListagem, 0);
			this.Controls.SetChildIndex(this.Label6, 0);
			this.Controls.SetChildIndex(this.txtCongregacao, 0);
			this.Controls.SetChildIndex(this.btnCongregacaoEscolher, 0);
			this.Controls.SetChildIndex(this.btnSetFuncao, 0);
			this.Controls.SetChildIndex(this.lblFunção, 0);
			this.Controls.SetChildIndex(this.btnSetSituacao, 0);
			this.Controls.SetChildIndex(this.txtFuncao, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.txtSituacao, 0);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).EndInit();
			this.MenuListagem.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button btnFechar;
		internal System.Windows.Forms.Button btnAdicionar;
		internal System.Windows.Forms.Button btnEditar;
		internal System.Windows.Forms.TextBox txtProcura;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.DataGridView dgvListagem;
		internal System.Windows.Forms.ContextMenuStrip MenuListagem;
		internal System.Windows.Forms.ToolStripMenuItem mnuImprimir;
		internal System.Windows.Forms.ToolStripMenuItem mnuNaoImprimir;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem mnuAtivar;
		private System.Windows.Forms.ToolStripMenuItem mnuDesativar;
		private System.Windows.Forms.ToolStripMenuItem transferênciaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem desligamentoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem falecimentoToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnRG;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnMembro;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnFuncao;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnCongregacao;
		private System.Windows.Forms.DataGridViewImageColumn clnImprimir;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnEmissaoData;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnValidadeData;
		internal System.Windows.Forms.Button btnCongregacaoEscolher;
		internal System.Windows.Forms.TextBox txtCongregacao;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txtFuncao;
		internal System.Windows.Forms.Label lblFunção;
		internal System.Windows.Forms.Button btnSetFuncao;
		internal System.Windows.Forms.Button btnEscolher;
		internal System.Windows.Forms.Button btnSetSituacao;
		internal System.Windows.Forms.Label label3;
		internal System.Windows.Forms.TextBox txtSituacao;
	}
}
