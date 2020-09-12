namespace CamadaUI.Config
{
	partial class frmConfigSobre
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
			this.lblVersao = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Text = "Aplicativo de Impressão de Credencial";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblVersao
			// 
			this.lblVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblVersao.AutoSize = true;
			this.lblVersao.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVersao.ForeColor = System.Drawing.Color.Black;
			this.lblVersao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblVersao.Location = new System.Drawing.Point(119, 99);
			this.lblVersao.Name = "lblVersao";
			this.lblVersao.Size = new System.Drawing.Size(31, 29);
			this.lblVersao.TabIndex = 16;
			this.lblVersao.Text = "...";
			// 
			// Label1
			// 
			this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.ForeColor = System.Drawing.Color.Black;
			this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Label1.Location = new System.Drawing.Point(27, 99);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(86, 29);
			this.Label1.TabIndex = 15;
			this.Label1.Text = "Versão:";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new System.Drawing.Point(27, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(206, 29);
			this.label2.TabIndex = 15;
			this.label2.Text = "DRO Systems - 2020";
			// 
			// frmConfigSobre
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(746, 452);
			this.Controls.Add(this.lblVersao);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Label1);
			this.Name = "frmConfigSobre";
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.Label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.lblVersao, 0);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Label lblVersao;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label label2;
	}
}
