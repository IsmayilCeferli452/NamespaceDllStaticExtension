using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Services;

namespace Task.Controllers
{
    internal class CalculatorController
    {
        public CalculatorService _calculatorService;

        public CalculatorController()
        {
            _calculatorService = new CalculatorService();
        }

        public void Calculator()
        {
            Console.WriteLine("Please add first number:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please add operation:");
            char operation = char.Parse(Console.ReadLine());

            Console.WriteLine("Please add second number:");
            int number2 = int.Parse(Console.ReadLine());

            var result = _calculatorService.Calculation(number1,number2,operation);

            Console.WriteLine(result);
        }
    }
}
