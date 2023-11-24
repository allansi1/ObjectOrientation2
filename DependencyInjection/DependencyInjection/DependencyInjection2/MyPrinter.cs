using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection2b
{
    class MyPrinter
    {
        private string s; 
        public string S
        {
            private get { return s; }
            set { s = value; }         // injection de dépendance -- mutateur
        }  

        public MyPrinter() { }

        public void PrintUpper()
        {
            Console.WriteLine(S.ToUpper()); 
        }

        public void PrintLower()
        {
            Console.WriteLine(S.ToLower());
        }

        public void PrintReverse()
        {
            char[] temp = S.ToCharArray();
            Array.Reverse(temp);
            Console.WriteLine(new string(temp));
        }
    }
}
