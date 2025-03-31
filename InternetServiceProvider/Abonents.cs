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

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }


        public Abonents()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BeautifyDataGridView()
        {
            if (dataGridView1.Columns.Count == 0)
                return;

            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 174, 219);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255);

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Ім'я";
            dataGridView1.Columns[2].HeaderText = "Прізвище";
            dataGridView1.Columns[3].HeaderText = "Телефон";
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[5].HeaderText = "Адреса";
            dataGridView1.Columns[6].HeaderText = "Тариф";
            dataGridView1.Columns[7].HeaderText = "Обладнання";

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            int totalColumnWidth = 0;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Visible)
                {
                    col.Width += 10;
                    totalColumnWidth += col.Width;
                }
            }

            if (totalColumnWidth < dataGridView1.Width && dataGridView1.Columns.Cast<DataGridViewColumn>().Any(c => c.Visible))
            {
                var lastVisibleColumn = dataGridView1.Columns.Cast<DataGridViewColumn>().Last(c => c.Visible);
                lastVisibleColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                string query = @"SELECT a.abonent_id, a.first_name, a.last_name, a.phone, a.email, 
                a.address, p.plan_name, d.device_name, a.plan_id, a.device_id
                FROM [InternetServiceProviderDB].[service].[abonents] a
                LEFT JOIN [InternetServiceProviderDB].[service].[plans] p ON a.plan_id = p.plan_id
                LEFT JOIN [InternetServiceProviderDB].[service].[devices] d ON a.device_id = d.device_id";

                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;

                        if (dataGridView1.Columns["plan_id"] != null)
                            dataGridView1.Columns["plan_id"].Visible = false;
                        if (dataGridView1.Columns["device_id"] != null)
                            dataGridView1.Columns["device_id"].Visible = false;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка оновлення інформації: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string query = "SELECT plan_id, plan_name FROM [InternetServiceProviderDB].[service].[plans]";
                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        comboBoxPlanID.Items.Clear();
                        while (reader.Read())
                        {
                            comboBoxPlanID.Items.Add(new ComboBoxItem
                            {
                                Text = reader["plan_name"].ToString(),
                                Value = reader["plan_id"].ToString()
                            });
                        }
                    }
                }

                comboBoxPlanID.DisplayMember = "Text";
                comboBoxPlanID.ValueMember = "Value";
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

        private void FillComboBoxDeviceID()
        {
            database.openConnection();
            try
            {
                string query = "SELECT device_id, device_name FROM [InternetServiceProviderDB].[service].[devices]";
                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        comboBoxDeviceID.Items.Clear();
                        while (reader.Read())
                        {
                            comboBoxDeviceID.Items.Add(new ComboBoxItem
                            {
                                Text = reader["device_name"].ToString(),
                                Value = reader["device_id"].ToString()
                            });
                        }
                    }
                }

                comboBoxDeviceID.DisplayMember = "Text";
                comboBoxDeviceID.ValueMember = "Value";
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

            string plan_id = (comboBoxPlanID.SelectedItem as ComboBoxItem)?.Value;
            string device_id = (comboBoxDeviceID.SelectedItem as ComboBoxItem)?.Value;

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
            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Виберіть рядок для оновлення!", "Помилка",
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

            string first_name = textBoxName.Text;
            string last_name = textBoxLastName.Text;
            string abonent_phone = textBoxTelephone.Text;
            string abonent_email = textBoxEmail.Text;
            string abonent_address = textBoxAddress.Text;

            string plan_id = (comboBoxPlanID.SelectedItem as ComboBoxItem)?.Value;
            string device_id = (comboBoxDeviceID.SelectedItem as ComboBoxItem)?.Value;

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
                RefreshAbonentsDataGrid();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBoxName.Text = row.Cells[1].Value?.ToString() ?? "";
                textBoxLastName.Text = row.Cells[2].Value?.ToString() ?? "";
                textBoxTelephone.Text = row.Cells[3].Value?.ToString() ?? "";
                textBoxEmail.Text = row.Cells[4].Value?.ToString() ?? "";
                textBoxAddress.Text = row.Cells[5].Value?.ToString() ?? "";

                string planId = row.Cells["planidDataGridViewTextBoxColumn"].Value?.ToString() ?? "";
                string deviceId = row.Cells["deviceidDataGridViewTextBoxColumn"].Value?.ToString() ?? "";

                SelectComboBoxItemByValue(comboBoxPlanID, planId);
                SelectComboBoxItemByValue(comboBoxDeviceID, deviceId);
            }
        }

        private void SelectComboBoxItemByValue(ComboBox comboBox, string value)
        {
            bool itemFound = false;
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                ComboBoxItem item = comboBox.Items[i] as ComboBoxItem;
                if (item != null && item.Value == value)
                {
                    comboBox.SelectedIndex = i;
                    itemFound = true;
                    break;
                }
            }

            if (!itemFound)
            {
                comboBox.SelectedIndex = -1;
                MessageBox.Show($"Item '{value}' not found in {comboBox.Name}.", "Item Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearFields()
        {
            textBoxName.Text = "";
            textBoxLastName.Text = "";
            textBoxTelephone.Text = "";
            textBoxEmail.Text = "";
            textBoxAddress.Text = "";
            comboBoxPlanID.SelectedIndex = -1;
            comboBoxDeviceID.SelectedIndex = -1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
