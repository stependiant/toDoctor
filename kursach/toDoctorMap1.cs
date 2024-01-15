namespace kursach
{
    public partial class toDoctorMap1 : Form
    {
        public toDoctorMap1()
        {
            InitializeComponent();
            markerHospital4.Parent = mapPicture1;
            markerHospital4.BackColor = Color.Transparent;
            markerHospital3.Parent = mapPicture1;
            markerHospital3.BackColor = Color.Transparent;
            markerHospital2.Parent = mapPicture1;
            markerHospital2.BackColor = Color.Transparent;
            markerHospital5.Parent = mapPicture1;
            markerHospital5.BackColor = Color.Transparent;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            toDoctorEnd toDoctorEnd = new toDoctorEnd();
            toDoctorEnd.Show();
        }

        private void toDoctorMap1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            toDoctorEnd toDoctorEndLabels = new toDoctorEnd();
            toDoctorEndLabels.hospital1();
            toDoctorEndLabels.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            toDoctorEnd toDoctorEndLabels = new toDoctorEnd();
            toDoctorEndLabels.hospital2();
            toDoctorEndLabels.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            toDoctorEnd toDoctorEndLabels = new toDoctorEnd();
            toDoctorEndLabels.hospital3();
            toDoctorEndLabels.Show();
        }

        private void mapPicture1_Click(object sender, EventArgs e)
        {

        }
    }
}
