namespace ControlStructureLib
{
    public class LoanEligibility
    {
        public void CheckLoanEligibility()
        {
            Console.Write("Enter credit score: ");
            int creditScore = int.Parse(Console.ReadLine());

            Console.Write("Enter annual income: ");
            double annualIncome = double.Parse(Console.ReadLine());

            if (creditScore > 700 && annualIncome >= 50000)
            {
                Console.WriteLine("Congratulations! You are eligible for the loan.");
            }
            else
            {
                Console.WriteLine("Sorry, you are not eligible for the loan.");
            }
        }
    }
}
