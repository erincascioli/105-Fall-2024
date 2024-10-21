
// Erin Cascioli
// 10/18/24
// Demo: Method Overloading & Array Algorithms

namespace StaticMethods_ArrayAlgorithms_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Variables needed for program
            // ----------------------------------------------------------------
            double sum = 0;
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] numbers2 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            string[] words = { "Witch", "Pumpkin", "Ghost" };


            // ----------------------------------------------------------------
            // CALLING STATIC METHODS
            // ----------------------------------------------------------------

            // Print all values in the array
            Console.WriteLine("Here are all values in the words array: ");
            PrintArray(words);

            // Print all values in the array, then print the sum of all values
            Console.WriteLine("\nHere are all values in the numbers array: ");
            PrintArray(numbers);
            sum = AddNumbers(numbers);
            Console.WriteLine("The sum is " + sum);

            Console.WriteLine("\nHere are all values in the numbers2 array: ");
            PrintArray(numbers2);
            sum = AddNumbers(numbers2);
            Console.WriteLine("The sum is " + sum);

            // Call one of the multiple AddNumbers method overloads
            Console.WriteLine("\n5 + 7 + 8");
            sum = AddNumbers(5, 7, 8);
            Console.WriteLine("The sum is " + sum);

            Console.WriteLine("\n5.7 + 9.26472");
            sum = AddNumbers(5.7, 9.26472);
            Console.WriteLine("The sum is " + sum);

            Console.WriteLine("\n4 + 87");
            sum = AddNumbers(4, 87);
            Console.WriteLine("The sum is " + sum);

            Console.WriteLine("\n2 + 1200 + 7 + 60");
            sum = AddNumbers(2, 1200, 7, 60);
            Console.WriteLine("The sum is " + sum);
        }


        /// <summary>
        /// Adds 2 numbers and returns the sum.
        /// </summary>
        /// <param name="one">First whole number</param>
        /// <param name="two">Second whole number</param>
        /// <returns>Sum of the 2 values</returns>
        public static int AddNumbers(int one, int two)
        {
            return one + two;
        }

        /// <summary>
        /// Adds 2 doubles and returns the sum.
        /// </summary>
        /// <param name="one">First floating-point number</param>
        /// <param name="two">Second floating-point number</param>
        /// <returns>Sum of the 2 values</returns>
        public static double AddNumbers(double one, double two)
        {
            return one + two;
        }

        /// <summary>
        /// Adds 3 integers and returns the sum.
        /// </summary>
        /// <param name="one">First whole number</param>
        /// <param name="two">Second whole number</param>
        /// <param name="three">Third whole number</param>
        /// <returns>Sum of all values</returns>
        public static int AddNumbers(int one, int two, int three)
        {
            return one + two + three;
        }

        /// <summary>
        /// Adds 4 integers and returns the sum.
        /// </summary>
        /// <param name="one">First whole number</param>
        /// <param name="two">Second whole number</param>
        /// <param name="three">Third whole number</param>
        /// <param name="four">Fourth whole number</param>
        /// <returns>Sum of all values</returns>
        public static int AddNumbers(int one, int two, int three, int four)
        {
            return one + two + three + four;
        }

        /// <summary>
        /// Adds all values in an integer array and returns the sum.
        /// </summary>
        /// <param name="numbersArray">Array of integers</param>
        /// <returns>Sum of all values in the array</returns>
        public static int AddNumbers(int[] numbersArray)
        {
            int sum = 0;

            for (int i = 0; i < numbersArray.Length; i++)
            {
                sum += numbersArray[i];
            }

            return sum;
        }

        /// <summary>
        /// Prints all values in an array on separate lines, starting with a dash
        /// </summary>
        /// <param name="array">Integer array</param>
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(" - " + array[i]);
            }
        }

        /// <summary>
        /// Prints all values in an array on separate lines
        /// </summary>
        /// <param name="array">Array of strings</param>
        public static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
