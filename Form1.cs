using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace iwm_ClipToText
{
	public partial class Form1 : Form
	{
		private const string ProgramID = "クリップボードからテキスト取得 iwm20210906";

		private const string NL = "\r\n";
		private const string RgxNL = "\r*\n";

		private readonly string[] GblASTextCode = { "Shift_JIS", "UTF-8N" };

		private readonly Hashtable GblHText = new Hashtable();

		private object OBJ = null;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			StartPosition = FormStartPosition.Manual;
			SubForm1_StartPosition();

			Text = ProgramID;

			foreach (string _s1 in GblASTextCode)
			{
				_ = CbTextCode.Items.Add(_s1);
			}
			CbTextCode.Text = GblASTextCode[0];

			foreach (RadioButton _rb1 in GrpRB.Controls)
			{
				GblHText[_rb1.Name] = "";
			}

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

		private string RtnShortPath(List<string> ls)
		{
			ls.Sort();
			StringBuilder sb = new StringBuilder();
			foreach (string _s1 in ls)
			{
				_ = sb.Append(Path.GetFileName(_s1));
				if (Directory.Exists(_s1))
				{
					_ = sb.Append("\\");
				}
				_ = sb.Append(NL);
			}
			return $"[{Path.GetDirectoryName(ls[0])}\\]" + NL + sb.ToString();
		}

		private void SubTbResultReload(bool bGetClip)
		{
			if (bGetClip)
			{
				if (Clipboard.ContainsText())
				{
					Text = "テキスト取得";
					TbResult.Text = Regex.Replace(Clipboard.GetText(), RgxNL, NL);
				}
				else if (Clipboard.ContainsFileDropList())
				{
					Text = "ファイルリスト取得";
					List<string> ls1 = new List<string>();
					foreach (string _s1 in Clipboard.GetFileDropList())
					{
						ls1.Add(_s1);
					}
					TbResult.Text = RtnShortPath(ls1);
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

			if (TbResult.TextLength == 0)
			{
				Text = ProgramID;
			}
		}

		private void TbResult_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
		}

		private void TbResult_DragDrop(object sender, DragEventArgs e)
		{
			Text = "ファイルリスト取得";
			List<string> ls1 = new List<string>();
			foreach (string _s1 in (string[])e.Data.GetData(DataFormats.FileDrop))
			{
				ls1.Add(_s1);
			}
			TbResult.Text = RtnShortPath(ls1);
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
				FileName = DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt",
				Filter = "Text (*.txt)|*.txt|TSV (*.tsv)|*.tsv|CSV (*.csv)|*.csv|HTML (*.html,*.htm)|*.html,*.htm|All files (*.*)|*.*",
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
	}
}
