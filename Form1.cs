using System;
using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Diagnostics;
using System.Drawing;
using System.IO;
//using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
//using System.Threading;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.VisualBasic;// (要)参照に追加

namespace iwm_ClipToText
{
	public partial class Form1 : Form
	{
		private const string VERSION = "クリップボードからテキストファイル生成 iwm20200215";
		private const string NL = "\r\n";

		private readonly string[] GblASExt = { "txt", "html", "csv", "tsv" };
		private readonly string[] GblASTextCode = { "Shift_JIS", "UTF-8N" };
		private readonly StringBuilder SB = new StringBuilder();

		private readonly Hashtable GblHText = new Hashtable();

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
			TbSaveFileName.Select(0, 0);

			SubTbResultReload(true);
		}

		private void TbResult_MouseHover(object sender, EventArgs e)
		{
			_ = TbResult.Focus();
		}

		private void TbResult_TextChanged(object sender, EventArgs e)
		{
			SubTbResultReload(false);
		}

		private void SubTbResultReload(bool bGetClip)
		{
			if (bGetClip && Clipboard.ContainsText())
			{
				TbResult.Text = Regex.Replace(Clipboard.GetText(), "\r*\n", NL);
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

		private void CmsResult_上へ_Click(object sender, EventArgs e)
		{
			TbResult.Select(0, 0);
			_ = TbResult.Focus();
			TbResult.ScrollToCaret();
		}

		private void CmsResult_下へ_Click(object sender, EventArgs e)
		{
			TbResult.Select(TbResult.TextLength, 0);
			_ = TbResult.Focus();
			TbResult.ScrollToCaret();
		}

		private void CmsResult_全クリア_Click(object sender, EventArgs e)
		{
			TbResult.Text = "";
			SubTbResultReload(false);
		}

		private void CmsResult_全コピー_Click(object sender, EventArgs e)
		{
			TbResult.SelectAll();
			TbResult.Copy();
		}

		private void CmsResult_コピー_Click(object sender, EventArgs e)
		{
			TbResult.Copy();
		}

		private void CmsResult_切り取り_Click(object sender, EventArgs e)
		{
			TbResult.Cut();
			SubTbResultReload(false);
		}

		private void CmsResult_貼り付け_Click(object sender, EventArgs e)
		{
			TbResult.Paste();
			SubTbResultReload(false);
		}

		private void CmsSaveFileName_全クリア_Click(object sender, EventArgs e)
		{
			TbSaveFileName.Text = "";
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

				if (GblHText[_rb1.Name].ToString().Length > 0)
				{
					_rb1.ForeColor = Color.Black;
					_rb1.BackColor = Color.LightCyan;
				}
				else
				{
					_rb1.ForeColor = Color.White;
					_rb1.BackColor = Color.DimGray;
				}
			}
		}

		private void TbSaveFileName_MouseEnter(object sender, EventArgs e)
		{
			ToolTip1.SetToolTip(TbSaveFileName, "ファイル名");
		}

		private void CbExtension_MouseEnter(object sender, EventArgs e)
		{
			ToolTip1.SetToolTip(CbExtension, "拡張子");
		}

		private void BtnReload_Click(object sender, EventArgs e)
		{
			SubTbResultReload(true);
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
			TextBox TB = TbResult;

			_ = SB.Clear();
			foreach (string _s1 in TB.Text.Split('\n'))
			{
				_ = SB.Append(_s1.TrimEnd() + NL);
			}
			TB.Text = "";
			_ = NativeMethods.SendMessage(TB.Handle, EM_REPLACESEL, 1, SB.ToString());

			using (SaveFileDialog saveFileDialog1 = new SaveFileDialog
			{
				InitialDirectory = Environment.SpecialFolder.DesktopDirectory.ToString(),
				FileName = TbSaveFileName.Text + "." + CbExtension.Text,
				Filter = "All files (*.*)|*.*",
				FilterIndex = 1
			})
			{
				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					switch (CbTextCode.Text.ToUpper())
					{
						case "UTF-8N":
							UTF8Encoding utf8nEnc = new UTF8Encoding(false);
							File.WriteAllText(saveFileDialog1.FileName, TB.Text, utf8nEnc);
							break;

						default:
							File.WriteAllText(saveFileDialog1.FileName, TB.Text, Encoding.GetEncoding("Shift_JIS"));
							break;
					}
				}
			}
		}
	}
}
