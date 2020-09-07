namespace CamadaUI.Main
{
	partial class frmDateGet
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
			this.dtpDateInfo = new System.Windows.Forms.DateTimePicker();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(106, 0);
			this.lblTitulo.Size = new System.Drawing.Size(259, 40);
			this.lblTitulo.Text = "Informe a Data";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(365, 0);
			this.btnClose.Size = new System.Drawing.Size(40, 40);
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
			this.btnCancelar.TabIndex = 8;
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
			this.btnOK.TabIndex = 7;
			this.btnOK.Text = "&OK";
			this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// lblSubTitulo
			// 
			this.lblSubTitulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubTitulo.Location = new System.Drawing.Point(12, 54);
			this.lblSubTitulo.Name = "lblSubTitulo";
			this.lblSubTitulo.Size = new System.Drawing.Size(381, 43);
			this.lblSubTitulo.TabIndex = 5;
			this.lblSubTitulo.Text = "Informe a Data";
			this.lblSubTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtpDateInfo
			// 
			this.dtpDateInfo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDateInfo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDateInfo.Location = new System.Drawing.Point(124, 107);
			this.dtpDateInfo.Name = "dtpDateInfo";
			this.dtpDateInfo.Size = new System.Drawing.Size(155, 31);
			this.dtpDateInfo.TabIndex = 6;
			// 
			// frmDateGet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(405, 219);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lblSubTitulo);
			this.Controls.Add(this.dtpDateInfo);
			this.Name = "frmDateGet";
			this.Activated += new System.EventHandler(this.frmDateGet_Activated);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDateGet_FormClosed);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.dtpDateInfo, 0);
			this.Controls.SetChildIndex(this.lblSubTitulo, 0);
			this.Controls.SetChildIndex(this.btnOK, 0);
			this.Controls.SetChildIndex(this.btnCancelar, 0);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.Button btnCancelar;
		internal System.Windows.Forms.Button btnOK;
		internal System.Windows.Forms.Label lblSubTitulo;
		internal System.Windows.Forms.DateTimePicker dtpDateInfo;
	}
}
