using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessNoteWinForms
{
    public partial class Form1 : Form
    {

        static CurrentProcess currentProcess;
        Dictionary<int, string> commentDict = new Dictionary<int, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProcesses();
        }

        private void processDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (string.IsNullOrWhiteSpace(newCommentTextBox.Text) == false)
                {
                    MessageBox.Show("You haven't saved your comment. Unsaved comments will be lost. Are you sure you want to see another process?", "Unsaved Comment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    DataGridViewRow row = this.processDataGrid.Rows[e.RowIndex];
                    int selectedProcessId = (int)row.Cells["processId"].Value;
                    currentProcess = new CurrentProcess(selectedProcessId);

                    newCommentPanel.Visible = false;
                    newCommentTextBox.Text = "";

                    idContentLabel.Text = currentProcess.Id.ToString();
                    nameContentLabel.Text = currentProcess.Name;
                    cpuContentLabel.Text = currentProcess.CpuUsage.ToString() + "%";
                    memoryContentLabel.Text = currentProcess.MemoryUsage.ToString() + "MB";
                    runningTimeContentLabel.Text = currentProcess.RunningTime.ToString();
                    startTimeContentLabel.Text = currentProcess.StartTime.ToString();

                    if (commentDict.ContainsKey(selectedProcessId))
                    {
                        commentContentLabel.Text = commentDict[selectedProcessId];
                        commentsPanel.Visible = true;
                    }
                    else
                    {
                        commentsPanel.Visible = false;
                        newCommentPanel.Visible = false;
                    }
                    detailsPanel.Visible = true;

                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Process process = Process.GetProcessById(currentProcess.Id);
            process.CloseMainWindow();
            process.Close();
        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            newCommentPanel.Visible = true;
        }

        private void saveCommentButton_Click(object sender, EventArgs e)
        {
            if (commentDict.ContainsKey(currentProcess.Id))
            {
                commentDict[currentProcess.Id] = commentDict[currentProcess.Id] + "\n" + newCommentTextBox.Text;
                commentContentLabel.Text = commentDict[currentProcess.Id];
                commentsPanel.Visible = true;
            }
            else
            {
                commentDict[currentProcess.Id] = "\n" + newCommentTextBox.Text;
                commentContentLabel.Text = commentDict[currentProcess.Id];
                commentsPanel.Visible = true;
            }
            newCommentTextBox.Text = "";
        }

        private void alwaysOnTopCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (alwaysOnTopCheck.Checked == true)
            {
                this.TopMost = true;
            }
            if (alwaysOnTopCheck.Checked == false)
                this.TopMost = false;
        }

        private void closeWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            commentDict.Clear();
            processDataGrid.Rows.Clear();
            detailsPanel.Visible = false;
            commentsPanel.Visible = false;
            newCommentPanel.Visible = false;
            LoadProcesses();

        }

        public void LoadProcesses()
        {
            ProcessHandler allProcesses = new ProcessHandler();
            foreach (Process process in Process.GetProcesses())
            {
                processDataGrid.Rows.Add(process.Id, process.ProcessName);
            }
        }

        private void prettyButton_Click(object sender, EventArgs e)
        {
            Image prettyImage = new Bitmap(@"C:\Users\amala\Downloads\pattern.jpg");
            this.BackgroundImage = prettyImage;
        }

        private void threadButton_Click(object sender, EventArgs e)
        {
            var threadForm = new Form2();
            threadForm.Show();
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            var newProcessForm = new Form3();
            newProcessForm.Show();
        }

        public int GetCurrentProcessId()
        {
            Process selectedProcess = Process.GetProcessById(currentProcess.Id);
            currentProcess = new CurrentProcess(selectedProcess.Id);
            return currentProcess.Id;
        }
    }
}
