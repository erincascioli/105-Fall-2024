namespace TryParseRandom_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables needed
            int result = 0;
            bool success = false;
            Random rng = new Random();

            // Try different overloads of the Next method
            Console.WriteLine(rng.Next());
            Console.WriteLine(rng.Next(10));
            Console.WriteLine(rng.Next(10, 21));

            // Try getting a randomized double from the NextDouble method
            Console.WriteLine(rng.NextDouble());

            // Prompt user for a number within range and gather their data
            Console.Write("Enter a number from 1 - 10: ");
            success = int.TryParse(Console.ReadLine()!, out result);

            // Re-prompt for a given
            while(!success ||                   // Bad format type of provided data
                  (result < 0 || result > 10))  // Out of range
            {
                Console.Write("Invalid. Try again. ");
                success = int.TryParse(Console.ReadLine()!, out result);
            }

            // CAN ASSUME DATA IS VALID AND WITHIN RANGE AT THIS POINT
            if(result == 5)
            {
                Console.WriteLine("Yay");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
