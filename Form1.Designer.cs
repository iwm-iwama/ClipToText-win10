namespace iwm_ClipToTextFile
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
			this.TbResult = new System.Windows.Forms.TextBox();
			this.CmsResult = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsResult_上へ = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsResult_下へ = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnSaveFile = new System.Windows.Forms.Button();
			this.CmsNull = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.TbSaveFileName = new System.Windows.Forms.TextBox();
			this.CmsSaveFileName = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CmsSaveFileName_全クリア = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsSaveFileName_L1 = new System.Windows.Forms.ToolStripSeparator();
			this.CmsSaveFileName_yyyyMMdd = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsSaveFileName_yyyyMMddHHmm = new System.Windows.Forms.ToolStripMenuItem();
			this.CmsSaveFileName_yyyyMMddHHmmss = new System.Windows.Forms.ToolStripMenuItem();
			this.CbExtension = new System.Windows.Forms.ComboBox();
			this.CbTextCode = new System.Windows.Forms.ComboBox();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.BtnReload = new System.Windows.Forms.Button();
			this.GrpRB = new System.Windows.Forms.GroupBox();
			this.RB05 = new System.Windows.Forms.RadioButton();
			this.RB04 = new System.Windows.Forms.RadioButton();
			this.RB03 = new System.Windows.Forms.RadioButton();
			this.RB02 = new System.Windows.Forms.RadioButton();
			this.RB01 = new System.Windows.Forms.RadioButton();
			this.CmsResult.SuspendLayout();
			this.CmsSaveFileName.SuspendLayout();
			this.GrpRB.SuspendLayout();
			this.SuspendLayout();
			// 
			// TbResult
			// 
			this.TbResult.AllowDrop = true;
			this.TbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TbResult.BackColor = System.Drawing.Color.Black;
			this.TbResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TbResult.ContextMenuStrip = this.CmsResult;
			this.TbResult.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TbResult.ForeColor = System.Drawing.Color.Lime;
			this.TbResult.Location = new System.Drawing.Point(10, 5);
			this.TbResult.Margin = new System.Windows.Forms.Padding(0);
			this.TbResult.MaxLength = 2147483647;
			this.TbResult.Multiline = true;
			this.TbResult.Name = "TbResult";
			this.TbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TbResult.Size = new System.Drawing.Size(285, 125);
			this.TbResult.TabIndex = 5;
			this.TbResult.TabStop = false;
			this.TbResult.WordWrap = false;
			this.TbResult.TextChanged += new System.EventHandler(this.TbResult_TextChanged);
			this.TbResult.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbResult_KeyUp);
			// 
			// CmsResult
			// 
			this.CmsResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsResult_上へ,
            this.CmsResult_下へ});
			this.CmsResult.Name = "CmsTbSaveFileName";
			this.CmsResult.Size = new System.Drawing.Size(87, 48);
			// 
			// CmsResult_上へ
			// 
			this.CmsResult_上へ.ForeColor = System.Drawing.Color.OrangeRed;
			this.CmsResult_上へ.Name = "CmsResult_上へ";
			this.CmsResult_上へ.Size = new System.Drawing.Size(86, 22);
			this.CmsResult_上へ.Text = "▲";
			this.CmsResult_上へ.Click += new System.EventHandler(this.CmsResult_上へ_Click);
			// 
			// CmsResult_下へ
			// 
			this.CmsResult_下へ.ForeColor = System.Drawing.Color.OrangeRed;
			this.CmsResult_下へ.Name = "CmsResult_下へ";
			this.CmsResult_下へ.Size = new System.Drawing.Size(86, 22);
			this.CmsResult_下へ.Text = "▼";
			this.CmsResult_下へ.Click += new System.EventHandler(this.CmsResult_下へ_Click);
			// 
			// BtnSaveFile
			// 
			this.BtnSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnSaveFile.BackColor = System.Drawing.Color.Firebrick;
			this.BtnSaveFile.ContextMenuStrip = this.CmsNull;
			this.BtnSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnSaveFile.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnSaveFile.ForeColor = System.Drawing.Color.White;
			this.BtnSaveFile.Location = new System.Drawing.Point(230, 187);
			this.BtnSaveFile.Margin = new System.Windows.Forms.Padding(0);
			this.BtnSaveFile.Name = "BtnSaveFile";
			this.BtnSaveFile.Size = new System.Drawing.Size(65, 24);
			this.BtnSaveFile.TabIndex = 4;
			this.BtnSaveFile.Text = "保存";
			this.BtnSaveFile.UseVisualStyleBackColor = false;
			this.BtnSaveFile.Click += new System.EventHandler(this.BtnSaveFile_Click);
			// 
			// CmsNull
			// 
			this.CmsNull.Name = "CmsNull";
			this.CmsNull.Size = new System.Drawing.Size(61, 4);
			// 
			// TbSaveFileName
			// 
			this.TbSaveFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TbSaveFileName.BackColor = System.Drawing.Color.GhostWhite;
			this.TbSaveFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TbSaveFileName.ContextMenuStrip = this.CmsSaveFileName;
			this.TbSaveFileName.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.TbSaveFileName.Location = new System.Drawing.Point(10, 160);
			this.TbSaveFileName.Margin = new System.Windows.Forms.Padding(0);
			this.TbSaveFileName.Name = "TbSaveFileName";
			this.TbSaveFileName.Size = new System.Drawing.Size(227, 20);
			this.TbSaveFileName.TabIndex = 0;
			this.TbSaveFileName.MouseEnter += new System.EventHandler(this.TbSaveFileName_MouseEnter);
			// 
			// CmsSaveFileName
			// 
			this.CmsSaveFileName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsSaveFileName_全クリア,
            this.CmsSaveFileName_L1,
            this.CmsSaveFileName_yyyyMMdd,
            this.CmsSaveFileName_yyyyMMddHHmm,
            this.CmsSaveFileName_yyyyMMddHHmmss});
			this.CmsSaveFileName.Name = "CmsTbSaveFileName";
			this.CmsSaveFileName.Size = new System.Drawing.Size(188, 98);
			// 
			// CmsSaveFileName_全クリア
			// 
			this.CmsSaveFileName_全クリア.Name = "CmsSaveFileName_全クリア";
			this.CmsSaveFileName_全クリア.Size = new System.Drawing.Size(187, 22);
			this.CmsSaveFileName_全クリア.Text = "全クリア";
			this.CmsSaveFileName_全クリア.Click += new System.EventHandler(this.CmsSaveFileName_全クリア_Click);
			// 
			// CmsSaveFileName_L1
			// 
			this.CmsSaveFileName_L1.Name = "CmsSaveFileName_L1";
			this.CmsSaveFileName_L1.Size = new System.Drawing.Size(184, 6);
			// 
			// CmsSaveFileName_yyyyMMdd
			// 
			this.CmsSaveFileName_yyyyMMdd.Name = "CmsSaveFileName_yyyyMMdd";
			this.CmsSaveFileName_yyyyMMdd.Size = new System.Drawing.Size(187, 22);
			this.CmsSaveFileName_yyyyMMdd.Text = "yyyyMMdd";
			this.CmsSaveFileName_yyyyMMdd.Click += new System.EventHandler(this.CmsSaveFileName_yyyyMMdd_Click);
			// 
			// CmsSaveFileName_yyyyMMddHHmm
			// 
			this.CmsSaveFileName_yyyyMMddHHmm.Name = "CmsSaveFileName_yyyyMMddHHmm";
			this.CmsSaveFileName_yyyyMMddHHmm.Size = new System.Drawing.Size(187, 22);
			this.CmsSaveFileName_yyyyMMddHHmm.Text = "yyyyMMdd_HHmm";
			this.CmsSaveFileName_yyyyMMddHHmm.Click += new System.EventHandler(this.CmsSaveFileName_yyyyMMddHHmm_Click);
			// 
			// CmsSaveFileName_yyyyMMddHHmmss
			// 
			this.CmsSaveFileName_yyyyMMddHHmmss.Name = "CmsSaveFileName_yyyyMMddHHmmss";
			this.CmsSaveFileName_yyyyMMddHHmmss.Size = new System.Drawing.Size(187, 22);
			this.CmsSaveFileName_yyyyMMddHHmmss.Text = "yyyyMMdd_HHmmss";
			this.CmsSaveFileName_yyyyMMddHHmmss.Click += new System.EventHandler(this.CmsSaveFileName_yyyyMMddHHmmss_Click);
			// 
			// CbExtension
			// 
			this.CbExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CbExtension.BackColor = System.Drawing.Color.GhostWhite;
			this.CbExtension.ContextMenuStrip = this.CmsNull;
			this.CbExtension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CbExtension.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.CbExtension.FormattingEnabled = true;
			this.CbExtension.ItemHeight = 12;
			this.CbExtension.Location = new System.Drawing.Point(242, 160);
			this.CbExtension.Margin = new System.Windows.Forms.Padding(0);
			this.CbExtension.Name = "CbExtension";
			this.CbExtension.Size = new System.Drawing.Size(52, 20);
			this.CbExtension.TabIndex = 1;
			this.CbExtension.MouseEnter += new System.EventHandler(this.CbExtension_MouseEnter);
			// 
			// CbTextCode
			// 
			this.CbTextCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CbTextCode.BackColor = System.Drawing.Color.DimGray;
			this.CbTextCode.ContextMenuStrip = this.CmsNull;
			this.CbTextCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CbTextCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CbTextCode.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.CbTextCode.ForeColor = System.Drawing.Color.White;
			this.CbTextCode.FormattingEnabled = true;
			this.CbTextCode.Location = new System.Drawing.Point(140, 189);
			this.CbTextCode.Margin = new System.Windows.Forms.Padding(0);
			this.CbTextCode.Name = "CbTextCode";
			this.CbTextCode.Size = new System.Drawing.Size(84, 20);
			this.CbTextCode.TabIndex = 3;
			this.CbTextCode.MouseEnter += new System.EventHandler(this.CbTextCode_MouseEnter);
			// 
			// ToolTip1
			// 
			this.ToolTip1.AutomaticDelay = 1000;
			// 
			// BtnReload
			// 
			this.BtnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnReload.BackColor = System.Drawing.Color.OrangeRed;
			this.BtnReload.ContextMenuStrip = this.CmsNull;
			this.BtnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnReload.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.BtnReload.ForeColor = System.Drawing.Color.White;
			this.BtnReload.Location = new System.Drawing.Point(10, 186);
			this.BtnReload.Margin = new System.Windows.Forms.Padding(0);
			this.BtnReload.Name = "BtnReload";
			this.BtnReload.Size = new System.Drawing.Size(65, 24);
			this.BtnReload.TabIndex = 2;
			this.BtnReload.TabStop = false;
			this.BtnReload.Text = "再読込";
			this.BtnReload.UseVisualStyleBackColor = false;
			this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
			this.BtnReload.MouseEnter += new System.EventHandler(this.BtnReload_MouseEnter);
			// 
			// GrpRB
			// 
			this.GrpRB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.GrpRB.BackColor = System.Drawing.Color.DimGray;
			this.GrpRB.Controls.Add(this.RB05);
			this.GrpRB.Controls.Add(this.RB04);
			this.GrpRB.Controls.Add(this.RB03);
			this.GrpRB.Controls.Add(this.RB02);
			this.GrpRB.Controls.Add(this.RB01);
			this.GrpRB.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.GrpRB.ForeColor = System.Drawing.Color.White;
			this.GrpRB.Location = new System.Drawing.Point(10, 125);
			this.GrpRB.Margin = new System.Windows.Forms.Padding(0);
			this.GrpRB.Name = "GrpRB";
			this.GrpRB.Padding = new System.Windows.Forms.Padding(0);
			this.GrpRB.Size = new System.Drawing.Size(285, 30);
			this.GrpRB.TabIndex = 6;
			this.GrpRB.TabStop = false;
			// 
			// RB05
			// 
			this.RB05.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RB05.AutoSize = true;
			this.RB05.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.RB05.ForeColor = System.Drawing.Color.White;
			this.RB05.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.RB05.Location = new System.Drawing.Point(205, 9);
			this.RB05.Margin = new System.Windows.Forms.Padding(0);
			this.RB05.Name = "RB05";
			this.RB05.Padding = new System.Windows.Forms.Padding(3, 1, 3, 0);
			this.RB05.Size = new System.Drawing.Size(47, 17);
			this.RB05.TabIndex = 11;
			this.RB05.Text = "5th";
			this.RB05.UseVisualStyleBackColor = true;
			this.RB05.CheckedChanged += new System.EventHandler(this.RB05_CheckedChanged);
			// 
			// RB04
			// 
			this.RB04.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RB04.AutoSize = true;
			this.RB04.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.RB04.ForeColor = System.Drawing.Color.White;
			this.RB04.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.RB04.Location = new System.Drawing.Point(155, 9);
			this.RB04.Margin = new System.Windows.Forms.Padding(0);
			this.RB04.Name = "RB04";
			this.RB04.Padding = new System.Windows.Forms.Padding(3, 1, 3, 0);
			this.RB04.Size = new System.Drawing.Size(47, 17);
			this.RB04.TabIndex = 10;
			this.RB04.Text = "4th";
			this.RB04.UseVisualStyleBackColor = true;
			this.RB04.CheckedChanged += new System.EventHandler(this.RB04_CheckedChanged);
			// 
			// RB03
			// 
			this.RB03.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RB03.AutoSize = true;
			this.RB03.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.RB03.ForeColor = System.Drawing.Color.White;
			this.RB03.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.RB03.Location = new System.Drawing.Point(105, 9);
			this.RB03.Margin = new System.Windows.Forms.Padding(0);
			this.RB03.Name = "RB03";
			this.RB03.Padding = new System.Windows.Forms.Padding(3, 1, 3, 0);
			this.RB03.Size = new System.Drawing.Size(47, 17);
			this.RB03.TabIndex = 9;
			this.RB03.Text = "3rd";
			this.RB03.UseVisualStyleBackColor = true;
			this.RB03.CheckedChanged += new System.EventHandler(this.RB03_CheckedChanged);
			// 
			// RB02
			// 
			this.RB02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RB02.AutoSize = true;
			this.RB02.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.RB02.ForeColor = System.Drawing.Color.White;
			this.RB02.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.RB02.Location = new System.Drawing.Point(55, 9);
			this.RB02.Margin = new System.Windows.Forms.Padding(0);
			this.RB02.Name = "RB02";
			this.RB02.Padding = new System.Windows.Forms.Padding(3, 1, 3, 0);
			this.RB02.Size = new System.Drawing.Size(47, 17);
			this.RB02.TabIndex = 8;
			this.RB02.Text = "2nd";
			this.RB02.UseVisualStyleBackColor = true;
			this.RB02.CheckedChanged += new System.EventHandler(this.RB02_CheckedChanged);
			// 
			// RB01
			// 
			this.RB01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RB01.AutoSize = true;
			this.RB01.BackColor = System.Drawing.Color.DimGray;
			this.RB01.Checked = true;
			this.RB01.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.RB01.ForeColor = System.Drawing.Color.White;
			this.RB01.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.RB01.Location = new System.Drawing.Point(5, 9);
			this.RB01.Margin = new System.Windows.Forms.Padding(0);
			this.RB01.Name = "RB01";
			this.RB01.Padding = new System.Windows.Forms.Padding(3, 1, 3, 0);
			this.RB01.Size = new System.Drawing.Size(47, 17);
			this.RB01.TabIndex = 7;
			this.RB01.TabStop = true;
			this.RB01.Text = "1st";
			this.RB01.UseVisualStyleBackColor = false;
			this.RB01.CheckedChanged += new System.EventHandler(this.RB01_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(304, 221);
			this.Controls.Add(this.TbResult);
			this.Controls.Add(this.GrpRB);
			this.Controls.Add(this.BtnReload);
			this.Controls.Add(this.CbTextCode);
			this.Controls.Add(this.CbExtension);
			this.Controls.Add(this.TbSaveFileName);
			this.Controls.Add(this.BtnSaveFile);
			this.MinimumSize = new System.Drawing.Size(320, 260);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ダミータイトル";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.CmsResult.ResumeLayout(false);
			this.CmsSaveFileName.ResumeLayout(false);
			this.GrpRB.ResumeLayout(false);
			this.GrpRB.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TbResult;
		private System.Windows.Forms.Button BtnSaveFile;
		private System.Windows.Forms.TextBox TbSaveFileName;
		private System.Windows.Forms.ComboBox CbExtension;
		private System.Windows.Forms.ComboBox CbTextCode;
		private System.Windows.Forms.ContextMenuStrip CmsSaveFileName;
		private System.Windows.Forms.ToolStripSeparator CmsSaveFileName_L1;
		private System.Windows.Forms.ToolStripMenuItem CmsSaveFileName_yyyyMMddHHmmss;
		private System.Windows.Forms.ToolStripMenuItem CmsSaveFileName_yyyyMMdd;
		private System.Windows.Forms.ContextMenuStrip CmsResult;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_上へ;
		private System.Windows.Forms.ToolStripMenuItem CmsResult_下へ;
		private System.Windows.Forms.ContextMenuStrip CmsNull;
		private System.Windows.Forms.ToolTip ToolTip1;
		private System.Windows.Forms.ToolStripMenuItem CmsSaveFileName_全クリア;
		private System.Windows.Forms.Button BtnReload;
		private System.Windows.Forms.GroupBox GrpRB;
		private System.Windows.Forms.RadioButton RB03;
		private System.Windows.Forms.RadioButton RB01;
		private System.Windows.Forms.RadioButton RB02;
		private System.Windows.Forms.RadioButton RB05;
		private System.Windows.Forms.RadioButton RB04;
		private System.Windows.Forms.ToolStripMenuItem CmsSaveFileName_yyyyMMddHHmm;
	}
}

