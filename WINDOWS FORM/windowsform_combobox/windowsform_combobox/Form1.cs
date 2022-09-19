﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsform_combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int bsal = Convert.ToInt32(textBox2.Text);
            string designation = comboBox1.Text;
            float bonus = 0.0f;
            float totalsal = 0.0f;

            label3.Text = "";
            label4.Text = "";
            switch (designation)
            {
                case "manager":
                    bonus = bsal * 0.55f;
                    break;
                case "clerk":
                    bonus = bsal * 0.45f;
                    break;
                case "peon":
                    bonus = bsal * 0.35f;
                    break;

            }
            totalsal = bsal + bonus;
            if (checkBox1.Checked)
                label3.Text = "bonus " + bonus;
            if (checkBox2.Checked)
            {
                label4.Text = "total sal" + totalsal;
            }

        }
    }
}
