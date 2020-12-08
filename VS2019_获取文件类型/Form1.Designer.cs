
namespace VS2019_获取文件类型
{
    partial class FileView_form
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
            this.Fileview_lstview = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Fileview_lstview
            // 
            this.Fileview_lstview.AllowDrop = true;
            this.Fileview_lstview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fileview_lstview.HideSelection = false;
            this.Fileview_lstview.Location = new System.Drawing.Point(0, 0);
            this.Fileview_lstview.Name = "Fileview_lstview";
            this.Fileview_lstview.Scrollable = false;
            this.Fileview_lstview.Size = new System.Drawing.Size(334, 161);
            this.Fileview_lstview.TabIndex = 0;
            this.Fileview_lstview.UseCompatibleStateImageBehavior = false;
            this.Fileview_lstview.DragEnter += new System.Windows.Forms.DragEventHandler(this.Fileview_lstview_DragEnter);
            // 
            // FileView_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.Fileview_lstview);
            this.Name = "FileView_form";
            this.Text = "VS2019_获取文件类型";
            this.Shown += new System.EventHandler(this.FileView_form_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Fileview_lstview;
    }
}

