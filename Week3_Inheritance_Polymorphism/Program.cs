using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Inheritance_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle baseVehicle = new Vehicle(4, 2000, "Green", 55.0d);

            baseVehicle.Move();
            Console.WriteLine(baseVehicle.DistancedTraveled);
        }



    }
}
