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
            this.adminSearchButton = new System.Windows.Forms.Button();
            this.dataGridAdmin = new System.Windows.Forms.DataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet = new Clinic.clinicDataSet();
            this.userTableAdapter = new Clinic.clinicDataSetTableAdapters.UserTableAdapter();
            this.adminDeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // adminEditButton
            // 
            this.adminEditButton.Location = new System.Drawing.Point(568, 236);
            this.adminEditButton.Name = "adminEditButton";
            this.adminEditButton.Size = new System.Drawing.Size(75, 23);
            this.adminEditButton.TabIndex = 2;
            this.adminEditButton.Text = "Edit";
            this.adminEditButton.UseVisualStyleBackColor = true;
            this.adminEditButton.Click += new System.EventHandler(this.adminEditButton_Click);
            // 
            // adminSearchButton
            // 
            this.adminSearchButton.Location = new System.Drawing.Point(406, 236);
            this.adminSearchButton.Name = "adminSearchButton";
            this.adminSearchButton.Size = new System.Drawing.Size(75, 23);
            this.adminSearchButton.TabIndex = 1;
            this.adminSearchButton.Text = "Search";
            this.adminSearchButton.UseVisualStyleBackColor = true;
            this.adminSearchButton.Click += new System.EventHandler(this.adminSearchButton_Click);
            // 
            // dataGridAdmin
            // 
            this.dataGridAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdmin.Location = new System.Drawing.Point(2, 3);
            this.dataGridAdmin.MultiSelect = false;
            this.dataGridAdmin.Name = "dataGridAdmin";
            this.dataGridAdmin.Size = new System.Drawing.Size(641, 174);
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
            this.adminDeleteButton.Location = new System.Drawing.Point(487, 236);
            this.adminDeleteButton.Name = "adminDeleteButton";
            this.adminDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.adminDeleteButton.TabIndex = 4;
            this.adminDeleteButton.Text = "Delete";
            this.adminDeleteButton.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 262);
            this.Controls.Add(this.adminDeleteButton);
            this.Controls.Add(this.dataGridAdmin);
            this.Controls.Add(this.adminEditButton);
            this.Controls.Add(this.adminSearchButton);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button adminEditButton;
        private System.Windows.Forms.Button adminSearchButton;
        private System.Windows.Forms.DataGridView dataGridAdmin;
        private clinicDataSet clinicDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private clinicDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.Button adminDeleteButton;
    }
}