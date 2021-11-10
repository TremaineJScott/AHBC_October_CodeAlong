using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcOctoberWeekFive
{
    public class Fish : Animal
    {
        public int Length { get; set; }
        public string WaterType { get; set; }

        public override string GoPotty()
        {
           return "nobody noticed";
        }

        public override void Grow(int growthAmount)
        {
            Length = Length + growthAmount;
        }

        public override void Sleep(int hours)
        {
            int sleepTime = hours;
        }

        public override string Speak()
        {
            return "glub";
        }
    }
}
