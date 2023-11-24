using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1.MauvaiseHeritage
{
    class Carre : Rectangle            /* un carré "is a" rectangle */
    {
        public Carre(double c) : base(c,c)
        {            
        }

        /* 
         * Il faut que le carré continue à être carré quand on change ses côtés.	
         * Alors, nous avons besoin de faire l'Override des méthodes SetC et SetD
         */
      
    public override void SetC(double c)
        {
            if (c < 0) { c = -1 * c; }
            base.SetC(c);
            base.SetD(c);
        }

    public override void SetD(double d)
        {
            if (d < 0) { d = -1 * d; }
            base.SetC(d);
            base.SetD(d);
        }
    }
}
