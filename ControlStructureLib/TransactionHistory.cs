using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructureLib
{
    public class TransactionHistory
    {
        public void CheckTransactionHistory()
        {
            List<string> transactions = new List<string>();
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Choose a transaction: \n1. Deposit \n2. Withdraw \n3. Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter deposit amount: ");
                        double deposit = double.Parse(Console.ReadLine());
                        transactions.Add($"Deposited: {deposit}");
                        Console.WriteLine("Transaction added.");
                        break;
                    case 2:
                        Console.Write("Enter withdrawal amount: ");
                        double withdrawal = double.Parse(Console.ReadLine());
                        transactions.Add($"Withdrew: {withdrawal}");
                        Console.WriteLine("Transaction added.");
                        break;
                    case 3:
                        isRunning = false;
                        Console.WriteLine("Transaction history:");
                        foreach (string transaction in transactions)
                        {
                            Console.WriteLine(transaction);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid option selected.");
                        break;
                }
            }
        }
    }
}
