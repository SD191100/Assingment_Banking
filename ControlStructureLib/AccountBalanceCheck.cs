using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructureLib
{
    public class AccountBalanceCheck
    {
        private Dictionary<int, double> accounts = new Dictionary<int, double>
        {
            { 101, 1000.50 },
            { 102, 2500.00 },
            { 103, 500.75 }
        };

        public void CheckAccountBalance()
        {
            bool isValid = false;
            while (!isValid)
            {
                Console.Write("Enter account number: ");
                int accountNumber = int.Parse(Console.ReadLine());

                if (accounts.ContainsKey(accountNumber))
                {
                    Console.WriteLine($"The balance for account {accountNumber} is {accounts[accountNumber]}.");
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid account number. Please try again.");
                }
            }
        }
    }
}
