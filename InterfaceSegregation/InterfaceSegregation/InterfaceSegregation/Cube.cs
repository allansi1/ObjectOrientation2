using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class Cube : IShape3D
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

        public List<int> ListEdges()
        {
            return new List<int>(new int[] { E });
        }

        //public int Perimeter()    // info inutile présente seulement pour satisfaire l'interface
        //{
        //    return -1;
        //}
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
