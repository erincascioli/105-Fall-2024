using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyListsPractice
{
    internal class Block
    {
        private int xLocation;
        private int yLocation;
        private string blockType;
        public bool canBeBroken;

        
        public string BlockType
        {
            get { return blockType; }
            set { blockType = value; }
        }

        
        public int XLocation
        {
            get 
            {
                Console.WriteLine("The location is " + xLocation);
                return xLocation; 
            }
        }
        public int YLocation
        {
            get { return yLocation; }
        }

        public bool IsOffscreen
        {
            get
            {
                return (xLocation < 0 || yLocation < 0);
            }
        }
        
        public Block()
        {
            xLocation = 0;
            yLocation = 0;
            blockType = null;
            canBeBroken = false;
        }

        public Block(int xLocation, int yLocation, string blockType)
        {
            // Assign values from params
            this.xLocation = xLocation;
            this.yLocation = yLocation;
            this.blockType = blockType;

            // Determine if this type of brick can be broken
            if (this.blockType == "brick")
            {
                canBeBroken = true;
            }
            else
            {
                canBeBroken = false;
            }
        }

        public string Bonk()
        {
            if(blockType == "question")
            {
                return "Release an item!";
            }
            else if(blockType == "brick")
            {
                return "The block breaks!";
            }
            else if(blockType == "hidden")
            {
                return "Release a coin!";
            }
            else
            {
                return "We don't know what this block does.";
            }
        }

        public int GetLocationX()
        {
            return xLocation;
        }

        public void SetLocationX(int xLoc)
        {
            this.xLocation = xLoc;
        }
    }
}
