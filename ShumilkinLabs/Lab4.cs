using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShumilkinLabs
{
    public partial class Lab4 : Form
    {
        //состояния, алфавит, хорошие состояния
        List<char> Neterms = new List<char>();
        List<char> Terms = new List<char>();

        //взаимосоответствие между именами состояний и их индексами в матр.
        Dictionary<char, int> NetermIndexes = new Dictionary<char, int>();
        Dictionary<char, int> TermIndexes = new Dictionary<char, int>();

        //матрица переходов
        string[,] transitions;

        //начальное состояние
        char initNeterm = 'S';
        //краткое описане данного К.А.
        string descrption;
        StringBuilder result = new StringBuilder();

        public Lab4()
        {
            InitializeComponent();
        }

        //метод проверки слова на принадлежность алфавиту
        private void CheckWord()
        {
            //текущ. сост
            Stack<char> stack = new Stack<char>();
            stack.Push('$');
            stack.Push(initNeterm);
            //слово на проверку
            string currentWord = textWordToCheck.Text.Trim() + '$';
            //индекс отдельной буквы слова
            int i = 0;
            // итерация алгоритма
            int step = 1;
            while (stack.Count > 1)
            {
                // берем элементы стека (магазина) в обр. порядке
                char[] ar = stack.Reverse().ToArray();
                // запоминаем что лежит в стеке в виде одной строки
                StringBuilder builder = new StringBuilder();
                foreach (char c in ar)
                {
                    builder.Append(c);
                }

                // переменная для текстовой записи каждого шага
                string info;
                // берём элемент с вершины стека (магазина)
                char cur = stack.Pop();
                // если это лямбда, тогда ничего делать не нужно
                if (cur == 'λ') continue;
                // если же это нетерминал, то...
                if (NetermIndexes.ContainsKey(cur))
                {
                    // смотрим в таблицу переходов и добавляем нужные символы в магазин
                    string toAdd = transitions[NetermIndexes[cur], TermIndexes[currentWord[i]]];
                    if (toAdd == null)
                    {
                        throw new Exception($"В таблице нет нужного перехода: {cur}<--->{currentWord[i]} ");
                    }
                    info = $"{step}. {Environment.NewLine}" +
                        $"Магазин: {builder} {Environment.NewLine}" +
                        $"Строка: {currentWord.Substring(i)} {Environment.NewLine}" +
                        $"Выход: {cur} --> {toAdd} {Environment.NewLine}";
                    result.Append(info);
                    char[] charsToAdd = toAdd.ToCharArray().Reverse().ToArray();
                    foreach (char ch in charsToAdd)
                    {
                        stack.Push(ch);
                    }
                    step++;
                }
                // если же это терминал, то ...
                else if (TermIndexes.ContainsKey(currentWord[i]) && cur == currentWord[i])
                {
                    result.Append($"{step}. { Environment.NewLine}" +
                        $"Магазин: {builder} {Environment.NewLine}" +
                        $"Строка: {currentWord.Substring(i)} {Environment.NewLine}" +
                        $"Удаляем терминал: {currentWord[i]} {Environment.NewLine}");
                    i++;
                    // делаем шаг на сл. элемент входной строки
                    step++;
                }
                else throw new Exception("Неразрешенный символ во входной строке: " + currentWord[i]);

            }

            // в конце алгоритма, в стеке должен остаться один элемент (конец строки)
            // и во входной строке тоже должен остаться только доллар 
            if (stack.Count == 1 && currentWord[i] == stack.Peek())
            {
                result.Append($"Слово принадлежит алфавиту :)");
            }
            else
            {
                result.Append($"Слово НЕ принадлежит алфавиту :(");
            }
        }

        //заполнение матрицы переходов
        private void FillTransitions()
        {
            transitions = new string[transitionMatr.RowCount, transitionMatr.ColumnCount];
            foreach (DataGridViewRow i in transitionMatr.Rows)
            {
                if (i.IsNewRow) continue;
                foreach (DataGridViewCell j in i.Cells)
                {
                    if (j.Value != null)
                        transitions[j.RowIndex, j.ColumnIndex] = j.Value.ToString();
                }
            }
        }

        //запуск  К.А
        private void checkButton_Click(object sender, EventArgs e)
        {
            result.Length = 0;
            if (CheckInputData())
            {
                FillTransitions();
                CheckWord();
                Lab4_2 answ = new Lab4_2(result.ToString());
                answ.FormClosed += SubFormClosed;
                answ.ShowDialog();
            }
        }

        public void SubFormClosed(Object sender, EventArgs e)
        {
            this.Show();
        }

        //создание заголовков матрицы
        private void FillMatrix()
        {
            NetermIndexes.Clear();
            TermIndexes.Clear();
            transitionMatr.ColumnCount = Terms.Count();
            transitionMatr.RowCount = Neterms.Count();
            for (int i = 0; i < Terms.Count; i++)
            {
                // устанавливаем заголовки колонок в матрице
                transitionMatr.Columns[i].Name = Terms[i].ToString();
                // каждому термналу (букве) ставим в соотв-ие его индекс в массиве
                TermIndexes.Add(Terms[i], i);
            }
            for (int i = 0; i < Neterms.Count; i++)
            {
                transitionMatr.Rows[i].HeaderCell.Value = Neterms[i].ToString();
                NetermIndexes.Add(Neterms[i], i);
            }

        }

        private void textNeterms_TextChanged(object sender, EventArgs e)
        {
            Neterms.Clear();
            cBoxInitialNeterm.Items.Clear();
            if (textNeterms.Text.Length > 0)
            {
                string[] temp = textNeterms.Text.Trim().Split(' ');
                foreach (string str in temp)
                {
                    Neterms.Add(str.ToCharArray()[0]);
                    cBoxInitialNeterm.Items.Add(str.ToCharArray()[0]);
                }
                cBoxInitialNeterm.SelectedIndex = 0;
            }
        }

        private void textTerms_TextChanged(object sender, EventArgs e)
        {
            Terms.Clear();
            string[] temp = textTerms.Text.Trim().Split(' ');
            if (temp[0].Length > 0)
            {
                foreach (string str in temp)
                {
                    Terms.Add(str.ToCharArray()[0]);
                }
                if (Neterms.Count > 0) FillMatrix();
            }
        }

        //изменение выбранного нач. состояния
        private void CBoxInitialNeterm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            initNeterm = cBoxInitialNeterm.SelectedItem.ToString().Trim().ToCharArray()[0];

        }
        //изменение выбранного нач. состояния
        private void cBoxInitialState_SelectedIndexChanged(object sender, EventArgs e)
        {
            initNeterm = cBoxInitialNeterm.SelectedItem.ToString().Trim().ToCharArray()[0];
        }

        //считывание описания текущей К.А.
        private void textDescription_TextChanged(object sender, EventArgs e)
        {
            descrption = textDescription.Text;
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
            label5.Text = "(символ скопирован)";
        }

        //сохранение настроенного К.А.
        private void menuItemSave_Click(object sender, EventArgs e)
        {
            StreamWriter writer;
            saveFileDialog1.Title = "Сохранить пресет";
            saveFileDialog1.FileName = descrption + ".SyntAn";
            saveFileDialog1.DefaultExt = "SyntAn";
            saveFileDialog1.Filter = "syntax analyzer (*.SyntAn)|*.SyntAn|txt files (*.txt)|*.txt|All files (*.*)|*.*";
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
                writer.WriteLine(cBoxInitialNeterm.SelectedItem.ToString());
                writer.WriteLine();
                writer.WriteLine(textWordToCheck.Text);
                writer.WriteLine();

                for (int i = 0; i < transitionMatr.RowCount; i++)
                {
                    for (int j = 0; j < transitionMatr.ColumnCount; j++)
                    {
                        if (transitionMatr.Rows[i].Cells[j].Value != null)
                            writer.Write(transitionMatr.Rows[i].Cells[j].Value.ToString() + " ");
                        else writer.Write("# ");
                    }
                    writer.Write(writer.NewLine);
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
            openFileDialog1.DefaultExt = "SyntAn";
            openFileDialog1.Filter = "syntax analyzer (*.SyntAn)|*.SyntAn|txt files (*.txt)|*.txt|All files (*.*)|*.*";
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
                cBoxInitialNeterm.SelectedItem = reader.ReadLine();
                reader.ReadLine();
                textWordToCheck.Text = reader.ReadLine();
                reader.ReadLine();

                for (int i = 0; i < transitionMatr.RowCount; i++)
                {
                    string[] str = reader.ReadLine().Trim().Split(' ');
                    for (int j = 0; j < transitionMatr.ColumnCount; j++)
                    {
                        if (str[j] != "#")
                            transitionMatr.Rows[i].Cells[j].Value = str[j];
                    }
                }
                reader.Close();
            }

        }

        private void menuClear_Click(object sender, EventArgs e)
        {
            textNeterms.Text = "";
            textTerms.Text = "";
            textDescription.Text = "";
            cBoxInitialNeterm.ResetText();
            textWordToCheck.Text = "";
            transitionMatr.DataSource = null;
            transitionMatr.Rows.Clear();
            transitionMatr.Columns.Clear();

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
            else if (textWordToCheck.Text == "")
            {
                MessageBox.Show("Забыли указать слово для проверки???", "Обнаружена ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void checkDataMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckInputData())
                MessageBox.Show("Всё указано правильно!!!", "Ошибок не обнаружено, но это не точно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
