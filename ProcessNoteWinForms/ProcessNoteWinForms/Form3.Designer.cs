namespace ProcessNoteWinForms
{
    partial class Form3
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
            this.newProcessLabel = new System.Windows.Forms.Label();
            this.newProcessNameTextBox = new System.Windows.Forms.TextBox();
            this.openNewProcessButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.invalidProcessLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newProcessLabel
            // 
            this.newProcessLabel.AutoSize = true;
            this.newProcessLabel.Location = new System.Drawing.Point(16, 44);
            this.newProcessLabel.Name = "newProcessLabel";
            this.newProcessLabel.Size = new System.Drawing.Size(80, 13);
            this.newProcessLabel.TabIndex = 0;
            this.newProcessLabel.Text = "Process name: ";
            // 
            // newProcessNameTextBox
            // 
            this.newProcessNameTextBox.Location = new System.Drawing.Point(102, 41);
            this.newProcessNameTextBox.Name = "newProcessNameTextBox";
            this.newProcessNameTextBox.Size = new System.Drawing.Size(257, 20);
            this.newProcessNameTextBox.TabIndex = 1;
            this.newProcessNameTextBox.TextChanged += new System.EventHandler(this.newProcessNameTextBox_TextChanged);
            // 
            // openNewProcessButton
            // 
            this.openNewProcessButton.Enabled = false;
            this.openNewProcessButton.Location = new System.Drawing.Point(284, 98);
            this.openNewProcessButton.Name = "openNewProcessButton";
            this.openNewProcessButton.Size = new System.Drawing.Size(75, 23);
            this.openNewProcessButton.TabIndex = 2;
            this.openNewProcessButton.Text = "Open";
            this.openNewProcessButton.UseVisualStyleBackColor = true;
            this.openNewProcessButton.Click += new System.EventHandler(this.openNewProcessButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(203, 98);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // invalidProcessLabel
            // 
            this.invalidProcessLabel.AutoSize = true;
            this.invalidProcessLabel.Location = new System.Drawing.Point(249, 64);
            this.invalidProcessLabel.Name = "invalidProcessLabel";
            this.invalidProcessLabel.Size = new System.Drawing.Size(110, 13);
            this.invalidProcessLabel.TabIndex = 4;
            this.invalidProcessLabel.Text = "Invalid process name!";
            this.invalidProcessLabel.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 133);
            this.Controls.Add(this.invalidProcessLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.openNewProcessButton);
            this.Controls.Add(this.newProcessNameTextBox);
            this.Controls.Add(this.newProcessLabel);
            this.Name = "Form3";
            this.Text = "Form3";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newProcessLabel;
        private System.Windows.Forms.TextBox newProcessNameTextBox;
        private System.Windows.Forms.Button openNewProcessButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label invalidProcessLabel;
    }
}