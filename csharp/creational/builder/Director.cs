using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.creational.builder
{
    public class Director
    {
        private IBuilder Builder { get; set; }

        public void SetBuilder(IBuilder builder)
        {
            this.Builder = builder;
        }

        public void MakeSportsCar(IBuilder builder)
        {
            this.Builder = builder;
        }

        public void MakeSUV(IBuilder builder)
        {
            this.Builder = builder;
        }
    }
}
