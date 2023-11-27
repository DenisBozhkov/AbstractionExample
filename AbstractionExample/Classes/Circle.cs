using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample
{
    internal class Circle : Point, IFigure //наследяваме Point и имплементираме IFigure
    {
        public double Radius { get; set; }
        public Circle(double radius,double x,double y)
            :base(x,y)
        {
            Radius = radius;
        }
        public Circle(double radius)
            : this(radius, 0, 0)
        { }
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
