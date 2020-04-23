using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP.GoodDesign
{
    public abstract class Vehicle
    {
        public abstract void Produce();
    }

    public class Car : Vehicle
    {
        public override void Produce()
        {
            Console.WriteLine("Car Produced\n");
        }
    }

    public class Bus : Vehicle
    {
        public override void Produce()
        {
            Console.WriteLine("Bus Produced\n");
        }
    }

    public class Truck : Vehicle
    {
        public override void Produce()
        {
            Console.WriteLine("Truck Produced\n");
        }
    }
}
