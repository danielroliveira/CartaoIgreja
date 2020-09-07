namespace CamadaUI.Main
{
	partial class frmComboLista
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
			this.lstItens = new ComponentOwl.BetterListView.BetterListView();
			this.clnID = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			this.clnItem = new ComponentOwl.BetterListView.BetterListViewColumnHeader();
			((System.ComponentModel.ISupportInitialize)(this.lstItens)).BeginInit();
			this.SuspendLayout();
			// 
			// lstItens
			// 
			this.lstItens.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.lstItens.BackColor = System.Drawing.Color.AntiqueWhite;
			this.lstItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lstItens.Columns.Add(this.clnID);
			this.lstItens.Columns.Add(this.clnItem);
			this.lstItens.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstItens.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstItens.HeaderStyle = ComponentOwl.BetterListView.BetterListViewHeaderStyle.None;
			this.lstItens.HScrollBarDisplayMode = ComponentOwl.BetterListView.BetterListViewScrollBarDisplayMode.Hide;
			this.lstItens.Location = new System.Drawing.Point(1, 2);
			this.lstItens.Name = "lstItens";
			this.lstItens.ShowGroupExpandButtons = false;
			this.lstItens.Size = new System.Drawing.Size(247, 46);
			this.lstItens.TabIndex = 0;
			this.lstItens.VScrollBarDisplayMode = ComponentOwl.BetterListView.BetterListViewScrollBarDisplayMode.Hide;
			// 
			// clnID
			// 
			this.clnID.Name = "clnID";
			this.clnID.Text = "ID";
			this.clnID.Width = 40;
			// 
			// clnItem
			// 
			this.clnItem.Name = "clnItem";
			this.clnItem.Text = "Item";
			this.clnItem.Width = 200;
			// 
			// frmComboLista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSlateGray;
			this.ClientSize = new System.Drawing.Size(249, 50);
			this.Controls.Add(this.lstItens);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "frmComboLista";
			this.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
			this.Text = "frmComboLista";
			this.TopMost = true;
			this.Shown += new System.EventHandler(this.frmComboLista_Shown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmComboLista_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.lstItens)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private ComponentOwl.BetterListView.BetterListView lstItens;
		private ComponentOwl.BetterListView.BetterListViewColumnHeader clnID;
		private ComponentOwl.BetterListView.BetterListViewColumnHeader clnItem;
	}
}