using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ShumilkinLabs
{
    // Пример: D=(2*(B*2,25+G)+C*3,14)*A+F*E
    public partial class Lab5 : Form
    {
        // входная строка
        private string expression = "";
        // таблица переходов К.А.
        private int[,] transTable = new int[,]
            { {5,2,2,2,2,5,5},
              {5,5,5,5,2,5,5},
              {5,5,5,5,2,5,5},
              {5,5,5,5,2,5,5},
              {2,2,2,2,2,6,3},
              {2,2,2,2,2,3,4}
            };

        // словари, где хранится соотв. индекс массива для 
        // string элемента, представляющего какую-либо арифм. операцию
        private Dictionary<string, int> operIndxs1;
        private Dictionary<string, int> operIndxs2;

        // стек операндов
        private Stack<OperandNode> operands;
        // стек операций
        private Stack<string> operations;
        // текущий символ вх. строки
        private int indx = 0;
        // таблица с идентификаторами
        private Hashtable hashtable;

        public Lab5()
        {
            // инициализация всех структур данных
            InitializeComponent();
            operands = new Stack<OperandNode>();
            operations = new Stack<string>();
            operIndxs1 = new Dictionary<string, int>();
            operIndxs2 = new Dictionary<string, int>();
            hashtable = new Hashtable();
            operIndxs1.Add("+", 0);
            operIndxs1.Add("*", 1);
            operIndxs1.Add("^", 2);
            operIndxs1.Add("%", 3);
            operIndxs1.Add("(", 4);
            operIndxs1.Add("$", 5);

            operIndxs2.Add("+", 0);
            operIndxs2.Add("*", 1);
            operIndxs2.Add("^", 2);
            operIndxs2.Add("%", 3);
            operIndxs2.Add("(", 4);
            operIndxs2.Add(")", 5);
            operIndxs2.Add("$", 6);
        }

        // основной метод
        private void Compute_Click(object sender, EventArgs e)
        {
            // начинаем с третьего (0 1 2) символа строки, т.к.
            // первые 2 всегда будут иметь вид A=
            indx = 2;
            // очищаем стеки
            operations.Clear();
            operands.Clear();
            hashtable.Clear();

            // добавляем символ конца строки
            expression = textExpr.Text + "$";
            // заменяем все точки запятыми, для правильного парсинга типа double
            expression.Replace('.', ',');
            // добавляем первый идентификатор в хэш-таблицу (тот, что перед знаком = )
            hashtable.Add(expression[0].ToString(), null);
            // переменная отслеживающая текущее состояние К.А.
            int action;
            // добавляем в стек операций символ конца строки
            operations.Push("$");

            do
            {   
                // текущий символ строки
                char next = expression[indx];
                // проверяем не является ли символ какой-либо операцией
                if (!operIndxs2.ContainsKey(next.ToString()))
                {
                    // если это число, парсим его и добавляем в стек операндов со знаком = перед ним
                    if (char.IsDigit(next))
                    {
                        operands.Push( new OperandNode(readNumber(indx), 0) );
                        indx = indx + operands.Peek().code.Length-1;
                    }
                    // если это идентификтор, то парсим его и добавляем в стек операндов
                    // и хэш-таблицу
                    else if (char.IsLetter(next))
                    {
                        operands.Push( new OperandNode(readLetter(indx), 0) );
                        indx = indx + operands.Peek().code.Length;
                        if(!hashtable.ContainsKey(operands.Peek().code))
                            hashtable.Add(operands.Peek().code, null);
                    }
                }
                // определяем какое действие следует совершить
                action = transTable[operIndxs1[operations.Peek()], operIndxs2[expression[indx].ToString()] ];
                // совершаем это действие
                makeAction(action);

                // 4-ое действие означает успешное заверш. работы
               } while (action != 4);

            // выводим результаты
            showResults();
        }

        private void showResults()
        {
            string n = Environment.NewLine;
            string result = "Исходное выражение:" + n +
                expression + n + n +
                operands.Pop().code + n +
                "STORE " + expression[0] + n + n;
            result += "Сохраненные идентификаторы:" + n;

            foreach (DictionaryEntry entry in hashtable)
            {
                result += entry.Key + ": empty\t";
            }

            Lab5_2 answ = new Lab5_2(result.ToString());
            answ.FormClosed += SubFormClosed;
            answ.ShowDialog();
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
                case "^":
                    int power = int.Parse(a.code.Remove(0,1));
                    code = $"{b.code}{n}STORE {lvl}{n}LOAD {b.code}";
                    for (int i = 0; i < power; i++)
                    {
                        code += $"{n}MPY {lvl}";
                        operands.Push(new OperandNode(code, lvl + 1));
                    }
                    break;
                case "%":
                    // TODO: CODE FOR %
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

            if (!operations.Contains(next.ToString()))
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

        // обработка закрытия второстепенной формы (окна) с 
        // результатами работы программы
        public void SubFormClosed(Object sender, EventArgs e)
        {
            this.Show();
        }

    }
    
    // класс, который хранит в себе код для текущего узла
    // и его уровень
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
