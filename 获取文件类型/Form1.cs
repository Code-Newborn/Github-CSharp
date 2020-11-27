using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 获取文件类型
{
    public partial class FileView_form : Form
    {
        public FileView_form()
        {
            InitializeComponent();
        }

        private void Fileview_lstview_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            String[] str_Drop = (String[])e.Data.GetData(DataFormats.FileDrop, true);
            Data_list(Fileview_lstview, str_Drop[0]);
        }

        public void Data_list(ListView fileview_lstview, string v)
        {
            string filetype = "";
            if (v.LastIndexOf(".") != -1)
            {
                filetype = v.Substring(v.LastIndexOf(".") + 1);
            }
            ListViewItem listViewItem = new ListViewItem(v);
            listViewItem.SubItems.Add(filetype);
            fileview_lstview.Items.Add(listViewItem);
        }

        private void FileView_form_Shown(object sender, EventArgs e)
        {
            Fileview_lstview.GridLines = true;
            Fileview_lstview.View = View.Details;
            Fileview_lstview.FullRowSelect = true;
            Fileview_lstview.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            Fileview_lstview.Columns.Add("文件名", Fileview_lstview.Width - 120, HorizontalAlignment.Center);
            Fileview_lstview.Columns.Add("文件类型", 120, HorizontalAlignment.Center);
        }
    }
}
