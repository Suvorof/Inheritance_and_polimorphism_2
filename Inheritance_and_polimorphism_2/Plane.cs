using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polimorphism_2
{
    class Plane : Vihicle
    {
        private double altitude;
        private int passengers_quant;

        public double Altitude
        {
            get { return altitude; }
            set { altitude = value; }
        }

        public int Passengers
        {
            get { return passengers_quant; }
            set { passengers_quant = value; }
        }

        public Plane (double CoordinateX, double CoordinateY, double Price, double Speed, double Year_of_construction)
            : base (CoordinateX, CoordinateY, Price, Speed, Year_of_construction)
        {
            Altitude = 7000;
            Passengers = 90;
        }
    }
}
