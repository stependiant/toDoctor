using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using kursach;
using MySqlX.XDevAPI.Relational;

namespace kursach
{
    public partial class mainForm : Form
    {
        dataBase db = new dataBase();
        DataTable usersTable = new DataTable();
        DataTable appointmentsTable = new DataTable();

        MySqlDataAdapter usersAdapter = new MySqlDataAdapter();
        MySqlDataAdapter appointmentsAdapter = new MySqlDataAdapter();
        public static string? CurrentUserLogin;

        public mainForm()
        {
            InitializeComponent();
            LoadDataIntoDataGridView1();
            LoadDataIntoDataGridView2();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void LoadDataIntoDataGridView2()
        {
            try
            {
                db.openConnection();
                string query = "SELECT DoctorName, Time FROM appointments";

                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                appointmentsAdapter.SelectCommand = command;

                appointmentsTable.Clear();
                appointmentsAdapter.Fill(appointmentsTable);

                dataGridView2.DataSource = appointmentsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }
        private void LoadDataIntoDataGridView1()
        {
            try
            {
                db.openConnection();
                string query = "SELECT login, name, surname, snils FROM users WHERE login = @login";

                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = CurrentUser.Login;
                usersAdapter.SelectCommand = command;

                usersTable.Clear();
                usersAdapter.Fill(usersTable);

                dataGridView1.DataSource = usersTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true;
            }
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.ReadOnly = true;
            }
            dataGridView1.Columns["login"].HeaderText = "Логин";
            dataGridView1.Columns["name"].HeaderText = "Имя";
            dataGridView1.Columns["surname"].HeaderText = "Фамилия";
            dataGridView1.Columns["snils"].HeaderText = "СНИЛС";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.RightToLeft = RightToLeft.No;
            dataGridView2.Columns["DoctorName"].HeaderText = "Имя доктора";
            dataGridView2.Columns["Time"].HeaderText = "Время";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ForeColor = Color.Black;
            dataGridView2.RightToLeft = RightToLeft.No;
        }

        private void toRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationToDoctorForm registrationToDoctorForm = new registrationToDoctorForm();
            registrationToDoctorForm.Show();
        }
    }
}
