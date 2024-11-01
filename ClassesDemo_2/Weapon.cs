using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo_2
{
    internal class Weapon
    {
        // FIELDS
        public int damage;
        public string name;
        public int durability;
        public int maxDurability;
        public string[] materials;


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
        /// 
        /// </summary>
        /// <param name="damage"></param>
        /// <param name="name"></param>
        /// <param name="durability"></param>
        /// <param name="maxDurability"></param>
        /// <param name="materials"></param>
        public Weapon(int damage, string name, int durability, 
            int maxDurability, string[] materials)
        {
            this.damage = damage;
            this.name = name;
            this.durability = durability;
            this.maxDurability = maxDurability;
            this.materials = materials;
        }

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
