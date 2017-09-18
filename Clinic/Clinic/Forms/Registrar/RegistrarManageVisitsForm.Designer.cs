using BizzLayer.Model;
using Clinic.DataSets;

namespace Clinic
{
    partial class RegistrarManageVisitsForm
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
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet1 = new Clinic.DataSets.clinicDataSet1();
            this.RegistrarManageVisitModifyVisitButton = new System.Windows.Forms.Button();
            this.clinicDataSet = new Clinic.DataSets.clinicDataSet();
            this.clinicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitTableAdapter = new Clinic.DataSets.clinicDataSet1TableAdapters.VisitTableAdapter();
            this.clinicDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTimePickerRegDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.registrarTextBoxPatientFName = new System.Windows.Forms.TextBox();
            this.registrarTextBoxDoctorFName = new System.Windows.Forms.TextBox();
            this.RegistrarManageVisitSearchPanel = new System.Windows.Forms.Panel();
            this.panelDoctor = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.registrarTextBoxDoctorLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPatient = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.registrarTextBoxPatientLName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.registrarStateComboBox = new System.Windows.Forms.ComboBox();
            this.RegistrarManageVisitSearchButton = new System.Windows.Forms.Button();
            this.visitTableAdapter1 = new Clinic.DataSets.clinicDataSet1TableAdapters.VisitTableAdapter();
            this.dataGridViewRegistrar = new System.Windows.Forms.DataGridView();
            this.clinicDataSet11 = new Clinic.DataSets.clinicDataSet1();
            this.RegistrarManageVisitCanceVisitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource1)).BeginInit();
            this.RegistrarManageVisitSearchPanel.SuspendLayout();
            this.panelDoctor.SuspendLayout();
            this.panelPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataMember = "Visit";
            this.visitBindingSource.DataSource = this.clinicDataSet1;
            // 
            // clinicDataSet1
            // 
            this.clinicDataSet1.DataSetName = "clinicDataSet1";
            this.clinicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RegistrarManageVisitModifyVisitButton
            // 
            this.RegistrarManageVisitModifyVisitButton.Location = new System.Drawing.Point(909, 105);
            this.RegistrarManageVisitModifyVisitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegistrarManageVisitModifyVisitButton.Name = "RegistrarManageVisitModifyVisitButton";
            this.RegistrarManageVisitModifyVisitButton.Size = new System.Drawing.Size(100, 28);
            this.RegistrarManageVisitModifyVisitButton.TabIndex = 2;
            this.RegistrarManageVisitModifyVisitButton.Text = "Modify Visit";
            this.RegistrarManageVisitModifyVisitButton.UseVisualStyleBackColor = true;
            this.RegistrarManageVisitModifyVisitButton.Click += new System.EventHandler(this.registrarModifyVisitButton_Click);
            // 
            // clinicDataSet
            // 
            this.clinicDataSet.DataSetName = "clinicDataSet";
            this.clinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinicDataSetBindingSource
            // 
            this.clinicDataSetBindingSource.DataSource = this.clinicDataSet;
            this.clinicDataSetBindingSource.Position = 0;
            // 
            // visitTableAdapter
            // 
            this.visitTableAdapter.ClearBeforeFill = true;
            // 
            // clinicDataSetBindingSource1
            // 
            this.clinicDataSetBindingSource1.DataSource = this.clinicDataSet;
            this.clinicDataSetBindingSource1.Position = 0;
            // 
            // dataTimePickerRegDate
            // 
            this.dataTimePickerRegDate.Location = new System.Drawing.Point(128, 16);
            this.dataTimePickerRegDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataTimePickerRegDate.Name = "dataTimePickerRegDate";
            this.dataTimePickerRegDate.ShowCheckBox = true;
            this.dataTimePickerRegDate.Size = new System.Drawing.Size(195, 22);
            this.dataTimePickerRegDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registration date :";
            // 
            // registrarTextBoxPatientFName
            // 
            this.registrarTextBoxPatientFName.Location = new System.Drawing.Point(99, 39);
            this.registrarTextBoxPatientFName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registrarTextBoxPatientFName.Name = "registrarTextBoxPatientFName";
            this.registrarTextBoxPatientFName.Size = new System.Drawing.Size(132, 22);
            this.registrarTextBoxPatientFName.TabIndex = 19;
            // 
            // registrarTextBoxDoctorFName
            // 
            this.registrarTextBoxDoctorFName.Location = new System.Drawing.Point(99, 39);
            this.registrarTextBoxDoctorFName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registrarTextBoxDoctorFName.Name = "registrarTextBoxDoctorFName";
            this.registrarTextBoxDoctorFName.Size = new System.Drawing.Size(132, 22);
            this.registrarTextBoxDoctorFName.TabIndex = 20;
            // 
            // RegistrarManageVisitSearchPanel
            // 
            this.RegistrarManageVisitSearchPanel.AutoScroll = true;
            this.RegistrarManageVisitSearchPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.RegistrarManageVisitSearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RegistrarManageVisitSearchPanel.Controls.Add(this.panelDoctor);
            this.RegistrarManageVisitSearchPanel.Controls.Add(this.panelPatient);
            this.RegistrarManageVisitSearchPanel.Controls.Add(this.label4);
            this.RegistrarManageVisitSearchPanel.Controls.Add(this.registrarStateComboBox);
            this.RegistrarManageVisitSearchPanel.Controls.Add(this.label1);
            this.RegistrarManageVisitSearchPanel.Controls.Add(this.dataTimePickerRegDate);
            this.RegistrarManageVisitSearchPanel.Location = new System.Drawing.Point(16, 15);
            this.RegistrarManageVisitSearchPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegistrarManageVisitSearchPanel.Name = "RegistrarManageVisitSearchPanel";
            this.RegistrarManageVisitSearchPanel.Size = new System.Drawing.Size(884, 176);
            this.RegistrarManageVisitSearchPanel.TabIndex = 21;
            // 
            // panelDoctor
            // 
            this.panelDoctor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDoctor.Controls.Add(this.label8);
            this.panelDoctor.Controls.Add(this.label5);
            this.panelDoctor.Controls.Add(this.registrarTextBoxDoctorLName);
            this.panelDoctor.Controls.Add(this.label3);
            this.panelDoctor.Controls.Add(this.registrarTextBoxDoctorFName);
            this.panelDoctor.Location = new System.Drawing.Point(352, 87);
            this.panelDoctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDoctor.Name = "panelDoctor";
            this.panelDoctor.Size = new System.Drawing.Size(499, 72);
            this.panelDoctor.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Doctor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Last name:";
            // 
            // registrarTextBoxDoctorLName
            // 
            this.registrarTextBoxDoctorLName.Location = new System.Drawing.Point(335, 39);
            this.registrarTextBoxDoctorLName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registrarTextBoxDoctorLName.Name = "registrarTextBoxDoctorLName";
            this.registrarTextBoxDoctorLName.Size = new System.Drawing.Size(132, 22);
            this.registrarTextBoxDoctorLName.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "First name:";
            // 
            // panelPatient
            // 
            this.panelPatient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPatient.Controls.Add(this.label7);
            this.panelPatient.Controls.Add(this.registrarTextBoxPatientLName);
            this.panelPatient.Controls.Add(this.label6);
            this.panelPatient.Controls.Add(this.label2);
            this.panelPatient.Controls.Add(this.registrarTextBoxPatientFName);
            this.panelPatient.Location = new System.Drawing.Point(352, 7);
            this.panelPatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPatient.Name = "panelPatient";
            this.panelPatient.Size = new System.Drawing.Size(499, 72);
            this.panelPatient.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Patient";
            // 
            // registrarTextBoxPatientLName
            // 
            this.registrarTextBoxPatientLName.Location = new System.Drawing.Point(335, 39);
            this.registrarTextBoxPatientLName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registrarTextBoxPatientLName.Name = "registrarTextBoxPatientLName";
            this.registrarTextBoxPatientLName.Size = new System.Drawing.Size(132, 22);
            this.registrarTextBoxPatientLName.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Last name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "First name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "State :";
            // 
            // registrarStateComboBox
            // 
            this.registrarStateComboBox.FormattingEnabled = true;
            this.registrarStateComboBox.Items.AddRange(new object[] {
            "",
            "DONE",
            "CANC",
            "REG"});
            this.registrarStateComboBox.Location = new System.Drawing.Point(128, 60);
            this.registrarStateComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registrarStateComboBox.Name = "registrarStateComboBox";
            this.registrarStateComboBox.Size = new System.Drawing.Size(195, 24);
            this.registrarStateComboBox.TabIndex = 25;
            // 
            // RegistrarManageVisitSearchButton
            // 
            this.RegistrarManageVisitSearchButton.Location = new System.Drawing.Point(909, 30);
            this.RegistrarManageVisitSearchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegistrarManageVisitSearchButton.Name = "RegistrarManageVisitSearchButton";
            this.RegistrarManageVisitSearchButton.Size = new System.Drawing.Size(100, 28);
            this.RegistrarManageVisitSearchButton.TabIndex = 21;
            this.RegistrarManageVisitSearchButton.Text = "Search";
            this.RegistrarManageVisitSearchButton.UseVisualStyleBackColor = true;
            this.RegistrarManageVisitSearchButton.Click += new System.EventHandler(this.registrarSearchButton_Click);
            // 
            // visitTableAdapter1
            // 
            this.visitTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewRegistrar
            // 
            this.dataGridViewRegistrar.AllowUserToAddRows = false;
            this.dataGridViewRegistrar.AllowUserToDeleteRows = false;
            this.dataGridViewRegistrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistrar.Location = new System.Drawing.Point(16, 199);
            this.dataGridViewRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewRegistrar.Name = "dataGridViewRegistrar";
            this.dataGridViewRegistrar.ReadOnly = true;
            this.dataGridViewRegistrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRegistrar.Size = new System.Drawing.Size(993, 487);
            this.dataGridViewRegistrar.TabIndex = 22;
            // 
            // clinicDataSet11
            // 
            this.clinicDataSet11.DataSetName = "clinicDataSet1";
            this.clinicDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RegistrarManageVisitCanceVisitButton
            // 
            this.RegistrarManageVisitCanceVisitButton.Location = new System.Drawing.Point(909, 149);
            this.RegistrarManageVisitCanceVisitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RegistrarManageVisitCanceVisitButton.Name = "RegistrarManageVisitCanceVisitButton";
            this.RegistrarManageVisitCanceVisitButton.Size = new System.Drawing.Size(100, 28);
            this.RegistrarManageVisitCanceVisitButton.TabIndex = 23;
            this.RegistrarManageVisitCanceVisitButton.Text = "Cancel Visit";
            this.RegistrarManageVisitCanceVisitButton.UseVisualStyleBackColor = true;
            this.RegistrarManageVisitCanceVisitButton.Click += new System.EventHandler(this.RegistrarManageVisitCanceVisitButton_Click);
            // 
            // RegistrarManageVisitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 702);
            this.Controls.Add(this.RegistrarManageVisitCanceVisitButton);
            this.Controls.Add(this.dataGridViewRegistrar);
            this.Controls.Add(this.RegistrarManageVisitSearchPanel);
            this.Controls.Add(this.RegistrarManageVisitSearchButton);
            this.Controls.Add(this.RegistrarManageVisitModifyVisitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1041, 974);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1041, 475);
            this.Name = "RegistrarManageVisitsForm";
            this.Text = "Manage Visits";
            this.Load += new System.EventHandler(this.Registrar_Load);
            this.Resize += new System.EventHandler(this.Registrar_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource1)).EndInit();
            this.RegistrarManageVisitSearchPanel.ResumeLayout(false);
            this.RegistrarManageVisitSearchPanel.PerformLayout();
            this.panelDoctor.ResumeLayout(false);
            this.panelDoctor.PerformLayout();
            this.panelPatient.ResumeLayout(false);
            this.panelPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RegistrarManageVisitModifyVisitButton;
        private clinicDataSet1 clinicDataSet1;
        private System.Windows.Forms.BindingSource clinicDataSetBindingSource;
        private clinicDataSet clinicDataSet;
        private System.Windows.Forms.BindingSource visitBindingSource;
        private DataSets.clinicDataSet1TableAdapters.VisitTableAdapter visitTableAdapter;
        private System.Windows.Forms.BindingSource clinicDataSetBindingSource1;
        private System.Windows.Forms.DateTimePicker dataTimePickerRegDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox registrarTextBoxPatientFName;
        private System.Windows.Forms.TextBox registrarTextBoxDoctorFName;
        private System.Windows.Forms.Panel RegistrarManageVisitSearchPanel;
        private System.Windows.Forms.Button RegistrarManageVisitSearchButton;
        private DataSets.clinicDataSet1TableAdapters.VisitTableAdapter visitTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewRegistrar;
        private clinicDataSet1 clinicDataSet11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox registrarStateComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox registrarTextBoxDoctorLName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox registrarTextBoxPatientLName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelDoctor;
        private System.Windows.Forms.Panel panelPatient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button RegistrarManageVisitCanceVisitButton;
    }
}