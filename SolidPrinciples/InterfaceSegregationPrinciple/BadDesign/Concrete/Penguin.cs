using SolidPrinciples.InterfaceSegregationPrinciple.BadDesign.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.InterfaceSegregationPrinciple.BadDesign.Concrete
{
    class Penguin : IBird
    {
        public string Fly()
        {
            return "Penguins can not fly..!";
        }

        public string Walk()
        {
            return " Penguins can walk..!";
        }
    }
}
