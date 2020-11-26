namespace VS2019_ExchangeSkin窗体换肤
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
            this.components = new System.ComponentModel.Container();
            this.panel_Titile = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pic_Size = new System.Windows.Forms.PictureBox();
            this.pic_Min = new System.Windows.Forms.PictureBox();
            this.pic_Close = new System.Windows.Forms.PictureBox();
            this.panel_WorkClient = new System.Windows.Forms.Panel();
            this.panel_Titile.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Titile
            // 
            this.panel_Titile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(109)))), ((int)(((byte)(147)))));
            this.panel_Titile.ContextMenuStrip = this.contextMenuStrip1;
            this.panel_Titile.Controls.Add(this.pic_Size);
            this.panel_Titile.Controls.Add(this.pic_Min);
            this.panel_Titile.Controls.Add(this.pic_Close);
            this.panel_Titile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Titile.Location = new System.Drawing.Point(0, 0);
            this.panel_Titile.Name = "panel_Titile";
            this.panel_Titile.Size = new System.Drawing.Size(298, 37);
            this.panel_Titile.TabIndex = 0;
            this.panel_Titile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Titile_MouseDown);
            this.panel_Titile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Titile_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem1.Tag = "0";
            this.toolStripMenuItem1.Text = "换肤1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem2.Tag = "1";
            this.toolStripMenuItem2.Text = "换肤2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem3.Tag = "2";
            this.toolStripMenuItem3.Text = "换肤3";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // pic_Size
            // 
            this.pic_Size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(149)))));
            this.pic_Size.BackgroundImage = global::VS2019_ExchangeSkin窗体换肤.Properties.Resources.fullscreen_expand;
            this.pic_Size.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Size.Location = new System.Drawing.Point(230, 6);
            this.pic_Size.Name = "pic_Size";
            this.pic_Size.Size = new System.Drawing.Size(25, 25);
            this.pic_Size.TabIndex = 2;
            this.pic_Size.TabStop = false;
            this.pic_Size.Tag = "1";
            this.pic_Size.Click += new System.EventHandler(this.pic_Min_Click);
            this.pic_Size.MouseEnter += new System.EventHandler(this.pic_Min_MouseEnter);
            this.pic_Size.MouseLeave += new System.EventHandler(this.pic_Min_MouseLeave);
            // 
            // pic_Min
            // 
            this.pic_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(149)))));
            this.pic_Min.BackgroundImage = global::VS2019_ExchangeSkin窗体换肤.Properties.Resources.min;
            this.pic_Min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Min.Location = new System.Drawing.Point(199, 6);
            this.pic_Min.Name = "pic_Min";
            this.pic_Min.Size = new System.Drawing.Size(25, 25);
            this.pic_Min.TabIndex = 1;
            this.pic_Min.TabStop = false;
            this.pic_Min.Tag = "0";
            this.pic_Min.Click += new System.EventHandler(this.pic_Min_Click);
            this.pic_Min.MouseEnter += new System.EventHandler(this.pic_Min_MouseEnter);
            this.pic_Min.MouseLeave += new System.EventHandler(this.pic_Min_MouseLeave);
            // 
            // pic_Close
            // 
            this.pic_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(149)))));
            this.pic_Close.BackgroundImage = global::VS2019_ExchangeSkin窗体换肤.Properties.Resources.close;
            this.pic_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_Close.Location = new System.Drawing.Point(261, 6);
            this.pic_Close.Name = "pic_Close";
            this.pic_Close.Size = new System.Drawing.Size(25, 25);
            this.pic_Close.TabIndex = 0;
            this.pic_Close.TabStop = false;
            this.pic_Close.Tag = "2";
            this.pic_Close.Click += new System.EventHandler(this.pic_Min_Click);
            this.pic_Close.MouseEnter += new System.EventHandler(this.pic_Min_MouseEnter);
            this.pic_Close.MouseLeave += new System.EventHandler(this.pic_Min_MouseLeave);
            // 
            // panel_WorkClient
            // 
            this.panel_WorkClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(149)))));
            this.panel_WorkClient.ContextMenuStrip = this.contextMenuStrip1;
            this.panel_WorkClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_WorkClient.Location = new System.Drawing.Point(0, 37);
            this.panel_WorkClient.Name = "panel_WorkClient";
            this.panel_WorkClient.Size = new System.Drawing.Size(298, 157);
            this.panel_WorkClient.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 194);
            this.Controls.Add(this.panel_WorkClient);
            this.Controls.Add(this.panel_Titile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Titile.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Titile;
        private System.Windows.Forms.Panel panel_WorkClient;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.PictureBox pic_Size;
        private System.Windows.Forms.PictureBox pic_Min;
        private System.Windows.Forms.PictureBox pic_Close;
    }
}

