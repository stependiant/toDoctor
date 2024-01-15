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
    public partial class toDoctorEnd : Form
    {
        public toDoctorEnd()
        {
            InitializeComponent();
        }
        public void hospital1()
        {
            toDoctorEndLabel1.Text = "        Взрослая поликлиника\nОБЗУ, \"Курская горбольница №3\"";
            toDoctorEndLabel2.Text = "305018, г.Курс, ул.Обоянская д.16";
            toDoctorEndLabel3.Text = "+7(4712)25-06-30";
        }
        public void hospital2()
        {
            toDoctorEndLabel1.Text = "        Взрослая поликлиника филиал\nОБЗУ, \"Курская горбольница №3\"";
            toDoctorEndLabel2.Text = "305025, г.Курс, ул.Магистральный проезд д.11Г";
            toDoctorEndLabel3.Text = "+7(4712)25-06-30";
        }
        public void hospital3()
        {
            toDoctorEndLabel1.Text = "        Взрослая поликлиника \n\"2й Промышленный переулок, 13\"";
            toDoctorEndLabel2.Text = "305025, г.Курс, пер.Промышленный 2-й д.13";
            toDoctorEndLabel3.Text = "+7(4712)24-15-75";
        }

        private void toDoctorEnd_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            toDoctorEnd2 toDoctorEnd2 = new toDoctorEnd2();
            toDoctorEnd2.Show();
        }
    }
}
