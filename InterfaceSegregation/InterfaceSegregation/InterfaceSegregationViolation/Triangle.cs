using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationViolation
{
    class Triangle : IShape
    {
        private int s1, s2, s3; 

        public int S1
        {
            get => s1;
            set { s1 = (value < 0) ? 0 : value;  }
        }
        public int S2
        {
            get => s2;
            set { s2 = (value < 0) ? 0 : value; }
        }
        public int S3
        {
            get => s3;
            set { s3 = (value < 0) ? 0 : value; }
        }

        public Triangle(int s1, int s2, int s3)
        {
            this.S1 = s1;
            this.S2 = s2;
            this.S3 = s3;
        }

        public List<int> ListSides()
        {
            return new List<int>(new int[] { S1, S2, S3 });
        }

        public int Perimeter()
        {
            return S1+S2+S3;
        }
        public double Area()
        {
            double sp = this.Perimeter() / 2.0;  // semi-perimètre
            return Math.Sqrt(sp * (sp - S1) * (sp - S2) * (sp - S3));  // formule d'Heron
        }
        public double Volume()   // info inutile présente seulement pour satisfaire l'interface
        {
            return 0;
        }
    }
}
