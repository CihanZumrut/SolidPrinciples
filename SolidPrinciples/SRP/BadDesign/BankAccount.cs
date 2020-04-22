using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP.BadDesign
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public int AccountBalance { get; set; }

        public void SaveData()
        {
            //Kayıt işlemini gerçekleştiren metod
        }
    }  
}
