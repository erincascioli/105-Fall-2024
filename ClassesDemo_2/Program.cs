
// Erin Cascioli
// 11/1/24
// Demo: Beginning OOP with just fields and constructors


namespace ClassesDemo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random myRNG = new Random();
            int randomNumber = myRNG.Next(1, 101);

            // Default
            Weapon toothpick = new Weapon();
            Console.WriteLine(toothpick.materials);

            // Parameterized
            Weapon sword = new Weapon(75, "Buster Sword", 9001, 9002, new string[] {""});
            Console.WriteLine(sword);
        }
    }
}
