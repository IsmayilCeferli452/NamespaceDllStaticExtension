using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Helpers.Extensions
{
    internal static class ArrayExtensions
    {
        public static int MultipleOfArrayElements(this int[] numbers)
        {
            int multiple = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                multiple *= numbers[i];
            }
            return multiple;
        }
    }
}
