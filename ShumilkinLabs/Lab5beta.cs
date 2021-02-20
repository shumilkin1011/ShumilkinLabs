using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MultiParse;

namespace ShumilkinLabs
{
    //D=(2*(B*2,25+G)+C*3,14)*A+F*E
    public partial class Lab5beta : Form
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
        private Stack<OperandNode> operands;
        private Stack<string> operations;
        private int indx = 0;

        public Lab5beta()
        {
            InitializeComponent();
            operands = new Stack<OperandNode>();
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
            string beta = "";
            indx = 2;
            operations.Clear();
            operands.Clear();

            expression = textExpr.Text + "$";
            expression.Replace('.', ',');
            int action;
            operations.Push("$");

            do
            {
                char next = expression[indx];
                if (next != '+' && next != '*' && next != '(' && next != ')' && next != '=' && next != '$')
                {
                    if (char.IsDigit(next))
                    {
                        operands.Push( new OperandNode(readNumber(indx), 0) );
                        indx = indx + operands.Peek().code.Length-1;
                        beta += Environment.NewLine + "new DIGIT: " + operands.Peek().code;
                    }
                    else if (char.IsLetter(next))
                    {
                        operands.Push( new OperandNode(readLetter(indx), 0) );
                        indx = indx + operands.Peek().code.Length;
                        beta += Environment.NewLine + "new LETTER: " + operands.Peek().code;

                    }
                }
                action = transTable[operIndxs1[operations.Peek()], operIndxs2[expression[indx].ToString()] ];
                makeAction(action);


               } while (action != 4);

            string result = "Исходное выражение:" + Environment.NewLine +
                expression+ Environment.NewLine +
                operands.Pop().code + Environment.NewLine + 
                "STORE " + expression[0];

            Lab5_2beta answ = new Lab5_2beta(result.ToString());
            answ.FormClosed += SubFormClosed;
            answ.ShowDialog();
        }
        public void SubFormClosed(Object sender, EventArgs e)
        {
            this.Show();
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
            OperandNode a = operands.Pop();
            OperandNode b = operands.Pop();
            string code;
            int lvl = Math.Max(a.lvl, b.lvl);
            string n = Environment.NewLine;
            switch (operations.Pop())
            {
                case "+":
                    code = $"{a.code}{n}STORE {lvl}{n}LOAD {b.code}{n}ADD {lvl}";
                    operands.Push(new OperandNode(code, lvl+1));
                    break;
                case "*":
                    code = $"{a.code}{n}STORE {lvl}{n}LOAD {b.code}{n}MPY {lvl}";
                    operands.Push(new OperandNode(code, lvl+1));
                    break;
            }
        }
        private string readNumber(int indx)
        {
            string res = "=";
            while(char.IsDigit(expression[indx]) || expression[indx] == ',')
            {
                res += expression[indx];
                indx++;
            }
            return res;
        }

        private string readLetter(int indx)
        {
            string res = "";
            char next = expression[indx];

            if (char.IsLetter(next) && next != '+' && next != '*' && next != '(' && next != ')' && next != '=' && next != '$')
            {
                res += next;
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
        }

    }
    
    class OperandNode 
    {
        public OperandNode(string code, int lvl)
        {
            this.code = code;
            this.lvl = lvl;
        }
        public string code;
        public int lvl;
    }
}
