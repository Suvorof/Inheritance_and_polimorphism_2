using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polimorphism_2
{
    class Ship : Vihicle
    {
        private int passengers_quant;
        private string home_port;

        public int Passengers
        {
            get { return passengers_quant; }
            set { passengers_quant = value; }
        }

        public string Port
        {
            get { return home_port; }
            set { home_port = value; }
        }

        public Ship (double CoordinateX, double CoordinateY, double Price, double Speed, double Year_of_construction)
            : base (CoordinateX, CoordinateY, Price, Speed, Year_of_construction)
        {
            Passengers = 450;
            Port= "Wallaroo";
        }
    }
}
