using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5exceptions
{
    public class Circle
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { SetRadius(value); }
        }

        public Circle(double radius)
        {
            SetRadius(radius);
        }

        private void SetRadius(double value)
        {
            if (value <= 0)
            {
                throw new InvalidRadiusException(value);
            }
            radius = value;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"Radius: {Radius}, Area: {Area()}";
        }
    }
}