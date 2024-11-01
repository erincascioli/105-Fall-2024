using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods_Warmup
{
    internal class Enemy
    {
        // --------------------------------------------------------------------
        // FIELDS of the class
        // --------------------------------------------------------------------
        public string name;
        public int currentHealth;
        public int maxHealth;


        // --------------------------------------------------------------------
        // CONSTRUCTOR of the class
        // --------------------------------------------------------------------
        
        // TODO: Add an XML comment for this constructor
        public Enemy(string name, int currentHealth)
        {
            this.name = name;
            this.currentHealth = currentHealth;

            // All Enemies can be maxed to 100 HP
            maxHealth = 100;

            // TODO: Write the answer to these 2 questions here, as comments:
            // What type is it – default or parameterized?
            //
            // What does this constructor do?
            //
        }


        // --------------------------------------------------------------------
        // METHODS of the class
        // --------------------------------------------------------------------

    }
}
