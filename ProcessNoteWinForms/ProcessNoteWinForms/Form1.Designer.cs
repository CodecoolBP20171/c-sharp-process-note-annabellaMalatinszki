namespace ProcessNoteWinForms
{
    partial class Form1
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
            this.processListLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.processDataGrid = new System.Windows.Forms.DataGridView();
            this.processId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.commentsPanel = new System.Windows.Forms.Panel();
            this.commentLabel = new System.Windows.Forms.Label();
            this.commentContentLabel = new System.Windows.Forms.Label();
            this.startTimeContentLabel = new System.Windows.Forms.Label();
            this.runningTimeContentLabel = new System.Windows.Forms.Label();
            this.memoryContentLabel = new System.Windows.Forms.Label();
            this.cpuContentLabel = new System.Windows.Forms.Label();
            this.nameContentLabel = new System.Windows.Forms.Label();
            this.idContentLabel = new System.Windows.Forms.Label();
            this.threadButton = new System.Windows.Forms.Button();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.runningTimeLabel = new System.Windows.Forms.Label();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.commentButton = new System.Windows.Forms.Button();
            this.newCommentPanel = new System.Windows.Forms.Panel();
            this.saveCommentButton = new System.Windows.Forms.Button();
            this.newCommentTextBox = new System.Windows.Forms.RichTextBox();
            this.detailsLabel = new System.Windows.Forms.Label();
            this.alwaysOnTopCheck = new System.Windows.Forms.CheckBox();
            this.closeWindowButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.prettyButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.processDataGrid)).BeginInit();
            this.detailsPanel.SuspendLayout();
            this.commentsPanel.SuspendLayout();
            this.newCommentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // processListLabel
            // 
            this.processListLabel.AutoSize = true;
            this.processListLabel.Location = new System.Drawing.Point(25, 36);
            this.processListLabel.Name = "processListLabel";
            this.processListLabel.Size = new System.Drawing.Size(143, 13);
            this.processListLabel.TabIndex = 1;
            this.processListLabel.Text = "Currenctly running processes";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(155, 393);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(101, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close Process";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // processDataGrid
            // 
            this.processDataGrid.AccessibleName = "processDataGrid";
            this.processDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.processDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processId,
            this.processName});
            this.processDataGrid.Location = new System.Drawing.Point(28, 53);
            this.processDataGrid.Name = "processDataGrid";
            this.processDataGrid.Size = new System.Drawing.Size(369, 419);
            this.processDataGrid.TabIndex = 4;
            this.processDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.processDataGrid_CellContentClick);
            // 
            // processId
            // 
            this.processId.HeaderText = "Process Id";
            this.processId.Name = "processId";
            this.processId.ReadOnly = true;
            // 
            // processName
            // 
            this.processName.HeaderText = "Process Name";
            this.processName.Name = "processName";
            this.processName.ReadOnly = true;
            this.processName.Width = 200;
            // 
            // detailsPanel
            // 
            this.detailsPanel.Controls.Add(this.commentsPanel);
            this.detailsPanel.Controls.Add(this.startTimeContentLabel);
            this.detailsPanel.Controls.Add(this.runningTimeContentLabel);
            this.detailsPanel.Controls.Add(this.memoryContentLabel);
            this.detailsPanel.Controls.Add(this.cpuContentLabel);
            this.detailsPanel.Controls.Add(this.nameContentLabel);
            this.detailsPanel.Controls.Add(this.idContentLabel);
            this.detailsPanel.Controls.Add(this.threadButton);
            this.detailsPanel.Controls.Add(this.startTimeLabel);
            this.detailsPanel.Controls.Add(this.runningTimeLabel);
            this.detailsPanel.Controls.Add(this.memoryLabel);
            this.detailsPanel.Controls.Add(this.cpuLabel);
            this.detailsPanel.Controls.Add(this.nameLabel);
            this.detailsPanel.Controls.Add(this.idLabel);
            this.detailsPanel.Controls.Add(this.commentButton);
            this.detailsPanel.Controls.Add(this.newCommentPanel);
            this.detailsPanel.Controls.Add(this.closeButton);
            this.detailsPanel.Controls.Add(this.detailsLabel);
            this.detailsPanel.Location = new System.Drawing.Point(415, 53);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(270, 419);
            this.detailsPanel.TabIndex = 5;
            this.detailsPanel.Visible = false;
            // 
            // commentsPanel
            // 
            this.commentsPanel.Controls.Add(this.commentLabel);
            this.commentsPanel.Controls.Add(this.commentContentLabel);
            this.commentsPanel.Location = new System.Drawing.Point(3, 159);
            this.commentsPanel.Name = "commentsPanel";
            this.commentsPanel.Size = new System.Drawing.Size(253, 134);
            this.commentsPanel.TabIndex = 20;
            this.commentsPanel.Visible = false;
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Location = new System.Drawing.Point(6, 9);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(56, 13);
            this.commentLabel.TabIndex = 21;
            this.commentLabel.Text = "Comments";
            // 
            // commentContentLabel
            // 
            this.commentContentLabel.AutoSize = true;
            this.commentContentLabel.Location = new System.Drawing.Point(12, 22);
            this.commentContentLabel.Name = "commentContentLabel";
            this.commentContentLabel.Size = new System.Drawing.Size(35, 13);
            this.commentContentLabel.TabIndex = 20;
            this.commentContentLabel.Text = "label1";
            // 
            // startTimeContentLabel
            // 
            this.startTimeContentLabel.AutoSize = true;
            this.startTimeContentLabel.Location = new System.Drawing.Point(93, 90);
            this.startTimeContentLabel.Name = "startTimeContentLabel";
            this.startTimeContentLabel.Size = new System.Drawing.Size(35, 13);
            this.startTimeContentLabel.TabIndex = 26;
            this.startTimeContentLabel.Text = "label6";
            // 
            // runningTimeContentLabel
            // 
            this.runningTimeContentLabel.AutoSize = true;
            this.runningTimeContentLabel.Location = new System.Drawing.Point(93, 77);
            this.runningTimeContentLabel.Name = "runningTimeContentLabel";
            this.runningTimeContentLabel.Size = new System.Drawing.Size(35, 13);
            this.runningTimeContentLabel.TabIndex = 25;
            this.runningTimeContentLabel.Text = "label5";
            // 
            // memoryContentLabel
            // 
            this.memoryContentLabel.AutoSize = true;
            this.memoryContentLabel.Location = new System.Drawing.Point(93, 64);
            this.memoryContentLabel.Name = "memoryContentLabel";
            this.memoryContentLabel.Size = new System.Drawing.Size(35, 13);
            this.memoryContentLabel.TabIndex = 24;
            this.memoryContentLabel.Text = "label4";
            // 
            // cpuContentLabel
            // 
            this.cpuContentLabel.AutoSize = true;
            this.cpuContentLabel.Location = new System.Drawing.Point(93, 51);
            this.cpuContentLabel.Name = "cpuContentLabel";
            this.cpuContentLabel.Size = new System.Drawing.Size(35, 13);
            this.cpuContentLabel.TabIndex = 23;
            this.cpuContentLabel.Text = "label3";
            // 
            // nameContentLabel
            // 
            this.nameContentLabel.AutoSize = true;
            this.nameContentLabel.Location = new System.Drawing.Point(93, 38);
            this.nameContentLabel.Name = "nameContentLabel";
            this.nameContentLabel.Size = new System.Drawing.Size(35, 13);
            this.nameContentLabel.TabIndex = 22;
            this.nameContentLabel.Text = "label2";
            // 
            // idContentLabel
            // 
            this.idContentLabel.AutoSize = true;
            this.idContentLabel.Location = new System.Drawing.Point(93, 25);
            this.idContentLabel.Name = "idContentLabel";
            this.idContentLabel.Size = new System.Drawing.Size(35, 13);
            this.idContentLabel.TabIndex = 21;
            this.idContentLabel.Text = "label1";
            // 
            // threadButton
            // 
            this.threadButton.Location = new System.Drawing.Point(9, 393);
            this.threadButton.Name = "threadButton";
            this.threadButton.Size = new System.Drawing.Size(96, 23);
            this.threadButton.TabIndex = 18;
            this.threadButton.Text = "Show Threads";
            this.threadButton.UseVisualStyleBackColor = true;
            this.threadButton.Click += new System.EventHandler(this.threadButton_Click);
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Location = new System.Drawing.Point(9, 90);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(61, 13);
            this.startTimeLabel.TabIndex = 15;
            this.startTimeLabel.Text = "Start Time: ";
            // 
            // runningTimeLabel
            // 
            this.runningTimeLabel.AutoSize = true;
            this.runningTimeLabel.Location = new System.Drawing.Point(9, 77);
            this.runningTimeLabel.Name = "runningTimeLabel";
            this.runningTimeLabel.Size = new System.Drawing.Size(79, 13);
            this.runningTimeLabel.TabIndex = 14;
            this.runningTimeLabel.Text = "Running Time: ";
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Location = new System.Drawing.Point(9, 64);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(84, 13);
            this.memoryLabel.TabIndex = 13;
            this.memoryLabel.Text = "Memory Usage: ";
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cpuLabel.Location = new System.Drawing.Point(9, 51);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(67, 13);
            this.cpuLabel.TabIndex = 12;
            this.cpuLabel.Text = "CPU usage: ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(9, 38);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 11;
            this.nameLabel.Text = "Name: ";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.idLabel.Location = new System.Drawing.Point(9, 25);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 13);
            this.idLabel.TabIndex = 10;
            this.idLabel.Text = "Id:";
            // 
            // commentButton
            // 
            this.commentButton.Location = new System.Drawing.Point(178, 130);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(75, 23);
            this.commentButton.TabIndex = 9;
            this.commentButton.Text = "Comment";
            this.commentButton.UseVisualStyleBackColor = true;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // newCommentPanel
            // 
            this.newCommentPanel.Controls.Add(this.saveCommentButton);
            this.newCommentPanel.Controls.Add(this.newCommentTextBox);
            this.newCommentPanel.Location = new System.Drawing.Point(3, 299);
            this.newCommentPanel.Name = "newCommentPanel";
            this.newCommentPanel.Size = new System.Drawing.Size(253, 88);
            this.newCommentPanel.TabIndex = 8;
            this.newCommentPanel.Visible = false;
            // 
            // saveCommentButton
            // 
            this.saveCommentButton.Location = new System.Drawing.Point(175, 58);
            this.saveCommentButton.Name = "saveCommentButton";
            this.saveCommentButton.Size = new System.Drawing.Size(75, 23);
            this.saveCommentButton.TabIndex = 8;
            this.saveCommentButton.Text = "Save";
            this.saveCommentButton.UseVisualStyleBackColor = true;
            this.saveCommentButton.Click += new System.EventHandler(this.saveCommentButton_Click);
            // 
            // newCommentTextBox
            // 
            this.newCommentTextBox.Location = new System.Drawing.Point(6, 8);
            this.newCommentTextBox.Name = "newCommentTextBox";
            this.newCommentTextBox.Size = new System.Drawing.Size(244, 44);
            this.newCommentTextBox.TabIndex = 7;
            this.newCommentTextBox.Text = "";
            // 
            // detailsLabel
            // 
            this.detailsLabel.AutoSize = true;
            this.detailsLabel.Location = new System.Drawing.Point(3, 0);
            this.detailsLabel.Name = "detailsLabel";
            this.detailsLabel.Size = new System.Drawing.Size(77, 13);
            this.detailsLabel.TabIndex = 6;
            this.detailsLabel.Text = "ProcessDetails";
            // 
            // alwaysOnTopCheck
            // 
            this.alwaysOnTopCheck.AutoSize = true;
            this.alwaysOnTopCheck.Location = new System.Drawing.Point(28, 493);
            this.alwaysOnTopCheck.Name = "alwaysOnTopCheck";
            this.alwaysOnTopCheck.Size = new System.Drawing.Size(92, 17);
            this.alwaysOnTopCheck.TabIndex = 6;
            this.alwaysOnTopCheck.Text = "Always on top";
            this.alwaysOnTopCheck.UseVisualStyleBackColor = true;
            this.alwaysOnTopCheck.CheckedChanged += new System.EventHandler(this.alwaysOnTopCheck_CheckedChanged);
            // 
            // closeWindowButton
            // 
            this.closeWindowButton.Location = new System.Drawing.Point(593, 489);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.Size = new System.Drawing.Size(75, 23);
            this.closeWindowButton.TabIndex = 7;
            this.closeWindowButton.Text = "Close";
            this.closeWindowButton.UseVisualStyleBackColor = true;
            this.closeWindowButton.Click += new System.EventHandler(this.closeWindowButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(511, 489);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // prettyButton
            // 
            this.prettyButton.Location = new System.Drawing.Point(349, 489);
            this.prettyButton.Name = "prettyButton";
            this.prettyButton.Size = new System.Drawing.Size(75, 23);
            this.prettyButton.TabIndex = 10;
            this.prettyButton.Text = "Pretty";
            this.prettyButton.UseVisualStyleBackColor = true;
            this.prettyButton.Click += new System.EventHandler(this.prettyButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(430, 489);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 23);
            this.newButton.TabIndex = 11;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 522);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.prettyButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.closeWindowButton);
            this.Controls.Add(this.alwaysOnTopCheck);
            this.Controls.Add(this.detailsPanel);
            this.Controls.Add(this.processDataGrid);
            this.Controls.Add(this.processListLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.processDataGrid)).EndInit();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.commentsPanel.ResumeLayout(false);
            this.commentsPanel.PerformLayout();
            this.newCommentPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label processListLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView processDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn processId;
        private System.Windows.Forms.DataGridViewTextBoxColumn processName;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label detailsLabel;
        private System.Windows.Forms.Panel newCommentPanel;
        private System.Windows.Forms.RichTextBox newCommentTextBox;
        private System.Windows.Forms.Button commentButton;
        private System.Windows.Forms.Button saveCommentButton;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Label runningTimeLabel;
        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button threadButton;
        private System.Windows.Forms.Label startTimeContentLabel;
        private System.Windows.Forms.Label runningTimeContentLabel;
        private System.Windows.Forms.Label memoryContentLabel;
        private System.Windows.Forms.Label cpuContentLabel;
        private System.Windows.Forms.Label nameContentLabel;
        private System.Windows.Forms.Label idContentLabel;
        private System.Windows.Forms.Panel commentsPanel;
        private System.Windows.Forms.Label commentContentLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.CheckBox alwaysOnTopCheck;
        private System.Windows.Forms.Button closeWindowButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button prettyButton;
        private System.Windows.Forms.Button newButton;
    }
}

