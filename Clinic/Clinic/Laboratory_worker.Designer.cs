namespace Clinic
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
            this.labWorkerToDoButton = new System.Windows.Forms.Button();
            this.labWorkerShowButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labWorkerCancelButton
            // 
            this.labWorkerCancelButton.Location = new System.Drawing.Point(222, 172);
            this.labWorkerCancelButton.Name = "labWorkerCancelButton";
            this.labWorkerCancelButton.Size = new System.Drawing.Size(79, 23);
            this.labWorkerCancelButton.TabIndex = 0;
            this.labWorkerCancelButton.Text = "Cancel";
            this.labWorkerCancelButton.UseVisualStyleBackColor = true;
            this.labWorkerCancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // labWorkerApproveButton
            // 
            this.labWorkerApproveButton.Location = new System.Drawing.Point(307, 172);
            this.labWorkerApproveButton.Name = "labWorkerApproveButton";
            this.labWorkerApproveButton.Size = new System.Drawing.Size(79, 23);
            this.labWorkerApproveButton.TabIndex = 1;
            this.labWorkerApproveButton.Text = "Approve";
            this.labWorkerApproveButton.UseVisualStyleBackColor = true;
            // 
            // labWorkerToDoButton
            // 
            this.labWorkerToDoButton.Location = new System.Drawing.Point(392, 172);
            this.labWorkerToDoButton.Name = "labWorkerToDoButton";
            this.labWorkerToDoButton.Size = new System.Drawing.Size(79, 23);
            this.labWorkerToDoButton.TabIndex = 2;
            this.labWorkerToDoButton.Text = "Only to do";
            this.labWorkerToDoButton.UseVisualStyleBackColor = true;
            // 
            // labWorkerShowButton
            // 
            this.labWorkerShowButton.Location = new System.Drawing.Point(477, 172);
            this.labWorkerShowButton.Name = "labWorkerShowButton";
            this.labWorkerShowButton.Size = new System.Drawing.Size(79, 23);
            this.labWorkerShowButton.TabIndex = 3;
            this.labWorkerShowButton.Text = "Show records";
            this.labWorkerShowButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 160);
            this.dataGridView1.TabIndex = 4;
            // 
            // Laboratory_worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 207);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labWorkerShowButton);
            this.Controls.Add(this.labWorkerToDoButton);
            this.Controls.Add(this.labWorkerApproveButton);
            this.Controls.Add(this.labWorkerCancelButton);
            this.Name = "Laboratory_worker";
            this.Text = "Laboratory_worker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button labWorkerCancelButton;
        private System.Windows.Forms.Button labWorkerApproveButton;
        private System.Windows.Forms.Button labWorkerToDoButton;
        private System.Windows.Forms.Button labWorkerShowButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}