﻿namespace Clinic
{
    partial class Laboratory_manager_editForm
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
            this.labManagerComboboxState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labManagerEConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labManagerComboboxState
            // 
            this.labManagerComboboxState.FormattingEnabled = true;
            this.labManagerComboboxState.Items.AddRange(new object[] {
            "APPROVE",
            "CANCEL"});
            this.labManagerComboboxState.Location = new System.Drawing.Point(112, 24);
            this.labManagerComboboxState.Name = "labManagerComboboxState";
            this.labManagerComboboxState.Size = new System.Drawing.Size(121, 21);
            this.labManagerComboboxState.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Change state";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 98);
            this.textBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Comment";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labManagerEConfirmButton
            // 
            this.labManagerEConfirmButton.Location = new System.Drawing.Point(234, 188);
            this.labManagerEConfirmButton.Name = "labManagerEConfirmButton";
            this.labManagerEConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.labManagerEConfirmButton.TabIndex = 12;
            this.labManagerEConfirmButton.Text = "Confirm";
            this.labManagerEConfirmButton.UseVisualStyleBackColor = true;
            this.labManagerEConfirmButton.Click += new System.EventHandler(this.labManagerEConfirmButton_Click);
            // 
            // Laboratory_manager_editForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 221);
            this.Controls.Add(this.labManagerEConfirmButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labManagerComboboxState);
            this.Name = "Laboratory_manager_editForm";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox labManagerComboboxState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button labManagerEConfirmButton;
    }
}