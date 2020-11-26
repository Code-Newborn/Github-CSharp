using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS2019_ExchangeSkin窗体换肤
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 静态肤色索引变量
        public static int var_bar = 1;
        #endregion



        private void barter(int n)
        {
            switch (n)
            {
                case 0:
                    {
                        panel_Titile.BackColor = colorTheme1.color1;
                        panel_WorkClient.BackColor = colorTheme1.color2;

                        pic_Close.BackColor = colorTheme1.color2;
                        pic_Min.BackColor = colorTheme1.color2;
                        pic_Size.BackColor = colorTheme1.color2;
                        var_bar = 1;
                        break;
                    }
                case 1:
                    {
                        panel_Titile.BackColor = colorTheme2.color1;
                        panel_WorkClient.BackColor = colorTheme2.color2;

                        pic_Close.BackColor = colorTheme2.color2;
                        pic_Min.BackColor = colorTheme2.color2;
                        pic_Size.BackColor = colorTheme2.color2;
                        var_bar = 1;
                        break;
                    }
                case 2:
                    {
                        panel_Titile.BackColor = colorTheme3.color1;
                        panel_WorkClient.BackColor = colorTheme3.color2;

                        pic_Close.BackColor = colorTheme3.color2;
                        pic_Min.BackColor = colorTheme3.color2;
                        pic_Size.BackColor = colorTheme3.color2;
                        var_bar = 1;
                        break;
                    }
            }
            barterShow(n);
        }

        private void barterShow(int n)
        {
            toolStripMenuItem1.Checked = false;
            toolStripMenuItem2.Checked = false;
            toolStripMenuItem3.Checked = false;
            switch (n)
            {
                case 0: toolStripMenuItem1.Checked = true; break;
                case 1: toolStripMenuItem2.Checked = true; break;
                case 2: toolStripMenuItem3.Checked = true; break;
            }
        }


        struct ColorTheme//肤色主题
        {
            public Color color1;
            public Color color2;
        }
        ColorTheme colorTheme1;//蓝色主题
        ColorTheme colorTheme2;//绿色主题
        ColorTheme colorTheme3;//红色主题

        private void Form1_Load(object sender, EventArgs e)
        {

            colorTheme1.color1 = Color.FromArgb(87, 109, 147);
            colorTheme1.color2 = Color.FromArgb(40, 79, 149);

            colorTheme2.color1 = Color.FromArgb(138, 206, 87);
            colorTheme2.color2 = Color.FromArgb(51, 125, 86);

            colorTheme3.color1 = Color.FromArgb(255, 147, 147);
            colorTheme3.color2 = Color.FromArgb(194, 69, 69);

            barter(0);
        }

        #region 窗体右上最小、最大、关闭按钮功能
        private void pic_Min_Click(object sender, EventArgs e)
        {
            ClickOperation(this, Convert.ToInt16(((PictureBox)sender).Tag.ToString()));
        }


        public void ClickOperation(Form Frm_Tem, int n)
        {
            switch (n)
            {
                case 0:
                    Frm_Tem.WindowState = FormWindowState.Minimized;
                    break;
                case 1:
                    {
                        if (Frm_Tem.WindowState == FormWindowState.Maximized)
                            Frm_Tem.WindowState = FormWindowState.Normal;
                        else
                            Frm_Tem.WindowState = FormWindowState.Maximized;
                        break;
                    }
                case 2:
                    Frm_Tem.Close();
                    break;
            }
        }
        #endregion

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            barter(Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
        }

        Point CPoint;
        private void panel_Titile_MouseDown(object sender, MouseEventArgs e)
        {
            CPoint = new Point(-e.X, -e.Y);
        }

        private void panel_Titile_MouseMove(object sender, MouseEventArgs e)
        {
            FrmMove(this, e);
        }

        private void FrmMove(Form Frm, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosition = Control.MousePosition;
                myPosition.Offset(CPoint.X, CPoint.Y);
                Frm.DesktopLocation = myPosition;
            }
        }


        private void pic_Min_MouseEnter(object sender, EventArgs e)
        {
            ColorReinforce(sender, Convert.ToInt16((((PictureBox)sender).Tag).ToString()), 0);
        }

        private void pic_Min_MouseLeave(object sender, EventArgs e)
        {
            ColorReinforce(sender, Convert.ToInt16((((PictureBox)sender).Tag).ToString()), 1);
        }

        public static PictureBox Tem_PicB = new PictureBox();


        private void ColorReinforce(object sender, int tag, int ns)
        {
            Tem_PicB = (PictureBox)sender;
            switch (tag)
            {
                case 0:
                    {
                        if (ns == 0)
                            Tem_PicB.BorderStyle = BorderStyle.FixedSingle;
                        if (ns == 1)
                            Tem_PicB.BorderStyle = BorderStyle.None;
                        break;
                    }
                case 1:
                    {
                        if (ns == 0)
                            Tem_PicB.BorderStyle = BorderStyle.FixedSingle;
                        if (ns == 1)
                            Tem_PicB.BorderStyle = BorderStyle.None;
                        break;
                    }
                case 2:
                    {
                        if (ns == 0)
                            Tem_PicB.BorderStyle = BorderStyle.FixedSingle;
                        if (ns == 1)
                            Tem_PicB.BorderStyle = BorderStyle.None;
                        break;
                    }
            }

        }


    }
}

