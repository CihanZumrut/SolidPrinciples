using SolidPrinciples.DependencyInversionPrinciple.GoodDesign.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversionPrinciple.GoodDesign.Concrete
{
    public class Meat : IProduct
    {
        public string GetCookingRecipe()
        {
            return "Meat Recipes";
        }
    }
}
