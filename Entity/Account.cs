using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Account
    {
        private int accountNumber;
        private string accountType;
        private double accountBalance;

        private const double interestRate = 4.5;

        public Account () { }

        public Account (int accountNumber, string accountType, double accountBalance)
        {
            this.accountNumber = accountNumber;
            this.accountType = accountType;
            this.accountBalance = accountBalance;
        }

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }

        public double AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                accountBalance += amount;
                Console.WriteLine($"Successfully deposited {amount}. New balance: {accountBalance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= accountBalance)
            {
                accountBalance -= amount;
                Console.WriteLine($"Successfully withdrew {amount}. New balance: {accountBalance}");
            }
            else if (amount > accountBalance)
            {
                Console.WriteLine("Insufficient balance for withdrawal.");
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
        }

        public void CalculateInterest()
        {
            if (accountType.ToLower() == "savings")
            {
                double interest = accountBalance * (interestRate / 100);
                accountBalance += interest;
                Console.WriteLine($"Interest added: {interest}. New balance: {accountBalance}");
            }
            else
            {
                Console.WriteLine("Interest calculation is only available for savings accounts.");
            }
        }

        public void PrintAccountInfo()
        {
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Account Balance: {accountBalance}");
        }
    }
}
