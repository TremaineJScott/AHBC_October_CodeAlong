using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcOctoberWeekFive
{
    public abstract class Animal
    {
        public string EyeColor { get; set; }
        public int Height { get; set; }        
        public int Weight { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }
        public string FoodType { get; set; }
        public virtual void Grow(int growthAmount)
        {
            Height = Height + growthAmount;
        }
        public void AgeAnimal(int numberOfYears)
        {
            Age +=  numberOfYears;
        }

        public virtual void Move(string newLocation)
        {
            Location = newLocation;
        }
        public abstract string Speak();

        public abstract string GoPotty();

        public string Sleep(int hours)
        {
            return $"Your animal slept for {hours} hours";
        }

        /// <summary>
        /// The method to allow the animal to sleep
        /// </summary>
        /// <param name="hours">The number of hours the animal slept</param>
        /// <param name="location">The location of the sleeping</param>
        /// <returns></returns>
        public string Sleep(int hours, string location)
        {
            return $"Your animal slept for {hours} hours at {location}";
        }

        public string Sleep(int hours, int  minutes)
        {
            return $"Your animal slept for {hours} hours and {minutes} minutes";
        }

        public string Sleep(string location, int partners)
        {
            return $"Your animal slept at {location} with {partners} friends";
        }

        public string Sleep(string location)
        {
            return $"Your animal slept at {location}";
        }
    }
}
