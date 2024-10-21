using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructureLib
{
    public class PasswordValidation
    {
        public void ValidatePassword()
        {
            Console.Write("Create a password: ");
            string password = Console.ReadLine();

            if (password.Length >= 8 && password.Any(char.IsUpper) && password.Any(char.IsDigit))
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password must be at least 8 characters long, contain at least one uppercase letter, and contain at least one digit.");
            }
        }
    }
}
