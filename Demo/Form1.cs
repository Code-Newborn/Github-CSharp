using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = lTrackBar1.L_Value.ToString();
            trackBar1.Value = lTrackBar1.L_Value;
        }

        private void lTrackBar1_LValueChanged(object sender, CTracker.LEventArgs e)
        {
            label1.Text = lTrackBar1.L_Value.ToString();
            trackBar1.Value = lTrackBar1.L_Value;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            lTrackBar1.L_Value = trackBar1.Value;
        }
    }
}
