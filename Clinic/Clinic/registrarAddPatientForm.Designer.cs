namespace Clinic
{
    partial class RegistrarAddPatientForm
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
            this.peselBox = new System.Windows.Forms.TextBox();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.registrarAddPatientButtonCancel = new System.Windows.Forms.Button();
            this.registrarAddPatientButtonApprove = new System.Windows.Forms.Button();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // peselBox
            // 
            this.peselBox.Location = new System.Drawing.Point(46, 12);
            this.peselBox.Name = "peselBox";
            this.peselBox.Size = new System.Drawing.Size(100, 20);
            this.peselBox.TabIndex = 0;
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(46, 54);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(100, 20);
            this.fnameBox.TabIndex = 2;
            // 
            // registrarAddPatientButtonCancel
            // 
            this.registrarAddPatientButtonCancel.Location = new System.Drawing.Point(105, 133);
            this.registrarAddPatientButtonCancel.Name = "registrarAddPatientButtonCancel";
            this.registrarAddPatientButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.registrarAddPatientButtonCancel.TabIndex = 3;
            this.registrarAddPatientButtonCancel.Text = "Cancel";
            this.registrarAddPatientButtonCancel.UseVisualStyleBackColor = true;
            this.registrarAddPatientButtonCancel.Click += new System.EventHandler(this.registrarAddPatientButtonCancel_Click);
            // 
            // registrarAddPatientButtonApprove
            // 
            this.registrarAddPatientButtonApprove.Location = new System.Drawing.Point(12, 133);
            this.registrarAddPatientButtonApprove.Name = "registrarAddPatientButtonApprove";
            this.registrarAddPatientButtonApprove.Size = new System.Drawing.Size(75, 23);
            this.registrarAddPatientButtonApprove.TabIndex = 4;
            this.registrarAddPatientButtonApprove.Text = "Approve";
            this.registrarAddPatientButtonApprove.UseVisualStyleBackColor = true;
            // 
            // lnameBox
            // 
            this.lnameBox.Location = new System.Drawing.Point(46, 94);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(100, 20);
            this.lnameBox.TabIndex = 1;
            // 
            // RegistrarAddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 168);
            this.Controls.Add(this.registrarAddPatientButtonApprove);
            this.Controls.Add(this.registrarAddPatientButtonCancel);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.peselBox);
            this.MaximumSize = new System.Drawing.Size(208, 206);
            this.MinimumSize = new System.Drawing.Size(208, 206);
            this.Name = "RegistrarAddPatientForm";
            this.Text = "Add Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox peselBox;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Button registrarAddPatientButtonCancel;
        private System.Windows.Forms.Button registrarAddPatientButtonApprove;
        private System.Windows.Forms.TextBox lnameBox;
    }
}