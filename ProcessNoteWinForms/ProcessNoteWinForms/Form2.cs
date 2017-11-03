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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
 
        private void Form2_Load(object sender, EventArgs e)
        {
            var originalProcessForm = new Form1();
            int processId = originalProcessForm.GetCurrentProcessId();
            CurrentProcess currentProcess = new CurrentProcess(processId);

            foreach (ProcessThread thread in currentProcess.Threads)
            {
                threadDataGridView.Rows.Add(thread.Id, thread.BasePriority, thread.CurrentPriority, thread.TotalProcessorTime);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
