﻿namespace Clinic
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
            this.adminTextBoxUserName = new System.Windows.Forms.TextBox();
            this.adminModifyButton = new System.Windows.Forms.Button();
            this.dataTimeCheckerRetireDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // adminTextBoxFname
            // 
            this.adminTextBoxFname.Location = new System.Drawing.Point(103, 203);
            this.adminTextBoxFname.Name = "adminTextBoxFname";
            this.adminTextBoxFname.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxFname.TabIndex = 17;
            // 
            // adminTextBoxLname
            // 
            this.adminTextBoxLname.Location = new System.Drawing.Point(103, 165);
            this.adminTextBoxLname.Name = "adminTextBoxLname";
            this.adminTextBoxLname.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxLname.TabIndex = 16;
            // 
            // adminTextBoxPassword
            // 
            this.adminTextBoxPassword.Location = new System.Drawing.Point(103, 48);
            this.adminTextBoxPassword.Name = "adminTextBoxPassword";
            this.adminTextBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxPassword.TabIndex = 13;
            // 
            // adminTextBoxUserName
            // 
            this.adminTextBoxUserName.Location = new System.Drawing.Point(103, 12);
            this.adminTextBoxUserName.Name = "adminTextBoxUserName";
            this.adminTextBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxUserName.TabIndex = 12;
            // 
            // adminModifyButton
            // 
            this.adminModifyButton.Location = new System.Drawing.Point(112, 237);
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
            this.dataTimeCheckerRetireDate.Location = new System.Drawing.Point(103, 89);
            this.dataTimeCheckerRetireDate.Name = "dataTimeCheckerRetireDate";
            this.dataTimeCheckerRetireDate.ShowCheckBox = true;
            this.dataTimeCheckerRetireDate.Size = new System.Drawing.Size(153, 20);
            this.dataTimeCheckerRetireDate.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Retire date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Password";
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(33, 131);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(60, 13);
            this.Role.TabIndex = 24;
            this.Role.Text = "User Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Last name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "First Name";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(103, 128);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(95, 21);
            this.comboBoxRole.TabIndex = 27;
            // 
            // AdminEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 272);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTimeCheckerRetireDate);
            this.Controls.Add(this.adminModifyButton);
            this.Controls.Add(this.adminTextBoxFname);
            this.Controls.Add(this.adminTextBoxLname);
            this.Controls.Add(this.adminTextBoxPassword);
            this.Controls.Add(this.adminTextBoxUserName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 500);
            this.MinimumSize = new System.Drawing.Size(190, 310);
            this.Name = "AdminEditForm";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adminTextBoxFname;
        private System.Windows.Forms.TextBox adminTextBoxLname;
        private System.Windows.Forms.TextBox adminTextBoxPassword;
        private System.Windows.Forms.TextBox adminTextBoxUserName;
        private System.Windows.Forms.Button adminModifyButton;
        private System.Windows.Forms.DateTimePicker dataTimeCheckerRetireDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxRole;
    }
}