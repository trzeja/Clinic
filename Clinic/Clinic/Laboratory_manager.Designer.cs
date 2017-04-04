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
            this.labManApproveButton = new System.Windows.Forms.Button();
            this.labManCancelButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labManApproveButton
            // 
            this.labManApproveButton.Location = new System.Drawing.Point(360, 311);
            this.labManApproveButton.Name = "labManApproveButton";
            this.labManApproveButton.Size = new System.Drawing.Size(75, 23);
            this.labManApproveButton.TabIndex = 1;
            this.labManApproveButton.Text = "Approve";
            this.labManApproveButton.UseVisualStyleBackColor = true;
            // 
            // labManCancelButton
            // 
            this.labManCancelButton.Location = new System.Drawing.Point(279, 311);
            this.labManCancelButton.Name = "labManCancelButton";
            this.labManCancelButton.Size = new System.Drawing.Size(75, 23);
            this.labManCancelButton.TabIndex = 2;
            this.labManCancelButton.Text = "Cancel";
            this.labManCancelButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 279);
            this.dataGridView1.TabIndex = 3;
            // 
            // Laboratory_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 346);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labManCancelButton);
            this.Controls.Add(this.labManApproveButton);
            this.Name = "Laboratory_manager";
            this.Text = "Laboratory_manager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button labManApproveButton;
        private System.Windows.Forms.Button labManCancelButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}