namespace Clinic
{
    partial class RegistrarMainForm
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
            this.RegistratarMainFromPanel = new System.Windows.Forms.Panel();
            this.RegistratarMainFormManageVisitsButton = new System.Windows.Forms.Button();
            this.RegistratarMainFormAddVisitButton = new System.Windows.Forms.Button();
            this.RegistratarMainFromPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistratarMainFromPanel
            // 
            this.RegistratarMainFromPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RegistratarMainFromPanel.Controls.Add(this.RegistratarMainFormManageVisitsButton);
            this.RegistratarMainFromPanel.Controls.Add(this.RegistratarMainFormAddVisitButton);
            this.RegistratarMainFromPanel.Location = new System.Drawing.Point(12, 12);
            this.RegistratarMainFromPanel.Name = "RegistratarMainFromPanel";
            this.RegistratarMainFromPanel.Size = new System.Drawing.Size(260, 237);
            this.RegistratarMainFromPanel.TabIndex = 0;
            // 
            // RegistratarMainFormManageVisitsButton
            // 
            this.RegistratarMainFormManageVisitsButton.Location = new System.Drawing.Point(49, 138);
            this.RegistratarMainFormManageVisitsButton.Name = "RegistratarMainFormManageVisitsButton";
            this.RegistratarMainFormManageVisitsButton.Size = new System.Drawing.Size(165, 47);
            this.RegistratarMainFormManageVisitsButton.TabIndex = 1;
            this.RegistratarMainFormManageVisitsButton.Text = "Manage visits ...";
            this.RegistratarMainFormManageVisitsButton.UseVisualStyleBackColor = true;
            this.RegistratarMainFormManageVisitsButton.Click += new System.EventHandler(this.RegistratarMainFormManageVisitsButton_Click);
            // 
            // RegistratarMainFormAddVisitButton
            // 
            this.RegistratarMainFormAddVisitButton.Location = new System.Drawing.Point(49, 34);
            this.RegistratarMainFormAddVisitButton.Name = "RegistratarMainFormAddVisitButton";
            this.RegistratarMainFormAddVisitButton.Size = new System.Drawing.Size(165, 47);
            this.RegistratarMainFormAddVisitButton.TabIndex = 0;
            this.RegistratarMainFormAddVisitButton.Text = "Add visit ...";
            this.RegistratarMainFormAddVisitButton.UseVisualStyleBackColor = true;
            this.RegistratarMainFormAddVisitButton.Click += new System.EventHandler(this.RegistratarMainFormAddVisitButton_Click);
            // 
            // RegistrarMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.RegistratarMainFromPanel);
            this.MaximizeBox = false;
            this.Name = "RegistrarMainForm";
            this.Text = "Registratar";
            this.RegistratarMainFromPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RegistratarMainFromPanel;
        private System.Windows.Forms.Button RegistratarMainFormAddVisitButton;
        private System.Windows.Forms.Button RegistratarMainFormManageVisitsButton;
    }
}