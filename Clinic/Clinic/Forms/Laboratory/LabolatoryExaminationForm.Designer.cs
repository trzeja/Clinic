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
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(899, 38);
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
            this.labExaminationInfoPanel.Location = new System.Drawing.Point(16, 42);
            this.labExaminationInfoPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labExaminationInfoPanel.Name = "labExaminationInfoPanel";
            this.labExaminationInfoPanel.Size = new System.Drawing.Size(870, 74);
            this.labExaminationInfoPanel.TabIndex = 3;
            // 
            // LabExaminationExamStateComboBox
            // 
            this.LabExaminationExamStateComboBox.Enabled = false;
            this.LabExaminationExamStateComboBox.FormattingEnabled = true;
            this.LabExaminationExamStateComboBox.Location = new System.Drawing.Point(615, 37);
            this.LabExaminationExamStateComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationExamStateComboBox.Name = "LabExaminationExamStateComboBox";
            this.LabExaminationExamStateComboBox.Size = new System.Drawing.Size(235, 24);
            this.LabExaminationExamStateComboBox.TabIndex = 8;
            this.LabExaminationExamStateComboBox.Text = "In progress";
            // 
            // LabExaminationExamStateLabel
            // 
            this.LabExaminationExamStateLabel.AutoSize = true;
            this.LabExaminationExamStateLabel.Location = new System.Drawing.Point(479, 41);
            this.LabExaminationExamStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabExaminationExamStateLabel.Name = "LabExaminationExamStateLabel";
            this.LabExaminationExamStateLabel.Size = new System.Drawing.Size(127, 17);
            this.LabExaminationExamStateLabel.TabIndex = 7;
            this.LabExaminationExamStateLabel.Text = "Examination state :";
            // 
            // LabExaminationPatientPeselTextBox
            // 
            this.LabExaminationPatientPeselTextBox.Location = new System.Drawing.Point(615, 5);
            this.LabExaminationPatientPeselTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationPatientPeselTextBox.Name = "LabExaminationPatientPeselTextBox";
            this.LabExaminationPatientPeselTextBox.ReadOnly = true;
            this.LabExaminationPatientPeselTextBox.Size = new System.Drawing.Size(141, 22);
            this.LabExaminationPatientPeselTextBox.TabIndex = 6;
            this.LabExaminationPatientPeselTextBox.Text = "PESEL";
            // 
            // LabExaminationPatientLastNameTextBox
            // 
            this.LabExaminationPatientLastNameTextBox.Location = new System.Drawing.Point(276, 5);
            this.LabExaminationPatientLastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationPatientLastNameTextBox.Name = "LabExaminationPatientLastNameTextBox";
            this.LabExaminationPatientLastNameTextBox.ReadOnly = true;
            this.LabExaminationPatientLastNameTextBox.Size = new System.Drawing.Size(223, 22);
            this.LabExaminationPatientLastNameTextBox.TabIndex = 5;
            this.LabExaminationPatientLastNameTextBox.Text = "Patient last name";
            // 
            // LabExaminationPatientFirstNameTextBox
            // 
            this.LabExaminationPatientFirstNameTextBox.Location = new System.Drawing.Point(135, 5);
            this.LabExaminationPatientFirstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationPatientFirstNameTextBox.Name = "LabExaminationPatientFirstNameTextBox";
            this.LabExaminationPatientFirstNameTextBox.ReadOnly = true;
            this.LabExaminationPatientFirstNameTextBox.Size = new System.Drawing.Size(132, 22);
            this.LabExaminationPatientFirstNameTextBox.TabIndex = 4;
            this.LabExaminationPatientFirstNameTextBox.Text = "Patient first name";
            // 
            // LabExaminationPatientPeselLabel
            // 
            this.LabExaminationPatientPeselLabel.AutoSize = true;
            this.LabExaminationPatientPeselLabel.Location = new System.Drawing.Point(504, 9);
            this.LabExaminationPatientPeselLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabExaminationPatientPeselLabel.Name = "LabExaminationPatientPeselLabel";
            this.LabExaminationPatientPeselLabel.Size = new System.Drawing.Size(100, 17);
            this.LabExaminationPatientPeselLabel.TabIndex = 3;
            this.LabExaminationPatientPeselLabel.Text = "Patient PESEL";
            // 
            // LabExaminationPatientNameLabel
            // 
            this.LabExaminationPatientNameLabel.AutoSize = true;
            this.LabExaminationPatientNameLabel.Location = new System.Drawing.Point(15, 9);
            this.LabExaminationPatientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabExaminationPatientNameLabel.Name = "LabExaminationPatientNameLabel";
            this.LabExaminationPatientNameLabel.Size = new System.Drawing.Size(99, 17);
            this.LabExaminationPatientNameLabel.TabIndex = 2;
            this.LabExaminationPatientNameLabel.Text = "Patient name :";
            // 
            // LabExaminationExamTypeComboBox
            // 
            this.LabExaminationExamTypeComboBox.Enabled = false;
            this.LabExaminationExamTypeComboBox.FormattingEnabled = true;
            this.LabExaminationExamTypeComboBox.Location = new System.Drawing.Point(171, 37);
            this.LabExaminationExamTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationExamTypeComboBox.Name = "LabExaminationExamTypeComboBox";
            this.LabExaminationExamTypeComboBox.Size = new System.Drawing.Size(299, 24);
            this.LabExaminationExamTypeComboBox.TabIndex = 1;
            this.LabExaminationExamTypeComboBox.Text = "<code + name here>";
            // 
            // LabExaminationExamTypeLabel
            // 
            this.LabExaminationExamTypeLabel.AutoSize = true;
            this.LabExaminationExamTypeLabel.Location = new System.Drawing.Point(15, 41);
            this.LabExaminationExamTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabExaminationExamTypeLabel.Name = "LabExaminationExamTypeLabel";
            this.LabExaminationExamTypeLabel.Size = new System.Drawing.Size(131, 17);
            this.LabExaminationExamTypeLabel.TabIndex = 0;
            this.LabExaminationExamTypeLabel.Text = "Examination name :";
            // 
            // LabExaminationExamApprovalDateTimePicker
            // 
            this.LabExaminationExamApprovalDateTimePicker.Enabled = false;
            this.LabExaminationExamApprovalDateTimePicker.Location = new System.Drawing.Point(137, 36);
            this.LabExaminationExamApprovalDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationExamApprovalDateTimePicker.Name = "LabExaminationExamApprovalDateTimePicker";
            this.LabExaminationExamApprovalDateTimePicker.Size = new System.Drawing.Size(257, 22);
            this.LabExaminationExamApprovalDateTimePicker.TabIndex = 14;
            this.LabExaminationExamApprovalDateTimePicker.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // LabExaminationExamApprovalDateLabel
            // 
            this.LabExaminationExamApprovalDateLabel.AutoSize = true;
            this.LabExaminationExamApprovalDateLabel.Location = new System.Drawing.Point(13, 36);
            this.LabExaminationExamApprovalDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabExaminationExamApprovalDateLabel.Name = "LabExaminationExamApprovalDateLabel";
            this.LabExaminationExamApprovalDateLabel.Size = new System.Drawing.Size(104, 17);
            this.LabExaminationExamApprovalDateLabel.TabIndex = 13;
            this.LabExaminationExamApprovalDateLabel.Text = "Approval date :";
            // 
            // LabExaminationExamExaminationDateTimePicker
            // 
            this.LabExaminationExamExaminationDateTimePicker.Enabled = false;
            this.LabExaminationExamExaminationDateTimePicker.Location = new System.Drawing.Point(135, 36);
            this.LabExaminationExamExaminationDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationExamExaminationDateTimePicker.Name = "LabExaminationExamExaminationDateTimePicker";
            this.LabExaminationExamExaminationDateTimePicker.Size = new System.Drawing.Size(257, 22);
            this.LabExaminationExamExaminationDateTimePicker.TabIndex = 12;
            this.LabExaminationExamExaminationDateTimePicker.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // LabExaminationExamExaminationDateLabel
            // 
            this.LabExaminationExamExaminationDateLabel.AutoSize = true;
            this.LabExaminationExamExaminationDateLabel.Location = new System.Drawing.Point(15, 36);
            this.LabExaminationExamExaminationDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabExaminationExamExaminationDateLabel.Name = "LabExaminationExamExaminationDateLabel";
            this.LabExaminationExamExaminationDateLabel.Size = new System.Drawing.Size(109, 17);
            this.LabExaminationExamExaminationDateLabel.TabIndex = 11;
            this.LabExaminationExamExaminationDateLabel.Text = "Execution date :";
            // 
            // LabExaminationExamOrderDateTimePicker
            // 
            this.LabExaminationExamOrderDateTimePicker.Enabled = false;
            this.LabExaminationExamOrderDateTimePicker.Location = new System.Drawing.Point(135, 36);
            this.LabExaminationExamOrderDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationExamOrderDateTimePicker.Name = "LabExaminationExamOrderDateTimePicker";
            this.LabExaminationExamOrderDateTimePicker.Size = new System.Drawing.Size(257, 22);
            this.LabExaminationExamOrderDateTimePicker.TabIndex = 10;
            this.LabExaminationExamOrderDateTimePicker.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // LabExaminationExamOrderDateLabel
            // 
            this.LabExaminationExamOrderDateLabel.AutoSize = true;
            this.LabExaminationExamOrderDateLabel.Location = new System.Drawing.Point(15, 36);
            this.LabExaminationExamOrderDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabExaminationExamOrderDateLabel.Name = "LabExaminationExamOrderDateLabel";
            this.LabExaminationExamOrderDateLabel.Size = new System.Drawing.Size(85, 17);
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
            this.LabExaminationDoctorPanel.Location = new System.Drawing.Point(16, 123);
            this.LabExaminationDoctorPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationDoctorPanel.Name = "LabExaminationDoctorPanel";
            this.LabExaminationDoctorPanel.Size = new System.Drawing.Size(868, 156);
            this.LabExaminationDoctorPanel.TabIndex = 4;
            // 
            // LabExaminationDoctorCommentsTextBox
            // 
            this.LabExaminationDoctorCommentsTextBox.Location = new System.Drawing.Point(171, 68);
            this.LabExaminationDoctorCommentsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationDoctorCommentsTextBox.Multiline = true;
            this.LabExaminationDoctorCommentsTextBox.Name = "LabExaminationDoctorCommentsTextBox";
            this.LabExaminationDoctorCommentsTextBox.ReadOnly = true;
            this.LabExaminationDoctorCommentsTextBox.Size = new System.Drawing.Size(576, 80);
            this.LabExaminationDoctorCommentsTextBox.TabIndex = 4;
            // 
            // LabExaminationDoctorCommentsLabel
            // 
            this.LabExaminationDoctorCommentsLabel.AutoSize = true;
            this.LabExaminationDoctorCommentsLabel.Location = new System.Drawing.Point(15, 71);
            this.LabExaminationDoctorCommentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabExaminationDoctorCommentsLabel.Name = "LabExaminationDoctorCommentsLabel";
            this.LabExaminationDoctorCommentsLabel.Size = new System.Drawing.Size(126, 17);
            this.LabExaminationDoctorCommentsLabel.TabIndex = 3;
            this.LabExaminationDoctorCommentsLabel.Text = "Doctor comments :";
            // 
            // LabExaminationDoctorLastNameTextBox
            // 
            this.LabExaminationDoctorLastNameTextBox.Location = new System.Drawing.Point(276, 4);
            this.LabExaminationDoctorLastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationDoctorLastNameTextBox.Name = "LabExaminationDoctorLastNameTextBox";
            this.LabExaminationDoctorLastNameTextBox.ReadOnly = true;
            this.LabExaminationDoctorLastNameTextBox.Size = new System.Drawing.Size(223, 22);
            this.LabExaminationDoctorLastNameTextBox.TabIndex = 2;
            this.LabExaminationDoctorLastNameTextBox.Text = "Doctor last name";
            // 
            // LabExaminationDoctorFirstNameTextBox
            // 
            this.LabExaminationDoctorFirstNameTextBox.Location = new System.Drawing.Point(135, 4);
            this.LabExaminationDoctorFirstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationDoctorFirstNameTextBox.Name = "LabExaminationDoctorFirstNameTextBox";
            this.LabExaminationDoctorFirstNameTextBox.ReadOnly = true;
            this.LabExaminationDoctorFirstNameTextBox.Size = new System.Drawing.Size(132, 22);
            this.LabExaminationDoctorFirstNameTextBox.TabIndex = 1;
            this.LabExaminationDoctorFirstNameTextBox.Text = "Doctor first name";
            // 
            // LabExaminationDoctorNameLabel
            // 
            this.LabExaminationDoctorNameLabel.AutoSize = true;
            this.LabExaminationDoctorNameLabel.Location = new System.Drawing.Point(15, 7);
            this.LabExaminationDoctorNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabExaminationDoctorNameLabel.Name = "LabExaminationDoctorNameLabel";
            this.LabExaminationDoctorNameLabel.Size = new System.Drawing.Size(97, 17);
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
            this.LabExaminationLabWorkerPanel.Location = new System.Drawing.Point(16, 287);
            this.LabExaminationLabWorkerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationLabWorkerPanel.Name = "LabExaminationLabWorkerPanel";
            this.LabExaminationLabWorkerPanel.Size = new System.Drawing.Size(868, 192);
            this.LabExaminationLabWorkerPanel.TabIndex = 5;
            // 
            // LabExaminationLabWorkerSubmitButton
            // 
            this.LabExaminationLabWorkerSubmitButton.Location = new System.Drawing.Point(267, 156);
            this.LabExaminationLabWorkerSubmitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationLabWorkerSubmitButton.Name = "LabExaminationLabWorkerSubmitButton";
            this.LabExaminationLabWorkerSubmitButton.Size = new System.Drawing.Size(172, 28);
            this.LabExaminationLabWorkerSubmitButton.TabIndex = 6;
            this.LabExaminationLabWorkerSubmitButton.Text = "Submit Examination";
            this.LabExaminationLabWorkerSubmitButton.UseVisualStyleBackColor = true;
            this.LabExaminationLabWorkerSubmitButton.Click += new System.EventHandler(this.LabExaminationLabWorkerSubmitButton_Click);
            // 
            // LabExaminationLabWorkerCancelButton
            // 
            this.LabExaminationLabWorkerCancelButton.Location = new System.Drawing.Point(508, 156);
            this.LabExaminationLabWorkerCancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationLabWorkerCancelButton.Name = "LabExaminationLabWorkerCancelButton";
            this.LabExaminationLabWorkerCancelButton.Size = new System.Drawing.Size(153, 28);
            this.LabExaminationLabWorkerCancelButton.TabIndex = 5;
            this.LabExaminationLabWorkerCancelButton.Text = "Cancel  Examination";
            this.LabExaminationLabWorkerCancelButton.UseVisualStyleBackColor = true;
            this.LabExaminationLabWorkerCancelButton.Click += new System.EventHandler(this.LabExaminationLabWorkerCancelButton_Click);
            // 
            // LabExaminationExamResultTextBox
            // 
            this.LabExaminationExamResultTextBox.Location = new System.Drawing.Point(171, 68);
            this.LabExaminationExamResultTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationExamResultTextBox.Multiline = true;
            this.LabExaminationExamResultTextBox.Name = "LabExaminationExamResultTextBox";
            this.LabExaminationExamResultTextBox.ReadOnly = true;
            this.LabExaminationExamResultTextBox.Size = new System.Drawing.Size(576, 80);
            this.LabExaminationExamResultTextBox.TabIndex = 4;
            // 
            // LabExaminationExamResultLabel
            // 
            this.LabExaminationExamResultLabel.AutoSize = true;
            this.LabExaminationExamResultLabel.Location = new System.Drawing.Point(15, 71);
            this.LabExaminationExamResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabExaminationExamResultLabel.Name = "LabExaminationExamResultLabel";
            this.LabExaminationExamResultLabel.Size = new System.Drawing.Size(131, 17);
            this.LabExaminationExamResultLabel.TabIndex = 3;
            this.LabExaminationExamResultLabel.Text = "Examination result :";
            // 
            // LabExaminationLabWorkerLastNameTextBox
            // 
            this.LabExaminationLabWorkerLastNameTextBox.Location = new System.Drawing.Point(276, 4);
            this.LabExaminationLabWorkerLastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationLabWorkerLastNameTextBox.Name = "LabExaminationLabWorkerLastNameTextBox";
            this.LabExaminationLabWorkerLastNameTextBox.ReadOnly = true;
            this.LabExaminationLabWorkerLastNameTextBox.Size = new System.Drawing.Size(223, 22);
            this.LabExaminationLabWorkerLastNameTextBox.TabIndex = 2;
            this.LabExaminationLabWorkerLastNameTextBox.Text = "Worker last name";
            // 
            // LabExaminationLabWorkerFirstNameTextBox
            // 
            this.LabExaminationLabWorkerFirstNameTextBox.Location = new System.Drawing.Point(135, 4);
            this.LabExaminationLabWorkerFirstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationLabWorkerFirstNameTextBox.Name = "LabExaminationLabWorkerFirstNameTextBox";
            this.LabExaminationLabWorkerFirstNameTextBox.ReadOnly = true;
            this.LabExaminationLabWorkerFirstNameTextBox.Size = new System.Drawing.Size(132, 22);
            this.LabExaminationLabWorkerFirstNameTextBox.TabIndex = 1;
            this.LabExaminationLabWorkerFirstNameTextBox.Text = "Worker first name";
            // 
            // LabExaminationLabWorkerNameLabel
            // 
            this.LabExaminationLabWorkerNameLabel.AutoSize = true;
            this.LabExaminationLabWorkerNameLabel.Location = new System.Drawing.Point(15, 7);
            this.LabExaminationLabWorkerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabExaminationLabWorkerNameLabel.Name = "LabExaminationLabWorkerNameLabel";
            this.LabExaminationLabWorkerNameLabel.Size = new System.Drawing.Size(86, 17);
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
            this.LabExaminationLabManagerPanel.Location = new System.Drawing.Point(17, 486);
            this.LabExaminationLabManagerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationLabManagerPanel.Name = "LabExaminationLabManagerPanel";
            this.LabExaminationLabManagerPanel.Size = new System.Drawing.Size(868, 192);
            this.LabExaminationLabManagerPanel.TabIndex = 6;
            // 
            // LabExaminationLabManagerCancelButton
            // 
            this.LabExaminationLabManagerCancelButton.Location = new System.Drawing.Point(507, 151);
            this.LabExaminationLabManagerCancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationLabManagerCancelButton.Name = "LabExaminationLabManagerCancelButton";
            this.LabExaminationLabManagerCancelButton.Size = new System.Drawing.Size(153, 28);
            this.LabExaminationLabManagerCancelButton.TabIndex = 8;
            this.LabExaminationLabManagerCancelButton.Text = "Cancel  Examination";
            this.LabExaminationLabManagerCancelButton.UseVisualStyleBackColor = true;
            this.LabExaminationLabManagerCancelButton.Click += new System.EventHandler(this.LabExaminationLabManagerCancelButton_Click);
            // 
            // LabExaminationLabManagerApproveButton
            // 
            this.LabExaminationLabManagerApproveButton.Location = new System.Drawing.Point(265, 151);
            this.LabExaminationLabManagerApproveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationLabManagerApproveButton.Name = "LabExaminationLabManagerApproveButton";
            this.LabExaminationLabManagerApproveButton.Size = new System.Drawing.Size(172, 28);
            this.LabExaminationLabManagerApproveButton.TabIndex = 7;
            this.LabExaminationLabManagerApproveButton.Text = "Approve Examination";
            this.LabExaminationLabManagerApproveButton.UseVisualStyleBackColor = true;
            this.LabExaminationLabManagerApproveButton.Click += new System.EventHandler(this.LabExaminationLabManagerApproveButton_Click);
            // 
            // LabExaminationLabManagerCommentsTextBox
            // 
            this.LabExaminationLabManagerCommentsTextBox.Location = new System.Drawing.Point(169, 68);
            this.LabExaminationLabManagerCommentsTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationLabManagerCommentsTextBox.Multiline = true;
            this.LabExaminationLabManagerCommentsTextBox.Name = "LabExaminationLabManagerCommentsTextBox";
            this.LabExaminationLabManagerCommentsTextBox.ReadOnly = true;
            this.LabExaminationLabManagerCommentsTextBox.Size = new System.Drawing.Size(576, 80);
            this.LabExaminationLabManagerCommentsTextBox.TabIndex = 4;
            // 
            // LabExaminationLabManagerCommentsLabel
            // 
            this.LabExaminationLabManagerCommentsLabel.AutoSize = true;
            this.LabExaminationLabManagerCommentsLabel.Location = new System.Drawing.Point(13, 73);
            this.LabExaminationLabManagerCommentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabExaminationLabManagerCommentsLabel.Name = "LabExaminationLabManagerCommentsLabel";
            this.LabExaminationLabManagerCommentsLabel.Size = new System.Drawing.Size(140, 17);
            this.LabExaminationLabManagerCommentsLabel.TabIndex = 3;
            this.LabExaminationLabManagerCommentsLabel.Text = "Manager comments :";
            // 
            // LabExaminationLabManagerLastNameTextBox
            // 
            this.LabExaminationLabManagerLastNameTextBox.Location = new System.Drawing.Point(275, 4);
            this.LabExaminationLabManagerLastNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationLabManagerLastNameTextBox.Name = "LabExaminationLabManagerLastNameTextBox";
            this.LabExaminationLabManagerLastNameTextBox.ReadOnly = true;
            this.LabExaminationLabManagerLastNameTextBox.Size = new System.Drawing.Size(223, 22);
            this.LabExaminationLabManagerLastNameTextBox.TabIndex = 2;
            this.LabExaminationLabManagerLastNameTextBox.Text = "Manager last name";
            // 
            // LabExaminationLabManagerFirstNameTextBox
            // 
            this.LabExaminationLabManagerFirstNameTextBox.Location = new System.Drawing.Point(133, 4);
            this.LabExaminationLabManagerFirstNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabExaminationLabManagerFirstNameTextBox.Name = "LabExaminationLabManagerFirstNameTextBox";
            this.LabExaminationLabManagerFirstNameTextBox.ReadOnly = true;
            this.LabExaminationLabManagerFirstNameTextBox.Size = new System.Drawing.Size(132, 22);
            this.LabExaminationLabManagerFirstNameTextBox.TabIndex = 1;
            this.LabExaminationLabManagerFirstNameTextBox.Text = "Manager first name";
            // 
            // LabExaminationLabManagerNameLabel
            // 
            this.LabExaminationLabManagerNameLabel.AutoSize = true;
            this.LabExaminationLabManagerNameLabel.Location = new System.Drawing.Point(13, 7);
            this.LabExaminationLabManagerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabExaminationLabManagerNameLabel.Name = "LabExaminationLabManagerNameLabel";
            this.LabExaminationLabManagerNameLabel.Size = new System.Drawing.Size(100, 17);
            this.LabExaminationLabManagerNameLabel.TabIndex = 0;
            this.LabExaminationLabManagerNameLabel.Text = "Lab manager :";
            // 
            // LabolatoryExaminationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 695);
            this.Controls.Add(this.LabExaminationLabManagerPanel);
            this.Controls.Add(this.LabExaminationLabWorkerPanel);
            this.Controls.Add(this.LabExaminationDoctorPanel);
            this.Controls.Add(this.labExaminationInfoPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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