using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Demo: Simple Exceptions and Exception Handling Demo
// Exceptions are thrown by calling intentionally broken code
//   and handled with try/catch blocks.  

namespace Sec3_ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------------------------- TRY/CATCH Blocks -----------------------------
            // Use try/catch blocks only where necessary
            // Anytime you can error-check with conditionals, tryparse, etc. DO SO!!!
            // Exceptions are SLOW to create/throw/catch
            //   and should only be used in situations where you cannot predict/prevent
            //   an error by using simple conditionals, checking for null, etc.  
            // An exception means "I simply cannot go on!" (pause for dramatic effect)
            //   "and I must stop noooow"
            // ------------------------------------------------------------------------

            // --------------------- Exception Handling Speed -------------------------
            // Creating an exception, then catching it, then handling it is a slow process.  
            // Demo of how slow exceptions can be versus checking valid values
            //    with an if statement (a simple conditional is always the best option)

            // Super quick!  Almost instantaneous!
            int totalValidDivisions = 0;
            int totalThrownExceptions = 0;

            for (int i = 0; i < 10000; i++)
            {
                int divisor = 0;

                // Only divide if the divisor is not 0.
                // Preventing a crash! 
                if (divisor != 0)
                {
                    int number = 5 / divisor;
                    totalValidDivisions++;
                }
            }

            // Print out a total to see the elapsed time error handling with a conditional 
            Console.WriteLine("How many divisions were ok? " + totalValidDivisions);


            // SLOW!  
            // Took a while to create 100,000 exceptions, throw them, and handle them
            for (int i = 0; i < 10000; i++)
            {
                try
                {
                    // Always divides by 0
                    int divisor = 0;
                    // An exception is thrown 
                    int number = 5 / divisor;
                    totalValidDivisions++;
                }
                // And that exception is caught
                catch(Exception e)
                {
                    totalThrownExceptions++;

                    // DON'T print the error message!  
                    // This will clutter up the Console with 100,000 statements
                }
            }
            // ------------------------------------------------------------------------

            // Print out totals to see the elapsed time when creating exceptions 
            Console.WriteLine("How many divisions were ok? " + totalValidDivisions);
            Console.WriteLine("How many exceptions were thrown? " + totalThrownExceptions);


            // ------------------------- TRY/CATCH Blocks -----------------------------
            // Try/Catch blocks can handle exceptions when they occur
            try
            {
                // It would be much better to check that the index is valid before
                //   automatically placing this in a try/catch, but it's here
                //   to demonstrate how to catch exceptions
                int[] numbers = { 1, 2, 3 };
                int index = -3;
                Console.WriteLine(numbers[index]);      // WILL THROW AN EXCEPTION

                // Since line 89 will throw an exception, lines 94 - 96 will actually never run. 
                // As above, would be far better to check that the divisor is not 0
                //   rather than placing it in a try/catch
                Console.WriteLine("HI");
                int zero = 0;
                int number = 5 / zero;
            }
            // Catch specific exceptions first...
            // e is now a reference to the Exception object that C# created 
            // We have access to all of its properties/methods
            catch(IndexOutOfRangeException e)
            {
                // Message is one useful property that describes what the error is
                Console.WriteLine("Out of range " + e.Message);

                // Can also use a stack trace to see the line of offending code
                Console.WriteLine("Stack trace " + e.StackTrace);

                // These messages are helpful for the DEVELOPER and not the user
                // Error messages printed in a catch block are typically for debugging
                //   for a developer, and not for a user to do anything differently. 
            }
            catch (DivideByZeroException e)
            {
                // Again, this message is helpful for the DEVELOPER and not the user
                Console.WriteLine("Divide by zero " + e.Message);
            }
            // ... And catch generic exceptions later
            catch (Exception e)
            {
                Console.WriteLine("General " + e.Message);
            }
            
            // Code after all of the try/catches will execute.  
            Console.WriteLine("This will print if the program did not crash");

            // Open window
            Console.ReadLine();
        }
    
    }
}
