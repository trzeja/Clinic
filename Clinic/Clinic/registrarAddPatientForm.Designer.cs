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
            this.registrarAddPatientButtonApprove = new System.Windows.Forms.Button();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // peselBox
            // 
            this.peselBox.Location = new System.Drawing.Point(81, 9);
            this.peselBox.Name = "peselBox";
            this.peselBox.Size = new System.Drawing.Size(100, 20);
            this.peselBox.TabIndex = 0;
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(81, 51);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(100, 20);
            this.fnameBox.TabIndex = 2;
            // 
            // registrarAddPatientButtonApprove
            // 
            this.registrarAddPatientButtonApprove.Location = new System.Drawing.Point(118, 133);
            this.registrarAddPatientButtonApprove.Name = "registrarAddPatientButtonApprove";
            this.registrarAddPatientButtonApprove.Size = new System.Drawing.Size(75, 23);
            this.registrarAddPatientButtonApprove.TabIndex = 4;
            this.registrarAddPatientButtonApprove.Text = "Add Patient";
            this.registrarAddPatientButtonApprove.UseVisualStyleBackColor = true;
            this.registrarAddPatientButtonApprove.Click += new System.EventHandler(this.registrarAddPatientButtonApprove_Click);
            // 
            // lnameBox
            // 
            this.lnameBox.Location = new System.Drawing.Point(81, 94);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(100, 20);
            this.lnameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PESEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // RegistrarAddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 168);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrarAddPatientButtonApprove);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.peselBox);
            this.MaximumSize = new System.Drawing.Size(408, 206);
            this.MinimumSize = new System.Drawing.Size(208, 206);
            this.Name = "RegistrarAddPatientForm";
            this.Text = "Add Patient";
            this.Load += new System.EventHandler(this.RegistrarAddPatientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox peselBox;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Button registrarAddPatientButtonApprove;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}