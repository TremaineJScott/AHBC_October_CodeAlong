using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MockAssessmentTwo
{
    public class StarWarsHelper
    {
        public int AddStarWarsCharacters(string[] characters)
        {
            int returnValue = -1;
            if (string.IsNullOrEmpty(characters[0]))
            {
                throw new ArgumentNullException();
            }
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

        // April
        public string DeathStarCombat(Dictionary<string, int> combat)
        {
            int maxAttack = combat.Values.Max();
            string strongest = combat.Where(x => x.Value == maxAttack).First().Key;
            return strongest;
        }

        // Steve
        public List<string> ConvertPlanets(string[] planets)
        {
            List<string> reversedPlanets = planets.Reverse().ToList();
            return reversedPlanets;
        }

        public double AverageDroids(List<int> droids)
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

        // Ed
        public string TryToCatchDarthVader(string value)
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
