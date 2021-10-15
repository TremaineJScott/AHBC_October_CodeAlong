using System;

namespace AHBC_Day_One
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            // While and Do...While
            // both have a condition check
            int number = 15;

            bool exitApplication = false;
            bool numberIsBad = true;
            int userNumber = -1;
            bool isCorrectAnswer = false;
            bool playAgain = true;



            for (int counter = 0; counter < length; counter++)
            {

            }






            do
            {
                do
                {
                    numberIsBad = true;

                    while (numberIsBad == true)
                    {
                        Console.WriteLine("Pick a number from 1 - 20");
                        userInput = Console.ReadLine();
                        userNumber = int.Parse(userInput);
                        if (userNumber > 20 || userNumber < 1)
                        {
                            // Fix bad number
                            Console.WriteLine("bad number, try again.");
                        }
                        else
                        {
                            numberIsBad = false;
                        }
                    }

                    if (userNumber == number)
                    {
                        isCorrectAnswer = true;
                        Console.WriteLine("Yeah you guessed it.");
                    }
                    else
                    {
                        Console.WriteLine("Wrong!!! Guess again.");
                    }
                } while (isCorrectAnswer == false);

                Console.WriteLine("again");
                userInput = Console.ReadLine();
                if (userInput.Trim().ToLower() == "no")
                {
                    playAgain = false;
                }

            } while (playAgain == true);

            Console.ReadKey();


            do
            {
                Console.WriteLine("Hey there");
                Console.WriteLine("Go again? Anything besides yes will exit the code.");
                userInput = Console.ReadLine();

                if (userInput.ToLower().Trim() == "yes")
                {
                    exitApplication = true;
                }
                else
                {
                    exitApplication = false;
                }
            } while (exitApplication == false);

            while (number == 1)
            {
                number = 2;
            }

            //  Welcome();
        }

        static void Welcome()
        {
            Console.WriteLine("What section do you want to run?");
            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    goto GetName;
                    break;
                case 2:
                    goto GetAge;
                    break;
                case 3:
                    goto BankBalance;
                    break;
                case 4:
                    goto EmotionalCheckup;
                    break;
                default:
                    goto Exit;
                    break;
            }

        /*
        if (selection == 1)
        {
            goto GetName;
        }
        else if (selection == 2)
        {
            goto GetAge;
        }
        else if (selection == 3)
        {
            goto BankBalance;
        }
        else if (selection == 4)
        {
            goto EmotionalCheckup;
        }
        else
        {
            goto Exit;
        }
          */

        GetName:

            Console.WriteLine("hello world");
            Console.WriteLine("What is your name?");
            // Get user name

            // This is a normal comment
            // TODO - Fix this later
            // HACK - smelly code


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
            bool wasOldEnough = false;
            string country = "";


            if (userAge >= 21)
            {
                Console.WriteLine("Welcome to the bar, have a drink");
            }
            else if (userAge == 19 && country == "candada")
            {
                Console.WriteLine("Have a drink, eh!");
            }
            else if (userAge > 17 && userAge < 21)
            {
                Console.WriteLine("You can only dance");
            }
            else
            {
                Console.WriteLine("No Dice");
            }

            if (country == "us")
            {
                if (userAge >= 21)
                {
                    Console.WriteLine("Welcome to the bar, have a drink");
                }
                else if (userAge > 17 && userAge < 21)
                {
                    Console.WriteLine("You can only dance");
                }
                else
                {
                    Console.WriteLine("No Dice");
                }
            }

            if (country == "canada")
            {
                if (userAge >= 19)
                {
                    Console.WriteLine("Welcome to the bar, have a drink");
                }
                else if (userAge > 17 && userAge < 19)
                {
                    Console.WriteLine("You can only dance");
                }
                else
                {
                    Console.WriteLine("No Dice");
                }
            }

            if (userAge > 17 && userAge < 21)
            {
                Console.WriteLine("you are only allowed to dance.");
            }

            if (userAge < 18)
            {
                Console.WriteLine("No Dice");
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

        EmotionalCheckup:

            Console.WriteLine("How are you feeling today?");
            userInput = Console.ReadLine();
            userInput = "   sad  ";


            switch (userInput.ToLower().Trim())
            {
                case "sad":
                case "unhappy":
                case "crying":
                    if (userInput.ToLower().Trim() == "crying")
                    {
                        Console.WriteLine("Please don't cry.");
                    }
                    Console.WriteLine("I'm sorry you are not feeling great,");
                    break;
                case "happy":
                    Console.WriteLine("Yeah! that's awsome!");
                    goto BankBalance;
                    break;
                case "confused":
                    Console.WriteLine("I get that way too.");
                    break;
                default:
                    Console.WriteLine("I don't know what that means.");
                    break;
            }

            /*
            if (userInput.ToLower().Trim() == "sad")
            {

            }
            else if (userInput == "happy")
            {

            }
            else
            {

            }
            */

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

    }
}
