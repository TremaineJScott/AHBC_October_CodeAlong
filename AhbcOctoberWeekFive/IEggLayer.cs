using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcOctoberWeekFive
{
    public interface IEggLayer
    {       
        int IncubationTime { get; set;}
        bool LayEggs();
    }
}
