using ControlStructureLib;
using Entity;
internal class Bank
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Banking App");

        //// Task 1
        //LoanEligibility loanEligibility = new LoanEligibility();
        //loanEligibility.CheckLoanEligibility();

        //// Task 2
        //ATMSimulation atmSimulation = new ATMSimulation();
        //atmSimulation.RunATMSimulation();

        ////Task 3
        //CompoundInterest compoundInterest = new CompoundInterest();
        //compoundInterest.CalculateCompoundInterest();

        ////Task 4
        //AccountBalanceCheck balanceCheck = new AccountBalanceCheck();
        //balanceCheck.CheckAccountBalance();

        ////Task 5
        //PasswordValidation passwordValidation = new PasswordValidation();
        //passwordValidation.ValidatePassword();

        ////Task 6
        //TransactionHistory transactionHistory = new TransactionHistory();
        //transactionHistory.CheckTransactionHistory();

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