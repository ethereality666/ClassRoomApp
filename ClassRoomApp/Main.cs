using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClassRoomApp {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
            UpdateStudentInfo();
			UpdateMarksInfo();
		}
		private void exportData(DataGridView dataGrid) {
			Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
			Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
			Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
			ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
			ExcelWorkSheet = ExcelWorkBook.Worksheets.get_Item(1) as Microsoft.Office.Interop.Excel.Worksheet;
			for (int i = 0; i < dataGrid.Rows.Count; i++)
			{
				for (int j = 0; j < dataGrid.ColumnCount; j++)
				{
					ExcelApp.Cells[i + 1, j + 1] = dataGrid.Rows[i].Cells[j].Value;
				}
			}
			ExcelApp.Visible = true;
			ExcelApp.UserControl = true;
		}
		private void UpdateStudentInfo() {
			ConnectionClass connection = new ConnectionClass();
			MySqlCommand mySqlCommand = new MySqlCommand("SELECT * from `students`,`classes` where `students`.classid = `classes`.id", connection.GetConnection());
			try {
				connection.OpenConnection();
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				dataGridViewStudent.Columns.Add("id", "Идентификатор");
				dataGridViewStudent.Columns.Add("firstname", "Имя");
				dataGridViewStudent.Columns.Add("secondname", "Фамилия");
				dataGridViewStudent.Columns.Add("thirdname", "Отчество");
				dataGridViewStudent.Columns.Add("birthday", "Дата рождения");
				dataGridViewStudent.Columns.Add("name", "Класс");
				dataGridViewStudent.Columns.Add("nubmerPhone", "Номер телефона");
				while (mySqlDataReader.Read()) {
					dataGridViewStudent.Rows.Add(mySqlDataReader["id"].ToString(), mySqlDataReader["firstname"].ToString(), mySqlDataReader["secondname"].ToString(), 
						mySqlDataReader["thirdname"].ToString(), mySqlDataReader["birthday"].ToString(),
						mySqlDataReader["name"].ToString(), mySqlDataReader["nubmerPhone"].ToString());
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString(), "Ошибка!");
			}
			finally {
				connection.CloseConnection();
			}
		}
		private void UpdateMarksInfo()
        {
			ConnectionClass connection = new ConnectionClass();
			MySqlCommand mySqlCommand = new MySqlCommand("SELECT * from `marks`,`shcoolsubjects`,`students` where `shcoolsubjects`.id = `marks`.subjectid and `students`.id=`marks`.studentid;", connection.GetConnection());
            try {
				connection.OpenConnection();
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				dataGridViewMarks.Columns.Add("id", "Идентификатор оценки");
				dataGridViewMarks.Columns.Add("firstname", "Имя");
				dataGridViewMarks.Columns.Add("secondname", "Фамилия");
				dataGridViewMarks.Columns.Add("thirdname", "Отчество");
				dataGridViewMarks.Columns.Add("name", "Предмет");
				dataGridViewMarks.Columns.Add("mark", "Оценка");
				while (mySqlDataReader.Read()) {
					dataGridViewMarks.Rows.Add(mySqlDataReader["id"].ToString(), mySqlDataReader["firstname"].ToString(), mySqlDataReader["secondname"].ToString(), mySqlDataReader["thirdname"].ToString(),
						 mySqlDataReader["name"].ToString(), mySqlDataReader["mark"].ToString());
				}
			} catch (Exception ex){
				MessageBox.Show(ex.ToString(),"Ошибка");
			} finally {
				connection.CloseConnection();
            }
		}
		private void buttonStudentUpdate_Click(object sender, EventArgs e) {
			dataGridViewStudent.Columns.Remove("id"); 
			dataGridViewStudent.Columns.Remove("firstname"); 
			dataGridViewStudent.Columns.Remove("secondname");
			dataGridViewStudent.Columns.Remove("thirdname");
			dataGridViewStudent.Columns.Remove("birthday");
			dataGridViewStudent.Columns.Remove("name");
			dataGridViewStudent.Columns.Remove("nubmerPhone");
			UpdateStudentInfo();
			MessageBox.Show("Информация успешно обновлена","Информация");
		}
        private void buttonStudentAdd_Click(object sender, EventArgs e)
        {
			ConnectionClass connection = new ConnectionClass();
			dateBirthd.CustomFormat = "yyyy-MM-dd";
			dateBirthd.Format = DateTimePickerFormat.Custom;
			int ClassID = 0;
			switch(listBoxClass.SelectedItem) {
				case "1 А":
					ClassID = 1;
					break;
				case "1 Б":
					ClassID = 2;
					break;
				case "1 В":
					ClassID = 3;
					break;
				case "2 А":
					ClassID = 4;
					break;
				case "2 Б":
					ClassID = 5;
					break;
				case "2 В":
					ClassID = 6;
					break;
				case "3 А":
					ClassID = 7;
					break;
				case "3 Б":
					ClassID = 8;
					break;
				case "3 В":
					ClassID = 9;
					break;
				case "4 А":
					ClassID = 10;
					break;
				case "4 Б":
					ClassID = 11;
					break;
				case "4 В":
					ClassID = 12;
					break;
				case "5 А":
					ClassID = 13;
					break;
				case "5 Б":
					ClassID = 14;
					break;
				case "5 В":
					ClassID = 15;
					break;
				case "6 А":
					ClassID = 16;
					break;
				case "6 Б":
					ClassID = 17;
					break;
				case "6 В":
					ClassID = 18;
					break;
				case "7 А":
					ClassID = 19;
					break;
				case "7 Б":
					ClassID = 20;
					break;
				case "7 В":
					ClassID = 21;
					break;
				case "8 А":
					ClassID = 22;
					break;
				case "8 Б":
					ClassID = 23;
					break;
				case "8 В":
					ClassID = 24;
					break;
				case "9 А":
					ClassID = 25;
					break;
				case "9 Б":
					ClassID = 26;
					break;
				case "10 А":
					ClassID = 27;
					break;
				case "11 А":
					ClassID = 28;
					break;
			}
			try
			{
				connection.OpenConnection();
				string command_string = "INSERT INTO `db`.`students` (`firstname`, `secondname`, `thirdname`, `Birthday`, `classid`, `nubmerPhone`) " +
					"VALUES (@firstname, @secondname, @thirdname, @Birthday, @classid, @nubmerPhone);";
				MySqlCommand mySqlCommand = new MySqlCommand(command_string, connection.GetConnection());
					mySqlCommand.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = textBoxName.Text;
					mySqlCommand.Parameters.Add("@secondname", MySqlDbType.VarChar).Value = textBoxSurname.Text;
					mySqlCommand.Parameters.Add("@thirdname", MySqlDbType.VarChar).Value = textBoxThirdname.Text;
					mySqlCommand.Parameters.Add("@Birthday", MySqlDbType.Date).Value = dateBirthd.Value;
					mySqlCommand.Parameters.Add("@classid", MySqlDbType.Int32).Value = Convert.ToInt32(ClassID);
					mySqlCommand.Parameters.Add("@nubmerPhone", MySqlDbType.VarChar).Value = textBoxPhone.Text;
				if (mySqlCommand.ExecuteNonQuery() == 1) 
					MessageBox.Show("Запись успешно добавлена", "Успешно");
				else 
					MessageBox.Show("Что-то пошло не так!", "Ошибка!");
				
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			finally {
				connection.CloseConnection();
			}
		}
		private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
			ConnectionClass connection = new ConnectionClass();
			try {
				connection.OpenConnection();
				string command_string = "DELETE FROM `db`.`students` WHERE (`ID` = @ID);";
				MySqlCommand mySqlCommand = new MySqlCommand(command_string, connection.GetConnection());
				mySqlCommand.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Convert.ToInt32(textBoxStudentID.Text);		
				if (mySqlCommand.ExecuteNonQuery() == 1)
					MessageBox.Show("Запись успешно удалена", "Успешно");
				else
					MessageBox.Show("Что-то пошло не так!", "Ошибка!");
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			finally {
				connection.CloseConnection();
			}
		}
        private void buttonExportStudents_Click(object sender, EventArgs e) {
			exportData(dataGridViewStudent);
		}
        private void buttonAddMark_Click(object sender, EventArgs e)
        {
			int subjectId;
			ConnectionClass connection = new ConnectionClass();
			DataTable dataTable = new DataTable();
			MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
			switch (listBoxSchoolObjects.SelectedItem) {
				case "Русский язык":
					subjectId = 1;
					break;
				case "Литература":
					subjectId = 2;
					break;
				case "Математика":
					subjectId = 3;
					break;
				case "Информатика":
					subjectId = 4;
					break;
				case "Алгебра":
					subjectId = 5;
					break;
				case "Геометрия":
					subjectId = 6;
					break;
				case "Черчение":
					subjectId = 7;
					break;
				case "ИЗО":
					subjectId = 8;
					break;
				case "Биология":
					subjectId = 9;
					break;
				case "Физкультура":
					subjectId = 10;
					break;
				case "История России":
					subjectId = 11;
					break;
				case "Всеобщая история":
					subjectId = 12;
					break;
				case "Астрономия":
					subjectId = 13;
					break;
				case "Физика":
					subjectId = 14;
					break;
				case "География":
					subjectId = 15;
					break;
				case "Иностранный язык":
					subjectId = 16;
					break;
				case "Технология":
					subjectId = 17;
					break;
				case "Химия":
					subjectId = 18;
					break;
				case "Музыка":
					subjectId = 19;
					break;
				case "ОБЖ":
					subjectId = 20;
					break;
				default:
					subjectId = 0;
					break;
			}
			object StudentId;
			string command_string_id = "SELECT id from `students` WHERE `id`=@id;";
			MySqlCommand sqlCommand = new MySqlCommand(command_string_id, connection.GetConnection());
			sqlCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = numericUpDownStudentID.Value;
			try {
				connection.OpenConnection();
				dataAdapter.SelectCommand = sqlCommand;
				dataAdapter.Fill(dataTable);
				if (dataTable.Rows.Count == 1) {
					StudentId = dataTable.Rows[0]["id"].ToString();
					string command_string = "INSERT INTO `db`.`marks` (`Mark`, `StudentID`, `SubjectID`) VALUES (@mark, @studentid, @subjectid);";
					MySqlCommand mySqlCommand = new MySqlCommand(command_string, connection.GetConnection());
					mySqlCommand.Parameters.Add("@mark", MySqlDbType.Int32).Value = numericUpDownMark.Value;
					mySqlCommand.Parameters.Add("@studentid", MySqlDbType.Int32).Value = StudentId;
					mySqlCommand.Parameters.Add("@subjectid", MySqlDbType.Int32).Value = subjectId;
					if (mySqlCommand.ExecuteNonQuery() == 1) 
						MessageBox.Show("Запись успешно добавлена", "Успешно");
					else 
						MessageBox.Show("Что-то пошло не так!", "Ошибка!");
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			finally {
				connection.CloseConnection();
			}
		}
		private void buttonDeleteMark_Click(object sender, EventArgs e)
        {
			ConnectionClass connection = new ConnectionClass();
			try {
				connection.OpenConnection();
				string command_string = "DELETE FROM `db`.`marks` WHERE (`ID` = @ID);";
				MySqlCommand mySqlCommand = new MySqlCommand(command_string, connection.GetConnection());
				mySqlCommand.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Convert.ToInt32(numericUpDownStudentID.Text);
				if (mySqlCommand.ExecuteNonQuery() == 1)
					MessageBox.Show("Запись успешно удалена", "Успешно");
				else
					MessageBox.Show("Что-то пошло не так!", "Ошибка!");
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			finally {
				connection.CloseConnection();
			}
		}
        private void buttonExportMark_Click(object sender, EventArgs e) {
			exportData(dataGridViewMarks);
        }

        private void buttonUpdateMark_Click(object sender, EventArgs e) {
			dataGridViewMarks.Columns.Remove("id");
			dataGridViewMarks.Columns.Remove("firstname");
			dataGridViewMarks.Columns.Remove("secondname");
			dataGridViewMarks.Columns.Remove("thirdname");
			dataGridViewMarks.Columns.Remove("name");
			dataGridViewMarks.Columns.Remove("mark");
			UpdateMarksInfo();
		}
    }
}
