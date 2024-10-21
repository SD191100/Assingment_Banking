using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Bank
    {
        public static void Main(string[] args)
        {
            // Creating customer object
            Customer customer = new Customer(101, "John", "Doe", "john.doe@example.com", "1234567890", "123 Main St");
            customer.PrintCustomerInfo();
            Console.WriteLine();

            // Creating account object using parameterized constructor
            Account account = new Account(123456, "Savings", 1000.0);
            account.PrintAccountInfo();
            Console.WriteLine();

            // Performing deposit operation
            account.Deposit(500.0);
            Console.WriteLine();

            // Performing withdraw operation
            account.Withdraw(200.0);
            Console.WriteLine();

            // Calculating interest for the savings account
            account.CalculateInterest();
            Console.WriteLine();

            // Printing final account information
            account.PrintAccountInfo();
        }
    }
}
