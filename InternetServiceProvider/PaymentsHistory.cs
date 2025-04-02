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
    public partial class PaymentsHistory: Form
    {
        private DataBase database = new DataBase();
        private int selectedPaymentId = -1;

        public PaymentsHistory()
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

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Вирівнювання тексту в комірках для всіх стовпців
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Задаємо назви стовпців
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "ID абонента";
            dataGridView1.Columns[2].HeaderText = "Сума";
            dataGridView1.Columns[3].HeaderText = "Дата оплати";
            dataGridView1.Columns[4].HeaderText = "Метод оплати";
            dataGridView1.Columns[5].HeaderText = "ID наданої послуги";

            // Вирівнювання тексту в заголовках
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Форматування стовпця з сумою для відображення з двома десятковими знаками
            dataGridView1.Columns[2].DefaultCellStyle.Format = "N2";

            // Форматування стовпця з датою
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void PaymentsHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paymentHistoryDataSet.payment_history' table. You can move, or remove it, as needed.
            this.payment_historyTableAdapter.Fill(this.paymentHistoryDataSet.payment_history);

            LoadAbonentsComboBox();
            LoadTicketsComboBox();
            SetupPaymentMethodsComboBox();

            radioButtonStatus.Checked = false;
            dateTimePickerPaymentDate.Enabled = false;
            dateTimePickerPaymentDate.Visible = false;

            BeautifyDataGridView();
            ClearFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PaymentsHistoryReport paymentsHistoryReport = new PaymentsHistoryReport();
            paymentsHistoryReport.Show();
        }

        private void radioButtonStatus_CheckedChanged(object sender, EventArgs e)
        {
            // Show or hide the dateTimePicker based on the radioButton's checked state
            dateTimePickerPaymentDate.Enabled = radioButtonStatus.Checked;
            dateTimePickerPaymentDate.Visible = radioButtonStatus.Checked;

            // If radioButton is checked, set date to today or ticket creation date (whichever is later)
            if (radioButtonStatus.Checked)
            {
                // If a ticket is selected (not the first "no ticket" option), get its creation date
                if (comboBoxTicketDescription.SelectedIndex > 0 && comboBoxTicketDescription.SelectedItem is ComboBoxItem item)
                {
                    int ticketId = item.Id;
                    DateTime ticketCreationDate = GetTicketCreationDate(ticketId);

                    // Set the min date for the date picker to prevent selecting dates before ticket creation
                    dateTimePickerPaymentDate.MinDate = ticketCreationDate > DateTime.MinValue ?
                        ticketCreationDate : DateTime.Today.AddYears(-1); // Fallback if we couldn't get the date

                    // Set the current value to either today or the ticket creation date, whichever is later
                    dateTimePickerPaymentDate.Value = DateTime.Today > ticketCreationDate ? DateTime.Today : ticketCreationDate;
                }
                else
                {
                    // No ticket selected, so just use today and allow selecting past dates (within reason)
                    dateTimePickerPaymentDate.MinDate = DateTime.Today.AddYears(-1);
                    dateTimePickerPaymentDate.Value = DateTime.Today;
                }
            }
        }
        private void LoadAbonentsComboBox()
        {
            List<Tuple<int, string, string>> abonentData = new List<Tuple<int, string, string>>();

            try
            {
                // Create a separate connection for this method
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PVF0G00\\SQLEXPRESS;Initial Catalog=InternetServiceProviderDB;Integrated Security=True"))
                {
                    conn.Open();

                    string query = "SELECT abonent_id, first_name, last_name FROM [InternetServiceProviderDB].[service].[abonents]";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int abonentId = reader.GetInt32(0);
                            string firstName = reader.GetString(1);
                            string lastName = reader.GetString(2);

                            abonentData.Add(new Tuple<int, string, string>(abonentId, firstName, lastName));
                        }
                    }
                } // Connection is closed here

                // Update UI with collected data
                comboBoxAbonent.Items.Clear();

                foreach (var abonent in abonentData)
                {
                    int abonentId = abonent.Item1;
                    string firstName = abonent.Item2;
                    string lastName = abonent.Item3;

                    ComboBoxItem item = new ComboBoxItem(abonentId, $"{firstName} {lastName}");
                    comboBoxAbonent.Items.Add(item);
                }

                if (comboBoxAbonent.Items.Count > 0)
                    comboBoxAbonent.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження абонентів: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadTicketsComboBox(int abonentId = -1)
        {
            // First, store all the data we need in a local list to avoid keeping a connection open
            List<Tuple<int, string>> ticketData = new List<Tuple<int, string>>();

            try
            {
                // Create a separate connection for this method
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PVF0G00\\SQLEXPRESS;Initial Catalog=InternetServiceProviderDB;Integrated Security=True"))
                {
                    conn.Open();

                    string query = @"SELECT t.ticket_id, t.issue_description 
                    FROM [InternetServiceProviderDB].[customer_service].[support_tickets] t";

                    // If an abonent is selected, filter tickets for that abonent
                    if (abonentId > 0)
                    {
                        query += " WHERE t.abonent_id = @abonent_id";
                    }

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        if (abonentId > 0)
                        {
                            command.Parameters.AddWithValue("@abonent_id", abonentId);
                        }

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int ticketId = reader.GetInt32(0);
                                string description = reader.GetString(1);
                                ticketData.Add(new Tuple<int, string>(ticketId, description));
                            }
                        }
                    }
                } // Connection is closed here by the using statement

                // Now we update the UI with our collected data
                comboBoxTicketDescription.Items.Clear();

                // Add empty item for payments without a ticket
                comboBoxTicketDescription.Items.Add(new ComboBoxItem(-1, "-- Без заявки --"));

                // Add all the tickets we retrieved
                foreach (var ticket in ticketData)
                {
                    int ticketId = ticket.Item1;
                    string description = ticket.Item2;
                    string truncatedDescription = description.Length > 50
                        ? description.Substring(0, 50) + "..."
                        : description;

                    ComboBoxItem item = new ComboBoxItem(ticketId, $"#{ticketId} - {truncatedDescription}");
                    comboBoxTicketDescription.Items.Add(item);
                }

                if (comboBoxTicketDescription.Items.Count > 0)
                    comboBoxTicketDescription.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження заявок: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupPaymentMethodsComboBox()
        {
            comboBoxPaymentMethod.Items.Clear();
            comboBoxPaymentMethod.Items.AddRange(new string[]
            {
                "Готівка",
                "Кредитна картка",
                "Дебетова картка",
                "Банківський переказ",
                "Електронний платіж",
                "Інше"
            });

            if (comboBoxPaymentMethod.Items.Count > 0)
                comboBoxPaymentMethod.SelectedIndex = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Get the payment ID from the selected row
                selectedPaymentId = Convert.ToInt32(row.Cells[0].Value);

                // Get abonent ID and set selection in combobox
                int abonentId = Convert.ToInt32(row.Cells[1].Value);
                SelectComboBoxItemById(comboBoxAbonent, abonentId);

                // When abonent is selected, the tickets combobox is automatically reloaded for this abonent
                // via the comboBoxAbonent_SelectedIndexChanged event

                // Set amount
                decimal amount = Convert.ToDecimal(row.Cells[2].Value);
                textBoxAmount.Text = amount.ToString("F2");

                // Update radioButtonStatus and dateTimePickerPaymentDate based on payment date
                if (row.Cells[3].Value != DBNull.Value)
                {
                    radioButtonStatus.Checked = true; // This will trigger the event to show the datetimepicker
                    dateTimePickerPaymentDate.Value = Convert.ToDateTime(row.Cells[3].Value);
                }
                else
                {
                    radioButtonStatus.Checked = false; // This will trigger the event to hide the datetimepicker
                }

                // Get payment method from the correct column (index 4, not 5)
                string paymentMethod = row.Cells[4].Value.ToString();
                if (comboBoxPaymentMethod.Items.Contains(paymentMethod))
                {
                    comboBoxPaymentMethod.SelectedItem = paymentMethod;
                }
                else
                {
                    comboBoxPaymentMethod.SelectedIndex = comboBoxPaymentMethod.Items.Count - 1; // Select "Інше"
                }

                // Get ticket ID (if associated)
                int ticketId = GetTicketIdForPayment(selectedPaymentId);
                if (ticketId > 0)
                {
                    // This may fail if the tickets aren't loaded yet because a different abonent was selected
                    SelectComboBoxItemById(comboBoxTicketDescription, ticketId);
                }
                else
                {
                    // If no ticket associated, select "Без заявки"
                    comboBoxTicketDescription.SelectedIndex = 0;
                }
            }
        }
        private void CheckTicketBelongsToAbonent(int ticketId, int abonentId)
        {
            try
            {
                // Create a separate connection for this method
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PVF0G00\\SQLEXPRESS;Initial Catalog=InternetServiceProviderDB;Integrated Security=True"))
                {
                    conn.Open();

                    string query = @"SELECT COUNT(*) FROM [InternetServiceProviderDB].[customer_service].[support_tickets] 
                    WHERE ticket_id = @ticket_id AND abonent_id = @abonent_id";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@ticket_id", ticketId);
                        command.Parameters.AddWithValue("@abonent_id", abonentId);

                        int count = (int)command.ExecuteScalar();

                        if (count == 0)
                        {
                            throw new Exception("Обрана заявка не належить вибраному абоненту.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Помилка перевірки приналежності заявки: " + ex.Message);
            }
        }

        private int GetTicketIdForPayment(int paymentId)
        {
            int ticketId = -1;
            try
            {
                // Create a separate connection for this method
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PVF0G00\\SQLEXPRESS;Initial Catalog=InternetServiceProviderDB;Integrated Security=True"))
                {
                    conn.Open();

                    string query = "SELECT ticket_id FROM [InternetServiceProviderDB].[customer_service].[payment_history] WHERE payment_id = @payment_id";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@payment_id", paymentId);
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            ticketId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка отримання номера заявки: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ticketId;
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
            // Existing validation code remains unchanged
            if (comboBoxAbonent.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть абонента.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxAmount.Text))
            {
                MessageBox.Show("Будь ласка, введіть суму платежу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxPaymentMethod.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть спосіб оплати.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal amount;
            if (!decimal.TryParse(textBoxAmount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну суму платежу (додатнє число).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get selected values
                int abonentId = ((ComboBoxItem)comboBoxAbonent.SelectedItem).Id;
                string paymentMethod = comboBoxPaymentMethod.SelectedItem.ToString();

                // Get payment date based on radioButton status
                DateTime? paymentDate = null;
                if (radioButtonStatus.Checked)
                {
                    paymentDate = dateTimePickerPaymentDate.Value;
                }

                // Get ticket ID if selected (not "Без заявки")
                int? ticketId = null;
                if (comboBoxTicketDescription.SelectedIndex > 0) // not the first item
                {
                    ticketId = ((ComboBoxItem)comboBoxTicketDescription.SelectedItem).Id;

                    // Make sure the ticket belongs to the selected abonent
                    CheckTicketBelongsToAbonent(ticketId.Value, abonentId);

                    // Check that payment date is valid for this ticket (on or after creation date)
                    if (paymentDate.HasValue)
                    {
                        DateTime ticketCreationDate = GetTicketCreationDate(ticketId.Value);
                        if (paymentDate.Value.Date < ticketCreationDate.Date)
                        {
                            MessageBox.Show(
                                $"Дата оплати не може бути раніше дати створення заявки ({ticketCreationDate.ToShortDateString()}).",
                                "Помилка валідації",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }
                    }
                }

                database.openConnection();

                string query = @"
            INSERT INTO [InternetServiceProviderDB].[customer_service].[payment_history]
            (abonent_id, amount, payment_date, payment_method, ticket_id)
            VALUES (@abonent_id, @amount, @payment_date, @payment_method, @ticket_id)";

                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@abonent_id", abonentId);
                    command.Parameters.AddWithValue("@amount", amount);

                    // Handle nullable payment date
                    if (paymentDate.HasValue)
                        command.Parameters.AddWithValue("@payment_date", paymentDate.Value);
                    else
                        command.Parameters.AddWithValue("@payment_date", DBNull.Value);

                    command.Parameters.AddWithValue("@payment_method", paymentMethod);

                    if (ticketId.HasValue)
                        command.Parameters.AddWithValue("@ticket_id", ticketId.Value);
                    else
                        command.Parameters.AddWithValue("@ticket_id", DBNull.Value);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Платіж успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні платежу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPaymentId == -1)
            {
                MessageBox.Show("Будь ласка, виберіть платіж для оновлення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate input (same as in Create method)
            if (comboBoxAbonent.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть абонента.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxAmount.Text))
            {
                MessageBox.Show("Будь ласка, введіть суму платежу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxPaymentMethod.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть спосіб оплати.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal amount;
            if (!decimal.TryParse(textBoxAmount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Будь ласка, введіть коректну суму платежу (додатнє число).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Get selected values
                int abonentId = ((ComboBoxItem)comboBoxAbonent.SelectedItem).Id;
                string paymentMethod = comboBoxPaymentMethod.SelectedItem.ToString();

                // Get payment date based on radioButton status
                DateTime? paymentDate = null;
                if (radioButtonStatus.Checked)
                {
                    paymentDate = dateTimePickerPaymentDate.Value;
                }

                // Get ticket ID if selected (not "Без заявки")
                int? ticketId = null;
                if (comboBoxTicketDescription.SelectedIndex > 0) // not the first item
                {
                    ticketId = ((ComboBoxItem)comboBoxTicketDescription.SelectedItem).Id;

                    // Make sure the ticket belongs to the selected abonent
                    CheckTicketBelongsToAbonent(ticketId.Value, abonentId);

                    // Check that payment date is valid for this ticket (on or after creation date)
                    if (paymentDate.HasValue)
                    {
                        DateTime ticketCreationDate = GetTicketCreationDate(ticketId.Value);
                        if (paymentDate.Value.Date < ticketCreationDate.Date)
                        {
                            MessageBox.Show(
                                $"Дата оплати не може бути раніше дати створення заявки ({ticketCreationDate.ToShortDateString()}).",
                                "Помилка валідації",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }
                    }
                }

                database.openConnection();

                string query = @"
            UPDATE [InternetServiceProviderDB].[customer_service].[payment_history]
            SET abonent_id = @abonent_id,
                amount = @amount,
                payment_date = @payment_date,
                payment_method = @payment_method,
                ticket_id = @ticket_id
            WHERE payment_id = @payment_id";

                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@payment_id", selectedPaymentId);
                    command.Parameters.AddWithValue("@abonent_id", abonentId);
                    command.Parameters.AddWithValue("@amount", amount);

                    // Handle nullable payment date
                    if (paymentDate.HasValue)
                        command.Parameters.AddWithValue("@payment_date", paymentDate.Value);
                    else
                        command.Parameters.AddWithValue("@payment_date", DBNull.Value);

                    command.Parameters.AddWithValue("@payment_method", paymentMethod);

                    if (ticketId.HasValue)
                        command.Parameters.AddWithValue("@ticket_id", ticketId.Value);
                    else
                        command.Parameters.AddWithValue("@ticket_id", DBNull.Value);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Платіж успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Не вдалося оновити платіж. Можливо, його було видалено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при оновленні платежу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                database.closeConnection();
            }
        }
        private DateTime GetTicketCreationDate(int ticketId)
        {
            DateTime creationDate = DateTime.MinValue;

            try
            {
                // Create a separate connection for this method
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PVF0G00\\SQLEXPRESS;Initial Catalog=InternetServiceProviderDB;Integrated Security=True"))
                {
                    conn.Open();

                    string query = "SELECT creation_date FROM [InternetServiceProviderDB].[customer_service].[support_tickets] WHERE ticket_id = @ticket_id";

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@ticket_id", ticketId);
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            creationDate = Convert.ToDateTime(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка отримання дати створення заявки: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return creationDate;
        }

        private void pictureBoxClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            // Reset selection
            selectedPaymentId = -1;

            // Reset controls
            if (comboBoxAbonent.Items.Count > 0)
                comboBoxAbonent.SelectedIndex = 0;

            textBoxAmount.Text = string.Empty;

            // Reset radioButton and dateTimePicker
            radioButtonStatus.Checked = false;

            if (comboBoxTicketDescription.Items.Count > 0)
                comboBoxTicketDescription.SelectedIndex = 0;

            if (comboBoxPaymentMethod.Items.Count > 0)
                comboBoxPaymentMethod.SelectedIndex = 0;
        }
        private void RefreshData()
        {
            this.payment_historyTableAdapter.Fill(this.paymentHistoryDataSet.payment_history);
            BeautifyDataGridView();
        }
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

        private void comboBoxTicketDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Only proceed if the radio button is checked (meaning payment date is being shown/used)
            if (radioButtonStatus.Checked)
            {
                // If a ticket is selected (not the first "no ticket" option), get its creation date
                if (comboBoxTicketDescription.SelectedIndex > 0 && comboBoxTicketDescription.SelectedItem is ComboBoxItem item)
                {
                    int ticketId = item.Id;
                    DateTime ticketCreationDate = GetTicketCreationDate(ticketId);

                    if (ticketCreationDate > DateTime.MinValue)
                    {
                        // Set the min date for the date picker to prevent selecting dates before ticket creation
                        dateTimePickerPaymentDate.MinDate = ticketCreationDate;

                        // If current value is earlier than creation date, update it
                        if (dateTimePickerPaymentDate.Value < ticketCreationDate)
                        {
                            dateTimePickerPaymentDate.Value = ticketCreationDate;
                        }
                    }
                }
                else
                {
                    // No ticket selected, so just allow selecting past dates (within reason)
                    dateTimePickerPaymentDate.MinDate = DateTime.Today.AddYears(-1);
                }
            }
        }

        private void comboBoxAbonent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAbonent.SelectedItem is ComboBoxItem selectedAbonent)
            {
                // Reload tickets for the selected abonent
                int abonentId = selectedAbonent.Id;
                LoadTicketsComboBox(abonentId);
            }
        }
    }
}
