using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructureLib
{
    public class ATMSimulation
    {
        public void RunATMSimulation()
        {
            Console.Write("Enter current balance: ");
            double balance = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose an option: \n1. Check Balance \n2. Withdraw \n3. Deposit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Your balance is: {balance}");
                    break;
                case 2:
                    Console.Write("Enter withdrawal amount: ");
                    double withdrawal = double.Parse(Console.ReadLine());
                    if (withdrawal % 100 == 0 || withdrawal % 500 == 0)
                    {
                        if (withdrawal <= balance)
                        {
                            balance -= withdrawal;
                            Console.WriteLine($"Withdrawal successful! New balance: {balance}");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Withdrawal amount must be in multiples of 100 or 500.");
                    }
                    break;
                case 3:
                    Console.Write("Enter deposit amount: ");
                    double deposit = double.Parse(Console.ReadLine());
                    balance += deposit;
                    Console.WriteLine($"Deposit successful! New balance: {balance}");
                    break;
                default:
                    Console.WriteLine("Invalid option selected.");
                    break;
            }
        }
    }
}
