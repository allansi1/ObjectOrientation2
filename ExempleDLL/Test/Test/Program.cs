using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDLL;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Greetings.Msg());
            String a = "abc";
            Console.WriteLine(MyExtensions.MyReverse(a));
            Console.WriteLine(Greetings.Msg().MyReverse());
            Console.WriteLine(MyExtensions.MyReverse(Greetings.Msg()));
            Console.ReadKey();
        }
    }
}
