namespace ProcessNoteWinForms
{
    partial class Form2
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
            this.threadDataGridView = new System.Windows.Forms.DataGridView();
            this.OKButton = new System.Windows.Forms.Button();
            this.threadId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.threadTotalProcessorTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.threadBasePriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.threadCurrentPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.threadDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // threadDataGridView
            // 
            this.threadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.threadDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.threadId,
            this.threadTotalProcessorTime,
            this.threadBasePriority,
            this.threadCurrentPriority});
            this.threadDataGridView.Location = new System.Drawing.Point(32, 12);
            this.threadDataGridView.Name = "threadDataGridView";
            this.threadDataGridView.Size = new System.Drawing.Size(460, 150);
            this.threadDataGridView.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(417, 185);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // threadId
            // 
            this.threadId.HeaderText = "Thread Id";
            this.threadId.Name = "threadId";
            this.threadId.ReadOnly = true;
            // 
            // threadTotalProcessorTime
            // 
            this.threadTotalProcessorTime.HeaderText = "Processor Time";
            this.threadTotalProcessorTime.Name = "threadTotalProcessorTime";
            this.threadTotalProcessorTime.ReadOnly = true;
            this.threadTotalProcessorTime.Width = 120;
            // 
            // threadBasePriority
            // 
            this.threadBasePriority.HeaderText = "Base Priority";
            this.threadBasePriority.Name = "threadBasePriority";
            this.threadBasePriority.ReadOnly = true;
            // 
            // threadCurrentPriority
            // 
            this.threadCurrentPriority.HeaderText = "Current Priority";
            this.threadCurrentPriority.Name = "threadCurrentPriority";
            this.threadCurrentPriority.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 220);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.threadDataGridView);
            this.Name = "Form2";
            this.Text = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.threadDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView threadDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn threadId;
        private System.Windows.Forms.DataGridViewTextBoxColumn threadTotalProcessorTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn threadBasePriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn threadCurrentPriority;
        private System.Windows.Forms.Button OKButton;
    }
}