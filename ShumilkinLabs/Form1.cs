﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShumilkinLabs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lab1 = new Lab1();
            lab1.FormClosed += lab1_Closed1;
            lab1.Show();
            this.Hide();
        }

        private void lab1_Closed1(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var lab2 = new Lab2();
            lab2.FormClosed += lab1_Closed1;
            lab2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var lab3 = new Lab3();
            lab3.FormClosed += lab1_Closed1;
            lab3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var lab4 = new Lab6();
            lab4.FormClosed += lab1_Closed1;
            lab4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var Lab5 = new Lab5();
            Lab5.FormClosed += lab1_Closed1;
            Lab5.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var Lab6 = new Lab6();
            Lab6.FormClosed += lab1_Closed1;
            Lab6.Show();
            this.Hide();
        }
        //A=2,75*(8+B)+(9+2,1)*C
    }
}
