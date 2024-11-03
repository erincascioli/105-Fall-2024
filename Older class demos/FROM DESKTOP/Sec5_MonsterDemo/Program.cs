using System;

// 11/10/2021
// Demo: Inheritance

namespace Sec5_MonsterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test the parent Monster class, PrintMonster method, and Name property
            Monster monster1 = new Monster("Slimeboi", 400, false);
            Monster monster2 = new Monster("Alicina", 100, true);
            Monster monster3 = new Monster("Ice King", 600, false);
            Monster monster4 = new Monster("Ancient One", 4, false);
            monster1.PrintMonster();
            Console.WriteLine("The first monster's name is {0}", monster1.Name);

            // Test the Vampire and Zombie classes
            Vampire dracula = new Vampire("Dracula", 496, "humanoid");
            Zombie rob = new Zombie("Rob", 36);

            // Call the parent class method
            dracula.PrintMonster();
            Console.WriteLine();
            rob.PrintMonster();

            // Test their unique print methods 
            dracula.PrintStatistics();
            rob.PrintStatistics();
            Console.WriteLine();

            // 5 days pass
            for (int i = 0; i < 5; i++)
            {
                dracula.TimePasses();
                rob.TimePasses();
            }
            Console.WriteLine();

            // See how they're faring
            dracula.PrintStatistics();
            rob.PrintStatistics();
            Console.WriteLine();

            // Eat!  Then shape change to fly away!
            dracula.DrinkBlood("Bob");
            dracula.ShapeChange();
            Console.WriteLine();

            // See how they're faring
            dracula.PrintStatistics();
            rob.PrintStatistics();
        }
    }
}
