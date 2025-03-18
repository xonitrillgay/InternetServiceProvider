using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InternetServiceProvider
{
    public partial class Add_Form : Form
    {
        DataBase database = new DataBase();

        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.openConnection();
            var name = textBox1.Text;
            var surname = textBox2.Text;
            var email = textBox3.Text;
            var telephone = textBox4.Text;
            int active;

            if (int.TryParse(textBox5.Text, out active))
            {
                // Перевіряємо, щоб active було 0 або 1
                if (active != 0 && active != 1)
                {
                    MessageBox.Show("Активність повинна бути 0 або 1!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    database.closeConnection();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Активність повинна бути числом 0 або 1!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                database.closeConnection();
                return;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(telephone, @"^\d{3}-\d{3}-\d{4}$"))
            {
                // Параметризований запит для безпеки
                var addQuery = "INSERT INTO customer_service.technicians (first_name, last_name, email, phone, active) " +
                               "VALUES (@first_name, @last_name, @email, @phone, @active)";

                var command = new SqlCommand(addQuery, database.getConnection());
                command.Parameters.AddWithValue("@first_name", name);
                command.Parameters.AddWithValue("@last_name", surname);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@phone", telephone); // telephone як string
                command.Parameters.AddWithValue("@active", active);

                command.ExecuteNonQuery();
                MessageBox.Show("Нового фахівця додано!", "Успіх",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Телефон повинен бути у форматі 111-111-1111!", "Помилка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            database.closeConnection();
        }
    }
}