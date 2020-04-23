using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP.BadDesign
{
    public class Vehicle
    {
        public VehicleType VType { get; set; }
    }

    public enum VehicleType
    {
        Car,
        Bus,
        Truck //truck nesnesini ekledik
    }

    public class Car : Vehicle
    {
        public Car()
        {
            this.VType = VehicleType.Car;
        }
    }

    public class Bus : Vehicle
    {
        public Bus()
        {
            this.VType = VehicleType.Bus;
        }
    }

    public class Truck : Vehicle //Truck nesnesini tanımladık 
    {
        public Truck()
        {
            this.VType = VehicleType.Truck;
        }

    }
}