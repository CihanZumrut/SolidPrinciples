using SolidPrinciples.InterfaceSegregationPrinciple.BadDesign.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregationPrinciple.BadDesign.Concrete
{
    public class Eagle : IBird
    {
        public string Fly()
        {
            return "Eagles can fly..!";
        }

        public string Walk()
        {
            return "Eagles can walk..!";
        }
    }
}
