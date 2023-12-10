using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Extensions
{
    public static class BoolExtensions
    {
        public static bool IsValid(this string str)
        {
            return !String.IsNullOrEmpty(str);
        }
    }
}
