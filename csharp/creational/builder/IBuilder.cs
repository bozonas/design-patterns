using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.creational.builder
{
    public interface IBuilder
    {
        public void Reset();
        public void SetSeats();
        public void SetEngine();
        public void SetTripComputer();
        public void SetGps();
    }
}
