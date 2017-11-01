using System;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace ProcessNote
{
    internal class ProcessHandler
    {
        public Process[] RunningProcesses { get; set; }

        public ProcessHandler()
        {
            RunningProcesses = Process.GetProcesses();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Process process in RunningProcesses)
            {
                sb.Append("Id: ");
                sb.Append(process.Id);
                sb.Append(" Name: ");
                sb.Append(process.ProcessName);
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}