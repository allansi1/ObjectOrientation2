using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationViolation
{
    class Cube : IShape
    {
        private int e;

        public int E
        {
            get => e;
            set { e = (value < 0) ? 0 : value; }
        }

        public Cube(int e)
        {
            this.E = e;
        }

        public List<int> ListSides()
        {
            return new List<int>(new int[] { E });
        }

        public int Perimeter()    // info inutile présente seulement pour satisfaire l'interface
        {
            return -1;
        }
        public double Area()
        {
            return 6 * E * E;
        }
        public double Volume()
        {
            return Math.Pow(E,3);
        }
    }
}
