using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "abcdefgh";
            Console.WriteLine("s = " + s);

            string sr1 = new string(s.Reverse().ToArray());

            string sr2 = s.Reverse().ToString();

            Console.WriteLine("sr1 = " + sr1);
            Console.WriteLine("sr2 = " + sr2);

            string sr3 = s.MyReverse();
            Console.WriteLine("sr3 = " + sr3);

            Console.ReadKey();
        }
    }
}
