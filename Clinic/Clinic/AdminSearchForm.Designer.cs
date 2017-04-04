namespace Clinic
{
    partial class AdminSearchForm
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
            this.adminTextBoxRoles = new System.Windows.Forms.TextBox();
            this.adminTextBoxRetireDate = new System.Windows.Forms.TextBox();
            this.adminTextBoxPassword = new System.Windows.Forms.TextBox();
            this.adminTextBoxUserName = new System.Windows.Forms.TextBox();
            this.adminCancelButton = new System.Windows.Forms.Button();
            this.adminSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminTextBoxFname
            // 
            this.adminTextBoxFname.Location = new System.Drawing.Point(37, 203);
            this.adminTextBoxFname.Name = "adminTextBoxFname";
            this.adminTextBoxFname.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxFname.TabIndex = 17;
            // 
            // adminTextBoxLname
            // 
            this.adminTextBoxLname.Location = new System.Drawing.Point(37, 166);
            this.adminTextBoxLname.Name = "adminTextBoxLname";
            this.adminTextBoxLname.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxLname.TabIndex = 16;
            // 
            // adminTextBoxRoles
            // 
            this.adminTextBoxRoles.Location = new System.Drawing.Point(37, 131);
            this.adminTextBoxRoles.Name = "adminTextBoxRoles";
            this.adminTextBoxRoles.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxRoles.TabIndex = 15;
            // 
            // adminTextBoxRetireDate
            // 
            this.adminTextBoxRetireDate.Location = new System.Drawing.Point(37, 92);
            this.adminTextBoxRetireDate.Name = "adminTextBoxRetireDate";
            this.adminTextBoxRetireDate.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxRetireDate.TabIndex = 14;
            // 
            // adminTextBoxPassword
            // 
            this.adminTextBoxPassword.Location = new System.Drawing.Point(37, 56);
            this.adminTextBoxPassword.Name = "adminTextBoxPassword";
            this.adminTextBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxPassword.TabIndex = 13;
            // 
            // adminTextBoxUserName
            // 
            this.adminTextBoxUserName.Location = new System.Drawing.Point(37, 16);
            this.adminTextBoxUserName.Name = "adminTextBoxUserName";
            this.adminTextBoxUserName.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxUserName.TabIndex = 12;
            // 
            // adminCancelButton
            // 
            this.adminCancelButton.Location = new System.Drawing.Point(90, 231);
            this.adminCancelButton.Name = "adminCancelButton";
            this.adminCancelButton.Size = new System.Drawing.Size(75, 23);
            this.adminCancelButton.TabIndex = 19;
            this.adminCancelButton.Text = "Cancel";
            this.adminCancelButton.UseVisualStyleBackColor = true;
            this.adminCancelButton.Click += new System.EventHandler(this.adminCancelButton_Click);
            // 
            // adminSearchButton
            // 
            this.adminSearchButton.Location = new System.Drawing.Point(9, 231);
            this.adminSearchButton.Name = "adminSearchButton";
            this.adminSearchButton.Size = new System.Drawing.Size(75, 23);
            this.adminSearchButton.TabIndex = 18;
            this.adminSearchButton.Text = "Search";
            this.adminSearchButton.UseVisualStyleBackColor = true;
            // 
            // AdminSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 272);
            this.Controls.Add(this.adminCancelButton);
            this.Controls.Add(this.adminSearchButton);
            this.Controls.Add(this.adminTextBoxFname);
            this.Controls.Add(this.adminTextBoxLname);
            this.Controls.Add(this.adminTextBoxRoles);
            this.Controls.Add(this.adminTextBoxRetireDate);
            this.Controls.Add(this.adminTextBoxPassword);
            this.Controls.Add(this.adminTextBoxUserName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(190, 310);
            this.MinimumSize = new System.Drawing.Size(190, 310);
            this.Name = "AdminSearchForm";
            this.Text = "AdminSearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adminTextBoxFname;
        private System.Windows.Forms.TextBox adminTextBoxLname;
        private System.Windows.Forms.TextBox adminTextBoxRoles;
        private System.Windows.Forms.TextBox adminTextBoxRetireDate;
        private System.Windows.Forms.TextBox adminTextBoxPassword;
        private System.Windows.Forms.TextBox adminTextBoxUserName;
        private System.Windows.Forms.Button adminCancelButton;
        private System.Windows.Forms.Button adminSearchButton;
    }
}