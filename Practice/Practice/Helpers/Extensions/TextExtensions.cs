using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Helpers.Extensions
{
    internal static class TextExtensions
    {
        public static int GetLength(this string text)
        {
            return text.Length;
        } 

        public static bool CheckCharInText(this string text, char letter)
        {
            return text.Contains(letter);
        }

        public static int CountOfCharInText(this string text, char letter)
        {
            return text.Where(x => x == letter).Count();
        }
    }
}
