using System;

namespace Sec5_MonsterDemo
{

    /// <summary>
    /// Vampire inherits from the Monster class.
    /// Represents a vampire who subsists on blood.
    /// Vampires can die of hunger if they don't eat every ten days.
    /// </summary>

    class Vampire : Monster
    {
        private double hungerRate;
        private string currentShape;

        public Vampire(string name, int age, string shape) : 
            base(name, age, false)
        {
            // Uncomment this if you want to see the order that constructors run
            //Console.WriteLine("I am about to run the Vampire constructor.");

            // Fields unique to Vampire that are NOT in the Parent or Zombie
            this.hungerRate = 0.9;
            this.currentShape = shape;
        }


        /// <summary>
        /// Simulates the passing of time, where vampires slowly wither away
        /// from hunger and "die" once they reach 0 constitution.
        /// </summary>
        public void TimePasses()
        {
            constitution *= hungerRate;
            constitution = Math.Round(constitution, 2);

            if (constitution <= 0)
            {
                this.stillAlive = false;
            }
        }

        /// <summary>
        /// Replenishes a vampire's constitution by drinking blood.
        /// </summary>
        /// <param name="victimName">Name of the victim that replenishes the vampire</param>
        public void DrinkBlood(string victimName)
        {
            Console.WriteLine("{0} drinks the blood of {1}", name, victimName);
            constitution = 100;
        }

        /// <summary>
        /// Ability to change shape between a human and bat
        /// </summary>
        public void ShapeChange()
        {
            if(currentShape == "bat")
            {
                currentShape = "humanoid";
            }
            else
            {
                currentShape = "bat";
            }
        }

        /// <summary>
        /// Prints basic information about a Vampire.
        /// </summary>
        public void PrintStatistics()
        {
            Console.WriteLine(
                "Vampire {0} has {1} constitution.",
                name,
                constitution);
            Console.WriteLine("Current in {0} form.", currentShape);
            Console.WriteLine("Is the vampire still alive? {0}", stillAlive);
        }
        
    }
}
