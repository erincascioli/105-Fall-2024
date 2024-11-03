using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Demo: Exceptions 
// This program has 3 classes:  Player, PlayerManager, and Program
// A Player is a simple object with a name and a score. 
// PlayerManager handles multiple instances of Player objects.
// This demo shows intentional errors and how they can be handled
//   to eliminate crashes. 

namespace Exceptions_Sec7
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------- Need a try block? ------------------------------
            // Try blocks are needed when you call code that might cause an exception.
            // These 2 lines of code won't throw exceptions or crash your program, 
            //   so they don't need to be in a try block.  
            List<int> numbers = new List<int>();
            numbers.Add(3430);


            // ---------------------------- TRY/CATCH blocks -----------------------------
            // Your program can have as many try/catch blocks as you find necessary. 
            // Each try/catch block should be separated from the other try/catch blocks. 
            // A try can have multiple "attached" catch blocks, if you are wanting
            //   to handle different types of exceptions. 


            // First TRY/CATCH block with MULTIPLE CATCHES -------------------------------
            try
            {
                // This code could throw an exception, so put it in the try
                // Why would it throw an exception?
                // The numbers list has a Count of 1, the only index is 0. 
                // Calling index 5 will cause an ArgumentOutOfRange exception. 
                Console.WriteLine(numbers[5]);
            }
            // If the numbers list is null, an ArgumentNullException would be thrown.
            // This first catch block would handle that type of exception. 
            catch (ArgumentNullException ex)
            {
                // Inside of the catch, place whatever code you want to run
                //   instead of crashing the program.
                // This will print the error message found in the ArgumentNullException
                //   object ex.
                Console.WriteLine("Null Error: " + ex.Message);
            }
            // If an invalid index is called, an ArgumentOutOfRangeException would be thrown.
            // This second catch block would handle that type of exception.
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Out of range Error: " + ex.Message);
            }


            // Second TRY/CATCH block with a SINGLE CATCH -------------------------------
            try
            {
                // Cannot divide by zero, so a DivideByZero exception would be thrown
                //   when line 60 executes.
                int value = 0;
                int division = 55 / value;
            }
            // This will catch ANY type of thrown exception!  Not just 
            //   DivideByZero exceptions!
            catch (Exception ex)
            {
                // This will print the error message found in the generic Exception
                //   object ex.
                Console.WriteLine("Error: " + ex.Message);
            }


            // Third TRY/CATCH block -------------------------------
            // Create some Player dudes
            // Add them to the PlayerManager's list of Players
            PlayerManager pm = new PlayerManager();
            pm.AddPlayer("Bob");
            pm.AddPlayer("Dave");
            pm.AddPlayer("Ryan");
            pm.AddPlayer("Shaggy");
            pm.AddPlayer("Velma");
            pm.AddPlayer("Daphne");

            // Let's try to get a Player that DOES exist, 
            //   and another Player that DOESN'T exist.
            // The GetPLayerByName method calls could throw exceptions, 
            //   so we'll call them in a try block.
            // This code will run line 101 just fine
            // And will catch the exception thrown by line 102
            // And skip down to the catch block. 
            // Line 103 will not execute. 
            try
            {
                Player bob = pm.GetPlayerByName("Bob");             // FINE
                Player unknown = pm.GetPlayerByName("Urglgru");     // OOPS
                Player ryan = pm.GetPlayerByName("Ryan");           // FINE
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error detected! " + ex.Message);
            }

            // Since the program never crashed, this line will execute!
            Console.WriteLine("Code after all try/catches");

            // Window open
            Console.ReadLine();
        }
    }
}
