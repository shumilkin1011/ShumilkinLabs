    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    namespace ShumilkinLabs
    {
        public partial class Lab2 : Form
        {
            // состояния, алфавит, хорошие состояния
            List<string> states = new List<string>();
            List<string> alfavit = new List<string>();
            List<string> goodStates = new List<string>();

            // словарь, где ключ - набор состояний, значение - номер нов. состояния
            Dictionary<List<string>,int> newStates = new Dictionary<List<string>,int>();
            // словать, где ключ - номер нов. сост, значение - набор первонач. состояний
            Dictionary<int, List<string>> getStatesByInt = new Dictionary<int, List<string>>();
            // словать, где ключ - номер нов. сост, значение - список переходов для каждого симв. алфавита
            Dictionary<int, List<int>> newTransitions = new Dictionary<int, List<int>>();

            // взаимосоответствие между именами состояний, симв. алфавита и их индексами в матр.
            Dictionary<string, int> alfavitIndexes = new Dictionary<string, int>();
            Dictionary<string, int> statesIndexes = new Dictionary<string, int>();
            // словарь с 27 символами - названиями новых состояний
            static Dictionary<int, char> bukv = new Dictionary<int, char>();

            // матрица переходов (изнач.)
            List<string>[,] transitions;
            // начальное состояние
            string initState;

            public Lab2()
            {
                InitializeComponent();
            }

            private void TransformFSM()
            {
                // вручную добавляем в список начальное состояние
                List<string> initStateList = new List<string>() { initState };
                // добавляем в словарь номер нового состояния (ключ - набор. стар. сост)
                newStates.Add(initStateList, 0);
                // обратный словарь, чтобы получить набор. стар. сост по номеру нов. сост-ия
                getStatesByInt.Add(0, initStateList);
                // номер новой вершины
                int counter = 0;

                // очередь для заполнения строк новых добавленных сост-ий
                Queue<int> checkLater = new Queue<int>();
                // добавляем в список строку под номером 0 (нач. сост)
                checkLater.Enqueue(0);

                // пока в очереди не закончаться строки для заполнения
                while (checkLater.Count>0)
                {
                    int num = checkLater.Dequeue();
                    List<int> statesTemp = new List<int>();
                    // для каждой буквы алфавита
                    for(int i =0;i<alfavit.Count(); i++)
                    {
                        // ищем какие состояний доступны из данного сост.
                        List<string> found = FindAvailStates(num, i);
                        bool isFound = false;
                        int ind = -1;
                        // проверяем есть ли у нас набор таких состояний в таблице
                        foreach (KeyValuePair<List<string>,int> ent in newStates)
                        {
                        
                            if (ent.Key.OrderBy(x => x).SequenceEqual(found.OrderBy(x => x)) )
                            {
                                isFound = true;
                                ind = ent.Value;
                            }
                        }
                        // если есть, то запоминаем в списке номер сост-ия, в которое идем
                        if(isFound)
                        {
                            statesTemp.Add(ind);
                        }
                        // иначе добавляем новое состояние, запоминаем набор стар. состояний,
                        // входящих в нов. сост, добавляем нов. верш. в стек для послед. заполнения
                        else
                        {
                            counter++;
                            newStates.Add(found, counter);
                            getStatesByInt.Add(counter, found);
                            statesTemp.Add(counter);
                            checkLater.Enqueue(counter);
                        }
                    
                    } 
                    newTransitions.Add(num, statesTemp);
                }

            }

            // функция для поиск доступных сост. из выбранного сост. и симв. алфавита
            private List<string> FindAvailStates(int stateNum, int indAlf)
            {
                List<string> result = new List<string>();
                List<string> newStatesToCheck = getStatesByInt[stateNum];
                foreach(string s in newStatesToCheck)
                {
                    // добавляем в список все сост, в которые можем пройти
                    result.AddRange(transitions[statesIndexes[s], indAlf]);
                }
                // убраем из списка повторы
                result = result.Distinct().ToList();
                // сортируем
                result.Sort();

                return result;
            }

            //заполнение матрицы переходов
            private void FillTransitions()
            {
                transitions = new List<string>[transitionMatr.RowCount, transitionMatr.ColumnCount];
                foreach (DataGridViewRow i in transitionMatr.Rows)
                {
                    if (i.IsNewRow) continue;
                    foreach (DataGridViewCell j in i.Cells)
                    {
                        transitions[j.RowIndex, j.ColumnIndex] = new List<string>();
                        List<string> statesInCell = new List<string>();
                        statesInCell = j.Value.ToString().Split(',').ToList();
                        transitions[j.RowIndex, j.ColumnIndex] = statesInCell;
                    }
                }
            }

            //запуск  К.А
            private void checkButton_Click(object sender, EventArgs e)
            {
                getStatesByInt.Clear();
                newStates.Clear();
                newTransitions.Clear();
                bukv.Clear();
                ClearDet();

                if (CheckInputData())
                {
                    FillTransitions();
                    TransformFSM();
                    ShowAns();
                }
            }

            // функция для вывода ответа на экран
            private void ShowAns()
            {
                // заполняем словарь с буквами для нов. сост
                for (int i = 0; i < 26; i++)
                {
                    bukv.Add(i, (char)(i + char.Parse("A")));
                }
                // заполняем строку с нов. сост
                for(int i = 0; i<newTransitions.Count;i++)
                {
                    textStatesDet.Text += bukv[i] + " ";
                }
                // заполн. строку с алфавитом
                for(int i = 0;i<alfavit.Count;i++)
                {
                    textAlfavitDet.Text += alfavit[i] + " ";
                }


                bool isGoodState = false;
         
                // ищем все хорошие состояния
                foreach (KeyValuePair<int, List<string>> entry in getStatesByInt)
                {
                    foreach(string state in entry.Value)
                    {
                        
                        if(goodStates.Contains(state))
                        {
                            isGoodState = true;
                        }
                    }
                    if (isGoodState)
                    {
                        // добавляем в список хорошее состояние
                        textGoodStatesDet.Text += bukv[entry.Key] + " ";
                    }
                    isGoodState = false;
                }

                // нач. состояние всегда "А"
                cBoxInitialStateDet.Items.Add(bukv[0]);
                cBoxInitialStateDet.SelectedIndex = 0;

                // заполняем матрицу
                FillNewMatrix();
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
                foreach (DataGridViewColumn column in transitionMatr.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

            }

            // заполняем новую матрицу переходов
            private void FillNewMatrix()
            {

                transitionMatrDet.ColumnCount = alfavit.Count() + 1;
                transitionMatrDet.RowCount = newTransitions.Count() ;
                transitionMatrDet.Columns[0].Name = "подмножества";
                for (int i = 0; i < alfavit.Count; i++)
                {
                    transitionMatrDet.Columns[i+1].Name = alfavit[i];
                }
           
                for(int i = 0; i<getStatesByInt.Count;i++)
                {
                    string s = "{ ";
                    foreach (string str in getStatesByInt[i])
                    {
                        s += str;
                        s += ",";
                    }
                    s = s.Remove(s.Length - 1, 1);
                    s += " }";

                    transitionMatrDet[0, i].Value = s;

                    for (int j = 0; j < alfavit.Count; j++)
                    {
                   
                        transitionMatrDet[j+1,i].Value = bukv[newTransitions[i][j]];
                    }
                    for (int k = 0; k < newTransitions.Count; k++)
                    {
                        transitionMatrDet.Rows[k].HeaderCell.Value = bukv[k].ToString();
                    }

                    foreach (DataGridViewColumn column in transitionMatrDet.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
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

            //изменение выбранного нач. состояния
            private void cBoxInitialState_SelectionChangeCommitted(object sender, EventArgs e)
            {
                initState = cBoxInitialState.SelectedItem.ToString().Trim();
            }

            // сохранение настроенного К.А.
            private void menuItemSave_Click(object sender, EventArgs e)
            {
                StreamWriter writer;
                saveFileDialog1.Title = "Сохранить пресет";
                saveFileDialog1.FileName = DateTime.Now.ToFileTimeUtc() + ".NDFSM";
                saveFileDialog1.DefaultExt = "NDFSM";
                saveFileDialog1.Filter = "non-deterministic finite state machine (*.NDFSM)|*.NDFSM|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 0;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    writer = new StreamWriter(saveFileDialog1.FileName);
                    writer.WriteLine(textAlfavit.Text);
                    writer.WriteLine();
                    writer.WriteLine(textStates.Text);
                    writer.WriteLine();
                    writer.WriteLine(textGoodStates.Text);
                    writer.WriteLine();
                    writer.WriteLine(cBoxInitialState.SelectedItem.ToString());
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
                openFileDialog1.DefaultExt = "NDFSM";
                openFileDialog1.Filter = "non-deterministic finite state machine (*.NDFSM)|*.NDFSM|txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 0;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    reader = new StreamReader(openFileDialog1.FileName);
                    textAlfavit.Text = reader.ReadLine();
                    reader.ReadLine();
                    textStates.Text = reader.ReadLine();
                    reader.ReadLine();
                    textGoodStates.Text = reader.ReadLine();
                    reader.ReadLine();
                    cBoxInitialState.SelectedItem = reader.ReadLine();
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

            //очистка полей
            private void menuClear_Click(object sender, EventArgs e)
            {
                textAlfavit.Text = "";
                textStates.Text = "";
                textGoodStates.Text = "";
                transitionMatr.DataSource = null;
                transitionMatr.Rows.Clear();
                transitionMatr.Columns.Clear();

                ClearDet();
            }

            private void ClearDet()
            {
                textAlfavitDet.Text = "";
                textStatesDet.Text = "";
                textGoodStatesDet.Text = "";
                transitionMatrDet.DataSource = null;
                transitionMatrDet.Rows.Clear();
                transitionMatrDet.Columns.Clear();
            }
            //проверки введенных данных
            private bool CheckInputData()
            {

                if (textAlfavit.Text == "")
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
                else if (CheckMatrixForNull() )
                {
                    MessageBox.Show("Незаполнены некоторые поля матрицы переходов???"
                        , "Обнаружена ошибка", MessageBoxButtons.OK);
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
                    MessageBox.Show("Всё указано правильно!!!", "Ошибок не обнаружено", MessageBoxButtons.OK);
            }

        }
    }
