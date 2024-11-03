using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShape
{
    class Circle : Shape
    {

        private double radius;

        public Circle(double radius, ConsoleColor color) : base(color)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            // Circle area = pi * r^2
            return Math.PI * Math.Pow(radius, 2);
        }

        public void Print()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(
                "This circle with radius {0} has an area of {1}.",
                radius,
                area);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void Draw()
        {
            Console.ForegroundColor = color;
            Console.WriteLine("   OOO    ");
            Console.WriteLine(" O     O  ");
            Console.WriteLine("O       O  ");
            Console.WriteLine(" O     O  ");
            Console.WriteLine("   OOO    ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
