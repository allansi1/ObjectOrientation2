using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairNat
{
    class Pair : Nat
    {
        public Pair(int x) : base(x)
        {
            if (N % 2 != 0) { N = N - 1; };
        }

        public override Nat Next()
        {
            return new Pair(N + 2);
        }
    }
}
