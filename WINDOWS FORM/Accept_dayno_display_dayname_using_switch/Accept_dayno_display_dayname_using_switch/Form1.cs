using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accept_dayno_display_dayname_using_switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char ch = Convert.ToChar(textBox1.Text);
            string result;

            switch(ch)
            {
                case '1' :
                    result = "Monday";
                    break;

                case '2':
                    result = "tuesday";
                    break;

                case '3':
                    result = "wednesday";
                    break;

                case '4':
                    result = "thrusday";
                    break;

                case '5':
                    result = "friday";
                    break;

                case '6':
                    result = "saturday";
                    break;

                    default:
                    result = "invalid";
                    break;
             }
            label2.Text = "result :" + result;
        }
    }
}
