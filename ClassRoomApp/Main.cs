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

        private void updateStudentInfo() {
            ConnectionClass connection = new ConnectionClass();
			MySqlCommand mySqlCommand = new MySqlCommand("SELECT * from `students`,`classes` where `students`.classid = `classes`.id", connection.GetConnection());
			try {
				connection.OpenConnection();
				MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
				dataGridViewStudent.Columns.Add("firstname", "Имя");
				dataGridViewStudent.Columns.Add("secondname", "Фамилия");
				dataGridViewStudent.Columns.Add("thirdname", "Имя");
				dataGridViewStudent.Columns.Add("birthday", "Дата рождения");
				dataGridViewStudent.Columns.Add("name", "Класс");
				dataGridViewStudent.Columns.Add("numberphone", "Номер телефона");
				while (mySqlDataReader.Read())
				{
					dataGridViewStudent.Rows.Add(mySqlDataReader["FirstName"].ToString(), mySqlDataReader["SecondName"].ToString());
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
			dataGridViewStudent.Columns.Remove("firstname");
			dataGridViewStudent.Columns.Remove("secondname");
			dataGridViewStudent.Columns.Remove("thirdname");
			dataGridViewStudent.Columns.Remove("birthday");
			dataGridViewStudent.Columns.Remove("name");
			dataGridViewStudent.Columns.Remove("numberphone");
			updateStudentInfo();
			MessageBox.Show("Информация успешно обновлена","Информация");
		}
    }
}
