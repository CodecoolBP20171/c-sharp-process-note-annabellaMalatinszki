using System.Diagnostics;
using System;

namespace ProcessNote
{
    internal class CurrentProcess

    {
        private int id;
        private string name;
        private float cpuUsage;
        private float memoryUsage;
        private TimeSpan runningTime;
        private DateTime startTime;
        private ProcessThreadCollection threads;

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public float CpuUsage
        {
            get { return cpuUsage; }
        }

        public float MemoryUsage
        {
            get { return memoryUsage; }
        }

        public TimeSpan RunningTime
        {
            get { return runningTime; }
        }

        public DateTime StartTime
        {
            get { return startTime; }
        }

        public ProcessThreadCollection Threads
        {
            get { return threads; }
        }


        public CurrentProcess(int processId)
        {
            id = processId;
            name = Process.GetProcessById(processId).ProcessName;
            cpuUsage = CountCPUUsage();
            memoryUsage = CountMemoryUsage();
            startTime = RetrieveStartTime();
            runningTime = CountRunningTime();
            threads = RetrieveThreads();

        }

        private float CountCPUUsage()
        {
            PerformanceCounter theCPUCounter = new PerformanceCounter("Process", "% Processor Time", name);
            float CPUCounterValue = theCPUCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            return theCPUCounter.NextValue();
        }

        private float CountMemoryUsage()
        {
            PerformanceCounter theMemCounter = new PerformanceCounter("Memory", "Available MBytes");
            //Console.WriteLine("MEMORY: " + theMemCounter.NextValue());
            return theMemCounter.NextValue();

        }

        private DateTime RetrieveStartTime()
        {
            return Process.GetProcessById(id).StartTime;
        }

        private TimeSpan CountRunningTime()
        {
            DateTime now = DateTime.Now;
            return (now-startTime);
        }

        private ProcessThreadCollection RetrieveThreads() 
        {
            return Process.GetProcessById(id).Threads;
        }
    }
}