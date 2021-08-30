using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace iwm_ClipToText
{
	public partial class Form1 : Form
	{
		private const string VERSION = "クリップボードからテキストファイル生成 iwm20210830";

		private const string NL = "\r\n";
		private const string RgxNL = "\r*\n";

		private readonly string[] GblASExt = { "txt", "html", "csv", "tsv" };
		private readonly string[] GblASTextCode = { "Shift_JIS", "UTF-8N" };
		private readonly StringBuilder SB = new StringBuilder();

		private readonly Hashtable GblHText = new Hashtable();

		private object OBJ = null;

		internal static class NativeMethods
		{
			[DllImport("User32.dll", CharSet = CharSet.Unicode)]
			internal static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);
		}

		private const int EM_REPLACESEL = 0x00C2;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			StartPosition = FormStartPosition.Manual;
			SubForm1_StartPosition();

			Text = VERSION;

			foreach (string _s1 in GblASExt)
			{
				_ = CbExtension.Items.Add(_s1);
			}
			CbExtension.Text = GblASExt[0];

			foreach (string _s1 in GblASTextCode)
			{
				_ = CbTextCode.Items.Add(_s1);
			}
			CbTextCode.Text = GblASTextCode[0];

			foreach (RadioButton _rb1 in GrpRB.Controls)
			{
				GblHText[_rb1.Name] = "";
			}

			TbSaveFileName.Text = DateTime.Now.ToString("yyyyMMdd_HHmmss");
			TbSaveFileName.SelectionStart = TbSaveFileName.TextLength;

			SubTbResultReload(true);
		}

		private void SubForm1_StartPosition()
		{
			int WorkingAreaW = Screen.PrimaryScreen.WorkingArea.Width;
			int WorkingAreaH = Screen.PrimaryScreen.WorkingArea.Height;

			int WorkingAreaX = Screen.PrimaryScreen.WorkingArea.X;
			int WorkingAreaY = Screen.PrimaryScreen.WorkingArea.Y;

			int MouseX = Cursor.Position.X;
			int MouseY = Cursor.Position.Y;

			// X = Width
			if (WorkingAreaW < MouseX + Size.Width)
			{
				MouseX -= Size.Width;
				if (MouseX < 0)
				{
					MouseX = WorkingAreaX + 10;
				}
			}

			// Y = Height
			if (WorkingAreaH < MouseY + Size.Height)
			{
				MouseY -= Size.Height;
				if (MouseY < 0)
				{
					MouseY = WorkingAreaY + 10;
				}
			}

			Location = new Point(MouseX, MouseY);
		}

		private void TbResult_TextChanged(object sender, EventArgs e)
		{
			SubTbResultReload(false);
		}

		private void TbResult_MouseUp(object sender, MouseEventArgs e)
		{
			CmsTextSelect_Open(e, TbResult);
		}

		private void SubTbResultReload(bool bGetClip)
		{
			if (bGetClip)
			{
				if (Clipboard.ContainsText())
				{
					TbResult.Text = Regex.Replace(Clipboard.GetText(), RgxNL, NL);
				}
				else if (Clipboard.ContainsFileDropList())
				{
					_ = SB.Clear();
					foreach (string _s1 in Clipboard.GetFileDropList())
					{
						_ = SB.Append(_s1);

						if (Directory.Exists(_s1))
						{
							_ = SB.Append("\\");
						}

						_ = SB.Append(NL);
					}

					TbResult.Text = SB.ToString();
				}
			}

			foreach (RadioButton _rb1 in GrpRB.Controls)
			{
				if (_rb1.Checked)
				{
					GblHText[_rb1.Name] = TbResult.Text;
					break;
				}
			}
		}

		private void TbResult_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
		}

		private void TbResult_DragDrop(object sender, DragEventArgs e)
		{
			_ = SB.Clear();

			foreach (string _s1 in (string[])e.Data.GetData(DataFormats.FileDrop))
			{
				_ = SB.Append(_s1);

				if (Directory.Exists(_s1))
				{
					_ = SB.Append("\\");
				}

				_ = SB.Append(NL);
			}

			TbResult.Text = SB.ToString();
		}

		private void CmsResult_全クリア_Click(object sender, EventArgs e)
		{
			TbResult.Text = "";
			SubTbResultReload(false);
		}

		private void CmsResult_貼り付け_Click(object sender, EventArgs e)
		{
			TbResult.Paste();
			TbResult.Text = Regex.Replace(TbResult.Text, RgxNL, NL);
			SubTbResultReload(false);
		}

		private void CmsSaveFileName_全クリア_Click(object sender, EventArgs e)
		{
			TbSaveFileName.Text = "";
		}

		private void CmsSaveFileName_貼り付け_Click(object sender, EventArgs e)
		{
			TbSaveFileName.Paste();
		}

		private void CmsSaveFileName_yyyyMMdd_Click(object sender, EventArgs e)
		{
			_ = NativeMethods.SendMessage(TbSaveFileName.Handle, EM_REPLACESEL, 1, DateTime.Now.ToString("yyyyMMdd"));
		}

		private void CmsSaveFileName_yyyyMMddHHmm_Click(object sender, EventArgs e)
		{
			_ = NativeMethods.SendMessage(TbSaveFileName.Handle, EM_REPLACESEL, 1, DateTime.Now.ToString("yyyyMMdd_HHmm"));
		}
		private void CmsSaveFileName_yyyyMMddHHmmss_Click(object sender, EventArgs e)
		{
			_ = NativeMethods.SendMessage(TbSaveFileName.Handle, EM_REPLACESEL, 1, DateTime.Now.ToString("yyyyMMdd_HHmmss"));
		}

		private void RB01_CheckedChanged(object sender, EventArgs e)
		{
			SubRbCheckedChanged();
		}

		private void RB02_CheckedChanged(object sender, EventArgs e)
		{
			SubRbCheckedChanged();
		}

		private void RB03_CheckedChanged(object sender, EventArgs e)
		{
			SubRbCheckedChanged();
		}

		private void RB04_CheckedChanged(object sender, EventArgs e)
		{
			SubRbCheckedChanged();
		}

		private void RB05_CheckedChanged(object sender, EventArgs e)
		{
			SubRbCheckedChanged();
		}

		private void SubRbCheckedChanged()
		{
			foreach (RadioButton _rb1 in GrpRB.Controls)
			{
				if (_rb1.Checked)
				{
					TbResult.Text = GblHText[_rb1.Name].ToString();
				}

				_rb1.ForeColor = GblHText[_rb1.Name].ToString().Length > 0 ? Color.Yellow : Color.White;
			}
		}

		private void TbSaveFileName_MouseEnter(object sender, EventArgs e)
		{
			ToolTip1.SetToolTip(TbSaveFileName, "ファイル名");
		}

		private void TbSaveFileName_MouseUp(object sender, MouseEventArgs e)
		{
			CmsTextSelect_Open(e, TbSaveFileName);
		}

		private void CbExtension_MouseEnter(object sender, EventArgs e)
		{
			ToolTip1.SetToolTip(CbExtension, "拡張子");
		}

		private void BtnReload_Click(object sender, EventArgs e)
		{
			SubTbResultReload(true);
		}

		private void BtnCopy_Click(object sender, EventArgs e)
		{
			TbResult.SelectAll();
			TbResult.Copy();
		}

		private void BtnReload_MouseEnter(object sender, EventArgs e)
		{
			ToolTip1.SetToolTip(BtnReload, "クリップボードから再読込します");
		}

		private void CbTextCode_MouseEnter(object sender, EventArgs e)
		{
			ToolTip1.SetToolTip(CbTextCode, "文字コードを指定");
		}

		private void BtnSaveFile_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog
			{
				FileName = TbSaveFileName.Text + "." + CbExtension.Text,
				Filter = "All files (*.*)|*.*",
				FilterIndex = 1,
				InitialDirectory = Environment.CurrentDirectory
			};

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				switch (CbTextCode.Text.ToUpper())
				{
					case "UTF-8N":
						UTF8Encoding utf8nEnc = new UTF8Encoding(false);
						File.WriteAllText(sfd.FileName, TbResult.Text, utf8nEnc);
						break;

					default:
						File.WriteAllText(sfd.FileName, TbResult.Text, Encoding.GetEncoding("Shift_JIS"));
						break;
				}
			}
		}

		private void CmsTextSelect_Open(MouseEventArgs e, object Obj)
		{
			if (e.Button == MouseButtons.Left)
			{
				switch (Obj)
				{
					case TextBox tb when tb.SelectionLength > 0:
					case RichTextBox rtb when rtb.SelectionLength > 0:
						OBJ = Obj;
						CmsTextSelect.Show(Cursor.Position);
						break;

					default:
						OBJ = null;
						break;
				}
			}
		}

		private void CmsTextSelect_Cancel_Click(object sender, EventArgs e)
		{
			CmsTextSelect.Close();
		}

		private void CmsTextSelect_コピー_Click(object sender, EventArgs e)
		{
			switch (OBJ)
			{
				case TextBox tb:
					tb.Copy();
					break;

				case RichTextBox rtb:
					rtb.Copy();
					break;
			}
		}

		private void CmsTextSelect_切り取り_Click(object sender, EventArgs e)
		{
			switch (OBJ)
			{
				case TextBox tb:
					tb.Cut();
					break;

				case RichTextBox rtb:
					rtb.Cut();
					break;
			}
		}

		private void CmsTextSelect_貼り付け_Click(object sender, EventArgs e)
		{
			switch (OBJ)
			{
				case TextBox tb:
					tb.Paste();
					break;

				case RichTextBox rtb:
					rtb.Paste();
					break;
			}
		}

		private void CmsResult_ソート_Click(object sender, EventArgs e)
		{
			TbResult.Text = RtnTextSort(TbResult.Text, true);
		}

		private void CmsResult_ソート逆順_Click(object sender, EventArgs e)
		{
			TbResult.Text = RtnTextSort(TbResult.Text, false);
		}

		private string RtnTextSort(string str, bool bOrder)
		{
			string[] a1 = Regex.Split(str, NL);

			Array.Sort(a1);

			if (!bOrder)
			{
				Array.Reverse(a1);
			}

			return string.Join(NL, a1).Trim() + NL;
		}
	}
}
