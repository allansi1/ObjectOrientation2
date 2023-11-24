using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class MyExtensions   
    {
        /*
         * To create extension methods the class must be static.
         * The methods must also be static and 
         * the reserved word "this" must be before the first argument 
         * of the method and the type of the first argument must be
         * the type for which the extension method will apply.  
         */
        public static string MyPrefix(this string a)   
        {
            return "My" + a;
        }

        public static string MyPrefix(this string a, string b)
        {
            return b + a;
        }

        public static string Reverse1(this string a)
        {
            char[] temp = a.ToCharArray();
            Array.Reverse(temp);                  // using the Array.Reverse(char[]) of Array
            return new string(temp);
        }

        public static string Reverse2(this string a)
        {
            return new String(a.Reverse().ToArray());  // using the .Reverse() of IEnumeralble
        }

        public static bool IsPalindrome(this string a)
        {
            string t = a.ToUpper(); 
            return t == new String(t.Reverse().ToArray());  // using the .Reverse() of IEnumeralble
        }

        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }

        public static bool IsPrime(this int i)
        {
            bool prime = true;
            if (i<=1) { prime = false; }           
            for (int j=2; j<=Math.Sqrt(i) && prime; j++)
            {
                if (i%j ==0) { prime = false;}
            }
            return prime;
        }
    }
}
