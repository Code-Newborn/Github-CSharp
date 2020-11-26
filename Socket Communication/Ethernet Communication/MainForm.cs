using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ethernet_Communication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Socket listenSocket;
        private Dictionary<string, Socket> onlineList = new Dictionary<string, Socket>();
        Encoding encoding = Encoding.Default;
        private string currentTime
        {
            get { return DateTime.Now.ToString("HH:ff:ss"); }
        }


        private void button_Start_Click(object sender, EventArgs e)
        {
            listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(this.textBox_IP.Text.Trim()), int.Parse(this.textBox_COM.Text.Trim()));

            try
            {
                listenSocket.Bind(endPoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show("服务器开启失败，" + ex.Message, "开启服务器");
                return;
            }
            listenSocket.Listen(10);

            ShowMessage("服务器开启成功");
            Task.Run(new Action(() => ListenConnection()));
            this.button_Start.Enabled = false;
        }

        private void ListenConnection()
        {
            while (true)
            {
                Socket clientSocket = listenSocket.Accept();

                string ip = clientSocket.RemoteEndPoint.ToString();

                AddOnline(ip, true);

                onlineList.Add(ip, clientSocket);

                ShowMessage(ip + "已上线");

                Task.Run(new Action(() => RecieveMssg(clientSocket)));
            }
        }

        private void RecieveMssg(Socket client)
        {
            while (true)
            {
                byte[] buffer = new byte[1024 * 1024 * 2];
                int length = -1;

                try
                {
                    length = client.Receive(buffer);
                }
                catch (Exception)
                {
                    string ip = client.RemoteEndPoint.ToString();
                    AddOnline(ip, false);
                    onlineList.Remove(ip);
                    break;
                }
                if (length == 0)
                {
                    string ip = client.RemoteEndPoint.ToString();
                    AddOnline(ip, false);
                    onlineList.Remove(ip);
                    break;
                }

                if (length > 0)
                {
                    string info = encoding.GetString(buffer, 0, length);
                    ShowMessage(currentTime + info);
                }
            }
        }

        private void AddOnline(string client, bool online)
        {
            Invoke(new Action(() =>
            {
                if (online)
                {
                    this.listBox_DeviceOnline.Items.Add(client);
                }
                else
                {
                    this.listBox_DeviceOnline.Items.Remove(client);
                }
            }
            ));
        }

        private void ShowMessage(string info)
        {
            Invoke(new Action(() =>
            {
                this.textBox_MessageReceive.AppendText(currentTime + Environment.NewLine + info + Environment.NewLine);
            }));
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (this.listBox_DeviceOnline.SelectedItem != null)
            {
                string item = this.listBox_DeviceOnline.SelectedItem.ToString();
                if (onlineList.ContainsKey(item))
                {
                    onlineList[item].Send(encoding.GetBytes(this.textBox_MessageSend.Text.Trim()));
                }
            }
            else
            {
                MessageBox.Show("消息发送失败，请选择发送对象", "发送消息");
            }
        }

        private void button_SendInGroups_Click(object sender, EventArgs e)
        {

            foreach (string item in listBox_DeviceOnline.Items)
            {
                if (onlineList.ContainsKey(item))
                {
                    onlineList[item].Send(encoding.GetBytes(this.textBox_MessageSend.Text.Trim()));
                }
            }

        }
    }
}
