namespace StaticMethodsDemo_Sec3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Output:
            // Enter a value:
            // Enter another value:
            // The sum is: 

            int number1;
            int number2;

            Console.Write("Enter a number: ");
            number1 = int.Parse(Console.ReadLine()!);
            Console.Write("Enter a number: ");
            number2 = int.Parse(Console.ReadLine()!);

            // Calling a method that has a void return type
            Sum(number1, number2);

            // Calling a method that has a return value
            // Capture the value in a variable, and use that variable somehow! 
            int sum = SumReturn(number1, number2);
            Console.WriteLine("The sum is " + sum);

        }// End Main


        // Add 2 values and print the sum to the console window
        public static void Sum(int number1, int number2)
        {
            int sumOfNumbers = number1 + number2;
            Console.WriteLine($"The sum of {number1} and {number2} is {sumOfNumbers}");
        }

        public static int SumReturn(int number1, int number2)
        {
            int sumOfNumbers = number1 + number2;
            return sumOfNumbers;
        }


    }// End Program
}
