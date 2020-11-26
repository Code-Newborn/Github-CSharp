using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS2019_QQFrm
{
    public partial class 窗体停靠_自动隐藏 : Form
    {
        public 窗体停靠_自动隐藏()
        {
            InitializeComponent();
        }

        #region API声明

        //获取当前鼠标下可视化控件的句柄
        [DllImport("user32.dll")]
        public static extern int WindowFromPoint(int xPoint, int yPoint);

        //获取指定句柄的父级句柄
        [DllImport("user32.dll")]
        public static extern IntPtr GetParent(IntPtr hWnd);

        //获取屏幕的大小
        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(int mval);

        #endregion

        #region 公共变量
        /// <summary>
        /// 获取控件及窗体的句柄
        /// </summary>
        IntPtr temp_Handle;
        /// <summary>
        /// 控件中鼠标的相对坐标
        /// </summary>
        Point CPoint;
        /// <summary>
        /// 
        /// </summary>
        static int Temp_place = 0;
        /// <summary>
        /// 
        /// </summary>
        int FrmHeight = 0;

        #endregion

        /// <summary>
        /// Get Present InPtr of the current cursor
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public IntPtr FormNameAt(int x, int y)
        {
            IntPtr Temp_hWhd;
            temp_Handle = (IntPtr)(WindowFromPoint(x, y));
            Temp_hWhd = temp_Handle;
            while (Temp_hWhd != (IntPtr)(0))
            {
                temp_Handle = Temp_hWhd;//同步记录当前句柄
                Temp_hWhd = GetParent(Temp_hWhd);//获取父级句柄，最后Temp_hWhd = IntPtr(0);
            }
            return temp_Handle;//返回最底层的父级句柄
        }
        
        public void FrmMove(Form Frm, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosition = Control.MousePosition;
                myPosition.Offset(CPoint.X, CPoint.Y);
                Frm.DesktopLocation = myPosition;
                Temp_place = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmHeight = this.Height;//获取窗体初始大小
            this.TopMost = true;//将窗体置于最上层
        }

        private void panel_Title_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;//关闭窗体位置检测
            CPoint = new Point(-e.X, -e.Y);//获取鼠标在窗体上按下的相对位置
        }

        private void panel_Title_MouseMove(object sender, MouseEventArgs e)
        {
            FrmMove(this, e);//鼠标在标题栏上移动时调用“窗体移动方法”
        }

        private void panel_Title_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;//鼠标抬起时开启窗体位置检测timer1
        }

        /// <summary>
        /// 用定时器timer1检测窗体位置以及鼠标是否处在窗体内（常开启，一直检测）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Top < 3 && Temp_place == 0)//窗体在屏幕顶端将panel_Title.Tag置1
            {
                if (this.Handle == FormNameAt(Cursor.Position.X, Cursor.Position.Y))//鼠标在窗体内，关闭窗体“窗体隐藏功能”timer2
                {
                    panel_Title.Tag = 1;
                    timer2.Enabled = false;
                    this.Top = 0;//将窗体置顶
                }
                else//鼠标不在窗体内，开启“窗体隐藏功能”timer2
                {
                    panel_Title.Tag = 1;
                    timer2.Enabled = true;
                }
            }
            else//窗体在屏幕左侧或右侧
            {
                if (this.Left < 3 || this.Right > GetSystemMetrics(0) - 3)
                {
                    if (this.Left < 3)//窗体在屏幕左侧，将panel_Title.Tag置2
                    {
                        if (this.Handle == FormNameAt(Cursor.Position.X, Cursor.Position.Y))//鼠标在窗体内，关闭“窗体隐藏功能”timer2
                        {
                            panel_Title.Tag = 2;
                            timer2.Enabled = false;
                            this.Left = 0;//将窗体置左
                            Temp_place = 1;//将窗体位置标志置1（用于“窗体隐藏功能”timer2的实现）
                        }
                        else//鼠标不在窗体内，开始“窗体隐藏功能”timer2
                        {
                            panel_Title.Tag = 2;
                            timer2.Enabled = true;
                        }
                    }
                    if (this.Right > GetSystemMetrics(0) - 3)//窗体在屏幕右侧，将panel_Title.Tag置3
                    {
                        if (this.Handle == FormNameAt(Cursor.Position.X, Cursor.Position.Y))//鼠标在窗体内，关闭“窗体隐藏功能”timer2
                        {
                            panel_Title.Tag = 3;
                            timer2.Enabled = false;
                            this.Left = GetSystemMetrics(0) - this.Width;//窗体置右
                            Temp_place = 2;//将窗体位置标志置2（用于“窗体隐藏功能”timer2的实现）
                        }
                        else//鼠标不在窗体内，开启“窗体隐藏功能”timer2
                        {
                            panel_Title.Tag = 3;
                            timer2.Enabled = true;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 定时器timer2实现窗体隐藏功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {            
            switch(Convert.ToInt16(panel_Title.Tag.ToString()))//根据窗体位置，对窗体进行相应位置的隐藏
            {
                case 1:
                    {
                        if (this.Top < 5)
                            this.Top = -(this.Height - 2);
                        break;
                    }
                case 2:
                    {
                        if (this.Left < 5)
                            this.Left = -(this.Width - 2);
                        break;
                    }
                case 3:
                    {
                        if (this.Right > GetSystemMetrics(0) - 2)
                            this.Left = GetSystemMetrics(0) - 2;
                        break;
                    }
            }
        }

        /// <summary>
        /// 窗体关闭按钮（PicBox）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
