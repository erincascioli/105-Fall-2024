using System;

namespace DragonPE_Completed
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables needed for the program
            Random rng = new Random();
            Dragon dragon1 = null;
            Dragon dragon2 = null;

            DragonManager manager = 
                new DragonManager("../../../dragonData.txt", rng);
            manager.InstantiateDragonsFromFile();
            manager.PrintDragons();

            Console.WriteLine("\nDefenders are chosen!");
            dragon1 = manager.ChooseDefender();
            dragon2 = manager.ChooseDefender();

            // If same dragon is chosen twice, exit the program gracefully.
            if (dragon1 == dragon2)
            {
                Console.WriteLine(
                    "The dragon {0} wrangles itself to the ground. Try again!", 
                    dragon1.Name);
                return;
            }

            // Stats before battle
            Console.WriteLine(dragon1);
            Console.WriteLine(dragon2);
            Console.WriteLine();

            // Attack!
            while (dragon1.Health > 0 && dragon2.Health > 0)
            {
                // Attack!
                int d1Attack = dragon1.Attack();
                int d2Attack = dragon2.Attack();
                dragon2.Health -= d1Attack;
                dragon1.Health -= d2Attack;

                // Display results
                Console.WriteLine(
                    "{0} received {1} points of damage and {2} received {3} points of damage.",
                    dragon1.Name,
                    d2Attack,
                    dragon2.Name,
                    d1Attack);
                Console.WriteLine(dragon1);
                Console.WriteLine(dragon2);
                Console.WriteLine();
            }

            // A winner emerges!
            if (dragon1.Health == 0 && dragon2.Health == 0)
            {
                Console.WriteLine("Both dragons fall to the ground, exhausted from their battle.");
            }
            // Dragon 1 wins
            else if (dragon2.Health == 0)
            {
                if(dragon1 is FrostDragon)
                    Console.WriteLine(
                        "The air freezes as {0} emerges victorious!", 
                        dragon1.Name);
                else if(dragon1 is FireDragon)
                    Console.WriteLine(
                        "Flames rise from the ground as {0} emerges victorious!", 
                        dragon1.Name);
            }
            // Dragon 2 wins
            else
            {
                if (dragon2 is FrostDragon)
                    Console.WriteLine("The air freezes as {0} emerges victorious!", dragon2.Name);
                else if (dragon2 is FireDragon)
                    Console.WriteLine("Flames rise from the ground as {0} emerges victorious!", dragon2.Name);
            }



            Console.WriteLine();



            #region Part 1
            /*
            // Test Dragons
            //Dragon myGuy = new Dragon();  // A-ha! Can't do it!
            FireDragon inferno = new FireDragon("Inferno", 100, rng);
            FrostDragon wynter = new FrostDragon("Wynter", 105, rng);

            // Stats before battle
            Console.WriteLine(inferno);
            Console.WriteLine(wynter);
            Console.WriteLine();

            // Attack!
            while (inferno.Health > 0 && wynter.Health > 0)
            {
                // Attack!
                int infernoAttack = inferno.Attack();
                int wynterAttack = wynter.Attack();
                wynter.Health -= infernoAttack;
                inferno.Health -= wynterAttack;

                // Display results
                Console.WriteLine(
                    "{0} received {1} points of damage and {2} received {3} points of damage.",
                    inferno.Name,
                    wynterAttack,
                    wynter.Name,
                    infernoAttack);
                Console.WriteLine(inferno + " " + wynter);
                Console.WriteLine();
            }

            // A winner emerges!
            if (wynter.Health == 0 && inferno.Health == 0)
            {
                Console.WriteLine("Both dragons fall to the ground, exhausted from their battle.");
            }
            else if (inferno.Health == 0)
            {
                Console.WriteLine("The air freezes as {0} emerges victorious!", wynter.Name);
            }
            else
            {
                Console.WriteLine("Flames rise from the ground as {0} emerges victorious!", inferno.Name);
            }
            */
            #endregion


            #region Game Balance
            /*
            int tie = 0;
            int fire = 0;
            int frost = 0;

            for (int i = 0; i < 100; i++)
            {
                inferno = new FireDragon("Inferno", 100, rng);
                wynter = new FrostDragon("Wynter", 105, rng);

                // Attack!
                while (inferno.Health > 0 && wynter.Health > 0)
                {
                    // Attack!
                    int infernoAttack = inferno.Attack();
                    int wynterAttack = wynter.Attack();
                    wynter.Health -= infernoAttack;
                    inferno.Health -= wynterAttack;
                }

                if (wynter.Health == 0 && inferno.Health == 0)
                {
                    tie++;
                }
                else if (inferno.Health == 0)
                {
                    frost++;
                }
                else
                {
                    fire++;
                }
            }

            Console.WriteLine("Tie: " + tie);
            Console.WriteLine("Fire: " + fire);
            Console.WriteLine("Frost: " + frost);
            */
            #endregion            
        }
    }
}
