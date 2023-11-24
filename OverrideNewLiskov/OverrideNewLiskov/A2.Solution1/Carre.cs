using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2.Solution1
{
    class Carre : Rectangle            /* un carré "is a" rectangle */
    {
        public Carre(double c) : base(c,c)
        {            
        }      
    }
}
