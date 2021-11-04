using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AhbcOctoberWeekFour
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What color is this text");
            Console.ReadKey();
            WorkWithClasses();
            
            WorkWithRegEx();
            WorkWithEnums();
            WorkWithLINQ();
            WorkWithLambda();

            Console.WriteLine("Enter your name.");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter a number.");
            int firstInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number.");
            int secondInput = int.Parse(Console.ReadLine());

            int calculationAnswer;
            calculationAnswer = Calulate(firstInput, secondInput);       

            calculationAnswer = Calculator.AddTwoNumbers(firstInput, secondInput);

            Console.ReadLine();
        }

        public static int Calulate(int firstNumber, int secondNumber)
        {
            int answer = firstNumber + secondNumber;
            return answer;
        }

        public static void WorkWithClasses()
        {
            string message = "";
            Book currentBook = new Book(
                "Hitchhikers Guide","Funny book about space travel",400);
            //currentBook.title = "Hitchhikers Guide";
            //currentBook.authors.Add("Douglas Adams");
            message = currentBook.AddAuthor("Douglas Adams");
            currentBook.CopyrightDate = DateTime.Parse("01/01/1980");
            System.Console.WriteLine(currentBook.Title);
            currentBook.Title = "new title";

            List<Book> hitchhikerSeries = new List<Book>();
            // Create the book
            Book bookOne  = new Book(
                "Hitchhikers Guide", "Funny book about space travel",400);

            //bookOne.title = "Hitchhikers Guide Two";
            //bookOne.authors.Add("Douglas Adams");
            message = bookOne.AddAuthor("Douglas Adams");
            Console.WriteLine(message);
            bookOne.CopyrightDate = DateTime.Parse("01/01/1980");
            // Add the book
            hitchhikerSeries.Add(bookOne);

            // Create Next Book
            Book bookLast = new Book(
                "So Long and Thanks for all the Fish", "Funny book about space travel", 400);
            //bookLast.authors.Add("Douglas Adams");
            //bookLast.title = "So Long and Thanks for all the Fish";

            Book secondBook = new Book(
                "Restaurant at the end", "Funny book about space travel",400);
                     

        }
        public static void WorkWithRegEx()
        {
            // Regular Expressions (RegEx)
            string pattern = "^[a-zA-Z]+$";
            pattern = "[a-zA-Z0-9]+$";

            string namePattern = "^[A-Z][a-zA-Z]+ [A-Z][a-zA-Z]+[a-zA-Z ]*";
            string streetAddressPattern = "^[0-9]+ [A-Z][a-zA-Z ]+$";
            string zipCode = "^[0-9]{5}$ [0-9]{0,4}";
            string ssn = "^[0-9]{3}-[0-9]{2}-[0-9]{4}$";
            string canadianPostalCode = "^[A-Z][0-9][A-Z] [0-9][A-Z][0-9]$";
            string websiteURl = "^[w|W]{3}.[A-Za-z0-9_]+.[A-Za-z]{2,4}$";

            pattern = "[a-zA-Z0-9]+$";
            Regex regex = new Regex(pattern);
            Console.WriteLine("What is your name");
            string input = Console.ReadLine();
            bool isMatch = regex.IsMatch(input);

            if (isMatch == false)
            {
                Console.WriteLine("Bad Input");
            }
            Console.ReadKey();



        }
        public static void WorkWithEnums()
        {
            Dictionary<string, BookGenre> bookCollection = new Dictionary<string, BookGenre>();

            // 1 = sci fi, 2 = mystery, 3 = non-fiction, 4 = personalDevelopment, 5 = romance

            bookCollection.Add("Dune", BookGenre.Mystery);
            bookCollection.Add("Green Lights", BookGenre.NonFiction);
            bookCollection.Add("Find Your Why", BookGenre.PersonalDevelopment);

            Console.WriteLine("add a book");
            Console.WriteLine("book title?");
            string bookTitle = Console.ReadLine();
            Console.WriteLine("book genre");
            Console.WriteLine("1 = sci fi, 2 = mystery, 3 = non-fiction, 4 = personalDevelopment, 5 = romance");
            BookGenre userBookGenre = (BookGenre) int.Parse(Console.ReadLine());

            bookCollection.Add(bookTitle,userBookGenre);

            switch (userBookGenre)
            {
                case BookGenre.SciFi:

                    break;
                case BookGenre.Romance:

                    break;
                case BookGenre.Western:

                    break;
                case BookGenre.PersonalDevelopment:

                    break;
                case BookGenre.NonFiction:

                    break;
                case BookGenre.Mystery:
                    break;
                default:
                    break;
            }

            Dictionary<string, BookStatus> librayCollection = new Dictionary<string, BookStatus>();
            librayCollection.Add("Dune", BookStatus.CheckedOut);
            librayCollection.Add("Green Lights", BookStatus.OnShelf);
            librayCollection.Add("Find Your Why", BookStatus.OnShelf);

            Console.WriteLine("There are the available books.");
            foreach (var item in librayCollection.Where(x => x.Value == BookStatus.OnShelf))
            {
                Console.WriteLine(item.Key);
            }

            if (librayCollection[bookTitle] == BookStatus.CheckedOut)
            {
                Console.WriteLine($"Sorry {bookTitle} is checked out.");
                Console.WriteLine($"Sorry "+ bookTitle + " is checked out.");
                Console.WriteLine(string.Format("The book {0} is {1}.", bookTitle, librayCollection[bookTitle].ToString()));
            }


        }
        public static void WorkWithLINQ()
        {
            List<string> movies = new List<string>() { "Dune", "Jurassic Park", "Planet of the Apes", "Venom", "Friday the 13th" };

            foreach (string movie in movies)
            {
                Console.WriteLine(movie);
            }

            movies.Reverse(); // permanently changes the order of the list

            foreach (string movie in movies)
            {
                Console.WriteLine(movie);
            }

            Console.WriteLine($"The first movie in the list is {movies.First()}");
            List<int> payChecks = new List<int>() { 100, 233, 32, 236, 6543 };

            // Console.Clear();           

            Console.WriteLine($"your biggest paycheck is {payChecks.Max()}");
            Console.WriteLine($"your smallest paycheck is {payChecks.Min()}");

            // payChecks.Clear();

            if (payChecks.FirstOrDefault() > 100)
            {
                Console.WriteLine("YEAH");
            }
            else
            {
                Console.WriteLine("Boo");
            }

            // Reverse as string
            string longString = "asdfghjkl";

            char[] stringChar = longString.ToCharArray();
            stringChar.Reverse();
        }
        public static bool GetVotingLegallity(int age)
        {
            if (age < 17)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static void WorkWithLambda()
        {
            // x => x.[something]
            List<string> movies = new List<string>() { "Dune", "Jurassic Park", "Planet of the Apes", "Venom", "Friday the 13th", "Peter Pan"};

            List<int> payChecks = new List<int>() { 100, 233, 32, 236, 6543 };

            foreach (var item in payChecks.Where(paycheck => paycheck > 100))
            {
                Console.WriteLine(item.ToString());
            }

            // movies.Where(x => x.StartsWith("P"));

            foreach (var item in movies.Where(x => x.StartsWith("P")))
            {
                Console.WriteLine(item);
            }
            // payChecks.Where(paycheck => paycheck > 100);

            movies.Sort();
            foreach (var item in movies)
            {
                Console.WriteLine(item);
            }

            movies.Reverse(); // Sorts in descending order

            foreach (var item in movies)
            {
                Console.WriteLine(item);
            }    
        }


    }
}
