using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CamadaUI.Models
{
	public partial class frmModFinBorderSizeable : Form
	{
		int Px, Py;
		bool mover;

		const int WM_NCLBUTTONDOWN = 0xA1;
		const int HTBOTTOM = 15;
		const int HTBOTTOMLEFT = 16;
		const int HTBOTTOMRIGHT = 17;
		const int HTLEFT = 10;
		const int HTRIGHT = 11;
		const int HTTOP = 12;
		const int HTTOPLEFT = 13;
		const int HTTOPRIGHT = 14;

		public frmModFinBorderSizeable()
		{
			InitializeComponent();

			Handler_MouseDown();
			Handler_MouseMove();
			Handler_MouseUp();

			btnClose.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Right);
			btnClose.Name = "btnClose";
			btnClose.UseVisualStyleBackColor = false;

			FormBorderStyle = FormBorderStyle.None;
			StartPosition = FormStartPosition.CenterScreen;
		}

		private void frmModFinBorderSizeable_Shown(object sender, EventArgs e)
		{
			RedesenhaBorder();
		}

		#region VISUAL

		internal void RedesenhaBorder()
		{
			// --- Redesenha a border do form
			Rectangle rect = new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);
			Pen pen = new Pen(Color.SlateGray, 5);
			// 
			Refresh();
			CreateGraphics().DrawRectangle(pen, rect);
		}

		#endregion // VISUAL --- END

		#region MOVIMENTO

		private void Painel_MouseDown(object sender, MouseEventArgs e)
		{
			Px = Cursor.Position.X - this.Left;
			Py = Cursor.Position.Y - this.Top;

			mover = true;
			Cursor = Cursors.SizeAll;
		}

		private void Painel_MouseUp(object sender, MouseEventArgs e)
		{
			mover = false;
			Cursor = Cursors.Arrow;
		}

		private void Painel_MouseMove(object sender, MouseEventArgs e)
		{
			Control c = (Control)sender;

			if (mover == true)
			{
				Cursor = Cursors.SizeAll;
				Location = this.PointToScreen(new Point(MousePosition.X - this.Location.X - Px, MousePosition.Y - this.Location.Y - Py));
				RedesenhaBorder();
			}
			else
				Cursor = Cursors.Arrow;
		}

		internal void Handler_MouseMove()
		{
			// --- adiciona o Handler no Painel
			Panel1.MouseMove += Painel_MouseMove;

			// -- adiciona o Handler em todos os controles  LABEL do painel
			foreach (Control c in Panel1.Controls)
			{
				if (c is Label)
					c.MouseMove += Painel_MouseMove;
			}
		}

		internal void Handler_MouseUp()
		{
			// --- adiciona o Handler no Painel
			Panel1.MouseUp += Painel_MouseUp;

			// -- adiciona o Handler em todos os controles LABEL do painel
			foreach (Control c in Panel1.Controls)
			{
				if (c is Label)
					c.MouseUp += Painel_MouseUp;
			}
		}

		internal void Handler_MouseDown()
		{
			// --- adiciona o Handler no Painel
			Panel1.MouseDown += Painel_MouseDown;

			// -- adiciona o Handler em todos os controles LABEL do painel
			foreach (Control c in Panel1.Controls)
			{
				if (c is Label)
					c.MouseDown += Painel_MouseDown;
			}
		}

		#endregion // MOVIMENTO --- END

		#region REDIMENSIONAR

		private void me_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Capture = false;
				Cursor theCursor = Cursors.Arrow;
				IntPtr Direction = new IntPtr(Bottom);

				int[] posX, posY;

				posX = new[] { 0, 1, 2, 3, Width - 1, Width - 2, Width - 3, Width - 4 };
				posY = new[] { Height - 1, Height - 2, Height - 3, Height - 4 };

				if (posX.Contains(e.X) || posY.Contains(e.Y))
				{
					switch (e.X)
					{
						case object _ when 0 <= e.X && e.X <= 3 // On the left line
					   :
							{
								switch (e.Y)
								{
									case object _ when 0 <= e.Y && e.Y <= 3:
										{
											// top left corner
											Direction = (IntPtr)HTTOPLEFT;
											theCursor = Cursors.SizeNWSE;
											break;
										}

									case object _ when this.Height - 4 <= e.Y && e.Y <= this.Height - 1:
										{
											// bottom left corner
											Direction = (IntPtr)HTBOTTOMLEFT;
											theCursor = Cursors.SizeNESW;
											break;
										}

									default:
										{
											// left side
											Direction = (IntPtr)HTLEFT;
											theCursor = Cursors.SizeWE;
											break;
										}
								}

								break;
							}

						case object _ when this.Width - 4 <= e.X && e.X <= this.Width - 1 // On the right line
				 :
							{
								switch (e.Y)
								{
									case object _ when 0 <= e.Y && e.Y <= 3:
										{
											// top right corner
											Direction = (IntPtr)HTTOPRIGHT;
											theCursor = Cursors.SizeNESW;
											break;
										}

									case object _ when this.Height - 4 <= e.Y && e.Y <= this.Height - 1:
										{
											// bottom right corner
											Direction = (IntPtr)HTBOTTOMRIGHT;
											theCursor = Cursors.SizeNWSE;
											break;
										}

									default:
										{
											// right side
											Direction = (IntPtr)HTRIGHT;
											theCursor = Cursors.SizeWE;
											break;
										}
								}

								break;
							}

						default:
							{
								switch (e.Y)
								{
									case object _ when 0 <= e.Y && e.Y <= 3:
										{
											// top line
											Direction = (IntPtr)HTTOP;
											theCursor = Cursors.SizeNS;
											break;
										}

									case object _ when this.Height - 4 <= e.Y && e.Y <= this.Height - 1:
										{
											// bottom line
											Direction = (IntPtr)HTBOTTOM;
											theCursor = Cursors.SizeNS;
											break;
										}
								}

								break;
							}
					}
					// 
					this.Cursor = theCursor;
					Message msg = Message.Create(this.Handle, WM_NCLBUTTONDOWN, Direction, IntPtr.Zero);
					this.DefWndProc(ref msg);
				}
			}
		}

		private void me_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.Cursor = Cursors.Arrow;
		}

		private void me_ResizeEnd(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.Arrow;
			RedesenhaBorder();
		}

		private void me_MouseMove(object sender, MouseEventArgs e)
		{
			// 
			int[] posX, posY;
			// 
			posX = new[] { 0, 1, 2, 3, Width - 1, Width - 2, Width - 3, Width - 4 };
			posY = new[] { Height - 1, Height - 2, Height - 3, Height - 4 };
			// 
			if (posX.Contains(e.X) || posY.Contains(e.Y))
			{
				// 
				Cursor theCursor = Cursors.Arrow;
				// 
				switch (e.X)
				{
					case object _ when 0 <= e.X && e.X <= 3 // On the left line
				   :
						{
							switch (e.Y)
							{
								case object _ when 0 <= e.Y && e.Y <= 3:
									{
										// top left corner
										theCursor = Cursors.SizeNWSE;
										break;
									}

								case object _ when this.Height - 4 <= e.Y && e.Y <= this.Height - 1:
									{
										// bottom left corner
										theCursor = Cursors.SizeNESW;
										break;
									}

								default:
									{
										// left side
										theCursor = Cursors.SizeWE;
										break;
									}
							}

							break;
						}

					case object _ when this.Width - 4 <= e.X && e.X <= this.Width - 1   // On the right line
			 :
						{
							switch (e.Y)
							{
								case object _ when 0 <= e.Y && e.Y <= 3:
									{
										// top right corner
										theCursor = Cursors.SizeNESW;
										break;
									}

								case object _ when this.Height - 4 <= e.Y && e.Y <= this.Height - 1:
									{
										// bottom right corner
										theCursor = Cursors.SizeNWSE;
										break;
									}

								default:
									{
										// right side
										theCursor = Cursors.SizeWE;
										break;
									}
							}

							break;
						}

					default:
						{
							switch (e.Y)
							{
								case object _ when 0 <= e.Y && e.Y <= 3:
									{
										// top line
										theCursor = Cursors.SizeNS;
										break;
									}

								case object _ when this.Height - 4 <= e.Y && e.Y <= this.Height - 1:
									{
										// bottom line
										theCursor = Cursors.SizeNS;
										break;
									}
							}

							break;
						}
				}
				// 
				this.Cursor = theCursor;
			}
			else if (this.Cursor != Cursors.SizeAll)
				this.Cursor = Cursors.Arrow;
		}

		#endregion // REDIMENSIONAR --- END

		#region BUTTONS

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnMaximizar_Click(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
			{
				WindowState = FormWindowState.Maximized;
				//btnMaximizar.ButtonType = VIBlend.WinForms.Controls.vFormButtonType.MinimizeButton;
			}
			else
			{
				WindowState = FormWindowState.Normal;
				//btnMaximizar.ButtonType = VIBlend.WinForms.Controls.vFormButtonType.MaximizeButton;
			}
			RedesenhaBorder();
		}

		#endregion // BUTTONS --- END


	}
}
