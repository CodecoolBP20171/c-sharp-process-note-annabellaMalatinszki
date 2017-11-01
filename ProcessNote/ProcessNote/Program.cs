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

            Console.ReadKey();
        }
    }
}
