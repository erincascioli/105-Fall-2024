using System;
using System.Collections.Generic;


namespace Demo_InheritanceMonsters
{
    /// <summary>
    /// Child of Monster
    /// Represents an undead Zombie.
    /// </summary>
    internal class Zombie : Monster
    {
        
        private double decayRate;

        /// <summary>
        /// Creates a Zombie, child of Monster
        /// </summary>
        /// <param name="name">Name of this zombie.</param>
        /// <param name="age">Age of this zombie. Must be positive.</param>
        public Zombie(string name, int age) :
            base(name, age, true)
        {
            // Uncomment this if you want to see the order that constructors run
            //Console.WriteLine("I am about to run the Zombie constructor.");

            // Field unique to Vampire that is NOT in the Parent or Zombie
            this.decayRate = 0.97;
        }

        /// <summary>
        /// Prints basic information about a Zombie.
        /// </summary>
        public void PrintZombie()
        {
            base.Print();
            Console.WriteLine(
                "Zombie {0} is existing at {1} constitution.",
                name,
                constitution);
            Console.WriteLine("Has it decayed yet? {0}", !stillAlive);
        }

        
        /// <summary>
        /// Simulates the passing of time, where zombies slowly decay
        /// and "die" once they reach 0 constitution.
        /// </summary>
        public void TimePasses()
        {
            constitution *= decayRate;
            constitution = Math.Round(constitution, 2);

            if (constitution <= 0)
            {
                this.stillAlive = false;
            }
        }
    }
}
