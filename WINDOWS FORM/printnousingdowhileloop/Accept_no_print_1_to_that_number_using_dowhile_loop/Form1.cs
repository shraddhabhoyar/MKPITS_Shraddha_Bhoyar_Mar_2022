﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accept_no_print_1_to_that_number_using_dowhile_loop
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
            do
            {
                sb.Append(i + "\n");
                i++;
            } while (i <= n);
            label2.Text=sb.ToString();
        }
    }
}
