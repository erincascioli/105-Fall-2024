using System;


namespace Sec8_Inheritance_Demo
{

    /// <summary>
    /// Child class of NatureEntity.
    /// Contains unique fields and methods that only apply to rocks.
    /// </summary>

    class Rock : NatureEntity 
    {
        private string typeOfRock;
        private string shape;
        private double movementSpeed;


        public Rock(
            string smell, int hardness, double weight, string type,     // Passed to parent
            string typeRock, string shape, double speed) :              // Unique to rock
            base(smell, hardness, weight, type)                         // Call parent param constructor
        {
            // Uncomment this to see the order that constructors run
            //Console.WriteLine("Child constructor is running");

            // Set the unique fields of this class; the parent did the rest already.
            this.typeOfRock = typeRock;
            this.shape = shape;
            this.movementSpeed = speed;
        }

        public void RollAway()
        {
            // Not going to code this right now, but we could...
            // Change X and Y (possibly Z) location for this rock depending on its
            //   movement speed, how long it rolls, terrain on which it rolls,
            //   weather conditions, etc.
        }

        /// <summary>
        /// Prints basic information about the rock
        /// </summary>
        public void PrintRock()
        {
            Console.WriteLine(
                "This {0} {1} rock can roll with a speed of {2}.",
                shape,
                typeOfRock,
                movementSpeed);
        }
    }
}
