
// Erin Cascioli
// 10/19/22
// Demo: Basic Inheritance and syntax

namespace Demo_InheritanceMonsters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test the parent Monster class
            Monster monster1 = new Monster("Slimeboi", 400, false);
            Monster monster2 = new Monster("Alicina", 100, true);
            Monster monster3 = new Monster("Ice King", 600, false);
            Monster monster4 = new Monster("Ancient One", 4, false);

            // Test the Vampire and Zombie classes
            Vampire dracula = new Vampire("Dracula", 496, "humanoid");
            Zombie rob = new Zombie("Rob", 36);

            // Call the parent class method Print
            // The child classes have their own Print
            Console.WriteLine("\nCalled Print on Monster and V and Z");
            Console.WriteLine("\n*** Monster 1:");
            monster1.Print();               // PARENT version
            Console.WriteLine("\n*** Dracula:");
            dracula.Print();                // PARENT version
            Console.WriteLine("\n*** Rob Zombie:");
            rob.Print();                    // PARENT version
            Console.WriteLine("\n*** Dracula (again):");
            dracula.PrintVampire();         // CHILD version
            Console.WriteLine("\n*** Rob Zombie (again):");
            rob.PrintZombie();              // CHILD version

            // 5 days pass
            Console.WriteLine("\n5 days pass on V and Z");
            for (int i = 0; i < 5; i++)
            {
                dracula.TimePasses();
                rob.TimePasses();
            }
            Console.WriteLine();

            // See how they're faring
            Console.WriteLine("\nCalled Print on V and Z");
            Console.WriteLine("\n*** Dracula:");
            dracula.PrintVampire();
            Console.WriteLine("\n*** Rob Zombie:");
            rob.PrintZombie();

            // Eat!  Then shape change to fly away!
            Console.WriteLine("\nV drinks blood/flies");
            dracula.DrinkBlood("Bob");
            dracula.ShapeChange();
            Console.WriteLine();

            // See how they're faring
            Console.WriteLine("\nCalled Print on V and Z");
            Console.WriteLine("\n*** Dracula:");
            dracula.PrintVampire();
            Console.WriteLine("\n*** Rob Zombie:");
            rob.PrintZombie();
        }
    }
}