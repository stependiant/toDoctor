using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace kursach
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;
            passField.Text = "Введите пароль";
            passField.ForeColor = Color.Gray;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passField.Text;
            dataBase db = new dataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    CurrentUser.Login = loginUser;
                    mainForm mainForm = new mainForm();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Не авторизован");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.ToString()}");
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Введите пароль";
                passField.ForeColor = Color.Gray;
            }
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            toRegisterForm.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            toRegisterForm.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerForm registerForm = new registerForm();
            registerForm.Show();
        }

        private void loginform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

    public static class CurrentUser
    {
        private static string login;

        public static string Login
        {
            get { return login; }
            set { login = value; }
        }
    }
}
