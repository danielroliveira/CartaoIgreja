namespace CamadaUI.Config
{
	partial class frmConfigImagem
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
			this.btnSalvarConfig = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.pnlPastas = new System.Windows.Forms.Panel();
			this.picLogoColor = new System.Windows.Forms.PictureBox();
			this.txtLogoColorCaminho = new System.Windows.Forms.TextBox();
			this.picLogoMono = new System.Windows.Forms.PictureBox();
			this.txtLogoMonoCaminho = new System.Windows.Forms.TextBox();
			this.btnProcLogoColor = new VIBlend.WinForms.Controls.vButton();
			this.Label17 = new System.Windows.Forms.Label();
			this.btnProcurarImagem = new VIBlend.WinForms.Controls.vButton();
			this.Label18 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.pnlPastas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogoColor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogoMono)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitulo
			// 
			this.lblTitulo.BackColor = System.Drawing.Color.CadetBlue;
			this.lblTitulo.Padding = new System.Windows.Forms.Padding(20, 0, 0, 4);
			this.lblTitulo.Size = new System.Drawing.Size(704, 30);
			this.lblTitulo.TabIndex = 0;
			this.lblTitulo.Text = "Logomarcas da Aplicação";
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.CadetBlue;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
			this.btnClose.Location = new System.Drawing.Point(704, 0);
			this.btnClose.TabIndex = 1;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panel1
			// 
			this.panel1.Size = new System.Drawing.Size(744, 30);
			// 
			// btnSalvarConfig
			// 
			this.btnSalvarConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSalvarConfig.Enabled = false;
			this.btnSalvarConfig.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnSalvarConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnSalvarConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnSalvarConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvarConfig.Image = global::CamadaUI.Properties.Resources.save_24;
			this.btnSalvarConfig.Location = new System.Drawing.Point(484, 531);
			this.btnSalvarConfig.Name = "btnSalvarConfig";
			this.btnSalvarConfig.Size = new System.Drawing.Size(121, 36);
			this.btnSalvarConfig.TabIndex = 6;
			this.btnSalvarConfig.Text = "&Salvar";
			this.btnSalvarConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvarConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalvarConfig.UseVisualStyleBackColor = true;
			this.btnSalvarConfig.Click += new System.EventHandler(this.btnSalvarConfig_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
			this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
			this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
			this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelar.Image = global::CamadaUI.Properties.Resources.delete_24;
			this.btnCancelar.Location = new System.Drawing.Point(611, 531);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(121, 36);
			this.btnCancelar.TabIndex = 7;
			this.btnCancelar.Text = "&Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancelar.UseVisualStyleBackColor = true;
			// 
			// pnlPastas
			// 
			this.pnlPastas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(221)))), ((int)(((byte)(234)))));
			this.pnlPastas.Controls.Add(this.picLogoColor);
			this.pnlPastas.Controls.Add(this.txtLogoColorCaminho);
			this.pnlPastas.Controls.Add(this.picLogoMono);
			this.pnlPastas.Controls.Add(this.txtLogoMonoCaminho);
			this.pnlPastas.Controls.Add(this.btnProcLogoColor);
			this.pnlPastas.Controls.Add(this.Label17);
			this.pnlPastas.Controls.Add(this.btnProcurarImagem);
			this.pnlPastas.Controls.Add(this.Label18);
			this.pnlPastas.Location = new System.Drawing.Point(12, 42);
			this.pnlPastas.Name = "pnlPastas";
			this.pnlPastas.Size = new System.Drawing.Size(720, 474);
			this.pnlPastas.TabIndex = 2;
			// 
			// picLogoColor
			// 
			this.picLogoColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(207)))), ((int)(((byte)(227)))));
			this.picLogoColor.InitialImage = null;
			this.picLogoColor.Location = new System.Drawing.Point(200, 62);
			this.picLogoColor.Name = "picLogoColor";
			this.picLogoColor.Size = new System.Drawing.Size(456, 134);
			this.picLogoColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picLogoColor.TabIndex = 19;
			this.picLogoColor.TabStop = false;
			// 
			// txtLogoColorCaminho
			// 
			this.txtLogoColorCaminho.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLogoColorCaminho.Location = new System.Drawing.Point(200, 20);
			this.txtLogoColorCaminho.MaxLength = 200;
			this.txtLogoColorCaminho.Name = "txtLogoColorCaminho";
			this.txtLogoColorCaminho.Size = new System.Drawing.Size(413, 27);
			this.txtLogoColorCaminho.TabIndex = 17;
			this.txtLogoColorCaminho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
			// 
			// picLogoMono
			// 
			this.picLogoMono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(207)))), ((int)(((byte)(227)))));
			this.picLogoMono.InitialImage = null;
			this.picLogoMono.Location = new System.Drawing.Point(200, 284);
			this.picLogoMono.Name = "picLogoMono";
			this.picLogoMono.Size = new System.Drawing.Size(456, 134);
			this.picLogoMono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picLogoMono.TabIndex = 20;
			this.picLogoMono.TabStop = false;
			// 
			// txtLogoMonoCaminho
			// 
			this.txtLogoMonoCaminho.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLogoMonoCaminho.Location = new System.Drawing.Point(200, 240);
			this.txtLogoMonoCaminho.MaxLength = 200;
			this.txtLogoMonoCaminho.Name = "txtLogoMonoCaminho";
			this.txtLogoMonoCaminho.Size = new System.Drawing.Size(413, 27);
			this.txtLogoMonoCaminho.TabIndex = 18;
			this.txtLogoMonoCaminho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Control_KeyDown);
			// 
			// btnProcLogoColor
			// 
			this.btnProcLogoColor.AllowAnimations = true;
			this.btnProcLogoColor.BackColor = System.Drawing.Color.Transparent;
			this.btnProcLogoColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnProcLogoColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProcLogoColor.Location = new System.Drawing.Point(622, 20);
			this.btnProcLogoColor.Name = "btnProcLogoColor";
			this.btnProcLogoColor.RoundedCornersMask = ((byte)(15));
			this.btnProcLogoColor.RoundedCornersRadius = 0;
			this.btnProcLogoColor.Size = new System.Drawing.Size(34, 27);
			this.btnProcLogoColor.TabIndex = 15;
			this.btnProcLogoColor.TabStop = false;
			this.btnProcLogoColor.Text = "...";
			this.btnProcLogoColor.UseCompatibleTextRendering = true;
			this.btnProcLogoColor.UseVisualStyleBackColor = false;
			this.btnProcLogoColor.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
			this.btnProcLogoColor.Click += new System.EventHandler(this.btnProcLogoColor_Click);
			// 
			// Label17
			// 
			this.Label17.AutoSize = true;
			this.Label17.BackColor = System.Drawing.Color.Transparent;
			this.Label17.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label17.Location = new System.Drawing.Point(41, 243);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(152, 18);
			this.Label17.TabIndex = 14;
			this.Label17.Text = "Logomarca Mono:";
			// 
			// btnProcurarImagem
			// 
			this.btnProcurarImagem.AllowAnimations = true;
			this.btnProcurarImagem.BackColor = System.Drawing.Color.Transparent;
			this.btnProcurarImagem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.btnProcurarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProcurarImagem.Location = new System.Drawing.Point(622, 240);
			this.btnProcurarImagem.Name = "btnProcurarImagem";
			this.btnProcurarImagem.RoundedCornersMask = ((byte)(15));
			this.btnProcurarImagem.RoundedCornersRadius = 0;
			this.btnProcurarImagem.Size = new System.Drawing.Size(34, 27);
			this.btnProcurarImagem.TabIndex = 16;
			this.btnProcurarImagem.TabStop = false;
			this.btnProcurarImagem.Text = "...";
			this.btnProcurarImagem.UseCompatibleTextRendering = true;
			this.btnProcurarImagem.UseVisualStyleBackColor = false;
			this.btnProcurarImagem.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
			this.btnProcurarImagem.Click += new System.EventHandler(this.btnProcurarImagem_Click);
			// 
			// Label18
			// 
			this.Label18.AutoSize = true;
			this.Label18.BackColor = System.Drawing.Color.Transparent;
			this.Label18.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label18.Location = new System.Drawing.Point(17, 23);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(176, 18);
			this.Label18.TabIndex = 13;
			this.Label18.Text = "Logomarca Colorida:";
			// 
			// frmConfigImagem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.ClientSize = new System.Drawing.Size(744, 579);
			this.Controls.Add(this.pnlPastas);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnSalvarConfig);
			this.KeyPreview = true;
			this.Name = "frmConfigImagem";
			this.Load += new System.EventHandler(this.frmConfigImagem_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_KeyPress);
			this.Controls.SetChildIndex(this.btnSalvarConfig, 0);
			this.Controls.SetChildIndex(this.btnCancelar, 0);
			this.Controls.SetChildIndex(this.pnlPastas, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.panel1.ResumeLayout(false);
			this.pnlPastas.ResumeLayout(false);
			this.pnlPastas.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogoColor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLogoMono)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnSalvarConfig;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Panel pnlPastas;
		internal System.Windows.Forms.PictureBox picLogoColor;
		internal System.Windows.Forms.PictureBox picLogoMono;
		internal VIBlend.WinForms.Controls.vButton btnProcLogoColor;
		internal VIBlend.WinForms.Controls.vButton btnProcurarImagem;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.TextBox txtLogoColorCaminho;
		internal System.Windows.Forms.TextBox txtLogoMonoCaminho;
	}
}
