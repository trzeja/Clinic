namespace Clinic
{
    partial class Doctor
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
            this.doctorSearchPanel = new System.Windows.Forms.Panel();
            this.doctorTextBoxPatient = new System.Windows.Forms.TextBox();
            this.doctorSearchButton = new System.Windows.Forms.Button();
            this.doctorDateTimePickerExecDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clinicDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet1 = new Clinic.clinicDataSet1();
            this.doctorSelectVisitbutton = new System.Windows.Forms.Button();
            this.doctorSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // doctorSearchPanel
            // 
            this.doctorSearchPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.doctorSearchPanel.Controls.Add(this.doctorTextBoxPatient);
            this.doctorSearchPanel.Controls.Add(this.doctorSearchButton);
            this.doctorSearchPanel.Controls.Add(this.doctorDateTimePickerExecDate);
            this.doctorSearchPanel.Location = new System.Drawing.Point(3, 7);
            this.doctorSearchPanel.Name = "doctorSearchPanel";
            this.doctorSearchPanel.Size = new System.Drawing.Size(640, 44);
            this.doctorSearchPanel.TabIndex = 0;
            // 
            // doctorTextBoxPatient
            // 
            this.doctorTextBoxPatient.Location = new System.Drawing.Point(19, 9);
            this.doctorTextBoxPatient.Name = "doctorTextBoxPatient";
            this.doctorTextBoxPatient.Size = new System.Drawing.Size(100, 20);
            this.doctorTextBoxPatient.TabIndex = 6;
            this.doctorTextBoxPatient.Click += new System.EventHandler(this.doctorTextBoxPatient_Click);
            this.doctorTextBoxPatient.Enter += new System.EventHandler(this.doctorTextBoxPatient_Enter);
            this.doctorTextBoxPatient.Leave += new System.EventHandler(this.doctorTextBoxPatient_Leave);
            // 
            // doctorSearchButton
            // 
            this.doctorSearchButton.Location = new System.Drawing.Point(547, 10);
            this.doctorSearchButton.Name = "doctorSearchButton";
            this.doctorSearchButton.Size = new System.Drawing.Size(75, 23);
            this.doctorSearchButton.TabIndex = 5;
            this.doctorSearchButton.Text = "Search";
            this.doctorSearchButton.UseVisualStyleBackColor = true;
            this.doctorSearchButton.Click += new System.EventHandler(this.doctorSearchButton_Click);
            // 
            // doctorDateTimePickerExecDate
            // 
            this.doctorDateTimePickerExecDate.Location = new System.Drawing.Point(226, 9);
            this.doctorDateTimePickerExecDate.Name = "doctorDateTimePickerExecDate";
            this.doctorDateTimePickerExecDate.ShowCheckBox = true;
            this.doctorDateTimePickerExecDate.Size = new System.Drawing.Size(216, 20);
            this.doctorDateTimePickerExecDate.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.clinicDataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(640, 276);
            this.dataGridView1.TabIndex = 1;
            // 
            // clinicDataSet1BindingSource
            // 
            this.clinicDataSet1BindingSource.DataSource = this.clinicDataSet1;
            this.clinicDataSet1BindingSource.Position = 0;
            // 
            // clinicDataSet1
            // 
            this.clinicDataSet1.DataSetName = "clinicDataSet1";
            this.clinicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorSelectVisitbutton
            // 
            this.doctorSelectVisitbutton.Location = new System.Drawing.Point(550, 347);
            this.doctorSelectVisitbutton.Name = "doctorSelectVisitbutton";
            this.doctorSelectVisitbutton.Size = new System.Drawing.Size(75, 23);
            this.doctorSelectVisitbutton.TabIndex = 2;
            this.doctorSelectVisitbutton.Text = "Select Visit";
            this.doctorSelectVisitbutton.UseVisualStyleBackColor = true;
            this.doctorSelectVisitbutton.Click += new System.EventHandler(this.doctorSelectVisitbutton_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 382);
            this.Controls.Add(this.doctorSelectVisitbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.doctorSearchPanel);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.doctorSearchPanel.ResumeLayout(false);
            this.doctorSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel doctorSearchPanel;
        private System.Windows.Forms.DateTimePicker doctorDateTimePickerExecDate;
        private System.Windows.Forms.Button doctorSearchButton;
        private System.Windows.Forms.TextBox doctorTextBoxPatient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource clinicDataSet1BindingSource;
        private clinicDataSet1 clinicDataSet1;
        private System.Windows.Forms.Button doctorSelectVisitbutton;
    }
}