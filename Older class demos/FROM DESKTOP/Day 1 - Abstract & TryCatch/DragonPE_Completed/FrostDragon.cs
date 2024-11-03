using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonPE_Completed
{
    class FrostDragon : Dragon
    {
        public FrostDragon(string name, int health, Random rng)
            : base(name, health, rng)
        {
            // Value assignments are handled in the parent class.
            attacks.Add(String.Format("{0} freezes their opponent!", name));
            attacks.Add(String.Format("{0} shivers as frost encompasses their opponent!", name));
            attacks.Add("An icy blast spirals through the air!");
        }

        public override int Attack()
        {
            int randomMessageIndex = rng.Next(0, attacks.Count);
            Console.WriteLine(attacks[randomMessageIndex]);

            // Calculate attack damage
            int attackDamage = rng.Next(10, 18);

            // 35% chance of bonus attack damage
            if (rng.NextDouble() < 0.25)
            {
                Console.WriteLine("{0} hits for bonus ice damage!", name);
                return attackDamage + 5;
            }

            return attackDamage;
        }

        public override string ToString()
        {
            return "The Frost dragon " + base.ToString() + ".";
        }
    }
}
