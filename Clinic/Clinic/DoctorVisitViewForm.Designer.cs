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
            this.doctorVisitPatientDescriptionTextBox = new System.Windows.Forms.TextBox();
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
            this.doctorVisitPhysicalExaminationPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.doctorVisitPanel.SuspendLayout();
            this.doctorVisitViewExaminationListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorVisitViewExaminationListDataGrid)).BeginInit();
            this.doctorVisitViewVisitListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorVisitViewVisitListDataGrid)).BeginInit();
            this.doctorVisitPhysicalExaminationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctorCancelVisitButton
            // 
            this.doctorCancelVisitButton.Location = new System.Drawing.Point(591, 36);
            this.doctorCancelVisitButton.Name = "doctorCancelVisitButton";
            this.doctorCancelVisitButton.Size = new System.Drawing.Size(75, 23);
            this.doctorCancelVisitButton.TabIndex = 0;
            this.doctorCancelVisitButton.Text = "Cancel visit";
            this.doctorCancelVisitButton.UseVisualStyleBackColor = true;
            this.doctorCancelVisitButton.Click += new System.EventHandler(this.doctorCancelVisitButton_Click);
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
            this.doctorOrderLaboratoryExaminationButton.Location = new System.Drawing.Point(427, 9);
            this.doctorOrderLaboratoryExaminationButton.Name = "doctorOrderLaboratoryExaminationButton";
            this.doctorOrderLaboratoryExaminationButton.Size = new System.Drawing.Size(158, 50);
            this.doctorOrderLaboratoryExaminationButton.TabIndex = 2;
            this.doctorOrderLaboratoryExaminationButton.Text = "Order Laboratory Examination";
            this.doctorOrderLaboratoryExaminationButton.UseVisualStyleBackColor = true;
            this.doctorOrderLaboratoryExaminationButton.Click += new System.EventHandler(this.doctorOrderLaboratoryExaminationButton_Click);
            // 
            // doctorVisitPanel
            // 
            this.doctorVisitPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.doctorVisitPanel.Controls.Add(this.comboBox2);
            this.doctorVisitPanel.Controls.Add(this.doctorVisitPatientDescriptionTextBox);
            this.doctorVisitPanel.Controls.Add(this.textBox1);
            this.doctorVisitPanel.Controls.Add(this.doctorCancelVisitButton);
            this.doctorVisitPanel.Controls.Add(this.doctorVisitPatientPeselTextBox);
            this.doctorVisitPanel.Controls.Add(this.doctorVisitPatientLastNameTextBox);
            this.doctorVisitPanel.Controls.Add(this.doctorVisitPatientFirstNameTextBox);
            this.doctorVisitPanel.Controls.Add(this.doctorFinishVisitButton);
            this.doctorVisitPanel.Controls.Add(this.doctorOrderLaboratoryExaminationButton);
            this.doctorVisitPanel.Location = new System.Drawing.Point(12, 12);
            this.doctorVisitPanel.Name = "doctorVisitPanel";
            this.doctorVisitPanel.Size = new System.Drawing.Size(686, 118);
            this.doctorVisitPanel.TabIndex = 3;
            // 
            // doctorVisitPatientDescriptionTextBox
            // 
            this.doctorVisitPatientDescriptionTextBox.Location = new System.Drawing.Point(21, 62);
            this.doctorVisitPatientDescriptionTextBox.Multiline = true;
            this.doctorVisitPatientDescriptionTextBox.Name = "doctorVisitPatientDescriptionTextBox";
            this.doctorVisitPatientDescriptionTextBox.Size = new System.Drawing.Size(645, 47);
            this.doctorVisitPatientDescriptionTextBox.TabIndex = 8;
            this.doctorVisitPatientDescriptionTextBox.Text = "Description";
            this.doctorVisitPatientDescriptionTextBox.Enter += new System.EventHandler(this.doctorVisitPatientDescriptionTextBox_Enter);
            this.doctorVisitPatientDescriptionTextBox.Leave += new System.EventHandler(this.doctorVisitPatientDescriptionTextBox_Leave);
            // 
            // doctorPhysicalExaminationButton
            // 
            this.doctorPhysicalExaminationButton.Location = new System.Drawing.Point(591, 8);
            this.doctorPhysicalExaminationButton.Name = "doctorPhysicalExaminationButton";
            this.doctorPhysicalExaminationButton.Size = new System.Drawing.Size(75, 23);
            this.doctorPhysicalExaminationButton.TabIndex = 7;
            this.doctorPhysicalExaminationButton.Text = "Submit";
            this.doctorPhysicalExaminationButton.UseVisualStyleBackColor = true;
            this.doctorPhysicalExaminationButton.Click += new System.EventHandler(this.doctorPhysicalExaminationButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(21, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "id_visit";
            // 
            // doctorVisitPatientPeselTextBox
            // 
            this.doctorVisitPatientPeselTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.doctorVisitPatientPeselTextBox.Enabled = false;
            this.doctorVisitPatientPeselTextBox.Location = new System.Drawing.Point(304, 12);
            this.doctorVisitPatientPeselTextBox.Name = "doctorVisitPatientPeselTextBox";
            this.doctorVisitPatientPeselTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctorVisitPatientPeselTextBox.TabIndex = 5;
            this.doctorVisitPatientPeselTextBox.Text = "PESEL";
            // 
            // doctorVisitPatientLastNameTextBox
            // 
            this.doctorVisitPatientLastNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.doctorVisitPatientLastNameTextBox.Enabled = false;
            this.doctorVisitPatientLastNameTextBox.Location = new System.Drawing.Point(198, 12);
            this.doctorVisitPatientLastNameTextBox.Name = "doctorVisitPatientLastNameTextBox";
            this.doctorVisitPatientLastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.doctorVisitPatientLastNameTextBox.TabIndex = 4;
            this.doctorVisitPatientLastNameTextBox.Text = "patient last name";
            // 
            // doctorVisitPatientFirstNameTextBox
            // 
            this.doctorVisitPatientFirstNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.doctorVisitPatientFirstNameTextBox.Enabled = false;
            this.doctorVisitPatientFirstNameTextBox.Location = new System.Drawing.Point(92, 11);
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
            this.doctorVisitViewExaminationListLabel.Location = new System.Drawing.Point(18, 13);
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
            this.doctorVisitViewVisitListLabel.Location = new System.Drawing.Point(18, 13);
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
            // doctorVisitPhysicalExaminationPanel
            // 
            this.doctorVisitPhysicalExaminationPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.doctorVisitPhysicalExaminationPanel.Controls.Add(this.label1);
            this.doctorVisitPhysicalExaminationPanel.Controls.Add(this.comboBox1);
            this.doctorVisitPhysicalExaminationPanel.Controls.Add(this.doctorPhysicalExaminationButton);
            this.doctorVisitPhysicalExaminationPanel.Location = new System.Drawing.Point(12, 137);
            this.doctorVisitPhysicalExaminationPanel.Name = "doctorVisitPhysicalExaminationPanel";
            this.doctorVisitPhysicalExaminationPanel.Size = new System.Drawing.Size(686, 46);
            this.doctorVisitPhysicalExaminationPanel.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(449, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(21, 38);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(383, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.Text = "Diagnosis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Physical Examination :";
            // 
            // DoctorVisitViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 529);
            this.Controls.Add(this.doctorVisitPhysicalExaminationPanel);
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
            this.doctorVisitPhysicalExaminationPanel.ResumeLayout(false);
            this.doctorVisitPhysicalExaminationPanel.PerformLayout();
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
        private System.Windows.Forms.TextBox doctorVisitPatientDescriptionTextBox;
        private System.Windows.Forms.Panel doctorVisitPhysicalExaminationPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
    }
}