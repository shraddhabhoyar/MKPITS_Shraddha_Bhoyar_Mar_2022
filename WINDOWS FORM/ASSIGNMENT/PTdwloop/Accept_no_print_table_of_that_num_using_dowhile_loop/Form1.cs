using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accept_no_print_table_of_that_num_using_dowhile_loop
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
            int n=Convert.ToInt32(textBox1.Text);
            int result = 1;
            int i = 1;
            do
            {
                result = n * i;
                
                sb.Append(n + "*" + i + "=" + result + "\n");
                i++;
            }  while (i <= 10);
            label2.Text = sb.ToString();
        }
    }
}
