using System;

namespace DelegatesTutorial
{
    public delegate void delegateForDoWork(int hours, string workType);
    public delegate void delegateForWorkDone(string workType);


    internal class Worker
    {
        public void doWork(int hours, string workType, delegateForDoWork del1, delegateForWorkDone del2) {
            for (int i = 0; i <= hours; i++) {
                del1(i + 1, workType);
            }
            del2(workType);
        }
    }
}
