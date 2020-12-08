using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS2019_获取文件类型
{
    public partial class FileView_form : Form
    {
        public FileView_form()
        {
            InitializeComponent();
        }

        private void Fileview_lstview_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;//拖放操作：复制
            String[] str_Drop = (String[])e.Data.GetData(DataFormats.FileDrop, true);//大写String，获取：检索与指定的数据格式关联的数据格式。
            Data_list(Fileview_lstview, str_Drop[0]);//添加数据项至listview
        }

        public void Data_list(ListView fileview_lstview, string v)
        {
            string filetype = "";
            if (v.LastIndexOf(".") != -1)//能够检索到"."则：
            {
                filetype = v.Substring(v.LastIndexOf(".") + 1);//获取文件后缀名
            }
            ListViewItem listViewItem = new ListViewItem(v);//新建listview数据项（行），添加进listview
            listViewItem.SubItems.Add(filetype);
            fileview_lstview.Items.Add(listViewItem);
        }

        private void FileView_form_Shown(object sender, EventArgs e)//程序初次显现样式
        {
            //设置listview显示样式
            Fileview_lstview.GridLines = true;
            Fileview_lstview.View = View.Details;
            Fileview_lstview.FullRowSelect = true;
            Fileview_lstview.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            //添加列
            Fileview_lstview.Columns.Add("文件名", Fileview_lstview.Width - 120, HorizontalAlignment.Center);
            Fileview_lstview.Columns.Add("文件类型", 120, HorizontalAlignment.Center);
        }
    }
}
