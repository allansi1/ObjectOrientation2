using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3.Solution2
{
    class Rectangle : FormatRetangulaire
    {
        public Rectangle(double c, double d)
        {
            SetC(c);
            SetD(d);
        }

        public void SetC(double c)
        {
            if (c < 0) { this.c = -1 * c; }
            else { this.c = c; }
        }

        public void SetD(double d)
        {
            if (d < 0) { this.d = -1 * d; }
            else { this.d = d; }
        }
    }
}
