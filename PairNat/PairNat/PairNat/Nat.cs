using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairNat
{
    class Nat
    {
        private int n;

        public int N    // This is a property
        {
            get { return n; }
            set
            {
                if (value < 0) { n = -1* value; }
                else { n = value; }
            }
        }

        public Nat(int x)
        {
            N = x;
        }

        public virtual Nat Next()
        {
            return new Nat(N+1);
        }
    }
}
