using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creating_using_classes_wf_runtime_polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        account act = null;
        private void button1_Click(object sender, EventArgs e)
        {
            act.accno = Convert.ToInt32(textBox1.Text);
            string str = act.deposite(Convert.ToInt32(textBox2.Text));
            label4.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            act.accno = Convert.ToInt32(textBox1.Text);
            string str = act.withdrawl(Convert.ToInt32(textBox2.Text));
            label4.Text = str;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            act.accno = Convert.ToInt32(textBox1.Text);
            string str = act.withdrawl(Convert.ToInt32(textBox2.Text));
            label4.Text = "account no : " + act.accno + " : " + str;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "saving")
            {
                act = new saving();
            }
            else if (comboBox1.Text == "current")
            {
                act = new current();
            }

        }
    }
}
