namespace DebugDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Divide by Zero Exception
            // Computer not "smart enough" to interpret the value of number as 0
            //   and then warn the programmer that their code will malfunction.
            // Passes all syntax tests, so VS sees it as good! 
            //int number = 0;
            //int result = 10 / number;

            int x = 10;
            x = x * 7;
            x = x/3;
            Console.WriteLine(x);


            /*
            // More runtime and logic errors:
            Console.Write("Enter your name: ");
            string name = Console.ReadLine()!.Trim();
            int howManyFit = 100 / name.Length;
            Console.WriteLine($"{name} has {name.Length} letters and can fit {howManyFit} times in 100 characters.");
            Console.WriteLine(name + " can fit " + howManyFit + ".");
            */
        }
    }
}
