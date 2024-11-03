using System;

// Demo: Basic Inheritance 
// 11/10/2021

namespace Sec8_Inheritance_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Creating instances of the parent class and child classes ---");
            NatureEntity ne = new NatureEntity();
            Rock rock1 = new Rock("smoke", 3, 2.5, "rock", "igneous", "janky", 2.3);
            Rock rock2 = new Rock("dirt", 10, 0.26, "rock", "diamond", "geometric", 12.4);
            Stick stick = new Stick("wood", 1, 1, "stick", 12.7, "pine");

            Console.WriteLine("--- Calling Print on each object ---");
            ne.Print();
            rock1.Print();
            rock2.Print();
            stick.Print();

            Console.WriteLine("--- Calling special Print methods on each child object ---");
            rock1.PrintRock();
            rock2.PrintRock();
            stick.PrintStick();
        }
    }
}
