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
    public partial class Auth: Form
    {
        DataBase database = new DataBase();

        public Auth()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            var loginUser = textBoxLogin.Text;
            var passwordUser = textBoxPassword.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passwordUser}'";

            SqlCommand command = new SqlCommand(query, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                MessageBox.Show("Ви успішно увійшли в систему", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Technicians frm1 = new Technicians();
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
            textBoxPassword.PasswordChar = '*'; // Hide the password
            closedEye.Visible = false;
            eyeOpen.Visible = true;
        }

        private void eyeOpen_Click(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '\0'; // Show the password
            eyeOpen.Visible = false;
            closedEye.Visible = true;
        }
    }
}
