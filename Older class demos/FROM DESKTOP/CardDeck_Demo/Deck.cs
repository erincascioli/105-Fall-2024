using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CardDeck_Demo
{
    class Deck
    {
        // Declare fields
        private Card[] myDeck;
        private Random rng;

        // Instantiate
        public Deck()
        {
            // Init fields
            myDeck = new Card[52];
            this.rng = new Random();

            // Initialize cards here!
            for(int i = 0; i < 13; i++)
            {
                Card heartCard = new Card(i + 1, "Hearts");
                myDeck[i] = heartCard;
            }
            for (int i = 0; i < 13; i++)
            {
                Card diamondCard = new Card(i + 1, "Diamonds");
                myDeck[i + 13] = diamondCard;
            }
            for (int i = 0; i < 13; i++)
            {
                Card spadeCard = new Card(i + 1, "Spades");
                myDeck[i + 26] = spadeCard;
            }
            for (int i = 0; i < 13; i++)
            {
                Card clubCard = new Card(i + 1, "Clubs");
                myDeck[i + 39] = clubCard;
            }
        }

        public void PrintDeck()
        {
            for(int i = 0; i < myDeck.Length; i++)
            {
                myDeck[i].PrintCard();
            }
        }

        public void Deal(int amountToDeal)
        {
            for (int i = 0; i < amountToDeal; i++)
            {
                int randomIndex = rng.Next(0, myDeck.Length);
                myDeck[randomIndex].PrintCard();
            }
        }
    }
}
