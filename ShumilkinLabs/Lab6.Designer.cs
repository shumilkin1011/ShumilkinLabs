namespace ShumilkinLabs
{
    partial class Lab6
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab6));
            this.Start = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fwsdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.checkDataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNeterms = new System.Windows.Forms.TextBox();
            this.textTerms = new System.Windows.Forms.TextBox();
            this.actionMatrix = new System.Windows.Forms.DataGridView();
            this.textWordToCheck = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gotoMatrix = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textStatesNumb = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClearList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textNewRule = new System.Windows.Forms.TextBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.lstRules = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gotoMatrix)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.DodgerBlue;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Start.Location = new System.Drawing.Point(6, 463);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(497, 46);
            this.Start.TabIndex = 8;
            this.Start.Text = "СТАРТ";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fwsdToolStripMenuItem,
            this.checkDataMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
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
            // checkDataMenuItem
            // 
            this.checkDataMenuItem.Name = "checkDataMenuItem";
            this.checkDataMenuItem.Size = new System.Drawing.Size(157, 20);
            this.checkDataMenuItem.Text = "Проверить корректность";
            this.checkDataMenuItem.Click += new System.EventHandler(this.checkDataMenuItem_Click);
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
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Нетерминалы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Терминалы";
            // 
            // textNeterms
            // 
            this.textNeterms.Location = new System.Drawing.Point(6, 61);
            this.textNeterms.Name = "textNeterms";
            this.textNeterms.Size = new System.Drawing.Size(456, 20);
            this.textNeterms.TabIndex = 1;
            this.textNeterms.TextChanged += new System.EventHandler(this.textNeterms_TextChanged);
            // 
            // textTerms
            // 
            this.textTerms.Location = new System.Drawing.Point(6, 100);
            this.textTerms.Name = "textTerms";
            this.textTerms.Size = new System.Drawing.Size(456, 20);
            this.textTerms.TabIndex = 2;
            this.textTerms.TextChanged += new System.EventHandler(this.textTerms_TextChanged);
            // 
            // actionMatrix
            // 
            this.actionMatrix.AllowUserToAddRows = false;
            this.actionMatrix.AllowUserToDeleteRows = false;
            this.actionMatrix.AllowUserToResizeColumns = false;
            this.actionMatrix.AllowUserToResizeRows = false;
            this.actionMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.actionMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.actionMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.actionMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.actionMatrix.DefaultCellStyle = dataGridViewCellStyle2;
            this.actionMatrix.Location = new System.Drawing.Point(14, 172);
            this.actionMatrix.MultiSelect = false;
            this.actionMatrix.Name = "actionMatrix";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.actionMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.actionMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.actionMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.actionMatrix.ShowCellToolTips = false;
            this.actionMatrix.ShowEditingIcon = false;
            this.actionMatrix.Size = new System.Drawing.Size(217, 199);
            this.actionMatrix.TabIndex = 20;
            // 
            // textWordToCheck
            // 
            this.textWordToCheck.Location = new System.Drawing.Point(7, 394);
            this.textWordToCheck.Name = "textWordToCheck";
            this.textWordToCheck.Size = new System.Drawing.Size(456, 20);
            this.textWordToCheck.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(11, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Слово для проверки:";
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(7, 19);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(456, 20);
            this.textDescription.TabIndex = 0;
            this.textDescription.TextChanged += new System.EventHandler(this.textDescription_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(11, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Описание  грамматики";
            // 
            // gotoMatrix
            // 
            this.gotoMatrix.AllowUserToAddRows = false;
            this.gotoMatrix.AllowUserToDeleteRows = false;
            this.gotoMatrix.AllowUserToResizeColumns = false;
            this.gotoMatrix.AllowUserToResizeRows = false;
            this.gotoMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gotoMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gotoMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gotoMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gotoMatrix.DefaultCellStyle = dataGridViewCellStyle5;
            this.gotoMatrix.Location = new System.Drawing.Point(240, 172);
            this.gotoMatrix.MultiSelect = false;
            this.gotoMatrix.Name = "gotoMatrix";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gotoMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gotoMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gotoMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gotoMatrix.ShowCellToolTips = false;
            this.gotoMatrix.ShowEditingIcon = false;
            this.gotoMatrix.Size = new System.Drawing.Size(217, 199);
            this.gotoMatrix.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Количество состояний";
            // 
            // textStatesNumb
            // 
            this.textStatesNumb.Location = new System.Drawing.Point(6, 141);
            this.textStatesNumb.Name = "textStatesNumb";
            this.textStatesNumb.Size = new System.Drawing.Size(458, 20);
            this.textStatesNumb.TabIndex = 32;
            this.textStatesNumb.TextChanged += new System.EventHandler(this.textStatesNumb_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(6, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textStatesNumb);
            this.splitContainer1.Panel1.Controls.Add(this.textTerms);
            this.splitContainer1.Panel1.Controls.Add(this.textWordToCheck);
            this.splitContainer1.Panel1.Controls.Add(this.gotoMatrix);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.textNeterms);
            this.splitContainer1.Panel1.Controls.Add(this.textDescription);
            this.splitContainer1.Panel1.Controls.Add(this.actionMatrix);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.btnClearList);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.textNewRule);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddToList);
            this.splitContainer1.Panel2.Controls.Add(this.lstRules);
            this.splitContainer1.Panel2MinSize = 15;
            this.splitContainer1.Size = new System.Drawing.Size(499, 424);
            this.splitContainer1.SplitterDistance = 479;
            this.splitContainer1.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Список правил для грамматики G:";
            // 
            // btnClearList
            // 
            this.btnClearList.BackColor = System.Drawing.Color.Red;
            this.btnClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearList.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClearList.Location = new System.Drawing.Point(150, 44);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(142, 35);
            this.btnClearList.TabIndex = 4;
            this.btnClearList.Text = "Очистить список";
            this.btnClearList.UseVisualStyleBackColor = false;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Введите новое правило граматики:";
            // 
            // textNewRule
            // 
            this.textNewRule.Location = new System.Drawing.Point(3, 20);
            this.textNewRule.Name = "textNewRule";
            this.textNewRule.Size = new System.Drawing.Size(289, 20);
            this.textNewRule.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textNewRule, "E -> B|C|ad");
            // 
            // btnAddToList
            // 
            this.btnAddToList.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToList.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddToList.Location = new System.Drawing.Point(3, 44);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(142, 35);
            this.btnAddToList.TabIndex = 1;
            this.btnAddToList.Text = "Добавить в список";
            this.btnAddToList.UseVisualStyleBackColor = false;
            this.btnAddToList.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstRules
            // 
            this.lstRules.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstRules.FormattingEnabled = true;
            this.lstRules.ItemHeight = 20;
            this.lstRules.Location = new System.Drawing.Point(0, 98);
            this.lstRules.Name = "lstRules";
            this.lstRules.Size = new System.Drawing.Size(14, 324);
            this.lstRules.TabIndex = 0;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Пример ввода:";
            // 
            // Lab6
            // 
            this.AcceptButton = this.Start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(515, 515);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lab6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Нисх. синт. анализатор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gotoMatrix)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MenuItemLoad_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fwsdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNeterms;
        private System.Windows.Forms.TextBox textTerms;
        private System.Windows.Forms.DataGridView actionMatrix;
        private System.Windows.Forms.TextBox textWordToCheck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuClear;
        private System.Windows.Forms.ToolStripMenuItem checkDataMenuItem;
        private System.Windows.Forms.DataGridView gotoMatrix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textStatesNumb;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNewRule;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.ListBox lstRules;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.Label label5;
    }
}

