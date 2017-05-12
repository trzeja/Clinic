namespace Clinic
{
    partial class SelectPersonForm
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
            this.registrarAddButton = new System.Windows.Forms.Button();
            this.registrarSearchButton = new System.Windows.Forms.Button();
            this.registrarSelectButton = new System.Windows.Forms.Button();
            this.patientTableAdapter1 = new Clinic.clinicDataSet1TableAdapters.PatientTableAdapter();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.lnameTextbox = new System.Windows.Forms.TextBox();
            this.fnameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // registrarAddButton
            // 
            this.registrarAddButton.Location = new System.Drawing.Point(218, 323);
            this.registrarAddButton.Name = "registrarAddButton";
            this.registrarAddButton.Size = new System.Drawing.Size(75, 23);
            this.registrarAddButton.TabIndex = 24;
            this.registrarAddButton.Text = "Add";
            this.registrarAddButton.UseVisualStyleBackColor = true;
            this.registrarAddButton.Click += new System.EventHandler(this.registrarAddPatientButton_Click);
            // 
            // registrarSearchButton
            // 
            this.registrarSearchButton.Location = new System.Drawing.Point(211, 52);
            this.registrarSearchButton.Name = "registrarSearchButton";
            this.registrarSearchButton.Size = new System.Drawing.Size(68, 23);
            this.registrarSearchButton.TabIndex = 25;
            this.registrarSearchButton.Text = "Search";
            this.registrarSearchButton.UseVisualStyleBackColor = true;
            // 
            // registrarSelectButton
            // 
            this.registrarSelectButton.Location = new System.Drawing.Point(124, 323);
            this.registrarSelectButton.Name = "registrarSelectButton";
            this.registrarSelectButton.Size = new System.Drawing.Size(75, 23);
            this.registrarSelectButton.TabIndex = 26;
            this.registrarSelectButton.Text = "Select";
            this.registrarSelectButton.UseVisualStyleBackColor = true;
            // 
            // patientTableAdapter1
            // 
            this.patientTableAdapter1.ClearBeforeFill = true;
            // 
            // searchPanel
            // 
            this.searchPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPanel.Controls.Add(this.label3);
            this.searchPanel.Controls.Add(this.label2);
            this.searchPanel.Controls.Add(this.lnameTextbox);
            this.searchPanel.Controls.Add(this.fnameTextbox);
            this.searchPanel.Controls.Add(this.registrarSearchButton);
            this.searchPanel.Location = new System.Drawing.Point(9, 1);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(284, 80);
            this.searchPanel.TabIndex = 27;
            // 
            // lnameTextbox
            // 
            this.lnameTextbox.Location = new System.Drawing.Point(101, 36);
            this.lnameTextbox.Name = "lnameTextbox";
            this.lnameTextbox.Size = new System.Drawing.Size(100, 20);
            this.lnameTextbox.TabIndex = 27;
            // 
            // fnameTextbox
            // 
            this.fnameTextbox.Location = new System.Drawing.Point(101, 10);
            this.fnameTextbox.Name = "fnameTextbox";
            this.fnameTextbox.Size = new System.Drawing.Size(100, 20);
            this.fnameTextbox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Last name";
            // 
            // SelectPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 360);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.registrarSelectButton);
            this.Controls.Add(this.registrarAddButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SelectPersonForm";
            this.Text = "Select Person";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button registrarAddButton;
        private System.Windows.Forms.Button registrarSearchButton;
        private System.Windows.Forms.Button registrarSelectButton;
        private clinicDataSet1TableAdapters.PatientTableAdapter patientTableAdapter1;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox lnameTextbox;
        private System.Windows.Forms.TextBox fnameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}