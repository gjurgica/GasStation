using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Volkswagen", "Porsche", "red", 55, true, true);
            car1.StartCar();
            car1.StartLights();
            car1.Drive("Palermo");
            Console.WriteLine("---------------------");
            Console.WriteLine(car1.GetCarStats());
            Console.WriteLine("---------------------");
            GasStation1.Refill(car1);
            Console.WriteLine("---------------------");
            GasStation1.PumpUpTires(car1);
            Console.ReadLine();
        }
    }
}
