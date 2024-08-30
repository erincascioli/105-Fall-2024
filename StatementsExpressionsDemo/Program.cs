

// ALWAYS ENTER THIS INFORMATION AT THE TOP OF YOUR PROGRAMS:
// YOUR NAME
// DATE
// PURPOSE OF THE PROGRAM


namespace StatementsExpressionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Statements with Console.WriteLines
            // ----------------------------------------------------------------

            // Every project starts out with this statement.
            // Students may delete it, as you won't need this for 99% if your assigned work. :)
            // Note: These comments are not going beyond the 80 - 100 character limit.
            Console.WriteLine("Hello, World!");

            // Anything that must be printed to the console window is placed within a
            //   Console.WriteLine statement.  
            // Characters (individual letters on the keyboard) must be positioned within a
            //   set of double-quotes.
            // Want to print "I am an ostrich" to the Console window? You need the following:
            Console.WriteLine("I am an ostrich");

            // Blank Console.WriteLines give space in the Console window.
            // This inserts 2 empty lines in the window.
            Console.WriteLine();
            Console.WriteLine();


            // ----------------------------------------------------------------
            // Line Length and Console.WriteLines
            // ----------------------------------------------------------------

            // The sentence "My name is Inigo Montoya. You killed my father. Prepare to die"
            //   *just* fits within the 80 - 100 character limit. It doesn't need to be broken.
            Console.WriteLine("My name is Inigo Montoya. You killed my father. Prepare to die.");

            // However, the sentence "According to all known laws of aviation, there is no way a bee should be able to fly. Its wings are too small to get its fat little body off the ground. The bee, of course, flies anyway, because bees don't care what humans think is impossible" will not.
            // Use multiple lines to enter this sentence in this program.
            // Visual Studio will automatically enter a + to concatenate those strings for you.
            // (See how looooooong that sentence is in the comments? Gross, right?)
            Console.WriteLine("According to all known laws of aviation, there is no way a bee " +
                "should be able to fly. Its wings are too small to get its fat little body off " +
                "the ground. The bee, of course, flies anyway, because bees don't care what humans " +
                "think is impossible");

            // Blank lines for output readability
            Console.WriteLine();
            Console.WriteLine();


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
            Console.WriteLine(100 % 5);			// Prints 0

            // Another way of styling the output window for readability
            // The \n enters a line break before the asterisks. 
            Console.WriteLine("\n**********************************");


            // ----------------------------------------------------------------
            // String Concatenation
            // ----------------------------------------------------------------

            // Strings can be combined with the + operator
            // string + string --> concatenates the strings!
            Console.WriteLine("I want to combine this string " + "with this string.");

            // Output spacing
            Console.WriteLine("\n**********************************");


            // ----------------------------------------------------------------
            // WriteLine versus Write
            // ----------------------------------------------------------------

            // Console.WriteLine inserts a line break at the end.
            // Console.Write does not. Text will continue where the cursor remains.
            Console.WriteLine("Console.WriteLine puts a line break afterward.");
            Console.Write("Console.Write does not.");
            Console.Write("Meaning that all of this text");
            Console.Write("is smooshed next to each other");
            Console.Write("in the console window.");
            Console.Write("Watch for spaces when using Write.");
            Console.WriteLine("And you might want to end with a Console.WriteLine.");

            // Output spacing
            Console.WriteLine("\n**********************************");


            // ----------------------------------------------------------------
            // Mathematical expressions within WriteLines
            // ----------------------------------------------------------------

            // Mathematical expressions are evaluated in a Console.WriteLine statement.
            // The following enters these values in the console window:
            Console.WriteLine(2 + 5);                       // Prints 7
            Console.WriteLine(100 - 35);                    // Prints 65
            Console.WriteLine(2 * 6);                       // Prints 12

            // Division occurs in 2 ways: Floating-point division and Integer division.
            // int/int --> int
            // fp/int  --> fp
            // int/fp  --> fp
            // fp/fp   --> fp
            Console.WriteLine(15/3);                        // Prints 5
            Console.WriteLine(20/3);                        // Prints 6
            Console.WriteLine(20.0/3);                      // Prints 6.666666666666667
            Console.WriteLine(20/3.0);                      // Prints 6.666666666666667
            Console.WriteLine(20.0/3.0);			        // Prints 6.666666666666667

            // Modulue is the REMAINDER of integer division
            Console.WriteLine(15 % 3);                      // Prints 0

            // Combining strings with mathematical expressions gives unexpected results...
            Console.WriteLine("2 plus 5 is " + 2 + 5);      // Prints "2 plus 5 is 25"

            // Use parentheses around mathematical expressions if combined with text.
            Console.WriteLine("2 plus 5 is " + (2 + 5));    // Prints "2 plus 5 is 7"

            // This line has an ERROR in it!
            // Why does it have // in front of it? That's a debugging technique!  It allows
            //   the program to compile and run without this statement showing a syntax error.
            //Console.WriteLine("I was born in " + 2024 - 75);

            // FIXED!
            Console.WriteLine("I was born in " + (2024 - 75));

            // Use parentheses for complex mathematical expressions
            Console.WriteLine(100 - (3 * 5) + (26.7/2));
        }
    }
}