using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.creational.builder
{
    public class CarBuilder : IBuilder
    {
        private Car Car { get; set; }

        public CarBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.Car = new Car();
        }

        public void SetEngine()
        {
            this.Car.Description += "Has nice engine\n";
        }

        public void SetGps()
        {
            this.Car.Description += "Has no GPS\n";
        }

        public void SetSeats()
        {
            this.Car.Description += "Has 4 seats\n";
        }

        public void SetTripComputer()
        {
            this.Car.Description += "Has no trip computer\n";
        }

        public Car GetCar()
        {
            var car = this.Car;
            this.Reset();
            return car;
        }
    }
}
