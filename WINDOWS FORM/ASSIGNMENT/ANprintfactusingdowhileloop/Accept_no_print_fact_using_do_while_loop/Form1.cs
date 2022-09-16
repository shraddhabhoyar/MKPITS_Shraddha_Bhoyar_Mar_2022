using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accept_no_print_fact_using_do_while_loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int fact = 1;
            int i = 1;
             do
            {
                fact = fact * i;
                i++;
            } while (i <= n);

            label2.Text = "fact:" + fact;
        }
             
    }
}
