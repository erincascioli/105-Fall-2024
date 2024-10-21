
// Erin Cascioli
// 10/7/24
// Demo: Enumerations

namespace Enumerations_Demo
{
    // ------------------------------------------------------------------------
    // Enumerations
    // ------------------------------------------------------------------------
    // ** Enums are typically defined outside of a class, inside the namespace.
    // ** Typically public so all classes can use them.
    // ** Act like a set of constant integer variables, with readable values
    //    in words but integral values (for speed of comparison).
    // ** Members are separated by commas and start with capital letters.
    // ------------------------------------------------------------------------
    public enum PlayerClass
    {
        Warrior,
        Mage,
        Archer,
        Rogue
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            // ------------------------------------------------------------------------
            // Enumerations and Variables
            // ------------------------------------------------------------------------
            // ** Once declared, any enum is now a valid data type.
            // ** Variables of those declared enums can be declared and initialized.

            // These 2 variables contain members of the PlayerClass enumeration.
            PlayerClass bestClass = PlayerClass.Rogue;
            PlayerClass dangerousClass = PlayerClass.Mage;


            // ** Members that are NOT included in the enumeration cannot be used.
            // This won't work because Warlock is not a member of PlayerClass.
            //PlayerClass doesntExist = PlayerClass.Warlock;


            // ------------------------------------------------------------------------
            // Printing Enumerations 
            // ------------------------------------------------------------------------
            // ** Enumerations always print exactly as the member identifiers are.
            // ** This means usually they'll print with capital letters, if the programmer
            //    follows standard conventions.
            // ** Need it to appear differently? Use ToUpper() or ToLower() methods when
            //    necessary, or make your own formatting using a combination of 
            //    concatenated characters.

            Console.WriteLine($"The best class is {bestClass}.");
            Console.WriteLine($"The dangerous class is {dangerousClass}.");


            // ------------------------------------------------------------------------
            // String values and enums
            // ------------------------------------------------------------------------
            // ** Strings can be retrieved from any enum member with ToString.
            // ** Once a string has been retrieved, you can do anything you need with it,
            //    including using other string methods on it.
            string bestClassAsString = bestClass.ToString();

            // Change the casing on the string for a funny appearance.
            string newClassName = "";
            for(int i = 0; i < bestClassAsString.Length; i++)
            {
                if(i % 3 == 1)
                {
                    newClassName += bestClassAsString[i].ToString().ToUpper();
                }
                else
                {
                    newClassName += bestClassAsString[i].ToString().ToLower();
                }
            }
            Console.WriteLine($"The best class is now {newClassName}.");


            // ------------------------------------------------------------------------
            // Integer values and enums
            // ------------------------------------------------------------------------
            // ** Variables of enum types can be cast to and from integers.
            // ** This is helpful if there is a relationship between the enum members's 
            //    value and the integer value.
            // ** Or when generating a random enum member.

            Console.WriteLine("\nChoosing a random player class...");

            // ** You don't need to know how Random works yet! ***
            // ** All you need to know is randomIndex will hold a random value of 0, 1, 2 or 3. **
            Random generator = new Random();
            int randomIndex = generator.Next(0, 4);

            // Get a valid enum member from the randomly generated integer
            PlayerClass myRandomClass = (PlayerClass)randomIndex;

            // However - BE CAREFUL when casting from int to an enum. Any integer value can be used!
            // What are numbers 4 through 99?  They are not one of the PlayerClass members!
            randomIndex = generator.Next(4, 100);
            PlayerClass myUnknownClass = (PlayerClass)randomIndex;


            // ------------------------------------------------------------------------
            // Enum comparisons
            // ------------------------------------------------------------------------
            // ** Enums can be compared against the discrete set of members
            // ** This comparison is FAST! Has the speed of integer comparison.

            switch (myRandomClass)
            {
                // Rogue changes the console colors to "stabby" colors.
                case PlayerClass.Rogue:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Aha! Lucky you, you became the best class. :)");
                    Console.WriteLine("You get sneaky, stabby text colors!");
                    break;

                case PlayerClass.Archer:
                    Console.WriteLine("Ahh, the archer.");
                    Console.WriteLine("You smile as you perch high on the hill, bow ready.");
                    break;

                case PlayerClass.Mage:
                    Console.WriteLine("Cunning mage.");
                    Console.WriteLine("You deviously get ready in the shadows for battle.");
                    break;

                case PlayerClass.Warrior:
                    Console.WriteLine("WARRIOR!");
                    Console.WriteLine("Raging, you welcome the enemy to charge at you!");
                    break;
            }


            // ------------------------------------------------------------------------
            // Parsing an enum
            // ------------------------------------------------------------------------
            // ** Enums can be parsed from strings, but the syntax is slightly different
            //    than other parsed values we've seen.

            Console.Write("\nWhich class do you like best? ");
            string userPreferredClass = Console.ReadLine()!;

            // Parse the user's string to an enum member.
            // ** This will crash if the user did not type the enum member exactly as expected,
            //    including spelling AND casing. 
            PlayerClass userPreferredClassEnum = 
                (PlayerClass)Enum.Parse(typeof(PlayerClass), userPreferredClass);

            Console.WriteLine($"You chose {userPreferredClassEnum}.");
        }
    }
}