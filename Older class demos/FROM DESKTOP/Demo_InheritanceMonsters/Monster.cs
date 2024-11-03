using System;
using System.Collections.Generic;


namespace Demo_InheritanceMonsters
{
    /// <summary>
    /// Parent class of Zombie and Vampire.
    /// </summary>
    internal class Monster
    {
        // Fields that are shared with child class
        protected string name;
        protected int age;
        protected double constitution;
        protected bool stillAlive;
        protected bool isUndead;

        public string Name
        {
            get { return name; }
        }

        /// <summary>
        /// Creates an instance of Monster
        /// </summary>
        /// <param name="name">Name of the monster</param>
        /// <param name="age">Age of the monster. Should be positive.</param>
        /// <param name="undead">Is this monster an undead type?</param>
        public Monster(string name, int age, bool undead)
        {
            // Uncomment this if you want to see the order that constructors run
            Console.WriteLine("I am about to run the parent constructor.");
            this.name = name;
            this.age = age;
            this.isUndead = undead;
            this.constitution = 100;
            this.stillAlive = true;
        }

        /// <summary>
        /// Prints basic Monster statistics.
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Undead? {0}", isUndead);
            Console.WriteLine("Alive? {0}", stillAlive);
            Console.WriteLine("Const: {0}", constitution);
        }
    }
}
