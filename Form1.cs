using System;
using System.Collections.Generic;
using System.Collections.Specialized;
//using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace iwm_ClipToText
{
	public partial class Form1 : Form
	{
		private const string ProgramID = "クリップボードからテキスト取得 iwm20220621";

		private const string NL = "\r\n";
		private const string RgxNL = "\r?\n";

		// [0]             [1]          [2]          [3]          [4]          [5]          [6]
		// TsmResultIndex, TsmResult01, TsmResult02, TsmResult03, TsmResult04, TsmResult05, TsmResult06
		private const int GblMstItemsSize = 7;

		private int GblResult_AryIndex = 1;
		private readonly string[] GblResult_AryText = { "", "", "", "", "", "", "" };

		private int GblResult_CursorPos = 0;

		private object OBJ = null;

		public Form1()
		{
			InitializeComponent();

			RtbResult.DragEnter += new DragEventHandler(RtbResult_DragEnter);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Text = ProgramID;

			StartPosition = FormStartPosition.Manual;
			SubFormStartPosition();

			// コマンドライン引数からファイル名を取得
			if (ARGS.Length > 0)
			{
				Array.Sort(ARGS);
				StringCollection files = new StringCollection();
				foreach (string _s1 in ARGS)
				{
					_ = files.Add(_s1);
				}
				Clipboard.SetFileDropList(files);
			}

			Scr.Visible = false;

			BtnReload_Click(sender, e);
			SubTsmResultSelect(1);
		}

		private void SubFormStartPosition()
		{
			Location = new Point(Cursor.Position.X - (Width / 2), Cursor.Position.Y - (SystemInformation.CaptionHeight / 2));
		}

		private void Form1_Resize(object sender, EventArgs e)
		{
			// CmbSearch が乱れるため再描画
			Refresh();
		}

		private void RtbResult_KeyUp(object sender, KeyEventArgs e)
		{
			// RichTextBox で以下の動作は不安定
			//   [Ctrl]+[↑]
			//   [Ctrl]+[↓]

			// [Ctrl]+[PgUp]
			if (e.KeyData == (Keys.Control | Keys.PageUp))
			{
				RtbResult.Select(0, 0);
				RtbResult.ScrollToCaret();
				return;
			}

			// [Ctrl]+[PgDn]
			if (e.KeyData == (Keys.Control | Keys.PageDown))
			{
				RtbResult.Select(RtbResult.TextLength, 0);
				RtbResult.ScrollToCaret();
				return;
			}

			switch (e.KeyCode)
			{
				case (Keys.Escape):
					CmbSearch.Focus();
					break;

				case (Keys.F3):
					BtnSearchNext_Click(sender, null);
					break;

				default:
					GblResult_CursorPos = RtbResult.SelectionStart;
					break;
			}
		}

		private void RtbResult_TextChanged(object sender, EventArgs e)
		{
			GblResult_AryText[GblResult_AryIndex] = RtbResult.Text;
		}

		private void RtbResult_DragEnter(object sender, DragEventArgs e)
		{
			// ドロップ不可
			e.Effect = DragDropEffects.None;

			Scr.Visible = true;
		}

		private void RtbResult_MouseUp(object sender, MouseEventArgs e)
		{
			GblResult_CursorPos = RtbResult.SelectionStart;

			CmsTextSelect_Open(e, RtbResult);
		}

		private void CmsResult_Opened(object sender, EventArgs e)
		{
			_ = RtbResult.Focus();
		}

		private void CmsResult_クリア_Click(object sender, EventArgs e)
		{
			RtbResult.Text = "";
		}

		private void CmsResult_貼り付け_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(Regex.Replace(RtnClipboard(), RgxNL, NL));
			RtbResult.Paste();
		}

		private void CmsResult_名前を付けて保存_SJIS_Click(object sender, EventArgs e)
		{
			_ = RtnTextFileWrite(RtbResult.Text, 932, DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt", true, TEXT_FILTER);
		}

		private void CmsResult_名前を付けて保存_UTF8N_Click(object sender, EventArgs e)
		{
			_ = RtnTextFileWrite(RtbResult.Text, 65001, DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt", true, TEXT_FILTER);
		}

		private void Scr_Panel1_Click(object sender, EventArgs e)
		{
			// 誤操作で表示されたままになったとき使用
			Scr.Visible = false;
		}

		private void Scr_Panel1_DragLeave(object sender, EventArgs e)
		{
			Scr.Visible = false;
		}

		private void Scr_Panel2_Click(object sender, EventArgs e)
		{
			// 誤操作で表示されたままになったとき使用
			Scr.Visible = false;
		}

		private void Scr_Panel2_DragLeave(object sender, EventArgs e)
		{
			Scr.Visible = false;
		}

		private void BtnPasteFilename_Click(object sender, EventArgs e)
		{
			// 誤操作で表示されたままになったとき使用
			Scr.Visible = false;
		}

		private void BtnPasteFilename_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
		}

		private void BtnPasteFilename_DragDrop(object sender, DragEventArgs e)
		{
			List<string> l1 = new List<string>();

			foreach (string _s1 in (string[])e.Data.GetData(DataFormats.FileDrop))
			{
				l1.Add(_s1);
			}
			l1.Sort();

			Clipboard.SetText(RtnShortPath(l1));
			RtbResult.Paste();

			RtbResult.Select(0, 0);
			RtbResult.ScrollToCaret();

			Scr.Visible = false;
		}

		private void BtnPasteTextfile_Click(object sender, EventArgs e)
		{
			// 誤操作で表示されたままになったとき使用
			Scr.Visible = false;
		}

		private void BtnPasteTextfile_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None;
		}

		private void BtnPasteTextfile_DragDrop(object sender, DragEventArgs e)
		{
			StringBuilder sb = new StringBuilder();
			string s1 = "";

			foreach (string _s1 in (string[])e.Data.GetData(DataFormats.FileDrop))
			{
				(string _s2, string _s3) = RtnTextFileRead(_s1, false, "");
				if (_s2.Length > 0)
				{
					_ = sb.Append(_s3);
				}
				else
				{
					if (File.Exists(_s1))
					{
						s1 += "・" + Path.GetFileName(_s1) + NL;
					}
				}
			}

			Clipboard.SetText(Regex.Replace(sb.ToString(), RgxNL, NL));
			RtbResult.Paste();

			RtbResult.Select(0, 0);
			RtbResult.ScrollToCaret();

			Scr.Visible = false;

			if (s1.Length > 0)
			{
				_ = MessageBox.Show(
					"[Err] テキストファイルではありません。" + NL + NL + s1,
					ProgramID
				);
			}
		}

		private void TsmResultIndex_Click(object sender, EventArgs e)
		{
			// インデクスを一括作成
			ToolStripMenuItem obj1 = (ToolStripMenuItem)MstResult.Items[0];
			for (int _i1 = 1; _i1 < GblMstItemsSize; _i1++)
			{
				ToolStripItem _obj1 = obj1.DropDownItems[_i1 - 1];
				_obj1.Text = RtnIndexB(GblResult_AryText[_i1], 100);
				_obj1.BackColor = _obj1.Text.Length > 0 ? Color.White : Color.Gainsboro;
			}
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

		private void TsmResultIndex06_Click(object sender, EventArgs e)
		{
			SubTsmResultSelect(6);
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

		private void TsmResult06_Click(object sender, EventArgs e)
		{
			SubTsmResultSelect(6);
		}

		private void SubTsmResultSelect(int iTsmIndex)
		{

			for (int _i1 = 1; _i1 < GblMstItemsSize; _i1++)
			{
				string _s1 = GblResult_AryText[_i1].ToString();

				if (_i1 == iTsmIndex)
				{
					MstResult.Items[_i1].BackColor = Color.Crimson;
					MstResult.Items[_i1].Select();

					GblResult_AryIndex = _i1;
					RtbResult.Text = GblResult_AryText[GblResult_AryIndex].ToString();

					// 再検索
					BtnSearch_Click(null, null);
				}
				else
				{
					MstResult.Items[_i1].BackColor = _s1.Length > 0 ? Color.Maroon : Color.DimGray;
				}
			}
		}

		private void BtnReload_Click(object sender, EventArgs e)
		{
			RtbResult.Text = RtnClipboard();
			RtbResult.Select(0, 0);
			RtbResult.ScrollToCaret();
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
			if (RtbResult.TextLength > 0)
			{
				Clipboard.SetText(RtbResult.Text);
			}
			else
			{
				Clipboard.Clear();
			}
		}

		private void CmbSearch_Enter(object sender, EventArgs e)
		{
			CmbSearch.BackColor = Color.LightYellow;
		}

		private void CmbSearch_Leave(object sender, EventArgs e)
		{
			CmbSearch.BackColor = Color.Azure;
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
			// [Ctrl]+[Space]
			if (e.KeyData == (Keys.Control | Keys.Space))
			{
				CmbSearch.Text = "";
				// 文字位置を再設定しないと SendMessage で不具合
				CmbSearch.SelectionStart = 0;
				return;
			}

			// [Ctrl]+[Backspace]
			if (e.KeyData == (Keys.Control | Keys.Back))
			{
				CmbSearch.Text = CmbSearch.Text.Substring(CmbSearch.SelectionStart);
				// 文字位置を再設定しないと SendMessage で不具合
				CmbSearch.SelectionStart = 0;
				return;
			}

			// [Ctrl]+[Delete]
			if (e.KeyData == (Keys.Control | Keys.Delete))
			{
				CmbSearch.Text = CmbSearch.Text.Substring(0, CmbSearch.SelectionStart);
				// 文字位置を再設定しないと SendMessage で不具合
				CmbSearch.SelectionStart = CmsSearch.Text.Length;
				return;
			}

			switch (e.KeyCode)
			{
				case (Keys.F1):
					GblResult_AryIndex = (GblResult_AryIndex > 1 ? GblResult_AryIndex : GblMstItemsSize) - 1;
					SubTsmResultSelect(GblResult_AryIndex);
					break;

				case (Keys.F2):
					GblResult_AryIndex = GblResult_AryIndex + 1 >= GblMstItemsSize ? 1 : GblResult_AryIndex + 1;
					SubTsmResultSelect(GblResult_AryIndex);
					break;

				case (Keys.F3):
					BtnSearchNext_Click(sender, null);
					break;

				// Keys.F4 => DropDown

				case (Keys.F5):
					BtnSearchClear_Click(sender, null);
					break;

				case (Keys.Enter):
					int iPos = CmbSearch.SelectionStart;
					BtnSearch_Click(sender, null);
					CmbSearch.Select(iPos, 0);
					break;

				case (Keys.PageUp):
				case (Keys.Up):
					CmbSearch.SelectionStart = 0;
					break;

				case (Keys.PageDown):
				case (Keys.Down):
					CmbSearch.SelectionStart = CmbSearch.Text.Length;
					break;
			}
		}

		private void CmsSearch_Opened(object sender, EventArgs e)
		{
			_ = CmbSearch.Focus();
		}

		private void CmsSearch_クリア_Click(object sender, EventArgs e)
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

		private void CmsSearch_ショートカットキーの説明_Click(object sender, EventArgs e)
		{
			_ = MessageBox.Show(
				"[Enter] 検索開始" + NL +
				"[F3] 次の検索結果" + NL +
				"[Esc] 検索にフォーカス移動" + NL +
				"[F4] 検索履歴" + NL +
				"[F5] 検索中止" + NL +
				NL +
				"[Ctrl]+[Space] クリア" + NL +
				"[Ctrl]+[Backspace] カーソルより前方をクリア" + NL +
				"[Ctrl]+[Delete] カーソルより後方をクリア" + NL +
				NL +
				"[F1] 前のタブに移動" + NL +
				"[F2] 次のタブに移動",
				ProgramID
			);
		}

		private void BtnSearch_Click(object sender, EventArgs e)
		{
			if (CmbSearch.Text.Length == 0)
			{
				BtnSearchClear_Click(sender, e);
				return;
			}

			// 検索履歴から重複排除
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

			int iLineBgnPos = 0;

			// 画面を初期化
			RtbResult.Text = GblResult_AryText[GblResult_AryIndex].ToString();

			// 行毎に検索!!
			// 検索位置を着色
			foreach (string _s1 in RtbResult.Text.Split('\n'))
			{
				foreach (Match _m1 in Regex.Matches(_s1, CmbSearch.Text, RegexOptions.IgnoreCase))
				{
					RtbResult.Select(iLineBgnPos + _m1.Index, _m1.Value.Length);
					RtbResult.SelectionColor = Color.White;
					RtbResult.SelectionBackColor = Color.Red;
				}
				iLineBgnPos += _s1.Length + 1;
			}

			// 最初の検索位置へスクロール
			RtbResult.SelectionStart = Regex.Match(RtbResult.Text, CmbSearch.Text, RegexOptions.IgnoreCase).Index;
			RtbResult.ScrollToCaret();

			_ = CmbSearch.Focus();
		}

		private void BtnSearchNext_Click(object sender, EventArgs e)
		{
			if (CmbSearch.Text.Length == 0)
			{
				_ = CmbSearch.Focus();
				return;
			}

			_ = RtbResult.Focus();
			CmbSearch.SelectionStart = 0;

			// 行毎に検索!!
			// 検索位置にカーソル移動
			while (Regex.IsMatch(RtbResult.Text, CmbSearch.Text, RegexOptions.IgnoreCase))
			{
				int iLineBgnPos = 0;

				foreach (string _s1 in RtbResult.Text.Split('\n'))
				{
					// 無駄なループを減らすため、こまめに GblResult_CursorPos の位置をチェック
					if (iLineBgnPos + _s1.Length > GblResult_CursorPos)
					{
						foreach (Match _m1 in Regex.Matches(_s1, CmbSearch.Text, RegexOptions.IgnoreCase))
						{
							if (iLineBgnPos + _m1.Index >= GblResult_CursorPos)
							{
								_ = RtbResult.Focus();
								RtbResult.Select(iLineBgnPos + _m1.Index, _m1.Value.Length);
								GblResult_CursorPos = iLineBgnPos + _m1.Index + _m1.Value.Length;
								return;
							}
						}
					}
					iLineBgnPos += _s1.Length + 1;
				}

				GblResult_CursorPos = 0;
			}
		}

		private void BtnSearchClear_Click(object sender, EventArgs e)
		{
			CmbSearch.Text = "";
			RtbResult.Text = GblResult_AryText[GblResult_AryIndex].ToString();
			Text = ProgramID;
			_ = CmbSearch.Focus();
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
		// Dir/File ショートリストを作成
		//--------------------------------------------------------------------------------
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
			sTmp = Regex.Replace(sTmp, RgxNL, "␤");

			int i1 = sTmp.Length;
			int i2 = Encoding.GetEncoding(932).GetByteCount(sTmp);

			return sTmp.Substring(0, (int)((double)iByte * i1 / i2));
		}

		//--------------------------------------------------------------------------------
		// Main()
		//--------------------------------------------------------------------------------
		public static string[] ARGS;

		private static class Program
		{
			/// <summary>
			/// アプリケーションのメイン エントリ ポイントです。
			/// </summary>
			[STAThread]
			private static void Main(string[] args)
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);

				ARGS = args;

				Application.Run(new Form1());
			}
		}
	}
}
