using System;

namespace Sec5_MonsterDemo
{

    /// <summary>
    /// Parent Monster class.
    /// Has 2 children: Vampire and Zombie
    /// </summary>

    class Monster
    {
        protected string name;
        protected int age;
        protected double constitution;
        protected bool stillAlive;
        protected bool isUndead;

        public string Name
        {
            get { return name; }
        }

        public Monster(string name, int age, bool undead)
        {
            // Uncomment this if you want to see the order that constructors run
            //Console.WriteLine("I am about to run the parent constructor.");
            this.name = name;
            this.age = age;
            this.isUndead = undead;
            this.constitution = 100;
            this.stillAlive = true;
        }

        /// <summary>
        /// Prints basic Monster statistics.
        /// </summary>
        public void PrintMonster()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Undead? {0}", isUndead);
            Console.WriteLine("Alive? {0}", stillAlive);
            Console.WriteLine("Const: {0}", constitution);
        }
    }
}
