
namespace ClassRoomApp
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonExportStudents = new System.Windows.Forms.Button();
            this.buttonStudentUpdate = new System.Windows.Forms.Button();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.buttonStudentAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxThirdname = new System.Windows.Forms.TextBox();
            this.listBoxClass = new System.Windows.Forms.ListBox();
            this.dateBirthd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonExportMark = new System.Windows.Forms.Button();
            this.buttonUpdateMark = new System.Windows.Forms.Button();
            this.buttonDeleteMark = new System.Windows.Forms.Button();
            this.buttonAddMark = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMarks = new System.Windows.Forms.DataGridView();
            this.listBoxSchoolObjects = new System.Windows.Forms.ListBox();
            this.numericUpDownMark = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStudentID = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudentID)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 497);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.buttonExportStudents);
            this.tabPage1.Controls.Add(this.buttonStudentUpdate);
            this.tabPage1.Controls.Add(this.buttonDeleteStudent);
            this.tabPage1.Controls.Add(this.buttonStudentAdd);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 471);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ученики";
            // 
            // buttonExportStudents
            // 
            this.buttonExportStudents.Location = new System.Drawing.Point(607, 442);
            this.buttonExportStudents.Name = "buttonExportStudents";
            this.buttonExportStudents.Size = new System.Drawing.Size(75, 23);
            this.buttonExportStudents.TabIndex = 5;
            this.buttonExportStudents.Text = "Экспорт";
            this.buttonExportStudents.UseVisualStyleBackColor = true;
            this.buttonExportStudents.Click += new System.EventHandler(this.buttonExportStudents_Click);
            // 
            // buttonStudentUpdate
            // 
            this.buttonStudentUpdate.Location = new System.Drawing.Point(688, 442);
            this.buttonStudentUpdate.Name = "buttonStudentUpdate";
            this.buttonStudentUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonStudentUpdate.TabIndex = 4;
            this.buttonStudentUpdate.Text = "Обновить";
            this.buttonStudentUpdate.UseVisualStyleBackColor = true;
            this.buttonStudentUpdate.Click += new System.EventHandler(this.buttonStudentUpdate_Click);
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.Location = new System.Drawing.Point(88, 442);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteStudent.TabIndex = 2;
            this.buttonDeleteStudent.Text = "Удалить";
            this.buttonDeleteStudent.UseVisualStyleBackColor = true;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.buttonDeleteStudent_Click);
            // 
            // buttonStudentAdd
            // 
            this.buttonStudentAdd.Location = new System.Drawing.Point(7, 442);
            this.buttonStudentAdd.Name = "buttonStudentAdd";
            this.buttonStudentAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonStudentAdd.TabIndex = 1;
            this.buttonStudentAdd.Text = "Добавить";
            this.buttonStudentAdd.UseVisualStyleBackColor = true;
            this.buttonStudentAdd.Click += new System.EventHandler(this.buttonStudentAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxStudentID);
            this.groupBox2.Controls.Add(this.textBoxPhone);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dateBirthd);
            this.groupBox2.Controls.Add(this.listBoxClass);
            this.groupBox2.Controls.Add(this.textBoxThirdname);
            this.groupBox2.Controls.Add(this.textBoxSurname);
            this.groupBox2.Controls.Add(this.textBoxName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 177);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление данными";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewStudent);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные об учениках";
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.Size = new System.Drawing.Size(744, 223);
            this.dataGridViewStudent.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.buttonExportMark);
            this.tabPage2.Controls.Add(this.buttonUpdateMark);
            this.tabPage2.Controls.Add(this.buttonDeleteMark);
            this.tabPage2.Controls.Add(this.buttonAddMark);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 471);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оценки";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(768, 471);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Учителя";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(768, 471);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Льготы и пособия";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(112, 17);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(112, 43);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.textBoxSurname.TabIndex = 2;
            // 
            // textBoxThirdname
            // 
            this.textBoxThirdname.Location = new System.Drawing.Point(112, 69);
            this.textBoxThirdname.Name = "textBoxThirdname";
            this.textBoxThirdname.Size = new System.Drawing.Size(100, 20);
            this.textBoxThirdname.TabIndex = 3;
            // 
            // listBoxClass
            // 
            this.listBoxClass.FormattingEnabled = true;
            this.listBoxClass.Items.AddRange(new object[] {
            "1 А",
            "1 Б",
            "1 В",
            "2 А",
            "2 Б",
            "2 В",
            "3 А",
            "3 Б",
            "3 В",
            "4 А",
            "4 Б",
            "4 В",
            "5 А",
            "5 Б",
            "5 В",
            "6 А",
            "6 Б",
            "6 В",
            "7 А",
            "7 Б",
            "7 В",
            "8 А",
            "8 Б",
            "8 В",
            "9 А",
            "9 Б",
            "10 А",
            "11 А"});
            this.listBoxClass.Location = new System.Drawing.Point(287, 72);
            this.listBoxClass.Name = "listBoxClass";
            this.listBoxClass.Size = new System.Drawing.Size(120, 30);
            this.listBoxClass.TabIndex = 5;
            // 
            // dateBirthd
            // 
            this.dateBirthd.Location = new System.Drawing.Point(237, 43);
            this.dateBirthd.Name = "dateBirthd";
            this.dateBirthd.Size = new System.Drawing.Size(170, 20);
            this.dateBirthd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Класс :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата рождения :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Номер телефона :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Отчество :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Фамилия : ";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(112, 95);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhone.TabIndex = 12;
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(112, 146);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentID.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Идентификатор : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "(для удаления)";
            // 
            // buttonExportMark
            // 
            this.buttonExportMark.Location = new System.Drawing.Point(606, 441);
            this.buttonExportMark.Name = "buttonExportMark";
            this.buttonExportMark.Size = new System.Drawing.Size(75, 23);
            this.buttonExportMark.TabIndex = 11;
            this.buttonExportMark.Text = "Экспорт";
            this.buttonExportMark.UseVisualStyleBackColor = true;
            this.buttonExportMark.Click += new System.EventHandler(this.buttonExportMark_Click);
            // 
            // buttonUpdateMark
            // 
            this.buttonUpdateMark.Location = new System.Drawing.Point(689, 441);
            this.buttonUpdateMark.Name = "buttonUpdateMark";
            this.buttonUpdateMark.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateMark.TabIndex = 10;
            this.buttonUpdateMark.Text = "Обновить";
            this.buttonUpdateMark.UseVisualStyleBackColor = true;
            this.buttonUpdateMark.Click += new System.EventHandler(this.buttonUpdateMark_Click);
            // 
            // buttonDeleteMark
            // 
            this.buttonDeleteMark.Location = new System.Drawing.Point(87, 441);
            this.buttonDeleteMark.Name = "buttonDeleteMark";
            this.buttonDeleteMark.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteMark.TabIndex = 9;
            this.buttonDeleteMark.Text = "Удалить";
            this.buttonDeleteMark.UseVisualStyleBackColor = true;
            this.buttonDeleteMark.Click += new System.EventHandler(this.buttonDeleteMark_Click);
            // 
            // buttonAddMark
            // 
            this.buttonAddMark.Location = new System.Drawing.Point(6, 441);
            this.buttonAddMark.Name = "buttonAddMark";
            this.buttonAddMark.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMark.TabIndex = 7;
            this.buttonAddMark.Text = "Добавить";
            this.buttonAddMark.UseVisualStyleBackColor = true;
            this.buttonAddMark.Click += new System.EventHandler(this.buttonAddMark_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.numericUpDownStudentID);
            this.groupBox3.Controls.Add(this.numericUpDownMark);
            this.groupBox3.Controls.Add(this.listBoxSchoolObjects);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(7, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(756, 172);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление данными";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Оценка : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Идентификатор* :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewMarks);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(756, 248);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Данные об оценках";
            // 
            // dataGridViewMarks
            // 
            this.dataGridViewMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarks.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewMarks.Name = "dataGridViewMarks";
            this.dataGridViewMarks.Size = new System.Drawing.Size(744, 223);
            this.dataGridViewMarks.TabIndex = 0;
            // 
            // listBoxSchoolObjects
            // 
            this.listBoxSchoolObjects.FormattingEnabled = true;
            this.listBoxSchoolObjects.Items.AddRange(new object[] {
            "Русский язык",
            "Литература",
            "Математика",
            "Информатика",
            "Алгебра",
            "Геометрия",
            "Черчение",
            "Изобразительное искусство",
            "Биология",
            "Физкультура",
            "История России",
            "Всеобщая история",
            "Астрономия",
            "Физика",
            "География",
            "Иностранный язык",
            "Технология",
            "Химия",
            "Музыка",
            "ОБЖ"});
            this.listBoxSchoolObjects.Location = new System.Drawing.Point(219, 44);
            this.listBoxSchoolObjects.Name = "listBoxSchoolObjects";
            this.listBoxSchoolObjects.Size = new System.Drawing.Size(178, 108);
            this.listBoxSchoolObjects.TabIndex = 12;
            // 
            // numericUpDownMark
            // 
            this.numericUpDownMark.Location = new System.Drawing.Point(112, 44);
            this.numericUpDownMark.Name = "numericUpDownMark";
            this.numericUpDownMark.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownMark.TabIndex = 13;
            this.numericUpDownMark.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDownStudentID
            // 
            this.numericUpDownStudentID.Location = new System.Drawing.Point(112, 18);
            this.numericUpDownStudentID.Name = "numericUpDownStudentID";
            this.numericUpDownStudentID.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownStudentID.TabIndex = 14;
            this.numericUpDownStudentID.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(9, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(529, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "Идентификатор ученика можно узнать во вкладке \"Ученики\". Для удаления оценки испо" +
    "льзовать идентификатор оценки!";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Предмет :";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Main";
            this.Text = "Программый комплекс учета учебного процесса \"ЭЛЕКТРОННАЯ ШКОЛА\"";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudentID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonExportStudents;
        private System.Windows.Forms.Button buttonStudentUpdate;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.Button buttonStudentAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateBirthd;
        private System.Windows.Forms.ListBox listBoxClass;
        private System.Windows.Forms.TextBox textBoxThirdname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExportMark;
        private System.Windows.Forms.Button buttonUpdateMark;
        private System.Windows.Forms.Button buttonDeleteMark;
        private System.Windows.Forms.Button buttonAddMark;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDownMark;
        private System.Windows.Forms.ListBox listBoxSchoolObjects;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewMarks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownStudentID;
    }
}

