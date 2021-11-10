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

        public abstract void Sleep(int hours);     

    }
}
