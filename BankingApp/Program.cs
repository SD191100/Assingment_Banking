internal class Program
{
    public static void CheckEligibility (int cred, int income)
    {
        if (cred > 700 && income > 50000)
        {
            Console.WriteLine("You are Eligible");
        }
        else
        {
            Console.WriteLine("You are Ineligible");
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // Task 1
        int _creditScore;
        int _annualIncome;

        Console.WriteLine("Enter Credit Score");
        _creditScore = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Annual Income");
        _annualIncome = Convert.ToInt32(Console.ReadLine());
        CheckEligibility(_creditScore, _annualIncome);
       
    }
}