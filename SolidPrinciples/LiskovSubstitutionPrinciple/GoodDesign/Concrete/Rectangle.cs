using SolidPrinciples.LiskovSubstitutionPrinciple.GoodDesign.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.GoodDesign.Concrete
{
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public double RectangleArea()
        {
            return Width * Height;
        }
    }
}
