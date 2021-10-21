using System;
using System.Text;


namespace AHBC_October_Week_Two
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("what are you doing?");
            string answer = Console.ReadLine();
            string outputMessage = "";

            int funValue = GetWednesdayNightFun(answer, out outputMessage);

            Console.WriteLine($"Fun level: {funValue}, {outputMessage}");
            Console.ReadKey();


            // DoStringManipulation();



            SayHello();
            // Get the user's name
            string userName = GetUserName();
            // Tell user they have a nice name
            Console.WriteLine($"{userName} is a very nice name!");

            int userAge = GetUserAge();

            int computerAge = 0;
            int ageDifference = 50;
            try
            {
                ageDifference = CalculateUserAgeDifference(userAge, computerAge);
            }
            catch (ArgumentException ex)
            {
                // Handle retry logic
            }

            // Can be done like this but very uncommon
            ageDifference = CalculateUserAgeDifference(
                computerAgeValue: computerAge, userAgeValue: userAge);

            // Tell the user, by name, the age difference and ask if it makes sense.
            bool doesMakesSense = AskIfMakesSense(userName, ageDifference);

            // Get ticket price
            double price = GetTotalPrice(2, true);


            // Either way is fine
            int answerFromMethod = AddNumbers();
            int copyOfAnswer = -1;
            copyOfAnswer = AddNumbers();

            string friends = GetFriendList();

            Console.ReadKey();
        }


        public static bool ValidateNumber(string userInput, int minValue, int MaxValue, out int validNumber)
        {
            try
            {
                int number = int.Parse(userInput);
                if (number >= minValue && number <= MaxValue)
                {
                    validNumber = number;
                    return true;
                }
                else
                {
                    validNumber = -1;
                    return false;
                }              
            }
            catch (FormatException ex)
            {
                validNumber = -1;
                return false;
            }
        }
        public static void TestLogic()
        {
            string friendList = "matt|mary";
            string userInput = "scott";
            AddFriendToList(userInput, ref friendList);
            Console.WriteLine(friendList);
        }


        public static string GetFriendList()
        {
            bool doContinue = true;
            string friendList = "";
            while (doContinue == true)
            {
                string userInput = "";
                Console.WriteLine("What is your friends name?");
                userInput = Console.ReadLine();
                AddFriendToList(userInput, ref friendList);

                Console.WriteLine("add another friend");
                userInput = Console.ReadLine();
                if (userInput.ToLower().Trim() == "no")
                {
                    doContinue = false;
                }
            }

            return friendList;
        }

        public static void GetNumberOfKids()
        {
            Console.WriteLine("how many kids");
            string userInput = Console.ReadLine();

            int numberOfKids = -1;

            bool isValidNumber = int.TryParse(userInput, out numberOfKids);
            

            if (isValidNumber == false)
            {
                // retry logic
            }
        }

        private static void AddFriendToList(string friend, ref string friendList)
        {
            friendList = friendList + "|" + friend;
        }

        public static double GetTotalPrice(int numberOfAdults, bool getsDiscount, int numberOfKids = 0)
        {
            double adultPrice = 5.50;
            double kidPrice = 1.75;
            double totalPrice = numberOfAdults * adultPrice + numberOfKids * kidPrice;

            if (getsDiscount == true)
            {
                totalPrice = GetDiscountedPrice(totalPrice);
            }

            return totalPrice;
        }

        private static double GetDiscountedPrice(double currentPrice)
        {
            const double DISCOUNTPERCENTAGE = .5;
            return currentPrice * DISCOUNTPERCENTAGE;
        }
        public static bool AskIfMakesSense(string userName, int ageDifference)
        {
            Console.WriteLine($"{userName} the age differnce is {ageDifference}");
            Console.WriteLine("Does this make sense (yes/no)?");
            string userResponse = Console.ReadLine();

            if (userResponse.ToLower().Trim() == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int CalculateUserAgeDifference(int userAgeValue, int computerAgeValue)
        {
            // userAgeValue = 12;
            if (userAgeValue <= 0 || computerAgeValue <= 0)
            {
                throw new ArgumentException("Ages must be greater than 0");

            }

            int difference = computerAgeValue - userAgeValue;

            if (userAgeValue > computerAgeValue)
            {
                difference = userAgeValue - computerAgeValue;
            }
            else
            {
                difference = computerAgeValue - userAgeValue;
            }

            return difference;

        }
        public static string GetUserName()
        {
            Console.Write("What's your name: ");
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static int GetWednesdayNightFun(string activity, out string message)
        {
            int funValue = -1;

            switch (activity.ToLower().Trim())
            {              
                case "coding":
                    funValue = 10;
                    message = "You must be a coding whiz!";
                    break;
                case "streaming":
                case "reading":
                    funValue = 9;
                    message = "that is a close second.";
                    break;
                case "mowing the lawn":
                case "nascar":
                    funValue = 4;
                    message = "I don't know why you think this is fun";
                    break;
                default:
                    funValue = 1;
                    message = "that's no fun";
                    break;
            }

            return funValue;
        }

        public static int GetUserAge()
        {
            Console.WriteLine("How old are you?");
            string userInput = Console.ReadLine();
            int userAge = -1;

            bool isValid = ValidateNumber(userInput, 5, 106, out userAge);
                     
            CalculateUserAgeDifference(userAge, 50);
            
            return userAge;
        }

        public static void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public static int AddNumbers()
        {
            int answer = 2 + 2;
            string test = "";

            // return test; WON'T WORK
            return answer;
        }
 

         public static string GetQuote(string sentence)
        {
            int locationOfQuote = sentence.IndexOf("\"");
            int locationOfLastQuote = sentence.LastIndexOf("\"");
            string actualQuote = sentence.Substring(locationOfQuote + 1, locationOfLastQuote - locationOfQuote - 1);
            return actualQuote;
        }

        public static void DoStringManipulation()
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
                string extractedQuote = GetQuote(quote); ;
           
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


        }
    }
}
