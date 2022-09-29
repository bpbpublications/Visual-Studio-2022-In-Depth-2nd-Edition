using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter_4_Ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //int i = 23;
            //Console.WriteLine(i.ToString());

            ////UNDONE: Complete this procedure
            //int I = 22;
            ////TODO: Decrement I value
            //i++;
            ////HACK: Display value in MessageBox
            //Console.WriteLine(i.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "OJ" && textBox2.Text == "BpB")
            {
                MessageBox.Show("Welcome Back!");
            }
            else
            {
                MessageBox.Show("Try Again.");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();

        }
    }
}
