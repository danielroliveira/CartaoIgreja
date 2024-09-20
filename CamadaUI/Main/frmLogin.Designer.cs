namespace CamadaUI.Main
{
	partial class frmLogin
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
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtApelido = new System.Windows.Forms.TextBox();
			this.lblSenha = new System.Windows.Forms.Label();
			this.lblApelido = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(252, 0);
			this.lblTitulo.Size = new System.Drawing.Size(276, 50);
			this.lblTitulo.Text = "Faça o LOGIN no sistema";
			// 
			// btnClose
			// 
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(528, 0);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(568, 50);
			// 
			// picLogo
			// 
			this.picLogo.BackColor = System.Drawing.Color.Transparent;
			this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.picLogo.Location = new System.Drawing.Point(12, 66);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(545, 191);
			this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picLogo.TabIndex = 11;
			this.picLogo.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Wheat;
			this.panel2.Controls.Add(this.txtSenha);
			this.panel2.Controls.Add(this.txtApelido);
			this.panel2.Controls.Add(this.lblSenha);
			this.panel2.Controls.Add(this.lblApelido);
			this.panel2.Location = new System.Drawing.Point(0, 274);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(568, 65);
			this.panel2.TabIndex = 8;
			// 
			// txtSenha
			// 
			this.txtSenha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSenha.Location = new System.Drawing.Point(319, 32);
			this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
			this.txtSenha.MaxLength = 8;
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(118, 23);
			this.txtSenha.TabIndex = 3;
			this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
			// 
			// txtApelido
			// 
			this.txtApelido.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApelido.Location = new System.Drawing.Point(133, 32);
			this.txtApelido.Margin = new System.Windows.Forms.Padding(4);
			this.txtApelido.Name = "txtApelido";
			this.txtApelido.Size = new System.Drawing.Size(156, 23);
			this.txtApelido.TabIndex = 1;
			this.txtApelido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KeyDown);
			// 
			// lblSenha
			// 
			this.lblSenha.Location = new System.Drawing.Point(316, 10);
			this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(69, 22);
			this.lblSenha.TabIndex = 2;
			this.lblSenha.Text = "&Senha";
			this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblApelido
			// 
			this.lblApelido.Location = new System.Drawing.Point(130, 10);
			this.lblApelido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblApelido.Name = "lblApelido";
			this.lblApelido.Size = new System.Drawing.Size(146, 22);
			this.lblApelido.TabIndex = 0;
			this.lblApelido.Text = "&Nome do Usuário";
			this.lblApelido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.Color.Honeydew;
			this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
			this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOK.Location = new System.Drawing.Point(176, 358);
			this.btnOK.Margin = new System.Windows.Forms.Padding(4);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(99, 42);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.OldLace;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Location = new System.Drawing.Point(287, 358);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(99, 42);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "&Cancelar";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(568, 417);
			this.Controls.Add(this.picLogo);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.KeyPreview = true;
			this.Name = "frmLogin";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.btnCancel, 0);
			this.Controls.SetChildIndex(this.btnOK, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.picLogo, 0);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.PictureBox picLogo;
		internal System.Windows.Forms.Panel panel2;
		internal System.Windows.Forms.TextBox txtSenha;
		internal System.Windows.Forms.TextBox txtApelido;
		internal System.Windows.Forms.Label lblSenha;
		internal System.Windows.Forms.Label lblApelido;
		internal System.Windows.Forms.Button btnOK;
		internal System.Windows.Forms.Button btnCancel;
	}
}
