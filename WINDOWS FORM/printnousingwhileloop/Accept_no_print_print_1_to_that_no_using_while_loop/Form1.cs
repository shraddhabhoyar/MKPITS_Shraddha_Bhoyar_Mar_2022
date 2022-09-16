using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accept_no_print_print_1_to_that_no_using_while_loop
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
            int n = Convert.ToInt32(textBox1.Text);
            int i = 1;
            while(i<=n)
            {
                sb.Append(i+"\n");
                i++;
            }
            label2.Text=sb.ToString();
        }
    }
}
