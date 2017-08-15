namespace Clinic
{
    partial class DoctorExaminationViewForm
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
            this.doctorExaminationViewExamTypeComboBox = new System.Windows.Forms.ComboBox();
            this.doctorExaminationViewExamTypeLabel = new System.Windows.Forms.Label();
            this.doctorExaminationViewCommentsResultTextBox = new System.Windows.Forms.TextBox();
            this.doctorExaminationViewExamTypeHeadingLabel = new System.Windows.Forms.Label();
            this.doctorExaminationViewCommentsResultLabel = new System.Windows.Forms.Label();
            this.doctorExaminationViewSubmitButton = new System.Windows.Forms.Button();
            this.doctorExaminationViewOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doctorExaminationViewExamTypeComboBox
            // 
            this.doctorExaminationViewExamTypeComboBox.FormattingEnabled = true;
            this.doctorExaminationViewExamTypeComboBox.Location = new System.Drawing.Point(12, 61);
            this.doctorExaminationViewExamTypeComboBox.Name = "doctorExaminationViewExamTypeComboBox";
            this.doctorExaminationViewExamTypeComboBox.Size = new System.Drawing.Size(374, 21);
            this.doctorExaminationViewExamTypeComboBox.TabIndex = 0;
            // 
            // doctorExaminationViewExamTypeLabel
            // 
            this.doctorExaminationViewExamTypeLabel.AutoSize = true;
            this.doctorExaminationViewExamTypeLabel.Location = new System.Drawing.Point(12, 45);
            this.doctorExaminationViewExamTypeLabel.Name = "doctorExaminationViewExamTypeLabel";
            this.doctorExaminationViewExamTypeLabel.Size = new System.Drawing.Size(93, 13);
            this.doctorExaminationViewExamTypeLabel.TabIndex = 1;
            this.doctorExaminationViewExamTypeLabel.Text = "Examination type :";
            // 
            // doctorExaminationViewCommentsResultTextBox
            // 
            this.doctorExaminationViewCommentsResultTextBox.Location = new System.Drawing.Point(12, 105);
            this.doctorExaminationViewCommentsResultTextBox.Multiline = true;
            this.doctorExaminationViewCommentsResultTextBox.Name = "doctorExaminationViewCommentsResultTextBox";
            this.doctorExaminationViewCommentsResultTextBox.Size = new System.Drawing.Size(374, 146);
            this.doctorExaminationViewCommentsResultTextBox.TabIndex = 2;
            // 
            // doctorExaminationViewExamTypeHeadingLabel
            // 
            this.doctorExaminationViewExamTypeHeadingLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.doctorExaminationViewExamTypeHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.doctorExaminationViewExamTypeHeadingLabel.Location = new System.Drawing.Point(0, 0);
            this.doctorExaminationViewExamTypeHeadingLabel.Name = "doctorExaminationViewExamTypeHeadingLabel";
            this.doctorExaminationViewExamTypeHeadingLabel.Size = new System.Drawing.Size(398, 38);
            this.doctorExaminationViewExamTypeHeadingLabel.TabIndex = 3;
            this.doctorExaminationViewExamTypeHeadingLabel.Text = "Laboratory Examination";
            this.doctorExaminationViewExamTypeHeadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doctorExaminationViewCommentsResultLabel
            // 
            this.doctorExaminationViewCommentsResultLabel.AutoSize = true;
            this.doctorExaminationViewCommentsResultLabel.Location = new System.Drawing.Point(12, 89);
            this.doctorExaminationViewCommentsResultLabel.Name = "doctorExaminationViewCommentsResultLabel";
            this.doctorExaminationViewCommentsResultLabel.Size = new System.Drawing.Size(62, 13);
            this.doctorExaminationViewCommentsResultLabel.TabIndex = 4;
            this.doctorExaminationViewCommentsResultLabel.Text = "Comments :";
            // 
            // doctorExaminationViewSubmitButton
            // 
            this.doctorExaminationViewSubmitButton.Location = new System.Drawing.Point(300, 259);
            this.doctorExaminationViewSubmitButton.Name = "doctorExaminationViewSubmitButton";
            this.doctorExaminationViewSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.doctorExaminationViewSubmitButton.TabIndex = 5;
            this.doctorExaminationViewSubmitButton.Text = "Confirm";
            this.doctorExaminationViewSubmitButton.UseVisualStyleBackColor = true;
            this.doctorExaminationViewSubmitButton.Visible = false;
            // 
            // doctorExaminationViewOrderButton
            // 
            this.doctorExaminationViewOrderButton.Location = new System.Drawing.Point(300, 259);
            this.doctorExaminationViewOrderButton.Name = "doctorExaminationViewOrderButton";
            this.doctorExaminationViewOrderButton.Size = new System.Drawing.Size(75, 23);
            this.doctorExaminationViewOrderButton.TabIndex = 6;
            this.doctorExaminationViewOrderButton.Text = "Order";
            this.doctorExaminationViewOrderButton.UseVisualStyleBackColor = true;
            this.doctorExaminationViewOrderButton.Visible = false;
            // 
            // DoctorExaminationViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 294);
            this.Controls.Add(this.doctorExaminationViewOrderButton);
            this.Controls.Add(this.doctorExaminationViewSubmitButton);
            this.Controls.Add(this.doctorExaminationViewCommentsResultLabel);
            this.Controls.Add(this.doctorExaminationViewExamTypeHeadingLabel);
            this.Controls.Add(this.doctorExaminationViewCommentsResultTextBox);
            this.Controls.Add(this.doctorExaminationViewExamTypeLabel);
            this.Controls.Add(this.doctorExaminationViewExamTypeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DoctorExaminationViewForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "DoctorExaminationView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
       
        private System.Windows.Forms.ComboBox doctorExaminationViewExamTypeComboBox;
        private System.Windows.Forms.Label doctorExaminationViewExamTypeLabel;
        private System.Windows.Forms.TextBox doctorExaminationViewCommentsResultTextBox;
        private System.Windows.Forms.Label doctorExaminationViewExamTypeHeadingLabel;
        private System.Windows.Forms.Label doctorExaminationViewCommentsResultLabel;
        private System.Windows.Forms.Button doctorExaminationViewSubmitButton;
        private System.Windows.Forms.Button doctorExaminationViewOrderButton;
    }
}