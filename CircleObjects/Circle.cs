using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CircleObjects
{
    internal class Circle
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        // Anthony said just these methods were okay to use
        public double CalculateCircumference()
        {
            double circumference = Math.Round((2 * Math.PI * GetRadius()), 2);
            return circumference;
        }

        public double CalculateArea()
        {
            double area = Math.Round((Math.PI * Math.Pow(GetRadius(), 2)), 2);
            return area;
        }

        public double GetRadius() { return radius; }
    }
}
