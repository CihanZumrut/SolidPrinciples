using SolidPrinciples.InterfaceSegregationPrinciple.GoodDesign.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregationPrinciple.GoodDesign.Concrete
{
    public class Penguin : IFlightlessBird
    {
        public string Walk()
        {
            throw new NotImplementedException();
        }
    }
}
