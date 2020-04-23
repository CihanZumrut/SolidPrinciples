using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.BadDesign
{
    public class AreaCalculator
    {
        public static double CalculateArea(Square square)
        {
            return square.Height * square.Width;
        }

        public static double CalculateArea(Rectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }
    }
}
