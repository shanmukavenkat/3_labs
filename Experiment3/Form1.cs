using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a;
        int b;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            sum = a + b;
            textBox3.Text = Convert.ToString(sum);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sub;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            sub = a - b;
            textBox3.Text = Convert.ToString(sub);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mul;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            mul = a * b;
            textBox3.Text = Convert.ToString(mul);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double div;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            div = a / b;
            textBox3.Text = Convert.ToString(div);
        }
    }
}
