using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDeck_Demo
{
    class Card
    {
        // 2 fields:
        private int number;
        private string suit;

        public Card(int number, string suit)
        {
            this.number = number;
            this.suit = suit;
        }

        public void PrintCard()
        {
            // "3 of Hearts"
            // "Queen of Diamonds"

            // string --> Number + " of " + suit
            string cardFormattedString = "";

            switch(number)
            {
                case 1:
                    cardFormattedString += "Ace";
                    break;
                case 11:
                    cardFormattedString += "Jack";
                    break;
                case 12:
                    cardFormattedString += "Queen";
                    break;
                case 13:
                    cardFormattedString += "King";
                    break;
                default:
                    cardFormattedString += number.ToString();
                    break;
            }
            cardFormattedString += " of " + suit;
            Console.WriteLine(cardFormattedString);
        }
    }
}
