﻿namespace Clinic
{
    partial class Laboratory_worker
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
            this.labWorkerCancelButton = new System.Windows.Forms.Button();
            this.labWorkerApproveButton = new System.Windows.Forms.Button();
            this.labWorkerShowButton = new System.Windows.Forms.Button();
            this.LabWorkerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.selectOrderDateLabel = new System.Windows.Forms.Label();
            this.dataTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridLabWorker = new System.Windows.Forms.DataGridView();
            this.LabWorkerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLabWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // labWorkerCancelButton
            // 
            this.labWorkerCancelButton.Location = new System.Drawing.Point(153, 278);
            this.labWorkerCancelButton.Name = "labWorkerCancelButton";
            this.labWorkerCancelButton.Size = new System.Drawing.Size(79, 23);
            this.labWorkerCancelButton.TabIndex = 0;
            this.labWorkerCancelButton.Text = "Cancel";
            this.labWorkerCancelButton.UseVisualStyleBackColor = true;
            this.labWorkerCancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // labWorkerApproveButton
            // 
            this.labWorkerApproveButton.Location = new System.Drawing.Point(34, 278);
            this.labWorkerApproveButton.Name = "labWorkerApproveButton";
            this.labWorkerApproveButton.Size = new System.Drawing.Size(79, 23);
            this.labWorkerApproveButton.TabIndex = 1;
            this.labWorkerApproveButton.Text = "Approve";
            this.labWorkerApproveButton.UseVisualStyleBackColor = true;
            this.labWorkerApproveButton.Click += new System.EventHandler(this.labWorkerApproveButton_Click);
            // 
            // labWorkerShowButton
            // 
            this.labWorkerShowButton.Location = new System.Drawing.Point(365, 6);
            this.labWorkerShowButton.Name = "labWorkerShowButton";
            this.labWorkerShowButton.Size = new System.Drawing.Size(79, 23);
            this.labWorkerShowButton.TabIndex = 3;
            this.labWorkerShowButton.Text = "Show records";
            this.labWorkerShowButton.UseVisualStyleBackColor = true;
            this.labWorkerShowButton.Click += new System.EventHandler(this.labWorkerShowButton_Click);
            // 
            // LabWorkerPanel
            // 
            this.LabWorkerPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LabWorkerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabWorkerPanel.Controls.Add(this.label1);
            this.LabWorkerPanel.Controls.Add(this.comboBox1);
            this.LabWorkerPanel.Controls.Add(this.labWorkerShowButton);
            this.LabWorkerPanel.Controls.Add(this.selectOrderDateLabel);
            this.LabWorkerPanel.Controls.Add(this.dataTimePickerOrderDate);
            this.LabWorkerPanel.Location = new System.Drawing.Point(6, 6);
            this.LabWorkerPanel.Name = "LabWorkerPanel";
            this.LabWorkerPanel.Size = new System.Drawing.Size(460, 48);
            this.LabWorkerPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "State of execution";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Done",
            "ORD"});
            this.comboBox1.Location = new System.Drawing.Point(192, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // selectOrderDateLabel
            // 
            this.selectOrderDateLabel.AutoSize = true;
            this.selectOrderDateLabel.Location = new System.Drawing.Point(33, 27);
            this.selectOrderDateLabel.Name = "selectOrderDateLabel";
            this.selectOrderDateLabel.Size = new System.Drawing.Size(88, 13);
            this.selectOrderDateLabel.TabIndex = 6;
            this.selectOrderDateLabel.Text = "Select order date";
            // 
            // dataTimePickerOrderDate
            // 
            this.dataTimePickerOrderDate.Location = new System.Drawing.Point(4, 4);
            this.dataTimePickerOrderDate.Name = "dataTimePickerOrderDate";
            this.dataTimePickerOrderDate.ShowCheckBox = true;
            this.dataTimePickerOrderDate.Size = new System.Drawing.Size(158, 20);
            this.dataTimePickerOrderDate.TabIndex = 5;
            // 
            // dataGridLabWorker
            // 
            this.dataGridLabWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLabWorker.Location = new System.Drawing.Point(6, 84);
            this.dataGridLabWorker.Name = "dataGridLabWorker";
            this.dataGridLabWorker.Size = new System.Drawing.Size(460, 96);
            this.dataGridLabWorker.TabIndex = 5;
            // 
            // Laboratory_worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 304);
            this.Controls.Add(this.labWorkerApproveButton);
            this.Controls.Add(this.labWorkerCancelButton);
            this.Controls.Add(this.LabWorkerPanel);
            this.Name = "Laboratory_worker";
            this.Text = "Laboratory_worker";
            this.LabWorkerPanel.ResumeLayout(false);
            this.LabWorkerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLabWorker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button labWorkerCancelButton;
        private System.Windows.Forms.Button labWorkerApproveButton;
        private System.Windows.Forms.Button labWorkerShowButton;
        private System.Windows.Forms.Panel LabWorkerPanel;
        private System.Windows.Forms.Label selectOrderDateLabel;
        private System.Windows.Forms.DateTimePicker dataTimePickerOrderDate;
        private System.Windows.Forms.DataGridView dataGridLabWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}