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
    public partial class AdminForm: Form
    {
        DataBase database = new DataBase();
        private int selectedRow;

        public AdminForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetServiceProviderDBDataSet10.register' table. You can move, or remove it, as needed.
            this.registerTableAdapter.Fill(this.internetServiceProviderDBDataSet10.register);
            BeautifyDataGridView();
            RefreshUserDataGrid();

            SetupRoleComboBoxes();
        }
        private void SetupRoleComboBoxes()
        {
            // Define valid roles
            string[] validRoles = new string[] { "admin", "user" };

            // Configure the main role ComboBox
            comboBoxRole.Items.Clear();
            comboBoxRole.Items.AddRange(validRoles);
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList; // Prevent manual text entry

            // Configure the second role ComboBox (for updating roles)
            comboBoxNewRole.Items.Clear();
            comboBoxNewRole.Items.AddRange(validRoles);
            comboBoxNewRole.DropDownStyle = ComboBoxStyle.DropDownList; // Prevent manual text entry
        }

        private void RefreshUserDataGrid()
        {
            database.openConnection();

            try
            {
                string query = "SELECT * FROM register";
                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        UsersdataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error refreshing user data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
            }
        }

        private void BeautifyDataGridView()
        {
            // Колір фону таблиці
            UsersdataGridView.BackgroundColor = Color.White;

            // Колір заголовків стовпців
            UsersdataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215); // Синій
            UsersdataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            UsersdataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            UsersdataGridView.EnableHeadersVisualStyles = false; // Вимикаємо стандартні стилі Windows

            // Колір рядків
            UsersdataGridView.DefaultCellStyle.BackColor = Color.White;
            UsersdataGridView.DefaultCellStyle.ForeColor = Color.Black;
            UsersdataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            // Колір вибраного рядка
            UsersdataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 174, 219); // Блакитний
            UsersdataGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            // Альтернативні кольори для рядків (зебрування)
            UsersdataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 248, 255); // Світло-блакитний

            // Задаємо назви стовпців
            UsersdataGridView.Columns[0].HeaderText = "ID";
            UsersdataGridView.Columns[1].HeaderText = "Ім'я";
            UsersdataGridView.Columns[2].HeaderText = "Захешований пароль";
            UsersdataGridView.Columns[3].HeaderText = "Рівень доступу";

            // Вирівнювання тексту в заголовках
            UsersdataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Вирівнювання тексту в комірках
            UsersdataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            UsersdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private string GetMd5Hash(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text;

            // Validate input fields
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate role selection
            if (comboBoxRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid role (admin or user)!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string role = comboBoxRole.SelectedItem.ToString();

            // Hash the password using MD5
            string hashedPassword = GetMd5Hash(password);

            database.openConnection();

            try
            {
                string query = "INSERT INTO register (login_user, password_user, roles) VALUES (@username, @password, @role)";
                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", hashedPassword);
                    command.Parameters.AddWithValue("@role", role);
                    command.ExecuteNonQuery();
                    MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear input fields after successful addition
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                    comboBoxRole.SelectedIndex = -1;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
                RefreshUserDataGrid();
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (UsersdataGridView.CurrentCell == null)
            {
                MessageBox.Show("Select a user to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = UsersdataGridView.CurrentCell.RowIndex;
            int userId = Convert.ToInt32(UsersdataGridView.Rows[selectedRowIndex].Cells[0].Value);

            database.openConnection();

            try
            {
                string query = "DELETE FROM register WHERE id_user = @user_id";
                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@user_id", userId);
                    command.ExecuteNonQuery();
                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error deleting user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
                RefreshUserDataGrid();
            }
        }

        private void buttonUpdateRole_Click(object sender, EventArgs e)
        {
            if (UsersdataGridView.CurrentCell == null)
            {
                MessageBox.Show("Select a user to update role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate role selection
            if (comboBoxNewRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid role (admin or user)!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = UsersdataGridView.CurrentCell.RowIndex;
            int userId = Convert.ToInt32(UsersdataGridView.Rows[selectedRowIndex].Cells[0].Value);
            string newRole = comboBoxNewRole.SelectedItem.ToString();

            database.openConnection();

            try
            {
                string query = "UPDATE register SET roles = @role WHERE id_user = @user_id";
                using (SqlCommand command = new SqlCommand(query, database.getConnection()))
                {
                    command.Parameters.AddWithValue("@role", newRole);
                    command.Parameters.AddWithValue("@user_id", userId);
                    command.ExecuteNonQuery();
                    MessageBox.Show("User role updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error updating user role: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.closeConnection();
                RefreshUserDataGrid();
            }
        }

        private void UsersdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = UsersdataGridView.Rows[selectedRow];

                textBoxUsername.Text = row.Cells[1].Value.ToString();
                textBoxPassword.Text = row.Cells[2].Value.ToString();

                // Set the role in comboBoxRole by finding the matching item
                string currentRole = row.Cells[3].Value.ToString();
                int roleIndex = comboBoxRole.Items.IndexOf(currentRole);
                if (roleIndex >= 0)
                {
                    comboBoxRole.SelectedIndex = roleIndex;
                }
                else
                {
                    comboBoxRole.SelectedIndex = -1;
                    MessageBox.Show($"The role '{currentRole}' is not a standard role. Please select either 'admin' or 'user'.",
                                   "Non-standard Role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Also set the role in the update role combobox
                int newRoleIndex = comboBoxNewRole.Items.IndexOf(currentRole);
                if (newRoleIndex >= 0)
                {
                    comboBoxNewRole.SelectedIndex = newRoleIndex;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            comboBoxRole.SelectedIndex = -1;
            comboBoxNewRole.SelectedIndex = -1;
        }
    }
}
