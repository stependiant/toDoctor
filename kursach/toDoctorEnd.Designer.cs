namespace kursach
{
    partial class toDoctorEnd
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
            button1 = new Button();
            toDoctorEndLabel3 = new Label();
            labal5 = new Label();
            toDoctorEndLabel2 = new Label();
            label2 = new Label();
            toDoctorEndLabel1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(toDoctorEndLabel3);
            panel1.Controls.Add(labal5);
            panel1.Controls.Add(toDoctorEndLabel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(toDoctorEndLabel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 275);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(135, 219);
            button1.Name = "button1";
            button1.Size = new Size(144, 34);
            button1.TabIndex = 5;
            button1.Text = "Выбрать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // toDoctorEndLabel3
            // 
            toDoctorEndLabel3.AutoSize = true;
            toDoctorEndLabel3.BackColor = Color.DarkSeaGreen;
            toDoctorEndLabel3.Location = new Point(36, 179);
            toDoctorEndLabel3.Name = "toDoctorEndLabel3";
            toDoctorEndLabel3.Size = new Size(99, 15);
            toDoctorEndLabel3.TabIndex = 4;
            toDoctorEndLabel3.Text = "+7(4712)34-98-06";
            // 
            // labal5
            // 
            labal5.AutoSize = true;
            labal5.BackColor = Color.DarkSeaGreen;
            labal5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labal5.Location = new Point(36, 151);
            labal5.Name = "labal5";
            labal5.Size = new Size(66, 19);
            labal5.TabIndex = 3;
            labal5.Text = "Телефон:";
            // 
            // toDoctorEndLabel2
            // 
            toDoctorEndLabel2.AutoSize = true;
            toDoctorEndLabel2.BackColor = Color.DarkSeaGreen;
            toDoctorEndLabel2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            toDoctorEndLabel2.Location = new Point(36, 123);
            toDoctorEndLabel2.Name = "toDoctorEndLabel2";
            toDoctorEndLabel2.Size = new Size(209, 19);
            toDoctorEndLabel2.TabIndex = 2;
            toDoctorEndLabel2.Text = "305004, г.Курс, ул.Садовая д.27";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSeaGreen;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 98);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 1;
            label2.Text = "Адрес:";
            // 
            // toDoctorEndLabel1
            // 
            toDoctorEndLabel1.AutoSize = true;
            toDoctorEndLabel1.BackColor = Color.DarkSeaGreen;
            toDoctorEndLabel1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            toDoctorEndLabel1.Location = new Point(26, 9);
            toDoctorEndLabel1.Name = "toDoctorEndLabel1";
            toDoctorEndLabel1.Size = new Size(370, 75);
            toDoctorEndLabel1.TabIndex = 0;
            toDoctorEndLabel1.Text = "        Отделение терапевтической\nстоматологии 1,ОБУЗ 'Курская областная\n     стоматологическая поликлиника'";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 275);
            panel2.TabIndex = 6;
            // 
            // toDoctorEnd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 275);
            Controls.Add(panel1);
            Name = "toDoctorEnd";
            Text = "toDoctorEnd";
            FormClosing += toDoctorEnd_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label toDoctorEndLabel1;
        private Label toDoctorEndLabel2;
        private Label label2;
        private Button button1;
        private Label toDoctorEndLabel3;
        private Label labal5;
        private Panel panel2;
    }
}