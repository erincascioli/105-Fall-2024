using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo_2
{
    internal class Weapon
    {
        // --------------------------------------------------------------------
        // FIELDS of the Weapon class
        // --------------------------------------------------------------------
        public int damage;
        public string name;
        public int durability;
        public int maxDurability;
        public string[] materials;


        // --------------------------------------------------------------------
        // CONSTRUCTOR(S) of this class
        // --------------------------------------------------------------------
        /// <summary>
        /// Default constructor - assigns default values to all fields of this class
        /// </summary>
        public Weapon()
        {
            damage = 125;
            name = "The Stick";
            durability = 2;
            maxDurability = 2;
            materials = new string[1] {"wood"};
        }

        /// <summary>
        /// Constructs an object of the Weapon class
        /// </summary>
        /// <param name="damage">Damage dealt upon blow</param>
        /// <param name="name">Name of the weapon</param>
        /// <param name="durability">Current durability</param>
        /// <param name="maxDurability">Maximum durability</param>
        /// <param name="materials">Materials the weapon is constructed from</param>
        public Weapon(int damage, string name, int durability, 
            int maxDurability, string[] materials)
        {
            this.damage = damage;
            this.name = name;
            this.durability = durability;
            this.maxDurability = maxDurability;
            this.materials = materials;
        }


        // This is another way of identifying parameters.
        /*
        public Weapon(int p_damage, string p_name, int p_durability, 
        int p_maxDurability, string[] p_materials)
        {
            damage = p_damage;
            name = p_name;
            durability = p_durability;
            maxDurability = p_maxDurability;
            materials = p_materials;
        }
        */
    }
}
