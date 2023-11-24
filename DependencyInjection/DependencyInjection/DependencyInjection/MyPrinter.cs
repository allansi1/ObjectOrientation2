using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection1
{
    class MyPrinter
    {
        private string s;

        public MyPrinter(string s)  // injection de dépendance -- constructeur
        {
            this.s = s;
        }

        public void PrintUpper()
        {
            Console.WriteLine(s.ToUpper()); 
        }

        public void PrintLower()
        {
            Console.WriteLine(s.ToLower());
        }

        public void PrintReverse()
        {
            char[] temp = s.ToCharArray();
            Array.Reverse(temp);
            Console.WriteLine(new string(temp));            
        }
    }
}
