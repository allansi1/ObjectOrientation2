using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairNat
{
    class Program
    {
        static public void F(Nat y)
        {
            int v1 = y.N;
            int v2 = y.Next().N;
            if(v2 == v1 + 1)
            {
                Console.WriteLine("OK");
            }
            else
            {
                throw new Exception();
            }
        }
        static void Main(string[] args)
        {
            Nat a = new Nat(5);
            Pair b = new Pair(4);
            F(a);
            F(b);

            Console.ReadKey();
        }
    }
}
