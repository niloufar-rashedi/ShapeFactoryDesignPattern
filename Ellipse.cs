using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLaboratorium
{
    class Ellipse : Shape
    {
        public Ellipse(double w, double l) : base(w, l)
        {
            Area = Math.PI * w * l;
            Perimeter = 2 * Math.PI * Math.Sqrt((w * w + l * l) / (2 * 1.0));
        }
        public override double Area { get; }
        public override double Perimeter { get; }

        public override string ToString()
        {
            return string.Format($"This ellipse has \n {Length} mm length \n {Width} mm width \n  {Perimeter:N2} mm perimeter \n  and area of { Area:N2} mm^3");
        }
    }
}
