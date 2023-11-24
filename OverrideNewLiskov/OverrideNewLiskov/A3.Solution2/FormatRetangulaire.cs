using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3.Solution2
{
    abstract class FormatRetangulaire
    {
        protected double c;
        protected double d;

        public double GetC()
        {
            return c;
        }

        public double GetD()
        {
            return d;
        }

        
        public override String ToString()
        {
            return "Rectangle [c=" + c + ", d=" + d + "]";
        }

        public double Aire()
        {                              /* pas virtual pour ne pas être "overrided" 
		                                 dans les classes dérivées */
            return c * d;
        }

        public double Perimetre()
        {                              /* pas virtual pour ne pas être "overrided" 
		                                  dans les classes dérivées */
            return 2 * (c + d);
        }
    }
}
