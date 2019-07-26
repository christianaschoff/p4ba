using System;
using Contract;

namespace Rules
{
    public class FizzBuzzCalculator : IFizzBuzzCalculator
    {
        public string FizzBuzz(int number)
        {
            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException("Nur Nummern zwischen 1 und 100 erlaubt");
            }

            if ((number % 5 == 0) && (number % 7 == 0))
            {
                return "fizzbuzz";
            }
            if (number % 5 == 0)
            {
                return "fizz";
            }
            if (number % 7 == 0)
            {
                return "buzz";
            }
            return number.ToString();
        }
    }
}
