using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructureLib
{
    public class CompoundInterest
    {
        public void CalculateCompoundInterest()
        {
            Console.Write("Enter the number of customers: ");
            int customerCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= customerCount; i++)
            {
                Console.WriteLine($"Customer {i}:");
                Console.Write("Enter initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());

                Console.Write("Enter annual interest rate (as a percentage): ");
                double interestRate = double.Parse(Console.ReadLine());

                Console.Write("Enter number of years: ");
                int years = int.Parse(Console.ReadLine());

                double futureBalance = initialBalance * Math.Pow((1 + interestRate / 100), years);
                Console.WriteLine($"Future balance after {years} years: {futureBalance}\n");
            }
        }
    }
}
