using System.Windows.Forms;

namespace ShumilkinLabs
{
    partial class Lab2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab2));
            this.Transform = new System.Windows.Forms.Button();
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
            this.textAlfavit = new System.Windows.Forms.TextBox();
            this.textStates = new System.Windows.Forms.TextBox();
            this.cBoxInitialState = new System.Windows.Forms.ComboBox();
            this.transitionMatr = new System.Windows.Forms.DataGridView();
            this.textGoodStates = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textGoodStatesDet = new System.Windows.Forms.TextBox();
            this.transitionMatrDet = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cBoxInitialStateDet = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textStatesDet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textAlfavitDet = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transitionMatr)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transitionMatrDet)).BeginInit();
            this.SuspendLayout();
            // 
            // Transform
            // 
            this.Transform.BackColor = System.Drawing.Color.DodgerBlue;
            this.Transform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Transform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Transform.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Transform.Location = new System.Drawing.Point(253, 426);
            this.Transform.Name = "Transform";
            this.Transform.Size = new System.Drawing.Size(324, 46);
            this.Transform.TabIndex = 8;
            this.Transform.Text = "ПРЕОБРАЗОВАТЬ";
            this.Transform.UseVisualStyleBackColor = false;
            this.Transform.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fwsdToolStripMenuItem,
            this.проверитьКорректностьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 24);
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
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Алфавит:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Состояния:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Нач. состояние:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Матрица переходов:";
            // 
            // textAlfavit
            // 
            this.textAlfavit.Location = new System.Drawing.Point(6, 67);
            this.textAlfavit.Name = "textAlfavit";
            this.textAlfavit.Size = new System.Drawing.Size(396, 20);
            this.textAlfavit.TabIndex = 1;
            this.textAlfavit.TextChanged += new System.EventHandler(this.textAlfavit_TextChanged);
            // 
            // textStates
            // 
            this.textStates.Location = new System.Drawing.Point(6, 109);
            this.textStates.Name = "textStates";
            this.textStates.Size = new System.Drawing.Size(396, 20);
            this.textStates.TabIndex = 2;
            this.textStates.TextChanged += new System.EventHandler(this.states_TextChanged);
            // 
            // cBoxInitialState
            // 
            this.cBoxInitialState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxInitialState.FormattingEnabled = true;
            this.cBoxInitialState.Location = new System.Drawing.Point(6, 189);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.transitionMatr.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.transitionMatr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.transitionMatr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transitionMatr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.transitionMatr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transitionMatr.DefaultCellStyle = dataGridViewCellStyle3;
            this.transitionMatr.Location = new System.Drawing.Point(6, 236);
            this.transitionMatr.MultiSelect = false;
            this.transitionMatr.Name = "transitionMatr";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transitionMatr.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.transitionMatr.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transitionMatr.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.transitionMatr.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.transitionMatr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.transitionMatr.ShowCellErrors = false;
            this.transitionMatr.ShowCellToolTips = false;
            this.transitionMatr.ShowEditingIcon = false;
            this.transitionMatr.ShowRowErrors = false;
            this.transitionMatr.Size = new System.Drawing.Size(396, 178);
            this.transitionMatr.TabIndex = 20;
            // 
            // textGoodStates
            // 
            this.textGoodStates.Location = new System.Drawing.Point(6, 149);
            this.textGoodStates.Name = "textGoodStates";
            this.textGoodStates.Size = new System.Drawing.Size(396, 20);
            this.textGoodStates.TabIndex = 3;
            this.textGoodStates.TextChanged += new System.EventHandler(this.goodStates_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Хорошие состояния:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 391);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Недетерминированный К.А.";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.textGoodStatesDet);
            this.groupBox2.Controls.Add(this.transitionMatrDet);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cBoxInitialStateDet);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textStatesDet);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textAlfavitDet);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(419, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 391);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Детерминированный К.А.";
            // 
            // textGoodStatesDet
            // 
            this.textGoodStatesDet.Location = new System.Drawing.Point(8, 120);
            this.textGoodStatesDet.Name = "textGoodStatesDet";
            this.textGoodStatesDet.ReadOnly = true;
            this.textGoodStatesDet.Size = new System.Drawing.Size(396, 23);
            this.textGoodStatesDet.TabIndex = 34;
            // 
            // transitionMatrDet
            // 
            this.transitionMatrDet.AllowUserToAddRows = false;
            this.transitionMatrDet.AllowUserToDeleteRows = false;
            this.transitionMatrDet.AllowUserToResizeColumns = false;
            this.transitionMatrDet.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.transitionMatrDet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.transitionMatrDet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.transitionMatrDet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transitionMatrDet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.transitionMatrDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transitionMatrDet.DefaultCellStyle = dataGridViewCellStyle8;
            this.transitionMatrDet.Location = new System.Drawing.Point(8, 207);
            this.transitionMatrDet.MultiSelect = false;
            this.transitionMatrDet.Name = "transitionMatrDet";
            this.transitionMatrDet.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transitionMatrDet.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.transitionMatrDet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transitionMatrDet.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.transitionMatrDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.transitionMatrDet.ShowCellErrors = false;
            this.transitionMatrDet.ShowCellToolTips = false;
            this.transitionMatrDet.ShowEditingIcon = false;
            this.transitionMatrDet.ShowRowErrors = false;
            this.transitionMatrDet.Size = new System.Drawing.Size(396, 178);
            this.transitionMatrDet.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(14, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Хорошие состояния:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(14, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Алфавит:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(14, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Состояния:";
            // 
            // cBoxInitialStateDet
            // 
            this.cBoxInitialStateDet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxInitialStateDet.FormattingEnabled = true;
            this.cBoxInitialStateDet.Location = new System.Drawing.Point(8, 160);
            this.cBoxInitialStateDet.Name = "cBoxInitialStateDet";
            this.cBoxInitialStateDet.Size = new System.Drawing.Size(121, 24);
            this.cBoxInitialStateDet.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label8.Location = new System.Drawing.Point(14, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Нач. состояние:";
            // 
            // textStatesDet
            // 
            this.textStatesDet.Location = new System.Drawing.Point(8, 80);
            this.textStatesDet.Name = "textStatesDet";
            this.textStatesDet.ReadOnly = true;
            this.textStatesDet.Size = new System.Drawing.Size(396, 23);
            this.textStatesDet.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(14, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Матрица переходов:";
            // 
            // textAlfavitDet
            // 
            this.textAlfavitDet.Location = new System.Drawing.Point(8, 38);
            this.textAlfavitDet.Name = "textAlfavitDet";
            this.textAlfavitDet.ReadOnly = true;
            this.textAlfavitDet.Size = new System.Drawing.Size(396, 23);
            this.textAlfavitDet.TabIndex = 32;
            // 
            // Lab2
            // 
            this.AcceptButton = this.Transform;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 475);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textGoodStates);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.transitionMatr);
            this.Controls.Add(this.cBoxInitialState);
            this.Controls.Add(this.textStates);
            this.Controls.Add(this.textAlfavit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Transform);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Lab2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Преобразование НДКА в ДКА";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transitionMatr)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transitionMatrDet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Transform;
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
        private System.Windows.Forms.TextBox textAlfavit;
        private System.Windows.Forms.TextBox textStates;
        private System.Windows.Forms.ComboBox cBoxInitialState;
        private System.Windows.Forms.DataGridView transitionMatr;
        private System.Windows.Forms.TextBox textGoodStates;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuClear;
        private System.Windows.Forms.ToolStripMenuItem проверитьКорректностьToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textGoodStatesDet;
        private System.Windows.Forms.DataGridView transitionMatrDet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBoxInitialStateDet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textStatesDet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textAlfavitDet;
    }
}

