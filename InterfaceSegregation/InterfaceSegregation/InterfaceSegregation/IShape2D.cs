using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    interface IShape2D
    {
        List<int> ListSides();

        int Perimeter();
        double Area();
    }
}
