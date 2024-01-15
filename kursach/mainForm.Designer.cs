namespace kursach
{
    partial class mainForm
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
            toRegistrationButton = new Button();
            dataGridView2 = new DataGridView();
            registrationLabel = new Label();
            mainLabel = new Label();
            personalPanel = new Panel();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            personalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toRegistrationButton
            // 
            toRegistrationButton.BackColor = Color.MediumAquamarine;
            toRegistrationButton.BackgroundImageLayout = ImageLayout.None;
            toRegistrationButton.Cursor = Cursors.Hand;
            toRegistrationButton.FlatStyle = FlatStyle.Flat;
            toRegistrationButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            toRegistrationButton.ForeColor = SystemColors.ActiveCaptionText;
            toRegistrationButton.Location = new Point(134, 480);
            toRegistrationButton.Name = "toRegistrationButton";
            toRegistrationButton.Size = new Size(193, 49);
            toRegistrationButton.TabIndex = 0;
            toRegistrationButton.Text = "Записаться к врачу";
            toRegistrationButton.UseVisualStyleBackColor = false;
            toRegistrationButton.Click += toRegistration_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(36, 257);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(404, 173);
            dataGridView2.TabIndex = 3;
            // 
            // registrationLabel
            // 
            registrationLabel.AutoSize = true;
            registrationLabel.BackColor = SystemColors.ActiveCaption;
            registrationLabel.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            registrationLabel.ForeColor = SystemColors.ActiveCaptionText;
            registrationLabel.Location = new Point(73, 206);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new Size(335, 36);
            registrationLabel.TabIndex = 2;
            registrationLabel.Text = ":Ваши прошлые записи";
            // 
            // mainLabel
            // 
            mainLabel.AutoSize = true;
            mainLabel.BackColor = SystemColors.ActiveCaption;
            mainLabel.Font = new Font("Times New Roman", 30F, FontStyle.Regular, GraphicsUnit.Point);
            mainLabel.ForeColor = SystemColors.ActiveCaptionText;
            mainLabel.Location = new Point(90, 20);
            mainLabel.Name = "mainLabel";
            mainLabel.Size = new Size(299, 46);
            mainLabel.TabIndex = 0;
            mainLabel.Text = "Личный кабинет";
            // 
            // personalPanel
            // 
            personalPanel.AutoSize = true;
            personalPanel.BackColor = SystemColors.ActiveCaption;
            personalPanel.BackgroundImageLayout = ImageLayout.None;
            personalPanel.Controls.Add(dataGridView1);
            personalPanel.Controls.Add(mainLabel);
            personalPanel.Controls.Add(registrationLabel);
            personalPanel.Controls.Add(dataGridView2);
            personalPanel.Controls.Add(toRegistrationButton);
            personalPanel.ForeColor = SystemColors.ControlLight;
            personalPanel.Location = new Point(0, 1);
            personalPanel.Name = "personalPanel";
            personalPanel.RightToLeft = RightToLeft.Yes;
            personalPanel.Size = new Size(475, 560);
            personalPanel.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(404, 51);
            dataGridView1.TabIndex = 4;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 560);
            Controls.Add(personalPanel);
            Name = "mainForm";
            Text = " ";
            FormClosing += mainForm_FormClosing;
            Load += mainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            personalPanel.ResumeLayout(false);
            personalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button toRegistrationButton;
        private DataGridView dataGridView2;
        private Label registrationLabel;
        private Label mainLabel;
        private Panel personalPanel;
        private DataGridView dataGridView1;
    }
}