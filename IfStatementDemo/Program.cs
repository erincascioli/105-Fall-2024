
// Erin Cascioli
// 9/20/24
// Demo: If Statements and If-Else Statements

namespace IfStatementDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Variable block
            // ----------------------------------------------------------------
            // These variables are within scope throughout all of the Main method.
            const int correctNumber = 7;
            int health = -3;


            // ----------------------------------------------------------------
            // Get user data
            // ----------------------------------------------------------------

            // PSEUDOCODE:
            // Prompt for input of integer ranged 1 - 10
            // Get user's data
            // Parse to integer
            // Prompt for color: red, green, blue
            // Get user's data as string

            // Grab user's guessed number and their chosen color
            Console.Write("Guess a whole number between 1 and 10: ");

            // Parse their input to an integer
            // Can do it in two lines like this:
            //string userInput = Console.ReadLine()!;
            //int userInputAsInt = int.Parse(userInput);
            // Or in one line like this:
            int userNumber = int.Parse(Console.ReadLine()!);

            Console.Write("Choose the best color: red, green or blue? ");
            string userColor = Console.ReadLine()!.ToUpper().Trim();


            // ----------------------------------------------------------------
            // Change console color
            // ---------------------------------------------------------------
            // This code has 3 distinct possibilities with a "catch-all" case
            //   handled by the else statement. The user could type red, or green,
            //   or blue, or ANYTHING ELSE at all. The else handles the "anything else"
            //   case. 

            // PSEUDOCODE:
            // IF chose red
            //      Change text to red
            // IF chose blue
            //      Change text to blue
            // IF chose green
            //      Change text to green
            // ELSE types anything else
            //      Display "Invalid" message
            //      Change text to yellow  

            // Change color based on user's valid choices of red, green, or blue
            if (userColor == "RED")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            else if (userColor == "GREEN")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (userColor == "BLUE")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            // User typed an invalid option --> Change text to yellow. 
            else
            {
                // Invalid option! Let the user know, don't make them guess. 
                Console.WriteLine($"I do not recognize {userColor}.");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }


            // ----------------------------------------------------------------
            // Display guess results with PSEUDOCODE
            // ----------------------------------------------------------------

            // PSEUDOCODE EXAMPLE:
            // Pseudocode is a way to describe the steps of an algorithm or program
            // using a natural language like English, mixed with programming language syntax.
            // This pre-planning can save hours of time debugging!
            
            // IF num is correct
            //      Display congrats message
            // IF number is smaller than correct
            //      IF number is less than 1
            //          Display "Invalid"
            //      ELSE number is 1, 2, 3, 4, 5, 6
            //          Display "Too low"
            // IF number is greater than correct
            //      IF number is more than 10
            //          Display "Invalid"
            //      ELSE number is 8, 9, 10
            //          Display "Too high"  


            // Correct guess!
            // ** See below for another way of writing this using a Boolean variable
            if (userNumber == correctNumber)
            {
                Console.WriteLine("Yay you guessed right!");
            }
            // Guess is smaller
            else if (userNumber < correctNumber)
            {
                // 0 or negative values
                if(userNumber < 1)          // Or you could say (userNumber <= 0)
                {
                    Console.WriteLine("That value is invalid. Choose a number between 1 and 10.");
                }
                // 1, 2, 3, 4, 5, 6
                else
                {
                    Console.WriteLine("Too low!");
                }
            }
            // Guess is larger
            else                            // Or you could say if (userNumber > correctNumber)
            {
                // 11 or higher
                if (userNumber > 10)        // Or you could say (userNumber <= 11>)
                {
                    Console.WriteLine("That value is invalid. Choose a number between 1 and 10.");
                }
                // 8, 9, 10
                else
                {
                    Console.WriteLine("Too high!");
                }
            }


            // ----------------------------------------------------------------
            // Scope in your programs!
            // ----------------------------------------------------------------
            // Variable declared within a code block exist only within that
            //   code block and any underneath/nested within.  
            // This output variable exists and is accessible within the Main
            //   method and in any nested code blocks here in Main, meaning it's 
            //   accessible in any if or else statements here. 

            // In this code block, the string variable output only exists within
            //   the if or else block. By the time Main attempts to access the variable
            //   in the C.WL line, the variable no longer exists.
            //if (health <= 0)
            //{
            //    string output = "dead";
            //}
            //else
            //{
            //    string output = "alive";
            //}

            //Console.WriteLine("The character is " + output);


            // However, in this case the variable is declared within Main, so it's
            //   entirely accessible in the if statement and all of Main.
            string output = "alive";
            if (health <= 0)
            {
                output = "dead";
            }

            Console.WriteLine("The character is " + output);
        }
    }
}
