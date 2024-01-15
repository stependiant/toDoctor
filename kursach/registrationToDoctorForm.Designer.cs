namespace kursach
{
    partial class registrationToDoctorForm
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
            backToMainForm = new Label();
            otherPersonButton = new Button();
            selfButton = new Button();
            titleLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OliveDrab;
            panel1.Controls.Add(backToMainForm);
            panel1.Controls.Add(otherPersonButton);
            panel1.Controls.Add(selfButton);
            panel1.Controls.Add(titleLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 378);
            panel1.TabIndex = 0;
            // 
            // backToMainForm
            // 
            backToMainForm.AutoSize = true;
            backToMainForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            backToMainForm.Location = new Point(169, 329);
            backToMainForm.Name = "backToMainForm";
            backToMainForm.Size = new Size(128, 21);
            backToMainForm.TabIndex = 3;
            backToMainForm.Text = "Вернуться назад";
            backToMainForm.Click += backToMainForm_Click;
            // 
            // otherPersonButton
            // 
            otherPersonButton.BackColor = Color.DarkCyan;
            otherPersonButton.BackgroundImageLayout = ImageLayout.None;
            otherPersonButton.FlatStyle = FlatStyle.Flat;
            otherPersonButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            otherPersonButton.Location = new Point(121, 224);
            otherPersonButton.Name = "otherPersonButton";
            otherPersonButton.Size = new Size(216, 60);
            otherPersonButton.TabIndex = 2;
            otherPersonButton.Text = "Другого человека";
            otherPersonButton.UseVisualStyleBackColor = false;
            otherPersonButton.Click += otherPersonButton_Click;
            // 
            // selfButton
            // 
            selfButton.BackColor = Color.DarkCyan;
            selfButton.BackgroundImageLayout = ImageLayout.None;
            selfButton.FlatStyle = FlatStyle.Flat;
            selfButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            selfButton.Location = new Point(121, 122);
            selfButton.Name = "selfButton";
            selfButton.Size = new Size(216, 60);
            selfButton.TabIndex = 1;
            selfButton.Text = "Себя";
            selfButton.UseVisualStyleBackColor = false;
            selfButton.Click += selfButton_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(21, 38);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(429, 39);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Кого вы хотите записать?";
            // 
            // registrationToDoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 378);
            Controls.Add(panel1);
            Name = "registrationToDoctorForm";
            Text = "registrationToDoctorForm";
            FormClosing += registrationToDoctorForm_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button otherPersonButton;
        private Button selfButton;
        private Label titleLabel;
        private Label backToMainForm;
    }
}