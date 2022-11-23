using System;

namespace BankAccountExample
{
    internal class LoanAccount : BankAccount
    {
        private int LoanAmount;
        public LoanAccount(int accountNumber, string userName, string accountType, int balance, int loanAmount) : base(accountNumber, userName, accountType, balance)
        {
            this.LoanAmount = loanAmount;
        }

        public int getLoanAmount () { return this.LoanAmount;  }
        public void setLoanAmount (int amount) { this.LoanAmount = amount; }

        public int getRemainingAmt() {
            return (this.getLoanAmount() - this.getBalance());
        }
    }
}
