using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accept_3_sub_marks_display_tot_per_gr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int total = a + b + c;
            label4.Text = "total:" + total;
            float per = (total / 300.0f) * 100.0f;
            label5.Text = "percentage :" + per;
            if (per >= 75)
            {
                label6.Text = "grade : Distinction";
            }
            else if (per >= 60 && per < 75)
            {
                label6.Text = "grade : first class";
            }
            else
            {
                label6.Text = "grade : fail";
            }

        }
    }
}
