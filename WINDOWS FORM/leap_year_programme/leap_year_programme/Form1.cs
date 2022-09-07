using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leap_year_programme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year;
            year = Convert.ToInt32(textBox1.Text);
            if(year%4==0)
            {
                label2.Text = year + "is leap year";
            }
            else
            {
                label2.Text = year + "is not a leap year";
            }
        }
    }
}
