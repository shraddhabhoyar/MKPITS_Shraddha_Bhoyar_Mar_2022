using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accept_no_print_factorial_using_for_loop
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
            int i, fact = 1;

            for (i=1;i<=n;i++)
            {
                fact = fact * i;
            }
            label2.Text = "fact:" + fact;
        }
    }
}
