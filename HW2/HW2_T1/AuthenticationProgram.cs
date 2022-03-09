using System;
using System.Collections.Generic;

namespace HW2_T1
{
    class AuthenticationProgram
    {
        static void Main(string[] args)
        {
            LoginRequest();
        }

        static void LoginRequest()
        {
            int attemptsLeft = 3;
            Dictionary <string, string> existingCredits = new Dictionary <string, string> { };
            existingCredits.Add("login1", "password1");
            existingCredits.Add("login2", "password2");
            existingCredits.Add("ilya", "qwerty");

            while (attemptsLeft > 0)
            {
                Console.WriteLine("Enter login");
                string inputLogin = Console.ReadLine();
                Console.WriteLine("Enter password");
                string inputPassword = Console.ReadLine();
                if(existingCredits.ContainsKey(inputLogin) && existingCredits.GetValueOrDefault(inputLogin).Equals(inputPassword))
                {
                    Console.WriteLine("Authentication success");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Login or Password");
                    attemptsLeft--;
                    Console.WriteLine($"Try again, attempts left: {attemptsLeft}");
                }
            }
            if (attemptsLeft == 0)
            {
                Console.WriteLine("ERROR: Out of attempts");
                Console.ReadKey();
            }
            
        }
        
    }
}
