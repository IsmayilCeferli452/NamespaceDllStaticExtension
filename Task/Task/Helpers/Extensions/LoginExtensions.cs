using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Helpers.Extensions
{
    internal static class LoginExtensions
    {
        public static bool CheckEmail(this string email, char symbol)
        {
            return email.Contains(symbol);
        }

        public static bool CheckPassword(this string password)
        {
            return password.Length > 8;
        }
    }
}
