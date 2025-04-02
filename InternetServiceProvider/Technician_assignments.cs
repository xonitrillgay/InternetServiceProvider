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
using static InternetServiceProvider.Abonents;

namespace InternetServiceProvider
{
    public partial class Technician_assignments: Form
    {
        private DataBase database = new DataBase();
        private int selectedAssignmentId = -1;

        public Technician_assignments()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BeautifyDataGridView()
        {
            // Колір фону таблиці
            dataGridViewAssignments.BackgroundColor = Color.White;

            // Колір заголовків стовпців
            dataGridViewAssignments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215); // Синій
            dataGridViewAssignments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewAssignments.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewAssignments.EnableHeadersVisualStyles = false; // Вимикаємо стандартні стилі Windows

            // Колір рядків
            dataGridViewAssignments.DefaultCellStyle.BackColor = Color.White;
            dataGridViewAssignments.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewAssignments.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            // Колір вибраного рядка
            dataGridViewAssignments.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 174, 219); // Блакитний
            dataGridViewAssignments.DefaultCellStyle.SelectionForeColor = Color.White;

            // Альтернативні кольори для рядків (зебрування)
            dataGridViewAssignments.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255); // Світло-блакитний

            // Задаємо назви стовпців
            dataGridViewAssignments.Columns[0].HeaderText = "ID призначення";
            dataGridViewAssignments.Columns[1].HeaderText = "ID замовлення";
            dataGridViewAssignments.Columns[2].HeaderText = "ID технічного працівника";
            dataGridViewAssignments.Columns[3].HeaderText = "Дата реєстрації призначення";
            dataGridViewAssignments.Columns[4].HeaderText = "Дата виконання призначення";

            // Вирівнювання тексту в заголовках
            dataGridViewAssignments.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Вирівнювання тексту в комірках
            dataGridViewAssignments.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridViewAssignments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Technician_assignments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetServiceProviderDBDataSet4.technician_assignments' table. You can move, or remove it, as needed.
            this.technician_assignmentsTableAdapter.Fill(this.internetServiceProviderDBDataSet4.technician_assignments);

            // Load tickets into comboBoxTicket
            LoadTickets();

            // Load technicians into comboBoxTechnicians
            LoadTechnicians();

            // Set up the datetimepicker with today's date
            dateTimePickerAssignedDate.Value = DateTime.Now;

            // Register event handler for cell click
            dataGridViewAssignments.CellClick += DataGridViewAssignments_CellClick;

            BeautifyDataGridView();
            ClearFields();
        }
        private void LoadTickets()
        {
            try
            {
                database.openConnection();
                string query = "SELECT ticket_id, issue_description FROM [InternetServiceProviderDB].[customer_service].[support_tickets] " +
                               "WHERE ticket_status = 'Новий' OR ticket_status = 'Відкрито'";

                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    comboBoxTicket.Items.Clear();

                    while (reader.Read())
                    {
                        int ticketId = reader.GetInt32(0);
                        string description = reader.GetString(1);
                        string truncatedDescription = description.Length > 30
                            ? description.Substring(0, 30) + "..."
                            : description;

                        comboBoxTicket.Items.Add(new ComboBoxItem(ticketId, $"#{ticketId} - {truncatedDescription}"));
                    }

                    if (comboBoxTicket.Items.Count > 0)
                        comboBoxTicket.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження списку замовлень: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void LoadTechnicians()
        {
            try
            {
                database.openConnection();
                // Updated schema from staff to customer_service
                string query = "SELECT technician_id, first_name, last_name FROM [InternetServiceProviderDB].[customer_service].[technicians]";

                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    comboBoxTechnicians.Items.Clear();

                    while (reader.Read())
                    {
                        int technicianId = reader.GetInt32(0);
                        string firstName = reader.GetString(1);
                        string lastName = reader.GetString(2);

                        comboBoxTechnicians.Items.Add(new ComboBoxItem(technicianId, $"{firstName} {lastName}"));
                    }

                    if (comboBoxTechnicians.Items.Count > 0)
                        comboBoxTechnicians.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження списку техніків: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void DataGridViewAssignments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewAssignments.Rows[e.RowIndex];
                selectedAssignmentId = Convert.ToInt32(row.Cells["assignmentidDataGridViewTextBoxColumn"].Value);

                int ticketId = Convert.ToInt32(row.Cells["ticketidDataGridViewTextBoxColumn"].Value);
                int technicianId = Convert.ToInt32(row.Cells["technicianidDataGridViewTextBoxColumn"].Value);

                // Find and select the ticket in comboBoxTicket
                SelectComboBoxItemById(comboBoxTicket, ticketId);

                // Find and select the technician in comboBoxTechnicians
                SelectComboBoxItemById(comboBoxTechnicians, technicianId);

                // Set the assigned date
                if (row.Cells["assigneddateDataGridViewTextBoxColumn"].Value != DBNull.Value)
                {
                    dateTimePickerAssignedDate.Value = Convert.ToDateTime(row.Cells["assigneddateDataGridViewTextBoxColumn"].Value);
                }
                else
                {
                    dateTimePickerAssignedDate.Value = DateTime.Now;
                }
            }
        }

        private void SelectComboBoxItemById(ComboBox comboBox, int id)
        {
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                if (comboBox.Items[i] is ComboBoxItem item && item.Id == id)
                {
                    comboBox.SelectedIndex = i;
                    return;
                }
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (comboBoxTicket.SelectedItem == null || comboBoxTechnicians.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть замовлення та технічного працівника.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ticketId = ((ComboBoxItem)comboBoxTicket.SelectedItem).Id;
            int technicianId = ((ComboBoxItem)comboBoxTechnicians.SelectedItem).Id;
            DateTime assignedDate = dateTimePickerAssignedDate.Value;

            try
            {
                database.openConnection();

                // Check if this ticket is already assigned
                string checkQuery = "SELECT COUNT(*) FROM [InternetServiceProviderDB].[customer_service].[technician_assignments] WHERE ticket_id = @ticket_id";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, database.getConnection()))
                {
                    checkCommand.Parameters.AddWithValue("@ticket_id", ticketId);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Це замовлення вже призначено техніку. Будь ласка, оновіть існуюче призначення або виберіть інше замовлення.",
                            "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Get ticket creation date to ensure assigned date is after it
                DateTime ticketCreationDate = DateTime.Now;
                string getTicketDateQuery = @"SELECT creation_date FROM [InternetServiceProviderDB].[customer_service].[support_tickets] 
                                     WHERE ticket_id = @ticket_id";
                using (SqlCommand dateCommand = new SqlCommand(getTicketDateQuery, database.getConnection()))
                {
                    dateCommand.Parameters.AddWithValue("@ticket_id", ticketId);
                    object result = dateCommand.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        ticketCreationDate = Convert.ToDateTime(result);
                    }
                }

                // Validate that assigned date is after ticket creation date
                if (assignedDate < ticketCreationDate)
                {
                    MessageBox.Show($"Дата призначення не може бути раніше дати створення замовлення ({ticketCreationDate.ToShortDateString()}).",
                        "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create new assignment - update schema from staff to customer_service
                string insertQuery = @"INSERT INTO [InternetServiceProviderDB].[customer_service].[technician_assignments] 
                            (ticket_id, technician_id, assigned_date) 
                            VALUES (@ticket_id, @technician_id, @assigned_date)";

                using (SqlCommand command = new SqlCommand(insertQuery, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@ticket_id", ticketId);
                    command.Parameters.AddWithValue("@technician_id", technicianId);
                    command.Parameters.AddWithValue("@assigned_date", assignedDate);

                    command.ExecuteNonQuery();

                    // Also update the ticket status to "В обробці"
                    string updateTicketQuery = @"UPDATE [InternetServiceProviderDB].[customer_service].[support_tickets] 
                                     SET ticket_status = 'В обробці' 
                                     WHERE ticket_id = @ticket_id";

                    using (SqlCommand updateCommand = new SqlCommand(updateTicketQuery, database.getConnection()))
                    {
                        updateCommand.Parameters.AddWithValue("@ticket_id", ticketId);
                        updateCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Призначення створено успішно!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при створенні призначення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (selectedAssignmentId == -1)
            {
                MessageBox.Show("Будь ласка, виберіть призначення для оновлення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxTicket.SelectedItem == null || comboBoxTechnicians.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть замовлення та технічного працівника.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ticketId = ((ComboBoxItem)comboBoxTicket.SelectedItem).Id;
            int technicianId = ((ComboBoxItem)comboBoxTechnicians.SelectedItem).Id;
            DateTime assignedDate = dateTimePickerAssignedDate.Value;

            try
            {
                database.openConnection();

                // Get ticket creation date to ensure assigned date is after it
                DateTime ticketCreationDate = DateTime.Now;
                string getTicketDateQuery = @"SELECT creation_date FROM [InternetServiceProviderDB].[customer_service].[support_tickets] 
                                     WHERE ticket_id = @ticket_id";
                using (SqlCommand dateCommand = new SqlCommand(getTicketDateQuery, database.getConnection()))
                {
                    dateCommand.Parameters.AddWithValue("@ticket_id", ticketId);
                    object result = dateCommand.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        ticketCreationDate = Convert.ToDateTime(result);
                    }
                }

                // Validate that assigned date is after ticket creation date
                if (assignedDate < ticketCreationDate)
                {
                    MessageBox.Show($"Дата призначення не може бути раніше дати створення замовлення ({ticketCreationDate.ToShortDateString()}).",
                        "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update assignment - updated schema from staff to customer_service
                string updateQuery = @"UPDATE [InternetServiceProviderDB].[customer_service].[technician_assignments] 
                            SET ticket_id = @ticket_id, 
                                technician_id = @technician_id, 
                                assigned_date = @assigned_date 
                            WHERE assignment_id = @assignment_id";

                using (SqlCommand command = new SqlCommand(updateQuery, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@assignment_id", selectedAssignmentId);
                    command.Parameters.AddWithValue("@ticket_id", ticketId);
                    command.Parameters.AddWithValue("@technician_id", technicianId);
                    command.Parameters.AddWithValue("@assigned_date", assignedDate);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Призначення оновлено успішно!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Не вдалося оновити призначення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при оновленні призначення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void ClearFields()
        {
            if (comboBoxTicket.Items.Count > 0)
                comboBoxTicket.SelectedIndex = 0;

            if (comboBoxTechnicians.Items.Count > 0)
                comboBoxTechnicians.SelectedIndex = 0;

            dateTimePickerAssignedDate.Value = DateTime.Now;
            selectedAssignmentId = -1;
        }
        private void RefreshData()
        {
            try
            {
                // Refresh assignments data
                this.technician_assignmentsTableAdapter.Fill(this.internetServiceProviderDBDataSet4.technician_assignments);

                // Refresh tickets list as some may have changed status
                LoadTickets();

                BeautifyDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка оновлення даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper class for combo box items
        private class ComboBoxItem
        {
            public int Id { get; }
            public string Text { get; }

            public ComboBoxItem(int id, string text)
            {
                Id = id;
                Text = text;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            if (selectedAssignmentId == -1)
            {
                MessageBox.Show("Будь ласка, виберіть призначення для завершення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                database.openConnection();

                // Get the ticket_id for the selected assignment
                int ticketId = 0;
                string getTicketQuery = @"SELECT ticket_id FROM [InternetServiceProviderDB].[customer_service].[technician_assignments] 
                                WHERE assignment_id = @assignment_id";
                using (SqlCommand getCommand = new SqlCommand(getTicketQuery, database.getConnection()))
                {
                    getCommand.Parameters.AddWithValue("@assignment_id", selectedAssignmentId);
                    object result = getCommand.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        ticketId = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Не вдалося знайти відповідний запит.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Mark the ticket as completed with current date
                DateTime completionDate = DateTime.Now;
                string updateTicketQuery = @"UPDATE [InternetServiceProviderDB].[customer_service].[support_tickets] 
                                  SET ticket_status = 'Закрито', 
                                      closure_date = @closure_date
                                  WHERE ticket_id = @ticket_id";

                using (SqlCommand updateTicketCommand = new SqlCommand(updateTicketQuery, database.getConnection()))
                {
                    updateTicketCommand.Parameters.AddWithValue("@ticket_id", ticketId);
                    updateTicketCommand.Parameters.AddWithValue("@closure_date", completionDate);
                    updateTicketCommand.ExecuteNonQuery();
                }

                // Update the assignment with the same completion date
                string updateAssignmentQuery = @"UPDATE [InternetServiceProviderDB].[customer_service].[technician_assignments] 
                                      SET completion_date = @completion_date 
                                      WHERE assignment_id = @assignment_id";

                using (SqlCommand updateAssignmentCommand = new SqlCommand(updateAssignmentQuery, database.getConnection()))
                {
                    updateAssignmentCommand.Parameters.AddWithValue("@assignment_id", selectedAssignmentId);
                    updateAssignmentCommand.Parameters.AddWithValue("@completion_date", completionDate);
                    updateAssignmentCommand.ExecuteNonQuery();
                }

                MessageBox.Show("Призначення та запит успішно завершено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завершенні призначення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void pictureBoxClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
