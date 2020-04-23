using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.OCP.GoodDesign
{
    public class VehicleFactory
    {
        public void ProduceVehicle(Vehicle vehicle)
        {
            vehicle.Produce();
        }
    }
}