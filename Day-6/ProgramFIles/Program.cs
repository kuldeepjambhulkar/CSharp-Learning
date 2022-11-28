using System;


namespace DelegatesTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            delegateForDoWork del1 = new delegateForDoWork(workPerformed);
            delegateForWorkDone del2 = new delegateForWorkDone(workDone);

            //del1(4, "Coding");
            Worker worker = new Worker();
            worker.doWork(5, "Documenting", del1, del2);
        }

        public static void workPerformed(int hours, string workType) {
            Console.WriteLine($"\n{hours} hours completed for {workType}");
        }

        public static void workDone(string workType) { 
            Console.WriteLine($"{workType} completed");
        }

    }
}