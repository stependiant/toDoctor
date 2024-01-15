using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace kursach
{
    public partial class toDoctorEnd2 : Form
    {
        private dataBase db = new dataBase();
        private DataTable table = new DataTable();
        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        public toDoctorEnd2()
        {
            InitializeComponent();
            LoadRandomTime();
            LoadDoctorsIntoComboBox();
        }
       
        private void LoadRandomTime()
        {
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                TimeSpan randomTime = new TimeSpan(random.Next(8, 18), 0, 0);
                comboBoxTime.Items.Add(randomTime.ToString("hh\\:mm"));
            }

            comboBoxTime.SelectedIndex = 0;
        }

        private void LoadDoctorsIntoComboBox()
        {
            try
            {
                db.openConnection();
                string query = "SELECT name, surname, patronymic FROM doctors";

                MySqlCommand command = new MySqlCommand(query, db.getConnection());
                adapter.SelectCommand = command;

                table.Clear();
                adapter.Fill(table);

                comboBoxDoctors.Items.Clear();

                foreach (DataRow row in table.Rows)
                {
                    string fullName = $"{row["name"]} {row["surname"]} {row["patronymic"]}";
                    comboBoxDoctors.Items.Add(fullName);
                }
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
        private void toDoctorEnd2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase db = new dataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `appointments` (`DoctorName`, `Time`) VALUES(@DoctorName, @Time)", db.getConnection());

            command.Parameters.Add("@DoctorName", MySqlDbType.VarChar).Value = comboBoxDoctors.SelectedItem?.ToString();
            command.Parameters.Add("@Time", MySqlDbType.VarChar).Value = comboBoxTime.SelectedItem?.ToString();

            db.openConnection();
            command.ExecuteNonQuery();
            this.Hide();
            mainForm mainForm = new mainForm();
            mainForm.Show();
            
            db.closeConnection();
        }
    }
}
