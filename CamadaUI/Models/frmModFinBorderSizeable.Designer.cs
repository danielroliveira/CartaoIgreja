namespace CamadaUI.Models
{
	partial class frmModFinBorderSizeable
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
			this.Panel1 = new System.Windows.Forms.Panel();
			this.btnMaximizar = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Panel1
			// 
			this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Panel1.BackColor = System.Drawing.Color.SlateGray;
			this.Panel1.Controls.Add(this.btnMaximizar);
			this.Panel1.Controls.Add(this.btnClose);
			this.Panel1.Controls.Add(this.lblTitulo);
			this.Panel1.Location = new System.Drawing.Point(2, 2);
			this.Panel1.Margin = new System.Windows.Forms.Padding(4);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(736, 50);
			this.Panel1.TabIndex = 3;
			// 
			// btnMaximizar
			// 
			this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMaximizar.BackColor = System.Drawing.Color.SlateGray;
			this.btnMaximizar.BackgroundImage = global::CamadaUI.Properties.Resources.maximize;
			this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnMaximizar.CausesValidation = false;
			this.btnMaximizar.FlatAppearance.BorderSize = 0;
			this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMaximizar.Location = new System.Drawing.Point(667, 7);
			this.btnMaximizar.Margin = new System.Windows.Forms.Padding(0);
			this.btnMaximizar.Name = "btnMaximizar";
			this.btnMaximizar.Size = new System.Drawing.Size(32, 32);
			this.btnMaximizar.TabIndex = 9;
			this.btnMaximizar.TabStop = false;
			this.btnMaximizar.UseVisualStyleBackColor = false;
			this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.Transparent;
			this.btnClose.BackgroundImage = global::CamadaUI.Properties.Resources.close;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnClose.CausesValidation = false;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(700, 7);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(30, 30);
			this.btnClose.TabIndex = 8;
			this.btnClose.TabStop = false;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblTitulo
			// 
			this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.ForeColor = System.Drawing.Color.White;
			this.lblTitulo.Location = new System.Drawing.Point(498, 0);
			this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
			this.lblTitulo.Size = new System.Drawing.Size(163, 50);
			this.lblTitulo.TabIndex = 1;
			this.lblTitulo.Text = "Label1";
			this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmModFinBorderSizeable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(740, 658);
			this.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmModFinBorderSizeable";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Form1";
			this.Shown += new System.EventHandler(this.frmModFinBorderSizeable_Shown);
			this.ResizeEnd += new System.EventHandler(this.me_ResizeEnd);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.me_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.me_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.me_MouseUp);
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		protected System.Windows.Forms.Panel Panel1;
		protected internal System.Windows.Forms.Button btnMaximizar;
		protected internal System.Windows.Forms.Button btnClose;
		protected System.Windows.Forms.Label lblTitulo;
	}
}
