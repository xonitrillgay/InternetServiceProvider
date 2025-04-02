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
        private int selectedPlanId = -1;

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
                        dataGridViewPlans.DataSource = dataTable;
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

        private void BeautifyDataGridView()
        {
            if (dataGridViewPlans.Columns.Count == 0)
                return;

            // Колір фону таблиці
            dataGridViewPlans.BackgroundColor = Color.White;

            // Колір заголовків стовпців
            dataGridViewPlans.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215); // Синій
            dataGridViewPlans.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewPlans.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewPlans.EnableHeadersVisualStyles = false; // Вимикаємо стандартні стилі Windows

            // Колір рядків
            dataGridViewPlans.DefaultCellStyle.BackColor = Color.White;
            dataGridViewPlans.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewPlans.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            // Колір вибраного рядка
            dataGridViewPlans.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 174, 219); // Блакитний
            dataGridViewPlans.DefaultCellStyle.SelectionForeColor = Color.White;

            // Альтернативні кольори для рядків (зебрування)
            dataGridViewPlans.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255); // Світло-блакитний

            // Задаємо назви стовпців
            dataGridViewPlans.Columns[0].HeaderText = "ID";
            dataGridViewPlans.Columns[1].HeaderText = "Назва";
            dataGridViewPlans.Columns[2].HeaderText = "Щомісячна оплата";

            // Center text in all cells
            foreach (DataGridViewColumn column in dataGridViewPlans.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Set column resizing behavior for optimal content display
            dataGridViewPlans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Calculate optimal width with some padding
            int totalColumnWidth = 0;
            foreach (DataGridViewColumn col in dataGridViewPlans.Columns)
            {
                if (col.Visible)
                {
                    // Add some padding (10 pixels) to the column width
                    col.Width += 10;
                    totalColumnWidth += col.Width;
                }
            }

            // If total width is less than the DataGridView width, adjust the last visible column
            if (totalColumnWidth < dataGridViewPlans.Width && dataGridViewPlans.Columns.Cast<DataGridViewColumn>().Any(c => c.Visible))
            {
                var lastVisibleColumn = dataGridViewPlans.Columns.Cast<DataGridViewColumn>().Last(c => c.Visible);
                lastVisibleColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Center align column headers
            dataGridViewPlans.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
        private bool CheckPlanDependencies(int planId)
        {
            bool hasDependencies = false;
            List<string> dependentAbonents = new List<string>();

            database.openConnection();

            try
            {
                // Query to check if any abonents are using this plan
                string query = @"SELECT a.abonent_id, a.first_name, a.last_name 
                        FROM [InternetServiceProviderDB].[service].[abonents] a
                        WHERE a.plan_id = @plan_id";

                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@plan_id", planId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int abonentId = reader.GetInt32(0);
                            string firstName = reader.GetString(1);
                            string lastName = reader.GetString(2);

                            dependentAbonents.Add($"{firstName} {lastName} (ID: {abonentId})");
                            hasDependencies = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка перевірки залежностей тарифу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }

            // If dependencies exist, show a message that admin should update abonent info first
            if (hasDependencies)
            {
                StringBuilder message = new StringBuilder();
                message.AppendLine("Цей тарифний план наразі використовується наступними абонентами:");
                message.AppendLine();

                foreach (string abonent in dependentAbonents)
                {
                    message.AppendLine($"• {abonent}");
                }

                message.AppendLine();
                message.AppendLine("Ви не можете видалити цей тарифний план, доки він пов'язаний з абонентами.");
                message.AppendLine("Спочатку оновіть інформацію про тарифи цих абонентів у формі \"Абоненти\".");

                MessageBox.Show(
                    message.ToString(),
                    "Тарифний план використовується",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return false; // Don't allow deletion when dependencies exist
            }

            return true; // No dependencies, safe to proceed
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedPlanId == -1)
            {
                MessageBox.Show("Спочатку виберіть тарифний план для видалення!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // First check for dependencies
            if (!CheckPlanDependencies(selectedPlanId))
            {
                return; // Don't proceed if dependencies exist
            }

            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей тарифний план?",
                "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    database.openConnection();

                    string query = "DELETE FROM [InternetServiceProviderDB].[service].[plans] WHERE plan_id = @plan_id";

                    using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                    {
                        command.Parameters.AddWithValue("@plan_id", selectedPlanId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Тарифний план видалено успішно!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Не вдалося видалити тарифний план!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка видалення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    database.closeConnection();
                    RefreshPlansData();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPlanId == -1)
            {
                MessageBox.Show("Спочатку виберіть тарифний план для оновлення!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate inputs
            if (string.IsNullOrWhiteSpace(textBoxPlanName.Text))
            {
                MessageBox.Show("Назва тарифного плану не може бути порожньою!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal monthlyFee;
            if (!decimal.TryParse(textBoxMonthlyFee.Text, out monthlyFee) || monthlyFee <= 0)
            {
                MessageBox.Show("Щомісячна оплата має бути додатнім числом!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // For updates, we'll only check dependencies and warn the admin, but still allow the update
            bool hasDependencies = false;
            List<string> dependentAbonents = new List<string>();

            database.openConnection();

            try
            {
                string query = @"SELECT a.abonent_id, a.first_name, a.last_name 
                    FROM [InternetServiceProviderDB].[service].[abonents] a
                    WHERE a.plan_id = @plan_id";

                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@plan_id", selectedPlanId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int abonentId = reader.GetInt32(0);
                            string firstName = reader.GetString(1);
                            string lastName = reader.GetString(2);

                            dependentAbonents.Add($"{firstName} {lastName} (ID: {abonentId})");
                            hasDependencies = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка перевірки залежностей тарифу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // If dependencies exist, warn the admin but allow update
            if (hasDependencies)
            {
                StringBuilder message = new StringBuilder();
                message.AppendLine("Цей тарифний план наразі використовується наступними абонентами:");
                message.AppendLine();

                foreach (string abonent in dependentAbonents)
                {
                    message.AppendLine($"• {abonent}");
                }

                message.AppendLine();
                message.AppendLine("Оновлення цього тарифного плану вплине на сервіси цих абонентів.");
                message.AppendLine("Бажаєте продовжити?");

                DialogResult continueResult = MessageBox.Show(
                    message.ToString(),
                    "Тарифний план використовується",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (continueResult == DialogResult.No)
                {
                    database.closeConnection();
                    return;
                }
            }

            try
            {
                string planName = textBoxPlanName.Text.Trim();

                string updateQuery = @"UPDATE [InternetServiceProviderDB].[service].[plans]
                   SET plan_name = @plan_name,
                       monthly_fee = @monthly_fee
                   WHERE plan_id = @plan_id";

                using (SqlCommand command = new SqlCommand(updateQuery, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@plan_id", selectedPlanId);
                    command.Parameters.AddWithValue("@plan_name", planName);
                    command.Parameters.AddWithValue("@monthly_fee", monthlyFee);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Тарифний план оновлено успішно!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Не вдалося оновити тарифний план!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка оновлення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
                RefreshPlansDataGrid(); // Using your existing method to refresh the grid
            }
        }

        private void dataGridPlans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPlans.Rows[e.RowIndex];
                selectedPlanId = Convert.ToInt32(row.Cells[0].Value); // Set the selected plan ID here
                int planId = selectedPlanId; // Use the stored value
                DisplayAbonentsByPlan(planId);

                textBoxPlanName.Text = row.Cells[1].Value.ToString();
                textBoxMonthlyFee.Text = row.Cells[2].Value.ToString();
            }
        }

        private void RefreshPlansData(string nameFilter = "")
        {
            try
            {
                // Store the current position to restore it after refresh
                int currentRow = -1;
                if (dataGridViewPlans.CurrentRow != null)
                {
                    currentRow = dataGridViewPlans.CurrentRow.Index;
                }

                // Clear the current DataSource
                dataGridViewPlans.DataSource = null;

                // Use direct SQL query
                database.openConnection();

                string query;
                SqlCommand command;

                // If a name filter is provided, use a WHERE clause to filter
                if (!string.IsNullOrWhiteSpace(nameFilter))
                {
                    query = @"SELECT plan_id, plan_name, monthly_fee
                    FROM [InternetServiceProviderDB].[service].[plans]
                    WHERE plan_name LIKE @nameFilter";

                    command = new SqlCommand(query, database.getConnection());
                    command.Parameters.AddWithValue("@nameFilter", "%" + nameFilter + "%");
                }
                else
                {
                    // No filter, get all plans
                    query = "SELECT plan_id, plan_name, monthly_fee FROM [InternetServiceProviderDB].[service].[plans]";
                    command = new SqlCommand(query, database.getConnection());
                }

                // Create a DataTable to hold the results
                DataTable dataTable = new DataTable();

                // Use SqlDataAdapter to fill the DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);

                    // Set the DataTable as the DataSource for the DataGridView
                    dataGridViewPlans.DataSource = dataTable;
                }

                // Apply formatting
                BeautifyDataGridView();

                // Try to restore the previous selected row if possible
                if (currentRow >= 0 && currentRow < dataGridViewPlans.Rows.Count)
                {
                    dataGridViewPlans.CurrentCell = dataGridViewPlans.Rows[currentRow].Cells[0];
                    dataGridViewPlans.Rows[currentRow].Selected = true;
                }

                // Force the DataGridView to refresh its display
                dataGridViewPlans.Refresh();

                // Display message if no records found
                if (dataTable.Rows.Count == 0 && !string.IsNullOrWhiteSpace(nameFilter))
                {
                    MessageBox.Show($"За запитом \"{nameFilter}\" тарифних планів не знайдено.",
                        "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка оновлення даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
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
