
// Erin Cascioli
// 9/27/24
// Demo: Switches and String Formatting

namespace Switch_StringFormatting_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // String Formatting
            // ----------------------------------------------------------------
            double gasPrice = 3333.399;
            string gasPriceFormatted = gasPrice.ToString("C2");
            Console.WriteLine(gasPriceFormatted);

            double percent = .995;
            string percentFormatted = percent.ToString("P1");
            Console.WriteLine(percentFormatted);

            string formattedSentence = 
                String.Format("The price of gas nowadays is {0:C2} and the tax is {1:C2}", 
                gasPrice,                   // 0
                gasPrice * 0.08);           // 1
            Console.WriteLine(formattedSentence);


            // ----------------------------------------------------------------
            // Switch Statement
            // ----------------------------------------------------------------
            int number = 10;

            switch(number)
            {
                case 5:
                    Console.WriteLine("Your number is 5!");
                    break;
                case 10:
                    Console.WriteLine("Your number is 10!");
                    break;
                default:
                    Console.WriteLine("Your number is something else!");
                    break;
            }

        }
    }
}
