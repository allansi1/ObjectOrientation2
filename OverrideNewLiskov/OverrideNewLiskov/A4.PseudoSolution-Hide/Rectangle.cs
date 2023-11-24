using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4.PseudoSolution
{
    class Rectangle
    {
        private double c;
        private double d;

        public Rectangle(double c, double d)
        {
            SetC(c);
            SetD(d);
        }

        public double GetC()
        {
            return c;
        }
        public void SetC(double c)
        {
            if (c < 0) { this.c = -1 * c; }
            else { this.c = c; }
        }
        public double GetD()
        {
            return d;
        }
        public void SetD(double d)
        {
            if (d < 0) { this.d = -1 * d; }
            else { this.d = d; }
        }

        public override String ToString()
        {
            return "Rectangle [c=" + c + ", d=" + d + "]";
        }

        public double Aire()
        {
            return c * d;
        }

        public double Perimetre()
        {
            return 2 * (c + d);
        }
    }
}
