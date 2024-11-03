using System;

namespace Sec5_MonsterDemo
{

    /// <summary>
    /// Zombie inherits from the Monster class.
    /// Represents an undead abomination who can die from decay over time.
    /// </summary>

    class Zombie : Monster
    {
        private double decayRate;


        public Zombie(string name, int age) : 
            base(name, age, true)
        {
            // Uncomment this if you want to see the order that constructors run
            //Console.WriteLine("I am about to run the Zombie constructor.");

            // Field unique to Vampire that is NOT in the Parent or Zombie
            this.decayRate = 0.97;
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

        /// <summary>
        /// Prints basic information about a Zombie.
        /// </summary>
        public void PrintStatistics()
        {
            Console.WriteLine(
                "Zombie {0} is existing at {1} constitution.", 
                name, 
                constitution);
            Console.WriteLine("Has it decayed yet? {0}", !stillAlive);
        }
        
    }
}
