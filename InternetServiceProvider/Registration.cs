﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace InternetServiceProvider
{
    public partial class Registration : Form
    {
        DataBase database = new DataBase();

        public Registration()
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

        private void Registration_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            closedEye.Visible = false;
            textBoxLogin.MaxLength = 50;
            textBoxPassword.MaxLength = 50;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkUser())
            {
                MessageBox.Show("Користувач з таким логіном вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = GetMD5Hash(password);

            string query = "INSERT INTO register (login_user, password_user, roles) VALUES (@login, @password, @role)";

            SqlCommand command = new SqlCommand(query, database.getConnection());
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", hashedPassword);
            command.Parameters.AddWithValue("@role", "user");

            database.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Ви успішно зареєструвались", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Auth frm1 = new Auth();
                this.Hide();
                frm1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Помилка реєстрації", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            database.closeConnection();
        }

        private Boolean checkUser()
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select * from register where login_user = '{login}'";
            SqlCommand command = new SqlCommand(query, database.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void loginLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Auth auth = new Auth();
            this.Hide();
            auth.Show();
        }

        private void clearPictureBox_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
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
    }
}
