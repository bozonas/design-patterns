﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.creational.abstractFactory
{
    public interface IAbstractProductB
    {
        string UsefulFunctionB();
        
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}
