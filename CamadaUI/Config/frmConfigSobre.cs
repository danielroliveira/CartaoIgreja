using System;
using System.Linq;
using System.Windows.Forms;
using static CamadaUI.Utilidades;

namespace CamadaUI.Config
{
	public partial class frmConfigSobre : Models.frmModConfig
	{
		#region SUB NEW | LOAD

		// SUB NEW
		public frmConfigSobre()
		{
			InitializeComponent();
			HandlerKeyDownControl(this);

			//--- HABILITA A VERSAO E O TITULO
			//----------------------------------------------------------------
			string Versao = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
			lblVersao.Text = Versao;
		}

		#endregion

		#region BUTTONS FUNCTION

		// CLOSE
		// =============================================================================
		private void btnClose_Click(object sender, EventArgs e)
		{
			frmConfig f = Application.OpenForms.OfType<frmConfig>().FirstOrDefault();
			f.FormNoPanelClosed(this);
		}

		#endregion


	}
}
