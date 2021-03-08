namespace ShumilkinLabs
{
    partial class Lab4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab6));
            this.Check = new System.Windows.Forms.Button();
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
            this.label3 = new System.Windows.Forms.Label();
            this.textNeterms = new System.Windows.Forms.TextBox();
            this.textTerms = new System.Windows.Forms.TextBox();
            this.cBoxInitialNeterm = new System.Windows.Forms.ComboBox();
            this.transitionMatr = new System.Windows.Forms.DataGridView();
            this.textWordToCheck = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transitionMatr)).BeginInit();
            this.SuspendLayout();
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.Color.DodgerBlue;
            this.Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Check.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Check.Location = new System.Drawing.Point(6, 449);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(457, 46);
            this.Check.TabIndex = 8;
            this.Check.Text = "СТАРТ";
            this.Check.UseVisualStyleBackColor = false;
            this.Check.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fwsdToolStripMenuItem,
            this.checkDataMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(476, 24);
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
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Нетерминалы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Терминалы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Нач. нетерминал";
            // 
            // textNeterms
            // 
            this.textNeterms.Location = new System.Drawing.Point(6, 86);
            this.textNeterms.Name = "textNeterms";
            this.textNeterms.Size = new System.Drawing.Size(456, 20);
            this.textNeterms.TabIndex = 1;
            this.textNeterms.TextChanged += new System.EventHandler(this.textNeterms_TextChanged);
            // 
            // textTerms
            // 
            this.textTerms.Location = new System.Drawing.Point(6, 128);
            this.textTerms.Name = "textTerms";
            this.textTerms.Size = new System.Drawing.Size(456, 20);
            this.textTerms.TabIndex = 2;
            this.textTerms.TextChanged += new System.EventHandler(this.textTerms_TextChanged);
            // 
            // cBoxInitialNeterm
            // 
            this.cBoxInitialNeterm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxInitialNeterm.FormattingEnabled = true;
            this.cBoxInitialNeterm.Location = new System.Drawing.Point(6, 168);
            this.cBoxInitialNeterm.Name = "cBoxInitialNeterm";
            this.cBoxInitialNeterm.Size = new System.Drawing.Size(121, 21);
            this.cBoxInitialNeterm.TabIndex = 4;
            this.cBoxInitialNeterm.SelectedIndexChanged += new System.EventHandler(this.cBoxInitialState_SelectedIndexChanged);
            // 
            // transitionMatr
            // 
            this.transitionMatr.AllowUserToAddRows = false;
            this.transitionMatr.AllowUserToDeleteRows = false;
            this.transitionMatr.AllowUserToResizeColumns = false;
            this.transitionMatr.AllowUserToResizeRows = false;
            this.transitionMatr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.transitionMatr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
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
            this.transitionMatr.Location = new System.Drawing.Point(7, 195);
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
            this.transitionMatr.Size = new System.Drawing.Size(456, 199);
            this.transitionMatr.TabIndex = 20;
            // 
            // textWordToCheck
            // 
            this.textWordToCheck.Location = new System.Drawing.Point(7, 423);
            this.textWordToCheck.Name = "textWordToCheck";
            this.textWordToCheck.Size = new System.Drawing.Size(456, 20);
            this.textWordToCheck.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Слово для проверки:";
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(7, 47);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(456, 20);
            this.textDescription.TabIndex = 0;
            this.textDescription.TextChanged += new System.EventHandler(this.textDescription_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Описание  грамматики";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(158, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Символ лямбды можно взять здесь -->";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(404, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(57, 35);
            this.textBox1.TabIndex = 31;
            this.textBox1.Text = "λ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(161, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "(или просто кликните СЮДА)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Lab4
            // 
            this.AcceptButton = this.Check;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(476, 500);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textWordToCheck);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.transitionMatr);
            this.Controls.Add(this.cBoxInitialNeterm);
            this.Controls.Add(this.textTerms);
            this.Controls.Add(this.textNeterms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lab4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Нисх. синт. анализатор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transitionMatr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void MenuItemLoad_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
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
        private System.Windows.Forms.TextBox textNeterms;
        private System.Windows.Forms.TextBox textTerms;
        private System.Windows.Forms.ComboBox cBoxInitialNeterm;
        private System.Windows.Forms.DataGridView transitionMatr;
        private System.Windows.Forms.TextBox textWordToCheck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuClear;
        private System.Windows.Forms.ToolStripMenuItem checkDataMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}

