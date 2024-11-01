namespace ClassesDemo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random myRNG = new Random();
            int randomNumber = myRNG.Next(1, 101);

            // Default
            Weapon myStabby = new Weapon();
            Console.WriteLine(myStabby.materials);

            // Parameterized
            Weapon myCutty = new Weapon(75, "Buster Sword", 9001, 9002, new string[] {""});
            Console.WriteLine(myCutty);
        }
    }
}
