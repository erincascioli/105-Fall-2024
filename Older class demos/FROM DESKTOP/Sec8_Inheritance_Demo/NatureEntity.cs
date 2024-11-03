using System;


namespace Sec8_Inheritance_Demo
{

    /// <summary>
    /// Parent class for Rock and Stick.
    /// Contains fields and methods that are common to all possible entities of nature.
    /// </summary>

    class NatureEntity
    {
        // Fields
        protected string smellsLike;
        protected int hardness;
        protected double weight;
        protected string typeofItem;
        protected string[] locationFound;

        public NatureEntity()
        {
            // Uncomment this to see the order that constructors run
            //Console.WriteLine("Parent constructor is running");

            smellsLike = "smell";
            hardness = 0;
            weight = 0.0;
            typeofItem = "item";
            locationFound = new string[2];
        }

        public NatureEntity(string smell, int hardness, double weight, string type)
        {
            // Uncomment this to see the order that constructors run
            //Console.WriteLine("Parent constructor is running");

            // Initialize fields with parameters
            this.smellsLike = smell;
            this.hardness = hardness;
            this.weight = weight;
            this.typeofItem = type;
            locationFound = new string[2];
        }

        public void Print()
        {
            Console.WriteLine("Smells like: " + smellsLike);
            Console.WriteLine("Hardness scale: " + hardness);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Type of item: " + typeofItem);
            Console.WriteLine();
        }

        // Exist? Prints they exist
        // Hurled? 
        // Broken?
        // RollAway?
        // Sticks can fall or snap

    }
}
