using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS2019_点击上下隐藏栏实现
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static Panel Var_Panel = new Panel();//类似指针，获取目标对象的引用
        private static PictureBox Var_Picbox = new PictureBox();
        private static int Var_i = 0;
        private Font Var_Font = new Font("宋体", 12);

        private void picbox_1_Click(object sender, EventArgs e)
        {
            Var_i = Convert.ToInt16(((PictureBox)sender).Tag.ToString());//采用控件的Tag来控制控件的行为
            switch (Var_i)
            {
                case 1:
                    {
                        Var_Panel = panel_menu1;
                        Var_Picbox = picbox_1;
                        break;
                    }
                case 2:
                    {
                        Var_Panel = panel_menu2;
                        Var_Picbox = picbox_2;
                        break;
                    }
                case 3:
                    {
                        Var_Panel = panel_menu3;
                        Var_Picbox = picbox_3;
                        break;
                    }
            }
            if (Convert.ToInt16(Var_Panel.Tag.ToString()) == 0 || Convert.ToInt16(Var_Panel.Tag.ToString()) == 2)//隐藏
            {
                Var_Panel.Tag = 1;
                Var_Picbox.BackgroundImage = null;
                Var_Picbox.BackgroundImageLayout = ImageLayout.Zoom;
                Var_Picbox.BackgroundImage = Properties.Resources.下__拉;
                Var_Panel.Visible = false;
            }
            else//展现
            {
                if (Convert.ToInt16(Var_Panel.Tag.ToString()) == 1)
                {
                    Var_Panel.Tag = 2;
                    Var_Picbox.BackgroundImage = null;
                    Var_Picbox.BackgroundImageLayout = ImageLayout.Zoom;
                    Var_Picbox.BackgroundImage = Properties.Resources.上__拉;
                    Var_Panel.Visible = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_MouseEnter(object sender, EventArgs e)//鼠标指向label时变灰
        {
            ((Label)sender).ForeColor = Color.Gray;
            ((Label)sender).Font = new Font(Var_Font, Var_Font.Style | FontStyle.Underline);
        }

        private void label1_MouseLeave(object sender, EventArgs e)//鼠标离开label时恢复
        {
            ((Label)sender).ForeColor = Color.Black;
            ((Label)sender).Font = new Font(Var_Font, Var_Font.Style);
        }
    }
}
