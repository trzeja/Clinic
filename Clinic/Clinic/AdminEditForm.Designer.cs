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
            this.adminApproveButton = new System.Windows.Forms.Button();
            this.adminCancelButton = new System.Windows.Forms.Button();
            this.adminTextBoxUserName = new System.Windows.Forms.TextBox();
            this.adminTextBoxPassword = new System.Windows.Forms.TextBox();
            this.adminTextBoxRetireDate = new System.Windows.Forms.TextBox();
            this.adminTextBoxRoles = new System.Windows.Forms.TextBox();
            this.adminTextBoxLname = new System.Windows.Forms.TextBox();
            this.adminTextBoxFname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // adminApproveButton
            // 
            this.adminApproveButton.Location = new System.Drawing.Point(12, 262);
            this.adminApproveButton.Name = "adminApproveButton";
            this.adminApproveButton.Size = new System.Drawing.Size(75, 23);
            this.adminApproveButton.TabIndex = 3;
            this.adminApproveButton.Text = "Approve";
            this.adminApproveButton.UseVisualStyleBackColor = true;
            this.adminApproveButton.Click += new System.EventHandler(this.adminApproveButton_Click);
            // 
            // adminCancelButton
            // 
            this.adminCancelButton.Location = new System.Drawing.Point(93, 262);
            this.adminCancelButton.Name = "adminCancelButton";
            this.adminCancelButton.Size = new System.Drawing.Size(75, 23);
            this.adminCancelButton.TabIndex = 5;
            this.adminCancelButton.Text = "Cancel";
            this.adminCancelButton.UseVisualStyleBackColor = true;
            this.adminCancelButton.Click += new System.EventHandler(this.adminCancelButton_Click);
            // 
            // adminTextBoxUserName
            // 
            this.adminTextBoxUserName.Location = new System.Drawing.Point(38, 24);
            this.adminTextBoxUserName.Name = "adminTextBoxUserName";
            this.adminTextBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxUserName.TabIndex = 6;
            // 
            // adminTextBoxPassword
            // 
            this.adminTextBoxPassword.Location = new System.Drawing.Point(38, 64);
            this.adminTextBoxPassword.Name = "adminTextBoxPassword";
            this.adminTextBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxPassword.TabIndex = 7;
            // 
            // adminTextBoxRetireDate
            // 
            this.adminTextBoxRetireDate.Location = new System.Drawing.Point(38, 100);
            this.adminTextBoxRetireDate.Name = "adminTextBoxRetireDate";
            this.adminTextBoxRetireDate.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxRetireDate.TabIndex = 8;
            // 
            // adminTextBoxRoles
            // 
            this.adminTextBoxRoles.Location = new System.Drawing.Point(38, 139);
            this.adminTextBoxRoles.Name = "adminTextBoxRoles";
            this.adminTextBoxRoles.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxRoles.TabIndex = 9;
            // 
            // adminTextBoxLname
            // 
            this.adminTextBoxLname.Location = new System.Drawing.Point(38, 174);
            this.adminTextBoxLname.Name = "adminTextBoxLname";
            this.adminTextBoxLname.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxLname.TabIndex = 10;
            // 
            // adminTextBoxFname
            // 
            this.adminTextBoxFname.Location = new System.Drawing.Point(38, 211);
            this.adminTextBoxFname.Name = "adminTextBoxFname";
            this.adminTextBoxFname.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxFname.TabIndex = 11;
            // 
            // AdminEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 297);
            this.Controls.Add(this.adminTextBoxFname);
            this.Controls.Add(this.adminTextBoxLname);
            this.Controls.Add(this.adminTextBoxRoles);
            this.Controls.Add(this.adminTextBoxRetireDate);
            this.Controls.Add(this.adminTextBoxPassword);
            this.Controls.Add(this.adminTextBoxUserName);
            this.Controls.Add(this.adminCancelButton);
            this.Controls.Add(this.adminApproveButton);
            this.MaximumSize = new System.Drawing.Size(190, 335);
            this.MinimumSize = new System.Drawing.Size(190, 335);
            this.Name = "AdminEditForm";
            this.Text = "AdminEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminApproveButton;
        private System.Windows.Forms.Button adminCancelButton;
        private System.Windows.Forms.TextBox adminTextBoxUserName;
        private System.Windows.Forms.TextBox adminTextBoxPassword;
        private System.Windows.Forms.TextBox adminTextBoxRetireDate;
        private System.Windows.Forms.TextBox adminTextBoxRoles;
        private System.Windows.Forms.TextBox adminTextBoxLname;
        private Admin admin;
        private System.Windows.Forms.TextBox adminTextBoxFname;
    }
}