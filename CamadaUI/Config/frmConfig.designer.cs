namespace CamadaUI.Config
{
	partial class frmConfig
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
			this.pnlMenu = new System.Windows.Forms.Panel();
			this.line1 = new AwesomeShapeControl.Line();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGeral = new System.Windows.Forms.Button();
			this.btnSobre = new System.Windows.Forms.Button();
			this.btnDados = new System.Windows.Forms.Button();
			this.pnlCorpo = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.pnlMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Configuração do Sistema";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.TabIndex = 1;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Goldenrod;
			// 
			// pnlMenu
			// 
			this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.pnlMenu.Controls.Add(this.line1);
			this.pnlMenu.Controls.Add(this.label1);
			this.pnlMenu.Controls.Add(this.btnGeral);
			this.pnlMenu.Controls.Add(this.btnSobre);
			this.pnlMenu.Controls.Add(this.btnDados);
			this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlMenu.Location = new System.Drawing.Point(0, 50);
			this.pnlMenu.Name = "pnlMenu";
			this.pnlMenu.Size = new System.Drawing.Size(200, 579);
			this.pnlMenu.TabIndex = 1;
			// 
			// line1
			// 
			this.line1.EndPoint = new System.Drawing.Point(166, 5);
			this.line1.LineColor = System.Drawing.Color.DarkGray;
			this.line1.LineWidth = 3F;
			this.line1.Location = new System.Drawing.Point(14, 44);
			this.line1.Name = "line1";
			this.line1.Size = new System.Drawing.Size(171, 10);
			this.line1.StartPoint = new System.Drawing.Point(5, 5);
			this.line1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkGray;
			this.label1.Location = new System.Drawing.Point(64, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "MENU";
			// 
			// btnGeral
			// 
			this.btnGeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.btnGeral.FlatAppearance.BorderSize = 0;
			this.btnGeral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnGeral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
			this.btnGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGeral.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGeral.ForeColor = System.Drawing.Color.White;
			this.btnGeral.Location = new System.Drawing.Point(1, 62);
			this.btnGeral.Name = "btnGeral";
			this.btnGeral.Size = new System.Drawing.Size(198, 55);
			this.btnGeral.TabIndex = 2;
			this.btnGeral.TabStop = false;
			this.btnGeral.Text = "Geral";
			this.btnGeral.UseVisualStyleBackColor = false;
			this.btnGeral.Click += new System.EventHandler(this.btnGeral_Click);
			// 
			// btnSobre
			// 
			this.btnSobre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.btnSobre.FlatAppearance.BorderSize = 0;
			this.btnSobre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnSobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
			this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSobre.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSobre.ForeColor = System.Drawing.Color.White;
			this.btnSobre.Location = new System.Drawing.Point(1, 184);
			this.btnSobre.Name = "btnSobre";
			this.btnSobre.Size = new System.Drawing.Size(198, 55);
			this.btnSobre.TabIndex = 4;
			this.btnSobre.TabStop = false;
			this.btnSobre.Text = "Sobre";
			this.btnSobre.UseVisualStyleBackColor = false;
			this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
			// 
			// btnDados
			// 
			this.btnDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
			this.btnDados.FlatAppearance.BorderSize = 0;
			this.btnDados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
			this.btnDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDados.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDados.ForeColor = System.Drawing.Color.White;
			this.btnDados.Location = new System.Drawing.Point(1, 123);
			this.btnDados.Name = "btnDados";
			this.btnDados.Size = new System.Drawing.Size(198, 55);
			this.btnDados.TabIndex = 3;
			this.btnDados.TabStop = false;
			this.btnDados.Text = "Dados da Igreja";
			this.btnDados.UseVisualStyleBackColor = false;
			this.btnDados.Click += new System.EventHandler(this.btnDados_Click);
			// 
			// pnlCorpo
			// 
			this.pnlCorpo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlCorpo.Location = new System.Drawing.Point(200, 50);
			this.pnlCorpo.Name = "pnlCorpo";
			this.pnlCorpo.Size = new System.Drawing.Size(744, 579);
			this.pnlCorpo.TabIndex = 2;
			// 
			// frmConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(944, 629);
			this.Controls.Add(this.pnlCorpo);
			this.Controls.Add(this.pnlMenu);
			this.Name = "frmConfig";
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.pnlMenu, 0);
			this.Controls.SetChildIndex(this.pnlCorpo, 0);
			this.panel1.ResumeLayout(false);
			this.pnlMenu.ResumeLayout(false);
			this.pnlMenu.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlMenu;
		private System.Windows.Forms.Panel pnlCorpo;
		private System.Windows.Forms.Label label1;
		private AwesomeShapeControl.Line line1;
		private System.Windows.Forms.Button btnGeral;
		private System.Windows.Forms.Button btnSobre;
		private System.Windows.Forms.Button btnDados;
	}
}
