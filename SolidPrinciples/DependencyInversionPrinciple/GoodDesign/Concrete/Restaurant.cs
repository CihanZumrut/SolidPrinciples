using SolidPrinciples.DependencyInversionPrinciple.GoodDesign.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversionPrinciple.GoodDesign.Concrete
{
    public class Restaurant
    {
        List<IProduct> products;

        public Restaurant()
        {
            products = new List<IProduct>();
        }

        public string GenerateRecipe()
        {
            string recipe = string.Empty;

            foreach (var item in products)
            {
                recipe += " " + item.GetCookingRecipe();
            }

            return recipe;
        }
    }
}
