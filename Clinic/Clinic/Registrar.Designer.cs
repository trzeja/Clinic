namespace Clinic
{
    partial class Registrar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idvisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.executioncanceldatetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idregistrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet1 = new Clinic.clinicDataSet1();
            this.resgistrarAddVisitButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clinicDataSet = new Clinic.clinicDataSet();
            this.clinicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitTableAdapter = new Clinic.clinicDataSet1TableAdapters.VisitTableAdapter();
            this.clinicDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idvisitDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.diagnosisDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.registrationdateDataGridViewTextBoxColumn,
            this.executioncanceldatetimeDataGridViewTextBoxColumn,
            this.idpatientDataGridViewTextBoxColumn,
            this.idregistrationDataGridViewTextBoxColumn,
            this.iddoctorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.visitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 191);
            this.dataGridView1.TabIndex = 0;
            // 
            // idvisitDataGridViewTextBoxColumn
            // 
            this.idvisitDataGridViewTextBoxColumn.DataPropertyName = "id_visit";
            this.idvisitDataGridViewTextBoxColumn.HeaderText = "id_visit";
            this.idvisitDataGridViewTextBoxColumn.Name = "idvisitDataGridViewTextBoxColumn";
            this.idvisitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // diagnosisDataGridViewTextBoxColumn
            // 
            this.diagnosisDataGridViewTextBoxColumn.DataPropertyName = "diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.HeaderText = "diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.Name = "diagnosisDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "state";
            this.stateDataGridViewTextBoxColumn.HeaderText = "state";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // registrationdateDataGridViewTextBoxColumn
            // 
            this.registrationdateDataGridViewTextBoxColumn.DataPropertyName = "registration_date";
            this.registrationdateDataGridViewTextBoxColumn.HeaderText = "registration_date";
            this.registrationdateDataGridViewTextBoxColumn.Name = "registrationdateDataGridViewTextBoxColumn";
            // 
            // executioncanceldatetimeDataGridViewTextBoxColumn
            // 
            this.executioncanceldatetimeDataGridViewTextBoxColumn.DataPropertyName = "execution_cancel_datetime";
            this.executioncanceldatetimeDataGridViewTextBoxColumn.HeaderText = "execution_cancel_datetime";
            this.executioncanceldatetimeDataGridViewTextBoxColumn.Name = "executioncanceldatetimeDataGridViewTextBoxColumn";
            // 
            // idpatientDataGridViewTextBoxColumn
            // 
            this.idpatientDataGridViewTextBoxColumn.DataPropertyName = "id_patient";
            this.idpatientDataGridViewTextBoxColumn.HeaderText = "id_patient";
            this.idpatientDataGridViewTextBoxColumn.Name = "idpatientDataGridViewTextBoxColumn";
            // 
            // idregistrationDataGridViewTextBoxColumn
            // 
            this.idregistrationDataGridViewTextBoxColumn.DataPropertyName = "id_registration";
            this.idregistrationDataGridViewTextBoxColumn.HeaderText = "id_registration";
            this.idregistrationDataGridViewTextBoxColumn.Name = "idregistrationDataGridViewTextBoxColumn";
            // 
            // iddoctorDataGridViewTextBoxColumn
            // 
            this.iddoctorDataGridViewTextBoxColumn.DataPropertyName = "id_doctor";
            this.iddoctorDataGridViewTextBoxColumn.HeaderText = "id_doctor";
            this.iddoctorDataGridViewTextBoxColumn.Name = "iddoctorDataGridViewTextBoxColumn";
            // 
            // visitBindingSource
            // 
            this.visitBindingSource.DataMember = "Visit";
            this.visitBindingSource.DataSource = this.clinicDataSet1;
            // 
            // clinicDataSet1
            // 
            this.clinicDataSet1.DataSetName = "clinicDataSet1";
            this.clinicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resgistrarAddVisitButton
            // 
            this.resgistrarAddVisitButton.Location = new System.Drawing.Point(875, 236);
            this.resgistrarAddVisitButton.Name = "resgistrarAddVisitButton";
            this.resgistrarAddVisitButton.Size = new System.Drawing.Size(75, 23);
            this.resgistrarAddVisitButton.TabIndex = 1;
            this.resgistrarAddVisitButton.Text = "Add Visit";
            this.resgistrarAddVisitButton.UseVisualStyleBackColor = true;
            this.resgistrarAddVisitButton.Click += new System.EventHandler(this.resgistrarAddVisitButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(783, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel Visit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clinicDataSet
            // 
            this.clinicDataSet.DataSetName = "clinicDataSet";
            this.clinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinicDataSetBindingSource
            // 
            this.clinicDataSetBindingSource.DataSource = this.clinicDataSet;
            this.clinicDataSetBindingSource.Position = 0;
            // 
            // visitTableAdapter
            // 
            this.visitTableAdapter.ClearBeforeFill = true;
            // 
            // clinicDataSetBindingSource1
            // 
            this.clinicDataSetBindingSource1.DataSource = this.clinicDataSet;
            this.clinicDataSetBindingSource1.Position = 0;
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resgistrarAddVisitButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.Registrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button resgistrarAddVisitButton;
        private System.Windows.Forms.Button button2;
        private clinicDataSet1 clinicDataSet1;
        private System.Windows.Forms.BindingSource clinicDataSetBindingSource;
        private clinicDataSet clinicDataSet;
        private System.Windows.Forms.BindingSource visitBindingSource;
        private clinicDataSet1TableAdapters.VisitTableAdapter visitTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn executioncanceldatetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idregistrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clinicDataSetBindingSource1;
    }
}