using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcOctoberWeekSix
{
    public class TurboCar: Car
    {
        public override void Accelerate(double accelerationRate)
        {
            CurrentAcceleration = CurrentAcceleration + accelerationRate * 2;
        }
    }
}
