using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetServiceProvider
{
    public partial class Abonents: Form
    {
        DataBase database = new DataBase();
        private int selectedRow;

        public Abonents()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            dataGridView1.Columns[3].HeaderText = "Телефон";
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[5].HeaderText = "Адреса";
            dataGridView1.Columns[6].HeaderText = "ID плану";
            dataGridView1.Columns[7].HeaderText = "ID обладнання";


            // Вирівнювання тексту в заголовках
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Вирівнювання тексту в комірках
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // active по центру

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Abonents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetServiceProviderDBDataSet6.abonents' table. You can move, or remove it, as needed.
            this.abonentsTableAdapter.Fill(this.internetServiceProviderDBDataSet6.abonents);
            FillComboBoxPlanID();
            FillComboBoxDeviceID();
            RefreshAbonentsDataGrid();
            BeautifyDataGridView();
        }

        private void RefreshAbonentsDataGrid()
        {
            database.openConnection();

            try
            {
                string query = "SELECT * FROM [InternetServiceProviderDB].[service].[abonents]";
                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error refreshing abonents data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void FillComboBoxPlanID()
        {
            database.openConnection();
            try
            {
                string query = "SELECT * FROM [InternetServiceProviderDB].[service].[plans]";
                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxPlanID.Items.Add(reader["plan_id"].ToString());
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error filling combobox: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void FillComboBoxDeviceID()
        {
            database.openConnection();
            try
            {
                string query = "SELECT *  FROM [InternetServiceProviderDB].[service].[devices]";
                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxDeviceID.Items.Add(reader["device_id"].ToString());
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка заповнення комбобоксу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void pictureBoxCreate_Click(object sender, EventArgs e)
        {
            string first_name = textBoxName.Text;
            string last_name = textBoxLastName.Text;
            string abonent_phone = textBoxTelephone.Text;
            string abonent_email = textBoxEmail.Text;
            string abonent_address = textBoxAddress.Text;
            string plan_id = comboBoxPlanID.Text;
            string device_id = comboBoxDeviceID.Text;

            database.openConnection();

            try
            {
                string query = "INSERT INTO [InternetServiceProviderDB].[service].[abonents] (first_name, last_name, phone, email, address, plan_id, device_id) VALUES (@first_name, @last_name, @abonent_phone, @abonent_email, @abonent_address, @plan_id, @device_id)";
                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@first_name", first_name);
                    command.Parameters.AddWithValue("@last_name", last_name);
                    command.Parameters.AddWithValue("@abonent_phone", abonent_phone);
                    command.Parameters.AddWithValue("@abonent_email", abonent_email);
                    command.Parameters.AddWithValue("@abonent_address", abonent_address);
                    command.Parameters.AddWithValue("@plan_id", plan_id);
                    command.Parameters.AddWithValue("@device_id", device_id);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Абонента додано успішно!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка додавання абонента: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
                RefreshAbonentsDataGrid();
            }
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
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

            int abonentId;
            try
            {
                abonentId = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ідентифікатор абонента має бути числом!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            database.openConnection();
            try
            {
                string deleteQuery = "DELETE FROM [InternetServiceProviderDB].[service].[abonents] WHERE abonent_id = @abonent_id";
                using (SqlCommand command = new SqlCommand(deleteQuery, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@abonent_id", abonentId);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        dataGridView1.Rows.RemoveAt(index);
                        MessageBox.Show("Абонента успішно видалено!", "Успіх",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не вдалося видалити абонента з бази!", "Помилка",
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Check if a row is selected in the DataGridView
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Виберіть рядок для онолвення!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dataGridView1.CurrentCell.RowIndex;

            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                string.IsNullOrEmpty(dataGridView1.Rows[index].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Рядок не містить ідентифікатора для оновлення!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int abonentId;
            try
            {
                abonentId = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ідентифікатор абонента має бути числом!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            database.openConnection();

            // Get the updated values from text boxes
            string first_name = textBoxName.Text;
            string last_name = textBoxLastName.Text;
            string abonent_phone = textBoxTelephone.Text;
            string abonent_email = textBoxEmail.Text;
            string abonent_address = textBoxAddress.Text;
            string plan_id = comboBoxPlanID.Text;
            string device_id = comboBoxDeviceID.Text;

            // Check if any field is empty
            if (string.IsNullOrWhiteSpace(first_name) ||
                string.IsNullOrWhiteSpace(last_name) ||
                string.IsNullOrWhiteSpace(abonent_phone) ||
                string.IsNullOrWhiteSpace(abonent_email) ||
                string.IsNullOrWhiteSpace(abonent_address) ||
                string.IsNullOrWhiteSpace(plan_id) ||
                string.IsNullOrWhiteSpace(device_id))
            {
                MessageBox.Show("Всі поля обов'язкові для заповнення.", "Помилка користувача", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            database.openConnection();

            try
            {
                string query = @"UPDATE [InternetServiceProviderDB].[service].[abonents] 
                        SET first_name = @first_name, 
                            last_name = @last_name, 
                            phone = @abonent_phone, 
                            email = @abonent_email, 
                            address = @abonent_address, 
                            plan_id = @plan_id, 
                            device_id = @device_id 
                        WHERE abonent_id = @abonent_id";

                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@abonent_id", abonentId);
                    command.Parameters.AddWithValue("@first_name", first_name);
                    command.Parameters.AddWithValue("@last_name", last_name);
                    command.Parameters.AddWithValue("@abonent_phone", abonent_phone);
                    command.Parameters.AddWithValue("@abonent_email", abonent_email);
                    command.Parameters.AddWithValue("@abonent_address", abonent_address);
                    command.Parameters.AddWithValue("@plan_id", plan_id);
                    command.Parameters.AddWithValue("@device_id", device_id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Абонента було успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear input fields after successful update
                        textBoxName.Clear();
                        textBoxLastName.Clear();
                        textBoxTelephone.Clear();
                        textBoxEmail.Clear();
                        textBoxAddress.Clear();
                        comboBoxPlanID.SelectedIndex = -1;
                        comboBoxDeviceID.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Інформацію про абонента не було оновлено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка оновлення абонента: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
                RefreshAbonentsDataGrid(); // Refresh the DataGridView to reflect changes
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBoxName.Text = row.Cells[1].Value.ToString();
                textBoxLastName.Text = row.Cells[2].Value.ToString();
                textBoxTelephone.Text = row.Cells[3].Value.ToString();
                textBoxEmail.Text = row.Cells[4].Value.ToString();
                textBoxAddress.Text = row.Cells[5].Value.ToString();
                comboBoxPlanID.Text = row.Cells[6].Value.ToString();
                comboBoxDeviceID.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
