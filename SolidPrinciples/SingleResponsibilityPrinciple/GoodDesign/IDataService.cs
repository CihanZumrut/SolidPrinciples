﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.SRP.GoodDesign
{
    public interface IDataService
    {
        bool Save(IBankAccount account);
    }
}
