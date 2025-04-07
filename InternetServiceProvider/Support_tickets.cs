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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InternetServiceProvider
{
    public partial class Support_tickets: Form
    {
        private DataBase database = new DataBase();
        private int selectedTicketId = -1;
        private string userRole = "user"; // Default role

        public Support_tickets(string role = "user")
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.userRole = role.Trim();
            SetupStatusComboBox();
            LoadAbonentIds();
            SetupSearchControls();
        }
        public Support_tickets() : this("user")
        {
        }

        private void SetupStatusComboBox()
        {
            comboBoxStatus.Items.Clear();
            comboBoxStatus.Items.AddRange(new string[] {
                "Новий",
                "Закрито"
            });
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.SelectedIndex = 0;
        }

        private void SetupSearchByDateComboBox()
        {
            comboBoxSearchByDate.Items.Clear();
            comboBoxSearchByDate.Items.AddRange(new string[] {
                "Всі дати",
                "Сьогодні",
                "За останній тиждень",
                "За останній місяць",
                "За останній рік",
            });
            comboBoxSearchByDate.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchByDate.SelectedIndex = 0;
        }

        private void SetupSearchControls()
        {
            SetupSearchByDateComboBox();

            comboBoxSearchByDate.SelectedIndexChanged += comboBoxSearchByDate_SelectedIndexChanged;
        }

        private void LoadAbonentIds()
        {
            try
            {
                database.openConnection();
                string query = "SELECT abonent_id, first_name, last_name FROM [InternetServiceProviderDB].[service].[abonents]";

                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    comboBoxAbonent.Items.Clear();

                    Dictionary<int, string> abonentMapping = new Dictionary<int, string>();

                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["abonent_id"]);
                        string firstName = reader["first_name"].ToString();
                        string lastName = reader["last_name"].ToString();
                        string displayName = $"{firstName} {lastName} (ID: {id})";

                        comboBoxAbonent.Items.Add(new ComboBoxAbonentItem(id, displayName));
                    }

                    if (comboBoxAbonent.Items.Count > 0)
                        comboBoxAbonent.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження даних абонентів: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private class ComboBoxAbonentItem
        {
            public int ID { get; set; }
            public string DisplayName { get; set; }

            public ComboBoxAbonentItem(int id, string displayName)
            {
                ID = id;
                DisplayName = displayName;
            }

            public override string ToString()
            {
                return DisplayName;
            }
        }

        private void BeautifyDataGridView()
        {
            dataGridViewTickets.BackgroundColor = Color.White;

            dataGridViewTickets.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewTickets.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewTickets.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewTickets.EnableHeadersVisualStyles = false;

            dataGridViewTickets.DefaultCellStyle.BackColor = Color.White;
            dataGridViewTickets.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewTickets.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridViewTickets.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 174, 219);
            dataGridViewTickets.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridViewTickets.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255); // Світло-блакитний

            dataGridViewTickets.Columns[0].HeaderText = "ID замовлення";
            dataGridViewTickets.Columns[1].HeaderText = "ID абонента";
            dataGridViewTickets.Columns[2].HeaderText = "Опис проблеми";
            dataGridViewTickets.Columns[3].HeaderText = "Статус замовлення";
            dataGridViewTickets.Columns[4].HeaderText = "Дата реєстрації замовлення";
            dataGridViewTickets.Columns[5].HeaderText = "Дата виконання замовлення";

            dataGridViewTickets.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewTickets.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewTickets.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // active по центру

            dataGridViewTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Support_tickets_Load(object sender, EventArgs e)
        {

            this.support_ticketsTableAdapter.Fill(this.internetServiceProviderDBDataSet3.support_tickets);

            dateTimePickerCreationDate.Value = DateTime.Now;
            dateTimePickerClosureDate.Value = DateTime.Now.AddDays(7);
            dateTimePickerClosureDate.Enabled = checkBoxClosureDate.Checked;

            checkBoxClosureDate.CheckedChanged += checkBoxClosureDate_CheckedChanged;
            comboBoxStatus.SelectedIndexChanged += ComboBoxStatus_SelectedIndexChanged;
            dataGridViewTickets.CellClick += DataGridViewTickets_CellClick;

            bool isAdmin = (userRole.ToLower() == "admin");
            buttonDelete.Visible = isAdmin;
            buttonUpdate.Visible = isAdmin;

            BeautifyDataGridView();

            ClearFields();
        }

        private void ComboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStatus.SelectedItem != null)
            {
                string status = comboBoxStatus.SelectedItem.ToString();

                if (status == "Закрито")
                {
                    checkBoxClosureDate.Checked = true;
                    dateTimePickerClosureDate.Enabled = true;
                }
                else
                {
                    checkBoxClosureDate.Checked = false;
                    dateTimePickerClosureDate.Enabled = false;
                }
            }
        }

        private void DataGridViewTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ClearFields();

                var row = dataGridViewTickets.Rows[e.RowIndex];
                selectedTicketId = Convert.ToInt32(row.Cells["ticketidDataGridViewTextBoxColumn"].Value);

                if (row.Cells["abonentidDataGridViewTextBoxColumn"].Value != null)
                {
                    int abonentId = Convert.ToInt32(row.Cells["abonentidDataGridViewTextBoxColumn"].Value);
                    SelectAbonentInComboBox(abonentId);
                }

                if (row.Cells["issuedescriptionDataGridViewTextBoxColumn"].Value != null)
                    textBoxIssueDescription.Text = row.Cells["issuedescriptionDataGridViewTextBoxColumn"].Value.ToString();

                if (row.Cells["ticketstatusDataGridViewTextBoxColumn"].Value != null)
                {
                    string status = row.Cells["ticketstatusDataGridViewTextBoxColumn"].Value.ToString();

                    if (status != "Новий" && status != "Закрито")
                    {
                        status = "Новий";
                    }

                    int index = comboBoxStatus.Items.IndexOf(status);
                    comboBoxStatus.SelectedIndex = index >= 0 ? index : 0;

                    if (status == "Закрито")
                    {
                        if (row.Cells["closuredateDataGridViewTextBoxColumn"].Value != DBNull.Value &&
                            row.Cells["closuredateDataGridViewTextBoxColumn"].Value != null)
                        {
                            dateTimePickerClosureDate.Value = Convert.ToDateTime(row.Cells["closuredateDataGridViewTextBoxColumn"].Value);
                            checkBoxClosureDate.Checked = true;
                        }
                        else
                        {
                            dateTimePickerClosureDate.Value = DateTime.Now;
                            checkBoxClosureDate.Checked = true;
                        }
                    }
                    else
                    {
                        dateTimePickerClosureDate.Value = DateTime.Now.AddDays(7);
                        checkBoxClosureDate.Checked = false;
                    }
                }

                if (row.Cells["creationdateDataGridViewTextBoxColumn"].Value != null)
                    dateTimePickerCreationDate.Value = Convert.ToDateTime(row.Cells["creationdateDataGridViewTextBoxColumn"].Value);

                dateTimePickerClosureDate.Enabled = checkBoxClosureDate.Checked;
            }
        }

        private void checkBoxClosureDate_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerClosureDate.Enabled = checkBoxClosureDate.Checked;

            if (checkBoxClosureDate.Checked)
            {
                string currentStatus = comboBoxStatus.SelectedItem?.ToString() ?? "";

                if (currentStatus != "Закрито")
                {
                    int closedIndex = comboBoxStatus.Items.IndexOf("Закрито");
                    if (closedIndex >= 0)
                    {
                        comboBoxStatus.SelectedIndex = closedIndex;
                        MessageBox.Show("Статус автоматично змінено на \"Закрито\", оскільки встановлена дата закриття.",
                            "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                string currentStatus = comboBoxStatus.SelectedItem?.ToString() ?? "";

                if (currentStatus == "Закрито")
                {
                    MessageBox.Show("Запити зі статусом \"Закрито\" повинні мати дату закриття.",
                        "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkBoxClosureDate.Checked = true;
                }
                else
                {
                    int newIndex = comboBoxStatus.Items.IndexOf("Новий");
                    if (newIndex >= 0)
                    {
                        comboBoxStatus.SelectedIndex = newIndex;
                    }
                }
            }
        }

        private bool ValidateStatusAndClosureDate(string ticketStatus, bool hasClosureDate)
        {
            bool isClosedStatus = (ticketStatus == "Закрито");

            if (isClosedStatus && !hasClosureDate)
            {
                MessageBox.Show("Запити зі статусом \"Закрито\" повинні мати дату закриття.",
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!isClosedStatus && hasClosureDate)
            {
                DialogResult result = MessageBox.Show(
                    "Встановлена дата закриття зазвичай вказується для закритих запитів. Бажаєте продовжити?",
                    "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                return (result == DialogResult.Yes);
            }

            return true;
        }

        private void SelectAbonentInComboBox(int abonentId)
        {
            for (int i = 0; i < comboBoxAbonent.Items.Count; i++)
            {
                ComboBoxAbonentItem item = comboBoxAbonent.Items[i] as ComboBoxAbonentItem;
                if (item != null && item.ID == abonentId)
                {
                    comboBoxAbonent.SelectedIndex = i;
                    return;
                }
            }

            LoadAbonentIds();

            for (int i = 0; i < comboBoxAbonent.Items.Count; i++)
            {
                ComboBoxAbonentItem item = comboBoxAbonent.Items[i] as ComboBoxAbonentItem;
                if (item != null && item.ID == abonentId)
                {
                    comboBoxAbonent.SelectedIndex = i;
                    return;
                }
            }
        }

        private void ClearFields()
        {
            comboBoxAbonent.SelectedIndex = comboBoxAbonent.Items.Count > 0 ? 0 : -1;
            textBoxIssueDescription.Text = "";
            comboBoxStatus.SelectedIndex = 0;
            dateTimePickerCreationDate.Value = DateTime.Now;
            dateTimePickerClosureDate.Value = DateTime.Now.AddDays(7);
            checkBoxClosureDate.Checked = false;
            dateTimePickerClosureDate.Enabled = false;
            selectedTicketId = -1;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (comboBoxAbonent.SelectedItem == null || string.IsNullOrWhiteSpace(textBoxIssueDescription.Text))
            {
                MessageBox.Show("Всі поля мають бути заповнені!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int abonentId = (comboBoxAbonent.SelectedItem as ComboBoxAbonentItem).ID;
                string issueDescription = textBoxIssueDescription.Text;
                string ticketStatus = comboBoxStatus.SelectedItem.ToString();
                DateTime creationDate = dateTimePickerCreationDate.Value;
                DateTime? closureDate = null;

                if (checkBoxClosureDate.Checked)
                {
                    closureDate = dateTimePickerClosureDate.Value;
                }

                if (!ValidateStatusAndClosureDate(ticketStatus, checkBoxClosureDate.Checked))
                    return;

                database.openConnection();

                string query = @"INSERT INTO [InternetServiceProviderDB].[customer_service].[support_tickets]
               (abonent_id, issue_description, ticket_status, creation_date, closure_date)
               VALUES (@abonent_id, @issue_description, @ticket_status, @creation_date, @closure_date)";

                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@abonent_id", abonentId);
                    command.Parameters.AddWithValue("@issue_description", issueDescription);
                    command.Parameters.AddWithValue("@ticket_status", ticketStatus);
                    command.Parameters.AddWithValue("@creation_date", creationDate);

                    if (closureDate.HasValue)
                        command.Parameters.AddWithValue("@closure_date", closureDate.Value);
                    else
                        command.Parameters.AddWithValue("@closure_date", DBNull.Value);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Запит створено успішно!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
                RefreshTicketsData();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedTicketId == -1)
            {
                MessageBox.Show("Спочатку виберіть запит для видалення!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей запит?",
                "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    database.openConnection();

                    string query = "DELETE FROM [InternetServiceProviderDB].[customer_service].[support_tickets] WHERE ticket_id = @ticket_id";

                    using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                    {
                        command.Parameters.AddWithValue("@ticket_id", selectedTicketId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Запит видалено успішно!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Не вдалося видалити запит!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    RefreshTicketsData();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (selectedTicketId == -1)
            {
                MessageBox.Show("Спочатку виберіть запит для оновлення!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxAbonent.SelectedItem == null || string.IsNullOrWhiteSpace(textBoxIssueDescription.Text))
            {
                MessageBox.Show("Всі поля мають бути заповнені!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int abonentId = (comboBoxAbonent.SelectedItem as ComboBoxAbonentItem).ID;
                string issueDescription = textBoxIssueDescription.Text;
                string ticketStatus = comboBoxStatus.SelectedItem.ToString();
                DateTime creationDate = dateTimePickerCreationDate.Value;
                DateTime? closureDate = null;

                if (checkBoxClosureDate.Checked)
                {
                    closureDate = dateTimePickerClosureDate.Value;
                }

                if (!ValidateStatusAndClosureDate(ticketStatus, checkBoxClosureDate.Checked))
                    return;

                database.openConnection();

                string query = @"UPDATE [InternetServiceProviderDB].[customer_service].[support_tickets]
           SET abonent_id = @abonent_id,
               issue_description = @issue_description,
               ticket_status = @ticket_status,
               creation_date = @creation_date,
               closure_date = @closure_date
           WHERE ticket_id = @ticket_id";

                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@ticket_id", selectedTicketId);
                    command.Parameters.AddWithValue("@abonent_id", abonentId);
                    command.Parameters.AddWithValue("@issue_description", issueDescription);
                    command.Parameters.AddWithValue("@ticket_status", ticketStatus);
                    command.Parameters.AddWithValue("@creation_date", creationDate);

                    if (closureDate.HasValue)
                        command.Parameters.AddWithValue("@closure_date", closureDate.Value);
                    else
                        command.Parameters.AddWithValue("@closure_date", DBNull.Value);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Запит оновлено успішно!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Не вдалося оновити запит!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                RefreshTicketsData();
            }
        }

        private void RefreshTicketsData()
        {
            try
            {
                int currentRow = -1;
                if (dataGridViewTickets.CurrentRow != null)
                {
                    currentRow = dataGridViewTickets.CurrentRow.Index;
                }

                dataGridViewTickets.DataSource = null;

                this.support_ticketsTableAdapter.Fill(this.internetServiceProviderDBDataSet3.support_tickets);

                dataGridViewTickets.DataSource = this.internetServiceProviderDBDataSet3.support_tickets;

                BeautifyDataGridView();

                if (currentRow >= 0 && currentRow < dataGridViewTickets.Rows.Count)
                {
                    dataGridViewTickets.CurrentCell = dataGridViewTickets.Rows[currentRow].Cells[0];
                    dataGridViewTickets.Rows[currentRow].Selected = true;
                }

                dataGridViewTickets.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка оновлення даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void comboBoxSearchByDate_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSearchByDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchTicketsByDate(comboBoxSearchByDate.SelectedItem.ToString());
        }

        private void SearchTicketsByDate(string dateOption)
        {
            try
            {
                string query = BuildDateFilterQuery(dateOption);
                if (string.IsNullOrEmpty(query))
                    return;

                database.openConnection();
                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewTickets.DataSource = dataTable;
                        BeautifyDataGridView();

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("За вказаний період запитів не знайдено.",
                                "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка пошуку: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }
        private string BuildDateFilterQuery(string dateOption)
        {
            string baseQuery = @"SELECT t.ticket_id, t.abonent_id, t.issue_description, t.ticket_status, 
                t.creation_date, t.closure_date 
                FROM [InternetServiceProviderDB].[customer_service].[support_tickets] t";

            switch (dateOption)
            {
                case "Всі дати":
                    return baseQuery;

                case "Сьогодні":
                    return $"{baseQuery} WHERE CONVERT(date, t.creation_date) = CONVERT(date, GETDATE())";

                case "За останній тиждень":
                    return $"{baseQuery} WHERE t.creation_date >= DATEADD(day, -7, GETDATE())";

                case "За останній місяць":
                    return $"{baseQuery} WHERE t.creation_date >= DATEADD(month, -1, GETDATE())";

                case "За останній рік":
                    return $"{baseQuery} WHERE t.creation_date >= DATEADD(year, -1, GETDATE())";

                default:
                    return baseQuery;
            }
        }

        private void buttonResetSearch_Click(object sender, EventArgs e)
        {
            RefreshTicketsData();
            comboBoxSearchByDate.SelectedIndex = 0;
        }
    }
}
