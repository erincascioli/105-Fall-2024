using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Sec7
{
    class PlayerManager
    {
        // List of Player objects
        private List<Player> myPlayers;


        public PlayerManager()
        {
            myPlayers = new List<Player>();
        }

        /// <summary>
        /// Adds a new Player object to this list
        /// </summary>
        /// <param name="name"></param>
        public void AddPlayer(string name)
        {
            Player newDude = new Player(name);
            myPlayers.Add(newDude);

            // OR you could do this:
            //myPlayers.Add(new Player(name));
        }


        // Retrieve a Player object, if we can find one, that matches a specific name
        // If there is no Player with that name, throw an Exception
        public Player GetPlayerByName(string name)
        {
            // Search through the list, comparing the name of each current Player
            //   to the name passed into this method
            foreach(Player p in myPlayers)
            {
                // Found the player!
                if(p.Name == name)
                {
                    return p;
                }
            }

            // Didn't find the person, so there is nobody to return!
            // Instead, throw an exception to let the code calling this method
            //   know that there was an error!
            Exception ex = new Exception("No player with that name found.");
            throw ex;
        }
    }
}
