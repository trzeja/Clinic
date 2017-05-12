namespace Clinic
{
    partial class Laboratory_manager
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
            this.LabWorkerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labManagerComboboxState = new System.Windows.Forms.ComboBox();
            this.labManagerShowButton = new System.Windows.Forms.Button();
            this.selectOrderDateLabel = new System.Windows.Forms.Label();
            this.dataTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewLabManager = new System.Windows.Forms.DataGridView();
            this.labManagerEditButton = new System.Windows.Forms.Button();
            this.LabWorkerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLabManager)).BeginInit();
            this.SuspendLayout();
            // 
            // LabWorkerPanel
            // 
            this.LabWorkerPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LabWorkerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabWorkerPanel.Controls.Add(this.label1);
            this.LabWorkerPanel.Controls.Add(this.labManagerComboboxState);
            this.LabWorkerPanel.Controls.Add(this.labManagerShowButton);
            this.LabWorkerPanel.Controls.Add(this.selectOrderDateLabel);
            this.LabWorkerPanel.Controls.Add(this.dataTimePickerOrderDate);
            this.LabWorkerPanel.Location = new System.Drawing.Point(12, 2);
            this.LabWorkerPanel.Name = "LabWorkerPanel";
            this.LabWorkerPanel.Size = new System.Drawing.Size(422, 48);
            this.LabWorkerPanel.TabIndex = 9;
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
            // labManagerComboboxState
            // 
            this.labManagerComboboxState.FormattingEnabled = true;
            this.labManagerComboboxState.Items.AddRange(new object[] {
            "DONE",
            "APPROVE",
            "CANCEL"});
            this.labManagerComboboxState.Location = new System.Drawing.Point(192, 6);
            this.labManagerComboboxState.Name = "labManagerComboboxState";
            this.labManagerComboboxState.Size = new System.Drawing.Size(121, 21);
            this.labManagerComboboxState.TabIndex = 7;
            // 
            // labManagerShowButton
            // 
            this.labManagerShowButton.Location = new System.Drawing.Point(332, 5);
            this.labManagerShowButton.Name = "labManagerShowButton";
            this.labManagerShowButton.Size = new System.Drawing.Size(79, 23);
            this.labManagerShowButton.TabIndex = 3;
            this.labManagerShowButton.Text = "Show records";
            this.labManagerShowButton.UseVisualStyleBackColor = true;
            this.labManagerShowButton.Click += new System.EventHandler(this.labManagerShowButton_Click);
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
            // dataGridViewLabManager
            // 
            this.dataGridViewLabManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLabManager.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewLabManager.Name = "dataGridViewLabManager";
            this.dataGridViewLabManager.Size = new System.Drawing.Size(422, 222);
            this.dataGridViewLabManager.TabIndex = 10;
            // 
            // labManagerEditButton
            // 
            this.labManagerEditButton.Location = new System.Drawing.Point(384, 311);
            this.labManagerEditButton.Name = "labManagerEditButton";
            this.labManagerEditButton.Size = new System.Drawing.Size(75, 23);
            this.labManagerEditButton.TabIndex = 10;
            this.labManagerEditButton.Text = "Edit";
            this.labManagerEditButton.UseVisualStyleBackColor = true;
            this.labManagerEditButton.Click += new System.EventHandler(this.labManagerEditButton_Click);
            // 
            // Laboratory_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 346);
            this.Controls.Add(this.dataGridViewLabManager);
            this.Controls.Add(this.labManagerEditButton);
            this.Controls.Add(this.LabWorkerPanel);
            this.Name = "Laboratory_manager";
            this.Text = "Laboratory_manager";
            this.LabWorkerPanel.ResumeLayout(false);
            this.LabWorkerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLabManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LabWorkerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox labManagerComboboxState;
        private System.Windows.Forms.Button labManagerShowButton;
        private System.Windows.Forms.Label selectOrderDateLabel;
        private System.Windows.Forms.DateTimePicker dataTimePickerOrderDate;
        private System.Windows.Forms.DataGridView dataGridViewLabManager;
        private System.Windows.Forms.Button labManagerEditButton;
    }
}