using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetServiceProvider
{
    public partial class Auth: Form
    {
        DataBase database = new DataBase();

        public Auth()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private string GetMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var loginUser = textBoxLogin.Text;
            var passwordUser = textBoxPassword.Text;

            string hashedPassword = GetMD5Hash(passwordUser);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = "SELECT id_user, login_user, password_user, roles FROM register WHERE login_user = @login AND password_user = @password";

            SqlCommand command = new SqlCommand(query, database.getConnection());
            command.Parameters.AddWithValue("@login", loginUser);
            command.Parameters.AddWithValue("@password", hashedPassword);

            database.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            database.closeConnection();

            if (table.Rows.Count == 1)
            {
                string role = table.Rows[0]["roles"].ToString();
                MessageBox.Show("Ви успішно увійшли в систему", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Create Technicians form and pass the user's role
                Technicians frm1 = new Technicians(role);
                this.Hide();
                frm1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неправильний логін або пароль", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            closedEye.Visible = false;
            textBoxLogin.MaxLength = 50;
            textBoxPassword.MaxLength = 50;
        }

        private void closedEye_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            closedEye.Visible = false;
            eyeOpen.Visible = true;
        }

        private void eyeOpen_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '\0';
            eyeOpen.Visible = false;
            closedEye.Visible = true;
        }

        private void regLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration frm2 = new Registration();
            frm2.Show();
            this.Hide();
        }

        private void clearPictureBox_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the Enter key was pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Prevent the beep sound
                e.Handled = true;

                // Move focus to the password textbox
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the Enter key was pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Prevent the beep sound
                e.Handled = true;

                // Automatically click the login button
                okButton.PerformClick();
            }
        }
    }
}
