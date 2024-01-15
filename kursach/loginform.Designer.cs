namespace kursach
{
    partial class loginform
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
            toRegisterForm = new Label();
            label1 = new Label();
            buttonLogin = new Button();
            passField = new TextBox();
            pictureBox2 = new PictureBox();
            loginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            upperPanel = new Label();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.LimeGreen;
            mainPanel.Controls.Add(toRegisterForm);
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(buttonLogin);
            mainPanel.Controls.Add(passField);
            mainPanel.Controls.Add(pictureBox2);
            mainPanel.Controls.Add(loginField);
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Controls.Add(panel2);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(462, 378);
            mainPanel.TabIndex = 0;
            // 
            // toRegisterForm
            // 
            toRegisterForm.AutoSize = true;
            toRegisterForm.Cursor = Cursors.Hand;
            toRegisterForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toRegisterForm.Location = new Point(248, 327);
            toRegisterForm.Name = "toRegisterForm";
            toRegisterForm.Size = new Size(155, 21);
            toRegisterForm.TabIndex = 7;
            toRegisterForm.Text = "Зарегистрироваться";
            toRegisterForm.Click += label2_Click;
            toRegisterForm.MouseEnter += label2_MouseEnter;
            toRegisterForm.MouseLeave += label2_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(71, 327);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 6;
            label1.Text = "У вас нету аккаунта?";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.DarkBlue;
            buttonLogin.FlatAppearance.BorderColor = Color.Black;
            buttonLogin.FlatAppearance.BorderSize = 2;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 17F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.ForeColor = SystemColors.Control;
            buttonLogin.Location = new Point(186, 265);
            buttonLogin.Margin = new Padding(3, 2, 3, 2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(151, 38);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // passField
            // 
            passField.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
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
            loginField.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
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
            panel2.Size = new Size(462, 94);
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
            upperPanel.Size = new Size(462, 94);
            upperPanel.TabIndex = 0;
            upperPanel.Text = "Авторизация";
            upperPanel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 378);
            Controls.Add(mainPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "loginform";
            Text = "loginform";
            FormClosing += loginform_FormClosing;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Panel panel2;
        private Label upperPanel;
        private PictureBox pictureBox1;
        private TextBox loginField;
        private Button buttonLogin;
        private TextBox passField;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label toRegisterForm;
        private Label label1;
    }
}