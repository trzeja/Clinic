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
            this.SuspendLayout();
            // 
            // adminTextBoxFname
            // 
            this.adminTextBoxFname.Location = new System.Drawing.Point(139, 272);
            this.adminTextBoxFname.Margin = new System.Windows.Forms.Padding(4);
            this.adminTextBoxFname.Name = "adminTextBoxFname";
            this.adminTextBoxFname.Size = new System.Drawing.Size(132, 22);
            this.adminTextBoxFname.TabIndex = 17;
            // 
            // adminTextBoxLname
            // 
            this.adminTextBoxLname.Location = new System.Drawing.Point(139, 225);
            this.adminTextBoxLname.Margin = new System.Windows.Forms.Padding(4);
            this.adminTextBoxLname.Name = "adminTextBoxLname";
            this.adminTextBoxLname.Size = new System.Drawing.Size(132, 22);
            this.adminTextBoxLname.TabIndex = 16;
            // 
            // adminTextBoxPassword
            // 
            this.adminTextBoxPassword.Location = new System.Drawing.Point(139, 81);
            this.adminTextBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.adminTextBoxPassword.Name = "adminTextBoxPassword";
            this.adminTextBoxPassword.Size = new System.Drawing.Size(132, 22);
            this.adminTextBoxPassword.TabIndex = 13;
            // 
            // adminModifyButton
            // 
            this.adminModifyButton.Location = new System.Drawing.Point(139, 330);
            this.adminModifyButton.Margin = new System.Windows.Forms.Padding(4);
            this.adminModifyButton.Name = "adminModifyButton";
            this.adminModifyButton.Size = new System.Drawing.Size(100, 28);
            this.adminModifyButton.TabIndex = 18;
            this.adminModifyButton.Text = "Add";
            this.adminModifyButton.UseVisualStyleBackColor = true;
            this.adminModifyButton.Click += new System.EventHandler(this.adminModifyButton_Click);
            // 
            // dataTimeCheckerRetireDate
            // 
            this.dataTimeCheckerRetireDate.Checked = false;
            this.dataTimeCheckerRetireDate.Location = new System.Drawing.Point(139, 131);
            this.dataTimeCheckerRetireDate.Margin = new System.Windows.Forms.Padding(4);
            this.dataTimeCheckerRetireDate.Name = "dataTimeCheckerRetireDate";
            this.dataTimeCheckerRetireDate.ShowCheckBox = true;
            this.dataTimeCheckerRetireDate.Size = new System.Drawing.Size(203, 22);
            this.dataTimeCheckerRetireDate.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Retire date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Password";
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(77, 183);
            this.Role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(37, 17);
            this.Role.TabIndex = 24;
            this.Role.Text = "Role";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Last name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "First Name";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "DOC",
            "REG",
            "LABM",
            "LABW",
            "ADM"});
            this.comboBoxRole.Location = new System.Drawing.Point(139, 179);
            this.comboBoxRole.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(125, 24);
            this.comboBoxRole.TabIndex = 27;
            // 
            // adminTextBoxUsername
            // 
            this.adminTextBoxUsername.Location = new System.Drawing.Point(140, 36);
            this.adminTextBoxUsername.Name = "adminTextBoxUsername";
            this.adminTextBoxUsername.Size = new System.Drawing.Size(131, 22);
            this.adminTextBoxUsername.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Username";
            // 
            // AdminEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 397);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(394, 605);
            this.MinimumSize = new System.Drawing.Size(247, 371);
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
    }
}