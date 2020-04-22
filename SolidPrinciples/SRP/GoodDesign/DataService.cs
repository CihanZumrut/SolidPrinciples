using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP.GoodDesign
{
    public class DataService : IDataService
    {
        public bool Save(IBankAccount account)
        {
            bool isSaved = false;
            try
            {
                //save data here 
                isSaved = true;
            }
            catch (Exception)
            {
                // error
                // log exception data
                isSaved = false;
            }
            return isSaved;
        }
    }
}