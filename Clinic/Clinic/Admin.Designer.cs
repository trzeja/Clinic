namespace Clinic
{
    partial class Admin
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
            this.adminEditButton = new System.Windows.Forms.Button();
            this.adminAddButton = new System.Windows.Forms.Button();
            this.dataGridAdmin = new System.Windows.Forms.DataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet = new Clinic.clinicDataSet();
            this.userTableAdapter = new Clinic.clinicDataSetTableAdapters.UserTableAdapter();
            this.adminDeleteButton = new System.Windows.Forms.Button();
            this.registrarSearchButton = new System.Windows.Forms.Button();
            this.adminTextBoxLastName = new System.Windows.Forms.TextBox();
            this.adminTextBoxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataTimePickerRegDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminEditButton
            // 
            this.adminEditButton.Location = new System.Drawing.Point(535, 309);
            this.adminEditButton.Name = "adminEditButton";
            this.adminEditButton.Size = new System.Drawing.Size(75, 23);
            this.adminEditButton.TabIndex = 2;
            this.adminEditButton.Text = "Edit";
            this.adminEditButton.UseVisualStyleBackColor = true;
            this.adminEditButton.Click += new System.EventHandler(this.adminEditButton_Click);
            // 
            // adminAddButton
            // 
            this.adminAddButton.Location = new System.Drawing.Point(357, 309);
            this.adminAddButton.Name = "adminAddButton";
            this.adminAddButton.Size = new System.Drawing.Size(75, 23);
            this.adminAddButton.TabIndex = 1;
            this.adminAddButton.Text = "Add";
            this.adminAddButton.UseVisualStyleBackColor = true;
            this.adminAddButton.Click += new System.EventHandler(this.adminAddButton_Click);
            // 
            // dataGridAdmin
            // 
            this.dataGridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdmin.Location = new System.Drawing.Point(5, 87);
            this.dataGridAdmin.MultiSelect = false;
            this.dataGridAdmin.Name = "dataGridAdmin";
            this.dataGridAdmin.Size = new System.Drawing.Size(570, 174);
            this.dataGridAdmin.TabIndex = 3;
            this.dataGridAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAdmin_CellContentClick);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.clinicDataSet;
            // 
            // clinicDataSet
            // 
            this.clinicDataSet.DataSetName = "clinicDataSet";
            this.clinicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // adminDeleteButton
            // 
            this.adminDeleteButton.Location = new System.Drawing.Point(445, 309);
            this.adminDeleteButton.Name = "adminDeleteButton";
            this.adminDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.adminDeleteButton.TabIndex = 4;
            this.adminDeleteButton.Text = "Delete";
            this.adminDeleteButton.UseVisualStyleBackColor = true;
            // 
            // registrarSearchButton
            // 
            this.registrarSearchButton.Location = new System.Drawing.Point(492, 49);
            this.registrarSearchButton.Name = "registrarSearchButton";
            this.registrarSearchButton.Size = new System.Drawing.Size(75, 23);
            this.registrarSearchButton.TabIndex = 21;
            this.registrarSearchButton.Text = "Search";
            this.registrarSearchButton.UseVisualStyleBackColor = true;
            this.registrarSearchButton.Click += new System.EventHandler(this.registrarSearchButton_Click);
            // 
            // adminTextBoxLastName
            // 
            this.adminTextBoxLastName.Location = new System.Drawing.Point(302, 49);
            this.adminTextBoxLastName.Name = "adminTextBoxLastName";
            this.adminTextBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxLastName.TabIndex = 20;
            // 
            // adminTextBoxFirstName
            // 
            this.adminTextBoxFirstName.Location = new System.Drawing.Point(302, 9);
            this.adminTextBoxFirstName.Name = "adminTextBoxFirstName";
            this.adminTextBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.adminTextBoxFirstName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Retire date";
            // 
            // dataTimePickerRegDate
            // 
            this.dataTimePickerRegDate.Checked = false;
            this.dataTimePickerRegDate.Location = new System.Drawing.Point(68, 7);
            this.dataTimePickerRegDate.Name = "dataTimePickerRegDate";
            this.dataTimePickerRegDate.ShowCheckBox = true;
            this.dataTimePickerRegDate.Size = new System.Drawing.Size(132, 20);
            this.dataTimePickerRegDate.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.registrarSearchButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.adminTextBoxLastName);
            this.panel1.Controls.Add(this.dataTimePickerRegDate);
            this.panel1.Controls.Add(this.adminTextBoxFirstName);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 78);
            this.panel1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Role";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "First name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 344);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminDeleteButton);
          //  this.Controls.Add(this.dataGridAdmin);
            this.Controls.Add(this.adminEditButton);
            this.Controls.Add(this.adminAddButton);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button adminEditButton;
        private System.Windows.Forms.Button adminAddButton;
        private System.Windows.Forms.DataGridView dataGridAdmin;
        private clinicDataSet clinicDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private clinicDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.Button adminDeleteButton;
        private System.Windows.Forms.Button registrarSearchButton;
        private System.Windows.Forms.TextBox adminTextBoxLastName;
        private System.Windows.Forms.TextBox adminTextBoxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dataTimePickerRegDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}