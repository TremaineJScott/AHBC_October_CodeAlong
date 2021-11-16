using System;
using System.Collections.Generic;
using System.Text;

namespace AhbcOctoberWeekSix
{
    public class Customer: Person
    {      
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public bool PassedCreditCheck { get; set; }

        public void UpdateCreditCheckFlag(bool value)
        {
            PassedCreditCheck = value;
        }
    }
}
