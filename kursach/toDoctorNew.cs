using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class toDoctorNew : Form
    {
        public toDoctorNew()
        {
            InitializeComponent();
            nameField.Text = "Введите имя";
            surnameField.Text = "Введите фамилию";
            snilsField.Text = "Введите СНИЛС";
            nameField.ForeColor = Color.Gray;
            surnameField.ForeColor = Color.Gray;
            snilsField.ForeColor = Color.Gray;
        }

        private void nameField_Enter(object sender, EventArgs e)
        {
            if (nameField.Text == "Введите имя")
            {
                nameField.Text = "";
                nameField.ForeColor = Color.Black;
            }
        }

        private void nameField_Leave(object sender, EventArgs e)
        {
            if (nameField.Text == "")
            {
                nameField.Text = "Введите имя";
                nameField.ForeColor = Color.Gray;
            }
        }

        private void surnameField_Enter(object sender, EventArgs e)
        {
            if (surnameField.Text == "Введите фамилию")
            {
                surnameField.Text = "";
                surnameField.ForeColor = Color.Black;
            }
        }

        private void surnameField_Leave(object sender, EventArgs e)
        {
            if (surnameField.Text == "")
            {
                surnameField.Text = "Введите фамилию";
                surnameField.ForeColor = Color.Gray;
            }
        }

        private void snilsField_Enter(object sender, EventArgs e)
        {
            if (snilsField.Text == "Введите СНИЛС")
            {
                snilsField.Text = "";
                snilsField.ForeColor = Color.Black;
            }
        }

        private void snilsField_Leave(object sender, EventArgs e)
        {
            if (snilsField.Text == "")
            {
                snilsField.Text = "Введите СНИЛС";
                snilsField.ForeColor = Color.Gray;
            }
        }

        private void toLoginFormLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.CurrentUserLogin = CurrentUser.Login;
            mainForm mainFormInstance = new mainForm();
            mainFormInstance.Show();
        }

        private void toDoctorNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            toDoctorMap1 toDoctorMap1 = new toDoctorMap1();
            toDoctorMap1.Show();
        }
    }
}
