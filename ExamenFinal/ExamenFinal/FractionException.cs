using Fractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class FractionException : Exception
    {
        private int code;
        private Object obj;
        private String msg;

        public int Code { get => code; }
        public Object Obj { get => obj; }
        public override string Message { get => msg; }

        internal FractionException(int code, Object obj)
        {
            this.code = code;
            this.obj = obj;
            if (code == 1)
                this.msg = "Error: Denominator = 0 ";
            else if (code == 2)
                this.msg = "Fraction" + (Fraction)obj + "non-invertible";
            else if (code == 3)
                this.msg = "Cannot divide by fraction" + (Fraction)obj;
            else if (code == 4)
                this.msg = "Invalid continued fraction: <tableaux d'entier>" + (Fraction)obj;
            else
                this.msg = "Unknown exception";
        }


    }
}
