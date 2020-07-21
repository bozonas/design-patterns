using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.creational.builder
{
    public class Client
    {
        public void Main()
        {
            var director = new Director();

            var builder = new CarBuilder();
            director.MakeSportsCar(builder);
            var car = builder.GetCar();
            Console.WriteLine(car.Description);

            var builderManual = new CarManualBuilder();
            director.MakeSportsCar(builderManual);
            var carManual = builderManual.GetCar();
            Console.WriteLine(carManual.Description);
        }
    }
}
