using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kursach
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
            loginField.Text = "Введите логин";
            passField.Text = "Введите пароль";
            nameField.Text = "Введите ваше имя";
            surnameField.Text = "Введите вашу фамилию";
            snilsField.Text = "Введите ваш СНИЛС";
            loginField.ForeColor = Color.Gray;
            passField.ForeColor = Color.Gray;
            nameField.ForeColor = Color.Gray;
            surnameField.ForeColor = Color.Gray;
            snilsField.ForeColor = Color.Gray;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform loginform = new loginform();
            loginform.Show();
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
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

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Введите пароль")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
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

        private void nameField_Enter(object sender, EventArgs e)
        {
            if (nameField.Text == "Введите ваше имя")
            {
                nameField.Text = "";
                nameField.ForeColor = Color.Black;
            }
        }

        private void nameField_Leave(object sender, EventArgs e)
        {
            if (nameField.Text == "")
            {
                nameField.Text = "Введите ваше имя";
                nameField.ForeColor = Color.Gray;
            }
        }

        private void surnameField_Enter(object sender, EventArgs e)
        {
            if (surnameField.Text == "Введите вашу фамилию")
            {
                surnameField.Text = "";
                surnameField.ForeColor = Color.Black;
            }
        }

        private void surnameField_Leave(object sender, EventArgs e)
        {
            if (surnameField.Text == "")
            {
                surnameField.Text = "Введите вашу фамилию";
                surnameField.ForeColor = Color.Gray;
            }
        }

        private void snilsField_Enter(object sender, EventArgs e)
        {
            if (snilsField.Text == "Введите ваш СНИЛС")
            {
                snilsField.Text = "";
                snilsField.ForeColor = Color.Black;
            }
        }

        private void snilsField_Leave(object sender, EventArgs e)
        {
            if (snilsField.Text == "")
            {
                snilsField.Text = "Введите ваш СНИЛС";
                snilsField.ForeColor = Color.Gray;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            dataBase db = new dataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`, `snils`) VALUES(@login, @password, @name, @surname, @snils)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surnameField.Text;
            command.Parameters.Add("@snils", MySqlDbType.VarChar).Value = snilsField.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Ваш аккаунт создан!");
                this.Hide();
                loginform loginform = new loginform();
                loginform.Show();
            }
            else
            {
                MessageBox.Show("Такой аккаунт уже существует");
            }
            db.closeConnection();
        }

        private void registerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
