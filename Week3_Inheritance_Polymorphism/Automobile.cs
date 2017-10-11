using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Inheritance_Polymorphism
{
    class Automobile : Vehicle
    {
        private int numberOfwheels;
        private float wheelSize;
        private int numberOfDoors;

        public int NumberOfWheels
        {
            get { return this.numberOfwheels = numberOfwheels; }
        }

        public Automobile (int numberofWheels, float wheelSize, int numberOfDoors):base(4, 2000, "Blue", 65.0d)
        {

        }



    }
}
