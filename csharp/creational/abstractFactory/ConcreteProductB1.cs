﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.creational.abstractFactory
{
    public class ConcreteProductB1 : IAbstractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();
            return $"The result of the B1 collaborating with the ({result})";
        }

        public string UsefulFunctionB()
        {
            return "The result of the product B1.";
        }
    }
}
