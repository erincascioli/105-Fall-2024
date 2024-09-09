
// Erin Cascioli
// 9/9/24
// Demo: Typecasting and math methods

namespace Casting_MathMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Casting
            // ----------------------------------------------------------------

            // ** Casting examples **
            // Declaration of 6 integers:
            int x1;
            int x2;
            int x3;
            int x4;
            int x5;
            int x6;

            // Assign values to these variables:
            x1 = 82;                // no casting, int --> int
            x2 = (int)2.57;         // explicit cast, double --> int
            x3 = (int)25.7/5;       // cast a single value in an expression
            x4 = (int)(25.7/5);     // cast an entire expression's evaluated value

            short y1 = 2;
            x5 = y1;                // implicit cast (automatic)

            x6 = 23;
            double d0 = x6;         // implicit cast (automatic)

            // ** Losing data with a cast **
            // Casts may result in the returned value meaning changing from its
            //   original value.  444444444444 is -2147483648 as an integer.
            double longNumber = 444_444_444_444;
            int smallerNumber = (int)d0;
            Console.WriteLine(longNumber + " as an int is " + smallerNumber);

            // String interpolation gives the same result as the statement above.
            // Can be easier for some programmers to read, as the variable identifiers
            //   are built right into the resulting string, with { }'s around the 
            //   variable identifier. 
            Console.WriteLine($"{longNumber} as an int is {smallerNumber}");


            // Casting characters
            Console.WriteLine((char)69 + "" + (char)114 + "" + (char)105 + "" + (char)110);
            Console.WriteLine($"{(char)69}{(char)114}{(char)105}{(char)110}");

            Console.WriteLine("The first letter of Erin is ASCII code " + (int)'E');
            Console.WriteLine($"The first letter of Erin is ASCII code {(int)'E'}");


            // ----------------------------------------------------------------
            // Math Methods
            // ----------------------------------------------------------------

            // ** Round method **
            // The Round method returns a double.  You can find that information
            //   through the Intellisense feature of VS, or through official
            //   Microsoft docs.  
            // Highlight Math.Round and press F1 to jump directly to the
            //   page for the Round method.

            // ** Using the Round method **
            // Returned values from Math methods can be stored/saved in variables.
            double d1 = Math.Round(6.739);
            double d2 = Math.Round(6.739, 1);
            double d3 = Math.Round(6.739, 2);
            double d4 = Math.Round(6.739, 3);
            double d5 = Math.Round(6.739, 4);

            // And you can reference those variables in a C.WL statement
            //   or use those variables later on.
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);

            // ** Round method within a C.WL **
            // Returned values from Math methods can also be used directly within
            //   C.WL statements (or other Math methods!)
            Console.WriteLine(Math.Round(6.739));

            // ** Casting with the Round method **
            // When a method returns a more-precise value than what you desire,
            //   explicit casting must occur.
            // The Round method returns a double, and it must be cast to an int
            //   if you want to save that in an integer variable.
            int x7 = (int)Math.Round(6.739);

            // ** Floats - PI **
            // Math.PI is a handy dandy constant. Usefor for multiplying against
            //   or for dividing with.
            double threeCircleRadians = 6 * Math.PI;
            Console.WriteLine($"There are {threeCircleRadians} radians in 3 full circles.");
        }
    }
}
