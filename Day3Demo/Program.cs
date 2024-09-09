
// Name
// Date
// Purpose

// Erin Cascioli
// 8/30/24
// Day 3 Demo: Statements and Expressions

/* Erin Cascioli
 * 8/30/24
 * Demo: Statements and Expressions
 * */



namespace Day3Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Console.WriteLine and Console.Write
            // ----------------------------------------------------------------

            Console.WriteLine("wakrghzsJFggsajze");\

            Console.WriteLine("Hi everyone!");
            Console.WriteLine("Let's play with sample code for our first coding day of 105!");
            Console.WriteLine();
            Console.Write("It's ");
            Console.Write("almost ");
            Console.Write("the ");
            Console.Write("weekend!");
            Console.WriteLine();


            // ----------------------------------------------------------------
            // Errors in Code
            // ----------------------------------------------------------------

           
            Console.WriteLine("This line has a mistake.");
            Console.WriteLine("Another mistake here!");
            Console.WriteLine("Yet another mistake");
            Console.WriteLine("Missing a semicolon at the end");

            // Erin: FIX THIS!
            // TODO: Research this error
            //6 + 3;
            


            // ----------------------------------------------------------------
            // Breaking Code into Lines
            // ----------------------------------------------------------------

            
            Console.WriteLine("This line is really long. We need to break it into multiple " +
                "lines so we're not scrolling right too much. Always break your long lines " +
                "into multiple lines. Visual Studio can help you do it.");
            


            // ----------------------------------------------------------------
            // String Concatenation
            // ----------------------------------------------------------------

            // Strings can be combined with the + operator
            // string + string --> concatenates the strings!
            Console.WriteLine("I want to combine this " + "with this.");


            // ----------------------------------------------------------------
            // Comments
            // ----------------------------------------------------------------

            // This is a single-line comment. It allows us to describe
            //   what the code underneath it does.
            Console.WriteLine("The above comment explains this statement.");

            /* Need multiple lines for a comment?
             * Feel free to use a multi-line comment!
             * They start with a slash star and end the opposite way.
             * */

            // Comments ARE ONLY permitted to the right of code IF the comments
            //   are short.  They must be left-aligned, like the following:
            Console.WriteLine(16 - 2);          // Prints 14
            Console.WriteLine(100 % 5);         // Prints 0


            // ----------------------------------------------------------------
            // Mathematical Expressions
            // ----------------------------------------------------------------

            // + - * / and % are common operands.
            Console.WriteLine(284 + 4629);          // Prints 4913
            Console.WriteLine(4726346 - 1);         // Prints 4726345

            // Division occurs in 2 ways: Floating-point division and Integer division.
            // int/int --> int
            // fp/int  --> fp
            // int/fp  --> fp
            // fp/fp   --> fp
            Console.WriteLine(20/3);                // Prints 6
            Console.WriteLine(20.0/3);              // Prints 6.666666666666667
            Console.WriteLine(20/3.0);              // Prints 6.666666666666667
            Console.WriteLine(20.0/3.0);            // Prints 6.666666666666667


            // ----------------------------------------------------------------
            // Combining Strings with Mathematical Expressions
            // ----------------------------------------------------------------

            // Watch out for combinations of strings with mathematical expressions.
            // Calculate the birth year for someone who is 75 years old.
            // This line has an ERROR in it!
            //Console.WriteLine("I was born in " + 2024 - 75);	

            // FIXED!  Use parentheses around math expressions!
            Console.WriteLine("I was born in " + (2024 - 75));

            // There's no error here, but the output isn't what you expect!
            // The + operand is seen as CONCATENATION, not addition
            Console.WriteLine("2 plus 5 is " + 2 + 5);  // Prints "2 plus 5 is 25"

            // Again, use parentheses here:
            Console.WriteLine("2 plus 5 is " + (2 + 5));	// Prints "2 plus 5 is 25"
        }
    }
}