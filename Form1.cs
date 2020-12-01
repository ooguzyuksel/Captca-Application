using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Text = "-";
            button3.BackColor = Color.White;

            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g", "h" };
            string[] sembol2 = { "-", "+", "*", "/", "!", "#" };
            string[] sembol3 = { "Z", "Y", "X", "V", "S", "P", "H" };

            Random rnd = new Random();

            int s1, s2, s3, s4, s5, s6;

            s1 = rnd.Next(0, sembol1.Length);
            s2 = rnd.Next(0, sembol2.Length);
            s3 = rnd.Next(0, sembol3.Length);
            s4 = rnd.Next(1, 10);
            s5 = rnd.Next(0, sembol1.Length);
            s6 = rnd.Next(0, sembol2.Length);

            label1.Text = sembol1[s1] + sembol2[s2] + sembol3[s3] + s4 + sembol1[s5] + sembol2[s6];

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text == textBox1.Text)
            {
                button3.BackColor = Color.Green;
                button3.Text = "DOĞRU";
            }
            else
            {
                button3.BackColor = Color.Red;
                button3.Text = "YANLIŞ";
            }

        }
    }
}
