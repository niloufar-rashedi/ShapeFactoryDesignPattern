using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLaboratorium
{
    class Rectangle : Shape
    {
        public Rectangle(double w, double l) : base(w, l)
        {
            Area = Math.Pow(w, l);
            Perimeter = (2 * w) + (2 * l);
        }
        public override double Area { get; }
        public override double Perimeter { get; }
        public override string ToString()
        {
            return string.Format($"This rectangle has \n {Length} mm length \n {Width} mm width \n  {Perimeter:N2} mm perimeter \n  and area of { Area:N2} mm^3");
        }

    }

}
