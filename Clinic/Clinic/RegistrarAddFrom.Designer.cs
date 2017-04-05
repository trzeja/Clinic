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
            this.registrarTextBoxExCancelDate = new System.Windows.Forms.TextBox();
            this.registrarTextBoxRegDate = new System.Windows.Forms.TextBox();
            this.registrarTextBoxState = new System.Windows.Forms.TextBox();
            this.registrarTextBoxDiagnosis = new System.Windows.Forms.TextBox();
            this.registrarTextBoxDescription = new System.Windows.Forms.TextBox();
            this.registrarTextBoxIDVisit = new System.Windows.Forms.TextBox();
            this.registrarCancelButton = new System.Windows.Forms.Button();
            this.registrarApproveButton = new System.Windows.Forms.Button();
            this.registrarTextBoxIDPatient = new System.Windows.Forms.TextBox();
            this.registrarTextBoxIDRegistration = new System.Windows.Forms.TextBox();
            this.registrarTextBoxIDDoctor = new System.Windows.Forms.TextBox();
            this.registrarAddPatientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registrarTextBoxExCancelDate
            // 
            this.registrarTextBoxExCancelDate.Location = new System.Drawing.Point(50, 200);
            this.registrarTextBoxExCancelDate.Name = "registrarTextBoxExCancelDate";
            this.registrarTextBoxExCancelDate.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxExCancelDate.TabIndex = 19;
            // 
            // registrarTextBoxRegDate
            // 
            this.registrarTextBoxRegDate.Location = new System.Drawing.Point(50, 163);
            this.registrarTextBoxRegDate.Name = "registrarTextBoxRegDate";
            this.registrarTextBoxRegDate.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxRegDate.TabIndex = 18;
            // 
            // registrarTextBoxState
            // 
            this.registrarTextBoxState.Location = new System.Drawing.Point(50, 128);
            this.registrarTextBoxState.Name = "registrarTextBoxState";
            this.registrarTextBoxState.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxState.TabIndex = 17;
            // 
            // registrarTextBoxDiagnosis
            // 
            this.registrarTextBoxDiagnosis.Location = new System.Drawing.Point(50, 89);
            this.registrarTextBoxDiagnosis.Name = "registrarTextBoxDiagnosis";
            this.registrarTextBoxDiagnosis.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxDiagnosis.TabIndex = 16;
            // 
            // registrarTextBoxDescription
            // 
            this.registrarTextBoxDescription.Location = new System.Drawing.Point(50, 53);
            this.registrarTextBoxDescription.Name = "registrarTextBoxDescription";
            this.registrarTextBoxDescription.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxDescription.TabIndex = 15;
            // 
            // registrarTextBoxIDVisit
            // 
            this.registrarTextBoxIDVisit.Location = new System.Drawing.Point(50, 13);
            this.registrarTextBoxIDVisit.Name = "registrarTextBoxIDVisit";
            this.registrarTextBoxIDVisit.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxIDVisit.TabIndex = 14;
            // 
            // registrarCancelButton
            // 
            this.registrarCancelButton.Location = new System.Drawing.Point(101, 355);
            this.registrarCancelButton.Name = "registrarCancelButton";
            this.registrarCancelButton.Size = new System.Drawing.Size(75, 23);
            this.registrarCancelButton.TabIndex = 13;
            this.registrarCancelButton.Text = "Cancel";
            this.registrarCancelButton.UseVisualStyleBackColor = true;
            this.registrarCancelButton.Click += new System.EventHandler(this.registrarCancelButton_Click);
            // 
            // registrarApproveButton
            // 
            this.registrarApproveButton.Location = new System.Drawing.Point(16, 355);
            this.registrarApproveButton.Name = "registrarApproveButton";
            this.registrarApproveButton.Size = new System.Drawing.Size(75, 23);
            this.registrarApproveButton.TabIndex = 12;
            this.registrarApproveButton.Text = "Approve";
            this.registrarApproveButton.UseVisualStyleBackColor = true;
            // 
            // registrarTextBoxIDPatient
            // 
            this.registrarTextBoxIDPatient.Location = new System.Drawing.Point(50, 239);
            this.registrarTextBoxIDPatient.Name = "registrarTextBoxIDPatient";
            this.registrarTextBoxIDPatient.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxIDPatient.TabIndex = 20;
            // 
            // registrarTextBoxIDRegistration
            // 
            this.registrarTextBoxIDRegistration.Location = new System.Drawing.Point(50, 278);
            this.registrarTextBoxIDRegistration.Name = "registrarTextBoxIDRegistration";
            this.registrarTextBoxIDRegistration.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxIDRegistration.TabIndex = 21;
            // 
            // registrarTextBoxIDDoctor
            // 
            this.registrarTextBoxIDDoctor.Location = new System.Drawing.Point(50, 316);
            this.registrarTextBoxIDDoctor.Name = "registrarTextBoxIDDoctor";
            this.registrarTextBoxIDDoctor.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxIDDoctor.TabIndex = 22;
            // 
            // registrarAddPatientButton
            // 
            this.registrarAddPatientButton.Location = new System.Drawing.Point(61, 384);
            this.registrarAddPatientButton.Name = "registrarAddPatientButton";
            this.registrarAddPatientButton.Size = new System.Drawing.Size(75, 23);
            this.registrarAddPatientButton.TabIndex = 23;
            this.registrarAddPatientButton.Text = "Add Patient";
            this.registrarAddPatientButton.UseVisualStyleBackColor = true;
            // 
            // RegistrarAddFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 433);
            this.Controls.Add(this.registrarAddPatientButton);
            this.Controls.Add(this.registrarTextBoxIDDoctor);
            this.Controls.Add(this.registrarTextBoxIDRegistration);
            this.Controls.Add(this.registrarTextBoxIDPatient);
            this.Controls.Add(this.registrarTextBoxExCancelDate);
            this.Controls.Add(this.registrarTextBoxRegDate);
            this.Controls.Add(this.registrarTextBoxState);
            this.Controls.Add(this.registrarTextBoxDiagnosis);
            this.Controls.Add(this.registrarTextBoxDescription);
            this.Controls.Add(this.registrarTextBoxIDVisit);
            this.Controls.Add(this.registrarCancelButton);
            this.Controls.Add(this.registrarApproveButton);
            this.Name = "RegistrarAddFrom";
            this.Text = "RegistrarAddFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox registrarTextBoxExCancelDate;
        private System.Windows.Forms.TextBox registrarTextBoxRegDate;
        private System.Windows.Forms.TextBox registrarTextBoxState;
        private System.Windows.Forms.TextBox registrarTextBoxDiagnosis;
        private System.Windows.Forms.TextBox registrarTextBoxDescription;
        private System.Windows.Forms.TextBox registrarTextBoxIDVisit;
        private System.Windows.Forms.Button registrarCancelButton;
        private System.Windows.Forms.Button registrarApproveButton;
        private System.Windows.Forms.TextBox registrarTextBoxIDPatient;
        private System.Windows.Forms.TextBox registrarTextBoxIDRegistration;
        private System.Windows.Forms.TextBox registrarTextBoxIDDoctor;
        private System.Windows.Forms.Button registrarAddPatientButton;
    }
}