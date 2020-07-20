using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.creational.factory
{
    public class ConcreteCreator1 : AbstractCreator
    {
        public override IProduct FactoryMethod()
        {
            return new Product1();
        }
    }
}
