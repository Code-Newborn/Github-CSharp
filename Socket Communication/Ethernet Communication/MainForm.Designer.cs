
namespace Ethernet_Communication
{
    partial class MainForm
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
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.textBox_COM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Send = new System.Windows.Forms.Button();
            this.textBox_MessageSend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_MessageReceive = new System.Windows.Forms.TextBox();
            this.button_SendInGroups = new System.Windows.Forms.Button();
            this.listBox_DeviceOnline = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_IP
            // 
            this.textBox_IP.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_IP.Location = new System.Drawing.Point(488, 25);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(135, 26);
            this.textBox_IP.TabIndex = 1;
            this.textBox_IP.Text = "127.0.0.1";
            // 
            // textBox_COM
            // 
            this.textBox_COM.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox_COM.Location = new System.Drawing.Point(488, 55);
            this.textBox_COM.Name = "textBox_COM";
            this.textBox_COM.Size = new System.Drawing.Size(135, 26);
            this.textBox_COM.TabIndex = 2;
            this.textBox_COM.Text = "8060";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(410, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP地址:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(410, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "端口号:";
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("宋体", 12F);
            this.button_Start.Location = new System.Drawing.Point(455, 247);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(126, 33);
            this.button_Start.TabIndex = 5;
            this.button_Start.Text = "启动服务";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Send
            // 
            this.button_Send.Font = new System.Drawing.Font("宋体", 12F);
            this.button_Send.Location = new System.Drawing.Point(455, 290);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(126, 33);
            this.button_Send.TabIndex = 6;
            this.button_Send.Text = "发送消息";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // textBox_MessageSend
            // 
            this.textBox_MessageSend.Location = new System.Drawing.Point(12, 216);
            this.textBox_MessageSend.Multiline = true;
            this.textBox_MessageSend.Name = "textBox_MessageSend";
            this.textBox_MessageSend.Size = new System.Drawing.Size(360, 150);
            this.textBox_MessageSend.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(9, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "消息发送";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "消息接收";
            // 
            // textBox_MessageReceive
            // 
            this.textBox_MessageReceive.Location = new System.Drawing.Point(12, 31);
            this.textBox_MessageReceive.Multiline = true;
            this.textBox_MessageReceive.Name = "textBox_MessageReceive";
            this.textBox_MessageReceive.ReadOnly = true;
            this.textBox_MessageReceive.Size = new System.Drawing.Size(360, 150);
            this.textBox_MessageReceive.TabIndex = 9;
            // 
            // button_SendInGroups
            // 
            this.button_SendInGroups.Font = new System.Drawing.Font("宋体", 12F);
            this.button_SendInGroups.Location = new System.Drawing.Point(455, 333);
            this.button_SendInGroups.Name = "button_SendInGroups";
            this.button_SendInGroups.Size = new System.Drawing.Size(126, 33);
            this.button_SendInGroups.TabIndex = 11;
            this.button_SendInGroups.Text = "群发消息";
            this.button_SendInGroups.UseVisualStyleBackColor = true;
            this.button_SendInGroups.Click += new System.EventHandler(this.button_SendInGroups_Click);
            // 
            // listBox_DeviceOnline
            // 
            this.listBox_DeviceOnline.Font = new System.Drawing.Font("宋体", 12F);
            this.listBox_DeviceOnline.FormattingEnabled = true;
            this.listBox_DeviceOnline.ItemHeight = 16;
            this.listBox_DeviceOnline.Location = new System.Drawing.Point(413, 121);
            this.listBox_DeviceOnline.Name = "listBox_DeviceOnline";
            this.listBox_DeviceOnline.Size = new System.Drawing.Size(210, 116);
            this.listBox_DeviceOnline.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(410, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "在线列表";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 381);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox_DeviceOnline);
            this.Controls.Add(this.button_SendInGroups);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_MessageReceive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_MessageSend);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_COM);
            this.Controls.Add(this.textBox_IP);
            this.Name = "MainForm";
            this.Text = "基于socket的TCP服务器通信";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.TextBox textBox_COM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.TextBox textBox_MessageSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_MessageReceive;
        private System.Windows.Forms.Button button_SendInGroups;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_DeviceOnline;
    }
}

