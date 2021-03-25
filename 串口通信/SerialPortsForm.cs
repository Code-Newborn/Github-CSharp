using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace 串口通信
{
    public partial class SerialPortsForm : Form
    {
        public SerialPortsForm()
        {
            InitializeComponent();
            //防止跨线程操作异常
            //Control.CheckForIllegalCrossThreadCalls = false;            
            serialPort1.Encoding = Encoding.GetEncoding("GB2312");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshPortToCombox(serialPort1, cbox_com);
            btn_OpenSp.Enabled = true;
            btn_CloseSp.Enabled = false;

            rbtn_SendASCII.Checked = true;
            rbtn_ReceiveASCII.Checked = true;
        }

        private void btn_ScanSp_Click(object sender, EventArgs e)
        {
            RefreshPortToCombox(serialPort1, cbox_com);
        }

        private void RefreshPortToCombox(SerialPort serialPort, ComboBox comboBox)
        {
            if (!serialPort.IsOpen)
            {
                comboBox.Items.Clear();
                string[] str = SerialPort.GetPortNames();
                if (str == null)
                {
                    MessageBox.Show("本机没有串口！", "Error");
                    return;
                }
                foreach (string s in str)
                {
                    comboBox.Items.Add(s);
                    Console.WriteLine(s);
                }
            }
            else
            {
                MessageBox.Show("串口处于打开状态不能刷新串口列表", "Error");
            }
        }

        private void btn_OpenSp_Click(object sender, EventArgs e)
        {
            Int32 iBaudRate = Convert.ToInt32(cbox_BaudRate.SelectedItem.ToString());
            serialPort1.PortName = cbox_com.SelectedItem.ToString();
            serialPort1.BaudRate = iBaudRate;

            try
            {    
                serialPort1.Open();
                btn_OpenSp.Enabled = false;
                btn_CloseSp.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("串口打开失败！" + ex, "Error");
            }

            cbox_com.Enabled = false;
            cbox_BaudRate.Enabled = false;
        }

        private void btn_CloseSp_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                btn_OpenSp.Enabled = true;
                btn_CloseSp.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("串口关闭失败！" + ex, "Error");
            }

            cbox_com.Enabled = true;
            cbox_BaudRate.Enabled = true;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btn_ReceiveClear_Click(object sender, EventArgs e)
        {
            tbox_Receive.Clear();
        }

        private void btn_SendClear_Click(object sender, EventArgs e)
        {
            tbox_Send.Clear();
        }


        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (rbtn_ReceiveASCII.Checked)
                {
                    string content = serialPort1.ReadExisting();
                    this.BeginInvoke(new Action(() =>
                   {
                       this.tbox_Receive.AppendText(content);
                   }));//采用BeginInvoke异步执行托替代，不可用Invoke同步执行委托，否则连续通信会阻塞。
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据接收错误" + ex, "Error");

            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (tbox_Send.Text != null)
                {
                    if (rbtn_SendASCII.Checked == true)
                    {
                        try
                        {
                            serialPort1.Write(tbox_Send.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("串口发送失败！" + ex, "Error");
                            serialPort1.Close();
                            btn_OpenSp.Enabled = true;
                            btn_CloseSp.Enabled = false;
                        }
                    }
                    else
                    {

                    }

                }
            }
        }
    }
}