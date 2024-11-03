using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonPE_Completed
{
    class FireDragon : Dragon
    {
        public FireDragon(string name, int health, Random rng)
            : base(name, health, rng)
        {
            // Value assignments are handled in the parent class.
            attacks.Add(String.Format("{0} burns their opponent to a crisp!", name));
            attacks.Add(String.Format("Smoke rises as {0} unleashes flames!", name));
            attacks.Add("A burst of fire explodes through the air!");
        }

        public override int Attack()
        {
            int randomMessageIndex = rng.Next(0, attacks.Count);
            Console.WriteLine(attacks[randomMessageIndex]);
            return rng.Next(10, 22);
        }

        public override string ToString()
        {
            return "The Fire dragon " + base.ToString() + ".";
        }
    }
}
