using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Services
{
    internal class CalculatorService
    {
        public int Calculation(int number1, int number2, char operation)
        {
            var result = 0;

            if (operation == '+' )
            {
                result = number1 + number2;
            }
            if(operation == '-')
            {
                result = number1 - number2;
            }
            if (operation == '*')
            {
                result = number1 * number2;
            }
            if (operation == '/')
            {
                result = number1 / number2;
            }
            return result;
        }
    }
}
