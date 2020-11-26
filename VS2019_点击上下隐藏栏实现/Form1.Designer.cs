namespace VS2019_点击上下隐藏栏实现
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_All = new System.Windows.Forms.Panel();
            this.panel_menu3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_Title3 = new System.Windows.Forms.Panel();
            this.picbox_3 = new System.Windows.Forms.PictureBox();
            this.panel_menu2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Title2 = new System.Windows.Forms.Panel();
            this.picbox_2 = new System.Windows.Forms.PictureBox();
            this.panel_menu1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Title1 = new System.Windows.Forms.Panel();
            this.picbox_1 = new System.Windows.Forms.PictureBox();
            this.panel_All.SuspendLayout();
            this.panel_menu3.SuspendLayout();
            this.panel_Title3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_3)).BeginInit();
            this.panel_menu2.SuspendLayout();
            this.panel_Title2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_2)).BeginInit();
            this.panel_menu1.SuspendLayout();
            this.panel_Title1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_All
            // 
            this.panel_All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(83)))), ((int)(((byte)(163)))));
            this.panel_All.Controls.Add(this.panel_menu3);
            this.panel_All.Controls.Add(this.panel_Title3);
            this.panel_All.Controls.Add(this.panel_menu2);
            this.panel_All.Controls.Add(this.panel_Title2);
            this.panel_All.Controls.Add(this.panel_menu1);
            this.panel_All.Controls.Add(this.panel_Title1);
            this.panel_All.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_All.Location = new System.Drawing.Point(0, 0);
            this.panel_All.Name = "panel_All";
            this.panel_All.Size = new System.Drawing.Size(249, 347);
            this.panel_All.TabIndex = 0;
            // 
            // panel_menu3
            // 
            this.panel_menu3.BackColor = System.Drawing.Color.White;
            this.panel_menu3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu3.Controls.Add(this.label6);
            this.panel_menu3.Controls.Add(this.label5);
            this.panel_menu3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu3.Location = new System.Drawing.Point(0, 252);
            this.panel_menu3.Name = "panel_menu3";
            this.panel_menu3.Size = new System.Drawing.Size(249, 81);
            this.panel_menu3.TabIndex = 4;
            this.panel_menu3.Tag = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(71, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "我的文档";
            this.label6.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label6.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(71, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "我的电脑";
            this.label5.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label5.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // panel_Title3
            // 
            this.panel_Title3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(82)))), ((int)(((byte)(162)))));
            this.panel_Title3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Title3.Controls.Add(this.picbox_3);
            this.panel_Title3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title3.Location = new System.Drawing.Point(0, 222);
            this.panel_Title3.Name = "panel_Title3";
            this.panel_Title3.Size = new System.Drawing.Size(249, 30);
            this.panel_Title3.TabIndex = 3;
            // 
            // picbox_3
            // 
            this.picbox_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_3.BackgroundImage")));
            this.picbox_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbox_3.Location = new System.Drawing.Point(221, 3);
            this.picbox_3.Name = "picbox_3";
            this.picbox_3.Size = new System.Drawing.Size(25, 25);
            this.picbox_3.TabIndex = 2;
            this.picbox_3.TabStop = false;
            this.picbox_3.Tag = "3";
            this.picbox_3.Click += new System.EventHandler(this.picbox_1_Click);
            // 
            // panel_menu2
            // 
            this.panel_menu2.BackColor = System.Drawing.Color.White;
            this.panel_menu2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu2.Controls.Add(this.label4);
            this.panel_menu2.Controls.Add(this.label3);
            this.panel_menu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu2.Location = new System.Drawing.Point(0, 141);
            this.panel_menu2.Name = "panel_menu2";
            this.panel_menu2.Size = new System.Drawing.Size(249, 81);
            this.panel_menu2.TabIndex = 2;
            this.panel_menu2.Tag = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(71, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "计算器";
            this.label4.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(71, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "记事本";
            this.label3.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // panel_Title2
            // 
            this.panel_Title2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(82)))), ((int)(((byte)(162)))));
            this.panel_Title2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Title2.Controls.Add(this.picbox_2);
            this.panel_Title2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title2.Location = new System.Drawing.Point(0, 111);
            this.panel_Title2.Name = "panel_Title2";
            this.panel_Title2.Size = new System.Drawing.Size(249, 30);
            this.panel_Title2.TabIndex = 2;
            // 
            // picbox_2
            // 
            this.picbox_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_2.BackgroundImage")));
            this.picbox_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbox_2.Location = new System.Drawing.Point(221, 3);
            this.picbox_2.Name = "picbox_2";
            this.picbox_2.Size = new System.Drawing.Size(25, 25);
            this.picbox_2.TabIndex = 1;
            this.picbox_2.TabStop = false;
            this.picbox_2.Tag = "2";
            this.picbox_2.Click += new System.EventHandler(this.picbox_1_Click);
            // 
            // panel_menu1
            // 
            this.panel_menu1.BackColor = System.Drawing.Color.White;
            this.panel_menu1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu1.Controls.Add(this.label2);
            this.panel_menu1.Controls.Add(this.label1);
            this.panel_menu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu1.Location = new System.Drawing.Point(0, 30);
            this.panel_menu1.Name = "panel_menu1";
            this.panel_menu1.Size = new System.Drawing.Size(249, 81);
            this.panel_menu1.TabIndex = 2;
            this.panel_menu1.Tag = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(71, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "客户信息录入";
            this.label2.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(71, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "产品信息录入";
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // panel_Title1
            // 
            this.panel_Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(82)))), ((int)(((byte)(162)))));
            this.panel_Title1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Title1.Controls.Add(this.picbox_1);
            this.panel_Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title1.Location = new System.Drawing.Point(0, 0);
            this.panel_Title1.Name = "panel_Title1";
            this.panel_Title1.Size = new System.Drawing.Size(249, 30);
            this.panel_Title1.TabIndex = 1;
            // 
            // picbox_1
            // 
            this.picbox_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbox_1.BackgroundImage")));
            this.picbox_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picbox_1.Location = new System.Drawing.Point(221, 3);
            this.picbox_1.Name = "picbox_1";
            this.picbox_1.Size = new System.Drawing.Size(25, 25);
            this.picbox_1.TabIndex = 0;
            this.picbox_1.TabStop = false;
            this.picbox_1.Tag = "1";
            this.picbox_1.Click += new System.EventHandler(this.picbox_1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(211)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(560, 347);
            this.Controls.Add(this.panel_All);
            this.Name = "Form1";
            this.Text = "任务栏菜单";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_All.ResumeLayout(false);
            this.panel_menu3.ResumeLayout(false);
            this.panel_menu3.PerformLayout();
            this.panel_Title3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_3)).EndInit();
            this.panel_menu2.ResumeLayout(false);
            this.panel_menu2.PerformLayout();
            this.panel_Title2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_2)).EndInit();
            this.panel_menu1.ResumeLayout(false);
            this.panel_menu1.PerformLayout();
            this.panel_Title1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_All;
        private System.Windows.Forms.Panel panel_menu2;
        private System.Windows.Forms.Panel panel_Title2;
        private System.Windows.Forms.Panel panel_menu1;
        private System.Windows.Forms.Panel panel_Title1;
        private System.Windows.Forms.Panel panel_menu3;
        private System.Windows.Forms.Panel panel_Title3;
        private System.Windows.Forms.PictureBox picbox_3;
        private System.Windows.Forms.PictureBox picbox_2;
        private System.Windows.Forms.PictureBox picbox_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

