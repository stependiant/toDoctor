using System.Windows.Forms;

namespace kursach
{
    partial class toDoctorMap1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mapPicture1 = new PictureBox();
            markerHospital2 = new PictureBox();
            markerHospital3 = new PictureBox();
            markerHospital4 = new PictureBox();
            markerHospital5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)mapPicture1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)markerHospital2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)markerHospital3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)markerHospital4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)markerHospital5).BeginInit();
            SuspendLayout();
            // 
            // mapPicture1
            // 
            mapPicture1.BackColor = Color.Transparent;
            mapPicture1.Dock = DockStyle.Fill;
            mapPicture1.Image = Properties.Resources.DoctorMap;
            mapPicture1.Location = new Point(0, 0);
            mapPicture1.Name = "mapPicture1";
            mapPicture1.Size = new Size(800, 450);
            mapPicture1.SizeMode = PictureBoxSizeMode.StretchImage;
            mapPicture1.TabIndex = 0;
            mapPicture1.TabStop = false;
            mapPicture1.Click += mapPicture1_Click;
            // 
            // markerHospital2
            // 
            markerHospital2.BackColor = Color.Transparent;
            markerHospital2.BackgroundImageLayout = ImageLayout.None;
            markerHospital2.Cursor = Cursors.Hand;
            markerHospital2.Image = Properties.Resources.markertest;
            markerHospital2.Location = new Point(318, 352);
            markerHospital2.Name = "markerHospital2";
            markerHospital2.Size = new Size(37, 32);
            markerHospital2.SizeMode = PictureBoxSizeMode.StretchImage;
            markerHospital2.TabIndex = 1;
            markerHospital2.TabStop = false;
            markerHospital2.Click += pictureBox2_Click;
            // 
            // markerHospital3
            // 
            markerHospital3.BackColor = Color.Transparent;
            markerHospital3.BackgroundImageLayout = ImageLayout.None;
            markerHospital3.Cursor = Cursors.Hand;
            markerHospital3.Image = Properties.Resources.markertest;
            markerHospital3.Location = new Point(328, 271);
            markerHospital3.Name = "markerHospital3";
            markerHospital3.Size = new Size(37, 32);
            markerHospital3.SizeMode = PictureBoxSizeMode.StretchImage;
            markerHospital3.TabIndex = 2;
            markerHospital3.TabStop = false;
            markerHospital3.Click += pictureBox3_Click;
            // 
            // markerHospital4
            // 
            markerHospital4.BackColor = Color.Transparent;
            markerHospital4.BackgroundImageLayout = ImageLayout.None;
            markerHospital4.Cursor = Cursors.Hand;
            markerHospital4.Image = Properties.Resources.markertest;
            markerHospital4.Location = new Point(437, 42);
            markerHospital4.Name = "markerHospital4";
            markerHospital4.Size = new Size(37, 32);
            markerHospital4.SizeMode = PictureBoxSizeMode.StretchImage;
            markerHospital4.TabIndex = 3;
            markerHospital4.TabStop = false;
            markerHospital4.Click += pictureBox4_Click;
            // 
            // markerHospital5
            // 
            markerHospital5.BackColor = Color.Transparent;
            markerHospital5.BackgroundImageLayout = ImageLayout.None;
            markerHospital5.Cursor = Cursors.Hand;
            markerHospital5.Image = Properties.Resources.markertest;
            markerHospital5.Location = new Point(163, 283);
            markerHospital5.Name = "markerHospital5";
            markerHospital5.Size = new Size(37, 32);
            markerHospital5.SizeMode = PictureBoxSizeMode.StretchImage;
            markerHospital5.TabIndex = 4;
            markerHospital5.TabStop = false;
            markerHospital5.Click += pictureBox5_Click;
            // 
            // toDoctorMap1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(markerHospital3);
            Controls.Add(markerHospital5);
            Controls.Add(markerHospital4);
            Controls.Add(markerHospital2);
            Controls.Add(mapPicture1);
            Name = "toDoctorMap1";
            Text = "toDoctorMap1";
            TransparencyKey = Color.White;
            FormClosing += toDoctorMap1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)mapPicture1).EndInit();
            ((System.ComponentModel.ISupportInitialize)markerHospital2).EndInit();
            ((System.ComponentModel.ISupportInitialize)markerHospital3).EndInit();
            ((System.ComponentModel.ISupportInitialize)markerHospital4).EndInit();
            ((System.ComponentModel.ISupportInitialize)markerHospital5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox mapPicture1;
        private PictureBox markerHospital2;
        private PictureBox markerHospital3;
        private PictureBox markerHospital4;
        private PictureBox markerHospital5;
    }
}