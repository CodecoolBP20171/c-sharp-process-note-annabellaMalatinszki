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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openNewProcessButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(newProcessNameTextBox.Text) == false)
            {
                invalidProcessLabel.Visible = false;
                try
                {
                    string newProcessName = newProcessNameTextBox.Text;
                    Process.Start(newProcessName);
                    this.Close();
                }
                catch (Exception)
                {
                    this.Show();
                    invalidProcessLabel.Visible = true;
                }
                
            }
        }

        private void newProcessNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(newProcessNameTextBox.Text) == false)
            {
                openNewProcessButton.Enabled = true;
            }
        }
    }
}
