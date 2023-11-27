using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample
{
    internal class Square : Point, IFigure //наследяваме Point и имплементираме IFigure
    {
        public double Side { get; set; }
        public Square(double side,double x,double y)
            :base(x,y)
        { Side = side; }
        public Square(double side)
            : this(side, 0, 0) { }
        public double Area()
        {
            return Side * Side;
        }

        public double Perimeter()
        {
            return 4 * Side;
        }
    }
}
