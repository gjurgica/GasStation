using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class StaticClass
    {
        public static void Drive(this Car car,string place)
        {
            Console.WriteLine($"Driving to {place}. And take some premium.");
        }
        public static string GetCarStats(Car car)
        {
            return $"Brand: {car.Brand}\nModel:{car.Model}\nColor:{car.Color}\nFuel:{car.Fuel}\nHaveKeys:{car.HaveKeys}\nIsDrivable:{car.IsDrivable}";
        }
    }
}
