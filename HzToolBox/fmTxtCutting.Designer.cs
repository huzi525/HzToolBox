namespace HzToolBox
{
    partial class fmTxtCutting
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.stTip = new System.Windows.Forms.StatusStrip();
            this.stTipLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTail = new System.Windows.Forms.TextBox();
            this.tbHead = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHead = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbLineCount = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.cbByteUnit = new System.Windows.Forms.ComboBox();
            this.tbFileSize = new System.Windows.Forms.TextBox();
            this.tbFileCount = new System.Windows.Forms.TextBox();
            this.rbFileSizeSet = new System.Windows.Forms.RadioButton();
            this.rbFileCountSet = new System.Windows.Forms.RadioButton();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.cbRegular = new System.Windows.Forms.CheckBox();
            this.stTip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stTip
            // 
            this.stTip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stTipLabel});
            this.stTip.Location = new System.Drawing.Point(0, 713);
            this.stTip.Name = "stTip";
            this.stTip.Size = new System.Drawing.Size(639, 22);
            this.stTip.TabIndex = 3;
            this.stTip.Text = "statusStrip1";
            // 
            // stTipLabel
            // 
            this.stTipLabel.Name = "stTipLabel";
            this.stTipLabel.Size = new System.Drawing.Size(68, 17);
            this.stTipLabel.Text = "无文件加载";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbRegular);
            this.groupBox2.Controls.Add(this.tbReplace);
            this.groupBox2.Controls.Add(this.btnReplace);
            this.groupBox2.Controls.Add(this.btnQuery);
            this.groupBox2.Controls.Add(this.tbKeyword);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(22, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 544);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "高级设置";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnCut);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.tbFilePath);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 147);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbTail);
            this.groupBox1.Controls.Add(this.tbHead);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelHead);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.tbLineCount);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.cbByteUnit);
            this.groupBox1.Controls.Add(this.tbFileSize);
            this.groupBox1.Controls.Add(this.tbFileCount);
            this.groupBox1.Controls.Add(this.rbFileSizeSet);
            this.groupBox1.Controls.Add(this.rbFileCountSet);
            this.groupBox1.Location = new System.Drawing.Point(14, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 98);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件分割设置区";
            // 
            // tbTail
            // 
            this.tbTail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTail.Location = new System.Drawing.Point(304, 60);
            this.tbTail.Multiline = true;
            this.tbTail.Name = "tbTail";
            this.tbTail.Size = new System.Drawing.Size(256, 21);
            this.tbTail.TabIndex = 7;
            // 
            // tbHead
            // 
            this.tbHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHead.Location = new System.Drawing.Point(304, 28);
            this.tbHead.Name = "tbHead";
            this.tbHead.Size = new System.Drawing.Size(256, 21);
            this.tbHead.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "附加文件尾:";
            // 
            // labelHead
            // 
            this.labelHead.AutoSize = true;
            this.labelHead.Location = new System.Drawing.Point(226, 38);
            this.labelHead.Name = "labelHead";
            this.labelHead.Size = new System.Drawing.Size(71, 12);
            this.labelHead.TabIndex = 6;
            this.labelHead.Text = "附加文件头:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(226, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "网页输出";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbLineCount
            // 
            this.tbLineCount.Location = new System.Drawing.Point(106, 60);
            this.tbLineCount.Name = "tbLineCount";
            this.tbLineCount.Size = new System.Drawing.Size(102, 21);
            this.tbLineCount.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 65);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 16);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "按文件行数";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // cbByteUnit
            // 
            this.cbByteUnit.FormattingEnabled = true;
            this.cbByteUnit.Items.AddRange(new object[] {
            "KB",
            "MB"});
            this.cbByteUnit.Location = new System.Drawing.Point(166, 39);
            this.cbByteUnit.Name = "cbByteUnit";
            this.cbByteUnit.Size = new System.Drawing.Size(42, 20);
            this.cbByteUnit.TabIndex = 2;
            // 
            // tbFileSize
            // 
            this.tbFileSize.Location = new System.Drawing.Point(106, 38);
            this.tbFileSize.Name = "tbFileSize";
            this.tbFileSize.Size = new System.Drawing.Size(54, 21);
            this.tbFileSize.TabIndex = 1;
            this.tbFileSize.Text = "100";
            // 
            // tbFileCount
            // 
            this.tbFileCount.Location = new System.Drawing.Point(106, 15);
            this.tbFileCount.Name = "tbFileCount";
            this.tbFileCount.Size = new System.Drawing.Size(102, 21);
            this.tbFileCount.TabIndex = 1;
            // 
            // rbFileSizeSet
            // 
            this.rbFileSizeSet.AutoSize = true;
            this.rbFileSizeSet.Location = new System.Drawing.Point(7, 43);
            this.rbFileSizeSet.Name = "rbFileSizeSet";
            this.rbFileSizeSet.Size = new System.Drawing.Size(83, 16);
            this.rbFileSizeSet.TabIndex = 0;
            this.rbFileSizeSet.Text = "按文件大小";
            this.rbFileSizeSet.UseVisualStyleBackColor = true;
            // 
            // rbFileCountSet
            // 
            this.rbFileCountSet.AutoSize = true;
            this.rbFileCountSet.Checked = true;
            this.rbFileCountSet.Location = new System.Drawing.Point(7, 21);
            this.rbFileCountSet.Name = "rbFileCountSet";
            this.rbFileCountSet.Size = new System.Drawing.Size(83, 16);
            this.rbFileCountSet.TabIndex = 0;
            this.rbFileCountSet.TabStop = true;
            this.rbFileCountSet.Text = "按文件个数";
            this.rbFileCountSet.UseVisualStyleBackColor = true;
            // 
            // btnCut
            // 
            this.btnCut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCut.Location = new System.Drawing.Point(499, 5);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(75, 23);
            this.btnCut.TabIndex = 4;
            this.btnCut.Text = "分割";
            this.btnCut.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(418, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFilePath.Location = new System.Drawing.Point(14, 5);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(398, 21);
            this.tbFilePath.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(14, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(566, 476);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tbKeyword
            // 
            this.tbKeyword.Location = new System.Drawing.Point(14, 21);
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(160, 21);
            this.tbKeyword.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(180, 19);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查找";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // tbReplace
            // 
            this.tbReplace.Location = new System.Drawing.Point(352, 21);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(141, 21);
            this.tbReplace.TabIndex = 3;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(499, 21);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 2;
            this.btnReplace.Text = "替换";
            this.btnReplace.UseVisualStyleBackColor = true;
            // 
            // cbRegular
            // 
            this.cbRegular.AutoSize = true;
            this.cbRegular.Location = new System.Drawing.Point(262, 21);
            this.cbRegular.Name = "cbRegular";
            this.cbRegular.Size = new System.Drawing.Size(84, 16);
            this.cbRegular.TabIndex = 4;
            this.cbRegular.Text = "正则表达式";
            this.cbRegular.UseVisualStyleBackColor = true;
            // 
            // fmTxtCutting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 735);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.stTip);
            this.Name = "fmTxtCutting";
            this.Text = "文本文件分割工具 Huzi@2017";
            this.stTip.ResumeLayout(false);
            this.stTip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stTip;
        private System.Windows.Forms.ToolStripStatusLabel stTipLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTail;
        private System.Windows.Forms.TextBox tbHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHead;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tbLineCount;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cbByteUnit;
        private System.Windows.Forms.TextBox tbFileSize;
        private System.Windows.Forms.TextBox tbFileCount;
        private System.Windows.Forms.RadioButton rbFileSizeSet;
        private System.Windows.Forms.RadioButton rbFileCountSet;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.CheckBox cbRegular;
        private System.Windows.Forms.TextBox tbReplace;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

