using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ShumilkinLabs
{
    public partial class Lab1 : Form
    {
        //состояния, алфавит, хорошие состояния
        List<string> states = new List<string>();
        List<string> alfavit = new List<string>();
        List<string> goodStates = new List<string>();

        //взаимосоответствие между именами состояний и их индексами в матр.
        Dictionary<string, int> alfavitIndexes = new Dictionary<string, int>();
        Dictionary<string, int> statesIndexes = new Dictionary<string, int>();

        //матрица переходов
        string[,] transitions;

        //строки с текстом в случае успешн и неуспешн. проверки слова
        string goodText;
        string badText;
        //начальное состояние
        string initState = "0";
        //краткое описане данного К.А.
        string descrption;
        public Lab1()
        {
            InitializeComponent();
        }

        //метд проверки слова (симуляция работы К.А)
        private void CheckWord()
        {
            //текущ. сост
            string currentState = initState;
            //слово на проверку
            string currentWord = textWordToCheck.Text.Trim() + '$';
            //индекс отдельной буквы слова
            int i = 0;
            while (currentWord[i] != '$')
            {
                currentState = transitions[statesIndexes[currentState], alfavitIndexes[currentWord[i].ToString()]];
                i++;
            }
            if (goodStates.Contains(currentState))
            {
                textResult.Text = goodText;
            }
            else textResult.Text = badText;
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
                    transitions[j.RowIndex, j.ColumnIndex] = j.Value.ToString();
                }
            }
        }

        //запуск  К.А
        private void checkButton_Click(object sender, EventArgs e)
        {
            if (CheckInputData())
            {
                FillTransitions();
                CheckWord();
            }
        }

        //Считывание состояний
        private void states_TextChanged(object sender, EventArgs e)
        {
            states = textStates.Text.Trim().Split(' ').ToList<string>();
            cBoxInitialState.DataSource = states;
            if (textAlfavit.Text.Length > 0)
            {
                if(states.Count() == states.Distinct().Count() &&
                    alfavit.Count() == alfavit.Distinct().Count())
                FillMatrix();
            }
        }

        //создание заголовков матрицы
        private void FillMatrix()
        {
            alfavitIndexes.Clear();
            statesIndexes.Clear();
            transitionMatr.ColumnCount = alfavit.Count();
            transitionMatr.RowCount = states.Count();
            for (int i = 0; i < alfavit.Count; i++)
            {
                transitionMatr.Columns[i].Name = alfavit[i];
                alfavitIndexes.Add(alfavit[i], i);
            }
            for (int i = 0; i < states.Count; i++)
            {
                transitionMatr.Rows[i].HeaderCell.Value = states[i];
                statesIndexes.Add(states[i], i);
            }

        }

        //считывание алфавита
        private void textAlfavit_TextChanged(object sender, EventArgs e)
        {
            alfavit = textAlfavit.Text.Trim().Split(' ').ToList<string>();
        }

        //считывание хороших состояний
        private void goodStates_TextChanged(object sender, EventArgs e)
        {
            goodStates = textGoodStates.Text.Trim().Split(' ').ToList<string>();
        }

        //считывания текста при успешн. проверке слова
        private void textGoodRes_TextChanged(object sender, EventArgs e)
        {
            goodText = textGoodRes.Text;
        }

        //считывания текста при неудачн. проверке слова
        private void textBadRes_TextChanged(object sender, EventArgs e)
        {
            badText = textBadRes.Text;
        }

        //изменение выбранного нач. состояния
        private void cBoxInitialState_SelectionChangeCommitted(object sender, EventArgs e)
        {
            initState = cBoxInitialState.SelectedItem.ToString().Trim();
        }

        //сохранение настроенного К.А.
        private void menuItemSave_Click(object sender, EventArgs e)
        {
            StreamWriter writer;
            saveFileDialog1.Title = "Сохранить пресет";
            saveFileDialog1.FileName = descrption + ".FSM";
            saveFileDialog1.DefaultExt = "FSM";
            saveFileDialog1.Filter = "state machine files (*.FSM)|*.FSM|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 0;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                writer = new StreamWriter(saveFileDialog1.FileName);
                writer.WriteLine(textDescription.Text);
                writer.WriteLine();
                writer.WriteLine(textAlfavit.Text);
                writer.WriteLine();
                writer.WriteLine(textStates.Text);
                writer.WriteLine();
                writer.WriteLine(textGoodStates.Text);
                writer.WriteLine();
                writer.WriteLine(cBoxInitialState.SelectedItem.ToString());
                writer.WriteLine();
                writer.WriteLine(textGoodRes.Text);
                writer.WriteLine();
                writer.WriteLine(textBadRes.Text);
                writer.WriteLine();

                for (int i = 0; i < transitionMatr.RowCount; i++)
                {
                    for (int j = 0; j < transitionMatr.ColumnCount; j++)
                    {
                        if (transitionMatr.Rows[i].Cells[j].Value.ToString() != null)
                            writer.Write(transitionMatr.Rows[i].Cells[j].Value.ToString() + " ");
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
            openFileDialog1.DefaultExt = "FSM";
            openFileDialog1.Filter = "state machine files (*.FSM)|*.FSM|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                reader = new StreamReader(openFileDialog1.FileName);
                textDescription.Text = reader.ReadLine();
                reader.ReadLine();
                textAlfavit.Text = reader.ReadLine();
                reader.ReadLine();
                textStates.Text = reader.ReadLine();
                reader.ReadLine();
                textGoodStates.Text = reader.ReadLine();
                reader.ReadLine();
                cBoxInitialState.SelectedItem = reader.ReadLine();
                reader.ReadLine();
                textGoodRes.Text = reader.ReadLine();
                reader.ReadLine();
                textBadRes.Text = reader.ReadLine();
                reader.ReadLine();

                for (int i = 0; i < transitionMatr.RowCount; i++)
                {
                    string[] str = reader.ReadLine().Trim().Split(' ');
                    for (int j = 0; j < transitionMatr.ColumnCount; j++)
                    {
                        transitionMatr.Rows[i].Cells[j].Value = str[j];
                    }
                }
                reader.Close();
            }

        }

        //изменение выбранного нач. состояния
        private void cBoxInitialState_SelectedIndexChanged(object sender, EventArgs e)
        {
            initState = cBoxInitialState.SelectedItem.ToString().Trim();

        }

        //считывание описания текущей К.А.
        private void textDescription_TextChanged(object sender, EventArgs e)
        {
            descrption = textDescription.Text;
        }

        //очистка полей
        private void menuClear_Click(object sender, EventArgs e)
        {
            textAlfavit.Text = "";
            textStates.Text = "";
            textGoodStates.Text = "";
            textDescription.Text = "";
            textGoodRes.Text = "";
            textBadRes.Text = "";
            textResult.Text = "";
            transitionMatr.DataSource = null;
            transitionMatr.Rows.Clear();
            transitionMatr.Columns.Clear();

        }

        //проверки введенных данных
        private bool CheckInputData()
        {
            if (textDescription.Text == "")
            {
                MessageBox.Show("Забыли указать описание К.М???", "Обнаружена ошибка", MessageBoxButtons.OK);
                return false;
            } 
            else if (textAlfavit.Text == "")
            {
                MessageBox.Show("Забыли указать символы алфавита???", "Обнаружена ошибка", MessageBoxButtons.OK);
                return false;
            }
            else if (CheckDublicatesAlfavit() )
            {
                MessageBox.Show("Обнаружены два одинаковых символа в строке алфавита???",
                    "Обнаружена ошибка", MessageBoxButtons.OK);
                return false;
            }
            else if (CheckDublicatesStates() )
            {
                MessageBox.Show("Обнаружены два одинаковых состояния в строке состояний???",
                    "Обнаружена ошибка", MessageBoxButtons.OK);

                return false;
            }
            else if(textStates.Text == "")
            {
                MessageBox.Show("Забыли указать возможные состояния???", "Обнаружена ошибка", MessageBoxButtons.OK);
                return false;
            }
            else if (textGoodStates.Text == "")
            {
                MessageBox.Show("Забыли указать хорошие состояния???", "Обнаружена ошибка", MessageBoxButtons.OK);
                return false;
            }
            else if (CheckGoodStates())
            {
                MessageBox.Show("В хороших состояниях указано состояние, которого нет в списке ВСЕХ состояний???"
                    , "Обнаружена ошибка", MessageBoxButtons.OK);
                return false;
            }
            else if (textGoodRes.Text == "")
            {
                MessageBox.Show("Забыли указать текст успешной проверки???", "Обнаружена ошибка", MessageBoxButtons.OK);
                return false;
            }
            else if (textBadRes.Text == "")
            {
                MessageBox.Show("Забыли указать текст неудачной проверки???", "Обнаружена ошибка", MessageBoxButtons.OK);
                return false;
            }
            else if (CheckMatrixForNull() )
            {
                MessageBox.Show("Незаполнены некоторые поля матрицы переходов???"
                    , "Обнаружена ошибка", MessageBoxButtons.OK);
                return false;
            }
            else if (CheckMatrixStates() )
            {
                MessageBox.Show("В одной из ячеек матрицы переходов указано состояние, которого нет в списке ВСЕХ состояний???"
                    , "Обнаружена ошибка", MessageBoxButtons.OK);
                return false;
            }
            else if (CheckWordToCheck() )
            {
                return false;
            }
            return true;
        }
        private bool CheckDublicatesAlfavit()
        {
            if (alfavit.Distinct().Count() != alfavit.Count()) return true;
            else return false;
        }
        private bool CheckDublicatesStates()
        {
            if (states.Distinct().Count() != states.Count()) return true;
            else return false;
        }
        private bool CheckWordToCheck()
        {
            if(textWordToCheck.Text == "")
            {
                DialogResult res = MessageBox.Show("Продолжить без указания слова на проверку???", "Намеренная ошибка", MessageBoxButtons.YesNo);
                if (res == DialogResult.No) return true;
                else return false;
            }
            return false;
        }
        private bool CheckMatrixStates()
        {
            for (int i = 0; i < transitionMatr.RowCount; i++)
            {
                for (int j = 0; j < transitionMatr.ColumnCount; j++)
                {
                    if (!states.Contains(transitionMatr.Rows[i].Cells[j].Value.ToString() ) ) return true;
                }
            }
            return false;
        }
        private bool CheckMatrixForNull()
        {
            for (int i = 0; i < transitionMatr.RowCount; i++)
            {
                for (int j = 0; j < transitionMatr.ColumnCount; j++)
                {
                    if (transitionMatr.Rows[i].Cells[j].Value == null) return true;
                }
            }
            return false;
        }
        private bool CheckGoodStates()
        {
            foreach(string state in goodStates)
            {
                if (!states.Contains(state)) return true;
            }
            return false;
        }
        private void checkInputData_Click(object sender, EventArgs e)
        {
            if(CheckInputData())
                MessageBox.Show("Всё указано правильно!!!", "Ошибок не обнаружено", MessageBoxButtons.OK); ;
            
        }
    }
}
