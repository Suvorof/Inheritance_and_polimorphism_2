using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polimorphism_2
{
    class Car : Vihicle
    {
        public Car (double CoordinateX, double CoordinateY, double Price, double Speed, double Year_of_construction)
            : base (CoordinateX, CoordinateY, Price, Speed, Year_of_construction)
        {

        }
    }
}
