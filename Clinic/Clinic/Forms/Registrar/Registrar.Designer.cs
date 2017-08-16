using Clinic.DataSets;

namespace Clinic
{
    partial class Registrar
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
            this.resgistrarAddVisitButton = new System.Windows.Forms.Button();
            this.registrarModifyButton = new System.Windows.Forms.Button();
            this.clinicDataSet = new Clinic.DataSets.clinicDataSet();
            this.clinicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitTableAdapter = new Clinic.DataSets.clinicDataSet1TableAdapters.VisitTableAdapter();
            this.clinicDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTimePickerRegDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.registrarTextBoxPatientFName = new System.Windows.Forms.TextBox();
            this.registrarTextBoxDoctorFName = new System.Windows.Forms.TextBox();
            this.searchPanelRegistrar = new System.Windows.Forms.Panel();
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
            this.registrarSearchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.registrarStateComboBox = new System.Windows.Forms.ComboBox();
            this.visitTableAdapter1 = new Clinic.DataSets.clinicDataSet1TableAdapters.VisitTableAdapter();
            this.dataGridViewRegistrar = new System.Windows.Forms.DataGridView();
            this.clinicDataSet11 = new Clinic.DataSets.clinicDataSet1();
            this.registrarModifyPatientButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource1)).BeginInit();
            this.searchPanelRegistrar.SuspendLayout();
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
            // resgistrarAddVisitButton
            // 
            this.resgistrarAddVisitButton.Location = new System.Drawing.Point(667, 17);
            this.resgistrarAddVisitButton.Name = "resgistrarAddVisitButton";
            this.resgistrarAddVisitButton.Size = new System.Drawing.Size(75, 23);
            this.resgistrarAddVisitButton.TabIndex = 1;
            this.resgistrarAddVisitButton.Text = "Add Visit";
            this.resgistrarAddVisitButton.UseVisualStyleBackColor = true;
            this.resgistrarAddVisitButton.Click += new System.EventHandler(this.resgistrarAddVisitButton_Click);
            // 
            // registrarModifyButton
            // 
            this.registrarModifyButton.Location = new System.Drawing.Point(667, 66);
            this.registrarModifyButton.Name = "registrarModifyButton";
            this.registrarModifyButton.Size = new System.Drawing.Size(75, 23);
            this.registrarModifyButton.TabIndex = 2;
            this.registrarModifyButton.Text = "Modify Visit";
            this.registrarModifyButton.UseVisualStyleBackColor = true;
            this.registrarModifyButton.Click += new System.EventHandler(this.registrarSelectDoctorButton_Click);
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
            this.dataTimePickerRegDate.Location = new System.Drawing.Point(96, 13);
            this.dataTimePickerRegDate.Name = "dataTimePickerRegDate";
            this.dataTimePickerRegDate.ShowCheckBox = true;
            this.dataTimePickerRegDate.Size = new System.Drawing.Size(147, 20);
            this.dataTimePickerRegDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registration date :";
            // 
            // registrarTextBoxPatientFName
            // 
            this.registrarTextBoxPatientFName.Location = new System.Drawing.Point(74, 32);
            this.registrarTextBoxPatientFName.Name = "registrarTextBoxPatientFName";
            this.registrarTextBoxPatientFName.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxPatientFName.TabIndex = 19;
            // 
            // registrarTextBoxDoctorFName
            // 
            this.registrarTextBoxDoctorFName.Location = new System.Drawing.Point(74, 32);
            this.registrarTextBoxDoctorFName.Name = "registrarTextBoxDoctorFName";
            this.registrarTextBoxDoctorFName.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxDoctorFName.TabIndex = 20;
            // 
            // searchPanelRegistrar
            // 
            this.searchPanelRegistrar.AutoScroll = true;
            this.searchPanelRegistrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchPanelRegistrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchPanelRegistrar.Controls.Add(this.panelDoctor);
            this.searchPanelRegistrar.Controls.Add(this.panelPatient);
            this.searchPanelRegistrar.Controls.Add(this.registrarSearchButton);
            this.searchPanelRegistrar.Controls.Add(this.label4);
            this.searchPanelRegistrar.Controls.Add(this.registrarStateComboBox);
            this.searchPanelRegistrar.Controls.Add(this.label1);
            this.searchPanelRegistrar.Controls.Add(this.dataTimePickerRegDate);
            this.searchPanelRegistrar.Location = new System.Drawing.Point(6, 5);
            this.searchPanelRegistrar.Name = "searchPanelRegistrar";
            this.searchPanelRegistrar.Size = new System.Drawing.Size(644, 168);
            this.searchPanelRegistrar.TabIndex = 21;
            // 
            // panelDoctor
            // 
            this.panelDoctor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDoctor.Controls.Add(this.label8);
            this.panelDoctor.Controls.Add(this.label5);
            this.panelDoctor.Controls.Add(this.registrarTextBoxDoctorLName);
            this.panelDoctor.Controls.Add(this.label3);
            this.panelDoctor.Controls.Add(this.registrarTextBoxDoctorFName);
            this.panelDoctor.Location = new System.Drawing.Point(249, 70);
            this.panelDoctor.Name = "panelDoctor";
            this.panelDoctor.Size = new System.Drawing.Size(375, 59);
            this.panelDoctor.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Doctor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Last name:";
            // 
            // registrarTextBoxDoctorLName
            // 
            this.registrarTextBoxDoctorLName.Location = new System.Drawing.Point(251, 32);
            this.registrarTextBoxDoctorLName.Name = "registrarTextBoxDoctorLName";
            this.registrarTextBoxDoctorLName.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxDoctorLName.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
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
            this.panelPatient.Location = new System.Drawing.Point(249, 3);
            this.panelPatient.Name = "panelPatient";
            this.panelPatient.Size = new System.Drawing.Size(375, 59);
            this.panelPatient.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Patient";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // registrarTextBoxPatientLName
            // 
            this.registrarTextBoxPatientLName.Location = new System.Drawing.Point(251, 32);
            this.registrarTextBoxPatientLName.Name = "registrarTextBoxPatientLName";
            this.registrarTextBoxPatientLName.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxPatientLName.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Last name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "First name:";
            // 
            // registrarSearchButton
            // 
            this.registrarSearchButton.Location = new System.Drawing.Point(562, 138);
            this.registrarSearchButton.Name = "registrarSearchButton";
            this.registrarSearchButton.Size = new System.Drawing.Size(75, 23);
            this.registrarSearchButton.TabIndex = 21;
            this.registrarSearchButton.Text = "Search";
            this.registrarSearchButton.UseVisualStyleBackColor = true;
            this.registrarSearchButton.Click += new System.EventHandler(this.registrarSearchButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "State :";
            // 
            // registrarStateComboBox
            // 
            this.registrarStateComboBox.FormattingEnabled = true;
            this.registrarStateComboBox.Items.AddRange(new object[] {
            "",
            "DONE",
            "CANCELED",
            "REGISTERED"});
            this.registrarStateComboBox.Location = new System.Drawing.Point(96, 49);
            this.registrarStateComboBox.Name = "registrarStateComboBox";
            this.registrarStateComboBox.Size = new System.Drawing.Size(147, 21);
            this.registrarStateComboBox.TabIndex = 25;
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
            this.dataGridViewRegistrar.Location = new System.Drawing.Point(4, 203);
            this.dataGridViewRegistrar.MultiSelect = false;
            this.dataGridViewRegistrar.Name = "dataGridViewRegistrar";
            this.dataGridViewRegistrar.Size = new System.Drawing.Size(733, 131);
            this.dataGridViewRegistrar.TabIndex = 22;
            // 
            // clinicDataSet11
            // 
            this.clinicDataSet11.DataSetName = "clinicDataSet1";
            this.clinicDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrarModifyPatientButton
            // 
            this.registrarModifyPatientButton.Location = new System.Drawing.Point(656, 111);
            this.registrarModifyPatientButton.Name = "registrarModifyPatientButton";
            this.registrarModifyPatientButton.Size = new System.Drawing.Size(86, 23);
            this.registrarModifyPatientButton.TabIndex = 23;
            this.registrarModifyPatientButton.Text = "Modify Patient";
            this.registrarModifyPatientButton.UseVisualStyleBackColor = true;
            this.registrarModifyPatientButton.Click += new System.EventHandler(this.registrarModifyPatientButton_Click);
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 355);
            this.Controls.Add(this.registrarModifyPatientButton);
            this.Controls.Add(this.dataGridViewRegistrar);
            this.Controls.Add(this.searchPanelRegistrar);
            this.Controls.Add(this.registrarModifyButton);
            this.Controls.Add(this.resgistrarAddVisitButton);
            this.MaximumSize = new System.Drawing.Size(765, 800);
            this.MinimumSize = new System.Drawing.Size(765, 394);
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.Registrar_Load);
            this.Resize += new System.EventHandler(this.Registrar_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource1)).EndInit();
            this.searchPanelRegistrar.ResumeLayout(false);
            this.searchPanelRegistrar.PerformLayout();
            this.panelDoctor.ResumeLayout(false);
            this.panelDoctor.PerformLayout();
            this.panelPatient.ResumeLayout(false);
            this.panelPatient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button resgistrarAddVisitButton;
        private System.Windows.Forms.Button registrarModifyButton;
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
        private System.Windows.Forms.Panel searchPanelRegistrar;
        private System.Windows.Forms.Button registrarSearchButton;
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
        private System.Windows.Forms.Button registrarModifyPatientButton;
    }
}