



namespace ForLoops_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1 - 10 in WHILE loop
            int counter = 1;
            while (counter <= 10)
            {
                Console.Write(counter + " ");
                counter++;
            }

            Console.WriteLine("\n********************");

            // 1 - 10 in FOR loop
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n********************");

            // 10 - 1 in FOR loop
            for (int i = 10; i >= 1; i--)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n********************");

            // 200 - 300 in multiples of 5 
            for (int i = 200; i <= 300; i += 5)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n********************");

            // 300 to 200 backwards
            for (int a = 300; a >= 200; a -= 5)
            {
                Console.Write(a + " ");
            }

            // Iterate through a string via its indices
            string someWord = "dfighsrgkjDBKJvzfdxbgc";
            //for (int i = 0; i <= someWord.Length - 1; i++)
            for (int i = 0; i <= someWord.Length; i++)
            {
                Console.WriteLine(someWord[i]);
            }
            */


            // BREAK AND CONTINUE
            // 1 2 3
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");

                if (i == 3)
                {
                    break;
                }
            }

            // 1 2 4 5 6 7 8 9 10
            for (int i = 1; i <= 10; i++)
            {
                if (i == 3)
                {
                    continue;
                }

                Console.Write(i + " ");
            }



            // What does this output?

            for(int row = 1; row < 3; row++)
            {
                for(int col = 1; col < 4; col++)
                {
                    Console.WriteLine($"{row}, {col}");
                }
            }







            #region MINIMIZE THIS


            // PSEUDOCODE:
            //
            // Prompt user for a number 1+
            // Parse to integer
            // WHILE number is invalid (0 or less)
            //     Re-prompt for data
            //     Parse to integer
            // WHILE counter is less than user's value
            //     Print counter
            //
            // CODE:

            //int userNumber = 0;
            //bool firstPrompt = true;

            /*
            do
            {
                if(firstPrompt)
                {
                    Console.Write("Enter: ");
                    userNumber = int.Parse(Console.ReadLine()!);
                    firstPrompt = false;
                }
                else
                {
                    Console.Write("Invalid. Enter again: ");
                    userNumber = int.Parse(Console.ReadLine()!);
                }
            }
            while (userNumber < 1);
            */


            /*
            Console.Write("Enter: ");
           
            do
            {
                userNumber = int.Parse(Console.ReadLine()!);

                if(userNumber < 1)
                {
                    Console.Write("Invalid. Enter again: ");
                }
            }
            while (userNumber < 1);
            */



            /*
            int counter = 1;
            while(counter <= userNumber)
            {
                Console.Write(counter + " ");
                counter++;
            }
            */




            /*
            // 1 2 3 4 5
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");

                if(i == 5)
                {
                    break;
                }
            }

            // 1 2 3 4 5 6 7 8 9 10
            for (int i = 1; i <= 10; i++)
            {
                if (i == 3)
                {
                    continue;
                }

                Console.Write(i + " ");
            }
            */



            /*
            for(int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n********************");

            for(int i = 200; i <= 300; i += 5)
            {
                Console.Write(i + " ");
            }


            Console.WriteLine("\n********************");

            for (int a = 300; a >= 200; a -= 5)
            {
                Console.Write(a + " ");
            }

            string someWord = "dfighsrgkjDBKJvzfdxbgc";
            for(int i = 0; i <= someWord.Length - 1; i++)
            {
                Console.WriteLine(someWord[i]);
            }
            */




            // PSEUDOCODE:
            //
            // Prompt user for a number 1+
            // Parse to integer
            // WHILE number is invalid (0 or less)
            //     Re-prompt for data
            //     Parse to integer
            // WHILE counter is less than user's value
            //     Print counter
            //
            //
            // CODE:
            /*
            Console.Write("Enter: ");
            int userNumber = int.Parse(Console.ReadLine()!);

            while(userNumber < 1)
            {
                Console.Write("Invalid. Enter again: ");
                userNumber = int.Parse(Console.ReadLine()!);
            }

            int counter = 1;
            while(counter <= userNumber)
            {
                Console.Write(counter + " ");
                counter++;
            }
            */

            // ------------------------------------------------------------------
            /*
            int userNumber = 9999999;

            do
            {
                if(userNumber < 1)
                {
                    Console.Write("Invalid. Enter again: ");
                    userNumber = int.Parse(Console.ReadLine()!);
                }
                else
                {
                    Console.Write("Enter: ");
                    userNumber = int.Parse(Console.ReadLine()!);
                }
            }
            while (userNumber < 1);

            int counter = 1;
            while (counter <= userNumber)
            {
                Console.Write(counter + " ");
                counter++;
            }
            */

            #endregion
        }
    }
}
