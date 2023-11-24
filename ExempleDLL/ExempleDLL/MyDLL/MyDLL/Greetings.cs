using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDLL
{
    public class Greetings
    {
        public static String Msg()
        {
            return "Bonjour";
        }
    }

    public static class MyExtensions
    {
        public static string MyReverse(this string a)
        {
            return new String(a.Reverse().ToArray());
        }
    }
}
