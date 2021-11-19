using System;
using System.Collections.Generic;
using System.Text;
using AhbcOctoberWeekSix;

namespace AhbcOctoberWeekSix
{
    public class ArithmeticHelper
    {
        public int Sum(int firstNumber, int secondNumber)
        {
            if (firstNumber == secondNumber)
            {
                throw new InvalidOperationException();
            }
            else
            {
                return firstNumber + secondNumber;
            }
            
        }
    }
}
