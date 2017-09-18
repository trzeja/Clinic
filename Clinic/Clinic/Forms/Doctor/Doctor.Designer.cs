using BizzLayer.Model;
using Clinic.DataSets;
using DataLayer;
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
            this.clinicDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet1 = new Clinic.DataSets.clinicDataSet1();
            this.doctorSelectVisitbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doctorAllPatientsButton = new System.Windows.Forms.Button();
            this.doctorSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorSearchPanel
            // 
            this.doctorSearchPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.doctorSearchPanel.Controls.Add(this.doctorAllPatientsButton);
            this.doctorSearchPanel.Controls.Add(this.doctorVisitStateComboBox);
            this.doctorSearchPanel.Controls.Add(this.label2);
            this.doctorSearchPanel.Controls.Add(this.doctorFindPatientButton);
            this.doctorSearchPanel.Controls.Add(this.doctorPatientNameLabel);
            this.doctorSearchPanel.Controls.Add(this.doctorPatientNameTextBox);
            this.doctorSearchPanel.Controls.Add(this.doctorSearchButton);
            this.doctorSearchPanel.Controls.Add(this.doctorDateTimePickerExecDate);
            this.doctorSearchPanel.Location = new System.Drawing.Point(4, 9);
            this.doctorSearchPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doctorSearchPanel.Name = "doctorSearchPanel";
            this.doctorSearchPanel.Size = new System.Drawing.Size(628, 110);
            this.doctorSearchPanel.TabIndex = 0;
            // 
            // doctorVisitStateComboBox
            // 
            this.doctorVisitStateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorVisitStateComboBox.FormattingEnabled = true;
            this.doctorVisitStateComboBox.Items.AddRange(new object[] {
            "",
            "REG",
            "DONE",
            "CANC"});
            this.doctorVisitStateComboBox.Location = new System.Drawing.Point(120, 43);
            this.doctorVisitStateComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doctorVisitStateComboBox.Name = "doctorVisitStateComboBox";
            this.doctorVisitStateComboBox.Size = new System.Drawing.Size(160, 24);
            this.doctorVisitStateComboBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Visit status :";
            // 
            // doctorFindPatientButton
            // 
            this.doctorFindPatientButton.Location = new System.Drawing.Point(404, 7);
            this.doctorFindPatientButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doctorFindPatientButton.Name = "doctorFindPatientButton";
            this.doctorFindPatientButton.Size = new System.Drawing.Size(161, 28);
            this.doctorFindPatientButton.TabIndex = 8;
            this.doctorFindPatientButton.Text = "Find patient";
            this.doctorFindPatientButton.UseVisualStyleBackColor = true;
            this.doctorFindPatientButton.Click += new System.EventHandler(this.doctorFindPatientButton_Click);
            // 
            // doctorPatientNameLabel
            // 
            this.doctorPatientNameLabel.AutoSize = true;
            this.doctorPatientNameLabel.Location = new System.Drawing.Point(12, 14);
            this.doctorPatientNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.doctorPatientNameLabel.Name = "doctorPatientNameLabel";
            this.doctorPatientNameLabel.Size = new System.Drawing.Size(99, 17);
            this.doctorPatientNameLabel.TabIndex = 7;
            this.doctorPatientNameLabel.Text = "Patient name :";
            // 
            // doctorPatientNameTextBox
            // 
            this.doctorPatientNameTextBox.Enabled = false;
            this.doctorPatientNameTextBox.Location = new System.Drawing.Point(120, 10);
            this.doctorPatientNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doctorPatientNameTextBox.Name = "doctorPatientNameTextBox";
            this.doctorPatientNameTextBox.ReadOnly = true;
            this.doctorPatientNameTextBox.Size = new System.Drawing.Size(275, 22);
            this.doctorPatientNameTextBox.TabIndex = 6;
            this.doctorPatientNameTextBox.Text = "Patient name";
            // 
            // doctorSearchButton
            // 
            this.doctorSearchButton.Location = new System.Drawing.Point(215, 75);
            this.doctorSearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doctorSearchButton.Name = "doctorSearchButton";
            this.doctorSearchButton.Size = new System.Drawing.Size(197, 28);
            this.doctorSearchButton.TabIndex = 5;
            this.doctorSearchButton.Text = "Search";
            this.doctorSearchButton.UseVisualStyleBackColor = true;
            this.doctorSearchButton.Click += new System.EventHandler(this.doctorSearchButton_Click);
            // 
            // doctorDateTimePickerExecDate
            // 
            this.doctorDateTimePickerExecDate.Checked = false;
            this.doctorDateTimePickerExecDate.Location = new System.Drawing.Point(289, 44);
            this.doctorDateTimePickerExecDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doctorDateTimePickerExecDate.Name = "doctorDateTimePickerExecDate";
            this.doctorDateTimePickerExecDate.ShowCheckBox = true;
            this.doctorDateTimePickerExecDate.Size = new System.Drawing.Size(313, 22);
            this.doctorDateTimePickerExecDate.TabIndex = 4;
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
            this.doctorSelectVisitbutton.Location = new System.Drawing.Point(447, 455);
            this.doctorSelectVisitbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.doctorSelectVisitbutton.Name = "doctorSelectVisitbutton";
            this.doctorSelectVisitbutton.Size = new System.Drawing.Size(161, 28);
            this.doctorSelectVisitbutton.TabIndex = 2;
            this.doctorSelectVisitbutton.Text = "Select Visit";
            this.doctorSelectVisitbutton.UseVisualStyleBackColor = true;
            this.doctorSelectVisitbutton.Click += new System.EventHandler(this.doctorSelectVisitbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 142);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(621, 290);
            this.dataGridView1.TabIndex = 3;
            // 
            // doctorAllPatientsButton
            // 
            this.doctorAllPatientsButton.Location = new System.Drawing.Point(570, 7);
            this.doctorAllPatientsButton.Name = "doctorAllPatientsButton";
            this.doctorAllPatientsButton.Size = new System.Drawing.Size(55, 28);
            this.doctorAllPatientsButton.TabIndex = 11;
            this.doctorAllPatientsButton.Text = "All";
            this.doctorAllPatientsButton.UseVisualStyleBackColor = true;
            this.doctorAllPatientsButton.Click += new System.EventHandler(this.doctorAllPatientsButton_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 495);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.doctorSelectVisitbutton);
            this.Controls.Add(this.doctorSearchPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.doctorSearchPanel.ResumeLayout(false);
            this.doctorSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel doctorSearchPanel;
        private System.Windows.Forms.DateTimePicker doctorDateTimePickerExecDate;
        private System.Windows.Forms.Button doctorSearchButton;
        private System.Windows.Forms.TextBox doctorPatientNameTextBox;
        private System.Windows.Forms.BindingSource clinicDataSet1BindingSource;
        private clinicDataSet1 clinicDataSet1;
        private System.Windows.Forms.Button doctorSelectVisitbutton;
        private System.Windows.Forms.Label doctorPatientNameLabel;
        private System.Windows.Forms.Button doctorFindPatientButton;
        private System.Windows.Forms.ComboBox doctorVisitStateComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button doctorAllPatientsButton;
    }
}