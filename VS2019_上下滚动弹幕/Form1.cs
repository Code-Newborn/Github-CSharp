using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS2019_上下滚动弹幕
{
    public partial class 滚动弹幕窗口 : Form
    {
        public 滚动弹幕窗口()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            滚动弹幕区.Top = this.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(滚动弹幕区.Top<-滚动弹幕区.Height)
            {
                滚动弹幕区.Top = this.Height;
            }
            滚动弹幕区.Top -= 10;            
        }
    }
}
