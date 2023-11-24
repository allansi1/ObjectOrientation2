using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    interface IShape3D
    {
        List<int> ListEdges();

        double Area();
        double Volume();
    }
}
