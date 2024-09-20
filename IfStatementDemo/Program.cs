
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
            const int correctNumber = 7;


            // ----------------------------------------------------------------
            // Get user data
            // ----------------------------------------------------------------
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
            // ----------------------------------------------------------------
            // Change color based on user's choice
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
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }


            // ----------------------------------------------------------------
            // Display guess results
            // ----------------------------------------------------------------
            // Display results of their guess
            if (userNumber == correctNumber)
            {
                Console.WriteLine("Yay you guessed right!");
            }
            if (userNumber < correctNumber)
            {
                Console.WriteLine("Too low!");
            }
            if (userNumber > correctNumber)
            {
                Console.WriteLine("Too high!");
            }

            /*
           // You could do this as well:
           bool guessedCorrectNumber = (userNumber == 7);
           if (guessedCorrectNumber)       // if (guessedCorrectNumber == true)
           {
               Console.WriteLine("Yay you guessed right!");
           }
           */
        }
    }
}
