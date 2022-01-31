using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassRoomApp {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
            updateStudentInfo();
        }

		void exportData(DataGridView dataGrid) {
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
		private void updateStudentInfo() {
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
				while (mySqlDataReader.Read())
				{
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
		private void buttonStudentUpdate_Click(object sender, EventArgs e) {
			dataGridViewStudent.Columns.Remove("id"); 
			dataGridViewStudent.Columns.Remove("firstname"); 
			dataGridViewStudent.Columns.Remove("secondname");
			dataGridViewStudent.Columns.Remove("thirdname");
			dataGridViewStudent.Columns.Remove("birthday");
			dataGridViewStudent.Columns.Remove("name");
			dataGridViewStudent.Columns.Remove("nubmerPhone");
			updateStudentInfo();
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

			try
			{
				connection.OpenConnection();

				string command_string = "DELETE FROM `db`.`students` WHERE (`ID` = @ID);";

				MySqlCommand mySqlCommand = new MySqlCommand(command_string, connection.GetConnection());
				mySqlCommand.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Convert.ToInt32(textBoxStudentID.Text);
					
				if (mySqlCommand.ExecuteNonQuery() == 1)
					MessageBox.Show("Запись успешно удалена", "Успешно");
				else
					MessageBox.Show("Что-то пошло не так!", "Ошибка!");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				connection.CloseConnection();
			}
		}

        private void buttonExportStudents_Click(object sender, EventArgs e)
        {
			exportData(dataGridViewStudent);
		}
	}
}
