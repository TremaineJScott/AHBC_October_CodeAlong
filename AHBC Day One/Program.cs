using System;

namespace AHBC_Day_One
{
    class Program
    {
        static void Main(string[] args)
        {
            goto GetAge;

            GetName:

            Console.WriteLine("hello world");
            Console.WriteLine("What is your name?");
            // Get user name
            string userName = Console.ReadLine();
            string userInput = "";

            const string COMPUTERNAME = "HAL";


            Console.WriteLine(COMPUTERNAME);

            goto Exit; 

            GetAge:

            // Get aga
            Console.WriteLine("How old are you.");
            userInput = Console.ReadLine();

            int userAge = int.Parse(userInput);

            userAge = 22;

            bool wasOldEnough = false;

            if (userAge >= 21)
            {
                // This code will run
            }

            if (wasOldEnough == false)
            {
                // This code will run
            }

            if (wasOldEnough != false)
            { 
                // This code WILL NOT run
            }


            if (wasOldEnough == true)
            {
                // This WILL NOT run
            }


            

            // Age the user 10 years for every turn
            userAge = userAge + 10;

            int answer = userAge % 3;

           goto Exit;

        BankBalance:

            // Decimal values
            Console.WriteLine("What is you banking balance (no $ sign).");
            userInput = Console.ReadLine();
            double bankBalance = double.Parse(userInput);

            int dollarAmount = (int)bankBalance;

            Welcome(bankBalance.ToString());

            string message = $"You have {0} in your account. Richness is {bankBalance >= 1000}";

            Console.WriteLine(message);

            goto Exit;

        // Convert userAge to Integer     



        // Subtract thier age from mine

        // Convert balance to double

        // Ask for half their money


        // Display the difference

        Exit:

            Console.ReadKey();
        }

        static void Welcome(string arg)
        {
            string computerName = "max";
        }

    }
}
