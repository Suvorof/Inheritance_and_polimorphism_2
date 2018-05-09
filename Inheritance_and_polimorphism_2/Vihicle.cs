using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polimorphism_2
{
    class Vihicle
    {
        private double coordinateX, coordinateY;
        private double price, speed, year_of_construction;

        public double CoordinateX
        {
            get { return coordinateX; }
            set { coordinateX = value; }
        }

        public double CoordinateY
        {
            get { return coordinateY; }
            set { coordinateY = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public double Year_of_construction
        {
            get { return year_of_construction; }
            set { year_of_construction = value; }
        }

        public Vihicle(double CoordinateX, double CoordinateY, double Price, double Speed, double Year_of_construction)
        {
            this.CoordinateX = CoordinateX;
            this.CoordinateY = CoordinateY;
            this.Price = Price;
            this.Speed = Speed;
            this.Year_of_construction = Year_of_construction;
        }
    }
}
