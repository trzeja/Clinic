namespace Clinic
{
    partial class RegistrarAddFrom
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
            this.registrarApproveButton = new System.Windows.Forms.Button();
            this.registrarTextBoxDoctor = new System.Windows.Forms.TextBox();
            this.registrarTextBoxPatient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataTimePickerRegDate = new System.Windows.Forms.DateTimePicker();
            this.registrarCancelVisitButton = new System.Windows.Forms.Button();
            this.patientTableAdapter1 = new Clinic.clinicDataSet1TableAdapters.PatientTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.registrarSelectPatientButton = new System.Windows.Forms.Button();
            this.registrarSelectDoctorButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrarApproveButton
            // 
            this.registrarApproveButton.Location = new System.Drawing.Point(300, 217);
            this.registrarApproveButton.Name = "registrarApproveButton";
            this.registrarApproveButton.Size = new System.Drawing.Size(75, 23);
            this.registrarApproveButton.TabIndex = 12;
            this.registrarApproveButton.Text = "Confirm";
            this.registrarApproveButton.UseVisualStyleBackColor = true;
            this.registrarApproveButton.Click += new System.EventHandler(this.registrarApproveButton_Click);
            // 
            // registrarTextBoxDoctor
            // 
            this.registrarTextBoxDoctor.Location = new System.Drawing.Point(108, 103);
            this.registrarTextBoxDoctor.Name = "registrarTextBoxDoctor";
            this.registrarTextBoxDoctor.Size = new System.Drawing.Size(132, 20);
            this.registrarTextBoxDoctor.TabIndex = 22;
            // 
            // registrarTextBoxPatient
            // 
            this.registrarTextBoxPatient.Location = new System.Drawing.Point(109, 59);
            this.registrarTextBoxPatient.Name = "registrarTextBoxPatient";
            this.registrarTextBoxPatient.Size = new System.Drawing.Size(132, 20);
            this.registrarTextBoxPatient.TabIndex = 20;
            this.registrarTextBoxPatient.TextChanged += new System.EventHandler(this.registrarTextBoxPatient_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Registration date";
            // 
            // dataTimePickerRegDate
            // 
            this.dataTimePickerRegDate.Location = new System.Drawing.Point(109, 9);
            this.dataTimePickerRegDate.Name = "dataTimePickerRegDate";
            this.dataTimePickerRegDate.Size = new System.Drawing.Size(132, 20);
            this.dataTimePickerRegDate.TabIndex = 24;
            // 
            // registrarCancelVisitButton
            // 
            this.registrarCancelVisitButton.Location = new System.Drawing.Point(247, 144);
            this.registrarCancelVisitButton.Name = "registrarCancelVisitButton";
            this.registrarCancelVisitButton.Size = new System.Drawing.Size(75, 23);
            this.registrarCancelVisitButton.TabIndex = 28;
            this.registrarCancelVisitButton.Text = "Cancel Visit";
            this.registrarCancelVisitButton.UseVisualStyleBackColor = true;
            // 
            // patientTableAdapter1
            // 
            this.patientTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Patient name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Doctor name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "State";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.registrarSelectDoctorButton);
            this.panel1.Controls.Add(this.registrarCancelVisitButton);
            this.panel1.Controls.Add(this.registrarSelectPatientButton);
            this.panel1.Controls.Add(this.textBoxState);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataTimePickerRegDate);
            this.panel1.Controls.Add(this.registrarTextBoxDoctor);
            this.panel1.Controls.Add(this.registrarTextBoxPatient);
            this.panel1.Location = new System.Drawing.Point(7, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 201);
            this.panel1.TabIndex = 34;
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(108, 141);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(132, 20);
            this.textBoxState.TabIndex = 34;
            // 
            // registrarSelectPatientButton
            // 
            this.registrarSelectPatientButton.Location = new System.Drawing.Point(247, 59);
            this.registrarSelectPatientButton.Name = "registrarSelectPatientButton";
            this.registrarSelectPatientButton.Size = new System.Drawing.Size(75, 23);
            this.registrarSelectPatientButton.TabIndex = 35;
            this.registrarSelectPatientButton.Text = "Select";
            this.registrarSelectPatientButton.UseVisualStyleBackColor = true;
            this.registrarSelectPatientButton.Click += new System.EventHandler(this.registrarSelectPatientButton_Click);
            // 
            // registrarSelectDoctorButton
            // 
            this.registrarSelectDoctorButton.Location = new System.Drawing.Point(247, 103);
            this.registrarSelectDoctorButton.Name = "registrarSelectDoctorButton";
            this.registrarSelectDoctorButton.Size = new System.Drawing.Size(75, 23);
            this.registrarSelectDoctorButton.TabIndex = 36;
            this.registrarSelectDoctorButton.Text = "Select";
            this.registrarSelectDoctorButton.UseVisualStyleBackColor = true;
            this.registrarSelectDoctorButton.Click += new System.EventHandler(this.registrarSelectDoctorButton_Click);
            // 
            // RegistrarAddFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 252);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.registrarApproveButton);
            this.Name = "RegistrarAddFrom";
            this.Text = "Change";
            this.Load += new System.EventHandler(this.RegistrarAddFrom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button registrarApproveButton;
        private System.Windows.Forms.TextBox registrarTextBoxDoctor;
        private System.Windows.Forms.TextBox registrarTextBoxPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dataTimePickerRegDate;
        private System.Windows.Forms.Button registrarCancelVisitButton;
        private clinicDataSet1TableAdapters.PatientTableAdapter patientTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Button registrarSelectDoctorButton;
        private System.Windows.Forms.Button registrarSelectPatientButton;
    }
}