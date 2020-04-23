using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.BadDesign
{
    public class Rectangle
    {
        //According to the scenario, this class is our base class
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }
}
