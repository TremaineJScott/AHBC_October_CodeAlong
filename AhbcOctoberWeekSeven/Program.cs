using System;
using System.IO;
using System.Collections.Generic;

namespace AhbcOctoberWeekSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString; 
            string newTest;
            List<Pokemon> savedList = FileHelper.BuildPokemonList(@"c:\code\pokemonList.txt");
            string namePath = @"c:\code\file1.txt";
            FileHelper.WriteToFile(namePath, "My name is scott");
            FileHelper.AppendToFile(namePath, "This is more stuff");
            FileHelper.AppendToFile(namePath, "Even more stuff");
            FileHelper.AppendToFile(namePath, "And more stuff");
            Pokemon pokemon = new Pokemon()
            {
                Name = "Ralts",
                Type = "Psychic",
                Attack = "Confusion"
            };

            FileHelper.AddPokemonToFile(@"c:\code\pokemonList.txt", pokemon);

            Console.WriteLine("Read Line");
            Console.WriteLine(FileHelper.ReadFirstLine(namePath));

            Console.WriteLine("Read File");
            Console.WriteLine(FileHelper.ReadEnterFile(namePath));

            Console.ReadKey();
        }
    }
}
