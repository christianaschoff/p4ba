using System;
using Contract;
using Rules;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
            IFizzBuzzCalculator calculator = new FizzBuzzCalculator();
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine(calculator.FizzBuzz(i));
            }
        }
    }
}
