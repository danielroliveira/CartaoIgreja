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
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.cmbAtivo = new CamadaUC.ucComboLimitedValues();
			this.dgvListagem = new System.Windows.Forms.DataGridView();
			this.MenuListagem = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.AtivarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.DesativarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clnRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnMembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnFuncao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnCongregacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clnImprimir = new System.Windows.Forms.DataGridViewImageColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).BeginInit();
			this.MenuListagem.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(706, 0);
			this.lblTitulo.Size = new System.Drawing.Size(162, 50);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Membros";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(868, 0);
			this.btnClose.TabIndex = 1;
			this.btnClose.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(908, 50);
			// 
			// btnFechar
			// 
			this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFechar.Image = global::CamadaUI.Properties.Resources.delete_16;
			this.btnFechar.Location = new System.Drawing.Point(760, 495);
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
			this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAdicionar.Image = global::CamadaUI.Properties.Resources.add_16;
			this.btnAdicionar.Location = new System.Drawing.Point(165, 495);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(126, 42);
			this.btnAdicionar.TabIndex = 7;
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
			this.btnEditar.Location = new System.Drawing.Point(22, 495);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(126, 42);
			this.btnEditar.TabIndex = 6;
			this.btnEditar.Text = "&Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// txtProcura
			// 
			this.txtProcura.Location = new System.Drawing.Point(90, 67);
			this.txtProcura.Margin = new System.Windows.Forms.Padding(6);
			this.txtProcura.Name = "txtProcura";
			this.txtProcura.Size = new System.Drawing.Size(282, 27);
			this.txtProcura.TabIndex = 2;
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(396, 70);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(64, 19);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Situação";
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(26, 70);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(58, 19);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Procura";
			// 
			// cmbAtivo
			// 
			this.cmbAtivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbAtivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbAtivo.FormattingEnabled = true;
			this.cmbAtivo.Location = new System.Drawing.Point(466, 67);
			this.cmbAtivo.Name = "cmbAtivo";
			this.cmbAtivo.Size = new System.Drawing.Size(103, 27);
			this.cmbAtivo.TabIndex = 4;
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
            this.clnImprimir});
			this.dgvListagem.EnableHeadersVisualStyles = false;
			this.dgvListagem.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvListagem.Location = new System.Drawing.Point(22, 111);
			this.dgvListagem.MultiSelect = false;
			this.dgvListagem.Name = "dgvListagem";
			this.dgvListagem.ReadOnly = true;
			this.dgvListagem.RowHeadersVisible = false;
			this.dgvListagem.RowHeadersWidth = 45;
			this.dgvListagem.RowTemplate.Height = 30;
			this.dgvListagem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvListagem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvListagem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvListagem.Size = new System.Drawing.Size(864, 371);
			this.dgvListagem.TabIndex = 5;
			this.dgvListagem.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListagem_CellFormatting);
			this.dgvListagem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvListagem_KeyDown);
			this.dgvListagem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvListagem_MouseDown);
			// 
			// MenuListagem
			// 
			this.MenuListagem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AtivarToolStripMenuItem,
            this.DesativarToolStripMenuItem});
			this.MenuListagem.Name = "MenuFab";
			this.MenuListagem.Size = new System.Drawing.Size(153, 48);
			// 
			// AtivarToolStripMenuItem
			// 
			this.AtivarToolStripMenuItem.Image = global::CamadaUI.Properties.Resources.accept_16;
			this.AtivarToolStripMenuItem.Name = "AtivarToolStripMenuItem";
			this.AtivarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.AtivarToolStripMenuItem.Text = "Ativar Setor";
			this.AtivarToolStripMenuItem.Click += new System.EventHandler(this.AtivarDesativar_Setor_Click);
			// 
			// DesativarToolStripMenuItem
			// 
			this.DesativarToolStripMenuItem.Image = global::CamadaUI.Properties.Resources.block_16;
			this.DesativarToolStripMenuItem.Name = "DesativarToolStripMenuItem";
			this.DesativarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.DesativarToolStripMenuItem.Text = "Desativar Setor";
			this.DesativarToolStripMenuItem.Click += new System.EventHandler(this.AtivarDesativar_Setor_Click);
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
			this.clnImprimir.HeaderText = "Imprimir";
			this.clnImprimir.Name = "clnImprimir";
			this.clnImprimir.ReadOnly = true;
			this.clnImprimir.Width = 70;
			// 
			// frmMembroListagem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(908, 549);
			this.Controls.Add(this.dgvListagem);
			this.Controls.Add(this.cmbAtivo);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.txtProcura);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.KeyPreview = true;
			this.Name = "frmMembroListagem";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMembroListagem_KeyDown);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.Label1, 0);
			this.Controls.SetChildIndex(this.Label2, 0);
			this.Controls.SetChildIndex(this.txtProcura, 0);
			this.Controls.SetChildIndex(this.btnEditar, 0);
			this.Controls.SetChildIndex(this.btnAdicionar, 0);
			this.Controls.SetChildIndex(this.btnFechar, 0);
			this.Controls.SetChildIndex(this.cmbAtivo, 0);
			this.Controls.SetChildIndex(this.dgvListagem, 0);
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
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		private CamadaUC.ucComboLimitedValues cmbAtivo;
		internal System.Windows.Forms.DataGridView dgvListagem;
		internal System.Windows.Forms.ContextMenuStrip MenuListagem;
		internal System.Windows.Forms.ToolStripMenuItem AtivarToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem DesativarToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnRG;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnMembro;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnFuncao;
		private System.Windows.Forms.DataGridViewTextBoxColumn clnCongregacao;
		private System.Windows.Forms.DataGridViewImageColumn clnImprimir;
	}
}
