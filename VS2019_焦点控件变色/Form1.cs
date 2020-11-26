using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS2019_焦点控件变色
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbox_num_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.CornflowerBlue;//焦点激活控件，改变背景色
        }

        private void tbox_num_Leave(object sender, EventArgs e)//焦点离开控件，恢复背景色
        {
            ((TextBox)sender).BackColor = Color.White;
        }


        /// <summary>
        /// 焦点循环（回车[KeyValue=13]激活）
        /// </summary>
        /// <param name="controls">控件集合</param>
        /// <param name="m">当前控件</param>
        /// <param name="n">最大控件</param>
        private void circle_Controls(Control.ControlCollection controls, int m, int n)
        {
            int temp_n = 0;
            foreach (Control control in controls)
            {
                if (control.GetType().Name == "TextBox")
                {
                    if (m == n)
                        temp_n = 1;//循环到头
                    else
                        temp_n = m + 1;//循环进行
                    if (Convert.ToInt32(((TextBox)control).Tag.ToString()) == temp_n)//匹配下一控件
                        control.Focus();//焦点

                }
            }
        }

        private void tbox_num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)//按下回车，焦点进入下一控件
            {
                int m = Convert.ToInt32(((TextBox)sender).Tag);//当前控件
                circle_Controls(this.Controls, m, 6);//焦点进入下一控件
            }
        }
    }
}
