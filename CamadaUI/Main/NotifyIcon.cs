using System;
using System.Windows.Forms;

namespace CamadaUI
{
	public class NotifyIcon : System.ComponentModel.Component  //: ApplicationContext
	{
		private System.Windows.Forms.NotifyIcon TrayIcon;

		public NotifyIcon(string title, string text, ToolTipIcon icon = ToolTipIcon.Info)
		{
			InitializeComponent();
			TrayIcon.Visible = true;
			TrayIcon.ShowBalloonTip(10000, title, text, icon);
			//Environment.Exit(0);
		}


		private void InitializeComponent()
		{
			if (Main.frmPrincipal.myNotify != null)
			{
				TrayIcon = Main.frmPrincipal.myNotify;
			}
			else
			{
				TrayIcon = new System.Windows.Forms.NotifyIcon();
				TrayIcon.Text = "Cartão Igreja Notificação";
				TrayIcon.Icon = CamadaUI.Properties.Resources.program_icon;
				Main.frmPrincipal.myNotify = TrayIcon;
				Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
			}
		}

		private void OnApplicationExit(object sender, EventArgs e)
		{
			//Cleanup so that the icon will be removed when the application is closed
			TrayIcon.Visible = false;
		}
	}
}
