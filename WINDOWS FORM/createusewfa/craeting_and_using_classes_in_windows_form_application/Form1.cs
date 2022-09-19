using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace craeting_and_using_classes_in_windows_form_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            
            c.rno = Convert.ToInt32(textBox1.Text);
            c.name = textBox2.Text;
            c.email = textBox3.Text;
            c.mob= Convert.ToInt64(textBox4.Text);
            StringBuilder sb = new StringBuilder();
            sb.Append("rno" + c.rno + "\n");
            sb.Append("name" + c.name + "\n");
            sb.Append("email" + c.email + "\n");
            sb.Append("mob" + c.mob + "\n");

            label5.Text=sb.ToString();
        }
        
    }
}
