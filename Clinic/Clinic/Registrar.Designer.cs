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
            this.clinicDataSet1 = new Clinic.clinicDataSet1();
            this.resgistrarAddVisitButton = new System.Windows.Forms.Button();
            this.registrarModifyButton = new System.Windows.Forms.Button();
            this.clinicDataSet = new Clinic.clinicDataSet();
            this.clinicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitTableAdapter = new Clinic.clinicDataSet1TableAdapters.VisitTableAdapter();
            this.clinicDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTimePickerRegDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.registrarTextBoxPatient = new System.Windows.Forms.TextBox();
            this.registrarTextBoxDoctor = new System.Windows.Forms.TextBox();
            this.searchPanelRegistrar = new System.Windows.Forms.Panel();
            this.registrarSelectDoctorButton = new System.Windows.Forms.Button();
            this.registrarSelectPatientButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registrarSearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.visitTableAdapter1 = new Clinic.clinicDataSet1TableAdapters.VisitTableAdapter();
            this.dataGridViewRegistrar = new System.Windows.Forms.DataGridView();
            this.clinicDataSet11 = new Clinic.clinicDataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource1)).BeginInit();
            this.searchPanelRegistrar.SuspendLayout();
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
            this.registrarModifyButton.Click += new System.EventHandler(this.registrarCancelButton_Click);
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
            this.dataTimePickerRegDate.Location = new System.Drawing.Point(96, 7);
            this.dataTimePickerRegDate.Name = "dataTimePickerRegDate";
            this.dataTimePickerRegDate.Size = new System.Drawing.Size(132, 20);
            this.dataTimePickerRegDate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registration date";
            // 
            // registrarTextBoxPatient
            // 
            this.registrarTextBoxPatient.Location = new System.Drawing.Point(320, 10);
            this.registrarTextBoxPatient.Name = "registrarTextBoxPatient";
            this.registrarTextBoxPatient.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxPatient.TabIndex = 19;
            // 
            // registrarTextBoxDoctor
            // 
            this.registrarTextBoxDoctor.Location = new System.Drawing.Point(320, 59);
            this.registrarTextBoxDoctor.Name = "registrarTextBoxDoctor";
            this.registrarTextBoxDoctor.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxDoctor.TabIndex = 20;
            // 
            // searchPanelRegistrar
            // 
            this.searchPanelRegistrar.AutoScroll = true;
            this.searchPanelRegistrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchPanelRegistrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchPanelRegistrar.Controls.Add(this.registrarSelectDoctorButton);
            this.searchPanelRegistrar.Controls.Add(this.registrarSelectPatientButton);
            this.searchPanelRegistrar.Controls.Add(this.label4);
            this.searchPanelRegistrar.Controls.Add(this.comboBox1);
            this.searchPanelRegistrar.Controls.Add(this.label3);
            this.searchPanelRegistrar.Controls.Add(this.registrarSearchButton);
            this.searchPanelRegistrar.Controls.Add(this.label2);
            this.searchPanelRegistrar.Controls.Add(this.registrarTextBoxDoctor);
            this.searchPanelRegistrar.Controls.Add(this.registrarTextBoxPatient);
            this.searchPanelRegistrar.Controls.Add(this.label1);
            this.searchPanelRegistrar.Controls.Add(this.dataTimePickerRegDate);
            this.searchPanelRegistrar.Location = new System.Drawing.Point(6, 5);
            this.searchPanelRegistrar.Name = "searchPanelRegistrar";
            this.searchPanelRegistrar.Size = new System.Drawing.Size(644, 95);
            this.searchPanelRegistrar.TabIndex = 21;
            // 
            // registrarSelectDoctorButton
            // 
            this.registrarSelectDoctorButton.Location = new System.Drawing.Point(426, 56);
            this.registrarSelectDoctorButton.Name = "registrarSelectDoctorButton";
            this.registrarSelectDoctorButton.Size = new System.Drawing.Size(97, 23);
            this.registrarSelectDoctorButton.TabIndex = 28;
            this.registrarSelectDoctorButton.Text = "Select Doctor";
            this.registrarSelectDoctorButton.UseVisualStyleBackColor = true;
            this.registrarSelectDoctorButton.Click += new System.EventHandler(this.registrarSelectDoctorButton_Click);
            // 
            // registrarSelectPatientButton
            // 
            this.registrarSelectPatientButton.Location = new System.Drawing.Point(426, 10);
            this.registrarSelectPatientButton.Name = "registrarSelectPatientButton";
            this.registrarSelectPatientButton.Size = new System.Drawing.Size(97, 23);
            this.registrarSelectPatientButton.TabIndex = 27;
            this.registrarSelectPatientButton.Text = "Select Patient";
            this.registrarSelectPatientButton.UseVisualStyleBackColor = true;
            this.registrarSelectPatientButton.Click += new System.EventHandler(this.registrarSelectPatientButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "State";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "DONE",
            "CANCEL"});
            this.comboBox1.Location = new System.Drawing.Point(96, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Last name";
            // 
            // registrarSearchButton
            // 
            this.registrarSearchButton.Location = new System.Drawing.Point(562, 59);
            this.registrarSearchButton.Name = "registrarSearchButton";
            this.registrarSearchButton.Size = new System.Drawing.Size(75, 23);
            this.registrarSearchButton.TabIndex = 21;
            this.registrarSearchButton.Text = "Search";
            this.registrarSearchButton.UseVisualStyleBackColor = true;
            this.registrarSearchButton.Click += new System.EventHandler(this.registrarSearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "First name";
            // 
            // visitTableAdapter1
            // 
            this.visitTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewRegistrar
            // 
            this.dataGridViewRegistrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistrar.Location = new System.Drawing.Point(4, 116);
            this.dataGridViewRegistrar.Name = "dataGridViewRegistrar";
            this.dataGridViewRegistrar.Size = new System.Drawing.Size(733, 218);
            this.dataGridViewRegistrar.TabIndex = 22;
            // 
            // clinicDataSet11
            // 
            this.clinicDataSet11.DataSetName = "clinicDataSet1";
            this.clinicDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 355);
            this.Controls.Add(this.dataGridViewRegistrar);
            this.Controls.Add(this.searchPanelRegistrar);
            this.Controls.Add(this.registrarModifyButton);
            this.Controls.Add(this.resgistrarAddVisitButton);
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.Registrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource1)).EndInit();
            this.searchPanelRegistrar.ResumeLayout(false);
            this.searchPanelRegistrar.PerformLayout();
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
        private clinicDataSet1TableAdapters.VisitTableAdapter visitTableAdapter;
        private System.Windows.Forms.BindingSource clinicDataSetBindingSource1;
        private System.Windows.Forms.DateTimePicker dataTimePickerRegDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox registrarTextBoxPatient;
        private System.Windows.Forms.TextBox registrarTextBoxDoctor;
        private System.Windows.Forms.Panel searchPanelRegistrar;
        private System.Windows.Forms.Button registrarSearchButton;
        private clinicDataSet1TableAdapters.VisitTableAdapter visitTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewRegistrar;
        private clinicDataSet1 clinicDataSet11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registrarSelectDoctorButton;
        private System.Windows.Forms.Button registrarSelectPatientButton;
    }
}