namespace CamadaUI.Main
{
	partial class frmDateMesAnoGet
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
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.lblSubTitulo = new System.Windows.Forms.Label();
			this.numAno = new System.Windows.Forms.NumericUpDown();
			this.cmbMes = new CamadaUC.ucComboLimitedValues();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAno)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(106, 0);
			this.lblTitulo.Size = new System.Drawing.Size(259, 40);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Informe o Mês e o Ano";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(365, 0);
			this.btnClose.Size = new System.Drawing.Size(40, 40);
			this.btnClose.TabIndex = 1;
			this.btnClose.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(405, 40);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Image = global::CamadaUI.Properties.Resources.fechar_24;
			this.btnCancelar.Location = new System.Drawing.Point(201, 163);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(140, 41);
			this.btnCancelar.TabIndex = 7;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnOK
			// 
			this.btnOK.Image = global::CamadaUI.Properties.Resources.accept_24;
			this.btnOK.Location = new System.Drawing.Point(55, 163);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(140, 41);
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "&OK";
			this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// lblSubTitulo
			// 
			this.lblSubTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubTitulo.Location = new System.Drawing.Point(12, 50);
			this.lblSubTitulo.Name = "lblSubTitulo";
			this.lblSubTitulo.Size = new System.Drawing.Size(381, 43);
			this.lblSubTitulo.TabIndex = 1;
			this.lblSubTitulo.Text = "Informe o Mês e o Ano";
			this.lblSubTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numAno
			// 
			this.numAno.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numAno.Location = new System.Drawing.Point(253, 115);
			this.numAno.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
			this.numAno.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numAno.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numAno.Name = "numAno";
			this.numAno.Size = new System.Drawing.Size(86, 31);
			this.numAno.TabIndex = 5;
			this.numAno.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
			// 
			// cmbMes
			// 
			this.cmbMes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbMes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbMes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbMes.FormattingEnabled = true;
			this.cmbMes.Location = new System.Drawing.Point(57, 115);
			this.cmbMes.Name = "cmbMes";
			this.cmbMes.Size = new System.Drawing.Size(186, 31);
			this.cmbMes.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(53, 93);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 19);
			this.label7.TabIndex = 2;
			this.label7.Text = "Mês";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(249, 92);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 19);
			this.label6.TabIndex = 3;
			this.label6.Text = "Ano";
			// 
			// frmDateMesAnoGet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(405, 219);
			this.Controls.Add(this.numAno);
			this.Controls.Add(this.cmbMes);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lblSubTitulo);
			this.Name = "frmDateMesAnoGet";
			this.Activated += new System.EventHandler(this.frmDateMesAnoGet_Activated);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDateMesAnoGet_FormClosed);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.lblSubTitulo, 0);
			this.Controls.SetChildIndex(this.btnOK, 0);
			this.Controls.SetChildIndex(this.btnCancelar, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.cmbMes, 0);
			this.Controls.SetChildIndex(this.numAno, 0);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numAno)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button btnCancelar;
		internal System.Windows.Forms.Button btnOK;
		internal System.Windows.Forms.Label lblSubTitulo;
		private System.Windows.Forms.NumericUpDown numAno;
		private CamadaUC.ucComboLimitedValues cmbMes;
		internal System.Windows.Forms.Label label7;
		internal System.Windows.Forms.Label label6;
	}
}
