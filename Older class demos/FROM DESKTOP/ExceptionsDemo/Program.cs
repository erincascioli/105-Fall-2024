using System;
using System.IO;

namespace ExceptionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // File reading should ALWAYS be done in a try block.
            // Catch allows alternate code to run. 
            try
            {
                StreamReader reader = new StreamReader("fileThatDoesntExist.txt");
                string lineOfText = reader.ReadLine();
                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("There was an error. The error message is: ");
                Console.WriteLine(ex.Message);
            }
            


            /*
            // This is not a great use of a try block.
            // Why?
            // Because we could prevent an out-of-range index with conditionals.
            try
            {
                int[] numbers = new int[2];
                numbers[0] = 10;
                numbers[1] = 20;
                numbers[2] = 30;
            }
            catch(Exception ex)
            {
                Console.WriteLine("There was an error. The error message is: ");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nALL GOOD!");
            */
            int divisionsThatOccurred = 0;
            for (int i = 0; i < 10000; i++)
            {
                int divisor = 0;

                if (divisor != 0)
                {
                    Console.WriteLine(5 / divisor);
                    divisionsThatOccurred++;
                }
            }            

            Console.WriteLine(
                "1 - How many times did the program attempt to divide? {0}",
                divisionsThatOccurred);



            int numberOfExceptionsThrown = 0;
            for (int i = 0; i < 10000; i++)
            {
                try
                {
                    int divisor = 0;
                    Console.WriteLine(5 / divisor);
                }
                catch (Exception ex)
                {
                    numberOfExceptionsThrown++;
                }
            }

            Console.WriteLine(
                "2 - This code threw and caught {0} exceptions", 
                numberOfExceptionsThrown);






        }
    }
}
