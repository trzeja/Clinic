using Clinic.DataSets;

namespace Clinic
{
    partial class Doctor
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
            this.components = new System.ComponentModel.Container();
            this.doctorSearchPanel = new System.Windows.Forms.Panel();
            this.doctorVisitStateComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.doctorFindPatientButton = new System.Windows.Forms.Button();
            this.doctorPatientNameLabel = new System.Windows.Forms.Label();
            this.doctorPatientNameTextBox = new System.Windows.Forms.TextBox();
            this.doctorSearchButton = new System.Windows.Forms.Button();
            this.doctorDateTimePickerExecDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clinicDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet1 = new Clinic.DataSets.clinicDataSet1();
            this.doctorSelectVisitbutton = new System.Windows.Forms.Button();
            this.doctorSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorSearchPanel
            // 
            this.doctorSearchPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.doctorSearchPanel.Controls.Add(this.doctorVisitStateComboBox);
            this.doctorSearchPanel.Controls.Add(this.label2);
            this.doctorSearchPanel.Controls.Add(this.doctorFindPatientButton);
            this.doctorSearchPanel.Controls.Add(this.doctorPatientNameLabel);
            this.doctorSearchPanel.Controls.Add(this.doctorPatientNameTextBox);
            this.doctorSearchPanel.Controls.Add(this.doctorSearchButton);
            this.doctorSearchPanel.Controls.Add(this.doctorDateTimePickerExecDate);
            this.doctorSearchPanel.Location = new System.Drawing.Point(3, 7);
            this.doctorSearchPanel.Name = "doctorSearchPanel";
            this.doctorSearchPanel.Size = new System.Drawing.Size(471, 89);
            this.doctorSearchPanel.TabIndex = 0;
            // 
            // doctorVisitStateComboBox
            // 
            this.doctorVisitStateComboBox.FormattingEnabled = true;
            this.doctorVisitStateComboBox.Items.AddRange(new object[] {
            "Registered",
            "Done",
            "Cancelled"});
            this.doctorVisitStateComboBox.Location = new System.Drawing.Point(90, 35);
            this.doctorVisitStateComboBox.Name = "doctorVisitStateComboBox";
            this.doctorVisitStateComboBox.Size = new System.Drawing.Size(121, 21);
            this.doctorVisitStateComboBox.TabIndex = 10;
            this.doctorVisitStateComboBox.Text = "Registered";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Visit status :";
            // 
            // doctorFindPatientButton
            // 
            this.doctorFindPatientButton.Location = new System.Drawing.Point(303, 6);
            this.doctorFindPatientButton.Name = "doctorFindPatientButton";
            this.doctorFindPatientButton.Size = new System.Drawing.Size(121, 23);
            this.doctorFindPatientButton.TabIndex = 8;
            this.doctorFindPatientButton.Text = "Find patient";
            this.doctorFindPatientButton.UseVisualStyleBackColor = true;
            this.doctorFindPatientButton.Click += new System.EventHandler(this.doctorFindPatientButton_Click);
            // 
            // doctorPatientNameLabel
            // 
            this.doctorPatientNameLabel.AutoSize = true;
            this.doctorPatientNameLabel.Location = new System.Drawing.Point(9, 11);
            this.doctorPatientNameLabel.Name = "doctorPatientNameLabel";
            this.doctorPatientNameLabel.Size = new System.Drawing.Size(75, 13);
            this.doctorPatientNameLabel.TabIndex = 7;
            this.doctorPatientNameLabel.Text = "Patient name :";
            // 
            // doctorPatientNameTextBox
            // 
            this.doctorPatientNameTextBox.Location = new System.Drawing.Point(90, 8);
            this.doctorPatientNameTextBox.Name = "doctorPatientNameTextBox";
            this.doctorPatientNameTextBox.ReadOnly = true;
            this.doctorPatientNameTextBox.Size = new System.Drawing.Size(207, 20);
            this.doctorPatientNameTextBox.TabIndex = 6;
            this.doctorPatientNameTextBox.Text = "Patient name";
            // 
            // doctorSearchButton
            // 
            this.doctorSearchButton.Location = new System.Drawing.Point(161, 61);
            this.doctorSearchButton.Name = "doctorSearchButton";
            this.doctorSearchButton.Size = new System.Drawing.Size(148, 23);
            this.doctorSearchButton.TabIndex = 5;
            this.doctorSearchButton.Text = "Search";
            this.doctorSearchButton.UseVisualStyleBackColor = true;
            this.doctorSearchButton.Click += new System.EventHandler(this.doctorSearchButton_Click);
            // 
            // doctorDateTimePickerExecDate
            // 
            this.doctorDateTimePickerExecDate.Checked = false;
            this.doctorDateTimePickerExecDate.Location = new System.Drawing.Point(217, 36);
            this.doctorDateTimePickerExecDate.Name = "doctorDateTimePickerExecDate";
            this.doctorDateTimePickerExecDate.ShowCheckBox = true;
            this.doctorDateTimePickerExecDate.Size = new System.Drawing.Size(236, 20);
            this.doctorDateTimePickerExecDate.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.clinicDataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(471, 262);
            this.dataGridView1.TabIndex = 1;
            // 
            // clinicDataSet1BindingSource
            // 
            this.clinicDataSet1BindingSource.DataSource = this.clinicDataSet1;
            this.clinicDataSet1BindingSource.Position = 0;
            // 
            // clinicDataSet1
            // 
            this.clinicDataSet1.DataSetName = "clinicDataSet1";
            this.clinicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorSelectVisitbutton
            // 
            this.doctorSelectVisitbutton.Location = new System.Drawing.Point(335, 370);
            this.doctorSelectVisitbutton.Name = "doctorSelectVisitbutton";
            this.doctorSelectVisitbutton.Size = new System.Drawing.Size(121, 23);
            this.doctorSelectVisitbutton.TabIndex = 2;
            this.doctorSelectVisitbutton.Text = "Select Visit";
            this.doctorSelectVisitbutton.UseVisualStyleBackColor = true;
            this.doctorSelectVisitbutton.Click += new System.EventHandler(this.doctorSelectVisitbutton_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 402);
            this.Controls.Add(this.doctorSelectVisitbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.doctorSearchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.doctorSearchPanel.ResumeLayout(false);
            this.doctorSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel doctorSearchPanel;
        private System.Windows.Forms.DateTimePicker doctorDateTimePickerExecDate;
        private System.Windows.Forms.Button doctorSearchButton;
        private System.Windows.Forms.TextBox doctorPatientNameTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clinicDataSet1BindingSource;
        private clinicDataSet1 clinicDataSet1;
        private System.Windows.Forms.Button doctorSelectVisitbutton;
        private System.Windows.Forms.Label doctorPatientNameLabel;
        private System.Windows.Forms.Button doctorFindPatientButton;
        private System.Windows.Forms.ComboBox doctorVisitStateComboBox;
        private System.Windows.Forms.Label label2;
    }
}