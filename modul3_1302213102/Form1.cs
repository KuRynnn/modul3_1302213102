﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_1302213102
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int num1 = 0, num2 = 0;
        private void buttonequal_Click(object sender, EventArgs e)
        {
            int jum;
            num2 = int.Parse(textBox1.Text);
            jum = num1 + num2;
            textBox1.Text = jum.ToString();
        }
        

        private void buttonplus_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(textBox1.Text);
            textBox1.Text = textBox1.Text + buttonplus.Text;
            textBox1.Text = "";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
