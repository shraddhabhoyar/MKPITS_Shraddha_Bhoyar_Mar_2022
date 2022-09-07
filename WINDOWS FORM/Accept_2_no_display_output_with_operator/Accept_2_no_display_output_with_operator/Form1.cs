using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accept_2_no_display_output_with_operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2= Convert.ToInt32(textBox2.Text);
           char op = Convert.ToChar (textBox3.Text);
            int result = 0;
            
            switch(op)
            {
                case '+':
                    result = num1 + num2;
                    break;

                    case '-':
                    result = num1 - num2;
                    break;

                   case '*':
                    result = num1 * num2;
                    break;

                    default:
                    result = num1 / num2;
                    break;
             }
            label4.Text = "Output :" + result;

        }
    }
}
