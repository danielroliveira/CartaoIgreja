
namespace CamadaUI.Main
{
	partial class frmMain
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
			this.lblProgress = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// lblProgress
			// 
			this.lblProgress.AutoSize = true;
			this.lblProgress.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.lblProgress.ForeColor = System.Drawing.Color.White;
			this.lblProgress.Location = new System.Drawing.Point(210, 218);
			this.lblProgress.Name = "lblProgress";
			this.lblProgress.Size = new System.Drawing.Size(120, 17);
			this.lblProgress.TabIndex = 104;
			this.lblProgress.Text = "DownLoading...";
			// 
			// progressBar
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar.Location = new System.Drawing.Point(339, 214);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(252, 23);
			this.progressBar.TabIndex = 103;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblProgress);
			this.Controls.Add(this.progressBar);
			this.Name = "frmMain";
			this.Text = "frmMain";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblProgress;
		private System.Windows.Forms.ProgressBar progressBar;
	}
}