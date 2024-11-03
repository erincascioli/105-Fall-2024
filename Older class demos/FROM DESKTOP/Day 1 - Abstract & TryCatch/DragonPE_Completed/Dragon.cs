using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonPE_Completed
{
    abstract class Dragon
    {
        protected int health;
        protected string name;
        protected Random rng;
        protected List<string> attacks;

        public int Health
        {
            get { return health; }
            set
            {
                health = value;
                if (health < 0)
                {
                    health = 0;
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public Dragon(string name, int health, Random rng)
        {
            this.name = name;
            this.health = health;
            this.rng = rng;
            attacks = new List<string>();
        }

        public abstract int Attack();

        public override string ToString()
        {
            return String.Format("{0} has {1} health", name, health);
        }
    }
}
