using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDLL;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Greetings.Msg());

            string s = "Bonsoir";

            Console.WriteLine("s = "+ s);
            Console.WriteLine("s.MyReverse() = " + s.MyReverse());

            Console.ReadKey();

        }
    }
}
