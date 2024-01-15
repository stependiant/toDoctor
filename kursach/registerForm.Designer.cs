namespace kursach
{
    partial class registerForm
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
            mainPanel = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            snilsField = new TextBox();
            surnameField = new TextBox();
            nameField = new TextBox();
            label2 = new Label();
            toLoginFormLabel = new Label();
            buttonRegister = new Button();
            passField = new TextBox();
            pictureBox2 = new PictureBox();
            loginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            upperPanel = new Label();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.LimeGreen;
            mainPanel.Controls.Add(pictureBox6);
            mainPanel.Controls.Add(pictureBox5);
            mainPanel.Controls.Add(pictureBox4);
            mainPanel.Controls.Add(snilsField);
            mainPanel.Controls.Add(surnameField);
            mainPanel.Controls.Add(nameField);
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(toLoginFormLabel);
            mainPanel.Controls.Add(buttonRegister);
            mainPanel.Controls.Add(passField);
            mainPanel.Controls.Add(pictureBox2);
            mainPanel.Controls.Add(loginField);
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Controls.Add(panel2);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(475, 560);
            mainPanel.TabIndex = 1;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.IDicon1;
            pictureBox6.Location = new Point(44, 398);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(41, 41);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.surnameicon;
            pictureBox5.Location = new Point(44, 315);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(41, 56);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.name;
            pictureBox4.Location = new Point(44, 246);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(41, 51);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // snilsField
            // 
            snilsField.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            snilsField.Location = new Point(101, 398);
            snilsField.Multiline = true;
            snilsField.Name = "snilsField";
            snilsField.Size = new Size(319, 41);
            snilsField.TabIndex = 10;
            snilsField.Enter += snilsField_Enter;
            snilsField.Leave += snilsField_Leave;
            // 
            // surnameField
            // 
            surnameField.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            surnameField.Location = new Point(100, 327);
            surnameField.Multiline = true;
            surnameField.Name = "surnameField";
            surnameField.Size = new Size(320, 44);
            surnameField.TabIndex = 9;
            surnameField.Enter += surnameField_Enter;
            surnameField.Leave += surnameField_Leave;
            // 
            // nameField
            // 
            nameField.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            nameField.Location = new Point(101, 254);
            nameField.Multiline = true;
            nameField.Name = "nameField";
            nameField.Size = new Size(320, 43);
            nameField.TabIndex = 8;
            nameField.Enter += nameField_Enter;
            nameField.Leave += nameField_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(248, 327);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 7;
            // 
            // toLoginFormLabel
            // 
            toLoginFormLabel.AutoSize = true;
            toLoginFormLabel.Cursor = Cursors.Hand;
            toLoginFormLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toLoginFormLabel.Location = new Point(190, 519);
            toLoginFormLabel.Name = "toLoginFormLabel";
            toLoginFormLabel.Size = new Size(140, 21);
            toLoginFormLabel.TabIndex = 6;
            toLoginFormLabel.Text = "Уже есть аккаунт?";
            toLoginFormLabel.Click += label1_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.DarkBlue;
            buttonRegister.FlatAppearance.BorderColor = Color.Black;
            buttonRegister.FlatAppearance.BorderSize = 2;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegister.ForeColor = SystemColors.Control;
            buttonRegister.Location = new Point(128, 469);
            buttonRegister.Margin = new Padding(3, 2, 3, 2);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(260, 38);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "Зарегистрироваться";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // passField
            // 
            passField.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            passField.Location = new Point(100, 187);
            passField.Margin = new Padding(3, 2, 3, 2);
            passField.Multiline = true;
            passField.Name = "passField";
            passField.Size = new Size(321, 43);
            passField.TabIndex = 4;
            passField.UseSystemPasswordChar = true;
            passField.Enter += passField_Enter;
            passField.Leave += passField_Leave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.lockicon;
            pictureBox2.InitialImage = Properties.Resources.usericon;
            pictureBox2.Location = new Point(44, 187);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            loginField.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            loginField.Location = new Point(100, 118);
            loginField.Margin = new Padding(3, 2, 3, 2);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(321, 43);
            loginField.TabIndex = 2;
            loginField.Enter += loginField_Enter;
            loginField.Leave += loginField_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usericon;
            pictureBox1.InitialImage = Properties.Resources.usericon;
            pictureBox1.Location = new Point(44, 118);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumOrchid;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(upperPanel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(475, 94);
            panel2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.SlateBlue;
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = Properties.Resources.hearticon;
            pictureBox3.Location = new Point(10, 26);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // upperPanel
            // 
            upperPanel.BackColor = Color.SlateBlue;
            upperPanel.Dock = DockStyle.Top;
            upperPanel.Font = new Font("Segoe UI Emoji", 32F, FontStyle.Regular, GraphicsUnit.Point);
            upperPanel.Location = new Point(0, 0);
            upperPanel.Name = "upperPanel";
            upperPanel.Size = new Size(475, 94);
            upperPanel.TabIndex = 0;
            upperPanel.Text = "Регистрация";
            upperPanel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // registerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 560);
            Controls.Add(mainPanel);
            Name = "registerForm";
            Text = "registerForm";
            FormClosing += registerForm_FormClosing;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label label2;
        private Label toLoginFormLabel;
        private Button buttonRegister;
        private TextBox passField;
        private PictureBox pictureBox2;
        private TextBox loginField;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label upperPanel;
        private PictureBox pictureBox4;
        private TextBox snilsField;
        private TextBox surnameField;
        private TextBox nameField;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
    }
}