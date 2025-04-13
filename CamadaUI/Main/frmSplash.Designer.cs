namespace CamadaUI.Main
{
	partial class frmSplash
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
			this.lblTexto = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(159, 0);
			this.lblTitulo.Size = new System.Drawing.Size(381, 50);
			this.lblTitulo.Text = "Cadastro de Membros  - Secretaria";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(540, 0);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(580, 50);
			// 
			// lblTexto
			// 
			this.lblTexto.AutoSize = true;
			this.lblTexto.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTexto.Location = new System.Drawing.Point(117, 131);
			this.lblTexto.Name = "lblTexto";
			this.lblTexto.Size = new System.Drawing.Size(361, 59);
			this.lblTexto.TabIndex = 1;
			this.lblTexto.Text = "Favor aguardar...";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Brown;
			this.label1.Location = new System.Drawing.Point(91, 190);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(405, 36);
			this.label1.TabIndex = 2;
			this.label1.Text = "Acessando o servidor de Dados.";
			// 
			// frmSplash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(580, 338);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTexto);
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "frmSplash";
			this.Text = "frmSplash";
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.lblTexto, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTexto;
		private System.Windows.Forms.Label label1;
	}
}