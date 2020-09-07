using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ComponentOwl.BetterListView;

namespace CamadaUI.Main
{
	public partial class frmComboLista : Form
	{
		Dictionary<int, string> origemLista;
		// TextBox sourceControl = null;

		public KeyValuePair<int, string> propEscolha { get; set; } // RETURN SELECTED VALUE

		// SUB NEW | CONSTRUCTOR
		//------------------------------------------------------------------------------------------------------------
		public frmComboLista(Dictionary<int, string> OrigemLista, TextBox SourceControl, int? DefaultID = null)
		{
			InitializeComponent();

			// POSITION FORM
			StartPosition = FormStartPosition.Manual;
			Point point = SourceControl.PointToScreen(Point.Empty);
			Location = new Point(point.X - 2, point.Y + SourceControl.Height);

			// CHECK IF EXISTS ITEMS
			if (OrigemLista.Count == 0) return;

			// GET LISTA
			origemLista = OrigemLista;
			PreencheLista();

			// SIZE FORM
			Height = origemLista.Count * 29;
			Width = SourceControl.Width;
			lstItens.Width = SourceControl.Width;
			clnItem.Width = SourceControl.Width - clnID.Width;

			// HANDLERS
			lstItens.ItemActivate += (a, b) => ReturnSelectedItem();
			lstItens.PreviewKeyDown += (a, e) => e.IsInputKey = true;
			this.PreviewKeyDown += (a, e) => e.IsInputKey = true;

			// SELECT DEFAULT ID
			FindSelectDefautID(DefaultID);
		}

		// SHOW - CLOSE IF ITEMS = 0
		//------------------------------------------------------------------------------------------------------------
		private void frmComboLista_Shown(object sender, EventArgs e)
		{
			// CHECK IF EXISTS ITEMS
			if (origemLista.Count == 0)
			{
				Close();
			};
		}

		// FILL LIST
		//------------------------------------------------------------------------------------------------------------
		public void PreencheLista()
		{
			lstItens.MultiSelect = false;
			lstItens.HideSelection = false;

			clnID.Width = 22;
			clnItem.Width = Width - clnID.Width - 30;

			foreach (var item in origemLista)
			{
				BetterListViewItem vItem = new BetterListViewItem(new string[] { item.Key.ToString(), item.Value });

				vItem.UseItemStyleForSubItems = false;
				vItem.SubItems[0].Font = new Font("Calibri", 7.0F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
				vItem.SubItems[0].BackColor = Color.LightSteelBlue;
				vItem.SubItems[1].Font = new Font("Calibri", 12.0F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

				lstItens.Items.Add(vItem);
			}
		}

		// FIND AND SELECT IN LIST PROVIDED DEFAULT ID 
		//------------------------------------------------------------------------------------------------------------
		private void FindSelectDefautID(int? DefaultID)
		{
			if (DefaultID != null)
			{
				foreach (BetterListViewItem item in lstItens)
				{
					if (Convert.ToInt32(item.Text) == DefaultID)
					{
						item.Selected = true;
					}
					else
					{
						item.Selected = false;
					}
				}
			}
			else
			{
				if (lstItens.Items.Count > 0)
				{
					lstItens.Items[0].Selected = true;
				}
			}
		}

		// CLOSE WHEN PRESS ESC | DOWN OR UP LIST WHEN KEY DOWN/UP | SELECT ITEM WHEN PRESS ENTER
		//------------------------------------------------------------------------------------------------------------
		private void frm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				e.Handled = true;
				DialogResult = DialogResult.Cancel;
			}
			else if (e.KeyCode == Keys.Up) // && ActiveControl.GetType().BaseType.Name != "ComboBox")
			{
				e.Handled = true;

				if (lstItens.Items.Count == 0) return;

				if (lstItens.SelectedItems.Count > 0)
				{
					int i = lstItens.SelectedItems[0].Index;
					lstItens.Items[i].Selected = false;

					if (i == 0) lstItens.Items[lstItens.Items.Count - 1].Selected = true;
					else lstItens.Items[i - 1].Selected = true;
				}
				else
				{
					lstItens.Items[0].Selected = true;
				}

				lstItens.EnsureVisible(lstItens.SelectedItems[0]);
			}
			else if (e.KeyCode == Keys.Down) // && ActiveControl.GetType().BaseType.Name != "ComboBox")
			{
				e.Handled = true;

				if (lstItens.Items.Count > 0)
				{
					if (lstItens.SelectedItems.Count > 0)
					{
						int i = lstItens.SelectedItems[0].Index;
						lstItens.Items[i].Selected = false;
						if (i == lstItens.Items.Count - 1) i = -1;
						lstItens.Items[i + 1].Selected = true;
					}
					else
					{
						lstItens.Items[0].Selected = true;
					}

					lstItens.EnsureVisible(lstItens.SelectedItems[0]);
				}
			}
			else if (e.KeyCode == Keys.Return)
			{
				ReturnSelectedItem();
			}
		}

		// RETURN SELECTED VALUE AND CLOSE
		//------------------------------------------------------------------------------------------------------------
		private void ReturnSelectedItem()
		{
			if (lstItens.SelectedItems.Count == 0) return;

			int ID = int.Parse(lstItens.SelectedItems[0].Text);
			string value = lstItens.SelectedItems[0].SubItems[1].Text;
			propEscolha = new KeyValuePair<int, string>(ID, value);

			DialogResult = DialogResult.OK;
		}

		// CREATE A SHORTCUT TO ITEM BY ID
		//------------------------------------------------------------------------------------------------------------
		private void frmComboLista_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsNumber(e.KeyChar))
			{
				foreach (BetterListViewItem item in lstItens)
				{
					if (int.Parse(item.Text) == int.Parse(e.KeyChar.ToString()))
					{
						item.Selected = true;
						ReturnSelectedItem();
					}
					else
					{
						item.Selected = false;
					}
				}

				e.Handled = true;
			}
			else if (char.IsLetter(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
