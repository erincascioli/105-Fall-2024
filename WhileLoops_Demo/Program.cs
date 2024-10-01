
// Erin Cascioli
// 9/30/24
// Demo: While and Do-While Loops


namespace WhileLoops_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ************************************************************************************
            // ************************************************************************************
            //                                                                                    *
            //                                  HEADLINES                                         *                           
            //                                                                                    *
            // ************************************************************************************
            // ************************************************************************************
            // Rather than writing the same exact C.WL statement over and over again to visually
            //   divide your output, you can write a method that accomplishes the task.
            // Then call the method whenever needed!
            VisualDivider();


            // ************************************************************************************
            // ************************************************************************************
            //                                                                                    *
            //                         LOOPS WITH NUMBER RANGES                                   *                           
            //                                                                                    *
            // ************************************************************************************
            // ************************************************************************************

            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // Loop 1:
            //  - This loop shows proper structure.
            //  - The loop control variable (iterations) is set to a value that kick-starts the loop.
            //  - The loop control variable's value changes within the body of the loop.
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

            // PSEUDOCODE:
            // counter variable starts at 0 (printed value)
            // WHILE the number has not gone past 4...
            //     Print the number
            //     Increase by 1

            int iterations = 0;
            while (iterations < 5)
            {
                Console.WriteLine(iterations);
                iterations++;
            }
            Console.WriteLine("Done!");
            VisualDivider();


            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // Loop 2: 
            //  - Loop will never run
            //  - Why? The condition is false from the start
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

            Console.WriteLine("No iterations of a loop (no output appears):");
            iterations = 0;
            while (iterations > 1000000000)
            {
                Console.WriteLine(iterations);
            }
            Console.WriteLine("Done!");
            VisualDivider();


            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // Loop 3: 
            //  - Infinite Loop will ALWAYS run!
            //  - Why? The value of iterations is not changing, so the condition
            //    of iterations being less than a billion is ALWAYS true
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

            Console.WriteLine("Infinite loop (commented so output won't appear):");
            iterations = 0;
            //while (iterations < 1000000000)
            //{
            //    Console.WriteLine(iterations);
            //}
            Console.WriteLine("Done!");
            VisualDivider();


            // ************************************************************************************
            // ************************************************************************************
            //                                                                                    *
            //                    LOOPS WITH INVALID NUMERICAL USER DATA                          *                           
            //                                                                                    *
            // ************************************************************************************
            // ************************************************************************************

            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // Loop 1: 
            // - Loop that asks for a number between 1 and 10 (a numerical range)
            // - Prompts the user for re-entry of invalid data
            // - Exit condition is valid data
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

            // PSEUDOCODE:
            // Prompt user for value in range of 1 - 10
            // Retrieve their input and parse to int
            // WHILE the number is invalid
            //     Provide feedback
            //     Re-prompt, gather data, parse

            // Declare variables for the loop
            int userNumber = 0;
            string userInput = "";

            // Prompt user and gather user data
            Console.Write("Enter a number between 1 and 10: ");
            userInput = Console.ReadLine()!;
            userNumber = int.Parse(userInput);

            // If user provides a bad number, force re-entry of data until user provides
            //   good input.
            while (userNumber < 1 || userNumber > 10)
            {
                Console.Write("Invalid. " +
                    "Please enter a number within range of 1 - 10: ");
                userInput = Console.ReadLine()!;
                userNumber = int.Parse(userInput);
            }

            // The user has been forced to provide valid data to exit the loop.
            // It's safe to assume that userNumber is valid at this point.

            // Output division between loops
            VisualDivider();


            // ************************************************************************************
            // ************************************************************************************
            //                                                                                    *
            //                       LOOPS WITH INVALID STRING USER DATA                          *                           
            //                                                                                    *
            // ************************************************************************************
            // ************************************************************************************

            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            // Loop 1: 
            // - Loop that asks for a season
            // - Prompts the user for re-entry of invalid data
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 

            // Declare variables for the loop
            userInput = "";

            // Prompt user and gather user data
            Console.WriteLine("Enter a season. ");
            Console.Write("Enter 'spring' 'summer' 'fall' or 'winter': ");
            userInput = Console.ReadLine()!.Trim().ToLower();

            // Force re-entry of data until user provides valid input.
            while (userInput != "spring" &&
                    userInput != "summer" &&
                    userInput != "fall" &&
                    userInput != "winter")
            {
                Console.Write("Invalid. " +
                    "Please enter a season: ");
                userInput = Console.ReadLine()!.Trim().ToLower();
            }

            Console.WriteLine("Thank you for your season of {0}.", userInput);

            // Output division between loops
            VisualDivider();


            // ************************************************************************************
            // ************************************************************************************
            //                                                                                    *
            //              LOOPS WITH CHARACTER-BY-CHARACTER STRING ITERATION                    *                           
            //                                                                                    *
            // ************************************************************************************
            // ************************************************************************************

            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            // Loops 1 & 2:
            //  - Iterate index by index of a string
            //  - Concatenate each letter to a new string, backwards
            //    where every other letter is uppercase          
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

            // New variable needed: index. This is declared outside of the loop so it remains
            //   in scope during both loops.
            int index = 0;

            // Used later for concatenation.
            string backwardsWord = "";

            // ** Prompt user for data. Gather and parse. **
            do
            {
                Console.Write("Enter a word between 3 and 10 letters long: ");
                userInput = Console.ReadLine()!;

                // User provided an invalid short word.
                if(userInput.Length <= 2)
                {
                    Console.WriteLine("Not enough letters. Try again.");
                }
                // User provided an invalid long word.
                else if (userInput.Length > 10)
                {
                    Console.WriteLine("Word was more than 10 letters. Try again.");
                }
                // Appropriate length - get index of the last character
                else
                {
                    index = userInput.Length - 1;
                }
            }
            while (userInput.Length <= 2 || userInput.Length > 10);


            // ** Iterate through each index of the string to build a backwards word **
            while (index >= 0)
            {
                // Get an uppercase version of all even-indexed characters
                if (index % 2 == 0)
                {
                    backwardsWord = backwardsWord +
                        userInput[index].ToString().ToUpper();
                }
                // And a lowercase version of all odd-indexed characters
                else
                {
                    backwardsWord = backwardsWord +
                        userInput[index].ToString().ToLower();
                }
                index--;
            }

            Console.WriteLine("Your word is " + backwardsWord);

            // Output division between loops
            VisualDivider();


            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            // Loop 3:
            // - Ensure a string is of proper length
            // - Prompt user for re-entry of invalid user data
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

            // Prompt the user for a specific length name
            Console.Write("Enter a name with less than 5 letters: ");
            string name = Console.ReadLine()!;

            // As long as the name is too long, re-prompt for entry
            while (name.Length >= 5)
            {
                Console.WriteLine("You done goofed, A-A-Ron");
                Console.Write("Enter it again. No more than 5 letters this time. ");
                name = Console.ReadLine()!;
            }

            // Output division between loops
            VisualDivider();


            // ************************************************************************************
            // ************************************************************************************
            //                                                                                    *
            //                                 DO-WHILE LOOPS                                     *                           
            //                                                                                    *
            // ************************************************************************************
            // ************************************************************************************

            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            // Loop 1: Prints out all numbers from 20 - 200
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

            int number = 201;
            do
            {
                Console.WriteLine(number);
                number++;
            }
            while (number <= 200);

            // Output division between loops
            VisualDivider();


            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            // Loop 2: 
            //  - Printing all values between 10 and 1
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

            int count = 10;
            do
            {
                count--;
                Console.WriteLine(count);
            }
            while (count > 0);

            // Output division between loops
            VisualDivider();


            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            // Loop 3:
            //  - Prompts for number between 1 and 10
            //  - Has different output depending on user response
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

            // Declare variables for the loop
            userNumber = 5;
            userInput = "";

            do
            {
                if(userNumber >= 1 && userNumber <= 10)
                {
                    Console.Write("Enter a number between 1 and 10: ");
                }
                else
                {
                    Console.Write("Invalid. " +
                    "Please enter a number within range of 1 - 10: ");
                }

                userInput = Console.ReadLine()!;
                userNumber = int.Parse(userInput);
            } 
            while (userNumber < 1 || userNumber > 10);

            // Output division between loops
            VisualDivider();



            // ************************************************************************************
            // ************************************************************************************
            //                                                                                    *
            //            PROPER LOOP STRUCTURE WITH CLEAR, EXPLICIT EXIT CONDITIONS              *                           
            //                                                                                    *
            // ************************************************************************************
            // ************************************************************************************

            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            // *** Poorly Structured Loop: ***
            // If looking at just the while loop declaration --> while(endLoop)
            //   a programmer has no idea when the loop will end until scrubbing through the code
            //   to find the exit condition.
            // Only in certain cases is a single boolean value inside of the loop's condition acceptable.
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

            //User input is invalid: force re-entry of data
            userInput = Console.ReadLine()!;
            bool keepGoing = true;

            Console.WriteLine("Enter your favorite season.");
            Console.Write("Type 'spring' 'summer' 'fall' or 'winter': ");
            userInput = Console.ReadLine()!.Trim().ToLower();

            while (keepGoing)
            {
                Console.Write("Invalid response. Please enter a season: ");
                userInput = Console.ReadLine()!.Trim().ToLower();

                keepGoing = userInput != "spring" &&
                            userInput != "summer" &&
                            userInput != "fall"   &&
                            userInput != "winter";
            }


            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            // *** Better Structured Loop: ***
            // Programmer can tell from looking at the exit condition 
            //   exactly when the loop will stop.
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            
            Console.WriteLine("Enter your favorite season.");
            Console.Write("Type 'spring' 'summer' 'fall' or 'winter': ");
            userInput = Console.ReadLine()!.Trim().ToLower();

            while (userInput != "spring" &&
                   userInput != "summer" &&
                   userInput != "fall"   &&
                   userInput != "winter")
            {
                Console.Write("Invalid response. Please enter a season: ");
                userInput = Console.ReadLine()!.Trim().ToLower();
            }


            // ************************************************************************************
            // ************************************************************************************
            //                                                                                    *
            //                    OTHER LOOPS THAT FULFILL DIFFERENT OUTCOMES                     *                           
            //                                                                                    *
            // ************************************************************************************
            // ************************************************************************************

            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            // Printing the numbers backward between 10 and 1
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            count = 10;
            while (count > 0)
            {
                count--;
                Console.WriteLine(count);
            }

            // Output division between loops
            VisualDivider();


            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            // Divide by 2 (integer division!) until we hit zero
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            int down = 100;
            while (down > 0)
            {
                down /= 2;
                Console.WriteLine(down);
            }

            // Output division between loops
            VisualDivider();


            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            // ADVANCED for now
            // Ensuring that parse doesn't crash:
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            Console.Write("Enter any number: ");
            userInput = Console.ReadLine()!;

            // Attempt to parse and check the result
            number = 0;
            while (int.TryParse(userInput, out number) == false)
            {
                Console.Write("Enter a number this time: ");
                userInput = Console.ReadLine()!;
            }
        }


        /// <summary>
        /// Prints a line of asterisks to the console window.
        /// </summary>
        public static void VisualDivider()
        {
            Console.WriteLine("\n*************************************************\n");
        }
    }
}
