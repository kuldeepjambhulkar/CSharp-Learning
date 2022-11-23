using System;

namespace BankAccountExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SavingAccount sa = new SavingAccount(101, "Micheal Scott", "Savings", 23000, 5);
            LoanAccount la = new LoanAccount(102, "Dwight Schrute", "Loans", 45000, 500000);

            Console.WriteLine($"\nAccount Type: {sa.getAccountType()} \nAccount Number: {sa.getAccountNumber()}\nUser Name: {sa.getUserName()} \nTotal Amount with interest: {sa.getTotalAmtWithInterest()}");
            /* Output: 
                    Account Type: Savings
                    Account Number: 101
                    User Name: Micheal Scott
                    Total Amount with interest: 11500000
             
             */
            Console.WriteLine($"\nAccount Type: {la.getAccountType()} \nAccount Number: {la.getAccountNumber()}\nUser Name: {la.getUserName()} \nRemaining Loan: {la.getRemainingAmt()}");
            /* Output:
                    Account Type: Loans
                    Account Number: 102
                    User Name: Dwight Schrute
                    Remaining Loan: 455000             
             */

        }
    }
}