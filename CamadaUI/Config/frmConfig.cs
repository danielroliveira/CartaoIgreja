using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CamadaUI.Config
{
	public partial class frmConfig : CamadaUI.Models.frmModFinBorder
	{
		Main.frmPrincipal _formOrigem;
		Form _OpenedForm;
		Color btnColorSelected = Color.Goldenrod;
		Color btnColorNormal = Color.FromArgb(37, 46, 59);

		#region NEW | PROPERTIES

		public frmConfig(Main.frmPrincipal formOrigem)
		{
			InitializeComponent();
			_formOrigem = formOrigem;
		}

		private Form OpenedForm
		{
			get => _OpenedForm;
			set
			{
				_OpenedForm = value;
				foreach (Control control in pnlMenu.Controls)
				{
					control.BackColor = btnColorNormal;
				}

				if (_OpenedForm == null)
					return;

				switch (_OpenedForm.Name)
				{
					case "frmConfigGeral":
						btnGeral.BackColor = btnColorSelected;
						break;
					case "frmConfigDados":
						btnDados.BackColor = btnColorSelected;
						break;
					case "frmConfigSobre":
						btnSobre.BackColor = btnColorSelected;
						break;
					default:
						break;
				}
			}
		}

		#endregion

		#region BUTTONS

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
			_formOrigem.MenuEnabled(true);
		}

		#endregion // BUTTONS --- END

		#region FUNCTIONS

		private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
		{
			Form formulario;
			formulario = pnlCorpo.Controls.OfType<Forms>().FirstOrDefault();

			if (OpenedForm != null && formulario == null)
			{
				OpenedForm.Close();
				OpenedForm = null;
			}

			if (formulario == null)
			{
				formulario = new Forms();
				formulario.TopLevel = false;
				formulario.FormBorderStyle = FormBorderStyle.None;
				formulario.Dock = DockStyle.Fill;
				pnlCorpo.Controls.Add(formulario);
				pnlCorpo.Tag = formulario;
				formulario.Show();
				formulario.BringToFront();
				OpenedForm = formulario;
			}
			else
			{
				if (formulario.WindowState == FormWindowState.Minimized)
					formulario.WindowState = FormWindowState.Normal;
				formulario.BringToFront();
			}
		}

		public void FormNoPanelClosed(Form frm)
		{
			frm.Close();
			OpenedForm = null;
		}

		#endregion // FUNCTIONS --- END

		#region BUTTONS CONFIGS

		private void btnGeral_Click(object sender, EventArgs e)
		{
			AbrirFormNoPanel<frmConfigGeral>();
		}

		private void btnSobre_Click(object sender, EventArgs e)
		{
			AbrirFormNoPanel<frmConfigSobre>();
		}

		private void btnDados_Click(object sender, EventArgs e)
		{
			AbrirFormNoPanel<frmConfigDados>();
		}

		#endregion // BUTTONS CONFIGS --- END
	}
}
