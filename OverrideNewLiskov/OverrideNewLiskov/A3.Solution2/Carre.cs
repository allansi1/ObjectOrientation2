using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3.Solution2
{
    class Carre : FormatRetangulaire
    {
        public Carre(double c)
        {
            SetC(c);
            // SetD(c);
        }

        /* 
         * Il faut que le carré continue à être carré quand on change ses côtés.
         */

        public void SetC(double c)
        {
            if (c < 0) { c = -1 * c; }
            this.c = c;
            this.d = c;
        }

        public void SetD(double d)
        {
            if (d < 0) { d = -1 * d; }
            this.c = d;
            this.d = d;
        }
    }
}
