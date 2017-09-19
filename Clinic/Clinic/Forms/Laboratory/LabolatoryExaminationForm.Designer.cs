using DataLayer;
using System;

namespace Clinic
{
    partial class LabolatoryExaminationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labExaminationInfoPanel = new System.Windows.Forms.Panel();
            this.LabExaminationExamStateComboBox = new System.Windows.Forms.ComboBox();
            this.LabExaminationExamStateLabel = new System.Windows.Forms.Label();
            this.LabExaminationPatientPeselTextBox = new System.Windows.Forms.TextBox();
            this.LabExaminationPatientLastNameTextBox = new System.Windows.Forms.TextBox();
            this.LabExaminationPatientFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LabExaminationPatientPeselLabel = new System.Windows.Forms.Label();
            this.LabExaminationPatientNameLabel = new System.Windows.Forms.Label();
            this.LabExaminationExamTypeComboBox = new System.Windows.Forms.ComboBox();
            this.LabExaminationExamTypeLabel = new System.Windows.Forms.Label();
            this.LabExaminationExamApprovalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LabExaminationExamApprovalDateLabel = new System.Windows.Forms.Label();
            this.LabExaminationExamExaminationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LabExaminationExamExaminationDateLabel = new System.Windows.Forms.Label();
            this.LabExaminationExamOrderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LabExaminationExamOrderDateLabel = new System.Windows.Forms.Label();
            this.LabExaminationDoctorPanel = new System.Windows.Forms.Panel();
            this.LabExaminationDoctorCommentsTextBox = new System.Windows.Forms.TextBox();
            this.LabExaminationDoctorCommentsLabel = new System.Windows.Forms.Label();
            this.LabExaminationDoctorLastNameTextBox = new System.Windows.Forms.TextBox();
            this.LabExaminationDoctorFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LabExaminationDoctorNameLabel = new System.Windows.Forms.Label();
            this.LabExaminationLabWorkerPanel = new System.Windows.Forms.Panel();
            this.LabExaminationLabWorkerSubmitButton = new System.Windows.Forms.Button();
            this.LabExaminationLabWorkerCancelButton = new System.Windows.Forms.Button();
            this.LabExaminationExamResultTextBox = new System.Windows.Forms.TextBox();
            this.LabExaminationExamResultLabel = new System.Windows.Forms.Label();
            this.LabExaminationLabWorkerLastNameTextBox = new System.Windows.Forms.TextBox();
            this.LabExaminationLabWorkerFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LabExaminationLabWorkerNameLabel = new System.Windows.Forms.Label();
            this.LabExaminationLabManagerPanel = new System.Windows.Forms.Panel();
            this.LabExaminationLabManagerCancelButton = new System.Windows.Forms.Button();
            this.LabExaminationLabManagerApproveButton = new System.Windows.Forms.Button();
            this.LabExaminationLabManagerCommentsTextBox = new System.Windows.Forms.TextBox();
            this.LabExaminationLabManagerCommentsLabel = new System.Windows.Forms.Label();
            this.LabExaminationLabManagerLastNameTextBox = new System.Windows.Forms.TextBox();
            this.LabExaminationLabManagerFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LabExaminationLabManagerNameLabel = new System.Windows.Forms.Label();
            this.labExaminationInfoPanel.SuspendLayout();
            this.LabExaminationDoctorPanel.SuspendLayout();
            this.LabExaminationLabWorkerPanel.SuspendLayout();
            this.LabExaminationLabManagerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(608, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laboratory Examination";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labExaminationInfoPanel
            // 
            this.labExaminationInfoPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.labExaminationInfoPanel.Controls.Add(this.LabExaminationExamStateComboBox);
            this.labExaminationInfoPanel.Controls.Add(this.LabExaminationExamStateLabel);
            this.labExaminationInfoPanel.Controls.Add(this.LabExaminationPatientPeselTextBox);
            this.labExaminationInfoPanel.Controls.Add(this.LabExaminationPatientLastNameTextBox);
            this.labExaminationInfoPanel.Controls.Add(this.LabExaminationPatientFirstNameTextBox);
            this.labExaminationInfoPanel.Controls.Add(this.LabExaminationPatientPeselLabel);
            this.labExaminationInfoPanel.Controls.Add(this.LabExaminationPatientNameLabel);
            this.labExaminationInfoPanel.Controls.Add(this.LabExaminationExamTypeComboBox);
            this.labExaminationInfoPanel.Controls.Add(this.LabExaminationExamTypeLabel);
            this.labExaminationInfoPanel.Location = new System.Drawing.Point(12, 34);
            this.labExaminationInfoPanel.Name = "labExaminationInfoPanel";
            this.labExaminationInfoPanel.Size = new System.Drawing.Size(584, 60);
            this.labExaminationInfoPanel.TabIndex = 3;
            // 
            // LabExaminationExamStateComboBox
            // 
            this.LabExaminationExamStateComboBox.Enabled = false;
            this.LabExaminationExamStateComboBox.FormattingEnabled = true;
            this.LabExaminationExamStateComboBox.Location = new System.Drawing.Point(461, 30);
            this.LabExaminationExamStateComboBox.Name = "LabExaminationExamStateComboBox";
            this.LabExaminationExamStateComboBox.Size = new System.Drawing.Size(107, 21);
            this.LabExaminationExamStateComboBox.TabIndex = 8;
            this.LabExaminationExamStateComboBox.Text = "In progress";
            // 
            // LabExaminationExamStateLabel
            // 
            this.LabExaminationExamStateLabel.AutoSize = true;
            this.LabExaminationExamStateLabel.Location = new System.Drawing.Point(359, 33);
            this.LabExaminationExamStateLabel.Name = "LabExaminationExamStateLabel";
            this.LabExaminationExamStateLabel.Size = new System.Drawing.Size(96, 13);
            this.LabExaminationExamStateLabel.TabIndex = 7;
            this.LabExaminationExamStateLabel.Text = "Examination state :";
            // 
            // LabExaminationPatientPeselTextBox
            // 
            this.LabExaminationPatientPeselTextBox.Location = new System.Drawing.Point(461, 4);
            this.LabExaminationPatientPeselTextBox.Name = "LabExaminationPatientPeselTextBox";
            this.LabExaminationPatientPeselTextBox.ReadOnly = true;
            this.LabExaminationPatientPeselTextBox.Size = new System.Drawing.Size(107, 20);
            this.LabExaminationPatientPeselTextBox.TabIndex = 6;
            this.LabExaminationPatientPeselTextBox.Text = "PESEL";
            // 
            // LabExaminationPatientLastNameTextBox
            // 
            this.LabExaminationPatientLastNameTextBox.Location = new System.Drawing.Point(207, 4);
            this.LabExaminationPatientLastNameTextBox.Name = "LabExaminationPatientLastNameTextBox";
            this.LabExaminationPatientLastNameTextBox.ReadOnly = true;
            this.LabExaminationPatientLastNameTextBox.Size = new System.Drawing.Size(168, 20);
            this.LabExaminationPatientLastNameTextBox.TabIndex = 5;
            this.LabExaminationPatientLastNameTextBox.Text = "Patient last name";
            // 
            // LabExaminationPatientFirstNameTextBox
            // 
            this.LabExaminationPatientFirstNameTextBox.Location = new System.Drawing.Point(101, 4);
            this.LabExaminationPatientFirstNameTextBox.Name = "LabExaminationPatientFirstNameTextBox";
            this.LabExaminationPatientFirstNameTextBox.ReadOnly = true;
            this.LabExaminationPatientFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LabExaminationPatientFirstNameTextBox.TabIndex = 4;
            this.LabExaminationPatientFirstNameTextBox.Text = "Patient first name";
            // 
            // LabExaminationPatientPeselLabel
            // 
            this.LabExaminationPatientPeselLabel.AutoSize = true;
            this.LabExaminationPatientPeselLabel.Location = new System.Drawing.Point(378, 7);
            this.LabExaminationPatientPeselLabel.Name = "LabExaminationPatientPeselLabel";
            this.LabExaminationPatientPeselLabel.Size = new System.Drawing.Size(77, 13);
            this.LabExaminationPatientPeselLabel.TabIndex = 3;
            this.LabExaminationPatientPeselLabel.Text = "Patient PESEL";
            // 
            // LabExaminationPatientNameLabel
            // 
            this.LabExaminationPatientNameLabel.AutoSize = true;
            this.LabExaminationPatientNameLabel.Location = new System.Drawing.Point(11, 7);
            this.LabExaminationPatientNameLabel.Name = "LabExaminationPatientNameLabel";
            this.LabExaminationPatientNameLabel.Size = new System.Drawing.Size(75, 13);
            this.LabExaminationPatientNameLabel.TabIndex = 2;
            this.LabExaminationPatientNameLabel.Text = "Patient name :";
            // 
            // LabExaminationExamTypeComboBox
            // 
            this.LabExaminationExamTypeComboBox.Enabled = false;
            this.LabExaminationExamTypeComboBox.FormattingEnabled = true;
            this.LabExaminationExamTypeComboBox.Location = new System.Drawing.Point(128, 30);
            this.LabExaminationExamTypeComboBox.Name = "LabExaminationExamTypeComboBox";
            this.LabExaminationExamTypeComboBox.Size = new System.Drawing.Size(225, 21);
            this.LabExaminationExamTypeComboBox.TabIndex = 1;
            this.LabExaminationExamTypeComboBox.Text = "<code + name here>";
            // 
            // LabExaminationExamTypeLabel
            // 
            this.LabExaminationExamTypeLabel.AutoSize = true;
            this.LabExaminationExamTypeLabel.Location = new System.Drawing.Point(11, 33);
            this.LabExaminationExamTypeLabel.Name = "LabExaminationExamTypeLabel";
            this.LabExaminationExamTypeLabel.Size = new System.Drawing.Size(99, 13);
            this.LabExaminationExamTypeLabel.TabIndex = 0;
            this.LabExaminationExamTypeLabel.Text = "Examination name :";
            // 
            // LabExaminationExamApprovalDateTimePicker
            // 
            this.LabExaminationExamApprovalDateTimePicker.Enabled = false;
            this.LabExaminationExamApprovalDateTimePicker.Location = new System.Drawing.Point(103, 29);
            this.LabExaminationExamApprovalDateTimePicker.Name = "LabExaminationExamApprovalDateTimePicker";
            this.LabExaminationExamApprovalDateTimePicker.Size = new System.Drawing.Size(194, 20);
            this.LabExaminationExamApprovalDateTimePicker.TabIndex = 14;
            this.LabExaminationExamApprovalDateTimePicker.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // LabExaminationExamApprovalDateLabel
            // 
            this.LabExaminationExamApprovalDateLabel.AutoSize = true;
            this.LabExaminationExamApprovalDateLabel.Location = new System.Drawing.Point(10, 29);
            this.LabExaminationExamApprovalDateLabel.Name = "LabExaminationExamApprovalDateLabel";
            this.LabExaminationExamApprovalDateLabel.Size = new System.Drawing.Size(79, 13);
            this.LabExaminationExamApprovalDateLabel.TabIndex = 13;
            this.LabExaminationExamApprovalDateLabel.Text = "Approval date :";
            // 
            // LabExaminationExamExaminationDateTimePicker
            // 
            this.LabExaminationExamExaminationDateTimePicker.Enabled = false;
            this.LabExaminationExamExaminationDateTimePicker.Location = new System.Drawing.Point(101, 29);
            this.LabExaminationExamExaminationDateTimePicker.Name = "LabExaminationExamExaminationDateTimePicker";
            this.LabExaminationExamExaminationDateTimePicker.Size = new System.Drawing.Size(194, 20);
            this.LabExaminationExamExaminationDateTimePicker.TabIndex = 12;
            this.LabExaminationExamExaminationDateTimePicker.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // LabExaminationExamExaminationDateLabel
            // 
            this.LabExaminationExamExaminationDateLabel.AutoSize = true;
            this.LabExaminationExamExaminationDateLabel.Location = new System.Drawing.Point(11, 29);
            this.LabExaminationExamExaminationDateLabel.Name = "LabExaminationExamExaminationDateLabel";
            this.LabExaminationExamExaminationDateLabel.Size = new System.Drawing.Size(84, 13);
            this.LabExaminationExamExaminationDateLabel.TabIndex = 11;
            this.LabExaminationExamExaminationDateLabel.Text = "Execution date :";
            // 
            // LabExaminationExamOrderDateTimePicker
            // 
            this.LabExaminationExamOrderDateTimePicker.Enabled = false;
            this.LabExaminationExamOrderDateTimePicker.Location = new System.Drawing.Point(101, 29);
            this.LabExaminationExamOrderDateTimePicker.Name = "LabExaminationExamOrderDateTimePicker";
            this.LabExaminationExamOrderDateTimePicker.Size = new System.Drawing.Size(194, 20);
            this.LabExaminationExamOrderDateTimePicker.TabIndex = 10;
            this.LabExaminationExamOrderDateTimePicker.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // LabExaminationExamOrderDateLabel
            // 
            this.LabExaminationExamOrderDateLabel.AutoSize = true;
            this.LabExaminationExamOrderDateLabel.Location = new System.Drawing.Point(11, 29);
            this.LabExaminationExamOrderDateLabel.Name = "LabExaminationExamOrderDateLabel";
            this.LabExaminationExamOrderDateLabel.Size = new System.Drawing.Size(63, 13);
            this.LabExaminationExamOrderDateLabel.TabIndex = 9;
            this.LabExaminationExamOrderDateLabel.Text = "Order date :";
            // 
            // LabExaminationDoctorPanel
            // 
            this.LabExaminationDoctorPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LabExaminationDoctorPanel.Controls.Add(this.LabExaminationDoctorCommentsTextBox);
            this.LabExaminationDoctorPanel.Controls.Add(this.LabExaminationDoctorCommentsLabel);
            this.LabExaminationDoctorPanel.Controls.Add(this.LabExaminationDoctorLastNameTextBox);
            this.LabExaminationDoctorPanel.Controls.Add(this.LabExaminationDoctorFirstNameTextBox);
            this.LabExaminationDoctorPanel.Controls.Add(this.LabExaminationExamOrderDateTimePicker);
            this.LabExaminationDoctorPanel.Controls.Add(this.LabExaminationExamOrderDateLabel);
            this.LabExaminationDoctorPanel.Controls.Add(this.LabExaminationDoctorNameLabel);
            this.LabExaminationDoctorPanel.Location = new System.Drawing.Point(12, 100);
            this.LabExaminationDoctorPanel.Name = "LabExaminationDoctorPanel";
            this.LabExaminationDoctorPanel.Size = new System.Drawing.Size(583, 127);
            this.LabExaminationDoctorPanel.TabIndex = 4;
            // 
            // LabExaminationDoctorCommentsTextBox
            // 
            this.LabExaminationDoctorCommentsTextBox.Location = new System.Drawing.Point(128, 55);
            this.LabExaminationDoctorCommentsTextBox.Multiline = true;
            this.LabExaminationDoctorCommentsTextBox.Name = "LabExaminationDoctorCommentsTextBox";
            this.LabExaminationDoctorCommentsTextBox.ReadOnly = true;
            this.LabExaminationDoctorCommentsTextBox.Size = new System.Drawing.Size(433, 66);
            this.LabExaminationDoctorCommentsTextBox.TabIndex = 4;
            // 
            // LabExaminationDoctorCommentsLabel
            // 
            this.LabExaminationDoctorCommentsLabel.AutoSize = true;
            this.LabExaminationDoctorCommentsLabel.Location = new System.Drawing.Point(11, 58);
            this.LabExaminationDoctorCommentsLabel.Name = "LabExaminationDoctorCommentsLabel";
            this.LabExaminationDoctorCommentsLabel.Size = new System.Drawing.Size(96, 13);
            this.LabExaminationDoctorCommentsLabel.TabIndex = 3;
            this.LabExaminationDoctorCommentsLabel.Text = "Doctor comments :";
            // 
            // LabExaminationDoctorLastNameTextBox
            // 
            this.LabExaminationDoctorLastNameTextBox.Location = new System.Drawing.Point(207, 3);
            this.LabExaminationDoctorLastNameTextBox.Name = "LabExaminationDoctorLastNameTextBox";
            this.LabExaminationDoctorLastNameTextBox.ReadOnly = true;
            this.LabExaminationDoctorLastNameTextBox.Size = new System.Drawing.Size(168, 20);
            this.LabExaminationDoctorLastNameTextBox.TabIndex = 2;
            this.LabExaminationDoctorLastNameTextBox.Text = "Doctor last name";
            // 
            // LabExaminationDoctorFirstNameTextBox
            // 
            this.LabExaminationDoctorFirstNameTextBox.Location = new System.Drawing.Point(101, 3);
            this.LabExaminationDoctorFirstNameTextBox.Name = "LabExaminationDoctorFirstNameTextBox";
            this.LabExaminationDoctorFirstNameTextBox.ReadOnly = true;
            this.LabExaminationDoctorFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LabExaminationDoctorFirstNameTextBox.TabIndex = 1;
            this.LabExaminationDoctorFirstNameTextBox.Text = "Doctor first name";
            // 
            // LabExaminationDoctorNameLabel
            // 
            this.LabExaminationDoctorNameLabel.AutoSize = true;
            this.LabExaminationDoctorNameLabel.Location = new System.Drawing.Point(11, 6);
            this.LabExaminationDoctorNameLabel.Name = "LabExaminationDoctorNameLabel";
            this.LabExaminationDoctorNameLabel.Size = new System.Drawing.Size(74, 13);
            this.LabExaminationDoctorNameLabel.TabIndex = 0;
            this.LabExaminationDoctorNameLabel.Text = "Doctor name :";
            // 
            // LabExaminationLabWorkerPanel
            // 
            this.LabExaminationLabWorkerPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LabExaminationLabWorkerPanel.Controls.Add(this.LabExaminationLabWorkerSubmitButton);
            this.LabExaminationLabWorkerPanel.Controls.Add(this.LabExaminationLabWorkerCancelButton);
            this.LabExaminationLabWorkerPanel.Controls.Add(this.LabExaminationExamExaminationDateTimePicker);
            this.LabExaminationLabWorkerPanel.Controls.Add(this.LabExaminationExamExaminationDateLabel);
            this.LabExaminationLabWorkerPanel.Controls.Add(this.LabExaminationExamResultTextBox);
            this.LabExaminationLabWorkerPanel.Controls.Add(this.LabExaminationExamResultLabel);
            this.LabExaminationLabWorkerPanel.Controls.Add(this.LabExaminationLabWorkerLastNameTextBox);
            this.LabExaminationLabWorkerPanel.Controls.Add(this.LabExaminationLabWorkerFirstNameTextBox);
            this.LabExaminationLabWorkerPanel.Controls.Add(this.LabExaminationLabWorkerNameLabel);
            this.LabExaminationLabWorkerPanel.Location = new System.Drawing.Point(12, 233);
            this.LabExaminationLabWorkerPanel.Name = "LabExaminationLabWorkerPanel";
            this.LabExaminationLabWorkerPanel.Size = new System.Drawing.Size(583, 156);
            this.LabExaminationLabWorkerPanel.TabIndex = 5;
            // 
            // LabExaminationLabWorkerSubmitButton
            // 
            this.LabExaminationLabWorkerSubmitButton.Location = new System.Drawing.Point(200, 127);
            this.LabExaminationLabWorkerSubmitButton.Name = "LabExaminationLabWorkerSubmitButton";
            this.LabExaminationLabWorkerSubmitButton.Size = new System.Drawing.Size(129, 23);
            this.LabExaminationLabWorkerSubmitButton.TabIndex = 6;
            this.LabExaminationLabWorkerSubmitButton.Text = "Submit Examination";
            this.LabExaminationLabWorkerSubmitButton.UseVisualStyleBackColor = true;
            this.LabExaminationLabWorkerSubmitButton.Click += new EventHandler(LabExaminationLabWorkerSubmitButton_Click);
            // 
            // LabExaminationLabWorkerCancelButton
            // 
            this.LabExaminationLabWorkerCancelButton.Location = new System.Drawing.Point(381, 127);
            this.LabExaminationLabWorkerCancelButton.Name = "LabExaminationLabWorkerCancelButton";
            this.LabExaminationLabWorkerCancelButton.Size = new System.Drawing.Size(115, 23);
            this.LabExaminationLabWorkerCancelButton.TabIndex = 5;
            this.LabExaminationLabWorkerCancelButton.Text = "Cancel  Examination";
            this.LabExaminationLabWorkerCancelButton.UseVisualStyleBackColor = true;
            this.LabExaminationLabWorkerCancelButton.Click += new EventHandler(LabExaminationLabWorkerCancelButton_Click);
            // 
            // LabExaminationExamResultTextBox
            // 
            this.LabExaminationExamResultTextBox.Location = new System.Drawing.Point(128, 55);
            this.LabExaminationExamResultTextBox.Multiline = true;
            this.LabExaminationExamResultTextBox.Name = "LabExaminationExamResultTextBox";
            this.LabExaminationExamResultTextBox.ReadOnly = true;
            this.LabExaminationExamResultTextBox.Size = new System.Drawing.Size(433, 66);
            this.LabExaminationExamResultTextBox.TabIndex = 4;
            // 
            // LabExaminationExamResultLabel
            // 
            this.LabExaminationExamResultLabel.AutoSize = true;
            this.LabExaminationExamResultLabel.Location = new System.Drawing.Point(11, 58);
            this.LabExaminationExamResultLabel.Name = "LabExaminationExamResultLabel";
            this.LabExaminationExamResultLabel.Size = new System.Drawing.Size(98, 13);
            this.LabExaminationExamResultLabel.TabIndex = 3;
            this.LabExaminationExamResultLabel.Text = "Examination result :";
            // 
            // LabExaminationLabWorkerLastNameTextBox
            // 
            this.LabExaminationLabWorkerLastNameTextBox.Location = new System.Drawing.Point(207, 3);
            this.LabExaminationLabWorkerLastNameTextBox.Name = "LabExaminationLabWorkerLastNameTextBox";
            this.LabExaminationLabWorkerLastNameTextBox.ReadOnly = true;
            this.LabExaminationLabWorkerLastNameTextBox.Size = new System.Drawing.Size(168, 20);
            this.LabExaminationLabWorkerLastNameTextBox.TabIndex = 2;
            this.LabExaminationLabWorkerLastNameTextBox.Text = "Worker last name";
            // 
            // LabExaminationLabWorkerFirstNameTextBox
            // 
            this.LabExaminationLabWorkerFirstNameTextBox.Location = new System.Drawing.Point(101, 3);
            this.LabExaminationLabWorkerFirstNameTextBox.Name = "LabExaminationLabWorkerFirstNameTextBox";
            this.LabExaminationLabWorkerFirstNameTextBox.ReadOnly = true;
            this.LabExaminationLabWorkerFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LabExaminationLabWorkerFirstNameTextBox.TabIndex = 1;
            this.LabExaminationLabWorkerFirstNameTextBox.Text = "Worker first name";
            // 
            // LabExaminationLabWorkerNameLabel
            // 
            this.LabExaminationLabWorkerNameLabel.AutoSize = true;
            this.LabExaminationLabWorkerNameLabel.Location = new System.Drawing.Point(11, 6);
            this.LabExaminationLabWorkerNameLabel.Name = "LabExaminationLabWorkerNameLabel";
            this.LabExaminationLabWorkerNameLabel.Size = new System.Drawing.Size(66, 13);
            this.LabExaminationLabWorkerNameLabel.TabIndex = 0;
            this.LabExaminationLabWorkerNameLabel.Text = "Lab worker :";
            // 
            // LabExaminationLabManagerPanel
            // 
            this.LabExaminationLabManagerPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LabExaminationLabManagerPanel.Controls.Add(this.LabExaminationExamApprovalDateTimePicker);
            this.LabExaminationLabManagerPanel.Controls.Add(this.LabExaminationExamApprovalDateLabel);
            this.LabExaminationLabManagerPanel.Controls.Add(this.LabExaminationLabManagerCancelButton);
            this.LabExaminationLabManagerPanel.Controls.Add(this.LabExaminationLabManagerApproveButton);
            this.LabExaminationLabManagerPanel.Controls.Add(this.LabExaminationLabManagerCommentsTextBox);
            this.LabExaminationLabManagerPanel.Controls.Add(this.LabExaminationLabManagerCommentsLabel);
            this.LabExaminationLabManagerPanel.Controls.Add(this.LabExaminationLabManagerLastNameTextBox);
            this.LabExaminationLabManagerPanel.Controls.Add(this.LabExaminationLabManagerFirstNameTextBox);
            this.LabExaminationLabManagerPanel.Controls.Add(this.LabExaminationLabManagerNameLabel);
            this.LabExaminationLabManagerPanel.Location = new System.Drawing.Point(13, 395);
            this.LabExaminationLabManagerPanel.Name = "LabExaminationLabManagerPanel";
            this.LabExaminationLabManagerPanel.Size = new System.Drawing.Size(583, 156);
            this.LabExaminationLabManagerPanel.TabIndex = 6;
            // 
            // LabExaminationLabManagerCancelButton
            // 
            this.LabExaminationLabManagerCancelButton.Location = new System.Drawing.Point(380, 123);
            this.LabExaminationLabManagerCancelButton.Name = "LabExaminationLabManagerCancelButton";
            this.LabExaminationLabManagerCancelButton.Size = new System.Drawing.Size(115, 23);
            this.LabExaminationLabManagerCancelButton.TabIndex = 8;
            this.LabExaminationLabManagerCancelButton.Text = "Cancel  Examination";
            this.LabExaminationLabManagerCancelButton.UseVisualStyleBackColor = true;
            // 
            // LabExaminationLabManagerApproveButton
            // 
            this.LabExaminationLabManagerApproveButton.Location = new System.Drawing.Point(199, 123);
            this.LabExaminationLabManagerApproveButton.Name = "LabExaminationLabManagerApproveButton";
            this.LabExaminationLabManagerApproveButton.Size = new System.Drawing.Size(129, 23);
            this.LabExaminationLabManagerApproveButton.TabIndex = 7;
            this.LabExaminationLabManagerApproveButton.Text = "Approve Examination";
            this.LabExaminationLabManagerApproveButton.UseVisualStyleBackColor = true;
            // 
            // LabExaminationLabManagerCommentsTextBox
            // 
            this.LabExaminationLabManagerCommentsTextBox.Location = new System.Drawing.Point(127, 55);
            this.LabExaminationLabManagerCommentsTextBox.Multiline = true;
            this.LabExaminationLabManagerCommentsTextBox.Name = "LabExaminationLabManagerCommentsTextBox";
            this.LabExaminationLabManagerCommentsTextBox.ReadOnly = true;
            this.LabExaminationLabManagerCommentsTextBox.Size = new System.Drawing.Size(433, 66);
            this.LabExaminationLabManagerCommentsTextBox.TabIndex = 4;
            // 
            // LabExaminationLabManagerCommentsLabel
            // 
            this.LabExaminationLabManagerCommentsLabel.AutoSize = true;
            this.LabExaminationLabManagerCommentsLabel.Location = new System.Drawing.Point(10, 59);
            this.LabExaminationLabManagerCommentsLabel.Name = "LabExaminationLabManagerCommentsLabel";
            this.LabExaminationLabManagerCommentsLabel.Size = new System.Drawing.Size(106, 13);
            this.LabExaminationLabManagerCommentsLabel.TabIndex = 3;
            this.LabExaminationLabManagerCommentsLabel.Text = "Manager comments :";
            // 
            // LabExaminationLabManagerLastNameTextBox
            // 
            this.LabExaminationLabManagerLastNameTextBox.Location = new System.Drawing.Point(206, 3);
            this.LabExaminationLabManagerLastNameTextBox.Name = "LabExaminationLabManagerLastNameTextBox";
            this.LabExaminationLabManagerLastNameTextBox.ReadOnly = true;
            this.LabExaminationLabManagerLastNameTextBox.Size = new System.Drawing.Size(168, 20);
            this.LabExaminationLabManagerLastNameTextBox.TabIndex = 2;
            this.LabExaminationLabManagerLastNameTextBox.Text = "Manager last name";
            // 
            // LabExaminationLabManagerFirstNameTextBox
            // 
            this.LabExaminationLabManagerFirstNameTextBox.Location = new System.Drawing.Point(100, 3);
            this.LabExaminationLabManagerFirstNameTextBox.Name = "LabExaminationLabManagerFirstNameTextBox";
            this.LabExaminationLabManagerFirstNameTextBox.ReadOnly = true;
            this.LabExaminationLabManagerFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LabExaminationLabManagerFirstNameTextBox.TabIndex = 1;
            this.LabExaminationLabManagerFirstNameTextBox.Text = "Manager first name";
            // 
            // LabExaminationLabManagerNameLabel
            // 
            this.LabExaminationLabManagerNameLabel.AutoSize = true;
            this.LabExaminationLabManagerNameLabel.Location = new System.Drawing.Point(10, 6);
            this.LabExaminationLabManagerNameLabel.Name = "LabExaminationLabManagerNameLabel";
            this.LabExaminationLabManagerNameLabel.Size = new System.Drawing.Size(75, 13);
            this.LabExaminationLabManagerNameLabel.TabIndex = 0;
            this.LabExaminationLabManagerNameLabel.Text = "Lab manager :";
            // 
            // LabolatoryExaminationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 565);
            this.Controls.Add(this.LabExaminationLabManagerPanel);
            this.Controls.Add(this.LabExaminationLabWorkerPanel);
            this.Controls.Add(this.LabExaminationDoctorPanel);
            this.Controls.Add(this.labExaminationInfoPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LabolatoryExaminationForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "LabExamination";
            this.labExaminationInfoPanel.ResumeLayout(false);
            this.labExaminationInfoPanel.PerformLayout();
            this.LabExaminationDoctorPanel.ResumeLayout(false);
            this.LabExaminationDoctorPanel.PerformLayout();
            this.LabExaminationLabWorkerPanel.ResumeLayout(false);
            this.LabExaminationLabWorkerPanel.PerformLayout();
            this.LabExaminationLabManagerPanel.ResumeLayout(false);
            this.LabExaminationLabManagerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        

       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel labExaminationInfoPanel;
        private System.Windows.Forms.ComboBox LabExaminationExamTypeComboBox;
        private System.Windows.Forms.Label LabExaminationExamTypeLabel;
        private System.Windows.Forms.Label LabExaminationPatientNameLabel;
        private System.Windows.Forms.TextBox LabExaminationPatientPeselTextBox;
        private System.Windows.Forms.TextBox LabExaminationPatientLastNameTextBox;
        private System.Windows.Forms.TextBox LabExaminationPatientFirstNameTextBox;
        private System.Windows.Forms.Label LabExaminationPatientPeselLabel;
        private System.Windows.Forms.DateTimePicker LabExaminationExamOrderDateTimePicker;
        private System.Windows.Forms.Label LabExaminationExamOrderDateLabel;
        private System.Windows.Forms.ComboBox LabExaminationExamStateComboBox;
        private System.Windows.Forms.Label LabExaminationExamStateLabel;
        private System.Windows.Forms.Panel LabExaminationDoctorPanel;
        private System.Windows.Forms.TextBox LabExaminationDoctorCommentsTextBox;
        private System.Windows.Forms.Label LabExaminationDoctorCommentsLabel;
        private System.Windows.Forms.TextBox LabExaminationDoctorLastNameTextBox;
        private System.Windows.Forms.TextBox LabExaminationDoctorFirstNameTextBox;
        private System.Windows.Forms.Label LabExaminationDoctorNameLabel;
        private System.Windows.Forms.Panel LabExaminationLabWorkerPanel;
        private System.Windows.Forms.TextBox LabExaminationExamResultTextBox;
        private System.Windows.Forms.Label LabExaminationExamResultLabel;
        private System.Windows.Forms.TextBox LabExaminationLabWorkerLastNameTextBox;
        private System.Windows.Forms.TextBox LabExaminationLabWorkerFirstNameTextBox;
        private System.Windows.Forms.Label LabExaminationLabWorkerNameLabel;
        private System.Windows.Forms.Panel LabExaminationLabManagerPanel;
        private System.Windows.Forms.TextBox LabExaminationLabManagerCommentsTextBox;
        private System.Windows.Forms.Label LabExaminationLabManagerCommentsLabel;
        private System.Windows.Forms.TextBox LabExaminationLabManagerLastNameTextBox;
        private System.Windows.Forms.TextBox LabExaminationLabManagerFirstNameTextBox;
        private System.Windows.Forms.Label LabExaminationLabManagerNameLabel;
        private System.Windows.Forms.Button LabExaminationLabWorkerSubmitButton;
        private System.Windows.Forms.Button LabExaminationLabWorkerCancelButton;
        private System.Windows.Forms.Button LabExaminationLabManagerCancelButton;
        private System.Windows.Forms.Button LabExaminationLabManagerApproveButton;
        private System.Windows.Forms.DateTimePicker LabExaminationExamApprovalDateTimePicker;
        private System.Windows.Forms.Label LabExaminationExamApprovalDateLabel;
        private System.Windows.Forms.DateTimePicker LabExaminationExamExaminationDateTimePicker;
        private System.Windows.Forms.Label LabExaminationExamExaminationDateLabel;
    }
}