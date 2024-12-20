﻿using System;
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
        public const int maxHealth = 100;
        public Weapon enemyWeapon;
        public string[] heldItems;


        // --------------------------------------------------------------------
        // CONSTRUCTOR of the class
        // --------------------------------------------------------------------
        
        /// <summary>
        /// Constructs an object of the Enemy class with defauly data for the max health,
        /// items held, and weapon.
        /// </summary>
        /// <param name="name">Name of the enemy</param>
        /// <param name="currentHealth">Current health value of this enemy</param>
        public Enemy(string name, int currentHealth)
        {
            this.name = name;
            this.currentHealth = currentHealth;
            SetDefaultFields();
        }

        /// <summary>
        /// Constructs an Enemy object has default data for the current health, max health
        /// items held, and the weapon.
        /// </summary>
        /// <param name="name">Name of the enemy</param>
        public Enemy(string name)
        {
            this.name = name;
            currentHealth = 86;
            SetDefaultFields();
        }

        /// <summary>
        /// Inits the weapon and items held fields.
        /// </summary>
        public void SetDefaultFields()
        {
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
        /// 
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"The enemy {name} has {currentHealth}/{maxHealth} health");
            Console.WriteLine($"Holding a(n) {enemyWeapon}.");
            Console.Write("This enemy holds: ");
            for(int i = 0; i < heldItems.Length; i++)
            {
                Console.Write(heldItems[i] + " ");
            }
            Console.WriteLine();

            //foreach(string item in heldItems)
            //{
            //    Console.Write(item + " ");
            //}
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Attack()
        {
            int damage = 0;

            switch(enemyWeapon)
            {
                case Weapon.Axe:    damage = 10; break;
                case Weapon.Dagger: damage = 7;  break;
                case Weapon.Sword:  damage = 12; break;
            }

            return damage;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="incomingDamage"></param>
        public void TakeDamage(int incomingDamage)
        {
            // Harm this enemy by the incoming damage HP amount
            currentHealth -= incomingDamage;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Heal()
        {
            // "Healthy" enough to heal at or above 50% of maximum
            if (currentHealth > maxHealth * .5)
            {
                currentHealth = maxHealth;
            }
        }
    }
}
