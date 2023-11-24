using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethods;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Bonjour";
            Console.WriteLine("s = " + s);
            Console.WriteLine("s.MyPrefix() = " + s.MyPrefix());  
            Console.WriteLine("s = " + s);
            Console.WriteLine("MyExtensions.MyPrefix(s) = " + MyExtensions.MyPrefix(s));
            Console.WriteLine("s = " + s);
            Console.WriteLine("\"Test\".MyPrefix() = " + "Test".MyPrefix());
            Console.WriteLine();

            Console.WriteLine("s = " + s);
            Console.WriteLine("s.MyPrefix(\"My-\") = " + s.MyPrefix("My-"));
            Console.WriteLine("s = " + s);
            Console.WriteLine("MyExtensions.MyPrefix(s, \"My-\") = " + MyExtensions.MyPrefix(s, "My-"));
            Console.WriteLine("s = " + s);
            Console.WriteLine("\"Test\".MyPrefix(\"My-\") = " + "Test".MyPrefix("My-"));
            Console.WriteLine();

            string s1 = s.Reverse1();
            Console.WriteLine("s = " + s);
            Console.WriteLine("s.Reverse1() = " + s1);
            Console.WriteLine();

            Console.WriteLine("Is \""+s+"\" a palindrome? " + s.IsPalindrome());
            string s2 = "Tadaradat";
            Console.WriteLine("Is \"" + s2 + "\" a palindrome? " + s2.IsPalindrome());
            Console.WriteLine();

            int j1 = 3;
            Console.WriteLine("Is " + j1 + " even? " + j1.IsEven());
            int j2 = 4;
            Console.WriteLine("Is " + j2 + " even? " + j2.IsEven());
            Console.WriteLine();

            for (int a=1; a<=20; a++)
            {
                Console.WriteLine("Is " + a + " prime? " + a.IsPrime());
            }
            
            Console.ReadKey();
        }
    }
}
