using System;
using System.Collections.Generic;
using System.Linq;

namespace MockAssessmentTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] people = new string[] { "Luke", "Yoda", "Han" };
            int index = AddStarWarsCharacters(people);
            Console.WriteLine($"Yoda index = {index}");

            Dictionary<string, int> combatStats = new Dictionary<string, int>()
            {
                {"Luke",400},
                {"Leia", 12345},
                {"Yoda",1000},
                {"JarJar", 12345}
            };
            string strongest = DeathStarCombat(combatStats);
            Console.WriteLine($"The strongest warrior is {strongest}.");

            string[] planets = new string[] { "pluto", "neptune", "jupiter", "saturn" };
            List<string> reversedButNotAlphabeticalPlanets = ConvertPlanets(planets);
            foreach (string planet in reversedButNotAlphabeticalPlanets)
            {
                Console.WriteLine(planet);
            }

            List<int> droidList = new List<int>() { 2, 1, 3, 4, 5, 6, 6, 7, 8, 9, 10 };
            double averageDroid = AverageDroids(droidList);
            Console.WriteLine(averageDroid);

            Console.WriteLine(TryToCatchDarthVader("2"));
            Console.WriteLine(TryToCatchDarthVader("vader"));
            Console.ReadKey();
        }

        static int AddStarWarsCharacters(string[] characters)
        {
            int returnValue = -1;

            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == "Yoda")
                {
                    returnValue = i;
                    break;
                }
            }

            return returnValue;
        }

        static string DeathStarCombat(Dictionary<string,int> combat)
        {
            int maxAttack = combat.Values.Max();
            string strongest = combat.Where(x => x.Value == maxAttack).First().Key;
            return strongest;
        }

        static List<string> ConvertPlanets(string[] planets)
        {
            List<string> reversedPlanets = planets.Reverse().ToList();
            return reversedPlanets;
        }

        static double AverageDroids(List<int> droids)
        {
            List<int> evenDroids = new List<int>();

            foreach (int droid in droids)
            {
                if (droid % 2 == 0)
                {
                    evenDroids.Add(droid);
                }
            }

            double returnValue = evenDroids.Average();
            return returnValue;
        }

        static string TryToCatchDarthVader(string value)
        {
            try
            {
                int.Parse(value);
                return "Vader Was Captured!";
            }
            catch (FormatException)
            {
               return "Vader Got Away!";
            }
        }

    }
}
