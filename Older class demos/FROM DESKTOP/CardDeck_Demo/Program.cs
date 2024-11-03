using System;

namespace CardDeck_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.PrintDeck();

            Console.WriteLine();
            myDeck.Deal(7);
        }
    }
}
