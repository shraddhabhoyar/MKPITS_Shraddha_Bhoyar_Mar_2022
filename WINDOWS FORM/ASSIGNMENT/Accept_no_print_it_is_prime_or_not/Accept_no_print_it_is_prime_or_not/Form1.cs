using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accept_no_print_it_is_prime_or_not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0; 
           int num = Convert.ToInt32(textBox1.Text);
            
            
            for (int i = 1; i <= num; i++)

            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                label2.Text = "it is a prime number";
             
            }
            else
            {
                label2.Text = "it is not a prime number";
            }
        }
    }
}
