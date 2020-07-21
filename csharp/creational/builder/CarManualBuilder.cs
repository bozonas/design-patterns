using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.creational.builder
{
    public class CarManualBuilder : IBuilder
    {
        private Manual Manual { get; set; }

        public CarManualBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.Manual = new Manual();
        }

        public void SetEngine()
        {
            this.Manual.Description += "Has engine\n";
        }

        public void SetGps()
        {
            this.Manual.Description += "Has GPS\n";
        }

        public void SetSeats()
        {
            this.Manual.Description += "Has 6 seats\n";
        }

        public void SetTripComputer()
        {
            this.Manual.Description += "Has tripComputer\n";
        }

        public Manual GetCar()
        {
            var car = this.Manual;
            this.Reset();
            return car;
        }
    }
}
