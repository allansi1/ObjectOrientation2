using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1.NatPaireSolution
{
    class Program
    {
        public static void F(Nat x)
        {
            if (x.Succ().GetValeur() == x.Add(new Nat(1)).GetValeur())
            {
                Console.WriteLine("F dit OK");
            }
            else
            {
                throw new Exception();
            }
        }

        static void Main(string[] args)
        {
            Nat n = new Nat(5);
            F(n);
            Paire p = new Paire(6);
            F(p);

            Console.ReadKey();
        }
    }
}
