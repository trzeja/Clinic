namespace Clinic
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
            this.doctorOrderLaboratoryExaminationButton = new System.Windows.Forms.Button();
            this.doctorVisitPanel = new System.Windows.Forms.Panel();
            this.doctorVisitPatientDiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.doctorPhysicalExaminationButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.doctorVisitPatientPeselTextBox = new System.Windows.Forms.TextBox();
            this.doctorVisitPatientLastNameTextBox = new System.Windows.Forms.TextBox();
            this.doctorVisitPatientFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.doctorVisitViewExaminationListPanel = new System.Windows.Forms.Panel();
            this.doctorVisitViewExaminationListLabel = new System.Windows.Forms.Label();
            this.doctorVisitViewExaminationListButton = new System.Windows.Forms.Button();
            this.doctorVisitViewExaminationListDataGrid = new System.Windows.Forms.DataGridView();
            this.doctorVisitViewVisitListPanel = new System.Windows.Forms.Panel();
            this.doctorVisitViewVisitListLabel = new System.Windows.Forms.Label();
            this.doctorVisitViewVisitListButton = new System.Windows.Forms.Button();
            this.doctorVisitViewVisitListDataGrid = new System.Windows.Forms.DataGridView();
            this.doctorVisitPanel.SuspendLayout();
            this.doctorVisitViewExaminationListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorVisitViewExaminationListDataGrid)).BeginInit();
            this.doctorVisitViewVisitListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorVisitViewVisitListDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorCancelVisitButton
            // 
            this.doctorCancelVisitButton.Location = new System.Drawing.Point(591, 38);
            this.doctorCancelVisitButton.Name = "doctorCancelVisitButton";
            this.doctorCancelVisitButton.Size = new System.Drawing.Size(75, 23);
            this.doctorCancelVisitButton.TabIndex = 0;
            this.doctorCancelVisitButton.Text = "Cancel visit";
            this.doctorCancelVisitButton.UseVisualStyleBackColor = true;
            // 
            // doctorFinishVisitButton
            // 
            this.doctorFinishVisitButton.Location = new System.Drawing.Point(591, 9);
            this.doctorFinishVisitButton.Name = "doctorFinishVisitButton";
            this.doctorFinishVisitButton.Size = new System.Drawing.Size(75, 23);
            this.doctorFinishVisitButton.TabIndex = 1;
            this.doctorFinishVisitButton.Text = "Finish visit";
            this.doctorFinishVisitButton.UseVisualStyleBackColor = true;
            this.doctorFinishVisitButton.Click += new System.EventHandler(this.doctorFinishVisitButton_Click);
            // 
            // doctorOrderLaboratoryExaminationButton
            // 
            this.doctorOrderLaboratoryExaminationButton.Location = new System.Drawing.Point(363, 8);
            this.doctorOrderLaboratoryExaminationButton.Name = "doctorOrderLaboratoryExaminationButton";
            this.doctorOrderLaboratoryExaminationButton.Size = new System.Drawing.Size(175, 24);
            this.doctorOrderLaboratoryExaminationButton.TabIndex = 2;
            this.doctorOrderLaboratoryExaminationButton.Text = "Order Laboratory Examination";
            this.doctorOrderLaboratoryExaminationButton.UseVisualStyleBackColor = true;
            // 
            // doctorVisitPanel
            // 
            this.doctorVisitPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.doctorVisitPanel.Controls.Add(this.doctorVisitPatientDiagnosisTextBox);
            this.doctorVisitPanel.Controls.Add(this.doctorPhysicalExaminationButton);
            this.doctorVisitPanel.Controls.Add(this.textBox1);
            this.doctorVisitPanel.Controls.Add(this.doctorCancelVisitButton);
            this.doctorVisitPanel.Controls.Add(this.doctorVisitPatientPeselTextBox);
            this.doctorVisitPanel.Controls.Add(this.doctorVisitPatientLastNameTextBox);
            this.doctorVisitPanel.Controls.Add(this.doctorVisitPatientFirstNameTextBox);
            this.doctorVisitPanel.Controls.Add(this.doctorFinishVisitButton);
            this.doctorVisitPanel.Controls.Add(this.doctorOrderLaboratoryExaminationButton);
            this.doctorVisitPanel.Location = new System.Drawing.Point(12, 12);
            this.doctorVisitPanel.Name = "doctorVisitPanel";
            this.doctorVisitPanel.Size = new System.Drawing.Size(686, 171);
            this.doctorVisitPanel.TabIndex = 3;
            // 
            // doctorVisitPatientDiagnosisTextBox
            // 
            this.doctorVisitPatientDiagnosisTextBox.Location = new System.Drawing.Point(21, 62);
            this.doctorVisitPatientDiagnosisTextBox.Multiline = true;
            this.doctorVisitPatientDiagnosisTextBox.Name = "doctorVisitPatientDiagnosisTextBox";
            this.doctorVisitPatientDiagnosisTextBox.Size = new System.Drawing.Size(312, 72);
            this.doctorVisitPatientDiagnosisTextBox.TabIndex = 8;
            this.doctorVisitPatientDiagnosisTextBox.Text = "Diagnosis";
            // 
            // doctorPhysicalExaminationButton
            // 
            this.doctorPhysicalExaminationButton.Location = new System.Drawing.Point(363, 37);
            this.doctorPhysicalExaminationButton.Name = "doctorPhysicalExaminationButton";
            this.doctorPhysicalExaminationButton.Size = new System.Drawing.Size(175, 23);
            this.doctorPhysicalExaminationButton.TabIndex = 7;
            this.doctorPhysicalExaminationButton.Text = "Physical Examination";
            this.doctorPhysicalExaminationButton.UseVisualStyleBackColor = true;
            this.doctorPhysicalExaminationButton.Click += new System.EventHandler(this.doctorPhysicalExaminationButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(21, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "id_visit";
            // 
            // doctorVisitPatientPeselTextBox
            // 
            this.doctorVisitPatientPeselTextBox.Enabled = false;
            this.doctorVisitPatientPeselTextBox.Location = new System.Drawing.Point(233, 36);
            this.doctorVisitPatientPeselTextBox.Name = "doctorVisitPatientPeselTextBox";
            this.doctorVisitPatientPeselTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctorVisitPatientPeselTextBox.TabIndex = 5;
            this.doctorVisitPatientPeselTextBox.Text = "PESEL";
            // 
            // doctorVisitPatientLastNameTextBox
            // 
            this.doctorVisitPatientLastNameTextBox.Enabled = false;
            this.doctorVisitPatientLastNameTextBox.Location = new System.Drawing.Point(127, 36);
            this.doctorVisitPatientLastNameTextBox.Name = "doctorVisitPatientLastNameTextBox";
            this.doctorVisitPatientLastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctorVisitPatientLastNameTextBox.TabIndex = 4;
            this.doctorVisitPatientLastNameTextBox.Text = "patient last name";
            // 
            // doctorVisitPatientFirstNameTextBox
            // 
            this.doctorVisitPatientFirstNameTextBox.Enabled = false;
            this.doctorVisitPatientFirstNameTextBox.Location = new System.Drawing.Point(21, 35);
            this.doctorVisitPatientFirstNameTextBox.Name = "doctorVisitPatientFirstNameTextBox";
            this.doctorVisitPatientFirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctorVisitPatientFirstNameTextBox.TabIndex = 3;
            this.doctorVisitPatientFirstNameTextBox.Text = "patient first name";
            // 
            // doctorVisitViewExaminationListPanel
            // 
            this.doctorVisitViewExaminationListPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.doctorVisitViewExaminationListPanel.Controls.Add(this.doctorVisitViewExaminationListLabel);
            this.doctorVisitViewExaminationListPanel.Controls.Add(this.doctorVisitViewExaminationListButton);
            this.doctorVisitViewExaminationListPanel.Controls.Add(this.doctorVisitViewExaminationListDataGrid);
            this.doctorVisitViewExaminationListPanel.Location = new System.Drawing.Point(12, 189);
            this.doctorVisitViewExaminationListPanel.Name = "doctorVisitViewExaminationListPanel";
            this.doctorVisitViewExaminationListPanel.Size = new System.Drawing.Size(686, 159);
            this.doctorVisitViewExaminationListPanel.TabIndex = 4;
            // 
            // doctorVisitViewExaminationListLabel
            // 
            this.doctorVisitViewExaminationListLabel.AutoSize = true;
            this.doctorVisitViewExaminationListLabel.Location = new System.Drawing.Point(7, 13);
            this.doctorVisitViewExaminationListLabel.Name = "doctorVisitViewExaminationListLabel";
            this.doctorVisitViewExaminationListLabel.Size = new System.Drawing.Size(103, 13);
            this.doctorVisitViewExaminationListLabel.TabIndex = 2;
            this.doctorVisitViewExaminationListLabel.Text = "Examination history :";
            // 
            // doctorVisitViewExaminationListButton
            // 
            this.doctorVisitViewExaminationListButton.Location = new System.Drawing.Point(591, 8);
            this.doctorVisitViewExaminationListButton.Name = "doctorVisitViewExaminationListButton";
            this.doctorVisitViewExaminationListButton.Size = new System.Drawing.Size(75, 23);
            this.doctorVisitViewExaminationListButton.TabIndex = 1;
            this.doctorVisitViewExaminationListButton.Text = "View details";
            this.doctorVisitViewExaminationListButton.UseVisualStyleBackColor = true;
            // 
            // doctorVisitViewExaminationListDataGrid
            // 
            this.doctorVisitViewExaminationListDataGrid.AllowUserToAddRows = false;
            this.doctorVisitViewExaminationListDataGrid.AllowUserToDeleteRows = false;
            this.doctorVisitViewExaminationListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorVisitViewExaminationListDataGrid.Location = new System.Drawing.Point(7, 33);
            this.doctorVisitViewExaminationListDataGrid.Name = "doctorVisitViewExaminationListDataGrid";
            this.doctorVisitViewExaminationListDataGrid.ReadOnly = true;
            this.doctorVisitViewExaminationListDataGrid.Size = new System.Drawing.Size(672, 123);
            this.doctorVisitViewExaminationListDataGrid.TabIndex = 0;
            // 
            // doctorVisitViewVisitListPanel
            // 
            this.doctorVisitViewVisitListPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.doctorVisitViewVisitListPanel.Controls.Add(this.doctorVisitViewVisitListLabel);
            this.doctorVisitViewVisitListPanel.Controls.Add(this.doctorVisitViewVisitListButton);
            this.doctorVisitViewVisitListPanel.Controls.Add(this.doctorVisitViewVisitListDataGrid);
            this.doctorVisitViewVisitListPanel.Location = new System.Drawing.Point(12, 355);
            this.doctorVisitViewVisitListPanel.Name = "doctorVisitViewVisitListPanel";
            this.doctorVisitViewVisitListPanel.Size = new System.Drawing.Size(686, 165);
            this.doctorVisitViewVisitListPanel.TabIndex = 5;
            // 
            // doctorVisitViewVisitListLabel
            // 
            this.doctorVisitViewVisitListLabel.AutoSize = true;
            this.doctorVisitViewVisitListLabel.Location = new System.Drawing.Point(7, 13);
            this.doctorVisitViewVisitListLabel.Name = "doctorVisitViewVisitListLabel";
            this.doctorVisitViewVisitListLabel.Size = new System.Drawing.Size(65, 13);
            this.doctorVisitViewVisitListLabel.TabIndex = 2;
            this.doctorVisitViewVisitListLabel.Text = "Visit history :";
            // 
            // doctorVisitViewVisitListButton
            // 
            this.doctorVisitViewVisitListButton.Location = new System.Drawing.Point(591, 8);
            this.doctorVisitViewVisitListButton.Name = "doctorVisitViewVisitListButton";
            this.doctorVisitViewVisitListButton.Size = new System.Drawing.Size(75, 23);
            this.doctorVisitViewVisitListButton.TabIndex = 1;
            this.doctorVisitViewVisitListButton.Text = "View details";
            this.doctorVisitViewVisitListButton.UseVisualStyleBackColor = true;
            // 
            // doctorVisitViewVisitListDataGrid
            // 
            this.doctorVisitViewVisitListDataGrid.AllowUserToAddRows = false;
            this.doctorVisitViewVisitListDataGrid.AllowUserToDeleteRows = false;
            this.doctorVisitViewVisitListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorVisitViewVisitListDataGrid.Location = new System.Drawing.Point(7, 33);
            this.doctorVisitViewVisitListDataGrid.Name = "doctorVisitViewVisitListDataGrid";
            this.doctorVisitViewVisitListDataGrid.ReadOnly = true;
            this.doctorVisitViewVisitListDataGrid.Size = new System.Drawing.Size(672, 129);
            this.doctorVisitViewVisitListDataGrid.TabIndex = 0;
            // 
            // DoctorVisitViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 529);
            this.Controls.Add(this.doctorVisitViewVisitListPanel);
            this.Controls.Add(this.doctorVisitViewExaminationListPanel);
            this.Controls.Add(this.doctorVisitPanel);
            this.Name = "DoctorVisitViewForm";
            this.Text = "DoctorVisitView";
            this.doctorVisitPanel.ResumeLayout(false);
            this.doctorVisitPanel.PerformLayout();
            this.doctorVisitViewExaminationListPanel.ResumeLayout(false);
            this.doctorVisitViewExaminationListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorVisitViewExaminationListDataGrid)).EndInit();
            this.doctorVisitViewVisitListPanel.ResumeLayout(false);
            this.doctorVisitViewVisitListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorVisitViewVisitListDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button doctorCancelVisitButton;
        private System.Windows.Forms.Button doctorFinishVisitButton;
        private System.Windows.Forms.Button doctorOrderLaboratoryExaminationButton;
        private System.Windows.Forms.Panel doctorVisitPanel;
        private System.Windows.Forms.TextBox doctorVisitPatientLastNameTextBox;
        private System.Windows.Forms.TextBox doctorVisitPatientFirstNameTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox doctorVisitPatientPeselTextBox;
        private System.Windows.Forms.Panel doctorVisitViewExaminationListPanel;
        private System.Windows.Forms.DataGridView doctorVisitViewExaminationListDataGrid;
        private System.Windows.Forms.Panel doctorVisitViewVisitListPanel;
        private System.Windows.Forms.Button doctorVisitViewExaminationListButton;
        private System.Windows.Forms.Button doctorVisitViewVisitListButton;
        private System.Windows.Forms.DataGridView doctorVisitViewVisitListDataGrid;
        private System.Windows.Forms.Button doctorPhysicalExaminationButton;
        private System.Windows.Forms.Label doctorVisitViewExaminationListLabel;
        private System.Windows.Forms.Label doctorVisitViewVisitListLabel;
        private System.Windows.Forms.TextBox doctorVisitPatientDiagnosisTextBox;
    }
}