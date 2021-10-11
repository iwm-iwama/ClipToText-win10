using System;
using System.Collections.Generic;
using System.Collections.Specialized;
///using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace iwm_ClipToText
{
	public partial class Form1 : Form
	{
		private const string ProgramID = "クリップボードからテキスト取得 iwm20211009";

		private const string NL = "\r\n";
		private const string RgxNL = "\r??\n";

		// [0]             [1]          [2]          [3]          [4]          [5]          [6]
		// TsmResultIndex, TsmResult01, TsmResult02, TsmResult03, TsmResult04, TsmResult05, TsmResultHelp
		private const int GblMstItemsSize = 7;

		private int GblAryIndex = 1;
		private readonly string[] GblAryText = { "", "", "", "", "", "", "" };

		private object OBJ = null;

		internal static class NativeMethods
		{
			[DllImport("User32.dll", CharSet = CharSet.Unicode)]
			internal static extern int SendMessage(IntPtr hWnd, int uMsg, int wParam, string lParam);
		}

		public void SubSendMessage(IntPtr hWnd, string lParam)
		{
			_ = NativeMethods.SendMessage(hWnd, 0x00C2, 1, lParam);
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Text = ProgramID;

			StartPosition = FormStartPosition.Manual;
			SubFormStartPosition();

			// コマンドライン引数からファイル名を取得
			if (Let.args.Length > 0)
			{
				Array.Sort(Let.args);
				StringCollection files = new StringCollection();
				foreach (string _s1 in Let.args)
				{
					_ = files.Add(_s1);
				}
				Clipboard.SetFileDropList(files);
			}

			BtnReload_Click(sender, e);
			SubTsmResultSelect(1);
		}

		private void SubFormStartPosition()
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

		private void Form1_Resize(object sender, EventArgs e)
		{
			// CmbSearch が乱れるため再描画
			Refresh();
		}

		private void TbResult_TextChanged(object sender, EventArgs e)
		{
			// 検索結果は反映しない
			if (CmbSearch.Text.Length == 0)
			{
				GblAryText[GblAryIndex] = TbResult.Text;
			}
		}

		private void TbResult_DragEnter(object sender, DragEventArgs e)
		{
			TbResult.Focus();
			e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
		}

		private void TbResult_DragDrop(object sender, DragEventArgs e)
		{
			foreach (string _s1 in (string[])e.Data.GetData(DataFormats.FileDrop))
			{
				(_, string _s2) = RtnTextFileRead(_s1, false, "");
				SubSendMessage(TbResult.Handle, Regex.Replace(_s2, RgxNL, NL));
			}
			BtnCopy_Click(sender, null);
		}

		private void TbResult_MouseUp(object sender, MouseEventArgs e)
		{
			CmsTextSelect_Open(e, TbResult);
		}

		private void CmsResult_全クリア_Click(object sender, EventArgs e)
		{
			TbResult.Text = "";
		}

		private void CmsResult_貼り付け_Click(object sender, EventArgs e)
		{
			SubSendMessage(TbResult.Handle, Regex.Replace(RtnClipboard(), RgxNL, NL));
		}

		private void TsmResultIndex_Click(object sender, EventArgs e)
		{
			// インデクスを一括作成
			ToolStripMenuItem obj1 = (ToolStripMenuItem)MstResult.Items[0];

			for (int _i1 = 1; _i1 <= 5; _i1++)
			{
				ToolStripItem _obj1 = obj1.DropDownItems[_i1 - 1];
				_obj1.Text = RtnIndexB(GblAryText[_i1], 100);
				_obj1.BackColor = _obj1.Text.Length > 0 ? Color.White : Color.Gainsboro;
			}
		}

		private string RtnShortPath(List<string> lStr)
		{
			StringBuilder sb = new StringBuilder();
			foreach (string _s1 in lStr)
			{
				_ = sb.Append(Path.GetFileName(_s1));
				if (Directory.Exists(_s1))
				{
					_ = sb.Append("\\");
				}
				_ = sb.Append(NL);
			}
			return "[" + Path.GetDirectoryName(lStr[0]).TrimEnd('\\') + "\\]" + NL + sb.ToString();
		}

		private void TsmResultIndex01_Click(object sender, EventArgs e)
		{
			SubTsmResultSelect(1);
		}

		private void TsmResultIndex02_Click(object sender, EventArgs e)
		{
			SubTsmResultSelect(2);
		}

		private void TsmResultIndex03_Click(object sender, EventArgs e)
		{
			SubTsmResultSelect(3);
		}

		private void TsmResultIndex04_Click(object sender, EventArgs e)
		{
			SubTsmResultSelect(4);
		}

		private void TsmResultIndex05_Click(object sender, EventArgs e)
		{
			SubTsmResultSelect(5);
		}

		private void TsmResult01_Click(object sender, EventArgs e)
		{
			SubTsmResultSelect(1);
		}

		private void TsmResult02_Click(object sender, EventArgs e)
		{
			SubTsmResultSelect(2);
		}

		private void TsmResult03_Click(object sender, EventArgs e)
		{
			SubTsmResultSelect(3);
		}

		private void TsmResult04_Click(object sender, EventArgs e)
		{
			SubTsmResultSelect(4);
		}

		private void TsmResult05_Click(object sender, EventArgs e)
		{
			SubTsmResultSelect(5);
		}

		private void SubTsmResultSelect(int iTsmIndex)
		{

			for (int _i1 = 1; _i1 < GblMstItemsSize; _i1++)
			{
				string _s1 = GblAryText[_i1].ToString();

				if (_i1 == iTsmIndex)
				{
					MstResult.Items[_i1].BackColor = Color.Crimson;
					MstResult.Items[_i1].Select();

					GblAryIndex = _i1;
					TbResult.Text = GblAryText[GblAryIndex].ToString();

					// 再検索
					BtnSearch_Click(null, null);
				}
				else
				{
					MstResult.Items[_i1].BackColor = _s1.Length > 0 ? Color.Maroon : Color.DimGray;
					MstResult.Items[6].BackColor = Color.Azure;
				}
			}
		}

		private void TsmResultHelp_Click(object sender, EventArgs e)
		{
			SubTsmResultSelect(6);

			TbResult.Text =
				"------------------" + NL +
				"> [再読込]ボタン <" + NL +
				"------------------" + NL +
				"コピーされた" + NL +
				"  ・テキストデータ" + NL +
				"  ・フォルダ／ファイル名" + NL +
				"を読み込みます（上書き）。" + NL +
				NL +
				"------------------------------" + NL +
				"> ドラッグ・アンド・ドロップ <" + NL +
				"------------------------------" + NL +
				"ドラッグされたファイル(複数可)からテキストデータを抽出し、" + NL +
				"カーソル位置に挿入します。" + NL +
				"文字コードの自動判別（UTF-8／Shift_JIS）を試みますが、" + NL +
				"判別不能の場合、Shift_JIS で読み込みます。" + NL
			;
		}

		private void BtnReload_Click(object sender, EventArgs e)
		{
			TbResult.Text = RtnClipboard();
		}

		private string RtnClipboard()
		{
			string rtn = "";

			if (Clipboard.ContainsText())
			{
				rtn = Regex.Replace(Clipboard.GetText(), RgxNL, NL);
			}
			else if (Clipboard.ContainsFileDropList())
			{
				List<string> l1 = new List<string>();
				foreach (string _s1 in Clipboard.GetFileDropList())
				{
					l1.Add(_s1);
				}
				l1.Sort();

				rtn = RtnShortPath(l1);
			}

			return rtn;
		}

		private void BtnCopy_Click(object sender, EventArgs e)
		{
			if (TbResult.TextLength > 0)
			{
				Clipboard.SetText(TbResult.Text);
			}
			else
			{
				Clipboard.Clear();
			}
		}

		private void CmsSearch_全クリア_Click(object sender, EventArgs e)
		{
			BtnSearchClear_Click(sender, e);
		}

		private void CmsSearch_貼り付け_Click(object sender, EventArgs e)
		{
			int iPos = CmbSearch.SelectionStart;
			string s1 = Clipboard.GetText();
			CmbSearch.Text = CmbSearch.Text.Insert(iPos, s1);
			CmbSearch.SelectionStart = iPos + s1.Length;
		}

		private void CmsResult_名前を付けて保存_SJIS_Click(object sender, EventArgs e)
		{
			_ = RtnTextFileWrite(TbResult.Text, 932, DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt", true, TEXT_FILTER);
		}

		private void CmsResult_名前を付けて保存_UTF8N_Click(object sender, EventArgs e)
		{
			_ = RtnTextFileWrite(TbResult.Text, 65001, DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt", true, TEXT_FILTER);
		}

		private void CmbSearch_MouseEnter(object sender, EventArgs e)
		{
			_ = CmbSearch.Focus();
		}

		private void CmbSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			// ビープ音抑制
			if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Escape)
			{
				e.Handled = true;
			}
		}

		private void CmbSearch_KeyUp(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (Keys.Enter):
					int iPos = CmbSearch.SelectionStart;
					BtnSearch_Click(sender, null);
					CmbSearch.SelectionStart = iPos;
					break;
			}
		}

		private void BtnSearch_Click(object sender, EventArgs e)
		{
			if (CmbSearch.Text.Length == 0)
			{
				BtnSearchClear_Click(sender, e);
				return;
			}

			int iPos = CmbSearch.SelectionStart;

			// 重複排除
			_ = CmbSearch.Items.Add(CmbSearch.Text);
			List<string> l1 = new List<string>();
			foreach (string _s1 in CmbSearch.Items)
			{
				l1.Add(_s1);
			}
			l1.Sort();
			CmbSearch.Items.Clear();
			string sOld = "";
			foreach (string _s1 in l1)
			{
				if (sOld != _s1)
				{
					_ = CmbSearch.Items.Add(_s1);
					sOld = _s1;
				}
			}
			l1.Clear();

			int iCnt = 0;

			// 検索
			StringBuilder sb = new StringBuilder();
			foreach (string _s1 in Regex.Split(GblAryText[GblAryIndex].ToString(), NL))
			{
				try
				{
					if (Regex.IsMatch(_s1, CmbSearch.Text, RegexOptions.IgnoreCase))
					{
						_ = sb.Append(_s1);
						_ = sb.Append(NL);
						++iCnt;
					}
				}
				catch
				{
					Color foreColorCur = CmbSearch.ForeColor;
					Color backColorCur = CmbSearch.BackColor;

					CmbSearch.ForeColor = Color.White;
					CmbSearch.BackColor = Color.Red;

					Refresh();
					Thread.Sleep(500);

					CmbSearch.ForeColor = foreColorCur;
					CmbSearch.BackColor = backColorCur;

					break;
				}
			}
			TbResult.Text = sb.ToString();
			Text = iCnt.ToString() + "行 検索";

			CmbSearch.SelectionStart = iPos;
		}

		private void BtnSearchClear_Click(object sender, EventArgs e)
		{
			CmbSearch.Text = "";
			TbResult.Text = GblAryText[GblAryIndex].ToString();
			Text = ProgramID;
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

		//--------------------------------------------------------------------------------
		// Text File ?
		//--------------------------------------------------------------------------------
		private bool RtnIsTextFile(string fn)
		{
			FileStream fs = File.OpenRead(fn);
			long len = fs.Length;
			byte[] ac = new byte[len];
			int size = fs.Read(ac, 0, (int)len);

			int iNull = 0;

			for (int _i1 = 0; _i1 < size; _i1++)
			{
				if (ac[_i1] == 0)
				{
					if (++iNull > 2)
					{
						return false;
					}
				}
				else
				{
					iNull = 0;
				}
			}
			return true;
		}

		//--------------------------------------------------------------------------------
		// UTF-8 判定
		//   1byte: [0]0x00..0x7F
		//   2byte: [0]0xC2..0xDF  [1]0x80..0xBF
		//   3byte: [0]0xE0..0xEF  [1]0x80..0xBF  [2]0x80..0xBF
		//   4byte: [0]0xF0..0xF7  [1]0x80..0xBF  [2]0x80..0xBF	[3]0x80..0xBF
		//--------------------------------------------------------------------------------
		private bool RtnIsFileEncCp65001(string fn)
		{
			byte[] bs = File.ReadAllBytes(fn);

			for (int _i1 = 1; _i1 < bs.Length; _i1++)
			{
				// 1byte
				if (bs[_i1] >= 0x00 && bs[_i1] <= 0x7F)
				{
				}
				// 2byte
				else if (bs[_i1] >= 0xC2 && bs[_i1] <= 0xDF)
				{
					++_i1;
					if (bs[_i1] < 0x80 || bs[_i1] > 0xBF)
					{
						return false;
					}
				}
				// 3byte
				else if (bs[_i1] >= 0xE0 && bs[_i1] <= 0xEF)
				{
					++_i1;
					for (int _i2 = 0; _i2 < 2 && _i1 < bs.Length; _i2++)
					{
						if (bs[_i1] < 0x80 || bs[_i1] > 0xBF)
						{
							return false;
						}
						++_i1;
					}
				}
				// 4byte
				else if (bs[_i1] >= 0xF0 && bs[_i1] <= 0xF7)
				{
					++_i1;
					for (int _i2 = 0; _i2 < 3 && _i1 < bs.Length; _i2++)
					{
						if (bs[_i1] < 0x80 || bs[_i1] > 0xBF)
						{
							return false;
						}
						++_i1;
					}
				}
			}
			return true;
		}

		//--------------------------------------------------------------------------------
		// File Read/Write
		//--------------------------------------------------------------------------------
		private const string TEXT_FILTER = "Text (*.txt)|*.txt|TSV (*.tsv)|*.tsv|CSV (*.csv)|*.csv|HTML (*.html,*.htm)|*.html,*.htm|All files (*.*)|*.*";

		private (string, string) RtnTextFileRead(string fn, bool bGuiOn, string filter) // return(ファイル名, データ)
		{
			if (bGuiOn || fn.Length == 0)
			{
				OpenFileDialog ofd = new OpenFileDialog
				{
					Filter = filter,
					InitialDirectory = Environment.CurrentDirectory
				};

				if (ofd.ShowDialog() == DialogResult.OK)
				{
					fn = ofd.FileName;
				}
				else
				{
					return ("", "");
				}
			}

			if (File.Exists(fn) && RtnIsTextFile(fn))
			{
				// UTF-8(CP65001) でないときは Shift_JIS(CP932) で読込
				return (fn, File.ReadAllText(fn, Encoding.GetEncoding(RtnIsFileEncCp65001(fn) ? 65001 : 932)));
			}

			// Err
			return ("", "");
		}

		private bool RtnTextFileWrite(string str, int encode, string fn, bool bGuiOn, string filter)
		{
			if (bGuiOn || fn.Length == 0)
			{
				SaveFileDialog sfd = new SaveFileDialog
				{
					FileName = fn,
					Filter = filter,
					FilterIndex = 1,
					InitialDirectory = Environment.CurrentDirectory
				};

				if (sfd.ShowDialog() == DialogResult.OK)
				{
					fn = sfd.FileName;
				}
				else
				{
					return false;
				}
			}

			// UTF-8(CP65001) でないときは Shift_JIS(CP932) で書込
			switch (encode)
			{
				case 65001:
					// UTF-8N(BOMなし)
					File.WriteAllText(fn, str, new UTF8Encoding(false));
					break;

				default:
					File.WriteAllText(fn, str, Encoding.GetEncoding(932));
					break;
			}

			return true;
		}

		//--------------------------------------------------------------------------------
		// 指定バイト長の文字列を返す
		//--------------------------------------------------------------------------------
		private string RtnIndexB(string str, int iByte)
		{
			str = str.TrimStart();

			if (str.Length == 0 || iByte == 0)
			{
				return "";
			}

			if (str.Length < iByte)
			{
				iByte = str.Length;
			}

			string sTmp = str.Substring(0, iByte);
			sTmp = Regex.Replace(sTmp, RgxNL, "␤ ");

			int i1 = sTmp.Length;
			int i2 = Encoding.GetEncoding(932).GetByteCount(sTmp);

			return sTmp.Substring(0, (int)((double)iByte * i1 / i2));
		}

		//--------------------------------------------------------------------------------
		// Main()
		//--------------------------------------------------------------------------------
		public class Let
		{
			public static string[] args;
		}

		private static class Program
		{
			/// <summary>
			/// アプリケーションのメイン エントリ ポイントです。
			/// </summary>
			[STAThread]
			private static void Main(string[] ARGS)
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);

				Let.args = ARGS;

				Application.Run(new Form1());
			}
		}
	}
}
