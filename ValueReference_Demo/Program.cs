using System;

// Erin Cascioli
// 10/29/2021
// Demo: Random, TryParse, Value types, Reference types, and Null

namespace Sec7_ValueReferenceRandom_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Random and TryParse
            
            // ------------------------- RANDOM -------------------------------
            // Create one Random object and call Next or NextDouble as much 
            //   as necessary.
            // Don't make more than 1 Random object. That's silly. :)
            // Make one and keep asking it for random numbers!
            // ----------------------------------------------------------------
            Random rng = new Random();

            /*
            Console.WriteLine("Next()");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(rng.Next());
            }

            Console.WriteLine("\nNext(upper value)");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rng.Next(3));
            }

            Console.WriteLine("\nNext(lower, upper)");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rng.Next(1, 7));
            }

            Console.WriteLine("\nNextDouble()");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rng.NextDouble());
            }


            // ----------------------- TRY PARSE ------------------------------
            // Allows an attempt of parsing
            // Won't crash if invalid data is given to the TryParse method.
            // ----------------------------------------------------------------
            // Regular Parse()
            // This will crash, resulting in a FormatException being thrown
            //int parsedInt = int.Parse("abc");

            // TryParse()
            // Returns a boolean
            // That boolean can be used to determine whether valid data was given
            //   and if the parse was successful. 
            // Why only 1 boolean?  Because methods can only return 1 piece of data.
            // What can you do with the bool?  Commonly used inside loops to ensure
            //   user re-enters data, or can be used to assign a default value to 
            //   something.  
            Console.Write("\nEnter an integer: ");
            string userInput = Console.ReadLine();
            int parsedValue = -1;
            bool successfullyParsed =
                int.TryParse(userInput, out parsedValue);

            // User gave you anything other than an integer.
            // Force re-entry of data.
            while(!successfullyParsed)
            {
                Console.Write("You did not enter an integer. Please enter an integer: ");
                userInput = Console.ReadLine();
                successfullyParsed =
                int.TryParse(userInput, out parsedValue);
            }

            Console.WriteLine("Thanks! Parsed value holds: " + parsedValue);

            // OR!

            Console.Write("\nEnter another integer: ");
            userInput = Console.ReadLine();
            parsedValue = -1;
            successfullyParsed =
                int.TryParse(userInput, out parsedValue);

            // User gave you anhything other than an integer.
            // Force re-entry of data.
            if (!successfullyParsed)
            {
                Console.WriteLine("You did not enter an integer, so I'm assigning one.");
                Console.WriteLine("Your number is -9999 now.");
                parsedValue = -9999;
            }
            */
            #endregion


            #region Value types

            // ---------------------- VALUE TYPES -----------------------------
            // Value types are primitive data:
            // Doubles, ints, bool, floats, shorts, longs, characters, etc.
            // Accessing a variable gives us a COPY of the data
            // = does NOT mean equals, it means assign
            // ----------------------------------------------------------------

            Console.WriteLine("\n----- Doubles -----");
            // Declare and init 3 doubles
            double a = 5;
            double b = 10;
            double c = b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            // Change the value of one to see what happens
            b = 27;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.WriteLine("\n----- Characters -----");
            // Declare and init 3 characters
            char aC = 'a';
            double bC ='b';
            double cC = bC;
            Console.WriteLine(aC);
            Console.WriteLine(bC);
            Console.WriteLine(cC);

            // Change the value of one to see what happens
            bC = 'Q';
            Console.WriteLine(aC);
            Console.WriteLine(bC);
            Console.WriteLine(cC);

            // ~~~~~ Calling methods on value types ~~~~~
            // Value types are passed BY COPY to methods

            Console.WriteLine("\n----- Value Types as Method Parameters -----");
            bool myBoolValue = false;
            Console.WriteLine("Boolean before calling method: " + myBoolValue);
            
            ChangeValueTypeInMethodOnly(myBoolValue);
            Console.WriteLine("Boolean after calling method: " + myBoolValue);
            #endregion


            #region Reference types

            // -------------------- REFERENCE TYPES ---------------------------
            // Reference types
            // Strings, Arrays, Objects from classes
            // 2 variables can "point" to the same data in memory
            // When one changes, the other "changes" too
            // ----------------------------------------------------------------

            // ~~~~~ Strings ~~~~~
            // Strings are reference types
            // When one string = another, they both point to the same
            //   string in memory. 
            // However, when a string is assigned a new value, a new string
            //   is made in the heap and the string variable points
            //   to that new string
            Console.WriteLine("\n----- Strings -----");

            // Declare and init 3 strings
            string aS = "A";
            string bS = "B";
            string cS = bS;
            Console.WriteLine(aS);
            Console.WriteLine(bS);
            Console.WriteLine(cS);

            // Change the value of one to see what happens
            bS = "something else";
            bS = "B";
            Console.WriteLine(aS);
            Console.WriteLine(bS);
            Console.WriteLine(cS);


            // ~~~~~ Arrays ~~~~~
            // When a value in an array changes, any other arrays pointing to the
            //   same array "change", too.
            //   (They don't really change, the array they're pointing to data has changed
            Console.WriteLine("\n----- Arrays -----");

            // Declare and init 2 arrays
            int[] arrayA = {7, 26};
            int[] arrayB = {2, 99};
            int[] arrayC = arrayB;

            // Print the values of each one
            foreach(int element in arrayA)
            {
                Console.WriteLine(element);
            }
            foreach (int element in arrayB)
            {
                Console.WriteLine(element);
            }
            foreach (int element in arrayC)
            {
                Console.WriteLine(element);
            }

            // change an array index to see what happens
            Console.WriteLine("Array B changed index 1 to 1000");
            arrayB[1] = 1000;
            foreach (int element in arrayA)
            {
                Console.WriteLine(element);
            }
            foreach (int element in arrayB)
            {
                Console.WriteLine(element);
            }
            foreach (int element in arrayC)
            {
                Console.WriteLine(element);
            }


            // ~~~~~ Calling methods on reference types ~~~~~
            // Reference types are passed BY REFERENCE to methods
            Console.WriteLine("\n----- Reference Types as Method Parameters -----");

            int[] myArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Last element data before calling method: " + myArray[4]);

            ChangeArrayData(myArray);
            Console.WriteLine("Last element data after calling method: " + myArray[4]);


            // -------------------- NULL REFERENCES ---------------------------
            // Reference types can be assigned the value of null
            // Most times, it's either:
            // 1. A placeholder for data you will enter later
            // 2. Indicative of an error or non-initialization
            // ----------------------------------------------------------------
 
            // Declare a string array as null so that it can be initialized one of 2 ways:
            // Either with a size of 5 or a size of 200
            string[] myWords = null;

            if (rng.Next(0, 2) == 1)
            {
                myWords = new string[5];
            }
            else
            {
                myWords = new string[200];
            }

            // Print the size of this array
            Console.WriteLine("The array was initialized to size " + myWords.Length);


            // What if you simply don't give an array a value?
            // A syntax error!
            // Line 302 below has an error because myWords1 was never given a value,
            //   not even null.
            // How is that possible? Visual Studio thinks its possible to exit the if statement
            //   blocks and never initialize the array. 
            // WE know by looking at it that the array will exist, but VS cannot analyze that.
            string[] myWords1;

            if (rng.Next(0, 2) == 1)
            {
                myWords1 = new string[5];
            }
            else if(rng.Next(0, 2) == 0)
            {
                myWords1 = new string[200];
            }

            // Print the size of this array
            // *** ERROR HERE!!! COMMENTED OUT SO PROGRAM WILL COMPILE ***
            //Console.WriteLine("The array was initialized to size " + myWords1.Length);
            #endregion
        }


        /// <summary>
        /// Changes the value of the last element of any integer array to 1 million.
        /// </summary>
        /// <param name="numbers">Any size integer array</param>
        public static void ChangeArrayData(int[] numbers)
        {
            // This will modify the array in all scopes of this program.
            numbers[numbers.Length - 1] = 1_000_000;
        }


        /// <summary>
        /// Sets the value of a Boolean variable to true ONLY within the scope of this method.
        /// Does not modify the variable or value that was passed into this method from elsewhere.
        /// </summary>
        /// <param name="trueOrFalse">Any Boolean variable or value</param>
        public static void ChangeValueTypeInMethodOnly(bool trueOrFalse)
        {
            // This is only true here in this method scope.
            trueOrFalse = true;

            // After this method executes, whatever value was passed into this method
            //   will remain false if it was false, or true if it was already true.
        }
    }
}
