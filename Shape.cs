using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLaboratorium
{
    abstract class Shape : IComparable<Shape> //I motsats till inlämningsinstruktionen implementerade jag IComparable direkt här i basklassen
                                              // Orsaken var att jag tänkte att det skulle inte stämma med DRY-regel om jag skriver två CompareTo metoder
                                              //i båda Rectangle och Ellipse. De arvar klassen Shape och det skulle räcka att skapa metoden endast här.
    {
        private double width;
        private double length;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public virtual double Area { get; }
        public virtual double Perimeter { get; }
        public Shape(double w, double l)
        {
            Width = w;
            Length = l;
        }
        public override string ToString()
        {
            return string.Format("The default shape information ");
        }
        public int CompareTo(Shape other)
        {
            return this.Area.CompareTo(other.Area);
        }

    }
}
