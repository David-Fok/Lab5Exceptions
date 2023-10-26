using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Exceptions
{
    internal class Circle
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value <= 0 || double.IsInfinity(value))
                    throw new InvalidRadiusException("Radius cannot be negative or infinity.");
                radius = value;
            }
        }

        //constructor
        public Circle(double radius) 
        {
          Radius = radius;
        }

        public double Area()
        { 
        return Math.PI * Math.Pow(Radius,2);
        }

        public override string ToString()
        {
            return "Area: " + this.Area();
        }
    }
}
