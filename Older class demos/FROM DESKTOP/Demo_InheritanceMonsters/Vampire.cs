using System;
using System.Collections.Generic;


namespace Demo_InheritanceMonsters
{
    /// <summary>
    /// Child of Monster
    /// Represents a blood-sucking vampire.
    /// </summary>
    internal class Vampire : Monster
    {
        
        private double hungerRate;
        private string currentShape;

        /// <summary>
        /// Vampire child class.
        /// </summary>
        /// <param name="name">Name of the vampire</param>
        /// <param name="age">Age of this vampire</param>
        /// <param name="shape">Is this vampire in humanoid or bat form?</param>
        public Vampire(string name, int age, string shape) :
            base(name, age, false)
        {
            // Uncomment this if you want to see the order that constructors run
            Console.WriteLine("I am about to run the Vampire constructor.");

            // Fields unique to Vampire that are NOT in the Parent or Zombie
            this.hungerRate = 0.9;
            this.currentShape = shape;
        }

        /// <summary>
        /// Prints basic information about a Vampire.
        /// </summary>
        public void PrintVampire()
        {
            // Use the Parent's version first
            base.Print();

            // Then add on specific stuff about Vampires
            Console.WriteLine(
                "Vampire {0} has {1} constitution.",
                name,
                constitution);
            Console.WriteLine("Current in {0} form.", currentShape);
            Console.WriteLine("Is the vampire still alive? {0}", stillAlive);
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
            if (currentShape == "bat")
            {
                currentShape = "humanoid";
            }
            else
            {
                currentShape = "bat";
            }
        }        
        
    }
}
