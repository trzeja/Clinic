namespace Clinic
{
    partial class Doctor
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
            this.DoctorSearchPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.doctorSearchButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.surnameTextbox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.DoctorSearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DoctorSearchPanel
            // 
            this.DoctorSearchPanel.Controls.Add(this.comboBox1);
            this.DoctorSearchPanel.Controls.Add(this.doctorSearchButton);
            this.DoctorSearchPanel.Controls.Add(this.dateTimePicker1);
            this.DoctorSearchPanel.Controls.Add(this.firstNameTextbox);
            this.DoctorSearchPanel.Controls.Add(this.surnameTextbox);
            this.DoctorSearchPanel.Controls.Add(this.firstNameLabel);
            this.DoctorSearchPanel.Controls.Add(this.surnameLabel);
            this.DoctorSearchPanel.Location = new System.Drawing.Point(3, 7);
            this.DoctorSearchPanel.Name = "DoctorSearchPanel";
            this.DoctorSearchPanel.Size = new System.Drawing.Size(507, 86);
            this.DoctorSearchPanel.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "REG",
            "Every"});
            this.comboBox1.Location = new System.Drawing.Point(175, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // doctorSearchButton
            // 
            this.doctorSearchButton.Location = new System.Drawing.Point(415, 36);
            this.doctorSearchButton.Name = "doctorSearchButton";
            this.doctorSearchButton.Size = new System.Drawing.Size(75, 23);
            this.doctorSearchButton.TabIndex = 5;
            this.doctorSearchButton.Text = "Search";
            this.doctorSearchButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(175, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(67, 43);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(67, 20);
            this.firstNameTextbox.TabIndex = 3;
            // 
            // surnameTextbox
            // 
            this.surnameTextbox.Location = new System.Drawing.Point(67, 9);
            this.surnameTextbox.Name = "surnameTextbox";
            this.surnameTextbox.Size = new System.Drawing.Size(67, 20);
            this.surnameTextbox.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(4, 46);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(12, 9);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(49, 13);
            this.surnameLabel.TabIndex = 0;
            this.surnameLabel.Text = "Surname";
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 354);
            this.Controls.Add(this.DoctorSearchPanel);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.DoctorSearchPanel.ResumeLayout(false);
            this.DoctorSearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DoctorSearchPanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.TextBox surnameTextbox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Button doctorSearchButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}