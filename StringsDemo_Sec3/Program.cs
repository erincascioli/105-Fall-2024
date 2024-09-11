
// Erin Cascioli
// 9/11/24
// Demo: Strings and String methods


namespace StringsDemo_Sec3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // String length and indices
            // ----------------------------------------------------------------

            // Declare and initialize 2 string variables:
            // 1. Your favorite food
            // 2. Your favorite holiday
            string favoriteFood = "banana bread";
            String favoriteHoliday = "Halloween";

            Console.WriteLine(favoriteFood);
            Console.WriteLine(favoriteFood.Length);

            int lastIndex = favoriteFood.Length - 1;
            Console.WriteLine(favoriteFood[lastIndex]);

            double randomValue = 3.6;
            Console.WriteLine(favoriteFood[(int)randomValue]);

            //char firstLetter = favoriteHoliday[0];
            //string firstLetterAsString = firstLetter.ToString();
            //string firstLetterAsStringUpper = firstLetterAsString.ToUpper();

            string firstLetter = favoriteHoliday[0].ToString();
            string firstLetterAsString = firstLetter + "";
            string firstLetterAsStringUpper = firstLetterAsString.ToUpper();

            int upperLetter = (int)favoriteFood[0] - 26;
            Console.WriteLine((char)upperLetter);

            Console.WriteLine(favoriteFood);

            // Concat of UpperFirstLetter + Rest of String



            // Immutability
            string word = "apple";
            string appleWord = word;

            word = "banana";
            string bananaWord = word;

            word = "chocolate";

            short letter = (short)'a';
            int letterInt = (int)'a';
            byte letterByte = (byte)'a';
            double letterDouble = (double)'a';
            Console.WriteLine(letterDouble);



            /*
            // ----------------------------------------------------------------
            // String Methods
            // ----------------------------------------------------------------

            // Immutability:
            // String methods return a COPY of the string in the desired modified form.
            // They NEVER change the string variable. 

            string characterName = "Sir Poopsalot";
            Console.WriteLine(characterName);

            // To Upper:
            Console.WriteLine(characterName.ToUpper());

            // Save the uppercase version in a new variable
            string characterUpper = characterName.ToUpper();
            Console.WriteLine(characterUpper);



            // To Lower:


            // Substring:


            //
            */

        }
    }
}
