using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcOctoberWeekSix
{
    public class OffRoadCar : Car
    {
        public double CurrentAltitude { get; set; }
        public void OffRoadAcceleration(double muliplier)
        {
            CurrentAcceleration *= muliplier;
        }      
            
        public void IncreaseAltitude (double muliplier)
        {
            CurrentAltitude *= muliplier;
        }



    }
}
