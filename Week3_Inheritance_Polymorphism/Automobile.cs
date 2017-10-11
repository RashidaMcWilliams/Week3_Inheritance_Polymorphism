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

        public Automobile (int numberofWheels, float wheelSize, int numberOfDoors, int seats, int carryingCapacity, string color, double movementSpeed)//:base(4, 2000, "Blue", 65.0d)
        {
            this.numberOfwheels = numberOfwheels;
            this.wheelSize = wheelSize;
            this.numberOfDoors = numberOfDoors;
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
        }



    }
}
