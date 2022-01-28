
using System.Data;
using MySql.Data.MySqlClient;

namespace ClassRoomApp
{
    class ConnectionClass
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=aether;password=!Exc25125;database=db");
        
        public void OpenConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection() => connection;
    }
}
