﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace create_2d_array_store_album_singer_names
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] album = new string[1, 2];
        StringBuilder sb=new StringBuilder();
        private void button1_Click(object sender, EventArgs e)
        {
            album[0, 0] = textBox1.Text;
            album[0, 1] = textBox2.Text;
            sb.Append("album name " + album[0, 0] + ",  singer name" + album[0, 1]);
            label3.Text= sb.ToString();

        }
    }
}
