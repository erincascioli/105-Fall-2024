using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods_Warmup
{
    public enum Weapon
    {
        Sword,
        Axe,
        Dagger
    }


    internal class Enemy
    {
        // --------------------------------------------------------------------
        // FIELDS of the class
        // --------------------------------------------------------------------
        public string name;
        public int currentHealth;
        public int maxHealth;
        public Weapon enemyWeapon;
        public string[] heldItems;


        // --------------------------------------------------------------------
        // CONSTRUCTOR of the class
        // --------------------------------------------------------------------
        
        /// <summary>
        /// Constructs an object of the Enemy class with default data for the max health,
        /// items held, and weapon.
        /// </summary>
        /// <param name="name">Name of the enemy</param>
        /// <param name="currentHealth">Current health value of this enemy</param>
        public Enemy(string name, int currentHealth)
        {
            this.name = name;
            this.currentHealth = currentHealth;
            maxHealth = 100;

            // Weapon type is dependent on the name length
            int nameLength = name.Length;

            if (nameLength <= 3)                 // 0-3 chars
            {
                enemyWeapon = Weapon.Sword;
            }
            else if (nameLength <= 7)            // 4-7 chars
            {
                enemyWeapon = Weapon.Axe;
            }
            else                                // 8+ chars
            {
                enemyWeapon = Weapon.Dagger;
            }

            // All enemies start with the same 3 items
            heldItems = new string[3] { "rations", "trinket", "trap" };


        }


        // --------------------------------------------------------------------
        // METHODS of the class
        // --------------------------------------------------------------------


        /// <summary>
        /// Displays information for this given Enemy in the Console window.
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"This enemy {name} has {currentHealth}/{maxHealth} health.");
            Console.WriteLine($"Weapon: {enemyWeapon}");
            Console.Write($"Is holding ");
            
            for(int i = 0; i < heldItems.Length; i++)
            {
                Console.Write(heldItems[i] + " ");
            }

            foreach(string item in heldItems)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        public void TakeDamage(int damageDealt)
        {
            if(damageDealt > 0)
            {
                currentHealth -= damageDealt;
            }
        }

        public int Attack()
        {
            // Make this more interesting!
            return 5;
        }

        public void Heal()
        {
            // Make this interesting!
        }
    }
}
