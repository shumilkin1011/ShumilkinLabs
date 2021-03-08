using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShumilkinLabs
{
    public partial class Lab6 : Form
    {
        // TODO: ПРАВИЛА ПЕРЕХОДОВ + сохранение матриц
        // состояния, алфавит, хорошие состояния
        List<char> neterms = new List<char>();
        List<char> terms = new List<char>();
        List<string> rules = new List<string>();

        // взаимосоответствие между именами состояний и их индексами в матр.
        Dictionary<char, int> netermIndexes = new Dictionary<char, int>();
        Dictionary<char, int> termIndexes = new Dictionary<char, int>();

        // матрица переходов
        string[,] actionMatr;
        string[,] gotoMatr;

        // кол-во состояний
        int statesNumber;
        // краткое описане данного К.А.
        string description;
        StringBuilder result = new StringBuilder();

        public Lab6()
        {
            InitializeComponent();
        }

        // начало алгоритма
        private void checkButton_Click(object sender, EventArgs e)
        {
            result.Length = 0;
            if (CheckInputData())
            {
                // заполняем матрицу переходов
                FillTransitions();
                // считываем правила грамматики
                ParseRules();
                // проводим LR-анализ
                Analyze();
                Lab6_2 answ = new Lab6_2(result.ToString());
                answ.FormClosed += SubFormClosed;
                answ.ShowDialog();
            }
        }

        // метод проверки слова на принадлежность алфавиту
        private void Analyze()
        {
            // текущ. сост
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            // слово на проверку
            string currentWord = textWordToCheck.Text.Trim() + '$';
            // индекс отдельной буквы слова
            int i = 0;
            // шаг алгоритма
            int step = 1;
            // переменная - новая строка
            string n = Environment.NewLine;

            while (true)
            {
                // запоминаем что лежит в стеке в виде одной строки
                StringBuilder magaz = new StringBuilder();
                foreach (int ch in stack.Reverse())
                {
                    magaz.Append(ch.ToString() + " ");
                }
                result.Append("Шаг: " + step + n);
                result.Append("Магазин: " + magaz + n);
                result.Append("Вход: " + currentWord.Substring(i) + n);

                // смотрим на элемент с вершины стека (магазина)
                int curSt = stack.Peek();
                // смотрим на текущий символ вх. строки
                char curCh = currentWord[i];
                // определяем текущее действие
                string curAct = actionMatr[curSt, termIndexes[curCh]];
                // если в траблице нет действия для данного состояния
                // выдаём ошибку
                if (curAct == null) throw 
                        new Exception("Переход в некоректное состояние: " + curSt + "&" + "curCh");
                // если по таблице требуется сдвиг 
                else if (curAct.ToUpper()[0] == 'S')
                {
                    // смотрим в какое состояние нужно перейти
                    int trans = int.Parse(curAct[1].ToString());
                    // выполняем сдвиг
                    i++;
                    step++;
                    result.Append("Действие: сдвиг в состояние №" + trans + n);
                    // добавляем новое состояние в стек
                    stack.Push(trans);

                }
                // если по таблице требуется свёртка
                else if (curAct.ToUpper()[0] == 'R')
                {
                    // смотрим по какому правилу вып-ся свертка
                    int trans = int.Parse(curAct[1].ToString());
                    step++;
                    result.Append("Действие: свёртка по правилу: " + rules[trans] + n);

                    // считаем сколько символов нужно удалить из стека при свертке
                    int deleteCount = DeleteCount(rules[trans]);
                    for (int j = 0; j < deleteCount; j++)
                    {
                        stack.Pop();
                    }

                    // по таблице goto определяем в какое состояние мы должны перейти
                    // для этого смотрим на эл-т в стеке и нетерминал в левой части правила свёртки
                    string newStStr = gotoMatr[stack.Peek(), netermIndexes[rules[trans][0]]];
                    if(newStStr == null) throw 
                            new Exception("Нет нужного перехода в матрице goto: " + stack.Peek() + 
                            "x" + netermIndexes[rules[trans][0]]);
                    int newSt = int.Parse(newStStr);
                    // добавляем новое состояние в стек
                    stack.Push(newSt);

                }
                // если мы встретили ключевое слово "ACC"
                // выходим из цикла
                else if(curAct.ToUpper() == "ACC")
                {
                    result.Append("Действие: ACC" + n);
                    break;
                }
                result.Append("------------------------------------------"+n);
            }
        }

        // метод для подсчета кол-ва символов, удаляющихся из стека
        private int DeleteCount(string s)
        {
            string s2 = s.Split('>')[1].Trim().Replace(" ", "");
            return s2.Length;
        }

        // парсим правила грамматики
        private void ParseRules()
        {
            for(int i = 0; i<lstRules.Items.Count;i++)
            {
                rules.Add(lstRules.Items[i].ToString());
            }
        }

        // заполнение матрицы переходов
        private void FillTransitions()
        {
            actionMatr = new string[actionMatrix.RowCount, actionMatrix.ColumnCount];
            gotoMatr = new string[actionMatrix.RowCount, actionMatrix.ColumnCount];
            foreach (DataGridViewRow i in actionMatrix.Rows)
            {
                if (i.IsNewRow) continue;
                foreach (DataGridViewCell j in i.Cells)
                {
                    if (j.Value != null)
                        actionMatr[j.RowIndex, j.ColumnIndex] = j.Value.ToString();
                }
            }
            foreach (DataGridViewRow i in gotoMatrix.Rows)
            {
                if (i.IsNewRow) continue;
                foreach (DataGridViewCell j in i.Cells)
                {
                    if (j.Value != null)
                        gotoMatr[j.RowIndex, j.ColumnIndex] = j.Value.ToString();
                }
            }
        }


        //создание заголовков матрицы
        private void FillMatrix()
        {
            if (!(statesNumber > 0 && textNeterms.Text.Length > 0 && textTerms.Text.Length > 0))
                return;
            netermIndexes.Clear();
            termIndexes.Clear();
            actionMatrix.ColumnCount = terms.Count();
            actionMatrix.RowCount = statesNumber;
            for (int i = 0; i < terms.Count; i++)
            {
                // устанавливаем заголовки колонок в матрице
                actionMatrix.Columns[i].Name = terms[i].ToString();
                // каждому термналу (букве) ставим в соотв-ие его индекс в массиве
                termIndexes.Add(terms[i], i);
            }
            for (int i = 0; i < statesNumber; i++)
            {
                actionMatrix.Rows[i].HeaderCell.Value = i.ToString();
            }

            gotoMatrix.ColumnCount = neterms.Count();
            gotoMatrix.RowCount = statesNumber;
            for (int i = 0; i < neterms.Count; i++)
            {
                // устанавливаем заголовки колонок в матрице
                gotoMatrix.Columns[i].Name = neterms[i].ToString();
                // каждому термналу (букве) ставим в соотв-ие его индекс в массиве
                netermIndexes.Add(neterms[i], i);
            }
            for (int i = 0; i < statesNumber; i++)
            {
                gotoMatrix.Rows[i].HeaderCell.Value = i.ToString();
            }

        }

        //сохранение настроенного К.А.
        private void menuItemSave_Click(object sender, EventArgs e)
        {
            StreamWriter writer;
            saveFileDialog1.Title = "Сохранить пресет";
            saveFileDialog1.FileName = description + ".LRGram";
            saveFileDialog1.DefaultExt = "LRGram";
            saveFileDialog1.Filter = "LR grammar (*.LRGram)|*.LRGram|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 0;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                writer = new StreamWriter(saveFileDialog1.FileName);
                writer.WriteLine(textDescription.Text);
                writer.WriteLine();
                writer.WriteLine(textNeterms.Text);
                writer.WriteLine();
                writer.WriteLine(textTerms.Text);
                writer.WriteLine();
                writer.WriteLine(textStatesNumb.Text);
                writer.WriteLine();
                writer.WriteLine(textWordToCheck.Text);
                writer.WriteLine();

                for (int i = 0; i < actionMatrix.RowCount; i++)
                {
                    for (int j = 0; j < actionMatrix.ColumnCount; j++)
                    {
                        if (actionMatrix.Rows[i].Cells[j].Value != null)
                            writer.Write(actionMatrix.Rows[i].Cells[j].Value.ToString() + " ");
                        else writer.Write("# ");
                    }
                    writer.Write(writer.NewLine);
                }
                writer.WriteLine();
                for (int i = 0; i < gotoMatrix.RowCount; i++)
                {
                    for (int j = 0; j < gotoMatrix.ColumnCount; j++)
                    {
                        if (gotoMatrix.Rows[i].Cells[j].Value != null)
                            writer.Write(gotoMatrix.Rows[i].Cells[j].Value.ToString() + " ");
                        else writer.Write("# ");
                    }
                    writer.Write(writer.NewLine);
                }
                writer.WriteLine();
                for (int i = 0; i < lstRules.Items.Count; i++)
                {
                    writer.WriteLine(lstRules.Items[i].ToString());
                }
                writer.Close();
            }
           
        }

        //загрузка сохраненного К.А.
        private void menuItemLoad_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            openFileDialog1.Title = "Выбрать сохраненный файл";
            openFileDialog1.FileName = "";
            openFileDialog1.DefaultExt = "LRGram";
            openFileDialog1.Filter = "LR grammar (*.LRGram)|*.LRGram|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                reader = new StreamReader(openFileDialog1.FileName);
                textDescription.Text = reader.ReadLine();
                reader.ReadLine();
                textNeterms.Text = reader.ReadLine();
                reader.ReadLine();
                textTerms.Text = reader.ReadLine();
                reader.ReadLine();
                textStatesNumb.Text = reader.ReadLine();
                reader.ReadLine();
                textWordToCheck.Text = reader.ReadLine();
                reader.ReadLine();

                for (int i = 0; i < actionMatrix.RowCount; i++)
                {
                    string[] str = reader.ReadLine().Trim().Split(' ');
                    for (int j = 0; j < actionMatrix.ColumnCount; j++)
                    {
                        if (str[j] != "#")
                            actionMatrix.Rows[i].Cells[j].Value = str[j];
                    }
                }
                reader.ReadLine();
                for (int i = 0; i < gotoMatrix.RowCount; i++)
                {
                    string[] str = reader.ReadLine().Trim().Split(' ');
                    for (int j = 0; j < gotoMatrix.ColumnCount; j++)
                    {
                        if (str[j] != "#")
                           gotoMatrix.Rows[i].Cells[j].Value = str[j];
                    }
                }
                reader.ReadLine();
                List<string> rules = reader.ReadToEnd().Split('\n').ToList();
                for(int i =0;i<rules.Count;i++)
                {
                    if(rules[i].Length > 0)
                        lstRules.Items.Add(rules[i]);
                }
                lstRules.Update();
                reader.Close();
            }

        }

        //проверки введенных данных
        private bool CheckInputData()
        {
            if (textDescription.Text == "")
            {
                MessageBox.Show("Забыли указать описание???", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textNeterms.Text == "")
            {
                MessageBox.Show("Забыли указать нетермин. символы???", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textTerms.Text == "")
            {
                MessageBox.Show("Забыли указать терм. символы???", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textStatesNumb.Text == "")
            {
                MessageBox.Show("Забыли указать кол-во состояний???", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (lstRules.Items.Count < 1)
            {
                MessageBox.Show("Забыли вписать правила грамматики???", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textWordToCheck.Text == "")
            {
                MessageBox.Show("Забыли указать слово для проверки???", "Обнаружена ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Дальше идут второстепенные методы и обработки событий
        /////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////


        // клика по кнопке очистки
        private void menuClear_Click(object sender, EventArgs e)
        {
            textNeterms.Text = "";
            textTerms.Text = "";
            textDescription.Text = "";
            textStatesNumb.ResetText();
            textWordToCheck.Text = "";
            actionMatrix.DataSource = null;
            actionMatrix.Rows.Clear();
            actionMatrix.Columns.Clear();
            btnClearList.PerformClick();

        }

        // изменилось множ-во нетерминалов
        private void textNeterms_TextChanged(object sender, EventArgs e)
        {
            neterms.Clear();
            if (textNeterms.Text.Length > 0)
            {
                string[] temp = textNeterms.Text.Trim().Split(' ');
                foreach (string str in temp)
                {
                    neterms.Add(str.ToCharArray()[0]);
                }
            }

            FillMatrix();
        }

        // изменилось множество терминалов
        private void textTerms_TextChanged(object sender, EventArgs e)
        {
            terms.Clear();
            string[] temp = textTerms.Text.Trim().Split(' ');
            if (temp[0].Length > 0)
            {
                foreach (string str in temp)
                {
                    terms.Add(str.ToCharArray()[0]);
                }
                if (neterms.Count > 0) FillMatrix();
            }

            FillMatrix();
        }

        //считывание описания текущей К.А.
        private void textDescription_TextChanged(object sender, EventArgs e)
        {
            description = textDescription.Text;
        }
                
        public void SubFormClosed(Object sender, EventArgs e)
        {
            this.Show();
        }

        private void checkDataMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckInputData())
                MessageBox.Show("Всё указано правильно!!!", "Ошибок не обнаружено, но это не точно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textStatesNumb_TextChanged(object sender, EventArgs e)
        {
            if (!(textStatesNumb.Text.Length > 0)) return;
            statesNumber = int.Parse(textStatesNumb.Text);
            FillMatrix();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstRules.Items.Add(textNewRule.Text);
            textNewRule.Clear();
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            lstRules.Items.Clear();
            lstRules.Update();
        }
    }
}
