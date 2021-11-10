using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcOctoberWeekFive
{
    public class Labradoodle : Dog 
    {
        public int AwesomenessLevel { get; set; }

        public override string GoPotty()
        {
            return "made big mess";
        }
              
    }
}
