using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Helpers.Extensions
{
    internal static class MathExtensions
    {
        public static int AddFive(this int number)
        {
            return number + 5;
        }

        public static int SumOfNumbers(this int number1, int number2)
        {
            return (number1 + number2);
        }

        public static double SquareOfNumbers(this int number1)
        {
            return Math.Pow(number1, 2);
        }

        public static double PowerOfNums(this int number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
