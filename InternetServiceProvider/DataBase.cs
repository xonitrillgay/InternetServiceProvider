using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace InternetServiceProvider
{
    public class DataBase
    {
        // Змінна для зберігання підключення до БД
        private SqlConnection connection;

        // Рядок підключення до БД
        private string connectionString = "Data Source=DESKTOP-PVF0G00\\SQLEXPRESS;Initial Catalog=InternetServiceProviderDB;Integrated Security=True";

        public DataBase()
        {
            // Створюємо підключення при ініціалізації класу
            connection = new SqlConnection(connectionString);
        }

        // Метод для відкриття підключення до БД
        public void openConnection()
        {
            // Перевіряємо, чи підключення закрите
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // Метод для отримання підключення до БД
        public SqlConnection getConnection()
        {
            return connection;
        }

        // Метод для закриття підключення до БД
        public void closeConnection()
        {
            // Перевіряємо, чи підключення відкрите
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}