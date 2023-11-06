using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    
    public partial class Form1 : Form
        
    {
        string m1,m3,m5,m7;
        int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void but1_Click(object sender, EventArgs e)
        {
            x.Text += "1";
        }

        private void but2_Click(object sender, EventArgs e)
        {
            x.Text += "2";
        }

        private void but3_Click(object sender, EventArgs e)
        {
            x.Text = "3";
        }

        private void but4_Click(object sender, EventArgs e)
        {
            x.Text+="4";    
        }

        private void but5_Click(object sender, EventArgs e)
        {
            x.Text="5";


        }

        private void but6_Click(object sender, EventArgs e)
        {
            x.Text+="6";    
        }

        private void but7_Click(object sender, EventArgs e)
        {
            x.Text += "7";
        }

        private void but8_Click(object sender, EventArgs e)
        {
            x.Text += "8";
        }

        private void but_sub_Click(object sender, EventArgs e)
        {
            m3 = x.Text;
            x.Clear();
            count = 2;
        }

        private void but_mul_Click(object sender, EventArgs e)
        {
            m5 = x.Text;
            x.Clear();
            count = 3;
        }

        private void but_div_Click(object sender, EventArgs e)
        {
            m7 = x.Text;
            x.Clear();
            count = 4;
        }

        private void but_equal_Click(object sender, EventArgs e)
        {
            if(count==1)
            {
                string m2 = x.Text;
                int c=int.Parse(m2) + int.Parse(m1);
                x.Text=c.ToString();
            }
            else if(count==2)
            {
                string m4 = x.Text;
                int c = int.Parse(m3) - int.Parse(m4);
                x.Text = c.ToString();
            }
            else if(count==3)
            {
                string m6 = x.Text;
                int c = int.Parse(m5) * int.Parse(m6);
                x.Text = c.ToString();
            }
            else
            {
                string m8 = x.Text;
                int c = int.Parse(m7) / int.Parse(m8);
                x.Text = c.ToString();
            }
        }

        private void but_clear_Click(object sender, EventArgs e)
        {
            x.Clear();
        }

        private void but9_Click(object sender, EventArgs e)
        {
            x.Text += "9";

        }

        private void but0_Click(object sender, EventArgs e)
        {
            x.Text += "0";
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            m1=x.Text;
            x.Clear();
            count= 1;

        }
    }
}
