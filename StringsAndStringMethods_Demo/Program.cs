
// Erin Cascioli
// 9/11/24
// Demo: Strings and String methods


namespace StringsAndStringMethods_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // String length and indices
            // ----------------------------------------------------------------

            // Output formatting:
            Console.WriteLine("------- String Length and Indices Output -------");

            // Declare and initialize 2 string variables:
            // 1. Your favorite food
            // 2. Your favorite holiday
            string favoriteFood = "banana bread";
            String favoriteHoliday = "Halloween";

            // ** Length Property **
            // Length property returns the number of characters in a string
            Console.WriteLine(
                favoriteFood + 
                " has " + 
                favoriteFood.Length + 
                " characters in the string.");

            // ** Indices **
            // String indices *always* start at 0.
            Console.WriteLine(
                "The first letter is " + 
                favoriteFood[0]);

            // The last index of a string is *always* the length - 1.
            int lastIndex = favoriteFood.Length - 1;
            Console.WriteLine(
                "The last letter is " + 
                favoriteFood[lastIndex]);

            // Integers are the only allowable data type for string indices.
            // Do you somehow have a double for the index? Cast it to an integer!
            double someRandomValue = 3.6;
            int integerRandomValue = (int)someRandomValue;
            Console.WriteLine(
                "The letter at index " +
                integerRandomValue + 
                " is " + 
                favoriteFood[integerRandomValue]);


            // ----------------------------------------------------------------
            // String Methods
            // ----------------------------------------------------------------

            // Output formatting:
            Console.WriteLine("\n------- String Immutability with Methods -------");

            // ** Immutability **
            // String methods return a COPY of the string in the desired modified form.
            // They NEVER change the string variable. 

            string characterName = "Sir Poopsalot";
            Console.WriteLine(characterName);

            // ** ToUpper method **
            // Always returns a NEW string in uppercase.

            // Only need to see the uppercased version of a string ONCE in the output window?
            // It's perfectly acceptable to call the ToUpper method right in a C.WL statement.
            // To Upper:
            Console.WriteLine(
                "That name in all caps is " + 
                characterName.ToUpper());

            // Do you need it MULTIPLE times in the same program though?
            // Call the ToUpper method once, and save the returned string in a variable!
            // The reference that variable as many times as needed!
            string characterUpper = characterName.ToUpper();
            Console.WriteLine(characterUpper);
            Console.WriteLine(
                "This time, I saved the returned uppercase string in a variable! " + 
                characterUpper);
            Console.WriteLine(
                "Hey I need it again! I'll grab the value from the variable: " +
                characterUpper);
            Console.WriteLine(
                "Need it a 3rd time? Don't call the method 3 times, use the variable!:)  " +
                characterUpper);

            // ** Substring **
            // Substring returns a NEW string with just a portion of the string

            // Get the first half of the character's name using the substring overload
            //   that requires 2 arguments:
            //   1) Index to start at
            //   2) Number of characters
            string firstHalfOfName = characterName.Substring(0, characterName.Length/2);

            // Get the last half of the character's name using the substring overload
            //   that requires 1 argument:
            //   1) Index to start at (returns the rest of the string!)
            string secondHalfOfName = characterName.Substring(characterName.Length/2);

            Console.WriteLine("The beginning is: " + firstHalfOfName);
            Console.WriteLine("The end is: " + secondHalfOfName);


            // ** Replace **
            // Replace returns a NEW string with characters replace by other characters
            string funnyName = characterName.Replace('t', '+');
            funnyName = funnyName.Replace('S', '$');
            funnyName = funnyName.Replace("o", "eww");
            Console.WriteLine("The funny name is " + funnyName);

            // For Experienced programmers:
            // Java Programmers might be used to chaining their methods.
            // Try to limit this to 2 or 3 max.  Too much chaining hinders code readability!
            //string funnyName = characterName.Replace('t', '+').Replace('S', '$').Replace("o", "eww");
            //Console.WriteLine("The funny name is " + funnyName);


            // ----------------------------------------------------------------
            // Character Casing with ToString and/or Math
            // ----------------------------------------------------------------

            // Output formatting:
            Console.WriteLine("\n------- Character Casing -------");

            // Characters do not have ToUpper or ToLower methods...
            // So how do you get the uppercase version of a character?
            // There are a few ways to do it!
            // 1. Convert the character to a string, then call ToUpper on it.
            // 2. Do some ASCII math to find the uppercase equivalent of the character

            // Start with a string that doesn't have an uppercase letter
            string name = "erin";
            Console.WriteLine("My name before fixing is: " + name);

            // 1. Convert the character to a string using the ToString() method:
            char firstLetter = name[0];                                                 // Retrieve first letter
            string firstLetterAsString = firstLetter.ToString();                        // Convert to a string
            string firstLetterUppercase = firstLetterAsString.ToUpper();                // Modify its case
            name = firstLetterUppercase + name.Substring(1);                            // Concatenate with rest of string
            Console.WriteLine("My name with the first letter fixed is: " + name);

            // Reset the string back to all lowercase
            name = "erin";
            Console.WriteLine("My name before fixing is: " + name);

            // 2. Do some ASCII math with casting:
            // Find the character 32 characters before this;
            // See https://simple.m.wikipedia.org/wiki/File:ASCII-Table-wide.svg for ASCII codes.
            // (Hint: Uppercase letters start at 65, and lowercase letters start at 97 - 
            //   a difference of 32!)
            int asciiCodeOfFirstLetter = (int)name[0];                                  // ASCII code of 'e' is 101
            int uppercaseAsciiCode = asciiCodeOfFirstLetter - 32;                       // Find value 32 before this one
            char firstLetterUppercaseChar = (char)uppercaseAsciiCode;                   // Cast to a character
            name = firstLetterUppercaseChar + name.Substring(1);                        // Concatenate with rest of string
            Console.WriteLine("My name with the first letter fixed is: " + name);

            // Have an uppercase letter and need to find the lowercase equivalent?
            asciiCodeOfFirstLetter = (int)name[0];                                      // ASCII code of 'E' is 69
            int lowercaseAsciiCode = asciiCodeOfFirstLetter + 32;                       // Find value 32 after this one
            char firstLetterLowercaseChar = (char)lowercaseAsciiCode;                   // Cast to a character
            name = firstLetterLowercaseChar + name.Substring(1);                        // Concatenate with rest of string
            Console.WriteLine("My name with the first letter back to lower is: " + name);
        }
    }
}
