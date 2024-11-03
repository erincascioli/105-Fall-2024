namespace ClassMethods_Warmup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create an instance of Enemy here
            Enemy bob = new Enemy("Bob", 75);
            Enemy bobert = new Enemy("Bobert, the enemy of Bob", 15);

            bob.Print();
            bobert.Print();
            
            // Bob hits Bobert
            int damage = bob.Attack();
            bobert.TakeDamage(damage);

            // Bobert hit Bob
            damage = bobert.Attack();
            bob.TakeDamage(damage);

            bob.Print();
            bobert.Print();
        }
    }
}
