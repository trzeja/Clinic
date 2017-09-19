namespace Clinic
{
    partial class AdminEditForm
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
            this.adminTextBoxFname = new System.Windows.Forms.TextBox();
            this.adminTextBoxLname = new System.Windows.Forms.TextBox();
            this.adminTextBoxPassword = new System.Windows.Forms.TextBox();
            this.adminModifyButton = new System.Windows.Forms.Button();
            this.dataTimeCheckerRetireDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.adminTextBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adminTextBoxMedicalRight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminTextBoxFname
            // 
            this.adminTextBoxFname.Location = new System.Drawing.Point(104, 221);
            this.adminTextBoxFname.Name = "adminTextBoxFname";
            this.adminTextBoxFname.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxFname.TabIndex = 17;
            // 
            // adminTextBoxLname
            // 
            this.adminTextBoxLname.Location = new System.Drawing.Point(104, 183);
            this.adminTextBoxLname.Name = "adminTextBoxLname";
            this.adminTextBoxLname.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxLname.TabIndex = 16;
            // 
            // adminTextBoxPassword
            // 
            this.adminTextBoxPassword.Location = new System.Drawing.Point(104, 66);
            this.adminTextBoxPassword.Name = "adminTextBoxPassword";
            this.adminTextBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxPassword.TabIndex = 13;
            // 
            // adminModifyButton
            // 
            this.adminModifyButton.Location = new System.Drawing.Point(104, 299);
            this.adminModifyButton.Name = "adminModifyButton";
            this.adminModifyButton.Size = new System.Drawing.Size(75, 23);
            this.adminModifyButton.TabIndex = 18;
            this.adminModifyButton.Text = "Add";
            this.adminModifyButton.UseVisualStyleBackColor = true;
            this.adminModifyButton.Click += new System.EventHandler(this.adminModifyButton_Click);
            // 
            // dataTimeCheckerRetireDate
            // 
            this.dataTimeCheckerRetireDate.Checked = false;
            this.dataTimeCheckerRetireDate.Location = new System.Drawing.Point(104, 106);
            this.dataTimeCheckerRetireDate.Name = "dataTimeCheckerRetireDate";
            this.dataTimeCheckerRetireDate.ShowCheckBox = true;
            this.dataTimeCheckerRetireDate.Size = new System.Drawing.Size(153, 20);
            this.dataTimeCheckerRetireDate.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Retire date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Password";
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(58, 149);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(29, 13);
            this.Role.TabIndex = 24;
            this.Role.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Last name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "First Name";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "DOC",
            "REG",
            "LABM",
            "LABW",
            "ADM"});
            this.comboBoxRole.Location = new System.Drawing.Point(104, 145);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(95, 21);
            this.comboBoxRole.TabIndex = 27;
            this.comboBoxRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxRole_SelectedIndexChanged);
            // 
            // adminTextBoxUsername
            // 
            this.adminTextBoxUsername.Location = new System.Drawing.Point(105, 29);
            this.adminTextBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.adminTextBoxUsername.Name = "adminTextBoxUsername";
            this.adminTextBoxUsername.Size = new System.Drawing.Size(99, 20);
            this.adminTextBoxUsername.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Username";
            // 
            // adminTextBoxMedicalRight
            // 
            this.adminTextBoxMedicalRight.Enabled = false;
            this.adminTextBoxMedicalRight.Location = new System.Drawing.Point(104, 259);
            this.adminTextBoxMedicalRight.Name = "adminTextBoxMedicalRight";
            this.adminTextBoxMedicalRight.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxMedicalRight.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Medical right";
            // 
            // AdminEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 334);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adminTextBoxMedicalRight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adminTextBoxUsername);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTimeCheckerRetireDate);
            this.Controls.Add(this.adminModifyButton);
            this.Controls.Add(this.adminTextBoxFname);
            this.Controls.Add(this.adminTextBoxLname);
            this.Controls.Add(this.adminTextBoxPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 499);
            this.MinimumSize = new System.Drawing.Size(189, 309);
            this.Name = "AdminEditForm";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adminTextBoxFname;
        private System.Windows.Forms.TextBox adminTextBoxLname;
        private System.Windows.Forms.TextBox adminTextBoxPassword;
        private System.Windows.Forms.Button adminModifyButton;
        private System.Windows.Forms.DateTimePicker dataTimeCheckerRetireDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.TextBox adminTextBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminTextBoxMedicalRight;
        private System.Windows.Forms.Label label4;
    }
}