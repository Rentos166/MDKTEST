using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_24
{
    public partial class Form1 : Form
    {
        double x;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
            {
                x = Convert.ToDouble(textBox1.Text) * 0.45359293319936;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                x = Convert.ToDouble(textBox1.Text) / 16.38;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                x = Convert.ToDouble(textBox1.Text) * 35.27;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                x = Convert.ToDouble(textBox1.Text) * 294.117647058824;
            }
            else 
            {
                x = Convert.ToDouble(textBox1.Text) * 1000;
            }
            textBox2.Text = Convert.ToString(x);
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.ForeColor = Color.Red;
            }
            else
            {
                textBox2.ForeColor = Color.Black;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Font = new Font("Roboto", (float)8);
            }
            else
            {
                textBox2.Font = (Font)this.textBox2.Tag;
            }
        }
    }
}
