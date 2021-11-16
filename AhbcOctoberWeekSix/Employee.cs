using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcOctoberWeekSix
{
    public class Employee: Person 
    { 
        public long IdNumber { get; set; }
        public bool PassedBackgroundCheck { get; set; }

        public void UpdateBackgroundCheckFlag(bool value)
        {
            PassedBackgroundCheck = value;
        }


    }
}
