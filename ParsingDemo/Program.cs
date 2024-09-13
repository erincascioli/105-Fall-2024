
// Erin Cascioli
// 9/13/24
// Demo: Parsing data from strings


namespace ParsingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double someNumber = 4.555666777;
            double roundedNumber = Math.Round(someNumber, 3);
            Console.WriteLine(roundedNumber);



            // 1. Prompt the user to enter a string value
            // 2. Call C.RL and save it in a string variable
            // 3. Print result

            // Variable block
            string userInput;
            double userNumber = 0;
            double result = 0;

            // 1. Prompt user
            Console.Write("Please enter your favorite place in the world: ");
            //Console.Write("Please enter your favorite place in the world >> ");
            //Console.Write("Please enter your favorite place in the world -> ");
            //Console.Write("Please enter your favorite place in the world #");

            // 2. Gather their input
            userInput = Console.ReadLine()!;

            // 3. Print result
            Console.WriteLine("I love " + userInput + " too!");
            //Console.WriteLine($"I love {userInput} too!");


            // Parse a number and double it!
            // 1. Prompt for data
            Console.Write("Enter a DECIMAL number: ");

            // 2. Gather input
            userInput = Console.ReadLine()!;

            // 3. Parse to an integer
            userNumber = double.Parse(userInput);

            // 4. Multiply and print back
            result = userNumber * 2;
            Console.WriteLine("The number doubled is " + result);

            // She said, "Hello"!
            Console.WriteLine("She said, \"Hello!\"");



            
            #region Section 3
            /*
            // 1. Prompt the user to enter some numerical data
            // 2. Call C.RL and save it in a string variable
            // 3. Parse the data, then multiply by 2
            // 4. Print result

            // Variable block
            string userInput = "";
            double userNumber = 0;
            double result = 0;

            // Program!
            Console.Write("Enter a decimal number between 1 and 100: ");
            userInput = Console.ReadLine()!;
            userNumber = double.Parse(userInput);
            result = userNumber * 2;
            Console.WriteLine("Your number doubled is " + result);

            // Parse errors:
            // Parsing can result in a runtime error if the user does not type in the correct datatype...
            // For now, we can't control this! It is what it is.

            Console.WriteLine("He said \"Hi there\"");
            */
            #endregion
        }
    }
}
