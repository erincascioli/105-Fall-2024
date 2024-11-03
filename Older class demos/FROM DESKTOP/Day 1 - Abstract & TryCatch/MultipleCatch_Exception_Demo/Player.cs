using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Sec7
{
    class Player
    {
        private string name;
        private int score;

        public string Name
        {
            get { return name; }
        }

        public Player(string name)
        {
            this.name = name;
            this.score = 0;
        }
    }
}
