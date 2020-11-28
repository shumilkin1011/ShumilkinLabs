using System;
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
    }
}
