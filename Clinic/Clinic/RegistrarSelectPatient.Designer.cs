namespace Clinic
{
    partial class RegistrarSelectPatient
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.registrarAddPatientButton = new System.Windows.Forms.Button();
            this.registrarSelarchButton = new System.Windows.Forms.Button();
            this.registrarSelectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(267, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // registrarAddPatientButton
            // 
            this.registrarAddPatientButton.Location = new System.Drawing.Point(195, 335);
            this.registrarAddPatientButton.Name = "registrarAddPatientButton";
            this.registrarAddPatientButton.Size = new System.Drawing.Size(75, 23);
            this.registrarAddPatientButton.TabIndex = 24;
            this.registrarAddPatientButton.Text = "Add Patient";
            this.registrarAddPatientButton.UseVisualStyleBackColor = true;
            this.registrarAddPatientButton.Click += new System.EventHandler(this.registrarAddPatientButton_Click);
            // 
            // registrarSelarchButton
            // 
            this.registrarSelarchButton.Location = new System.Drawing.Point(97, 335);
            this.registrarSelarchButton.Name = "registrarSelarchButton";
            this.registrarSelarchButton.Size = new System.Drawing.Size(92, 23);
            this.registrarSelarchButton.TabIndex = 25;
            this.registrarSelarchButton.Text = "Search Patient";
            this.registrarSelarchButton.UseVisualStyleBackColor = true;
            // 
            // registrarSelectButton
            // 
            this.registrarSelectButton.Location = new System.Drawing.Point(12, 335);
            this.registrarSelectButton.Name = "registrarSelectButton";
            this.registrarSelectButton.Size = new System.Drawing.Size(75, 23);
            this.registrarSelectButton.TabIndex = 26;
            this.registrarSelectButton.Text = "Select";
            this.registrarSelectButton.UseVisualStyleBackColor = true;
            // 
            // RegistrarSelectPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 381);
            this.Controls.Add(this.registrarSelectButton);
            this.Controls.Add(this.registrarSelarchButton);
            this.Controls.Add(this.registrarAddPatientButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RegistrarSelectPatient";
            this.Text = "RegistrarSelectPatient";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button registrarAddPatientButton;
        private System.Windows.Forms.Button registrarSelarchButton;
        private System.Windows.Forms.Button registrarSelectButton;
    }
}