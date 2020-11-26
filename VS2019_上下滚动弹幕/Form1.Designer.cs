
namespace VS2019_上下滚动弹幕
{
    partial class 滚动弹幕窗口
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.滚动弹幕区 = new System.Windows.Forms.ListBox();
            this.计时滚动 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // 滚动弹幕区
            // 
            this.滚动弹幕区.BackColor = System.Drawing.SystemColors.ControlText;
            this.滚动弹幕区.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.滚动弹幕区.ForeColor = System.Drawing.SystemColors.Control;
            this.滚动弹幕区.FormattingEnabled = true;
            this.滚动弹幕区.ItemHeight = 12;
            this.滚动弹幕区.Items.AddRange(new object[] {
            "",
            "namespace VS2019_上下滚动弹幕",
            "{",
            "    partial class Form1",
            "    {",
            "        /// <summary>",
            "        /// 必需的设计器变量。",
            "        /// </summary>",
            "        private System.ComponentModel.IContainer components = null;",
            "",
            "        /// <summary>",
            "        /// 清理所有正在使用的资源。",
            "        /// </summary>",
            "        /// <param name=\"disposing\">如果应释放托管资源，为 true；否则为 false。</param>",
            "        protected override void Dispose(bool disposing)",
            "        {",
            "            if (disposing && (components != null))",
            "            {",
            "                components.Dispose();",
            "            }",
            "            base.Dispose(disposing);",
            "        }",
            "",
            "        #region Windows 窗体设计器生成的代码",
            "",
            "        /// <summary>",
            "        /// 设计器支持所需的方法 - 不要修改",
            "        /// 使用代码编辑器修改此方法的内容。",
            "        /// </summary>",
            "        private void InitializeComponent()",
            "        {",
            "            this.listBox1 = new System.Windows.Forms.ListBox();",
            "            this.SuspendLayout();",
            "            // ",
            "            // listBox1",
            "            // ",
            "            this.listBox1.FormattingEnabled = true;",
            "            this.listBox1.ItemHeight = 12;",
            "            this.listBox1.Location = new System.Drawing.Point(87, 12);",
            "            this.listBox1.Name = \"listBox1\";",
            "            this.listBox1.Size = new System.Drawing.Size(600, 448);",
            "            this.listBox1.TabIndex = 0;",
            "            // ",
            "            // Form1",
            "            // ",
            "            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);",
            "            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;",
            "            this.BackColor = System.Drawing.SystemColors.ControlText;",
            "            this.ClientSize = new System.Drawing.Size(784, 461);",
            "            this.Controls.Add(this.listBox1);",
            "            this.Name = \"Form1\";",
            "            this.Text = \"Form1\";",
            "            this.ResumeLayout(false);",
            "",
            "        }",
            "",
            "        #endregion",
            "",
            "        private System.Windows.Forms.ListBox listBox1;",
            "    }",
            "}"});
            this.滚动弹幕区.Location = new System.Drawing.Point(100, 12);
            this.滚动弹幕区.Name = "滚动弹幕区";
            this.滚动弹幕区.Size = new System.Drawing.Size(600, 756);
            this.滚动弹幕区.TabIndex = 0;
            // 
            // 计时滚动
            // 
            this.计时滚动.Enabled = true;
            this.计时滚动.Interval = 10;
            this.计时滚动.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 滚动弹幕窗口
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.滚动弹幕区);
            this.Name = "滚动弹幕窗口";
            this.Text = "滚动弹幕窗口";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox 滚动弹幕区;
        private System.Windows.Forms.Timer 计时滚动;
    }
}

