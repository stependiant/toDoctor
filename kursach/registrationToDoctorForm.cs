using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kursach;

namespace kursach
{
    public partial class registrationToDoctorForm : Form
    {
        public registrationToDoctorForm()
        {
            InitializeComponent();
        }


        private void backToMainForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.CurrentUserLogin = CurrentUser.Login;
            mainForm mainFormInstance = new mainForm();
            mainFormInstance.Show();
        }

        private void registrationToDoctorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void selfButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            toDoctorMap1 toDoctorMap1 = new toDoctorMap1();
            toDoctorMap1.Show();
        }

        private void otherPersonButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            toDoctorNew toDoctorNew = new toDoctorNew();
            toDoctorNew.Show();
        }
    }
}
