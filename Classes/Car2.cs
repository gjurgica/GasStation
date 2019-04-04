using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public partial class Car
    {
        public Car(string brand,string model,string color,int fuel,bool haveKeys,bool isDrivable)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Fuel = fuel;
            HaveKeys = haveKeys;
            IsDrivable = isDrivable;
        }
        public void StartCar()
        {
            if(Fuel > 3 && HaveKeys == true && IsDrivable == true)
            {
                Console.WriteLine($"{Model} is started");
            }
            else
            {
                Console.WriteLine($"{Model} can't be start");
            }
        }
        public void StartLights()
        {
            if(HaveKeys == true && IsDrivable == true)
            {
                Console.WriteLine("Lights are on");
            }
            else
            {
                Console.WriteLine("Lights can't be on");
            }
        }
       
    }
}
