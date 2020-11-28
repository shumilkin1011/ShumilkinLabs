namespace ShumilkinLabs
{
    partial class Lab1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab1));
            this.textResult = new System.Windows.Forms.TextBox();
            this.Check = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fwsdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.проверитьКорректностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textAlfavit = new System.Windows.Forms.TextBox();
            this.textStates = new System.Windows.Forms.TextBox();
            this.cBoxInitialState = new System.Windows.Forms.ComboBox();
            this.transitionMatr = new System.Windows.Forms.DataGridView();
            this.textGoodStates = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textGoodRes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBadRes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textWordToCheck = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transitionMatr)).BeginInit();
            this.SuspendLayout();
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(189, 547);
            this.textResult.MaxLength = 100;
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(272, 20);
            this.textResult.TabIndex = 9;
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.Color.DodgerBlue;
            this.Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Check.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Check.Location = new System.Drawing.Point(5, 521);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(160, 46);
            this.Check.TabIndex = 8;
            this.Check.Text = "ПРОВЕРИТЬ";
            this.Check.UseVisualStyleBackColor = false;
            this.Check.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fwsdToolStripMenuItem,
            this.проверитьКорректностьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(474, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fwsdToolStripMenuItem
            // 
            this.fwsdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemLoad,
            this.menuItemSave,
            this.toolStripSeparator1,
            this.menuClear});
            this.fwsdToolStripMenuItem.Name = "fwsdToolStripMenuItem";
            this.fwsdToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fwsdToolStripMenuItem.Text = "Файл";
            // 
            // menuItemLoad
            // 
            this.menuItemLoad.Name = "menuItemLoad";
            this.menuItemLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menuItemLoad.Size = new System.Drawing.Size(196, 22);
            this.menuItemLoad.Text = "Загрузить";
            this.menuItemLoad.Click += new System.EventHandler(this.menuItemLoad_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItemSave.Size = new System.Drawing.Size(196, 22);
            this.menuItemSave.Text = "Сохранить";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // menuClear
            // 
            this.menuClear.Name = "menuClear";
            this.menuClear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.menuClear.Size = new System.Drawing.Size(196, 22);
            this.menuClear.Text = "Очистить поля";
            this.menuClear.Click += new System.EventHandler(this.menuClear_Click);
            // 
            // проверитьКорректностьToolStripMenuItem
            // 
            this.проверитьКорректностьToolStripMenuItem.Name = "проверитьКорректностьToolStripMenuItem";
            this.проверитьКорректностьToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.проверитьКорректностьToolStripMenuItem.Text = "Проверить корректность";
            this.проверитьКорректностьToolStripMenuItem.Click += new System.EventHandler(this.checkInputData_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Алфавит:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Состояния:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Нач. состояние:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Матрица переходов:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(281, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Результат:";
            // 
            // textAlfavit
            // 
            this.textAlfavit.Location = new System.Drawing.Point(5, 86);
            this.textAlfavit.Name = "textAlfavit";
            this.textAlfavit.Size = new System.Drawing.Size(456, 20);
            this.textAlfavit.TabIndex = 1;
            this.textAlfavit.TextChanged += new System.EventHandler(this.textAlfavit_TextChanged);
            // 
            // textStates
            // 
            this.textStates.Location = new System.Drawing.Point(5, 128);
            this.textStates.Name = "textStates";
            this.textStates.Size = new System.Drawing.Size(456, 20);
            this.textStates.TabIndex = 2;
            this.textStates.TextChanged += new System.EventHandler(this.states_TextChanged);
            // 
            // cBoxInitialState
            // 
            this.cBoxInitialState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxInitialState.FormattingEnabled = true;
            this.cBoxInitialState.Location = new System.Drawing.Point(5, 208);
            this.cBoxInitialState.Name = "cBoxInitialState";
            this.cBoxInitialState.Size = new System.Drawing.Size(121, 21);
            this.cBoxInitialState.TabIndex = 4;
            this.cBoxInitialState.SelectedIndexChanged += new System.EventHandler(this.cBoxInitialState_SelectedIndexChanged);
            this.cBoxInitialState.SelectionChangeCommitted += new System.EventHandler(this.cBoxInitialState_SelectionChangeCommitted);
            // 
            // transitionMatr
            // 
            this.transitionMatr.AllowUserToAddRows = false;
            this.transitionMatr.AllowUserToDeleteRows = false;
            this.transitionMatr.AllowUserToResizeColumns = false;
            this.transitionMatr.AllowUserToResizeRows = false;
            this.transitionMatr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.transitionMatr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transitionMatr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.transitionMatr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transitionMatr.DefaultCellStyle = dataGridViewCellStyle2;
            this.transitionMatr.Location = new System.Drawing.Point(5, 336);
            this.transitionMatr.MultiSelect = false;
            this.transitionMatr.Name = "transitionMatr";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transitionMatr.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.transitionMatr.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.transitionMatr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.transitionMatr.ShowCellToolTips = false;
            this.transitionMatr.ShowEditingIcon = false;
            this.transitionMatr.Size = new System.Drawing.Size(456, 140);
            this.transitionMatr.TabIndex = 20;
            // 
            // textGoodStates
            // 
            this.textGoodStates.Location = new System.Drawing.Point(5, 168);
            this.textGoodStates.Name = "textGoodStates";
            this.textGoodStates.Size = new System.Drawing.Size(456, 20);
            this.textGoodStates.TabIndex = 3;
            this.textGoodStates.TextChanged += new System.EventHandler(this.goodStates_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(11, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Хорошие состояния:";
            // 
            // textGoodRes
            // 
            this.textGoodRes.Location = new System.Drawing.Point(5, 248);
            this.textGoodRes.Name = "textGoodRes";
            this.textGoodRes.Size = new System.Drawing.Size(456, 20);
            this.textGoodRes.TabIndex = 5;
            this.textGoodRes.TextChanged += new System.EventHandler(this.textGoodRes_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(11, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Успешный результат:";
            // 
            // textBadRes
            // 
            this.textBadRes.Location = new System.Drawing.Point(5, 289);
            this.textBadRes.Name = "textBadRes";
            this.textBadRes.Size = new System.Drawing.Size(456, 20);
            this.textBadRes.TabIndex = 6;
            this.textBadRes.TextChanged += new System.EventHandler(this.textBadRes_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(11, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Неудачный результат:";
            // 
            // textWordToCheck
            // 
            this.textWordToCheck.Location = new System.Drawing.Point(5, 495);
            this.textWordToCheck.Name = "textWordToCheck";
            this.textWordToCheck.Size = new System.Drawing.Size(456, 20);
            this.textWordToCheck.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(11, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Слово для проверки:";
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(5, 47);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(456, 20);
            this.textDescription.TabIndex = 0;
            this.textDescription.TextChanged += new System.EventHandler(this.textDescription_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(11, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Описание автомата:";
            // 
            // Lab1
            // 
            this.AcceptButton = this.Check;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(474, 578);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textWordToCheck);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBadRes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textGoodRes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textGoodStates);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.transitionMatr);
            this.Controls.Add(this.cBoxInitialState);
            this.Controls.Add(this.textStates);
            this.Controls.Add(this.textAlfavit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lab1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конечный автомат";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transitionMatr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fwsdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAlfavit;
        private System.Windows.Forms.TextBox textStates;
        private System.Windows.Forms.ComboBox cBoxInitialState;
        private System.Windows.Forms.DataGridView transitionMatr;
        private System.Windows.Forms.TextBox textGoodStates;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textGoodRes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBadRes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textWordToCheck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuClear;
        private System.Windows.Forms.ToolStripMenuItem проверитьКорректностьToolStripMenuItem;
    }
}

