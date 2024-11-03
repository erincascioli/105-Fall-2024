namespace ClassMethods_Warmup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create an instance of Enemy here
            Enemy myEnemy1 = new Enemy("Bob", 75);
            Enemy myEnemy2 = new Enemy("Bobathan", 75);

            myEnemy1.Print();
            myEnemy2.Print();

            for(int i = 0; i < 3; i++)
            {
                int attackDmg = myEnemy1.Attack();
                myEnemy2.TakeDamage(attackDmg);

                attackDmg = myEnemy2.Attack();
                myEnemy1.TakeDamage(attackDmg);
            }

            myEnemy1.Heal();
            myEnemy2.Heal();

            myEnemy1.Print();
            myEnemy2.Print();
        }
    }
}
