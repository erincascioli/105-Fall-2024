using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShape
{
    class Rhombus : Shape
    {
        private double width;
        private double length;

        public Rhombus(double width, double length, ConsoleColor color) : base(color)
        {
            this.width = width;
            this.length = length;
        }

        public void Print()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(
                "This rectangle with width {0} and length {1} an area of {2}.",
                width,
                length,
                area);
            Console.ForegroundColor = ConsoleColor.White;
        }


        public override void Draw()
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
