namespace CamadaUI.Cartao
{
	partial class frmCartaoLista
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnFechar = new System.Windows.Forms.Button();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.btnConcluido = new System.Windows.Forms.Button();
			this.dgvListagem = new System.Windows.Forms.DataGridView();
			this.clnRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnMembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnFuncao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnCongregacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MenuListagem = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.mnuImprimir = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuNaoImprimir = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuAtivar = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuDesativar = new System.Windows.Forms.ToolStripMenuItem();
			this.transferênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.desligamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.falecimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnRemover = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.editarMembroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removerDaListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).BeginInit();
			this.MenuListagem.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(562, 0);
			this.lblTitulo.Size = new System.Drawing.Size(240, 50);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Lista de Impressão";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(802, 0);
			this.btnClose.TabIndex = 1;
			this.btnClose.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(842, 50);
			// 
			// btnFechar
			// 
			this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFechar.Image = global::CamadaUI.Properties.Resources.delete_16;
			this.btnFechar.Location = new System.Drawing.Point(694, 540);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(126, 42);
			this.btnFechar.TabIndex = 8;
			this.btnFechar.Text = "&Fechar";
			this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.Image = global::CamadaUI.Properties.Resources.add_16;
			this.btnAdicionar.Location = new System.Drawing.Point(22, 66);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(126, 42);
			this.btnAdicionar.TabIndex = 7;
			this.btnAdicionar.Text = "&Adicionar";
			this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// btnConcluido
			// 
			this.btnConcluido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnConcluido.Image = global::CamadaUI.Properties.Resources.accept_24;
			this.btnConcluido.Location = new System.Drawing.Point(422, 540);
			this.btnConcluido.Name = "btnConcluido";
			this.btnConcluido.Size = new System.Drawing.Size(194, 42);
			this.btnConcluido.TabIndex = 6;
			this.btnConcluido.Text = "&Impressão Concluída";
			this.btnConcluido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnConcluido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnConcluido.UseVisualStyleBackColor = true;
			// 
			// dgvListagem
			// 
			this.dgvListagem.AllowUserToAddRows = false;
			this.dgvListagem.AllowUserToDeleteRows = false;
			this.dgvListagem.AllowUserToResizeColumns = false;
			this.dgvListagem.AllowUserToResizeRows = false;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.OldLace;
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
			this.dgvListagem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvListagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvListagem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgvListagem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSteelBlue;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Navy;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvListagem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvListagem.ColumnHeadersHeight = 33;
			this.dgvListagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvListagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnRG,
            this.clnMembro,
            this.clnFuncao,
            this.clnCongregacao});
			this.dgvListagem.EnableHeadersVisualStyles = false;
			this.dgvListagem.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvListagem.Location = new System.Drawing.Point(22, 123);
			this.dgvListagem.MultiSelect = false;
			this.dgvListagem.Name = "dgvListagem";
			this.dgvListagem.ReadOnly = true;
			this.dgvListagem.RowHeadersVisible = false;
			this.dgvListagem.RowHeadersWidth = 45;
			this.dgvListagem.RowTemplate.Height = 30;
			this.dgvListagem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvListagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListagem.Size = new System.Drawing.Size(798, 404);
			this.dgvListagem.TabIndex = 5;
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
			this.clnCongregacao.HeaderText = "Congregação";
			this.clnCongregacao.Name = "clnCongregacao";
			this.clnCongregacao.ReadOnly = true;
			this.clnCongregacao.Width = 200;
			// 
			// MenuListagem
			// 
			this.MenuListagem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MenuListagem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarMembroToolStripMenuItem,
            this.removerDaListaToolStripMenuItem,
            this.mnuImprimir,
            this.mnuNaoImprimir,
            this.toolStripSeparator1,
            this.mnuAtivar,
            this.mnuDesativar});
			this.MenuListagem.Name = "MenuFab";
			this.MenuListagem.Size = new System.Drawing.Size(230, 166);
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
			// btnRemover
			// 
			this.btnRemover.Image = global::CamadaUI.Properties.Resources.delete_16;
			this.btnRemover.Location = new System.Drawing.Point(154, 66);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(126, 42);
			this.btnRemover.TabIndex = 7;
			this.btnRemover.Text = "&Remover";
			this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRemover.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRemover.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.ForeColor = System.Drawing.Color.MediumBlue;
			this.button1.Image = global::CamadaUI.Properties.Resources.Imprimir_30;
			this.button1.Location = new System.Drawing.Point(22, 540);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(194, 42);
			this.button1.TabIndex = 9;
			this.button1.Text = "&Imprimir FRENTE";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button2.ForeColor = System.Drawing.Color.DarkRed;
			this.button2.Image = global::CamadaUI.Properties.Resources.Imprimir_30;
			this.button2.Location = new System.Drawing.Point(222, 540);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(194, 42);
			this.button2.TabIndex = 9;
			this.button2.Text = "&Imprimir VERSO";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// editarMembroToolStripMenuItem
			// 
			this.editarMembroToolStripMenuItem.Image = global::CamadaUI.Properties.Resources.edit_profile;
			this.editarMembroToolStripMenuItem.Name = "editarMembroToolStripMenuItem";
			this.editarMembroToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
			this.editarMembroToolStripMenuItem.Text = "Editar Membro";
			// 
			// removerDaListaToolStripMenuItem
			// 
			this.removerDaListaToolStripMenuItem.Image = global::CamadaUI.Properties.Resources.delete_16;
			this.removerDaListaToolStripMenuItem.Name = "removerDaListaToolStripMenuItem";
			this.removerDaListaToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
			this.removerDaListaToolStripMenuItem.Text = "Remover da Lista";
			// 
			// frmCartaoLista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(842, 594);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dgvListagem);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.btnRemover);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.btnConcluido);
			this.KeyPreview = true;
			this.Name = "frmCartaoLista";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCartaoLista_KeyDown);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.btnConcluido, 0);
			this.Controls.SetChildIndex(this.btnAdicionar, 0);
			this.Controls.SetChildIndex(this.btnRemover, 0);
			this.Controls.SetChildIndex(this.btnFechar, 0);
			this.Controls.SetChildIndex(this.dgvListagem, 0);
			this.Controls.SetChildIndex(this.button1, 0);
			this.Controls.SetChildIndex(this.button2, 0);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).EndInit();
			this.MenuListagem.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.Button btnFechar;
		internal System.Windows.Forms.Button btnAdicionar;
		internal System.Windows.Forms.Button btnConcluido;
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
		internal System.Windows.Forms.Button btnRemover;
		internal System.Windows.Forms.Button button1;
		internal System.Windows.Forms.Button button2;
		private System.Windows.Forms.ToolStripMenuItem editarMembroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removerDaListaToolStripMenuItem;
	}
}
