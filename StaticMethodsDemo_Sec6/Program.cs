namespace StaticMethodsDemo_Sec6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CODE THIS:
            // Ask the user for an int number, save in a variable
            // Ask the user for another int number, save in a variable

            int numberOne;
            int numberTwo;

            Console.Write("Enter a whole number: ");
            numberOne = int.Parse(Console.ReadLine()!);

            Console.Write("Enter another whole number: ");
            numberTwo = int.Parse(Console.ReadLine()!);


            // --------------------------------------------------------------------
            // CALL STATIC METHODS
            // --------------------------------------------------------------------
            // Any methods that are written below can be "called" here in Main.

            // Methods that return no information (void return type) can simply be called as-is.
            Sum(numberOne, numberTwo);


            // Methods that DO return information typically either:
            //  - Are called in a C.WL statement (if it returns a string or a value that needs
            //    to be printed to the console window)
            //  - Or save the returned value in a variable of the matching datatype
            //  - Or are called within another method, using the returned data from method #1
            //    inside of method #2.
            // This saved the returned data inside of a variable, then uses that variable
            //   somehow in the program. 
            int sumOfNumbers = SumReturn(numberOne, numberTwo);
            Console.WriteLine("The sum is " + sumOfNumbers);
        }
        // --------------------- END MAIN -------------------------------------


        // --------------------------------------------------------------------
        // STATIC METHODS GO HERE!!!
        // --------------------------------------------------------------------
        // All static method declarations should be placed down here, 
        //   between the end of the Main method and the end of the Program class.
        // 
        // Method declaration:  public static returntype ID(list of params)
        // Method doesn't need to give information back? VOID return type
        // Method returns some type of information back? DATATYPE return type
        //
        // Methods can receive 0 or more parameters. Up to you to decide
        //   what information the method needs to "do its job"

        /// <summary>
        /// Displays the sum of 2 numbers in the Console window
        /// </summary>
        /// <param name="one">Whole number, first operand of the sum</param>
        /// <param name="two">Whole number, second operand of the sum</param>
        public static void Sum(int one, int two)
        {
            Console.WriteLine("The sum of these numbers is " + (one + two));
        }


        /// <summary>
        /// Calculates and returns the sum of 2 integers
        /// </summary>
        /// <param name="one">Whole number, first operand of the sum</param>
        /// <param name="two">Whole number, second operand of the sum</param>
        /// <returns>The sum of 2 provided integers</returns>
        public static int SumReturn(int one, int two)
        {
            // Can do this in 2 lines:
            //int sumofNumbers = one + two;
            //return sumofNumbers;

            // Or in 1 line:
            return one + two;
        }


    // --------------------- END PROGRAM CLASS --------------------------------
    }
}
