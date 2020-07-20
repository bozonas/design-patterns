using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.creational.abstractFactory
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public override IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public override IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
