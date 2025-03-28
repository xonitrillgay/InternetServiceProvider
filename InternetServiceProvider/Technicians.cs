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
    //enum Rowstate 
    //{ 
    //    Existed,
    //    New,
    //    Modified,
    //    ModifiedNew,
    //    Deleted,
    //}

    public partial class Technicians: Form
    {
        private string userRole;

        DataBase database = new DataBase();

        int selectedRow;

        public Technicians(string role)
        {
            InitializeComponent();
            userRole = role;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public Technicians() : this("user")
        {
            
        }

        private void BeautifyDataGridView()
        {
            // Колір фону таблиці
            dataGridView1.BackgroundColor = Color.White;

            // Колір заголовків стовпців
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215); // Синій
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false; // Вимикаємо стандартні стилі Windows

            // Колір рядків
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            // Колір вибраного рядка
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 174, 219); // Блакитний
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            // Альтернативні кольори для рядків (зебрування)
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255); // Світло-блакитний

            // Задаємо назви стовпців
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Ім'я";
            dataGridView1.Columns[2].HeaderText = "Прізвище";
            dataGridView1.Columns[3].HeaderText = "Email";
            dataGridView1.Columns[4].HeaderText = "Телефон";
            dataGridView1.Columns[5].HeaderText = "Активний";

            // Вирівнювання тексту в заголовках
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Вирівнювання тексту в комірках
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // active по центру

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetServiceProviderDBDataSet.technicians' table. You can move, or remove it, as needed.
            this.techniciansTableAdapter.Fill(this.internetServiceProviderDBDataSet.technicians);
            адмінпанельToolStripMenuItem.Visible = (userRole == "admin");

            BeautifyDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void RefreshDataGrid(DataGridView dataGrid)
        {
            database.openConnection();

            try
            {
                // SQL-запит для отримання всіх даних із таблиці technicians
                string query = "SELECT * FROM customer_service.technicians";
                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Створюємо DataTable для зберігання результатів
                        System.Data.DataTable dataTable = new System.Data.DataTable();
                        adapter.Fill(dataTable); // Завантажуємо дані з бази

                        // Оновлюємо DataGridView
                        dataGrid.DataSource = null; // Очищаємо попередні дані
                        dataGrid.DataSource = dataTable; // Прив’язуємо нові дані
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка при оновленні даних: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection(); // Завжди закриваємо підключення
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Form addform = new Add_Form();
            addform.Show();
        }

        private void deleteRow()
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Виберіть рядок для видалення!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dataGridView1.CurrentCell.RowIndex;

            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                string.IsNullOrEmpty(dataGridView1.Rows[index].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Рядок не містить ідентифікатора для видалення!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int technicianId;
            try
            {
                technicianId = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ідентифікатор техніка має бути числом!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            database.openConnection();
            try
            {
                string deleteQuery = "DELETE FROM customer_service.technicians WHERE technician_id = @technician_id";
                using (SqlCommand command = new SqlCommand(deleteQuery, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@technician_id", technicianId);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        dataGridView1.Rows.RemoveAt(index);
                        MessageBox.Show("Техніка успішно видалено!", "Успіх",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не вдалося видалити техніка з бази!", "Помилка",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка при видаленні: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void Change()
        {
            // Перевіряємо, чи вибрано рядок
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Виберіть рядок для редагування!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            // Отримуємо technician_id із першого стовпця DataGridView
            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value == null ||
                string.IsNullOrEmpty(dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Рядок не містить ідентифікатора для редагування!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int technicianId;
            try
            {
                technicianId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ідентифікатор техніка має бути числом!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Отримуємо нові значення з текстових полів
            var name = textBox2.Text;
            var surname = textBox3.Text;
            var email = textBox4.Text;
            var telephone = textBox5.Text;
            int active;

            // Перевірка active
            if (!int.TryParse(textBox6.Text, out active))
            {
                MessageBox.Show("Активність повинна бути числом 0 або 1!", "Помилка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (active != 0 && active != 1)
            {
                MessageBox.Show("Активність повинна бути 0 або 1!", "Помилка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Перевірка формату телефону
            if (!System.Text.RegularExpressions.Regex.IsMatch(telephone, @"^\d{3}-\d{3}-\d{4}$"))
            {
                MessageBox.Show("Телефон повинен бути у форматі 111-111-1111!", "Помилка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Відкриваємо підключення до бази один раз
            database.openConnection();

            try
            {
                // SQL-запит для оновлення даних у базі
                string updateQuery = "UPDATE customer_service.technicians " +
                                    "SET first_name = @first_name, last_name = @last_name, " +
                                    "email = @email, phone = @phone, active = @active " +
                                    "WHERE technician_id = @technician_id";

                using (SqlCommand command = new SqlCommand(updateQuery, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@first_name", name);
                    command.Parameters.AddWithValue("@last_name", surname);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phone", telephone);
                    command.Parameters.AddWithValue("@active", active);
                    command.Parameters.AddWithValue("@technician_id", technicianId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Оновлюємо DataGridView
                        dataGridView1.Rows[selectedRowIndex].Cells[1].Value = name;
                        dataGridView1.Rows[selectedRowIndex].Cells[2].Value = surname;
                        dataGridView1.Rows[selectedRowIndex].Cells[3].Value = email;
                        dataGridView1.Rows[selectedRowIndex].Cells[4].Value = telephone;
                        dataGridView1.Rows[selectedRowIndex].Cells[5].Value = active;

                        MessageBox.Show("Інформацію про фахівця змінено!", "Успіх",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не вдалося оновити дані фахівця!", "Помилка",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка при редагуванні: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void ClearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void інтернетпланиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Plans plansform = new Plans();
            plansform.Show();
        }

        private void обладнанняToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Devices devicesform = new Devices();
            devicesform.Show();
        }

        private void запитиАбонентівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Support_tickets ticketsform = new Support_tickets();
            ticketsform.Show();
        }

        private void призначенняТехніківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Technician_assignments assignmentsform = new Technician_assignments();
            assignmentsform.Show();
        }

        private void абонентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abonents abonentsform = new Abonents();
            abonentsform.Show();
        }

        private void платежіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payments paymentsform = new Payments();
            paymentsform.Show();
        }

        private void вийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Ви впевнені, що хочете вийти з програми?",
                "Підтвердження виходу",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Якщо користувач обрав "Так", закриваємо програму
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void report_Click(object sender, EventArgs e)
        {
            TechniciansReport techreportform = new TechniciansReport();
            techreportform.Show();
        }

        private void адмінпанельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
        }
    }
}
