using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DragonPE_Completed
{
    class DragonManager
    {
        private List<Dragon> dragons;
        private string filename;
        private Random rng;

        public DragonManager(string filename, Random rng)
        {
            dragons = new List<Dragon>();
            this.filename = filename;
            this.rng = rng;
        }

        public void InstantiateDragonsFromFile()
        {
            // Read from a file, creating dragons and adding them to the list
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(filename);
                string readData = "";

                // Read the first line to know how 
                //   many of each dragon exist.
                // "Fire|4|Frost|3"  <-- File format
                readData = reader.ReadLine();
                string[] splitDragontypes = readData.Split('|');
                int fireDragons = int.Parse(splitDragontypes[1]);
                int frostDragons = int.Parse(splitDragontypes[3]);

                // Creation of FireDragons
                for (int i = 0; i < fireDragons; i++)
                {
                    readData = reader.ReadLine();
                    string[] dragonData = readData.Split(':');
                    dragons.Add(new FireDragon(dragonData[0], int.Parse(dragonData[1]), rng));
                }

                // Creation of FrostDragons
                for (int i = 0; i < frostDragons; i++)
                {
                    readData = reader.ReadLine();
                    string[] dragonData = readData.Split(':');
                    dragons.Add(new FrostDragon(dragonData[0], int.Parse(dragonData[1]), rng));
                }

                // Done! Close the stream
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(
                    "Oh no, an error occurred trying to read the file!\n" + e.Message);
                Environment.Exit(1);
            }
        }

        public void PrintDragons()
        {
            foreach (Dragon d in dragons)
            {
                Console.WriteLine(d);
            }
        }

        public Dragon ChooseDefender()
        {
            // Randomly return a reference to a Dragon if the list
            //   contains properly instantiated Dragon objects.
            if (dragons.Count > 0)
            {
                int randomIndex = rng.Next(0, dragons.Count);
                return dragons[randomIndex];
            }

            // Otherwise, return null.
            return null;
        }

    }
}
