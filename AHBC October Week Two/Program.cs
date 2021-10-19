using System;
using System.Text;


namespace AHBC_October_Week_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Method

            // ToLower - ToUpper
            // TrimStart - TrimEnd - Trim

            try
            {
                // Logic goes here
                // Runs fine if no exception

                throw new DivideByZeroException("something bad happened, April");

                // Replace
                string message = "this course is okay";
                string newMessage = message.Replace('i', 'o');
                newMessage = message.Replace("okay", "great");

                string templateMessage = "goodbye USERNAME how are you?";
                int hLocation = templateMessage.IndexOf('h'); // 0
                int oLocation = templateMessage.IndexOf('o');
                int otherHLocation = templateMessage.LastIndexOf('h');

                int locacationOfFirstSpace = templateMessage.IndexOf(' '); // 5
                string firstWord = templateMessage.Substring(0, locacationOfFirstSpace);
                templateMessage = "you ok?";
                string punctuation = templateMessage.Substring(templateMessage.Length - 1);

                string quote = "Einstein says \"e=mc2\" all the time";
                int locationOfQuote = quote.IndexOf("\"");
                int locationOfLastQuote = quote.LastIndexOf("\"");
                string actualQuote = quote.Substring(locationOfQuote + 1, locationOfLastQuote - locationOfQuote - 1);

                string address = @"http:\\www.here.com";
                string filePath = @"c:\code\documents";

                Console.WriteLine("what is your name");
                string userInput = Console.ReadLine();
                newMessage = templateMessage.Replace("USERNAME", userInput);
                bool isValidNumber = false;

                while (isValidNumber == false)
                {
                    try
                    {
                        Console.WriteLine("How old are you?");
                        userInput = Console.ReadLine();
                        int age = int.Parse(userInput);
                        isValidNumber = true;
                    }
                    catch (FormatException ex)
                    {
                        // Catches the exception
                        Console.WriteLine("You need to enter an actual number for your age");
                    }
                }

                int candyAmount = 12;
                Console.WriteLine("Split the candy among your kids.");

                isValidNumber = false;
                int numberOfKids = -1;

                while (isValidNumber == false)
                {
                    try
                    {
                        Console.WriteLine("How many kids do you have");
                        userInput = Console.ReadLine();
                        numberOfKids = int.Parse(userInput);
                        isValidNumber = true;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("You need to enter an actual number");
                    }
                }

                try
                {
                    Console.WriteLine($"Each kid gets {candyAmount / numberOfKids} pieces of candy.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("You don't have any kids? You get all the candy");
                }


                // StartWith, EndsWith
                bool startsWithMyLetter = newMessage.StartsWith("hel");
                bool isQuestion = newMessage.EndsWith('?');

                // https://regexr.com/

                //Split
                string friends = "Jeff|Mary|Jacob|Sylvia";
                string[] friendList = friends.Split('|');

                string userRecord = "Scott|200|160|28";
                string[] userInfo = userRecord.Split('|');
                string name = userInfo[0];
                string weight = userInfo[1];
                string targetHeartRate = userInfo[2];
                string bmi = userInfo[3];

                string firstValue = "";
                string secondValue = null;

                bool isValidString = false;

                while (isValidString == false)
                {
                    try
                    {
                        Console.WriteLine("enter a value");
                        string value = Console.ReadLine();

                        // Business Logic    
                        if (value.StartsWith('s') == false)
                        {
                            Console.WriteLine("string does not start with s");
                        }
                        isValidString = true;
                    }
                    catch (NullReferenceException ex)
                    {
                        Console.WriteLine("You need to enter an actual value");
                    }
                }

                // Validation Logic
                //if (string.IsNullOrEmpty(value))
                //{
                //    Console.WriteLine("Please enter valid string");
                //}               

                Console.WriteLine("Do you have kids (yes/no)?");
                userInput = Console.ReadLine();

                // This IF statement
                if (userInput.Trim().ToLower() == "yes")
                {

                }
                // Does the same thing as this IF statement
                // Developers Choice!!!!
                if (string.Equals(userInput.Trim(), "yes", StringComparison.OrdinalIgnoreCase))
                {

                }

                // String are immutable - they can not be changed
                string myName = "Scott";
                myName = "John";
                myName = "Trevor";
                string realFriendList = "";
                string[] realFriends = new string[] { "Jeff", "Frank", "Mary" };
                StringBuilder builder = new StringBuilder();

                foreach (string friendName in realFriends)
                {
                    realFriendList = realFriendList + friendName + "|";
                    builder.Append(friendName + "|");
                }

                // These lines are the same
                Console.WriteLine(realFriendList);
                Console.WriteLine(builder.ToString());

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Something unexpected happened");
            }
            Console.ReadKey();
        }
    }
}
