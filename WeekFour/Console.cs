using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcOctoberWeekFour
{
    public static class Console
    {

        public static void WriteLine(string text)
        {
            System.Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine(text);
            System.Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void ReadKey()
        {
            System.Console.WriteLine("Press any key to continue");
            System.Console.ReadKey();
        }
        public static string ReadLine()
        {
            return "what is in the console";
        }



    }
}
