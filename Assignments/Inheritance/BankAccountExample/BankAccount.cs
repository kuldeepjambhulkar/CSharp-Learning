using System;

namespace BankAccountExample
{
    internal class BankAccount
    {
        private int AccountNumber;
        private string UserName;
        private string AccountType;
        private int Balance;


        public BankAccount(int accountNumber, string userName, string accountType, int balance) { 
            this.AccountNumber = accountNumber;
            this.UserName = userName.Trim();  
            this.AccountType = accountType.Trim();
            this.Balance = balance; 
        }

        public int getAccountNumber() {
            return this.AccountNumber;
        }
        public string getUserName() { 
            return this.UserName;
        }
        public string getAccountType() {
            return this.AccountType;
        }
        public void setAccountNumber(int accountNumber) { 
            this.AccountNumber = accountNumber;
        }
        public void setBalance(int balance) {
            this.Balance = balance;
        }
        public int getBalance() {
            return this.Balance;
        }

        public void setName(string userName) {
            this.UserName = userName.Trim();
        }

        public void setAccountType(string accountType) {
            this.AccountType = accountType.Trim();
        }

    }
}
