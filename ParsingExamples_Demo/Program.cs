// Erin Cascioli
// Example program: Parsing values from strings
// 
//      This is a small program that demonstrates how to gather information 
//      from a user.  Numerical data is parsed from the user-provided input. 
//      User should provide input in the specified format.  
//
//      Important info:
//          Input that does not match the specified data type will cause program to crash.  
//          i.e. Entering "chocolate" as the user's birth year will crash.
//          i.e. Entering true for an integer will crash.
//
//      Ignore the warnings about Console.ReadLine for now. 
//              

namespace ParsingExamples_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Necessary variables
            // ----------------------------------------------------------------
            // None of these variables are initialized, as we don't know what
            //   values the user will provide.
            // Initialization will occur after gathering user input.
            string userProvidedPriceAsString;               // Cost of salad, minus tax, as string
            double userProvidedPriceAsDouble;               // Cost of salad, minus tax, parsed
            double tax;                                     // Calculated tax on salad
            double totalCost;                               // Calculated total of salad
            string userYearAsString;                        // Birth year, as string
            int userYearAsInteger;                          // Birth year, parsed
            string userName;                                // Name of user


            // ----------------------------------------------------------------
            // Introduction to the program
            // ----------------------------------------------------------------
            // Basic introduction
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Hi!");
            Console.WriteLine("I will ask you some questions.");
            Console.WriteLine("Please answer as best you can.");
            Console.WriteLine();

            // Gather user's name
            Console.Write("What is your name? ");
            userName = Console.ReadLine();
            Console.WriteLine("Thanks, " + userName + "!");
            Console.WriteLine();


            // --- Example 1 --------------------------------------------------
            // Calculate tax on a user-provided price.
            // ----------------------------------------------------------------
            // Formatting of the question
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("1. Price of your lunch:");

            // Prompt user for a price of their salad. Parse to double.
            Console.Write("Please enter the price of your salad: $");
            userProvidedPriceAsString = Console.ReadLine();
            userProvidedPriceAsDouble = double.Parse(userProvidedPriceAsString);

            // Calculate tax and display to user.
            // A locally declared variable saves the tax amount rounded to 2 decimal places.
            Console.WriteLine("Let’s calculate the tax on that...");
            tax = userProvidedPriceAsDouble * 0.08;
            double taxRounded = Math.Round(tax, 2);
            Console.WriteLine("The tax on your salad is $" + taxRounded);

            // Calculate total cost of salad. Display to user.
            Console.WriteLine("Let’s find the total of your salad.");
            totalCost = userProvidedPriceAsDouble + taxRounded;
            Console.WriteLine("Your salad costs $" + totalCost);

            // Intro to the next part...
            Console.WriteLine("\nLet's try something else.");


            // --- Example 2 --------------------------------------------------
            // Calculate the user's age
            // ----------------------------------------------------------------
            // Formatting of the question
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("2. Find your age:");

            // Prompt user for their birth year. Parse to integer.
            Console.Write("What year were you born? ");
            userYearAsString = Console.ReadLine();
            userYearAsInteger = int.Parse(userYearAsString);

            // Calculate the user’s age dependent on their birth year.
            // If the user’s birth month and date are after the date the program is run,
            //   they have not yet passed a full year.
            Console.WriteLine(
                "It is now 2023. " +                        // 
                userName +                                  // Parrot user's name
                ", you must be " +                          // 
                (2023 - userYearAsInteger) +                // Calc age range
                " or you might be " +                       //
                (2023 - userYearAsInteger - 1) +            // Calc age if late birthday
                " years old.");                             //


            // ----------------------------------------------------------------
            // End the program
            // ----------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Thank you for those answers, " + userName + "!");
            Console.WriteLine("Play again soon.");
        }
    }
}