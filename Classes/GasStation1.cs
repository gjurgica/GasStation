using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class GasStation1
    {
        public static void Refill(Car car)
        {
            int addedFuel = 25;
            car.Fuel += addedFuel;
            Console.WriteLine($"{addedFuel} premium is added");
        }
        public static void PumpUpTires(Car car)
        {
            if(car.IsDrivable == false)
            {
                car.IsDrivable = true;
                Console.WriteLine($"{car.Model} now is in good state");
            }
            else
            {
                Console.WriteLine($"No need to pump up tires, your {car.Model} is in good state");
            }
        }
    }
}
