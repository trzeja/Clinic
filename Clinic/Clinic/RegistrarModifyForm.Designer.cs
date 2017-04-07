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
            this.registrarCancelButton = new System.Windows.Forms.Button();
            this.registrarApproveButton = new System.Windows.Forms.Button();
            this.registrarTextBoxDoctor = new System.Windows.Forms.TextBox();
            this.registrarTextBoxPatient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataTimePickerRegDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataTimePickerEcCancelDate = new System.Windows.Forms.DateTimePicker();
            this.registrarCancelVisitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registrarCancelButton
            // 
            this.registrarCancelButton.Location = new System.Drawing.Point(113, 189);
            this.registrarCancelButton.Name = "registrarCancelButton";
            this.registrarCancelButton.Size = new System.Drawing.Size(75, 23);
            this.registrarCancelButton.TabIndex = 13;
            this.registrarCancelButton.Text = "Cancel";
            this.registrarCancelButton.UseVisualStyleBackColor = true;
            this.registrarCancelButton.Click += new System.EventHandler(this.registrarCancelButton_Click);
            // 
            // registrarApproveButton
            // 
            this.registrarApproveButton.Location = new System.Drawing.Point(12, 189);
            this.registrarApproveButton.Name = "registrarApproveButton";
            this.registrarApproveButton.Size = new System.Drawing.Size(75, 23);
            this.registrarApproveButton.TabIndex = 12;
            this.registrarApproveButton.Text = "Approve";
            this.registrarApproveButton.UseVisualStyleBackColor = true;
            this.registrarApproveButton.Click += new System.EventHandler(this.registrarApproveButton_Click);
            // 
            // registrarTextBoxDoctor
            // 
            this.registrarTextBoxDoctor.Location = new System.Drawing.Point(50, 154);
            this.registrarTextBoxDoctor.Name = "registrarTextBoxDoctor";
            this.registrarTextBoxDoctor.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxDoctor.TabIndex = 22;
            // 
            // registrarTextBoxPatient
            // 
            this.registrarTextBoxPatient.Location = new System.Drawing.Point(50, 116);
            this.registrarTextBoxPatient.Name = "registrarTextBoxPatient";
            this.registrarTextBoxPatient.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxPatient.TabIndex = 20;
            this.registrarTextBoxPatient.Click += new System.EventHandler(this.registrarTextBoxPatient_Clicked);
            this.registrarTextBoxPatient.TextChanged += new System.EventHandler(this.registrarTextBoxPatient_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Registration date";
            // 
            // dataTimePickerRegDate
            // 
            this.dataTimePickerRegDate.Location = new System.Drawing.Point(34, 12);
            this.dataTimePickerRegDate.Name = "dataTimePickerRegDate";
            this.dataTimePickerRegDate.Size = new System.Drawing.Size(132, 20);
            this.dataTimePickerRegDate.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Execution, Cancel date";
            // 
            // dataTimePickerEcCancelDate
            // 
            this.dataTimePickerEcCancelDate.Location = new System.Drawing.Point(15, 65);
            this.dataTimePickerEcCancelDate.Name = "dataTimePickerEcCancelDate";
            this.dataTimePickerEcCancelDate.ShowCheckBox = true;
            this.dataTimePickerEcCancelDate.Size = new System.Drawing.Size(158, 20);
            this.dataTimePickerEcCancelDate.TabIndex = 26;
            // 
            // registrarCancelVisitButton
            // 
            this.registrarCancelVisitButton.Location = new System.Drawing.Point(63, 228);
            this.registrarCancelVisitButton.Name = "registrarCancelVisitButton";
            this.registrarCancelVisitButton.Size = new System.Drawing.Size(75, 23);
            this.registrarCancelVisitButton.TabIndex = 28;
            this.registrarCancelVisitButton.Text = "Cancel Visit";
            this.registrarCancelVisitButton.UseVisualStyleBackColor = true;
            // 
            // RegistrarAddFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 271);
            this.Controls.Add(this.registrarCancelVisitButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataTimePickerEcCancelDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTimePickerRegDate);
            this.Controls.Add(this.registrarTextBoxDoctor);
            this.Controls.Add(this.registrarTextBoxPatient);
            this.Controls.Add(this.registrarCancelButton);
            this.Controls.Add(this.registrarApproveButton);
            this.Name = "RegistrarAddFrom";
            this.Text = "RegistrarAddFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button registrarCancelButton;
        private System.Windows.Forms.Button registrarApproveButton;
        private System.Windows.Forms.TextBox registrarTextBoxDoctor;
        private System.Windows.Forms.TextBox registrarTextBoxPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dataTimePickerRegDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dataTimePickerEcCancelDate;
        private System.Windows.Forms.Button registrarCancelVisitButton;
    }
}