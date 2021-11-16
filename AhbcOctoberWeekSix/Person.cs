using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcOctoberWeekSix
{
    public abstract class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
