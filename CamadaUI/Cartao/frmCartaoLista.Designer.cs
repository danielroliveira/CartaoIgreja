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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnFechar = new System.Windows.Forms.Button();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.btnPrintConcluido = new System.Windows.Forms.Button();
			this.dgvListagem = new System.Windows.Forms.DataGridView();
			this.clnRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnMembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnFuncao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnCongregacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MenuListagem = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.editarMembroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removerDaListaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btnRemover = new System.Windows.Forms.Button();
			this.btnPrintFrente = new System.Windows.Forms.Button();
			this.btnPrintAtras = new System.Windows.Forms.Button();
			this.lblMarcados = new System.Windows.Forms.Label();
			this.lblNaLista = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).BeginInit();
			this.MenuListagem.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(564, 0);
			this.lblTitulo.Size = new System.Drawing.Size(240, 50);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Lista de Impressão";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(804, 0);
			this.btnClose.TabIndex = 1;
			this.btnClose.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(844, 50);
			// 
			// btnFechar
			// 
			this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFechar.Image = global::CamadaUI.Properties.Resources.delete_16;
			this.btnFechar.Location = new System.Drawing.Point(696, 551);
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
			// btnPrintConcluido
			// 
			this.btnPrintConcluido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPrintConcluido.Image = global::CamadaUI.Properties.Resources.accept_24;
			this.btnPrintConcluido.Location = new System.Drawing.Point(422, 551);
			this.btnPrintConcluido.Name = "btnPrintConcluido";
			this.btnPrintConcluido.Size = new System.Drawing.Size(194, 42);
			this.btnPrintConcluido.TabIndex = 6;
			this.btnPrintConcluido.Text = "&Impressão Concluída";
			this.btnPrintConcluido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPrintConcluido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrintConcluido.UseVisualStyleBackColor = true;
			this.btnPrintConcluido.Click += new System.EventHandler(this.btnPrintConcluido_Click);
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
			this.dgvListagem.Size = new System.Drawing.Size(800, 381);
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
			this.clnMembro.Width = 340;
			// 
			// clnFuncao
			// 
			this.clnFuncao.HeaderText = "Função";
			this.clnFuncao.Name = "clnFuncao";
			this.clnFuncao.ReadOnly = true;
			this.clnFuncao.Width = 140;
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
            this.removerDaListaToolStripMenuItem});
			this.MenuListagem.Name = "MenuFab";
			this.MenuListagem.Size = new System.Drawing.Size(201, 56);
			// 
			// editarMembroToolStripMenuItem
			// 
			this.editarMembroToolStripMenuItem.Image = global::CamadaUI.Properties.Resources.edit_profile;
			this.editarMembroToolStripMenuItem.Name = "editarMembroToolStripMenuItem";
			this.editarMembroToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
			this.editarMembroToolStripMenuItem.Text = "Editar Membro";
			this.editarMembroToolStripMenuItem.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// removerDaListaToolStripMenuItem
			// 
			this.removerDaListaToolStripMenuItem.Image = global::CamadaUI.Properties.Resources.delete_16;
			this.removerDaListaToolStripMenuItem.Name = "removerDaListaToolStripMenuItem";
			this.removerDaListaToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
			this.removerDaListaToolStripMenuItem.Text = "Remover da Lista";
			this.removerDaListaToolStripMenuItem.Click += new System.EventHandler(this.btnRemover_Click);
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
			this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
			// 
			// btnPrintFrente
			// 
			this.btnPrintFrente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPrintFrente.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnPrintFrente.Image = global::CamadaUI.Properties.Resources.Imprimir_30;
			this.btnPrintFrente.Location = new System.Drawing.Point(22, 551);
			this.btnPrintFrente.Name = "btnPrintFrente";
			this.btnPrintFrente.Size = new System.Drawing.Size(194, 42);
			this.btnPrintFrente.TabIndex = 9;
			this.btnPrintFrente.Text = "&Imprimir FRENTE";
			this.btnPrintFrente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPrintFrente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrintFrente.UseVisualStyleBackColor = true;
			this.btnPrintFrente.Click += new System.EventHandler(this.btnPrintFrente_Click);
			// 
			// btnPrintAtras
			// 
			this.btnPrintAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPrintAtras.ForeColor = System.Drawing.Color.DarkRed;
			this.btnPrintAtras.Image = global::CamadaUI.Properties.Resources.Imprimir_30;
			this.btnPrintAtras.Location = new System.Drawing.Point(222, 551);
			this.btnPrintAtras.Name = "btnPrintAtras";
			this.btnPrintAtras.Size = new System.Drawing.Size(194, 42);
			this.btnPrintAtras.TabIndex = 9;
			this.btnPrintAtras.Text = "&Imprimir VERSO";
			this.btnPrintAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPrintAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrintAtras.UseVisualStyleBackColor = true;
			this.btnPrintAtras.Click += new System.EventHandler(this.btnPrintAtras_Click);
			// 
			// lblMarcados
			// 
			this.lblMarcados.AutoSize = true;
			this.lblMarcados.Font = new System.Drawing.Font("Pathway Gothic One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMarcados.Location = new System.Drawing.Point(24, 516);
			this.lblMarcados.Name = "lblMarcados";
			this.lblMarcados.Size = new System.Drawing.Size(299, 24);
			this.lblMarcados.TabIndex = 10;
			this.lblMarcados.Text = "Nenhum Membro foi marcado para impressão";
			// 
			// lblNaLista
			// 
			this.lblNaLista.Font = new System.Drawing.Font("Pathway Gothic One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNaLista.Location = new System.Drawing.Point(374, 69);
			this.lblNaLista.Name = "lblNaLista";
			this.lblNaLista.Size = new System.Drawing.Size(446, 33);
			this.lblNaLista.TabIndex = 10;
			this.lblNaLista.Text = "Nenhum Membro na Lista de Impressão";
			this.lblNaLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmCartaoLista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(844, 605);
			this.Controls.Add(this.lblNaLista);
			this.Controls.Add(this.lblMarcados);
			this.Controls.Add(this.btnPrintAtras);
			this.Controls.Add(this.btnPrintFrente);
			this.Controls.Add(this.dgvListagem);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.btnRemover);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.btnPrintConcluido);
			this.KeyPreview = true;
			this.Name = "frmCartaoLista";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCartaoLista_KeyDown);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.btnPrintConcluido, 0);
			this.Controls.SetChildIndex(this.btnAdicionar, 0);
			this.Controls.SetChildIndex(this.btnRemover, 0);
			this.Controls.SetChildIndex(this.btnFechar, 0);
			this.Controls.SetChildIndex(this.dgvListagem, 0);
			this.Controls.SetChildIndex(this.btnPrintFrente, 0);
			this.Controls.SetChildIndex(this.btnPrintAtras, 0);
			this.Controls.SetChildIndex(this.lblMarcados, 0);
			this.Controls.SetChildIndex(this.lblNaLista, 0);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).EndInit();
			this.MenuListagem.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button btnFechar;
		internal System.Windows.Forms.Button btnAdicionar;
		internal System.Windows.Forms.Button btnPrintConcluido;
		internal System.Windows.Forms.DataGridView dgvListagem;
		internal System.Windows.Forms.ContextMenuStrip MenuListagem;
		internal System.Windows.Forms.Button btnRemover;
		internal System.Windows.Forms.Button btnPrintFrente;
		internal System.Windows.Forms.Button btnPrintAtras;
		private System.Windows.Forms.ToolStripMenuItem editarMembroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removerDaListaToolStripMenuItem;
		private System.Windows.Forms.Label lblMarcados;
		private System.Windows.Forms.Label lblNaLista;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnRG;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnMembro;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnFuncao;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnCongregacao;
	}
}
