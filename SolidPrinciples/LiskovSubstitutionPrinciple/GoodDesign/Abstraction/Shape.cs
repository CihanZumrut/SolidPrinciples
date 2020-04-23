using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.LiskovSubstitutionPrinciple.GoodDesign.Abstraction
{
    public abstract class Shape
    {
        
        //This is the base class
        public virtual int Id { get; set; }
    }
}
