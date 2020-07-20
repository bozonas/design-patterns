using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.creational.abstractFactory
{
    public abstract class AbstractFactory : IAbstractFactory
    {
        public abstract IAbstractProductA CreateProductA();
        public abstract IAbstractProductB CreateProductB();
    }
}
