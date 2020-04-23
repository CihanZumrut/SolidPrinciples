using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DependencyInversionPrinciple.BadDesign
{
    public class Restaurant
    {
        Fish salmon = new Fish();
        Poultry chicken = new Poultry();

        public string GenerateRecipe()
        {
            return salmon.GetFishCookingRecipes() + " " + chicken.GetPoultryCookingRecipes();
        }
    }
}
