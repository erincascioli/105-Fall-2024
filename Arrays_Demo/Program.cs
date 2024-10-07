
// Erin Cascioli
// 10/4/24
// Demo: Arrays (1-dimensional)

namespace Arrays_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] birthdaysInMonths = new int[12];
            birthdaysInMonths[0] = 1;
            birthdaysInMonths[1] = 0;
            birthdaysInMonths[2] = 3;
            birthdaysInMonths[3] = 1;
            birthdaysInMonths[4] = 5;
            birthdaysInMonths[5] = 2;
            birthdaysInMonths[6] = 4;
            birthdaysInMonths[7] = 1;
            birthdaysInMonths[8] = 3;
            birthdaysInMonths[9] = 1;
            birthdaysInMonths[10] = 5;
            birthdaysInMonths[11] = 2;
            Console.WriteLine(birthdaysInMonths.Length);

            int[] birthdaysInMonthsLiteral = {1, 0, 3, 1, 5, 2, 4, 1, 3, 1, 5, 2};

            string[] characterNames = {"Sleeve McDichael", "Freddy Krueger", "Keith"};

            // Print all values to the Console window
            for (int i = 0; i < characterNames.Length; i++)
            {
                Console.WriteLine(characterNames[i]);
            }



            // Get user-provided values. Declare only!
            string[] userProvidedNames;

            // How many names?
            Console.Write("How many? ");
            int arraySize = int.Parse(Console.ReadLine()!);

            // Initialize array to the correct size
            userProvidedNames = new string[arraySize];

            // Enter the names
            for(int i = 0; i < userProvidedNames.Length; i++)
            {
                Console.Write("Enter name: ");
                userProvidedNames[i] = Console.ReadLine()!;
            }
            
            // At this point, the array contains X names with
            // all data provided by the user.
























            /*
            // ----------------------------------------------------------------
            // Arrays 1-dimensional
            // ----------------------------------------------------------------
            // Arrays hold consecutive data in memory. 
            // They are indexed by an integral value, starting at 1 through one less
            //   than the array's length. 

            // *** Declare an array ***
            // This array is declared only and not initialized because we don't know
            //   how many values the array should contain yet. The user provides that
            //   information.
            string[] userProvidedNames;

            // *** Declare and initialize an array ***
            // When you know all the data, you can initialize the array with data
            //   immediately. 
            int[] birthdaysInMonths = new int[12];
            birthdaysInMonths[0] = 2;       // Jan
            birthdaysInMonths[1] = 2;       // Feb
            birthdaysInMonths[2] = 0;       // Mar
            birthdaysInMonths[3] = 1;       // Apr
            birthdaysInMonths[4] = 1;       // May
            birthdaysInMonths[5] = 2;       // Jun
            birthdaysInMonths[6] = 2;       // Jul
            birthdaysInMonths[7] = 1;       // Aug
            birthdaysInMonths[8] = 1;       // Sep
            birthdaysInMonths[9] = 1;       // Oct
            birthdaysInMonths[10] = 2;      // Nov
            birthdaysInMonths[11] = 3;      // Dec

            // *** "Literal" array ***
            // Great option when you know the data to begin with!
            // Literal arrays eliminate the need to use a separate line for each element
            //   when initializing with data.
            // However, literal arrays cannot be used for user-provided information
            //   or for any type of iteration necessary for initial data providing. 
            int[] birthdaysInMonthsLiteral = { 2, 2, 0, 1, 1, 2, 2, 1, 1, 1, 2, 3 };

            // Literal string array
            string[] characterNames = {"Banana McGillicuddy", "Spooner McForkson", "Jeebus"};

            // *** Change value in array ***
            // Values inside arrays can be changed with the assignment variable. 
            characterNames[1] = "AAAAAAAAAA";

            // *** Getting data from a user ***
            // Prompt a user for a number of names:
            Console.Write("How many names? ");
            int numberOfNames = int.Parse(Console.ReadLine()!);

            // Use that parsed value to initialize the array with a size
            userProvidedNames = new string[numberOfNames];

            // Get all information from the user
            for(int i = 0; i < numberOfNames; i++)
            {
                Console.Write("Enter a name:");
                userProvidedNames[i] = Console.ReadLine()!;
            }

            // *** Printing array data ***
            Console.WriteLine("All character names: ");

            // Using the name of the array will provide you with the TYPE of array
            // This statement will *not* print each element of the array. 
            Console.WriteLine(characterNames);

            // Instead, array data must be iterated through to access each element. 
            for(int i = 0; i < characterNames.Length; i++)
            {
                // Print the data at this element
                Console.WriteLine(" --> " + characterNames[i]);
            }
            */
        }
    }
}
