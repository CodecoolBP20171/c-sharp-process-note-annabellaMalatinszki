using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProcessNote
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessHandler allProcesses = new ProcessHandler();
            CurrentProcess currentProcess;

            Console.WriteLine("CURRENTLY RUNNING PROCESSES:\n" + allProcesses.ToString());


                        Console.WriteLine("SELECT AN ID TO SEE DETAILS: ");

            int selectedProcessId;
            if (int.TryParse(Console.ReadLine(), out selectedProcessId))
            {
                currentProcess = new CurrentProcess(selectedProcessId);
                StringBuilder sb = new StringBuilder();
                sb.Append("\nName: " + currentProcess.Name);
                sb.Append("\nCPU usage: " + currentProcess.CpuUsage);
                sb.Append("\nMemory usage: " + currentProcess.MemoryUsage);
                sb.Append("\nStart time: " + currentProcess.StartTime);
                sb.Append("\nRunning time: " + currentProcess.RunningTime);
                sb.Append("\nThreads: ");
                foreach(ProcessThread thread in currentProcess.Threads) 
                {
                    sb.Append("\nId: " + thread.Id + " Current priority: " + thread.CurrentPriority);
                }

                Console.WriteLine(sb);
            }
            else
            {
                Console.WriteLine("PROCESS ID NOT FOUND");
            }
            Console.ReadKey();
        }
    }
}
