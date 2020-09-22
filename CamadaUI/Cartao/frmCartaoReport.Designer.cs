namespace CamadaUI.Cartao
{
	partial class frmCartaoReport
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
			this.objAPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.rptvPadrao = new Microsoft.Reporting.WinForms.ReportViewer();
			this.btnFechar = new System.Windows.Forms.Button();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.objAPagarBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// Panel1
			// 
			this.Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
			this.Panel1.Size = new System.Drawing.Size(798, 50);
			// 
			// btnMaximizar
			// 
			this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
			this.btnMaximizar.FlatAppearance.BorderSize = 0;
			this.btnMaximizar.Location = new System.Drawing.Point(728, 10);
			this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
			this.btnClose.Location = new System.Drawing.Point(757, 10);
			this.btnClose.Size = new System.Drawing.Size(25, 25);
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(494, 1);
			this.lblTitulo.Size = new System.Drawing.Size(227, 50);
			this.lblTitulo.Text = "Impressão de Cartão";
			// 
			// rptvPadrao
			// 
			this.rptvPadrao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rptvPadrao.LocalReport.ReportEmbeddedResource = "CamadaUI.Cartao.rptCartaoFrente.rdlc";
			this.rptvPadrao.Location = new System.Drawing.Point(19, 72);
			this.rptvPadrao.Margin = new System.Windows.Forms.Padding(10);
			this.rptvPadrao.Name = "rptvPadrao";
			this.rptvPadrao.ServerReport.BearerToken = null;
			this.rptvPadrao.Size = new System.Drawing.Size(764, 596);
			this.rptvPadrao.TabIndex = 4;
			// 
			// btnFechar
			// 
			this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFechar.CausesValidation = false;
			this.btnFechar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFechar.Image = global::CamadaUI.Properties.Resources.fechar_24;
			this.btnFechar.Location = new System.Drawing.Point(645, 682);
			this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Size = new System.Drawing.Size(138, 41);
			this.btnFechar.TabIndex = 19;
			this.btnFechar.Text = "&Fechar";
			this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFechar.UseVisualStyleBackColor = true;
			this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
			// 
			// frmCartaoReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(802, 734);
			this.Controls.Add(this.btnFechar);
			this.Controls.Add(this.rptvPadrao);
			this.Name = "frmCartaoReport";
			this.Load += new System.EventHandler(this.frmCartaoReport_Load);
			this.Controls.SetChildIndex(this.rptvPadrao, 0);
			this.Controls.SetChildIndex(this.btnFechar, 0);
			this.Controls.SetChildIndex(this.Panel1, 0);
			this.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.objAPagarBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer rptvPadrao;
		internal System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.BindingSource objAPagarBindingSource;
	}
}
