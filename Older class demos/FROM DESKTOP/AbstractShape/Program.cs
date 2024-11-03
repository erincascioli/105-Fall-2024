using System;
using System.Collections.Generic;

namespace AbstractShape
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism is awesome!
            List<Shape> myShapes = new List<Shape>();
            //myShapes.Add(new Shape(ConsoleColor.Cyan));
            myShapes.Add(new Rectangle(3, 5, ConsoleColor.Yellow));
            myShapes.Add(new Circle(4, ConsoleColor.Red));
            myShapes.Add(new Rhombus(2, 2, ConsoleColor.DarkYellow));

            Type shapeType = myShapes[2].GetType();

            // Call Draw on all Shapes!
            // And calculate their areas!
            foreach(Shape shapeID in myShapes)
            {
                shapeID.CalculateArea();
                shapeID.Draw();

                //if (shapeID is Rectangle)
                //{
                //    Rectangle r = (Rectangle)shapeID;
                //    r.Draw();
                //    double area = r.CalculateArea();
                //    Console.WriteLine("The area is " + area);
                //}
                //if (shapeID is Circle)
                //{
                //    Circle r = (Circle)shapeID;
                //    r.Draw();
                //    double area = r.CalculateArea();
                //    Console.WriteLine("The area is " + area);
                //}
            }
        }
    }
}
