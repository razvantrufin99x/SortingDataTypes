using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SortingDataTypes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //loop lungime cuvant ....
            if (textBox1.Text.Substring(0, 1) != textBox2.Text.Substring(0, 1))
            {
                if (char.Parse(textBox1.Text.Substring(0, 1)) > char.Parse(textBox2.Text.Substring(0, 1)))
                {
                    string s = textBox1.Text;
                    textBox1.Text = textBox2.Text;
                    textBox2.Text = s;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox7.Text.Substring(0, 1) != textBox8.Text.Substring(0, 1))
            {
                if (char.Parse(textBox7.Text.Substring(0, 1)) > char.Parse(textBox8.Text.Substring(0, 1)))
                {
                    string s = textBox7.Text;
                    textBox7.Text = textBox8.Text;
                    textBox8.Text = s;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(int.Parse(textBox3.Text) > int.Parse(textBox4.Text) ){
                string s = textBox3.Text;
                textBox3.Text = textBox4.Text;
                textBox4.Text = s;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (float.Parse(textBox5.Text) > float.Parse(textBox6.Text))
            {
                string s = textBox5.Text;
                textBox5.Text = textBox6.Text;
                textBox6.Text = s;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (double.Parse(textBox9.Text) > double.Parse(textBox10.Text))
            {
                string s = textBox9.Text;
                textBox9.Text = textBox10.Text;
                textBox10.Text = s;
            }
        }
    }
}
