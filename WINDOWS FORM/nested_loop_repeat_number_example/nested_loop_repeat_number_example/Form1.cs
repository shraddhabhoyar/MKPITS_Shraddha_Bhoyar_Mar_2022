using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nested_loop_repeat_number_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int i, j;
            for (i = 1; i <= 7; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    sb.Append(i + "  ");
                }
                sb.Append("\n");
            }
            label1.Text = sb.ToString();

        }
    }
}
