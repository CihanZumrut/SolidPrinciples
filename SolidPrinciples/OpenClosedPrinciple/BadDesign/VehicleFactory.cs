using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP.BadDesign
{
    public class VehicleFactory
    {
        public void ProduceVehicle(Vehicle vehicle)
        {
            switch (vehicle.VType)
            {
                case VehicleType.Car:
                    ProduceCar((Car)vehicle);
                    break;
                case VehicleType.Bus:
                    ProduceBus((Bus)vehicle);
                    break;
            }
        }

        private void ProduceCar(Car car)
        {
            Console.WriteLine("Car Produced\n");
        }

        private void ProduceBus(Bus car)
        {
            Console.WriteLine("Bus Produced\n");
        }

        private void ProduceTruck(Truck truck) //truck üretimi yapan metodu ekledik
        {
            Console.WriteLine("Truck Produced\n");
        }
    }
}


