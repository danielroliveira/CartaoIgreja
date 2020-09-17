namespace CamadaUI.Membros
{
	partial class frmCongregacaoProcura
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
			this.btnFechar = new System.Windows.Forms.Button();
			this.btnEscolher = new System.Windows.Forms.Button();
			this.lstItens = new ComponentOwl.BetterListView.BetterListView();
			this.clnID = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.clnItem = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtProcura = new CamadaUC.ucTextBoxUnclicked();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lstItens)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(96, 0);
			this.lblTitulo.Size = new System.Drawing.Size(245, 50);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Escolher Congregação";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(341, 0);
			this.btnClose.TabIndex = 1;
			this.btnClose.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(381, 50);
			// 
			// btnFechar
			// 
			this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnFechar.Image = global::CamadaUI.Properties.Resources.delete_24;
			this.btnFechar.Location = new System.Drawing.Point(216, 495);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(142, 42);
			this.btnFechar.TabIndex = 5;
			this.btnFechar.Text = "&Cancelar";
			this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// btnEscolher
			// 
			this.btnEscolher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEscolher.Image = global::CamadaUI.Properties.Resources.accept_24;
			this.btnEscolher.Location = new System.Drawing.Point(22, 495);
			this.btnEscolher.Name = "btnEscolher";
			this.btnEscolher.Size = new System.Drawing.Size(142, 42);
			this.btnEscolher.TabIndex = 4;
			this.btnEscolher.Text = "&Escolher";
			this.btnEscolher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEscolher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEscolher.UseVisualStyleBackColor = true;
			this.btnEscolher.Click += new System.EventHandler(this.btnEscolher_Click);
			// 
			// lstItens
			// 
			this.lstItens.ColorSortedColumn = System.Drawing.Color.Transparent;
			this.lstItens.Columns.Add(this.clnID);
			this.lstItens.Columns.Add(this.clnItem);
			this.lstItens.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstItens.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.Nonclickable;
			this.lstItens.HideSelectionMode = ComponentOwl.BetterListView.BetterListViewHideSelectionMode.KeepSelection;
			this.lstItens.HotTracking = ComponentOwl.BetterListView.BetterListViewHotTracking.ItemHot;
			this.lstItens.Location = new System.Drawing.Point(22, 105);
			this.lstItens.Name = "lstItens";
			this.lstItens.Size = new System.Drawing.Size(336, 378);
			this.lstItens.TabIndex = 3;
			this.lstItens.ItemActivate += new ComponentOwl.BetterListView.BetterListViewItemActivateEventHandler(this.lstItens_ItemActivate);
			this.lstItens.DrawColumnHeader += new ComponentOwl.BetterListView.BetterListViewDrawColumnHeaderEventHandler(this.lstItens_DrawColumnHeader);
			this.lstItens.DrawItem += new ComponentOwl.BetterListView.BetterListViewDrawItemEventHandler(this.lstItens_DrawItem);
			// 
			// clnID
			// 
			this.clnID.AllowResize = false;
			this.clnID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clnID.Name = "clnID";
			this.clnID.Text = "Reg.";
			this.clnID.Width = 60;
			// 
			// clnItem
			// 
			this.clnItem.AllowResize = false;
			this.clnItem.Name = "clnItem";
			this.clnItem.Text = "Congregação";
			this.clnItem.Width = 230;
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(22, 67);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(58, 19);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Procura";
			// 
			// txtProcura
			// 
			this.txtProcura.Location = new System.Drawing.Point(86, 64);
			this.txtProcura.Name = "txtProcura";
			this.txtProcura.SelectionHighlightEnabled = false;
			this.txtProcura.Size = new System.Drawing.Size(272, 27);
			this.txtProcura.TabIndex = 6;
			this.txtProcura.TabStop = false;
			this.txtProcura.TextChanged += new System.EventHandler(this.txtProcura_TextChanged);
			// 
			// frmCongregacaoProcura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(381, 549);
			this.Controls.Add(this.txtProcura);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.lstItens);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.btnEscolher);
			this.KeyPreview = true;
			this.Name = "frmCongregacaoProcura";
			this.Activated += new System.EventHandler(this.frmCongregacaoProcura_Activated);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCongregacaoProcura_FormClosed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_KeyPress);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.btnEscolher, 0);
			this.Controls.SetChildIndex(this.btnFechar, 0);
			this.Controls.SetChildIndex(this.lstItens, 0);
			this.Controls.SetChildIndex(this.Label1, 0);
			this.Controls.SetChildIndex(this.txtProcura, 0);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lstItens)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button btnFechar;
		internal System.Windows.Forms.Button btnEscolher;
		internal ComponentOwl.BetterListView.BetterListView lstItens;
		internal ComponentOwl.BetterListView.BetterListViewColumnHeader clnID;
		internal ComponentOwl.BetterListView.BetterListViewColumnHeader clnItem;
		internal System.Windows.Forms.Label Label1;
		private CamadaUC.ucTextBoxUnclicked txtProcura;
	}
}
