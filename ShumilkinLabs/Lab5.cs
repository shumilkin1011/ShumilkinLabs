using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MultiParse;

namespace ShumilkinLabs
{
    public partial class Lab5 : Form
    {
        private string expression = "";
        private int[,] transTable = new int[,]
            { {5,2,2,5,5},
              {5,5,2,5,5},
              {2,2,2,6,3},
              {2,2,2,3,4}
            };

        private Dictionary<string, int> operIndxs1;
        private Dictionary<string, int> operIndxs2;
        private Stack<string> operands;
        private Stack<string> operations;
        private int indx = 0;

        public Lab5()
        {
            InitializeComponent();
            operands = new Stack<string>();
            operations = new Stack<string>();
            operIndxs1 = new Dictionary<string, int>();
            operIndxs2 = new Dictionary<string, int>();
            operIndxs1.Add("+", 0);
            operIndxs1.Add("*", 1);
            operIndxs1.Add("(", 2);
            operIndxs1.Add("$", 3);

            operIndxs2.Add("+", 0);
            operIndxs2.Add("*", 1);
            operIndxs2.Add("(", 2);
            operIndxs2.Add(")", 3);
            operIndxs2.Add("$", 4);
        }

        private void Compute_Click(object sender, EventArgs e)
        {
            indx = 0;
            operations.Clear();
            operands.Clear();

            expression = textExpr.Text + "$";
            expression.Replace('.', ',');
            int action;
            operations.Push("$");

            do
            {
                //2*(5+6)+(2+4)*7
                if (char.IsDigit(expression[indx])) {
                    operands.Push(readNumber(indx));
                    indx = indx+operands.Peek().Length;
                }
                action = transTable[operIndxs1[operations.Peek()], operIndxs2[expression[indx].ToString()] ];
                makeAction(action);


               } while (action != 4);


            textAnsw.Text = operands.Pop();
        }

        private void makeAction(int action)
        {
            switch(action)
            {
                case 2:
                    operations.Push(expression[indx++].ToString());
                    break;
                case 3:
                    throw new Exception("Wrong operation!");
                    break;
                case 4:
                    break;
                case 5:
                    computeOperation();
                    break;
                case 6:
                    operations.Pop();
                    indx++;
                    break;
            }
        }

        private void computeOperation()
        {
            int a = int.Parse(operands.Pop());
            int b = int.Parse(operands.Pop());

            switch(operations.Pop())
            {
                case "+":
                    operands.Push((a + b).ToString());
                    break;
                case "*":
                    operands.Push((a * b).ToString());
                    break;
            }
        }
        private string readNumber(int indx)
        {
            string res = "";
            while(char.IsDigit(expression[indx]) || expression[indx] == ',')
            {
                res += expression[indx];
                indx++;
            }
            return res;
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
