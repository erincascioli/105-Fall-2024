
// Erin Cascioli
// 10/2/24
// Demo: For loops, Break statements, Continue statements, and Nested loops

namespace ForBreakContinue_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string password = "";
            string userGuess = "";


            // ************************************************************************************
            //                                                                                    *
            //                                  FOR LOOPS                                         *
            //                                                                                    *
            // ************************************************************************************

            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // Loop 1: Prints consecutive values from 0 - 9 on the same line.
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

            PrintHeadline("PRINT 0 THROUGH 9", true);

            for (int i = 0; i <= 9; i++)                    // or (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
            }


            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // Loop 2: Prints backward consecutive values from 10 - 1 on the same line.
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            PrintHeadline("PRINT 10 THROUGH 1");

            for (int i = 10; i >= 0; i--)                   // or (int i = 10; i > -1; i--)
            {
                Console.Write(i + " ");
            }


            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // Loop 3: Prints consecutive values from 5 - 20 on the same line.
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            PrintHeadline("PRINT 5 THROUGH 20");
            for (int i = 5; i <= 20; i++)                   // or (int i = 5; i < 21; i++)
            {
                Console.Write(i + " ");
            }


            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // Loop 4: Prints 10 through 90 in intervals of 10.
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            PrintHeadline("PRINT 10 THROUGH 90, SKIPPING BY 10'S");
            for (int i = 10; i <= 90; i += 10)              // or (int i = 10; i < 91; i += 10)
            {
                Console.Write(i + " ");
            }


            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // Loop 5: Prints backward intervals of 10 from 100 through 0.
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            PrintHeadline("COUNT BACKWARD BY 10");
            for (int i = 100; i >= 0; i -= 10)              // or (int i = 100; i > -1; i -= 10)
            {
                Console.Write(i + " ");
            }


            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // Loop 6: Iterates through each index of a string, printing to the window
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            PrintHeadline("PRINT EACH CHARACTER ON SEPARATE LINE");

            string word = "waffle";
            for (int i = 0; i <= word.Length - 1; i++)      // or (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
            }



            // ************************************************************************************
            //                                                                                    *
            //                       NESTED LOOPS FOR GAMEPLAY                                    *
            //                                                                                    *
            // ************************************************************************************

            // ** Nested loops **
            // Like conditionals, loops can be nested when needed. 
            // The outer loop will run first, and any inner loops will execute afterward.
            // These are useful when you need to:
            //  - Ask the user to continue playing, and inside that loop, validate data.


            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // Loop 7: Play a guessing game
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

            // ** PSEUDOCODE: **
            // Start LCV password as "new password"
            // Does user want to play the game?
            // WHILE they keep choosing "YES"...
            //     Prompt user for password. Gather input.
            //     WHILE they guessed incorrectly...
            //         Re-prompt user for password with "invalid" message.
            //         Gather new input.
            //         IF the guess correct...
            //             Notify of correct guess!
            //     Do they want to play again? Gather input.


            // ** CODE: **
            PrintHeadline("GUESS THE PASSWORD (new password)");

            // Variables needed for this situation:
            string userChoice = "";
            userGuess = "";
            password = "new password";

            // Want to play the game?
            Console.Write("Do you want to play my guessing game? Enter Y or N: ");
            userChoice = Console.ReadLine()!.Trim().ToUpper();

            // Keep going if user wants to play
            while (userChoice == "Y")
            {
                // Prompt user to enter a password
                Console.Write("Enter the password: ");
                userGuess = Console.ReadLine()!;

                // As long as the user has not guessed the password...
                while (userGuess != password)
                {
                    // Give feedback and re-gather their guess
                    Console.Write("Incorrect guess. Try again. Enter the password. ");
                    userGuess = Console.ReadLine()!;
                }

                // Did they guess it? Give feedback!
                // The only way to get this far in the game is if the user entered a correct value
                //   and breaks out of the inner "invalid word" loop!
                if (userGuess == password)
                {
                    Console.WriteLine("Yay! You guessed it!");
                }

                // Ask if they want to play again
                Console.Write("Do you want to play my game AGAIN? Enter Y or N: ");
                userChoice = Console.ReadLine()!.Trim().ToUpper();
            }

            Console.WriteLine("See you later!");


            // ************************************************************************************
            //                                                                                    *
            //                   NESTED LOOPS FOR ROWS & COLUMNS                                  *
            //                                                                                    *
            // ************************************************************************************

            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // Loop 8: Iterates through each index of a string, printing to the window
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

            // These loops' output is:
            // Row 1: 1*2*3*4*5*6*7*8*9*10
            // Row 2: 1*2*3*4*5*6*7*8*9*10
            // Row 3: 1*2*3*4*5*6*7*8*9*10
            // Row 4: 1*2*3*4*5*6*7*8*9*10
            // Row 5: 1*2*3*4*5*6*7*8*9*10

            // ** PSEUDOCODE: **
            // FOR 5 rows
            //     Write the row number
            //     FOR 10 columns
            //         Write the column's value
            //         Attach an asterisk for all columns except the last


            // ** CODE: **
            PrintHeadline("5 ROWS OF VALUES");

            // Variables needed for this situation:
            int numberRows = 5;
            int numberColumns = 10;

            // Create 5 rows of numbers
            for (int row = 1; row <= numberRows; row++)
            {
                // Prints row number
                Console.Write($"Row {row}: ");

                // Create 10 columns of numbers 
                for (int col = 1; col <= numberColumns; col++)
                {
                    // Print column number at the associated spot
                    Console.Write(col);

                    // Print asterisk between all but the last value
                    if (col < numberColumns)
                    {
                        Console.Write("*");
                    }
                }

                // Break the line at the end of columns
                Console.Write("\n");
            }



            // ************************************************************************************
            //                                                                                    *
            //                           BREAK AND CONTINUE                                       *
            //                                                                                    *
            // ************************************************************************************

            // *** Continue and Break Statements ***
            // A continue; statement skips the current iteration and moves on to the next one.
            // A break; statement breaks out of the current loop and returns to the scope
            //   immediately above it.


            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // Loop 9: Print all even values from 20 - 40
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

            // ** PSEUDOCODE: **
            // Start LCV at 19
            // WHILE the number hasn't reached 40 yet...
            //     Is it an odd value? Skip over this iteration.
            //     Print the value.
            //     Increase by 1 (ensures LCV changes and stops infinite loop)

            // ** CODE: **
            PrintHeadline("PRINT EVENS, SKIP ODDS WITH CONTINUE");

            // Start the loop at 19. Why? To print 20 to the window.
            counter = 19;

            // Numbers 20 - 40
            while (counter <= 40)
            {
                // Increase to stop an infinite loop from occurring
                counter++;

                // Skip over odd values
                if (counter % 2 == 1)
                {
                    continue;
                }

                // Print numbers on the same line with space between
                Console.Write(counter + " ");
            }


            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // Loop 10: Skip over several values with a common value of 1
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

            // ** PSEUDOCODE: **
            // FOR x 0 - 3
            //     FOR y 0 - 2
            //         SKIP over X at 1
            //         Print "x: ?, y: ?" where ? is an increasing coordinate value

            // ** CODE: **
            PrintHeadline("SKIP X VALUE OF 1 IN A LIST OF COORDINATES");

            // 4 "columns"
            for (int x = 0; x < 4; x++)
            {
                // 3 "rows"
                for (int y = 0; y < 3; y++)
                {
                    // Exit the inner loop at column 1
                    if (x == 1)
                    {
                        break;
                    }
                    Console.WriteLine($"x: {x}, y: {y}");
                }
            }
        }



        // ************************************************************************************
        //                                                                                    *
        //                               STATIC METHODS                                       *
        //                                                                                    *
        // ************************************************************************************

        /// <summary>
        /// Prints a headline to the console window, surrounded by dashed lines.
        /// </summary>
        /// <param name="phrase"></param>
        public static void PrintHeadline(string phrase, bool first = false)
        {
            if(first)
            {
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine($"-- {phrase} --");
                Console.WriteLine("-----------------------------------------------");
            }
            else
            {
                Console.WriteLine("\n\n-----------------------------------------------");
                Console.WriteLine($"-- {phrase} --");
                Console.WriteLine("-----------------------------------------------");
            }
        }
    }
}
