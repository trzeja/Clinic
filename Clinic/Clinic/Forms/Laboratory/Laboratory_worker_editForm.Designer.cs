namespace Clinic
{
    partial class Laboratory_worker_editForm
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
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labWorkerComboboxState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labWorkerEConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(98, 69);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(174, 98);
            this.resultTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Results";
            // 
            // labWorkerComboboxState
            // 
            this.labWorkerComboboxState.FormattingEnabled = true;
            this.labWorkerComboboxState.Items.AddRange(new object[] {
            "DONE",
            "CANCEL"});
            this.labWorkerComboboxState.Location = new System.Drawing.Point(98, 26);
            this.labWorkerComboboxState.Name = "labWorkerComboboxState";
            this.labWorkerComboboxState.Size = new System.Drawing.Size(121, 21);
            this.labWorkerComboboxState.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Change state";
            // 
            // labWorkerEConfirmButton
            // 
            this.labWorkerEConfirmButton.Location = new System.Drawing.Point(197, 185);
            this.labWorkerEConfirmButton.Name = "labWorkerEConfirmButton";
            this.labWorkerEConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.labWorkerEConfirmButton.TabIndex = 15;
            this.labWorkerEConfirmButton.Text = "Confirm";
            this.labWorkerEConfirmButton.UseVisualStyleBackColor = true;
            this.labWorkerEConfirmButton.Click += new System.EventHandler(this.labWorkerEConfirmButton_Click);
            // 
            // Laboratory_worker_editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 225);
            this.Controls.Add(this.labWorkerEConfirmButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labWorkerComboboxState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resultTextBox);
            this.Name = "Laboratory_worker_editForm";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox labWorkerComboboxState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button labWorkerEConfirmButton;
    }
}