using System;


namespace Sec8_Inheritance_Demo
{

    /// <summary>
    /// Child class of NatureEntity.
    /// Contains unique fields and methods that only apply to sticks.
    /// </summary>

    class Stick : NatureEntity
    {
        private double length;
        private string typeOfWood;
        private double flammability;

        public Stick(
            string smell, int hardness, double weight, string type,     // Passed to parent
            double length, string typeWood) :                           // Unique to stick
            base(smell, hardness, weight, type)                         // Call parent param constructor
        {
            // Set the unique fields of this class; the parent did the rest already.
            this.flammability = 10;
            this.length = length;
            this.typeOfWood = typeWood;
        }

        /// <summary>
        /// Breaks the stick by cutting it in half.
        /// </summary>
        public void Break()
        {
            this.length /= 2;
        }

        // We could also have a method that returns a new, smaller stick
        /*
        public Stick Break(// some param)
        {
            return new Stick( params here with smaller length );
        }
        */

        /// <summary>
        /// Prints basic information about the stick
        /// </summary>
        public void PrintStick()
        {
            Console.WriteLine(
                "This {0} stick is {1} long with a flammability rating of {2}.", 
                typeOfWood,
                length,
                flammability);
        }
    }
}
