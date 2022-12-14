using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee(102, "Micheal", 1000.54f);
            Console.WriteLine("\n FTE: " + fte.getEmployeeId() + " " + fte.getEmployeeName() + ", Bonus: " + fte.getBonusAmt() + ", Total Amount: " + fte.getTotalAmt());
            // Output:  FTE: 102 Micheal, Bonus: 1000.54, Total Amount: 23012.42

            PartTimeEmployee pte = new PartTimeEmployee(103, "Scott", 2000);
            Console.WriteLine("\n PTE: " + pte.getEmployeeId() + " " + pte.getEmployeeName() + ", Hourly Rate: " + pte.getHourlyRate() + ", Paycheck Amount: " + pte.getPayAmt());
            // Output:  PTE: 103 Scott, Hourly Rate: 2000, Paycheck Amount: 10000

        }
    }
}