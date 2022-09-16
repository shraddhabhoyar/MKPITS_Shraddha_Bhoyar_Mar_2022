using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accepr_no_print_table_of_that_no_using_for_loop
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

            for(int i=1;i<=10;i++)
            {
                result = n * i;
                sb.Append(n + "*" + i + "=" + result + "\n");
                
            }
            label2.Text=sb.ToString();
        }
    }
}
