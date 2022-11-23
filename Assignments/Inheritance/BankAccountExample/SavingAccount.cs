using System;


namespace BankAccountExample
{
    internal class SavingAccount : BankAccount
    {
        private int InterestRate;
        public SavingAccount(int accountNumber, string userName, string accountType, int balance, int interestRate) : base(accountNumber, userName, accountType, balance)
        {
            this.InterestRate = interestRate;
        }

        public int getInterestRate() { 
            return this.InterestRate;
        }
        public void setInterestRate(int interestRate) {
            this.InterestRate = interestRate;
        }

        public int getTotalAmtWithInterest() {
            return (this.getBalance() * this.InterestRate * 100);
        }
    }
}
