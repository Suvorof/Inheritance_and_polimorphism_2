using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_polimorphism_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("<<<<<Ship>>>>>");
            Console.WriteLine("<<<<<Technical characteristics>>>>>");
            Ship kon_tiki = new Ship(256.4, 325.5, 2000000, 70, 1947);
            Console.WriteLine("Координаты корабля kon_tiki: {0} градусов юж. широты, {1} градусов вост. долготы", kon_tiki.CoordinateY, kon_tiki.CoordinateX);
            Console.WriteLine("Цена корабля kon_tiki: {0} $", kon_tiki.Price);
            Console.WriteLine("Скорость корабля kon_tiki: {0} км/ч", kon_tiki.Speed);
            Console.WriteLine("Год производства корабля kon_tiki: {0}", kon_tiki.Year_of_construction);
            Console.WriteLine("Возможное количество пассажиров корабля kon_tiki: {0}", kon_tiki.Passengers);
            Console.WriteLine("Порт приписки корабля kon_tiki: {0}, Australia", kon_tiki.Port);
            Console.WriteLine("\n");

            Console.WriteLine("<<<<<Plane>>>>>");
            Console.WriteLine("<<<<<Technical characteristics>>>>>");
            Plane tu_154 = new Plane(60.4, 57.7, 1200000, 600, 1965);
            Console.WriteLine("Координаты самолёта tu_154: {0} градусов юж. широты, {1} градусов вост. долготы", tu_154.CoordinateY, tu_154.CoordinateX);
            Console.WriteLine("Цена самолёта tu_154: {0} $", tu_154.Price);
            Console.WriteLine("Скорость корабля tu_154: {0} км/ч", tu_154.Speed);
            Console.WriteLine("Год производства корабля tu_154: {0}", tu_154.Year_of_construction);
            Console.WriteLine("Возможная высота самлолёта tu_154: {0} метров", tu_154.Altitude);
            Console.WriteLine("Возможное количество пассажиров tu_154: {0}", tu_154.Passengers);
            Console.WriteLine("\n");

            Console.WriteLine("<<<<<Car>>>>>");
            Console.WriteLine("<<<<<Technical characteristics>>>>>");
            Car reno_logan = new Car (156.3, 313.9, 9600, 180, 2017);
            Console.WriteLine("Координаты автомобиля reno_logan: {0} градусов юж. широты, {1} градусов вост. долготы", reno_logan.CoordinateY, reno_logan.CoordinateX);
            Console.WriteLine("Цена автомобиля: {0} $", reno_logan.Price);
            Console.WriteLine("Скорость автмобиля reno_logan: {0} км/ч", reno_logan.Speed);
            Console.WriteLine("Год производства автомобиля reno_logan: {0}", reno_logan.Year_of_construction);
            Console.ReadKey();

        }
    }
}
