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
    public partial class Devices: Form
    {
        private DataBase database = new DataBase();
        private int selectedDeviceId = -1;

        public Devices()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            SetupDeviceTypeComboBox();
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
            dataGridView1.Columns[1].HeaderText = "Назва";
            dataGridView1.Columns[2].HeaderText = "Тип обладнання";

            // Вирівнювання тексту в заголовках
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Devices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetServiceProviderDBDataSet1.devices' table. You can move, or remove it, as needed.
            this.devicesTableAdapter.Fill(this.internetServiceProviderDBDataSet1.devices);

            ClearFields();
            BeautifyDataGridView();
        }
        private void SetupDeviceTypeComboBox()
        {
            // Fill the device type combobox with predefined values in Ukrainian
            comboBoxDeviceType.Items.Clear();
            comboBoxDeviceType.Items.AddRange(new string[] {
                "Маршрутизатор",
                "Комутатор",
                "Модем",
                "Оптичний приймач",
                "Wi-Fi точка доступу",
                "Медіаконвертер",
                "Мережева карта",
                "Інше обладнання"
            });
            comboBoxDeviceType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ClearFields()
        {
            textBoxDeviceName.Text = "";
            comboBoxDeviceType.SelectedIndex = -1;
        }
        private void RefreshDevicesData(string nameFilter = "")
        {
            try
            {
                // Store the current position to restore it after refresh
                int currentRow = -1;
                if (dataGridView1.CurrentRow != null)
                {
                    currentRow = dataGridView1.CurrentRow.Index;
                }

                // Clear the current DataSource
                dataGridView1.DataSource = null;

                // Use direct SQL query instead of TableAdapter
                database.openConnection();

                string query;
                SqlCommand command;

                // If a name filter is provided, use a WHERE clause to filter
                if (!string.IsNullOrWhiteSpace(nameFilter))
                {
                    query = @"SELECT device_id, device_name, device_type 
                    FROM [InternetServiceProviderDB].[service].[devices]
                    WHERE device_name LIKE @nameFilter";

                    command = new SqlCommand(query, database.getConnection());
                    command.Parameters.AddWithValue("@nameFilter", "%" + nameFilter + "%");
                }
                else
                {
                    // No filter, get all devices
                    query = "SELECT device_id, device_name, device_type FROM [InternetServiceProviderDB].[service].[devices]";
                    command = new SqlCommand(query, database.getConnection());
                }

                // Create a DataTable to hold the results
                DataTable dataTable = new DataTable();

                // Use SqlDataAdapter to fill the DataTable
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);

                    // Set the DataTable as the DataSource for the DataGridView
                    dataGridView1.DataSource = dataTable;
                }

                // Apply formatting
                BeautifyDataGridView();

                // Try to restore the previous selected row if possible
                if (currentRow >= 0 && currentRow < dataGridView1.Rows.Count)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[currentRow].Cells[0];
                    dataGridView1.Rows[currentRow].Selected = true;
                }

                // Force the DataGridView to refresh its display
                dataGridView1.Refresh();

                // Display message if no records found
                if (dataTable.Rows.Count == 0 && !string.IsNullOrWhiteSpace(nameFilter))
                {
                    MessageBox.Show($"За запитом \"{nameFilter}\" пристроїв не знайдено.",
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

        // Add a method to handle the search button click
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string nameFilter = textBoxSearchByName.Text.Trim();
            RefreshDevicesData(nameFilter);
        }

        // Add a method to handle Enter key press in the search textbox
        private void textBoxSearchByName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the beep sound
                buttonSearch_Click(sender, e);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(textBoxDeviceName.Text) || comboBoxDeviceType.SelectedIndex == -1)
            {
                MessageBox.Show("Всі поля мають бути заповнені!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string deviceName = textBoxDeviceName.Text.Trim();
                string deviceType = comboBoxDeviceType.SelectedItem.ToString();

                database.openConnection();

                string query = @"INSERT INTO [InternetServiceProviderDB].[service].[devices]
                                (device_name, device_type)
                                VALUES (@device_name, @device_type)";

                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@device_name", deviceName);
                    command.Parameters.AddWithValue("@device_type", deviceType);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Пристрій додано успішно!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                RefreshDevicesData();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (selectedDeviceId == -1)
            {
                MessageBox.Show("Спочатку виберіть пристрій для видалення!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей пристрій?",
                "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    database.openConnection();

                    string query = "DELETE FROM [InternetServiceProviderDB].[service].[devices] WHERE device_id = @device_id";

                    using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                    {
                        command.Parameters.AddWithValue("@device_id", selectedDeviceId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Пристрій видалено успішно!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Не вдалося видалити пристрій!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    RefreshDevicesData();
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (selectedDeviceId == -1)
            {
                MessageBox.Show("Спочатку виберіть пристрій для оновлення!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxDeviceName.Text) || comboBoxDeviceType.SelectedIndex == -1)
            {
                MessageBox.Show("Всі поля мають бути заповнені!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string deviceName = textBoxDeviceName.Text.Trim();
                string deviceType = comboBoxDeviceType.SelectedItem.ToString();

                database.openConnection();

                string query = @"UPDATE [InternetServiceProviderDB].[service].[devices]
                               SET device_name = @device_name,
                                   device_type = @device_type
                               WHERE device_id = @device_id";

                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@device_id", selectedDeviceId);
                    command.Parameters.AddWithValue("@device_name", deviceName);
                    command.Parameters.AddWithValue("@device_type", deviceType);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Пристрій оновлено успішно!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Не вдалося оновити пристрій!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                RefreshDevicesData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                selectedDeviceId = Convert.ToInt32(row.Cells["deviceidDataGridViewTextBoxColumn"].Value);

                // Fill form fields with selected device data
                if (row.Cells["devicenameDataGridViewTextBoxColumn"].Value != null)
                    textBoxDeviceName.Text = row.Cells["devicenameDataGridViewTextBoxColumn"].Value.ToString();

                if (row.Cells["devicetypeDataGridViewTextBoxColumn"].Value != null)
                {
                    string deviceType = row.Cells["devicetypeDataGridViewTextBoxColumn"].Value.ToString();
                    int typeIndex = comboBoxDeviceType.Items.IndexOf(deviceType);
                    if (typeIndex >= 0)
                        comboBoxDeviceType.SelectedIndex = typeIndex;
                    else if (comboBoxDeviceType.Items.Count > 0)
                    {
                        // If the exact type is not found in the combobox, select "Інше обладнання" if available
                        int otherIndex = comboBoxDeviceType.Items.IndexOf("Інше обладнання");
                        if (otherIndex >= 0)
                            comboBoxDeviceType.SelectedIndex = otherIndex;
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void buttonResetSearch_Click(object sender, EventArgs e)
        {
            textBoxSearchByName.Clear();
            RefreshDevicesData();
        }
    }
}
