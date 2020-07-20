using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.creational.factory
{
    public class Product1 : IProduct
    {
        public string Operation()
        {
            return "{Result of Product1}";
        }
    }
}
