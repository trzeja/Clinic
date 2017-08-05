﻿namespace Clinic
{
    partial class DoctorVisitViewForm
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
            this.doctorCancelVisitButton = new System.Windows.Forms.Button();
            this.doctorFinishVisitButton = new System.Windows.Forms.Button();
            this.doctorLaboratoryExaminationButton = new System.Windows.Forms.Button();
            this.doctorVisitViewVisitPanel = new System.Windows.Forms.Panel();
            this.doctorPhysicalExaminationButton = new System.Windows.Forms.Button();
            this.doctorVisitDescriptionLabel = new System.Windows.Forms.Label();
            this.doctorVisitDiagnosisLabel = new System.Windows.Forms.Label();
            this.doctorVisitPeselLabel = new System.Windows.Forms.Label();
            this.doctorVisitPatientNameLabel = new System.Windows.Forms.Label();
            this.doctorVisitPatientDiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.doctorVisitPatientDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.doctorVisitPatientPeselTextBox = new System.Windows.Forms.TextBox();
            this.doctorVisitPatientLastNameTextBox = new System.Windows.Forms.TextBox();
            this.doctorVisitPatientFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.doctorVisitViewExaminationListPanel = new System.Windows.Forms.Panel();
            this.doctorVisitViewLoadExamHistButton = new System.Windows.Forms.Button();
            this.doctorVisitViewExaminationListLabel = new System.Windows.Forms.Label();
            this.doctorVisitViewExamHistDetailsButton = new System.Windows.Forms.Button();
            this.doctorVisitViewExaminationListDataGrid = new System.Windows.Forms.DataGridView();
            this.doctorVisitViewVisitListPanel = new System.Windows.Forms.Panel();
            this.doctorVisitViewLoadVisitHistButton = new System.Windows.Forms.Button();
            this.doctorVisitViewVisitListLabel = new System.Windows.Forms.Label();
            this.doctorVisitViewVisitHistDetailsButton = new System.Windows.Forms.Button();
            this.doctorVisitViewVisitListDataGrid = new System.Windows.Forms.DataGridView();
            this.doctorVisitViewPatientInfoPanel = new System.Windows.Forms.Panel();
            this.doctorVisitViewVisitPanel.SuspendLayout();
            this.doctorVisitViewExaminationListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorVisitViewExaminationListDataGrid)).BeginInit();
            this.doctorVisitViewVisitListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorVisitViewVisitListDataGrid)).BeginInit();
            this.doctorVisitViewPatientInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctorCancelVisitButton
            // 
            this.doctorCancelVisitButton.Location = new System.Drawing.Point(431, 567);
            this.doctorCancelVisitButton.Name = "doctorCancelVisitButton";
            this.doctorCancelVisitButton.Size = new System.Drawing.Size(110, 23);
            this.doctorCancelVisitButton.TabIndex = 0;
            this.doctorCancelVisitButton.Text = "Cancel visit";
            this.doctorCancelVisitButton.UseVisualStyleBackColor = true;
            this.doctorCancelVisitButton.Click += new System.EventHandler(this.doctorCancelVisitButton_Click);
            // 
            // doctorFinishVisitButton
            // 
            this.doctorFinishVisitButton.Location = new System.Drawing.Point(188, 567);
            this.doctorFinishVisitButton.Name = "doctorFinishVisitButton";
            this.doctorFinishVisitButton.Size = new System.Drawing.Size(110, 23);
            this.doctorFinishVisitButton.TabIndex = 1;
            this.doctorFinishVisitButton.Text = "Finish visit";
            this.doctorFinishVisitButton.UseVisualStyleBackColor = true;
            this.doctorFinishVisitButton.Click += new System.EventHandler(this.doctorFinishVisitButton_Click);
            // 
            // doctorLaboratoryExaminationButton
            // 
            this.doctorLaboratoryExaminationButton.Location = new System.Drawing.Point(407, 185);
            this.doctorLaboratoryExaminationButton.Name = "doctorLaboratoryExaminationButton";
            this.doctorLaboratoryExaminationButton.Size = new System.Drawing.Size(158, 23);
            this.doctorLaboratoryExaminationButton.TabIndex = 2;
            this.doctorLaboratoryExaminationButton.Text = "Laboratory Examination";
            this.doctorLaboratoryExaminationButton.UseVisualStyleBackColor = true;
            this.doctorLaboratoryExaminationButton.Click += new System.EventHandler(this.doctorOrderLaboratoryExaminationButton_Click);
            // 
            // doctorVisitViewVisitPanel
            // 
            this.doctorVisitViewVisitPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.doctorVisitViewVisitPanel.Controls.Add(this.doctorPhysicalExaminationButton);
            this.doctorVisitViewVisitPanel.Controls.Add(this.doctorVisitDescriptionLabel);
            this.doctorVisitViewVisitPanel.Controls.Add(this.doctorVisitDiagnosisLabel);
            this.doctorVisitViewVisitPanel.Controls.Add(this.doctorVisitPatientDiagnosisTextBox);
            this.doctorVisitViewVisitPanel.Controls.Add(this.doctorVisitPatientDescriptionTextBox);
            this.doctorVisitViewVisitPanel.Controls.Add(this.doctorLaboratoryExaminationButton);
            this.doctorVisitViewVisitPanel.Location = new System.Drawing.Point(12, 51);
            this.doctorVisitViewVisitPanel.Name = "doctorVisitViewVisitPanel";
            this.doctorVisitViewVisitPanel.Size = new System.Drawing.Size(686, 215);
            this.doctorVisitViewVisitPanel.TabIndex = 3;
            // 
            // doctorPhysicalExaminationButton
            // 
            this.doctorPhysicalExaminationButton.Location = new System.Drawing.Point(164, 185);
            this.doctorPhysicalExaminationButton.Name = "doctorPhysicalExaminationButton";
            this.doctorPhysicalExaminationButton.Size = new System.Drawing.Size(158, 23);
            this.doctorPhysicalExaminationButton.TabIndex = 14;
            this.doctorPhysicalExaminationButton.Text = "Physical Examination";
            this.doctorPhysicalExaminationButton.UseVisualStyleBackColor = true;
            this.doctorPhysicalExaminationButton.Click += new System.EventHandler(this.doctorPhysicalExaminationButton_Click);
            // 
            // doctorVisitDescriptionLabel
            // 
            this.doctorVisitDescriptionLabel.AutoSize = true;
            this.doctorVisitDescriptionLabel.Location = new System.Drawing.Point(18, 4);
            this.doctorVisitDescriptionLabel.Name = "doctorVisitDescriptionLabel";
            this.doctorVisitDescriptionLabel.Size = new System.Drawing.Size(66, 13);
            this.doctorVisitDescriptionLabel.TabIndex = 13;
            this.doctorVisitDescriptionLabel.Text = "Description :";
            // 
            // doctorVisitDiagnosisLabel
            // 
            this.doctorVisitDiagnosisLabel.AutoSize = true;
            this.doctorVisitDiagnosisLabel.Location = new System.Drawing.Point(18, 93);
            this.doctorVisitDiagnosisLabel.Name = "doctorVisitDiagnosisLabel";
            this.doctorVisitDiagnosisLabel.Size = new System.Drawing.Size(59, 13);
            this.doctorVisitDiagnosisLabel.TabIndex = 12;
            this.doctorVisitDiagnosisLabel.Text = "Diagnosis :";
            // 
            // doctorVisitPeselLabel
            // 
            this.doctorVisitPeselLabel.AutoSize = true;
            this.doctorVisitPeselLabel.Location = new System.Drawing.Point(387, 15);
            this.doctorVisitPeselLabel.Name = "doctorVisitPeselLabel";
            this.doctorVisitPeselLabel.Size = new System.Drawing.Size(83, 13);
            this.doctorVisitPeselLabel.TabIndex = 11;
            this.doctorVisitPeselLabel.Text = "Patient PESEL :";
            // 
            // doctorVisitPatientNameLabel
            // 
            this.doctorVisitPatientNameLabel.AutoSize = true;
            this.doctorVisitPatientNameLabel.Location = new System.Drawing.Point(19, 15);
            this.doctorVisitPatientNameLabel.Name = "doctorVisitPatientNameLabel";
            this.doctorVisitPatientNameLabel.Size = new System.Drawing.Size(75, 13);
            this.doctorVisitPatientNameLabel.TabIndex = 10;
            this.doctorVisitPatientNameLabel.Text = "Patient name :";
            // 
            // doctorVisitPatientDiagnosisTextBox
            // 
            this.doctorVisitPatientDiagnosisTextBox.Location = new System.Drawing.Point(21, 109);
            this.doctorVisitPatientDiagnosisTextBox.Multiline = true;
            this.doctorVisitPatientDiagnosisTextBox.Name = "doctorVisitPatientDiagnosisTextBox";
            this.doctorVisitPatientDiagnosisTextBox.Size = new System.Drawing.Size(645, 70);
            this.doctorVisitPatientDiagnosisTextBox.TabIndex = 9;
            this.doctorVisitPatientDiagnosisTextBox.Text = "Diagnosis";
            this.doctorVisitPatientDiagnosisTextBox.Enter += new System.EventHandler(this.doctorVisitPatientDiagnosisTextBox_Enter);
            this.doctorVisitPatientDiagnosisTextBox.Leave += new System.EventHandler(this.doctorVisitPatientDiagnosisTextBox_Leave);
            // 
            // doctorVisitPatientDescriptionTextBox
            // 
            this.doctorVisitPatientDescriptionTextBox.Location = new System.Drawing.Point(21, 20);
            this.doctorVisitPatientDescriptionTextBox.Multiline = true;
            this.doctorVisitPatientDescriptionTextBox.Name = "doctorVisitPatientDescriptionTextBox";
            this.doctorVisitPatientDescriptionTextBox.Size = new System.Drawing.Size(645, 70);
            this.doctorVisitPatientDescriptionTextBox.TabIndex = 8;
            this.doctorVisitPatientDescriptionTextBox.Text = "Description";
            this.doctorVisitPatientDescriptionTextBox.Enter += new System.EventHandler(this.doctorVisitPatientDescriptionTextBox_Enter);
            this.doctorVisitPatientDescriptionTextBox.Leave += new System.EventHandler(this.doctorVisitPatientDescriptionTextBox_Leave);
            // 
            // doctorVisitPatientPeselTextBox
            // 
            this.doctorVisitPatientPeselTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.doctorVisitPatientPeselTextBox.Location = new System.Drawing.Point(476, 12);
            this.doctorVisitPatientPeselTextBox.Name = "doctorVisitPatientPeselTextBox";
            this.doctorVisitPatientPeselTextBox.ReadOnly = true;
            this.doctorVisitPatientPeselTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctorVisitPatientPeselTextBox.TabIndex = 5;
            this.doctorVisitPatientPeselTextBox.Text = "PESEL";
            // 
            // doctorVisitPatientLastNameTextBox
            // 
            this.doctorVisitPatientLastNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.doctorVisitPatientLastNameTextBox.Location = new System.Drawing.Point(206, 13);
            this.doctorVisitPatientLastNameTextBox.Name = "doctorVisitPatientLastNameTextBox";
            this.doctorVisitPatientLastNameTextBox.ReadOnly = true;
            this.doctorVisitPatientLastNameTextBox.Size = new System.Drawing.Size(175, 20);
            this.doctorVisitPatientLastNameTextBox.TabIndex = 4;
            this.doctorVisitPatientLastNameTextBox.Text = "patient last name";
            // 
            // doctorVisitPatientFirstNameTextBox
            // 
            this.doctorVisitPatientFirstNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.doctorVisitPatientFirstNameTextBox.Location = new System.Drawing.Point(100, 12);
            this.doctorVisitPatientFirstNameTextBox.Name = "doctorVisitPatientFirstNameTextBox";
            this.doctorVisitPatientFirstNameTextBox.ReadOnly = true;
            this.doctorVisitPatientFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctorVisitPatientFirstNameTextBox.TabIndex = 3;
            this.doctorVisitPatientFirstNameTextBox.Text = "patient first name";
            // 
            // doctorVisitViewExaminationListPanel
            // 
            this.doctorVisitViewExaminationListPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.doctorVisitViewExaminationListPanel.Controls.Add(this.doctorVisitViewLoadExamHistButton);
            this.doctorVisitViewExaminationListPanel.Controls.Add(this.doctorVisitViewExaminationListLabel);
            this.doctorVisitViewExaminationListPanel.Controls.Add(this.doctorVisitViewExamHistDetailsButton);
            this.doctorVisitViewExaminationListPanel.Controls.Add(this.doctorVisitViewExaminationListDataGrid);
            this.doctorVisitViewExaminationListPanel.Location = new System.Drawing.Point(12, 272);
            this.doctorVisitViewExaminationListPanel.Name = "doctorVisitViewExaminationListPanel";
            this.doctorVisitViewExaminationListPanel.Size = new System.Drawing.Size(686, 142);
            this.doctorVisitViewExaminationListPanel.TabIndex = 4;
            // 
            // doctorVisitViewLoadExamHistButton
            // 
            this.doctorVisitViewLoadExamHistButton.Location = new System.Drawing.Point(510, 4);
            this.doctorVisitViewLoadExamHistButton.Name = "doctorVisitViewLoadExamHistButton";
            this.doctorVisitViewLoadExamHistButton.Size = new System.Drawing.Size(75, 23);
            this.doctorVisitViewLoadExamHistButton.TabIndex = 3;
            this.doctorVisitViewLoadExamHistButton.Text = "Load history";
            this.doctorVisitViewLoadExamHistButton.UseVisualStyleBackColor = true;
            // 
            // doctorVisitViewExaminationListLabel
            // 
            this.doctorVisitViewExaminationListLabel.AutoSize = true;
            this.doctorVisitViewExaminationListLabel.Location = new System.Drawing.Point(18, 9);
            this.doctorVisitViewExaminationListLabel.Name = "doctorVisitViewExaminationListLabel";
            this.doctorVisitViewExaminationListLabel.Size = new System.Drawing.Size(103, 13);
            this.doctorVisitViewExaminationListLabel.TabIndex = 2;
            this.doctorVisitViewExaminationListLabel.Text = "Examination history :";
            // 
            // doctorVisitViewExamHistDetailsButton
            // 
            this.doctorVisitViewExamHistDetailsButton.Location = new System.Drawing.Point(591, 4);
            this.doctorVisitViewExamHistDetailsButton.Name = "doctorVisitViewExamHistDetailsButton";
            this.doctorVisitViewExamHistDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.doctorVisitViewExamHistDetailsButton.TabIndex = 1;
            this.doctorVisitViewExamHistDetailsButton.Text = "View details";
            this.doctorVisitViewExamHistDetailsButton.UseVisualStyleBackColor = true;
            this.doctorVisitViewExamHistDetailsButton.Click += new System.EventHandler(this.doctorVisitViewExamHistDetailsButton_Click);
            // 
            // doctorVisitViewExaminationListDataGrid
            // 
            this.doctorVisitViewExaminationListDataGrid.AllowUserToAddRows = false;
            this.doctorVisitViewExaminationListDataGrid.AllowUserToDeleteRows = false;
            this.doctorVisitViewExaminationListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorVisitViewExaminationListDataGrid.Location = new System.Drawing.Point(7, 33);
            this.doctorVisitViewExaminationListDataGrid.Name = "doctorVisitViewExaminationListDataGrid";
            this.doctorVisitViewExaminationListDataGrid.ReadOnly = true;
            this.doctorVisitViewExaminationListDataGrid.Size = new System.Drawing.Size(672, 106);
            this.doctorVisitViewExaminationListDataGrid.TabIndex = 0;
            // 
            // doctorVisitViewVisitListPanel
            // 
            this.doctorVisitViewVisitListPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.doctorVisitViewVisitListPanel.Controls.Add(this.doctorVisitViewLoadVisitHistButton);
            this.doctorVisitViewVisitListPanel.Controls.Add(this.doctorVisitViewVisitListLabel);
            this.doctorVisitViewVisitListPanel.Controls.Add(this.doctorVisitViewVisitHistDetailsButton);
            this.doctorVisitViewVisitListPanel.Controls.Add(this.doctorVisitViewVisitListDataGrid);
            this.doctorVisitViewVisitListPanel.Location = new System.Drawing.Point(12, 420);
            this.doctorVisitViewVisitListPanel.Name = "doctorVisitViewVisitListPanel";
            this.doctorVisitViewVisitListPanel.Size = new System.Drawing.Size(686, 141);
            this.doctorVisitViewVisitListPanel.TabIndex = 5;
            // 
            // doctorVisitViewLoadVisitHistButton
            // 
            this.doctorVisitViewLoadVisitHistButton.Location = new System.Drawing.Point(510, 4);
            this.doctorVisitViewLoadVisitHistButton.Name = "doctorVisitViewLoadVisitHistButton";
            this.doctorVisitViewLoadVisitHistButton.Size = new System.Drawing.Size(75, 23);
            this.doctorVisitViewLoadVisitHistButton.TabIndex = 3;
            this.doctorVisitViewLoadVisitHistButton.Text = "Load history";
            this.doctorVisitViewLoadVisitHistButton.UseVisualStyleBackColor = true;
            // 
            // doctorVisitViewVisitListLabel
            // 
            this.doctorVisitViewVisitListLabel.AutoSize = true;
            this.doctorVisitViewVisitListLabel.Location = new System.Drawing.Point(19, 9);
            this.doctorVisitViewVisitListLabel.Name = "doctorVisitViewVisitListLabel";
            this.doctorVisitViewVisitListLabel.Size = new System.Drawing.Size(65, 13);
            this.doctorVisitViewVisitListLabel.TabIndex = 2;
            this.doctorVisitViewVisitListLabel.Text = "Visit history :";
            // 
            // doctorVisitViewVisitHistDetailsButton
            // 
            this.doctorVisitViewVisitHistDetailsButton.Location = new System.Drawing.Point(591, 4);
            this.doctorVisitViewVisitHistDetailsButton.Name = "doctorVisitViewVisitHistDetailsButton";
            this.doctorVisitViewVisitHistDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.doctorVisitViewVisitHistDetailsButton.TabIndex = 1;
            this.doctorVisitViewVisitHistDetailsButton.Text = "View details";
            this.doctorVisitViewVisitHistDetailsButton.UseVisualStyleBackColor = true;
            this.doctorVisitViewVisitHistDetailsButton.Click += new System.EventHandler(this.doctorVisitViewVisitHistDetailsButton_Click);
            // 
            // doctorVisitViewVisitListDataGrid
            // 
            this.doctorVisitViewVisitListDataGrid.AllowUserToAddRows = false;
            this.doctorVisitViewVisitListDataGrid.AllowUserToDeleteRows = false;
            this.doctorVisitViewVisitListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorVisitViewVisitListDataGrid.Location = new System.Drawing.Point(7, 33);
            this.doctorVisitViewVisitListDataGrid.Name = "doctorVisitViewVisitListDataGrid";
            this.doctorVisitViewVisitListDataGrid.ReadOnly = true;
            this.doctorVisitViewVisitListDataGrid.Size = new System.Drawing.Size(672, 105);
            this.doctorVisitViewVisitListDataGrid.TabIndex = 0;
            // 
            // doctorVisitViewPatientInfoPanel
            // 
            this.doctorVisitViewPatientInfoPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.doctorVisitViewPatientInfoPanel.Controls.Add(this.doctorVisitPatientLastNameTextBox);
            this.doctorVisitViewPatientInfoPanel.Controls.Add(this.doctorVisitPatientFirstNameTextBox);
            this.doctorVisitViewPatientInfoPanel.Controls.Add(this.doctorVisitPatientPeselTextBox);
            this.doctorVisitViewPatientInfoPanel.Controls.Add(this.doctorVisitPeselLabel);
            this.doctorVisitViewPatientInfoPanel.Controls.Add(this.doctorVisitPatientNameLabel);
            this.doctorVisitViewPatientInfoPanel.Location = new System.Drawing.Point(12, 3);
            this.doctorVisitViewPatientInfoPanel.Name = "doctorVisitViewPatientInfoPanel";
            this.doctorVisitViewPatientInfoPanel.Size = new System.Drawing.Size(686, 42);
            this.doctorVisitViewPatientInfoPanel.TabIndex = 6;
            // 
            // DoctorVisitViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 596);
            this.Controls.Add(this.doctorVisitViewPatientInfoPanel);
            this.Controls.Add(this.doctorVisitViewVisitListPanel);
            this.Controls.Add(this.doctorVisitViewExaminationListPanel);
            this.Controls.Add(this.doctorVisitViewVisitPanel);
            this.Controls.Add(this.doctorFinishVisitButton);
            this.Controls.Add(this.doctorCancelVisitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DoctorVisitViewForm";
            this.Text = "DoctorVisitView";
            this.doctorVisitViewVisitPanel.ResumeLayout(false);
            this.doctorVisitViewVisitPanel.PerformLayout();
            this.doctorVisitViewExaminationListPanel.ResumeLayout(false);
            this.doctorVisitViewExaminationListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorVisitViewExaminationListDataGrid)).EndInit();
            this.doctorVisitViewVisitListPanel.ResumeLayout(false);
            this.doctorVisitViewVisitListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorVisitViewVisitListDataGrid)).EndInit();
            this.doctorVisitViewPatientInfoPanel.ResumeLayout(false);
            this.doctorVisitViewPatientInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button doctorCancelVisitButton;
        private System.Windows.Forms.Button doctorFinishVisitButton;
        private System.Windows.Forms.Button doctorLaboratoryExaminationButton;
        private System.Windows.Forms.Panel doctorVisitViewVisitPanel;
        private System.Windows.Forms.TextBox doctorVisitPatientLastNameTextBox;
        private System.Windows.Forms.TextBox doctorVisitPatientFirstNameTextBox;
        private System.Windows.Forms.TextBox doctorVisitPatientPeselTextBox;
        private System.Windows.Forms.Panel doctorVisitViewExaminationListPanel;
        private System.Windows.Forms.DataGridView doctorVisitViewExaminationListDataGrid;
        private System.Windows.Forms.Panel doctorVisitViewVisitListPanel;
        private System.Windows.Forms.Button doctorVisitViewExamHistDetailsButton;
        private System.Windows.Forms.Button doctorVisitViewVisitHistDetailsButton;
        private System.Windows.Forms.DataGridView doctorVisitViewVisitListDataGrid;
        private System.Windows.Forms.Label doctorVisitViewExaminationListLabel;
        private System.Windows.Forms.Label doctorVisitViewVisitListLabel;
        private System.Windows.Forms.TextBox doctorVisitPatientDescriptionTextBox;
        private System.Windows.Forms.TextBox doctorVisitPatientDiagnosisTextBox;
        private System.Windows.Forms.Label doctorVisitDescriptionLabel;
        private System.Windows.Forms.Label doctorVisitDiagnosisLabel;
        private System.Windows.Forms.Label doctorVisitPeselLabel;
        private System.Windows.Forms.Label doctorVisitPatientNameLabel;
        private System.Windows.Forms.Button doctorPhysicalExaminationButton;
        private System.Windows.Forms.Button doctorVisitViewLoadExamHistButton;
        private System.Windows.Forms.Button doctorVisitViewLoadVisitHistButton;
        private System.Windows.Forms.Panel doctorVisitViewPatientInfoPanel;
    }
}