namespace 串口通信
{
    partial class SerialPortsForm
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
            this.btn_OpenSp = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_ScanSp = new System.Windows.Forms.Button();
            this.btn_CloseSp = new System.Windows.Forms.Button();
            this.btn_SendClear = new System.Windows.Forms.Button();
            this.btn_ReceiveClear = new System.Windows.Forms.Button();
            this.tbox_Send = new System.Windows.Forms.TextBox();
            this.tbox_Receive = new System.Windows.Forms.TextBox();
            this.gpbox_SpSet = new System.Windows.Forms.GroupBox();
            this.lbl_BaudRate = new System.Windows.Forms.Label();
            this.cbox_BaudRate = new System.Windows.Forms.ComboBox();
            this.cbox_com = new System.Windows.Forms.ComboBox();
            this.grpBox_ReceiveSet = new System.Windows.Forms.GroupBox();
            this.rbtn_ReceiveASCII = new System.Windows.Forms.RadioButton();
            this.rbtn_ReceiveHex = new System.Windows.Forms.RadioButton();
            this.grpBox_SendSet = new System.Windows.Forms.GroupBox();
            this.rbtn_SendASCII = new System.Windows.Forms.RadioButton();
            this.rbtn_SendHex = new System.Windows.Forms.RadioButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.gpbox_SpSet.SuspendLayout();
            this.grpBox_ReceiveSet.SuspendLayout();
            this.grpBox_SendSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OpenSp
            // 
            this.btn_OpenSp.Font = new System.Drawing.Font("宋体", 10F);
            this.btn_OpenSp.Location = new System.Drawing.Point(14, 95);
            this.btn_OpenSp.Name = "btn_OpenSp";
            this.btn_OpenSp.Size = new System.Drawing.Size(96, 30);
            this.btn_OpenSp.TabIndex = 3;
            this.btn_OpenSp.Text = "打开串口";
            this.btn_OpenSp.UseVisualStyleBackColor = true;
            this.btn_OpenSp.Click += new System.EventHandler(this.btn_OpenSp_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("宋体", 10F);
            this.btn_Send.Location = new System.Drawing.Point(457, 227);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 56);
            this.btn_Send.TabIndex = 9;
            this.btn_Send.Text = "发送";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_ScanSp
            // 
            this.btn_ScanSp.Font = new System.Drawing.Font("宋体", 10F);
            this.btn_ScanSp.Location = new System.Drawing.Point(14, 27);
            this.btn_ScanSp.Name = "btn_ScanSp";
            this.btn_ScanSp.Size = new System.Drawing.Size(77, 30);
            this.btn_ScanSp.TabIndex = 0;
            this.btn_ScanSp.Text = "扫描端口";
            this.btn_ScanSp.UseVisualStyleBackColor = true;
            this.btn_ScanSp.Click += new System.EventHandler(this.btn_ScanSp_Click);
            // 
            // btn_CloseSp
            // 
            this.btn_CloseSp.Font = new System.Drawing.Font("宋体", 10F);
            this.btn_CloseSp.Location = new System.Drawing.Point(122, 95);
            this.btn_CloseSp.Name = "btn_CloseSp";
            this.btn_CloseSp.Size = new System.Drawing.Size(96, 30);
            this.btn_CloseSp.TabIndex = 4;
            this.btn_CloseSp.Text = "关闭串口";
            this.btn_CloseSp.UseVisualStyleBackColor = true;
            this.btn_CloseSp.Click += new System.EventHandler(this.btn_CloseSp_Click);
            // 
            // btn_SendClear
            // 
            this.btn_SendClear.Font = new System.Drawing.Font("宋体", 10F);
            this.btn_SendClear.Location = new System.Drawing.Point(145, 18);
            this.btn_SendClear.Name = "btn_SendClear";
            this.btn_SendClear.Size = new System.Drawing.Size(77, 30);
            this.btn_SendClear.TabIndex = 6;
            this.btn_SendClear.Text = "清空发送";
            this.btn_SendClear.UseVisualStyleBackColor = true;
            this.btn_SendClear.Click += new System.EventHandler(this.btn_SendClear_Click);
            // 
            // btn_ReceiveClear
            // 
            this.btn_ReceiveClear.Font = new System.Drawing.Font("宋体", 10F);
            this.btn_ReceiveClear.Location = new System.Drawing.Point(145, 19);
            this.btn_ReceiveClear.Name = "btn_ReceiveClear";
            this.btn_ReceiveClear.Size = new System.Drawing.Size(77, 30);
            this.btn_ReceiveClear.TabIndex = 5;
            this.btn_ReceiveClear.Text = "清空接收";
            this.btn_ReceiveClear.UseVisualStyleBackColor = true;
            this.btn_ReceiveClear.Click += new System.EventHandler(this.btn_ReceiveClear_Click);
            // 
            // tbox_Send
            // 
            this.tbox_Send.Location = new System.Drawing.Point(252, 227);
            this.tbox_Send.Multiline = true;
            this.tbox_Send.Name = "tbox_Send";
            this.tbox_Send.Size = new System.Drawing.Size(199, 56);
            this.tbox_Send.TabIndex = 7;
            // 
            // tbox_Receive
            // 
            this.tbox_Receive.Location = new System.Drawing.Point(252, 21);
            this.tbox_Receive.Multiline = true;
            this.tbox_Receive.Name = "tbox_Receive";
            this.tbox_Receive.ReadOnly = true;
            this.tbox_Receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbox_Receive.Size = new System.Drawing.Size(280, 200);
            this.tbox_Receive.TabIndex = 8;
            // 
            // gpbox_SpSet
            // 
            this.gpbox_SpSet.Controls.Add(this.lbl_BaudRate);
            this.gpbox_SpSet.Controls.Add(this.cbox_BaudRate);
            this.gpbox_SpSet.Controls.Add(this.cbox_com);
            this.gpbox_SpSet.Controls.Add(this.btn_OpenSp);
            this.gpbox_SpSet.Controls.Add(this.btn_ScanSp);
            this.gpbox_SpSet.Controls.Add(this.btn_CloseSp);
            this.gpbox_SpSet.Font = new System.Drawing.Font("宋体", 12F);
            this.gpbox_SpSet.Location = new System.Drawing.Point(12, 12);
            this.gpbox_SpSet.Name = "gpbox_SpSet";
            this.gpbox_SpSet.Size = new System.Drawing.Size(234, 138);
            this.gpbox_SpSet.TabIndex = 8;
            this.gpbox_SpSet.TabStop = false;
            this.gpbox_SpSet.Text = "串口设置";
            // 
            // lbl_BaudRate
            // 
            this.lbl_BaudRate.AutoSize = true;
            this.lbl_BaudRate.Location = new System.Drawing.Point(24, 63);
            this.lbl_BaudRate.Name = "lbl_BaudRate";
            this.lbl_BaudRate.Size = new System.Drawing.Size(56, 16);
            this.lbl_BaudRate.TabIndex = 6;
            this.lbl_BaudRate.Text = "波特率";
            // 
            // cbox_BaudRate
            // 
            this.cbox_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_BaudRate.FormattingEnabled = true;
            this.cbox_BaudRate.Items.AddRange(new object[] {
            "9600",
            "12800",
            "115200"});
            this.cbox_BaudRate.Location = new System.Drawing.Point(97, 60);
            this.cbox_BaudRate.Name = "cbox_BaudRate";
            this.cbox_BaudRate.Size = new System.Drawing.Size(121, 24);
            this.cbox_BaudRate.TabIndex = 2;
            // 
            // cbox_com
            // 
            this.cbox_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_com.FormattingEnabled = true;
            this.cbox_com.Location = new System.Drawing.Point(97, 30);
            this.cbox_com.Name = "cbox_com";
            this.cbox_com.Size = new System.Drawing.Size(121, 24);
            this.cbox_com.TabIndex = 1;
            // 
            // grpBox_ReceiveSet
            // 
            this.grpBox_ReceiveSet.Controls.Add(this.rbtn_ReceiveASCII);
            this.grpBox_ReceiveSet.Controls.Add(this.rbtn_ReceiveHex);
            this.grpBox_ReceiveSet.Controls.Add(this.btn_ReceiveClear);
            this.grpBox_ReceiveSet.Font = new System.Drawing.Font("宋体", 12F);
            this.grpBox_ReceiveSet.Location = new System.Drawing.Point(12, 156);
            this.grpBox_ReceiveSet.Name = "grpBox_ReceiveSet";
            this.grpBox_ReceiveSet.Size = new System.Drawing.Size(234, 57);
            this.grpBox_ReceiveSet.TabIndex = 9;
            this.grpBox_ReceiveSet.TabStop = false;
            this.grpBox_ReceiveSet.Text = "接收设置";
            // 
            // rbtn_ReceiveASCII
            // 
            this.rbtn_ReceiveASCII.AutoSize = true;
            this.rbtn_ReceiveASCII.Location = new System.Drawing.Point(70, 23);
            this.rbtn_ReceiveASCII.Name = "rbtn_ReceiveASCII";
            this.rbtn_ReceiveASCII.Size = new System.Drawing.Size(66, 20);
            this.rbtn_ReceiveASCII.TabIndex = 7;
            this.rbtn_ReceiveASCII.TabStop = true;
            this.rbtn_ReceiveASCII.Text = "ASCII";
            this.rbtn_ReceiveASCII.UseVisualStyleBackColor = true;
            // 
            // rbtn_ReceiveHex
            // 
            this.rbtn_ReceiveHex.AutoSize = true;
            this.rbtn_ReceiveHex.Location = new System.Drawing.Point(14, 23);
            this.rbtn_ReceiveHex.Name = "rbtn_ReceiveHex";
            this.rbtn_ReceiveHex.Size = new System.Drawing.Size(50, 20);
            this.rbtn_ReceiveHex.TabIndex = 6;
            this.rbtn_ReceiveHex.TabStop = true;
            this.rbtn_ReceiveHex.Text = "HEX";
            this.rbtn_ReceiveHex.UseVisualStyleBackColor = true;
            // 
            // grpBox_SendSet
            // 
            this.grpBox_SendSet.Controls.Add(this.rbtn_SendASCII);
            this.grpBox_SendSet.Controls.Add(this.rbtn_SendHex);
            this.grpBox_SendSet.Controls.Add(this.btn_SendClear);
            this.grpBox_SendSet.Font = new System.Drawing.Font("宋体", 12F);
            this.grpBox_SendSet.Location = new System.Drawing.Point(12, 227);
            this.grpBox_SendSet.Name = "grpBox_SendSet";
            this.grpBox_SendSet.Size = new System.Drawing.Size(234, 56);
            this.grpBox_SendSet.TabIndex = 10;
            this.grpBox_SendSet.TabStop = false;
            this.grpBox_SendSet.Text = "发送设置";
            // 
            // rbtn_SendASCII
            // 
            this.rbtn_SendASCII.AutoSize = true;
            this.rbtn_SendASCII.Location = new System.Drawing.Point(70, 25);
            this.rbtn_SendASCII.Name = "rbtn_SendASCII";
            this.rbtn_SendASCII.Size = new System.Drawing.Size(66, 20);
            this.rbtn_SendASCII.TabIndex = 9;
            this.rbtn_SendASCII.TabStop = true;
            this.rbtn_SendASCII.Text = "ASCII";
            this.rbtn_SendASCII.UseVisualStyleBackColor = true;
            // 
            // rbtn_SendHex
            // 
            this.rbtn_SendHex.AutoSize = true;
            this.rbtn_SendHex.Location = new System.Drawing.Point(14, 25);
            this.rbtn_SendHex.Name = "rbtn_SendHex";
            this.rbtn_SendHex.Size = new System.Drawing.Size(50, 20);
            this.rbtn_SendHex.TabIndex = 8;
            this.rbtn_SendHex.TabStop = true;
            this.rbtn_SendHex.Text = "HEX";
            this.rbtn_SendHex.UseVisualStyleBackColor = true;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // SerialPortsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 291);
            this.Controls.Add(this.tbox_Send);
            this.Controls.Add(this.tbox_Receive);
            this.Controls.Add(this.grpBox_SendSet);
            this.Controls.Add(this.grpBox_ReceiveSet);
            this.Controls.Add(this.gpbox_SpSet);
            this.Controls.Add(this.btn_Send);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(560, 330);
            this.MinimumSize = new System.Drawing.Size(560, 330);
            this.Name = "SerialPortsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口通信";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.gpbox_SpSet.ResumeLayout(false);
            this.gpbox_SpSet.PerformLayout();
            this.grpBox_ReceiveSet.ResumeLayout(false);
            this.grpBox_ReceiveSet.PerformLayout();
            this.grpBox_SendSet.ResumeLayout(false);
            this.grpBox_SendSet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OpenSp;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_ScanSp;
        private System.Windows.Forms.Button btn_CloseSp;
        private System.Windows.Forms.Button btn_SendClear;
        private System.Windows.Forms.Button btn_ReceiveClear;
        private System.Windows.Forms.TextBox tbox_Send;
        private System.Windows.Forms.TextBox tbox_Receive;
        private System.Windows.Forms.GroupBox gpbox_SpSet;
        private System.Windows.Forms.Label lbl_BaudRate;
        private System.Windows.Forms.ComboBox cbox_BaudRate;
        private System.Windows.Forms.ComboBox cbox_com;
        private System.Windows.Forms.GroupBox grpBox_ReceiveSet;
        private System.Windows.Forms.RadioButton rbtn_ReceiveASCII;
        private System.Windows.Forms.RadioButton rbtn_ReceiveHex;
        private System.Windows.Forms.GroupBox grpBox_SendSet;
        private System.Windows.Forms.RadioButton rbtn_SendASCII;
        private System.Windows.Forms.RadioButton rbtn_SendHex;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

