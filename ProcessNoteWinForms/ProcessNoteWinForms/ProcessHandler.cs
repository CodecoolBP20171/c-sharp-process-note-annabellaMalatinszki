using System.Diagnostics;
using System.Text;

namespace ProcessNoteWinForms
{
    internal class ProcessHandler
    {
        public Process[] RunningProcesses { get; set; }

        public ProcessHandler()
        {
            RunningProcesses = Process.GetProcesses();
        }
    }
}