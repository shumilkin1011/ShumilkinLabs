using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MultiParse;

namespace ShumilkinLabs
{
    public partial class Lab3 : Form
    {
        private string expression = "";

        public Lab3()
        {
            InitializeComponent();
        }

        private void Compute_Click(object sender, EventArgs e)
        {
            expression = textExpr.Text;
            textAnsw.Text = (new Expression()).Evaluate(expression).ToString();
        }

        // сохранение выражения
        private void menuItemSave_Click(object sender, EventArgs e)
        {
            StreamWriter writer;
            saveFileDialog1.Title = "Сохранить выражение";
            saveFileDialog1.FileName = DateTime.Now.ToFileTimeUtc() + ".EXPR";
            saveFileDialog1.DefaultExt = "EXPR";
            saveFileDialog1.Filter = "expression (*.EXPR)|*.EXPR|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 0;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                writer = new StreamWriter(saveFileDialog1.FileName);
                writer.WriteLine(textExpr.Text);
                writer.Close();
            }

        }

        //загрузка сохраненного выражения
        private void menuItemLoad_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            openFileDialog1.Title = "Выбрать сохраненный файл";
            openFileDialog1.FileName = "";
            openFileDialog1.DefaultExt = "EXPR";
            openFileDialog1.Filter = "expression (*.EXPR)|*.EXPR|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                reader = new StreamReader(openFileDialog1.FileName);
                textExpr.Text = reader.ReadLine();
                reader.Close();
            }

        }

        //очистка полей
        private void menuClear_Click(object sender, EventArgs e)
        {
            textExpr.Text = "";
            textAnsw.Text = "";
        }

    }
}
