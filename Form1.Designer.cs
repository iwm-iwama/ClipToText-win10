
namespace iwm_ClipToText
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.MstResult = new System.Windows.Forms.MenuStrip();
			this.TsmResultIndex = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmResultIndex01 = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmResultIndex02 = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmResultIndex03 = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmResultIndex04 = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmResultIndex05 = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmResultIndex06 = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmResult01 = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmResult02 = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmResult03 = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmResult04 = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmResult05 = new System.Windows.Forms.ToolStripMenuItem();
			this.TsmResult06 = new System.Windows.Forms.ToolStripMenuItem();
			this.SplitContainerResult = new System.Windows.Forms.SplitContainer();
			this.BtnPasteFilename = new System.Windows.Forms.Button();
			this.BtnPasteTextfile = new System.Windows.Forms.Button();
			this.RtbResult = new System.Windows.Forms.RichTextBox();
			this.CmsResult = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsResult_クリア = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_貼り付け = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsResult_名前を付けて保存 = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_名前を付けて保存_SJIS = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_名前を付けて保存_UTF8N = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsResult_最上部へ = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_最下部へ = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnSearch = new System.Windows.Forms.Button();
			this.CmbSearch = new System.Windows.Forms.ComboBox();
			this.CmsSearch = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsSearch_クリア = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsSearch_貼り付け = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsSearch_ショートカットキーの説明 = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnSearchNext = new System.Windows.Forms.Button();
			this.BtnSearchClear = new System.Windows.Forms.Button();
			this.BtnReload = new System.Windows.Forms.Button();
			this.CmsNull = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.BtnCopy = new System.Windows.Forms.Button();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.CmsTextSelect = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsTextSelect_Cancel = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsTextSelect_コピー = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsTextSelect_切り取り = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsTextSelect_貼り付け = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.MstResult.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainerResult)).BeginInit();
			this.SplitContainerResult.Panel1.SuspendLayout();
			this.SplitContainerResult.Panel2.SuspendLayout();
			this.SplitContainerResult.SuspendLayout();
			this.CmsResult.SuspendLayout();
			this.CmsSearch.SuspendLayout();
			this.CmsTextSelect.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.Color.DimGray;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer1.ForeColor = System.Drawing.Color.White;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DimGray;
			this.splitContainer1.Panel1.Controls.Add(this.MstResult);
			this.splitContainer1.Panel1.Controls.Add(this.SplitContainerResult);
			this.splitContainer1.Panel1.Controls.Add(this.RtbResult);
			this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.White;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DimGray;
			this.splitContainer1.Panel2.Controls.Add(this.BtnSearch);
			this.splitContainer1.Panel2.Controls.Add(this.CmbSearch);
			this.splitContainer1.Panel2.Controls.Add(this.BtnSearchNext);
			this.splitContainer1.Panel2.Controls.Add(this.BtnSearchClear);
			this.splitContainer1.Panel2.Controls.Add(this.BtnReload);
			this.splitContainer1.Panel2.Controls.Add(this.BtnCopy);
			this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.White;
			this.splitContainer1.Size = new System.Drawing.Size(304, 101);
			this.splitContainer1.SplitterDistance = 66;
			this.splitContainer1.TabIndex = 0;
			this.splitContainer1.TabStop = false;
			// 
			// MstResult
			// 
			this.MstResult.BackColor = System.Drawing.Color.DimGray;
			this.MstResult.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.MstResult.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.MstResult.GripMargin = new System.Windows.Forms.Padding(0);
			this.MstResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmResultIndex,
            this.TsmResult01,
            this.TsmResult02,
            this.TsmResult03,
            this.TsmResult04,
            this.TsmResult05,
            this.TsmResult06});
			this.MstResult.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.MstResult.Location = new System.Drawing.Point(0, 49);
			this.MstResult.Name = "MstResult";
			this.MstResult.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.MstResult.Size = new System.Drawing.Size(304, 17);
			this.MstResult.TabIndex = 0;
			this.MstResult.Text = "menuStrip1";
			// 
			// TsmResultIndex
			// 
			this.TsmResultIndex.BackColor = System.Drawing.Color.Azure;
			this.TsmResultIndex.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmResultIndex01,
            this.TsmResultIndex02,
            this.TsmResultIndex03,
            this.TsmResultIndex04,
            this.TsmResultIndex05,
            this.TsmResultIndex06});
			this.TsmResultIndex.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TsmResultIndex.ForeColor = System.Drawing.Color.DimGray;
			this.TsmResultIndex.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
			this.TsmResultIndex.Name = "TsmResultIndex";
			this.TsmResultIndex.Padding = new System.Windows.Forms.Padding(4, 1, 4, 0);
			this.TsmResultIndex.Size = new System.Drawing.Size(47, 17);
			this.TsmResultIndex.Text = "Index";
			this.TsmResultIndex.Click += new System.EventHandler(this.TsmResultIndex_Click);
			// 
			// TsmResultIndex01
			// 
			this.TsmResultIndex01.Name = "TsmResultIndex01";
			this.TsmResultIndex01.Size = new System.Drawing.Size(65, 22);
			this.TsmResultIndex01.Click += new System.EventHandler(this.TsmResultIndex01_Click);
			// 
			// TsmResultIndex02
			// 
			this.TsmResultIndex02.Name = "TsmResultIndex02";
			this.TsmResultIndex02.Size = new System.Drawing.Size(65, 22);
			this.TsmResultIndex02.Click += new System.EventHandler(this.TsmResultIndex02_Click);
			// 
			// TsmResultIndex03
			// 
			this.TsmResultIndex03.Name = "TsmResultIndex03";
			this.TsmResultIndex03.Size = new System.Drawing.Size(65, 22);
			this.TsmResultIndex03.Click += new System.EventHandler(this.TsmResultIndex03_Click);
			// 
			// TsmResultIndex04
			// 
			this.TsmResultIndex04.Name = "TsmResultIndex04";
			this.TsmResultIndex04.Size = new System.Drawing.Size(65, 22);
			this.TsmResultIndex04.Click += new System.EventHandler(this.TsmResultIndex04_Click);
			// 
			// TsmResultIndex05
			// 
			this.TsmResultIndex05.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.TsmResultIndex05.Name = "TsmResultIndex05";
			this.TsmResultIndex05.Size = new System.Drawing.Size(65, 22);
			this.TsmResultIndex05.Click += new System.EventHandler(this.TsmResultIndex05_Click);
			// 
			// TsmResultIndex06
			// 
			this.TsmResultIndex06.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.TsmResultIndex06.Name = "TsmResultIndex06";
			this.TsmResultIndex06.Size = new System.Drawing.Size(65, 22);
			this.TsmResultIndex06.Click += new System.EventHandler(this.TsmResultIndex06_Click);
			// 
			// TsmResult01
			// 
			this.TsmResult01.BackColor = System.Drawing.Color.Crimson;
			this.TsmResult01.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TsmResult01.ForeColor = System.Drawing.Color.White;
			this.TsmResult01.Name = "TsmResult01";
			this.TsmResult01.Padding = new System.Windows.Forms.Padding(13, 1, 14, 0);
			this.TsmResult01.Size = new System.Drawing.Size(42, 17);
			this.TsmResult01.Text = "1";
			this.TsmResult01.Click += new System.EventHandler(this.TsmResult01_Click);
			// 
			// TsmResult02
			// 
			this.TsmResult02.BackColor = System.Drawing.Color.Crimson;
			this.TsmResult02.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TsmResult02.ForeColor = System.Drawing.Color.White;
			this.TsmResult02.Name = "TsmResult02";
			this.TsmResult02.Padding = new System.Windows.Forms.Padding(13, 1, 14, 0);
			this.TsmResult02.Size = new System.Drawing.Size(42, 17);
			this.TsmResult02.Text = "2";
			this.TsmResult02.Click += new System.EventHandler(this.TsmResult02_Click);
			// 
			// TsmResult03
			// 
			this.TsmResult03.BackColor = System.Drawing.Color.Crimson;
			this.TsmResult03.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TsmResult03.ForeColor = System.Drawing.Color.White;
			this.TsmResult03.Name = "TsmResult03";
			this.TsmResult03.Padding = new System.Windows.Forms.Padding(13, 1, 14, 0);
			this.TsmResult03.Size = new System.Drawing.Size(42, 17);
			this.TsmResult03.Text = "3";
			this.TsmResult03.Click += new System.EventHandler(this.TsmResult03_Click);
			// 
			// TsmResult04
			// 
			this.TsmResult04.BackColor = System.Drawing.Color.Crimson;
			this.TsmResult04.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TsmResult04.ForeColor = System.Drawing.Color.White;
			this.TsmResult04.Name = "TsmResult04";
			this.TsmResult04.Padding = new System.Windows.Forms.Padding(13, 1, 14, 0);
			this.TsmResult04.Size = new System.Drawing.Size(42, 17);
			this.TsmResult04.Text = "4";
			this.TsmResult04.Click += new System.EventHandler(this.TsmResult04_Click);
			// 
			// TsmResult05
			// 
			this.TsmResult05.BackColor = System.Drawing.Color.Crimson;
			this.TsmResult05.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TsmResult05.ForeColor = System.Drawing.Color.White;
			this.TsmResult05.Name = "TsmResult05";
			this.TsmResult05.Padding = new System.Windows.Forms.Padding(13, 1, 14, 0);
			this.TsmResult05.Size = new System.Drawing.Size(42, 17);
			this.TsmResult05.Text = "5";
			this.TsmResult05.Click += new System.EventHandler(this.TsmResult05_Click);
			// 
			// TsmResult06
			// 
			this.TsmResult06.BackColor = System.Drawing.Color.Crimson;
			this.TsmResult06.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TsmResult06.ForeColor = System.Drawing.Color.White;
			this.TsmResult06.Name = "TsmResult06";
			this.TsmResult06.Padding = new System.Windows.Forms.Padding(13, 1, 14, 0);
			this.TsmResult06.Size = new System.Drawing.Size(42, 17);
			this.TsmResult06.Text = "6";
			this.TsmResult06.Click += new System.EventHandler(this.TsmResult06_Click);
			// 
			// SplitContainerResult
			// 
			this.SplitContainerResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.SplitContainerResult.BackColor = System.Drawing.Color.Black;
			this.SplitContainerResult.ForeColor = System.Drawing.Color.White;
			this.SplitContainerResult.IsSplitterFixed = true;
			this.SplitContainerResult.Location = new System.Drawing.Point(1, 1);
			this.SplitContainerResult.Margin = new System.Windows.Forms.Padding(0);
			this.SplitContainerResult.Name = "SplitContainerResult";
			// 
			// SplitContainerResult.Panel1
			// 
			this.SplitContainerResult.Panel1.AllowDrop = true;
			this.SplitContainerResult.Panel1.BackColor = System.Drawing.Color.Black;
			this.SplitContainerResult.Panel1.Controls.Add(this.BtnPasteFilename);
			this.SplitContainerResult.Panel1.ForeColor = System.Drawing.Color.White;
			this.SplitContainerResult.Panel1.Click += new System.EventHandler(this.SplitContainerResult_Panel1_Click);
			this.SplitContainerResult.Panel1.DragLeave += new System.EventHandler(this.SplitContainerResult_Panel1_DragLeave);
			// 
			// SplitContainerResult.Panel2
			// 
			this.SplitContainerResult.Panel2.AllowDrop = true;
			this.SplitContainerResult.Panel2.BackColor = System.Drawing.Color.Black;
			this.SplitContainerResult.Panel2.Controls.Add(this.BtnPasteTextfile);
			this.SplitContainerResult.Panel2.ForeColor = System.Drawing.Color.White;
			this.SplitContainerResult.Panel2.Click += new System.EventHandler(this.SplitContainerResult_Panel2_Click);
			this.SplitContainerResult.Panel2.DragLeave += new System.EventHandler(this.SplitContainerResult_Panel2_DragLeave);
			this.SplitContainerResult.Size = new System.Drawing.Size(302, 50);
			this.SplitContainerResult.SplitterDistance = 150;
			this.SplitContainerResult.SplitterWidth = 2;
			this.SplitContainerResult.TabIndex = 0;
			this.SplitContainerResult.TabStop = false;
			// 
			// BtnPasteFilename
			// 
			this.BtnPasteFilename.AllowDrop = true;
			this.BtnPasteFilename.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnPasteFilename.BackColor = System.Drawing.Color.RoyalBlue;
			this.BtnPasteFilename.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.BtnPasteFilename.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
			this.BtnPasteFilename.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
			this.BtnPasteFilename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnPasteFilename.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnPasteFilename.ForeColor = System.Drawing.Color.White;
			this.BtnPasteFilename.Location = new System.Drawing.Point(15, 10);
			this.BtnPasteFilename.Margin = new System.Windows.Forms.Padding(0);
			this.BtnPasteFilename.Name = "BtnPasteFilename";
			this.BtnPasteFilename.Size = new System.Drawing.Size(120, 30);
			this.BtnPasteFilename.TabIndex = 0;
			this.BtnPasteFilename.TabStop = false;
			this.BtnPasteFilename.Text = "ファイル名";
			this.BtnPasteFilename.UseVisualStyleBackColor = false;
			this.BtnPasteFilename.Click += new System.EventHandler(this.BtnPasteFilename_Click);
			this.BtnPasteFilename.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnPasteFilename_DragDrop);
			this.BtnPasteFilename.DragEnter += new System.Windows.Forms.DragEventHandler(this.BtnPasteFilename_DragEnter);
			// 
			// BtnPasteTextfile
			// 
			this.BtnPasteTextfile.AllowDrop = true;
			this.BtnPasteTextfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnPasteTextfile.BackColor = System.Drawing.Color.Crimson;
			this.BtnPasteTextfile.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.BtnPasteTextfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
			this.BtnPasteTextfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
			this.BtnPasteTextfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnPasteTextfile.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnPasteTextfile.ForeColor = System.Drawing.Color.White;
			this.BtnPasteTextfile.Location = new System.Drawing.Point(15, 10);
			this.BtnPasteTextfile.Margin = new System.Windows.Forms.Padding(0);
			this.BtnPasteTextfile.Name = "BtnPasteTextfile";
			this.BtnPasteTextfile.Size = new System.Drawing.Size(122, 30);
			this.BtnPasteTextfile.TabIndex = 0;
			this.BtnPasteTextfile.TabStop = false;
			this.BtnPasteTextfile.Text = "テキスト";
			this.BtnPasteTextfile.UseVisualStyleBackColor = false;
			this.BtnPasteTextfile.Click += new System.EventHandler(this.BtnPasteTextfile_Click);
			this.BtnPasteTextfile.DragDrop += new System.Windows.Forms.DragEventHandler(this.BtnPasteTextfile_DragDrop);
			this.BtnPasteTextfile.DragEnter += new System.Windows.Forms.DragEventHandler(this.BtnPasteTextfile_DragEnter);
			// 
			// RtbResult
			// 
			this.RtbResult.AllowDrop = true;
			this.RtbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RtbResult.BackColor = System.Drawing.Color.Black;
			this.RtbResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RtbResult.ContextMenuStrip = this.CmsResult;
			this.RtbResult.DetectUrls = false;
			this.RtbResult.EnableAutoDragDrop = true;
			this.RtbResult.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.RtbResult.ForeColor = System.Drawing.Color.Lime;
			this.RtbResult.Location = new System.Drawing.Point(1, 1);
			this.RtbResult.Margin = new System.Windows.Forms.Padding(0);
			this.RtbResult.Name = "RtbResult";
			this.RtbResult.Size = new System.Drawing.Size(302, 50);
			this.RtbResult.TabIndex = 0;
			this.RtbResult.TabStop = false;
			this.RtbResult.Text = "";
			this.RtbResult.WordWrap = false;
			this.RtbResult.TextChanged += new System.EventHandler(this.RtbResult_TextChanged);
			this.RtbResult.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RtbResult_KeyUp);
			this.RtbResult.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RtbResult_MouseUp);
			// 
			// CmsResult
			// 
			this.CmsResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.CmsResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsResult_クリア,
            this.CmsResult_貼り付け,
            this.toolStripSeparator2,
            this.CmsResult_名前を付けて保存,
            this.toolStripSeparator4,
            this.CmsResult_最上部へ,
            this.CmsResult_最下部へ});
			this.CmsResult.Name = "CmsTbSaveFileName";
			this.CmsResult.Size = new System.Drawing.Size(162, 126);
			// 
			// CmsResult_クリア
			// 
			this.CmsResult_クリア.Image = ((System.Drawing.Image)(resources.GetObject("CmsResult_クリア.Image")));
			this.CmsResult_クリア.Name = "CmsResult_クリア";
			this.CmsResult_クリア.Size = new System.Drawing.Size(161, 22);
			this.CmsResult_クリア.Text = "クリア";
			this.CmsResult_クリア.Click += new System.EventHandler(this.CmsResult_クリア_Click);
			// 
			// CmsResult_貼り付け
			// 
			this.CmsResult_貼り付け.Image = ((System.Drawing.Image)(resources.GetObject("CmsResult_貼り付け.Image")));
			this.CmsResult_貼り付け.Name = "CmsResult_貼り付け";
			this.CmsResult_貼り付け.Size = new System.Drawing.Size(161, 22);
			this.CmsResult_貼り付け.Text = "貼り付け";
			this.CmsResult_貼り付け.Click += new System.EventHandler(this.CmsResult_貼り付け_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
			// 
			// CmsResult_名前を付けて保存
			// 
			this.CmsResult_名前を付けて保存.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsResult_名前を付けて保存_SJIS,
            this.CmsResult_名前を付けて保存_UTF8N});
			this.CmsResult_名前を付けて保存.Image = ((System.Drawing.Image)(resources.GetObject("CmsResult_名前を付けて保存.Image")));
			this.CmsResult_名前を付けて保存.Name = "CmsResult_名前を付けて保存";
			this.CmsResult_名前を付けて保存.Size = new System.Drawing.Size(161, 22);
			this.CmsResult_名前を付けて保存.Text = "名前を付けて保存";
			// 
			// CmsResult_名前を付けて保存_SJIS
			// 
			this.CmsResult_名前を付けて保存_SJIS.Image = ((System.Drawing.Image)(resources.GetObject("CmsResult_名前を付けて保存_SJIS.Image")));
			this.CmsResult_名前を付けて保存_SJIS.Name = "CmsResult_名前を付けて保存_SJIS";
			this.CmsResult_名前を付けて保存_SJIS.Size = new System.Drawing.Size(116, 22);
			this.CmsResult_名前を付けて保存_SJIS.Text = "Shift_JIS";
			this.CmsResult_名前を付けて保存_SJIS.Click += new System.EventHandler(this.CmsResult_名前を付けて保存_SJIS_Click);
			// 
			// CmsResult_名前を付けて保存_UTF8N
			// 
			this.CmsResult_名前を付けて保存_UTF8N.Image = ((System.Drawing.Image)(resources.GetObject("CmsResult_名前を付けて保存_UTF8N.Image")));
			this.CmsResult_名前を付けて保存_UTF8N.Name = "CmsResult_名前を付けて保存_UTF8N";
			this.CmsResult_名前を付けて保存_UTF8N.Size = new System.Drawing.Size(116, 22);
			this.CmsResult_名前を付けて保存_UTF8N.Text = "UTF-8N";
			this.CmsResult_名前を付けて保存_UTF8N.Click += new System.EventHandler(this.CmsResult_名前を付けて保存_UTF8N_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(158, 6);
			// 
			// CmsResult_最上部へ
			// 
			this.CmsResult_最上部へ.Image = ((System.Drawing.Image)(resources.GetObject("CmsResult_最上部へ.Image")));
			this.CmsResult_最上部へ.Name = "CmsResult_最上部へ";
			this.CmsResult_最上部へ.Size = new System.Drawing.Size(161, 22);
			this.CmsResult_最上部へ.Text = "最上部へ";
			this.CmsResult_最上部へ.Click += new System.EventHandler(this.CmsResult_最上部へ_Click);
			// 
			// CmsResult_最下部へ
			// 
			this.CmsResult_最下部へ.Image = ((System.Drawing.Image)(resources.GetObject("CmsResult_最下部へ.Image")));
			this.CmsResult_最下部へ.Name = "CmsResult_最下部へ";
			this.CmsResult_最下部へ.Size = new System.Drawing.Size(161, 22);
			this.CmsResult_最下部へ.Text = "最下部へ";
			this.CmsResult_最下部へ.Click += new System.EventHandler(this.CmsResult_最下部へ_Click);
			// 
			// BtnSearch
			// 
			this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnSearch.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BtnSearch.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.BtnSearch.FlatAppearance.BorderSize = 0;
			this.BtnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this.BtnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
			this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnSearch.Font = new System.Drawing.Font("游ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnSearch.ForeColor = System.Drawing.Color.Black;
			this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
			this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.BtnSearch.Location = new System.Drawing.Point(241, 5);
			this.BtnSearch.Margin = new System.Windows.Forms.Padding(0);
			this.BtnSearch.Name = "BtnSearch";
			this.BtnSearch.Size = new System.Drawing.Size(20, 20);
			this.BtnSearch.TabIndex = 0;
			this.BtnSearch.TabStop = false;
			this.ToolTip1.SetToolTip(this.BtnSearch, "検索開始");
			this.BtnSearch.UseVisualStyleBackColor = false;
			this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// CmbSearch
			// 
			this.CmbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CmbSearch.BackColor = System.Drawing.Color.LightYellow;
			this.CmbSearch.ContextMenuStrip = this.CmsSearch;
			this.CmbSearch.DropDownHeight = 121;
			this.CmbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CmbSearch.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.CmbSearch.ForeColor = System.Drawing.Color.Black;
			this.CmbSearch.FormattingEnabled = true;
			this.CmbSearch.IntegralHeight = false;
			this.CmbSearch.ItemHeight = 12;
			this.CmbSearch.Location = new System.Drawing.Point(151, 5);
			this.CmbSearch.Margin = new System.Windows.Forms.Padding(0);
			this.CmbSearch.MaxDropDownItems = 1;
			this.CmbSearch.Name = "CmbSearch";
			this.CmbSearch.Size = new System.Drawing.Size(90, 20);
			this.CmbSearch.TabIndex = 1;
			this.ToolTip1.SetToolTip(this.CmbSearch, "正規表現による検索");
			this.CmbSearch.Enter += new System.EventHandler(this.CmbSearch_Enter);
			this.CmbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbSearch_KeyPress);
			this.CmbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CmbSearch_KeyUp);
			this.CmbSearch.Leave += new System.EventHandler(this.CmbSearch_Leave);
			// 
			// CmsSearch
			// 
			this.CmsSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.CmsSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsSearch_クリア,
            this.CmsSearch_貼り付け,
            this.toolStripMenuItem1,
            this.CmsSearch_ショートカットキーの説明});
			this.CmsSearch.Name = "CmsTbSaveFileName";
			this.CmsSearch.Size = new System.Drawing.Size(184, 76);
			// 
			// CmsSearch_クリア
			// 
			this.CmsSearch_クリア.Image = ((System.Drawing.Image)(resources.GetObject("CmsSearch_クリア.Image")));
			this.CmsSearch_クリア.Name = "CmsSearch_クリア";
			this.CmsSearch_クリア.Size = new System.Drawing.Size(183, 22);
			this.CmsSearch_クリア.Text = "クリア";
			this.CmsSearch_クリア.Click += new System.EventHandler(this.CmsSearch_クリア_Click);
			// 
			// CmsSearch_貼り付け
			// 
			this.CmsSearch_貼り付け.Image = ((System.Drawing.Image)(resources.GetObject("CmsSearch_貼り付け.Image")));
			this.CmsSearch_貼り付け.Name = "CmsSearch_貼り付け";
			this.CmsSearch_貼り付け.Size = new System.Drawing.Size(183, 22);
			this.CmsSearch_貼り付け.Text = "貼り付け";
			this.CmsSearch_貼り付け.Click += new System.EventHandler(this.CmsSearch_貼り付け_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 6);
			// 
			// CmsSearch_ショートカットキーの説明
			// 
			this.CmsSearch_ショートカットキーの説明.Image = ((System.Drawing.Image)(resources.GetObject("CmsSearch_ショートカットキーの説明.Image")));
			this.CmsSearch_ショートカットキーの説明.Name = "CmsSearch_ショートカットキーの説明";
			this.CmsSearch_ショートカットキーの説明.Size = new System.Drawing.Size(183, 22);
			this.CmsSearch_ショートカットキーの説明.Text = "ショートカットキーの説明";
			this.CmsSearch_ショートカットキーの説明.Click += new System.EventHandler(this.CmsSearch_ショートカットキーの説明_Click);
			// 
			// BtnSearchNext
			// 
			this.BtnSearchNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnSearchNext.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BtnSearchNext.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.BtnSearchNext.FlatAppearance.BorderSize = 0;
			this.BtnSearchNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this.BtnSearchNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
			this.BtnSearchNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnSearchNext.Font = new System.Drawing.Font("游ゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnSearchNext.ForeColor = System.Drawing.Color.Black;
			this.BtnSearchNext.Location = new System.Drawing.Point(261, 5);
			this.BtnSearchNext.Margin = new System.Windows.Forms.Padding(0);
			this.BtnSearchNext.Name = "BtnSearchNext";
			this.BtnSearchNext.Size = new System.Drawing.Size(20, 20);
			this.BtnSearchNext.TabIndex = 0;
			this.BtnSearchNext.TabStop = false;
			this.BtnSearchNext.Text = "▶";
			this.ToolTip1.SetToolTip(this.BtnSearchNext, "次の検索結果");
			this.BtnSearchNext.UseVisualStyleBackColor = false;
			this.BtnSearchNext.Click += new System.EventHandler(this.BtnSearchNext_Click);
			// 
			// BtnSearchClear
			// 
			this.BtnSearchClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnSearchClear.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BtnSearchClear.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.BtnSearchClear.FlatAppearance.BorderSize = 0;
			this.BtnSearchClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
			this.BtnSearchClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
			this.BtnSearchClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnSearchClear.Font = new System.Drawing.Font("游ゴシック", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnSearchClear.ForeColor = System.Drawing.Color.Black;
			this.BtnSearchClear.Location = new System.Drawing.Point(281, 5);
			this.BtnSearchClear.Margin = new System.Windows.Forms.Padding(0);
			this.BtnSearchClear.Name = "BtnSearchClear";
			this.BtnSearchClear.Size = new System.Drawing.Size(20, 20);
			this.BtnSearchClear.TabIndex = 2;
			this.BtnSearchClear.Text = "✖";
			this.ToolTip1.SetToolTip(this.BtnSearchClear, "検索結果をクリア");
			this.BtnSearchClear.UseVisualStyleBackColor = false;
			this.BtnSearchClear.Click += new System.EventHandler(this.BtnSearchClear_Click);
			// 
			// BtnReload
			// 
			this.BtnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnReload.BackColor = System.Drawing.Color.OrangeRed;
			this.BtnReload.ContextMenuStrip = this.CmsNull;
			this.BtnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnReload.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnReload.ForeColor = System.Drawing.Color.White;
			this.BtnReload.Location = new System.Drawing.Point(2, 2);
			this.BtnReload.Margin = new System.Windows.Forms.Padding(0);
			this.BtnReload.Name = "BtnReload";
			this.BtnReload.Size = new System.Drawing.Size(65, 24);
			this.BtnReload.TabIndex = 0;
			this.BtnReload.TabStop = false;
			this.BtnReload.Text = "再読込";
			this.ToolTip1.SetToolTip(this.BtnReload, "クリップボードから再読込");
			this.BtnReload.UseVisualStyleBackColor = false;
			this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
			// 
			// CmsNull
			// 
			this.CmsNull.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.CmsNull.Name = "CmsNull";
			this.CmsNull.Size = new System.Drawing.Size(61, 4);
			// 
			// BtnCopy
			// 
			this.BtnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnCopy.BackColor = System.Drawing.Color.RoyalBlue;
			this.BtnCopy.ContextMenuStrip = this.CmsNull;
			this.BtnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnCopy.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnCopy.ForeColor = System.Drawing.Color.White;
			this.BtnCopy.Location = new System.Drawing.Point(72, 2);
			this.BtnCopy.Margin = new System.Windows.Forms.Padding(0);
			this.BtnCopy.Name = "BtnCopy";
			this.BtnCopy.Size = new System.Drawing.Size(60, 24);
			this.BtnCopy.TabIndex = 0;
			this.BtnCopy.TabStop = false;
			this.BtnCopy.Text = "コピー";
			this.ToolTip1.SetToolTip(this.BtnCopy, "クリップボードにコピー(以前のクリップボードは破棄)");
			this.BtnCopy.UseVisualStyleBackColor = false;
			this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
			// 
			// ToolTip1
			// 
			this.ToolTip1.AutomaticDelay = 1000;
			// 
			// CmsTextSelect
			// 
			this.CmsTextSelect.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.CmsTextSelect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsTextSelect_Cancel,
            this.toolStripSeparator3,
            this.CmsTextSelect_コピー,
            this.CmsTextSelect_切り取り,
            this.toolStripSeparator1,
            this.CmsTextSelect_貼り付け});
			this.CmsTextSelect.Name = "CmsResult";
			this.CmsTextSelect.Size = new System.Drawing.Size(116, 104);
			// 
			// CmsTextSelect_Cancel
			// 
			this.CmsTextSelect_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("CmsTextSelect_Cancel.Image")));
			this.CmsTextSelect_Cancel.Name = "CmsTextSelect_Cancel";
			this.CmsTextSelect_Cancel.Size = new System.Drawing.Size(115, 22);
			this.CmsTextSelect_Cancel.Text = "選択";
			this.CmsTextSelect_Cancel.Click += new System.EventHandler(this.CmsTextSelect_Cancel_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(112, 6);
			// 
			// CmsTextSelect_コピー
			// 
			this.CmsTextSelect_コピー.Image = ((System.Drawing.Image)(resources.GetObject("CmsTextSelect_コピー.Image")));
			this.CmsTextSelect_コピー.Name = "CmsTextSelect_コピー";
			this.CmsTextSelect_コピー.Size = new System.Drawing.Size(115, 22);
			this.CmsTextSelect_コピー.Text = "コピー";
			this.CmsTextSelect_コピー.Click += new System.EventHandler(this.CmsTextSelect_コピー_Click);
			// 
			// CmsTextSelect_切り取り
			// 
			this.CmsTextSelect_切り取り.Image = ((System.Drawing.Image)(resources.GetObject("CmsTextSelect_切り取り.Image")));
			this.CmsTextSelect_切り取り.Name = "CmsTextSelect_切り取り";
			this.CmsTextSelect_切り取り.Size = new System.Drawing.Size(115, 22);
			this.CmsTextSelect_切り取り.Text = "切り取り";
			this.CmsTextSelect_切り取り.Click += new System.EventHandler(this.CmsTextSelect_切り取り_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(112, 6);
			// 
			// CmsTextSelect_貼り付け
			// 
			this.CmsTextSelect_貼り付け.Image = ((System.Drawing.Image)(resources.GetObject("CmsTextSelect_貼り付け.Image")));
			this.CmsTextSelect_貼り付け.Name = "CmsTextSelect_貼り付け";
			this.CmsTextSelect_貼り付け.Size = new System.Drawing.Size(115, 22);
			this.CmsTextSelect_貼り付け.Text = "貼り付け";
			this.CmsTextSelect_貼り付け.Click += new System.EventHandler(this.CmsTextSelect_貼り付け_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(304, 101);
			this.Controls.Add(this.splitContainer1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.ForeColor = System.Drawing.Color.White;
			this.MinimumSize = new System.Drawing.Size(320, 140);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.MstResult.ResumeLayout(false);
			this.MstResult.PerformLayout();
			this.SplitContainerResult.Panel1.ResumeLayout(false);
			this.SplitContainerResult.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SplitContainerResult)).EndInit();
			this.SplitContainerResult.ResumeLayout(false);
			this.CmsResult.ResumeLayout(false);
			this.CmsSearch.ResumeLayout(false);
			this.CmsTextSelect.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.MenuStrip MstResult;
		private System.Windows.Forms.ToolStripMenuItem TsmResultIndex;
		private System.Windows.Forms.ToolStripMenuItem TsmResultIndex01;
		private System.Windows.Forms.ToolStripMenuItem TsmResultIndex02;
		private System.Windows.Forms.ToolStripMenuItem TsmResultIndex03;
		private System.Windows.Forms.ToolStripMenuItem TsmResultIndex04;
		private System.Windows.Forms.ToolStripMenuItem TsmResultIndex05;
		private System.Windows.Forms.ToolStripMenuItem TsmResultIndex06;
		private System.Windows.Forms.ToolStripMenuItem TsmResult01;
		private System.Windows.Forms.ToolStripMenuItem TsmResult02;
		private System.Windows.Forms.ToolStripMenuItem TsmResult03;
		private System.Windows.Forms.ToolStripMenuItem TsmResult04;
		private System.Windows.Forms.ToolStripMenuItem TsmResult05;
		private System.Windows.Forms.ToolStripMenuItem TsmResult06;
		private System.Windows.Forms.ComboBox CmbSearch;
		private System.Windows.Forms.ContextMenuStrip CmsSearch;
		private System.Windows.Forms.ToolStripMenuItem CmsSearch_クリア;
		private System.Windows.Forms.ToolStripMenuItem CmsSearch_貼り付け;
		private System.Windows.Forms.ToolTip ToolTip1;
		private System.Windows.Forms.Button BtnSearchClear;
		private System.Windows.Forms.Button BtnReload;
		private System.Windows.Forms.ContextMenuStrip CmsNull;
		private System.Windows.Forms.Button BtnCopy;
		private System.Windows.Forms.ContextMenuStrip CmsResult;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_クリア;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_貼り付け;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_名前を付けて保存;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_名前を付けて保存_SJIS;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_名前を付けて保存_UTF8N;
		private System.Windows.Forms.ContextMenuStrip CmsTextSelect;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_Cancel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_コピー;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_切り取り;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem CmsTextSelect_貼り付け;
		private System.Windows.Forms.SplitContainer SplitContainerResult;
		private System.Windows.Forms.Button BtnPasteFilename;
		private System.Windows.Forms.Button BtnPasteTextfile;
		private System.Windows.Forms.RichTextBox RtbResult;
		private System.Windows.Forms.Button BtnSearchNext;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem CmsSearch_ショートカットキーの説明;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_最上部へ;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_最下部へ;
		private System.Windows.Forms.Button BtnSearch;
	}
}

