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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.registrarAddPatientButtonCancel = new System.Windows.Forms.Button();
            this.registrarAddPatientButtonApprove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(46, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(46, 54);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
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
            // RegistrarAddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 168);
            this.Controls.Add(this.registrarAddPatientButtonApprove);
            this.Controls.Add(this.registrarAddPatientButtonCancel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(208, 206);
            this.MinimumSize = new System.Drawing.Size(208, 206);
            this.Name = "RegistrarAddPatientForm";
            this.Text = "Add Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button registrarAddPatientButtonCancel;
        private System.Windows.Forms.Button registrarAddPatientButtonApprove;
    }
}