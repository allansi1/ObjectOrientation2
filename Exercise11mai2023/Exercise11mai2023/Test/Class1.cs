using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    static class MyExtensions
    {
        public static string MyReverse(this string a)
        {
            return new String(a.Reverse().ToArray());
        }
    }
}
