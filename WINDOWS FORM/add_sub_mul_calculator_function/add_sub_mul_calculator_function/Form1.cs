﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace add_sub_mul_calculator_function
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        int prevnumber = 0;
        char op;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            prevnumber = Convert.ToInt32(textBox1.Text);
            op = '+';
            textBox1.Text = "+";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            prevnumber = Convert.ToInt32(textBox1.Text);
            op = '-';
            textBox1.Text = "-";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int result = 0;
            switch (op)
            {
                case '+':

                    result = Convert.ToInt32(textBox1.Text) + prevnumber;
                    break;
                case '-':
                    result = prevnumber - Convert.ToInt32(textBox1.Text);
                    break;
            }
            textBox1.Text = result.ToString();

        }
    }
}


        