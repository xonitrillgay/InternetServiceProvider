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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InternetServiceProvider
{
    public partial class Plans: Form
    {
        DataBase database = new DataBase();

        public Plans()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void RefreshPlansDataGrid()
        {
            database.openConnection();

            try
            {
                string query = "SELECT * FROM [InternetServiceProviderDB].[service].[plans]";
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
                MessageBox.Show($"Помилка оновлення інформації про тарифні плани: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
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
                        dataGridViewAbonents.DataSource = dataTable;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка оновлення інформації про абонентів: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void BeautifyDataGridView()
        {
            if (dataGridView1.Columns.Count == 0)
                return;

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
            dataGridView1.Columns[1].HeaderText = "Назва";
            dataGridView1.Columns[2].HeaderText = "Щомісячна оплата";

            // Center text in all cells
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Set column resizing behavior for optimal content display
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Calculate optimal width with some padding
            int totalColumnWidth = 0;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Visible)
                {
                    // Add some padding (10 pixels) to the column width
                    col.Width += 10;
                    totalColumnWidth += col.Width;
                }
            }

            // If total width is less than the DataGridView width, adjust the last visible column
            if (totalColumnWidth < dataGridView1.Width && dataGridView1.Columns.Cast<DataGridViewColumn>().Any(c => c.Visible))
            {
                var lastVisibleColumn = dataGridView1.Columns.Cast<DataGridViewColumn>().Last(c => c.Visible);
                lastVisibleColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Center align column headers
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void BeautifyDataGridViewAbonents()
        {
            if (dataGridViewAbonents.Columns.Count == 0)
                return;

            // Колір фону таблиці
            dataGridViewAbonents.BackgroundColor = Color.White;

            // Колір заголовків стовпців
            dataGridViewAbonents.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215); // Синій
            dataGridViewAbonents.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewAbonents.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewAbonents.EnableHeadersVisualStyles = false; // Вимикаємо стандартні стилі Windows

            // Колір рядків
            dataGridViewAbonents.DefaultCellStyle.BackColor = Color.White;
            dataGridViewAbonents.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewAbonents.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            // Колір вибраного рядка
            dataGridViewAbonents.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 174, 219); // Блакитний
            dataGridViewAbonents.DefaultCellStyle.SelectionForeColor = Color.White;

            // Альтернативні кольори для рядків (зебрування)
            dataGridViewAbonents.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255); // Світло-блакитний

            // Задаємо назви стовпців
            dataGridViewAbonents.Columns[0].HeaderText = "Ім'я";
            dataGridViewAbonents.Columns[1].HeaderText = "Прізвище";
            dataGridViewAbonents.Columns[2].HeaderText = "Телефон";
            dataGridViewAbonents.Columns[3].HeaderText = "Адреса";

            // Center text in all cells
            foreach (DataGridViewColumn column in dataGridViewAbonents.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Set column resizing behavior for optimal content display
            dataGridViewAbonents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Calculate optimal width with some padding
            int totalColumnWidth = 0;
            foreach (DataGridViewColumn col in dataGridViewAbonents.Columns)
            {
                if (col.Visible)
                {
                    // Add some padding (10 pixels) to the column width
                    col.Width += 10;
                    totalColumnWidth += col.Width;
                }
            }

            // If total width is less than the DataGridView width, adjust the last visible column
            if (totalColumnWidth < dataGridViewAbonents.Width && dataGridViewAbonents.Columns.Cast<DataGridViewColumn>().Any(c => c.Visible))
            {
                var lastVisibleColumn = dataGridViewAbonents.Columns.Cast<DataGridViewColumn>().Last(c => c.Visible);
                lastVisibleColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Center align column headers
            dataGridViewAbonents.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Hide the row header column
            dataGridViewAbonents.RowHeadersVisible = false;
        }


        private void Plans_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetServiceProviderDBDataSet6.abonents' table. You can move, or remove it, as needed.
            this.abonentsTableAdapter.Fill(this.internetServiceProviderDBDataSet6.abonents);
            // TODO: This line of code loads data into the 'internetServiceProviderDBDataSet6.abonents' table. You can move, or remove it, as needed.
            this.abonentsTableAdapter.Fill(this.internetServiceProviderDBDataSet6.abonents);
            // TODO: This line of code loads data into the 'internetServiceProviderDBDataSet2.plans' table. You can move, or remove it, as needed.
            this.plansTableAdapter.Fill(this.internetServiceProviderDBDataSet2.plans);

            BeautifyDataGridView();
            BeautifyDataGridViewAbonents();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string planName = textBoxPlanName.Text;
            decimal monthlyFee;
            if (!decimal.TryParse(textBoxMonthlyFee.Text, out monthlyFee))
            {
                MessageBox.Show("Щомісячна оплата має бути числом!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            database.openConnection();

            try
            {
                string query = "INSERT INTO [InternetServiceProviderDB].[service].[plans] (plan_name, monthly_fee) VALUES (@plan_name, @monthly_fee)";
                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@plan_name", planName);
                    command.Parameters.AddWithValue("@monthly_fee", monthlyFee);
                    command.ExecuteNonQuery();
                    MessageBox.Show("План додано успішно!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка додавання плану: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
                RefreshPlansDataGrid();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Виберіть рядок для видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dataGridView1.CurrentCell.RowIndex;

            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                string.IsNullOrEmpty(dataGridView1.Rows[index].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Рядок не містить ідентифікатора для видалення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int planId;
            try
            {
                planId = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ідентифікатор плану має бути числом!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if any abonents are using this plan
            int abonentsCount = CountAbonentsUsingPlan(planId);
            if (abonentsCount > 0)
            {
                // Ask for confirmation to reassign abonents
                DialogResult result = MessageBox.Show(
                    $"{abonentsCount} абоненти використовують цей тариф. Видалення тарифу призведе до автоматичного переведення абонентів на тариф з найближчою ціною. Продовжити?",
                    "Підтвердження",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }

                // Find nearest price plan and reassign abonents
                ReassignAbonentsToNearestPricePlan(planId);
            }

            database.openConnection();
            try
            {
                string deleteQuery = "DELETE FROM [InternetServiceProviderDB].[service].[plans] WHERE plan_id = @plan_id";
                using (SqlCommand command = new SqlCommand(deleteQuery, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@plan_id", planId);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        dataGridView1.Rows.RemoveAt(index);
                        MessageBox.Show("План успішно видалено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не вдалося видалити план з бази!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка при видаленні: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
                RefreshPlansDataGrid();
                RefreshAbonentsDataGrid();
            }
        }

        private int CountAbonentsUsingPlan(int planId)
        {
            int count = 0;
            database.openConnection();

            try
            {
                string query = "SELECT COUNT(*) FROM [InternetServiceProviderDB].[service].[abonents] WHERE plan_id = @plan_id";
                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@plan_id", planId);
                    count = (int)command.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка підрахунку абонентів: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }

            return count;
        }

        private void ReassignAbonentsToNearestPricePlan(int planIdToDelete)
        {
            // First, get the price and name of the plan being deleted
            decimal currentPlanPrice = GetPlanPrice(planIdToDelete);
            string currentPlanName = GetPlanName(planIdToDelete);
            if (currentPlanPrice < 0)
            {
                MessageBox.Show("Не вдалося отримати ціну поточного плану.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Next, find the plan with the nearest price (excluding the one being deleted)
            int nearestPlanId = FindPlanWithNearestPrice(planIdToDelete, currentPlanPrice);
            if (nearestPlanId <= 0)
            {
                MessageBox.Show("Не вдалося знайти альтернативний план. Операцію скасовано.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get information about the new plan
            string newPlanName = GetPlanName(nearestPlanId);
            decimal newPlanPrice = GetPlanPrice(nearestPlanId);

            // Get a list of affected abonents before making changes
            List<string> affectedAbonents = GetAbonentsUsingPlan(planIdToDelete);

            // Finally, update all abonents using the plan being deleted to use the nearest plan
            database.openConnection();

            try
            {
                string updateQuery = @"UPDATE [InternetServiceProviderDB].[service].[abonents] 
                            SET plan_id = @new_plan_id
                            WHERE plan_id = @old_plan_id";

                using (SqlCommand command = new SqlCommand(updateQuery, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@new_plan_id", nearestPlanId);
                    command.Parameters.AddWithValue("@old_plan_id", planIdToDelete);
                    int rowsAffected = command.ExecuteNonQuery();

                    // Create a detailed message
                    StringBuilder detailedMessage = new StringBuilder();
                    detailedMessage.AppendLine($"Успішно переведено {rowsAffected} абонентів з тарифу:");
                    detailedMessage.AppendLine($"• \"{currentPlanName}\" ({currentPlanPrice:C})");
                    detailedMessage.AppendLine($"на тариф:");
                    detailedMessage.AppendLine($"• \"{newPlanName}\" ({newPlanPrice:C})");

                    if (affectedAbonents.Count > 0)
                    {
                        detailedMessage.AppendLine("\nПерелік абонентів:");
                        foreach (string abonent in affectedAbonents)
                        {
                            detailedMessage.AppendLine($"• {abonent}");
                        }
                    }

                    MessageBox.Show(detailedMessage.ToString(), "Інформація про зміну тарифів", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка оновлення абонентів: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private decimal GetPlanPrice(int planId)
        {
            decimal price = -1;
            database.openConnection();

            try
            {
                string query = "SELECT monthly_fee FROM [InternetServiceProviderDB].[service].[plans] WHERE plan_id = @plan_id";
                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@plan_id", planId);
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        price = Convert.ToDecimal(result);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка отримання ціни плану: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }

            return price;
        }

        // Helper methods to get plan information
        private string GetPlanName(int planId)
        {
            string name = string.Empty;
            database.openConnection();

            try
            {
                string query = "SELECT plan_name FROM [InternetServiceProviderDB].[service].[plans] WHERE plan_id = @plan_id";
                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@plan_id", planId);
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        name = result.ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка отримання назви плану: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }

            return name;
        }

        private List<string> GetAbonentsUsingPlan(int planId)
        {
            List<string> abonentsList = new List<string>();
            database.openConnection();

            try
            {
                string query = @"SELECT first_name, last_name, phone 
                        FROM [InternetServiceProviderDB].[service].[abonents] 
                        WHERE plan_id = @plan_id";

                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@plan_id", planId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string firstName = reader["first_name"].ToString();
                            string lastName = reader["last_name"].ToString();
                            string phone = reader["phone"].ToString();
                            abonentsList.Add($"{firstName} {lastName} ({phone})");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка отримання списку абонентів: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }

            return abonentsList;
        }

        private int FindPlanWithNearestPrice(int planIdToExclude, decimal targetPrice)
        {
            int nearestPlanId = -1;
            decimal minPriceDifference = decimal.MaxValue;

            database.openConnection();

            try
            {
                string query = "SELECT plan_id, monthly_fee FROM [InternetServiceProviderDB].[service].[plans] WHERE plan_id != @exclude_plan_id";
                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@exclude_plan_id", planIdToExclude);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("Немає інших доступних планів.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return -1;
                        }

                        while (reader.Read())
                        {
                            int currentPlanId = reader.GetInt32(0);
                            decimal currentPrice = reader.GetDecimal(1);
                            decimal priceDifference = Math.Abs(currentPrice - targetPrice);

                            if (priceDifference < minPriceDifference)
                            {
                                minPriceDifference = priceDifference;
                                nearestPlanId = currentPlanId;
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка пошуку найближчого плану: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }

            return nearestPlanId;
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Виберіть рядок для оновлення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int index = dataGridView1.CurrentCell.RowIndex;

            if (dataGridView1.Rows[index].Cells[0].Value == null ||
                string.IsNullOrEmpty(dataGridView1.Rows[index].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Рядок не містить ідентифікатора для оновлення!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int planId;
            try
            {
                planId = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ідентифікатор плану має бути числом!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the updated values from text boxes
            string planName = textBoxPlanName.Text;
            decimal monthlyFee;
            if (!decimal.TryParse(textBoxMonthlyFee.Text, out monthlyFee))
            {
                MessageBox.Show("Щомісячна оплата має бути числом!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if any field is empty
            if (string.IsNullOrWhiteSpace(planName))
            {
                MessageBox.Show("Назва плану обов'язкова для заповнення.", "Помилка користувача", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            database.openConnection();

            try
            {
                string query = @"UPDATE [InternetServiceProviderDB].[service].[plans] 
                        SET plan_name = @plan_name, 
                            monthly_fee = @monthly_fee 
                        WHERE plan_id = @plan_id";

                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@plan_id", planId);
                    command.Parameters.AddWithValue("@plan_name", planName);
                    command.Parameters.AddWithValue("@monthly_fee", monthlyFee);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("План було успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear input fields after successful update
                        textBoxPlanName.Clear();
                        textBoxMonthlyFee.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Інформацію про план не було оновлено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка оновлення плану: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
                RefreshPlansDataGrid(); // Refresh the DataGridView to reflect changes
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int planId = Convert.ToInt32(row.Cells[0].Value);
                DisplayAbonentsByPlan(planId);

                textBoxPlanName.Text = row.Cells[1].Value.ToString();
                textBoxMonthlyFee.Text = row.Cells[2].Value.ToString();
            }
        }

        private void DisplayAbonentsByPlan(int planId)
        {
            database.openConnection();

            try
            {
                string query = "SELECT * FROM [InternetServiceProviderDB].[service].[abonents] WHERE plan_id = @plan_id";
                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@plan_id", planId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewAbonents.DataSource = dataTable;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка відображення абонентів: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void ClearFields()
        {
            textBoxPlanName.Text = "";
            textBoxMonthlyFee.Text = "";
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
