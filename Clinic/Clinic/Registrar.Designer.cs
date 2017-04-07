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
            this.visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet1 = new Clinic.clinicDataSet1();
            this.resgistrarAddVisitButton = new System.Windows.Forms.Button();
            this.registrarModifyButton = new System.Windows.Forms.Button();
            this.clinicDataSet = new Clinic.clinicDataSet();
            this.clinicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitTableAdapter = new Clinic.clinicDataSet1TableAdapters.VisitTableAdapter();
            this.clinicDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTimePickerRegDate = new System.Windows.Forms.DateTimePicker();
            this.dataTimePickerEcCancelDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.registrarTextBoxPatient = new System.Windows.Forms.TextBox();
            this.registrarTextBoxDoctor = new System.Windows.Forms.TextBox();
            this.searchPanelRegistrar = new System.Windows.Forms.Panel();
            this.registrarSearchButton = new System.Windows.Forms.Button();
            this.visitTableAdapter1 = new Clinic.clinicDataSet1TableAdapters.VisitTableAdapter();
            this.dataGridViewRegistrar = new System.Windows.Forms.DataGridView();
            this.clinicDataSet11 = new Clinic.clinicDataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource1)).BeginInit();
            this.searchPanelRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet11)).BeginInit();
            this.SuspendLayout();
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
            this.resgistrarAddVisitButton.Location = new System.Drawing.Point(782, 11);
            this.resgistrarAddVisitButton.Name = "resgistrarAddVisitButton";
            this.resgistrarAddVisitButton.Size = new System.Drawing.Size(75, 23);
            this.resgistrarAddVisitButton.TabIndex = 1;
            this.resgistrarAddVisitButton.Text = "Add Visit";
            this.resgistrarAddVisitButton.UseVisualStyleBackColor = true;
            this.resgistrarAddVisitButton.Click += new System.EventHandler(this.resgistrarAddVisitButton_Click);
            // 
            // registrarModifyButton
            // 
            this.registrarModifyButton.Location = new System.Drawing.Point(782, 47);
            this.registrarModifyButton.Name = "registrarModifyButton";
            this.registrarModifyButton.Size = new System.Drawing.Size(75, 23);
            this.registrarModifyButton.TabIndex = 2;
            this.registrarModifyButton.Text = "Modify Visit";
            this.registrarModifyButton.UseVisualStyleBackColor = true;
            this.registrarModifyButton.Click += new System.EventHandler(this.registrarCancelButton_Click);
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
            // dataTimePickerRegDate
            // 
            this.dataTimePickerRegDate.Location = new System.Drawing.Point(21, 7);
            this.dataTimePickerRegDate.Name = "dataTimePickerRegDate";
            this.dataTimePickerRegDate.Size = new System.Drawing.Size(132, 20);
            this.dataTimePickerRegDate.TabIndex = 3;
            // 
            // dataTimePickerEcCancelDate
            // 
            this.dataTimePickerEcCancelDate.Location = new System.Drawing.Point(191, 7);
            this.dataTimePickerEcCancelDate.Name = "dataTimePickerEcCancelDate";
            this.dataTimePickerEcCancelDate.ShowCheckBox = true;
            this.dataTimePickerEcCancelDate.Size = new System.Drawing.Size(158, 20);
            this.dataTimePickerEcCancelDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registration date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Execution, Cancel date";
            // 
            // registrarTextBoxPatient
            // 
            this.registrarTextBoxPatient.Location = new System.Drawing.Point(401, 7);
            this.registrarTextBoxPatient.Name = "registrarTextBoxPatient";
            this.registrarTextBoxPatient.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxPatient.TabIndex = 19;
            this.registrarTextBoxPatient.Click += new System.EventHandler(this.registrarTextBoxPatient_Clicked);
            // 
            // registrarTextBoxDoctor
            // 
            this.registrarTextBoxDoctor.Location = new System.Drawing.Point(542, 7);
            this.registrarTextBoxDoctor.Name = "registrarTextBoxDoctor";
            this.registrarTextBoxDoctor.Size = new System.Drawing.Size(100, 20);
            this.registrarTextBoxDoctor.TabIndex = 20;
            // 
            // searchPanelRegistrar
            // 
            this.searchPanelRegistrar.AutoScroll = true;
            this.searchPanelRegistrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchPanelRegistrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.searchPanelRegistrar.Controls.Add(this.registrarSearchButton);
            this.searchPanelRegistrar.Controls.Add(this.registrarTextBoxDoctor);
            this.searchPanelRegistrar.Controls.Add(this.registrarTextBoxPatient);
            this.searchPanelRegistrar.Controls.Add(this.label2);
            this.searchPanelRegistrar.Controls.Add(this.label1);
            this.searchPanelRegistrar.Controls.Add(this.dataTimePickerEcCancelDate);
            this.searchPanelRegistrar.Controls.Add(this.dataTimePickerRegDate);
            this.searchPanelRegistrar.Location = new System.Drawing.Point(6, 5);
            this.searchPanelRegistrar.Name = "searchPanelRegistrar";
            this.searchPanelRegistrar.Size = new System.Drawing.Size(760, 95);
            this.searchPanelRegistrar.TabIndex = 21;
            // 
            // registrarSearchButton
            // 
            this.registrarSearchButton.Location = new System.Drawing.Point(673, 59);
            this.registrarSearchButton.Name = "registrarSearchButton";
            this.registrarSearchButton.Size = new System.Drawing.Size(75, 23);
            this.registrarSearchButton.TabIndex = 21;
            this.registrarSearchButton.Text = "Search";
            this.registrarSearchButton.UseVisualStyleBackColor = true;
            this.registrarSearchButton.Click += new System.EventHandler(this.registrarSearchButton_Click);
            // 
            // visitTableAdapter1
            // 
            this.visitTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewRegistrar
            // 
            this.dataGridViewRegistrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistrar.Location = new System.Drawing.Point(9, 120);
            this.dataGridViewRegistrar.Name = "dataGridViewRegistrar";
            this.dataGridViewRegistrar.Size = new System.Drawing.Size(756, 218);
            this.dataGridViewRegistrar.TabIndex = 22;
            // 
            // clinicDataSet11
            // 
            this.clinicDataSet11.DataSetName = "clinicDataSet1";
            this.clinicDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 355);
            this.Controls.Add(this.searchPanelRegistrar);
            this.Controls.Add(this.registrarModifyButton);
            this.Controls.Add(this.resgistrarAddVisitButton);
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.Registrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSetBindingSource1)).EndInit();
            this.searchPanelRegistrar.ResumeLayout(false);
            this.searchPanelRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button resgistrarAddVisitButton;
        private System.Windows.Forms.Button registrarModifyButton;
        private clinicDataSet1 clinicDataSet1;
        private System.Windows.Forms.BindingSource clinicDataSetBindingSource;
        private clinicDataSet clinicDataSet;
        private System.Windows.Forms.BindingSource visitBindingSource;
        private clinicDataSet1TableAdapters.VisitTableAdapter visitTableAdapter;
        private System.Windows.Forms.BindingSource clinicDataSetBindingSource1;
        private System.Windows.Forms.DateTimePicker dataTimePickerRegDate;
        private System.Windows.Forms.DateTimePicker dataTimePickerEcCancelDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox registrarTextBoxPatient;
        private System.Windows.Forms.TextBox registrarTextBoxDoctor;
        private System.Windows.Forms.Panel searchPanelRegistrar;
        private System.Windows.Forms.Button registrarSearchButton;
        private clinicDataSet1TableAdapters.VisitTableAdapter visitTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridViewRegistrar;
        private clinicDataSet1 clinicDataSet11;
    }
}