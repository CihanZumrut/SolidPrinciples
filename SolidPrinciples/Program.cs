using SolidPrinciples.SRP.BadDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory vf1 = new VehicleFactory();
            vf1.ProduceVehicle(new Car());

            VehicleFactory vf2 = new VehicleFactory();
            vf2.ProduceVehicle(new Bus());

            VehicleFactory vf3 = new VehicleFactory();
            vf3.ProduceVehicle(new Truck());

            Console.ReadLine();
        }
    }
}
