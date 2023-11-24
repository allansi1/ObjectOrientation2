using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationViolation
{
    interface IShape
    {
        List<int> ListSides();

        int Perimeter();
        double Area();
        double Volume();
    }
}
