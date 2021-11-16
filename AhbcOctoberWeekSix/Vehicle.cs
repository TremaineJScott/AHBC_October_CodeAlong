using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcOctoberWeekSix
{
    public class Vehicle
    {
        double currentAcceleration;
        public double CurrentAcceleration {get;set;}



        public virtual void Accelerate(double accelerationRate)
        {             
            currentAcceleration += accelerationRate;
        }
        public void Brake(double decelerationRate)
        {
            currentAcceleration -= decelerationRate;
        }
    }
}
