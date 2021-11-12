using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcOctoberWeekFive
{
    public class Dog : Mammal, ILiveBirthGiver
    {
      

        public sealed override string Speak()
        {
            return "woof";
        }

        public override string GoPotty()
        {
            return "made small mess";
        }

        public sealed override void Move(string newLocation)
        {
            GoPotty();
            Location = newLocation;
        }

        public void GiveLiveBirth()
        {
            throw new NotImplementedException();
        }

        //public override void Sleep(int hours)
        //{
        //    int sleepTime = hours;
        //}
    }
}
