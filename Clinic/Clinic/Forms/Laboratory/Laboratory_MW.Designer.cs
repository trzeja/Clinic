namespace Clinic
{
    partial class Laboratory_MW
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
            this.labMWComboboxState = new System.Windows.Forms.ComboBox();
            this.labMWShowButton = new System.Windows.Forms.Button();
            this.selectOrderDateLabel = new System.Windows.Forms.Label();
            this.labMWDataTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.labMWDataGridView = new System.Windows.Forms.DataGridView();
            this.labMWEditButton = new System.Windows.Forms.Button();
            this.LabWorkerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labMWDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LabWorkerPanel
            // 
            this.LabWorkerPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LabWorkerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabWorkerPanel.Controls.Add(this.label1);
            this.LabWorkerPanel.Controls.Add(this.labMWComboboxState);
            this.LabWorkerPanel.Controls.Add(this.labMWShowButton);
            this.LabWorkerPanel.Controls.Add(this.selectOrderDateLabel);
            this.LabWorkerPanel.Controls.Add(this.labMWDataTimePickerOrderDate);
            this.LabWorkerPanel.Location = new System.Drawing.Point(16, 2);
            this.LabWorkerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LabWorkerPanel.Name = "LabWorkerPanel";
            this.LabWorkerPanel.Size = new System.Drawing.Size(592, 100);
            this.LabWorkerPanel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "State of execution :";
            // 
            // labMWComboboxState
            // 
            this.labMWComboboxState.FormattingEnabled = true;
            this.labMWComboboxState.Items.AddRange(new object[] {
            "",
            "ORD",
            "DONE",
            "APP",
            "CANC_LABW",
            "CANC_LABM"});
            this.labMWComboboxState.Location = new System.Drawing.Point(171, 12);
            this.labMWComboboxState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labMWComboboxState.Name = "labMWComboboxState";
            this.labMWComboboxState.Size = new System.Drawing.Size(160, 24);
            this.labMWComboboxState.TabIndex = 7;
            // 
            // labMWShowButton
            // 
            this.labMWShowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.labMWShowButton.Location = new System.Drawing.Point(445, 50);
            this.labMWShowButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labMWShowButton.Name = "labMWShowButton";
            this.labMWShowButton.Size = new System.Drawing.Size(105, 31);
            this.labMWShowButton.TabIndex = 3;
            this.labMWShowButton.Text = "Show records";
            this.labMWShowButton.UseVisualStyleBackColor = true;
            this.labMWShowButton.Click += new System.EventHandler(this.labManagerShowButton_Click);
            // 
            // selectOrderDateLabel
            // 
            this.selectOrderDateLabel.AutoSize = true;
            this.selectOrderDateLabel.Location = new System.Drawing.Point(79, 62);
            this.selectOrderDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectOrderDateLabel.Name = "selectOrderDateLabel";
            this.selectOrderDateLabel.Size = new System.Drawing.Size(85, 17);
            this.selectOrderDateLabel.TabIndex = 6;
            this.selectOrderDateLabel.Text = "Order date :";
            // 
            // labMWDataTimePickerOrderDate
            // 
            this.labMWDataTimePickerOrderDate.CustomFormat = "dddd, dd.MM.yyyyr.";
            this.labMWDataTimePickerOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labMWDataTimePickerOrderDate.Location = new System.Drawing.Point(171, 53);
            this.labMWDataTimePickerOrderDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labMWDataTimePickerOrderDate.Name = "labMWDataTimePickerOrderDate";
            this.labMWDataTimePickerOrderDate.ShowCheckBox = true;
            this.labMWDataTimePickerOrderDate.Size = new System.Drawing.Size(237, 23);
            this.labMWDataTimePickerOrderDate.TabIndex = 5;
            // 
            // labMWDataGridView
            // 
            this.labMWDataGridView.AllowUserToAddRows = false;
            this.labMWDataGridView.AllowUserToDeleteRows = false;
            this.labMWDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labMWDataGridView.Location = new System.Drawing.Point(16, 111);
            this.labMWDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labMWDataGridView.MultiSelect = false;
            this.labMWDataGridView.Name = "labMWDataGridView";
            this.labMWDataGridView.ReadOnly = true;
            this.labMWDataGridView.RowTemplate.ReadOnly = true;
            this.labMWDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.labMWDataGridView.Size = new System.Drawing.Size(593, 618);
            this.labMWDataGridView.TabIndex = 10;
            // 
            // labMWEditButton
            // 
            this.labMWEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.labMWEditButton.Location = new System.Drawing.Point(464, 736);
            this.labMWEditButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labMWEditButton.Name = "labMWEditButton";
            this.labMWEditButton.Size = new System.Drawing.Size(105, 28);
            this.labMWEditButton.TabIndex = 10;
            this.labMWEditButton.Text = "Edit";
            this.labMWEditButton.UseVisualStyleBackColor = true;
            this.labMWEditButton.Click += new System.EventHandler(this.labManagerEditButton_Click);
            // 
            // Laboratory_MW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 779);
            this.Controls.Add(this.labMWDataGridView);
            this.Controls.Add(this.labMWEditButton);
            this.Controls.Add(this.LabWorkerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(641, 974);
            this.MinimumSize = new System.Drawing.Size(641, 482);
            this.Name = "Laboratory_MW";
            this.Text = "Laboratory manager/worker";
            this.Resize += new System.EventHandler(this.Laboratory_MW_Resize);
            this.LabWorkerPanel.ResumeLayout(false);
            this.LabWorkerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labMWDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LabWorkerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox labMWComboboxState;
        private System.Windows.Forms.Button labMWShowButton;
        private System.Windows.Forms.Label selectOrderDateLabel;
        private System.Windows.Forms.DateTimePicker labMWDataTimePickerOrderDate;
        private System.Windows.Forms.DataGridView labMWDataGridView;
        private System.Windows.Forms.Button labMWEditButton;
    }
}