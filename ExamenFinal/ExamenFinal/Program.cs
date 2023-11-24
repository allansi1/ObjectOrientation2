using Fractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(3, 5);
            Fraction f2 = new Fraction(2, 3);
            Fraction f3 = new Fraction(2, 1);
            Console.WriteLine();

            //Fraction fraction = new Fraction(2, 0);
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(f3);
            Console.WriteLine("GCD 36/20: " + Fractions.Fraction.GCD(36, 20));
            Console.WriteLine("Add 3/5 + 2/3: " + f1.Add(f2));
            Console.WriteLine("Substract 3/5 - 2/3:: " + f1.Subtract(f2));
            Console.WriteLine("Multiply: 3/5 * 2/3: " + f1.Multiply(f2));
            Console.WriteLine("Invert 3/5: " + f1.Invert());
            //Console.WriteLine("Invert 0/5:" + new Fraction(0,5).Invert());
            Console.WriteLine("Division:3/5 / 2/3 " + f1.Divide(f2));
            //Console.WriteLine("Division par 0:" + f1.Divide(new Fraction(0,5)));
            Console.WriteLine("Equals: 3/5 = 3/5 " + f1.Equals(new Fraction(3, 5)));
            Console.WriteLine("To double (3/5): " + f1.ToDouble());
            Console.WriteLine();

            List<Fraction> list = new List<Fraction>();
            list.Add(f1);
            list.Add(f2);
            list.Add(f3);
            list.Add(new Fraction(-1, 6));
            Console.WriteLine("List is by default sorted by the inclusion order");
            foreach (Fraction f in list)
                Console.WriteLine(f);
            Console.WriteLine();

            Console.WriteLine("List sorted by ascending order (default order)");
            list.Sort();
            foreach (Fraction f in list)
                Console.WriteLine(f);
            Console.WriteLine();

            Console.WriteLine("List sorted descending order");
            list.Sort();
            list.Reverse();
            foreach (Fraction f in list)
                Console.WriteLine(f);
            Console.WriteLine();

            int[] coefficients = new int[] {0,2,2};            
            ContinuedFraction continuedFraction = new ContinuedFraction(coefficients);
            Fraction f4 = continuedFraction.ToFraction();
            Console.WriteLine("Fraction : " + f4);
            Console.WriteLine("ContinuedFraction" + continuedFraction.ToString());
            Console.WriteLine("ToDouble(): " + continuedFraction.ToDouble());
            Console.WriteLine();

            Fraction f5 = new Fraction(2, 5);
            ContinuedFraction continuedFraction2 = f5.ToContinuedFraction();
            Console.WriteLine("Fraction: " + f5);
            Console.WriteLine("Continued Fraction: " + continuedFraction2);
            Console.WriteLine("ToDouble(): " + continuedFraction2.ToDouble());
            Console.WriteLine();

            Fraction f6 = new Fraction(-2, 5);
            ContinuedFraction continuedFraction3 = f6.ToContinuedFraction();
            Console.WriteLine("Fraction: " + f6);
            Console.WriteLine("Continued Fraction: " + continuedFraction3);
            Console.WriteLine("ToDouble(): " + continuedFraction3.ToDouble());

            //int[] coefficients2 = new int[] { 0, -2, -2 };
            //ContinuedFraction continuedFraction4 = new ContinuedFraction(coefficients2);
            //Fraction f7 = continuedFraction4.ToFraction();
            //Console.WriteLine("Fraction : " + f7);
            //Console.WriteLine("ContinuedFraction" + continuedFraction4.ToString());

            Console.ReadKey();
        }
    }
}
