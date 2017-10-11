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
            //Vehicle baseVehicle = new Vehicle(4, 2000, "Green", 55.0d);

            //baseVehicle.Move();
            //baseVehicle.Move();
            //Console.WriteLine(baseVehicle.DistancedTraveled);

            Automobile herbie = new Automobile(4, 13, 2, 4, 1500, "White", 88.0d);
            herbie.Move();
            herbie.Move();
            Console.WriteLine("Automobile Distance Traveled: " + herbie.DistancedTraveled);




        }
    }
}
