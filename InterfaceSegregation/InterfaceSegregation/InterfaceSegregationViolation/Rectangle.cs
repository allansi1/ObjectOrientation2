using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationViolation
{
    class Rectangle : IShape
    {
        private int h;
        private int v;

        public int  H
        {
            get => h;
            set { h = (value < 0) ? 0 : value; }
        }
        public int V
        {
            get => v;
            set { v = (value < 0) ? 0 : value; }
        }

        public Rectangle(int h, int v)
        {
            this.H = h;
            this.V = v;
        }

        public List<int> ListSides()
        {
            return new List<int>(new int[] { H, V });
        }

        public int Perimeter()
        {
            return 2 * (H + V);
        }
        public double Area()
        {
            return H * V;
        }
        public double Volume()   // info inutile présente seulement pour satisfaire l'interface
        {
            return 0;
        }
    }
}
