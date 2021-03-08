using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShumilkinLabs
{
    public partial class Lab6_2 : Form
    {
        public Lab6_2(string str)
        {
            InitializeComponent();
            textBox1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter writer;
            saveFileDialog1.Title = "Сохранить результаты";
            saveFileDialog1.FileName = "LR_анализ_"+ DateTime.Now.ToShortDateString() + ".txt";
            saveFileDialog1.DefaultExt = "LRGram";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 0;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                writer = new StreamWriter(saveFileDialog1.FileName);
                writer.Write(textBox1.Text);
                writer.Close();               
                    
            }
        }
    }
}
