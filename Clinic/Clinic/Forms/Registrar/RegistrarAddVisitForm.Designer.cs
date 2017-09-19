namespace Clinic
{
    partial class RegistrarAddVisitForm
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
            this.RegistrarAddVisitDataGridView = new System.Windows.Forms.DataGridView();
            this.RegistrarAddVisitSearchPanel = new System.Windows.Forms.Panel();
            this.RegistrarAddVisitButton = new System.Windows.Forms.Button();
            this.RegistrarAddVisitModifyPatientButton = new System.Windows.Forms.Button();
            this.panelPatient = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.registrarTextBoxPatientLName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registrarTextBoxPatientFName = new System.Windows.Forms.TextBox();
            this.RegistrarAddVisitSearchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrarAddVisitDataGridView)).BeginInit();
            this.RegistrarAddVisitSearchPanel.SuspendLayout();
            this.panelPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistrarAddVisitDataGridView
            // 
            this.RegistrarAddVisitDataGridView.AllowUserToAddRows = false;
            this.RegistrarAddVisitDataGridView.AllowUserToDeleteRows = false;
            this.RegistrarAddVisitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistrarAddVisitDataGridView.Location = new System.Drawing.Point(12, 138);
            this.RegistrarAddVisitDataGridView.MultiSelect = false;
            this.RegistrarAddVisitDataGridView.Name = "RegistrarAddVisitDataGridView";
            this.RegistrarAddVisitDataGridView.ReadOnly = true;
            this.RegistrarAddVisitDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RegistrarAddVisitDataGridView.Size = new System.Drawing.Size(484, 205);
            this.RegistrarAddVisitDataGridView.TabIndex = 0;
            // 
            // RegistrarAddVisitSearchPanel
            // 
            this.RegistrarAddVisitSearchPanel.AutoScroll = true;
            this.RegistrarAddVisitSearchPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.RegistrarAddVisitSearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RegistrarAddVisitSearchPanel.Controls.Add(this.button1);
            this.RegistrarAddVisitSearchPanel.Controls.Add(this.RegistrarAddVisitButton);
            this.RegistrarAddVisitSearchPanel.Controls.Add(this.RegistrarAddVisitModifyPatientButton);
            this.RegistrarAddVisitSearchPanel.Controls.Add(this.panelPatient);
            this.RegistrarAddVisitSearchPanel.Controls.Add(this.RegistrarAddVisitSearchButton);
            this.RegistrarAddVisitSearchPanel.Location = new System.Drawing.Point(12, 12);
            this.RegistrarAddVisitSearchPanel.Name = "RegistrarAddVisitSearchPanel";
            this.RegistrarAddVisitSearchPanel.Size = new System.Drawing.Size(484, 120);
            this.RegistrarAddVisitSearchPanel.TabIndex = 22;
            // 
            // RegistrarAddVisitButton
            // 
            this.RegistrarAddVisitButton.Location = new System.Drawing.Point(384, 4);
            this.RegistrarAddVisitButton.Name = "RegistrarAddVisitButton";
            this.RegistrarAddVisitButton.Size = new System.Drawing.Size(82, 23);
            this.RegistrarAddVisitButton.TabIndex = 24;
            this.RegistrarAddVisitButton.Text = "Add Visit";
            this.RegistrarAddVisitButton.UseVisualStyleBackColor = true;
            this.RegistrarAddVisitButton.Click += new System.EventHandler(this.resgistrarAddVisitButton_Click);
            // 
            // RegistrarAddVisitModifyPatientButton
            // 
            this.RegistrarAddVisitModifyPatientButton.Location = new System.Drawing.Point(384, 33);
            this.RegistrarAddVisitModifyPatientButton.Name = "RegistrarAddVisitModifyPatientButton";
            this.RegistrarAddVisitModifyPatientButton.Size = new System.Drawing.Size(82, 23);
            this.RegistrarAddVisitModifyPatientButton.TabIndex = 25;
            this.RegistrarAddVisitModifyPatientButton.Text = "Modify Patient";
            this.RegistrarAddVisitModifyPatientButton.UseVisualStyleBackColor = true;
            this.RegistrarAddVisitModifyPatientButton.Click += new System.EventHandler(this.registrarModifyPatientButton_Click);
            // 
            // panelPatient
            // 
            this.panelPatient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPatient.Controls.Add(this.label7);
            this.panelPatient.Controls.Add(this.registrarTextBoxPatientLName);
            this.panelPatient.Controls.Add(this.label6);
            this.panelPatient.Controls.Add(this.label2);
            this.panelPatient.Controls.Add(this.registrarTextBoxPatientFName);
            this.panelPatient.Location = new System.Drawing.Point(3, 3);
            this.panelPatient.Name = "panelPatient";
            this.panelPatient.Size = new System.Drawing.Size(375, 88);
            this.panelPatient.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(172, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Patient";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // registrarTextBoxPatientLName
            // 
            this.registrarTextBoxPatientLName.Location = new System.Drawing.Point(260, 43);
            this.registrarTextBoxPatientLName.Name = "registrarTextBoxPatientLName";
            this.registrarTextBoxPatientLName.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxPatientLName.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Last name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "First name:";
            // 
            // registrarTextBoxPatientFName
            // 
            this.registrarTextBoxPatientFName.Location = new System.Drawing.Point(76, 43);
            this.registrarTextBoxPatientFName.Name = "registrarTextBoxPatientFName";
            this.registrarTextBoxPatientFName.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxPatientFName.TabIndex = 19;
            // 
            // RegistrarAddVisitSearchButton
            // 
            this.RegistrarAddVisitSearchButton.Location = new System.Drawing.Point(384, 90);
            this.RegistrarAddVisitSearchButton.Name = "RegistrarAddVisitSearchButton";
            this.RegistrarAddVisitSearchButton.Size = new System.Drawing.Size(82, 23);
            this.RegistrarAddVisitSearchButton.TabIndex = 21;
            this.RegistrarAddVisitSearchButton.Text = "Search";
            this.RegistrarAddVisitSearchButton.UseVisualStyleBackColor = true;
            this.RegistrarAddVisitSearchButton.Click += new System.EventHandler(this.RegistrarAddVisitSearchButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Add Patient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrarAddVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 355);
            this.Controls.Add(this.RegistrarAddVisitSearchPanel);
            this.Controls.Add(this.RegistrarAddVisitDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegistrarAddVisitForm";
            this.Text = "Add Visit";
            ((System.ComponentModel.ISupportInitialize)(this.RegistrarAddVisitDataGridView)).EndInit();
            this.RegistrarAddVisitSearchPanel.ResumeLayout(false);
            this.panelPatient.ResumeLayout(false);
            this.panelPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RegistrarAddVisitDataGridView;
        private System.Windows.Forms.Panel RegistrarAddVisitSearchPanel;
        private System.Windows.Forms.Panel panelPatient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox registrarTextBoxPatientLName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox registrarTextBoxPatientFName;
        private System.Windows.Forms.Button RegistrarAddVisitSearchButton;
        private System.Windows.Forms.Button RegistrarAddVisitModifyPatientButton;
        private System.Windows.Forms.Button RegistrarAddVisitButton;
        private System.Windows.Forms.Button button1;
    }
}