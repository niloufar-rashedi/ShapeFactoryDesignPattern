using System;
using System.Collections.Generic;
using System.Linq;

namespace ShapeLaboratorium
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.WriteLine("Welcome! You can create here as many as rectangles and ellipses as you wish and then see their info. \n Follow the menu instructions! ");
            do
            {
                Console.WriteLine("Enter 1 to create Rectangle, \n 2 to create Ellipse, \n 3 to exit the console \n and 0 to break and see object information");
                Byte menuChoice = Convert.ToByte(Console.ReadLine());
                if (menuChoice == 0)
                    break;

                try
                {
                    double w, l;
                    switch (menuChoice)
                    {
                        case 1:
                            Console.Write("Enter Width: ");
                            w = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter length: ");
                            l = Convert.ToDouble(Console.ReadLine());
                            Shape shape = CreateShape(ShapeType.rectangle, w, l);
                            Console.WriteLine(shape);
                            Console.WriteLine();
                            list.Add(shape);
                            break;
                        case 2:
                            Console.Write("Enter Width: ");
                            w = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter length: ");
                            l = Convert.ToDouble(Console.ReadLine());
                            shape = CreateShape(ShapeType.ellipse, w, l);
                            Console.WriteLine(shape);
                            Console.WriteLine();
                            list.Add(shape);
                            break;
                        case 3:
                            Environment.Exit(3);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter your choice in double digits", e.Message);
                }
            } while (true);

            foreach (Shape s in list)
            {
                ViewShapeInfo(s);
            }

            Console.WriteLine("\nCalculated Areas sorted as Max -> Min values: ");
            list.Reverse();
            foreach (Shape s in list)
            {
                //Maximum value med LINQ
                Shape maxArea = list.Max();
                ViewShapeInfo(s);
            }

            static void ViewShapeInfo(Shape shape)
            {
                Console.WriteLine($"{shape.GetType()} Area {shape.Area:N2}");
            }
            static Shape CreateShape(ShapeType shape, double width, double length)
            {
                switch (shape)
                {
                    case ShapeType.ellipse:
                        return new Ellipse(width, length);
                    //break;
                    case ShapeType.rectangle:
                        return new Rectangle(width, length);
                    //break;
                    default: throw new NotImplementedException();
                }
            }
        }

        enum ShapeType : byte { ellipse, rectangle }
    }

}
