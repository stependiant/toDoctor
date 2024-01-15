namespace kursach
{
    partial class toDoctorEnd2
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            comboBoxDoctors = new ComboBox();
            comboBoxTime = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(85, 27);
            label1.Name = "label1";
            label1.Size = new Size(213, 45);
            label1.TabIndex = 0;
            label1.Text = "Выбор врача";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBoxDoctors);
            panel2.Controls.Add(comboBoxTime);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 275);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(101, 197);
            button1.Name = "button1";
            button1.Size = new Size(183, 36);
            button1.TabIndex = 3;
            button1.Text = "Записаться";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 95);
            label3.Name = "label3";
            label3.Size = new Size(173, 28);
            label3.TabIndex = 2;
            label3.Text = "Доступное время";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 13);
            label2.Name = "label2";
            label2.Size = new Size(178, 28);
            label2.TabIndex = 1;
            label2.Text = "Доступные врачи:";
            // 
            // comboBoxDoctors
            // 
            comboBoxDoctors.FormattingEnabled = true;
            comboBoxDoctors.Location = new Point(28, 53);
            comboBoxDoctors.Name = "comboBoxDoctors";
            comboBoxDoctors.Size = new Size(235, 23);
            comboBoxDoctors.TabIndex = 0;
            // 
            // comboBoxTime
            // 
            comboBoxTime.FormattingEnabled = true;
            comboBoxTime.Location = new Point(28, 135);
            comboBoxTime.Name = "comboBoxTime";
            comboBoxTime.Size = new Size(235, 23);
            comboBoxTime.TabIndex = 0;
            // 
            // toDoctorEnd2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 375);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "toDoctorEnd2";
            Text = "toDoctorEnd2";
            FormClosing += toDoctorEnd2_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private Label label3;
        private Label label2;
        private ComboBox comboBoxDoctors;
        private ComboBox comboBoxTime;
    }
}