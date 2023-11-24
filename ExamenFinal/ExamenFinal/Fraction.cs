using ExamenFinal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Fractions

{
    public class Fraction : IComparable<Fraction>
    {

        private int n;
        private int d;

        public int Numerator
        {
            get
            {
                return n;
            }
            protected set
            {
                this.n = value;
            }
        }
        public int Denominator
        {
            get
            {
                return d;
            }
            protected set
            {
                if (value == 0)
                {
                    throw new FractionException(1, value);
                }
                else
                {
                    this.d = value;
                }
            }
        }

        public Fraction(int n, int d)
        {
            if (d < 0)
            {
                Numerator = -n;
                Denominator = -d;
            }
            else
            {
                Numerator = n;
                Denominator = d;
            }


        }

        public override string ToString()
        {
            if (Denominator == 1)
            {
                return "Fraction: " + Numerator;
            }
            else
            {
                return "Fraction:" + Numerator + "/" + Denominator;
            }
        }

        public double ToDouble()
        {
            return (double)Numerator / Denominator;
        }

        public static int GCD(int a, int b)
        {
            if (a != 0 || b != 0)
            {
                a = Math.Abs(a);
                b = Math.Abs(b);
                int dividend = a;
                int divisor = b;
                double quotient;
                int rest;
                while (divisor != 0)
                {

                    /* 
                     Dividende: 36; Diviseur: 20; Quotient: 1; Reste: 16
                    Dividende:      20 (le diviseur antérieur); Diviseur: 16 (le reste antérieur); 
                    Quotient: 1; Reste: 4 Dividende: 16 (le diviseur antérieur); 
                    Diviseur: 4 (le reste antérieur); Quotient: 4; Reste: 0  
                     */

                    quotient = dividend / divisor;
                    rest = dividend % divisor;
                    dividend = divisor;
                    divisor = rest;

                }
                return dividend;

            }
            else
            {
                return 0;
            }


        }

        public Fraction Simplify()
        {
            int gcd = GCD(Numerator, Denominator);
            int simpleNum = Numerator / gcd;
            int simpleDen = Denominator / gcd;

            return new Fraction(simpleNum, simpleDen);
        }

        public Fraction Add(Fraction f)
        {
            int commonDen = Denominator * f.Denominator;
            int num1 = Numerator * f.Denominator;
            int num2 = f.Numerator * Denominator;
            int sum = num1 + num2;

            Fraction result = new Fraction(sum, commonDen);
            return result.Simplify();
        }

        public Fraction Subtract(Fraction f)
        {
            int commonDen = Denominator * f.Denominator;
            int num1 = Numerator * f.Denominator;
            int num2 = f.Numerator * Denominator;
            int diff = num1 - num2;

            Fraction result = new Fraction(diff, commonDen);
            return result.Simplify();
        }

        public Fraction Multiply(Fraction f)
        {
            int multiNum = Numerator * f.Numerator;
            int MultiDen = Denominator * f.Denominator;

            Fraction result = new Fraction(multiNum, MultiDen);
            return result.Simplify();
        }

        public Fraction Invert()
        {
            if (Numerator == 0)
            {
                throw new FractionException(2, this);
            }

            int invertedNum = Denominator;
            int invertedDen = Numerator;

            Fraction result = new Fraction(invertedNum, invertedDen);
            return result.Simplify();
        }

        public Fraction Divide(Fraction f)
        {
            if (f.Numerator == 0)
            {
                throw new FractionException(3, this);
            }

            Fraction invertedFraction = f.Invert();

            Fraction result = Multiply(invertedFraction);
            return result.Simplify();
        }
        public bool Equals(Fraction f)
        {

           return ((this.Numerator == f.Numerator) && (this.Denominator == f.Denominator));
        }

        public int CompareTo(Fraction f)
        {

            int result1 = this.Numerator * f.Denominator;
            int result2 = f.Numerator * this.Denominator;

            return result1.CompareTo(result2);

        }

        public ContinuedFraction ToContinuedFraction()
        {
            List<int> l = new List<int>();
            int dividend;
            int divisor ;
            int quotient, rest;
                                    
            dividend = Numerator;
            divisor = Denominator;
            quotient = (dividend / divisor);
            rest = (dividend % divisor) ;
            if (rest < 0)
            {
                quotient = quotient - 1;
                rest = rest + divisor;
            }
             dividend = divisor;
             divisor = rest;
             l.Add(quotient);                      
                        
                while (divisor != 0)
                {                    
                    quotient = dividend / divisor;
                    rest = dividend % divisor;
                    dividend = divisor;
                    divisor = rest;
                    l.Add(quotient);
                }                          

            return new ContinuedFraction(l.ToArray());
        }

    }

    public class ContinuedFraction
    {
        //private List<int> l = new List<int>();
        private int[] tab;

        public ContinuedFraction(int [] fracTab)
        {   
            for (int i = 1; i < fracTab.Length; i++)
            {
                if (fracTab[i] <= 0)
                {
                    throw new FractionException(4, fracTab[i]);
                }       
                
            }
            tab= fracTab;
        }

        public Fraction ToFraction()
        {
            int len = tab.Length;
            Fraction r = new Fraction(tab[len-1], 1);
            
            for (int i = len-2; i >=0; i--)
            {
               r=new Fraction(tab[i], 1).Add(r.Invert());
            }          
            
           return r;
        }
        public override string ToString()
        {
            //return "[" + string.Join(", ", l) + "]";
            string result = "[" + tab[0];

            for (int i = 1; i < tab.Length; i++)
            {
                result += ", " + tab[i].ToString();
            }

            result += "]";
            return result;
        }

        public double ToDouble()
        {
            Fraction f = ToFraction();
            return f.ToDouble();            
        }
    }    

}

