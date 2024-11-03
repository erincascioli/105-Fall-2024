using System;
using System.Collections.Generic;

namespace ListDemo_PrimitiveData
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------------------- Lists ------------------------------------
            // You don't need to set a size of a list like you do with an array!  
            // The list will dynamically resize itself when you add new data.
            // The List class's constructor is a generic method, which means you need to put
            //   the kind of datatype you want the List to hold inside of angle brackets
            //   because Lists can hold any datatype!  
            // However, a single List can only hold the same kind of data (like an array) - 
            //   arrays are designed to hold any datatypes, but each array can only hold a 
            //   single type of data.  
            // ----------------------------------------------------------------------------

            // ***** Declaration of a list *****
            // Declare and initialize a List of strings
            List<string> gameTitles = new List<string>();


            // ***** Common List Properties *****
            // Count property --> Number of things in list.  (Similar to .Length of an array)
            // Capacity property --> How much space is in the underlying array
            // Before adding any data to the list, the count is 0 and the List can
            //   hold 0 objects.  
            Console.WriteLine("Count before Add: " + gameTitles.Count);
            Console.WriteLine("Capacity before Add:" + gameTitles.Capacity);


            // ***** Adding data to a list *****
            // Use Add method to enter data into a List.
            // Add() always add to the END of the list!
            gameTitles.Add("Cooking Mama");                         // Index 0

            // Once we add the first game title to the list, 
            //   the count is 1 and the List can hold 4
            //   elements now. 
            Console.WriteLine("Count after adding 1 thing: " + gameTitles.Count);
            Console.WriteLine("Capacity after adding 1 thing: " + gameTitles.Capacity);

            // Add more data to the list with the Add method
            gameTitles.Add("Outer Worlds");                         // Index 1
            gameTitles.Add("Catan");                                // Index 2
            gameTitles.Add("Skyrim");                               // Index 3
            gameTitles.Add("All the Pokemon games everrrrrr");      // Index 4
            gameTitles.Add("Wizards 101");                          // Index 5
            gameTitles.Add("Roblox");                               // Index 6
            gameTitles.Add("Shrek Superslam");                      // Index 7
            gameTitles.Add("Roblox");                               // Index 8
            gameTitles.Add("Sega Bass Fishing");                    // Index 9
            gameTitles.Add("Roblox");                               // Index 10

            // After adding all of that data, the count is 11 
            //   and the list has space for 16 data
            Console.WriteLine("Count after adding all data: " + gameTitles.Count);
            Console.WriteLine("Capacity after adding all data: " + gameTitles.Capacity);
            Console.WriteLine();


            // ***** Data Access *****
            // You can access specific data using array notation 
            // Print the first and second elements
            Console.WriteLine("First game: " + gameTitles[0]);
            Console.WriteLine("Second game: " + gameTitles[1]);
            // Print the last element
            Console.WriteLine("Last game: " + gameTitles[10]);
            // But if you don't know how many elements are in the List, 
            //   the last index is the List's Count - 1
            Console.WriteLine("Last game: " + gameTitles[gameTitles.Count - 1]);
            Console.WriteLine();


            // ***** List Iteration *****
            // Iterate through each element in the list and print 
            //   all of the elements in that list
            // Remember: Arrays have a Length but Lists have a Count
            Console.WriteLine("All of the games in the list (for loop)-------");
            for (int i = 0; i < gameTitles.Count; i++)
            {
                Console.WriteLine(gameTitles[i]);
            }
            Console.WriteLine();

            // Use a foreach loop to iterate through the list and print all games
            // Foreach loops will iterate through ALL data in a data structure!
            Console.WriteLine("All of the games in the list (foreach loop)-------");
            int counter = 0;
            foreach (string game in gameTitles)
            {
                Console.WriteLine("Index " + counter + ": " + game);
                counter++;
            }
            Console.WriteLine();


            // ***** List Removal *****
            // Removal occurs in one of 2 ways:
            // Remove - searches for the thing you're attempting to remove,
            //   and returns a bool if the list successfully removed it
            // Although Roblox is in the list 3 times, Remove() will only remove
            //   the first one it finds. 
            bool didItRemove = gameTitles.Remove("Roblox");

            // RemoveAt - receives an index and removes whatever is at that index
            // Remove the very first element
            gameTitles.RemoveAt(0);
            // Remove the last element
            gameTitles.RemoveAt(gameTitles.Count - 1);

            // Be careful - Can crash upon invalid indices
            // Be sure you are checking for an invalid index before attempting
            //   to remove data from a List!  
            int indexToRemove = -6;
            if (indexToRemove < 0 || indexToRemove >= gameTitles.Count)
            {
                Console.WriteLine("That index is invalid.");
            }
            else
            {
                gameTitles.RemoveAt(indexToRemove);
            }
            Console.WriteLine();


            // ***** List Iteration *****
            // Let's see what is left in the list.
            Console.WriteLine("Remaining games in the list-------");
            for (int i = 0; i < gameTitles.Count; i++)
            {
                Console.WriteLine(gameTitles[i]);
            }
            Console.WriteLine();


            // ***** Fun Stuff *****
            // Other fun stuff you can do with a list:
            // Remove only the games which have 6 letters
            Console.WriteLine("REMOVING games w/ 6 letters -------");
            for (int i = 0; i < gameTitles.Count; i++)
            {
                // Check the length of this particular title
                if (gameTitles[i].Length == 6)
                {
                    // Great, remove this one!
                    gameTitles.RemoveAt(i);

                    // We know this will shift items around,
                    // So we have to RECHECK the same index
                    i--;
                }
            }


            // ***** List Iteration *****
            // Let's see what is left in the list after the removal of 6 letter games.
            for (int i = 0; i < gameTitles.Count; i++)
            {
                Console.WriteLine(gameTitles[i]);
            }


            // ------------------ Can't you do all of this with an array? -----------------
            // Sure, you absolutely can do all of this with an array!
            // You can:  
            // Declare an array of a certain size
            // Add data to the array
            // Access any element in that array
            // Iterate through the array
            //
            // ... BUT ...
            // IF you run out of room in the array and you want to add more stuff to it...
            // OR you want to remove data from the List without leaving any gaps...
            // You need to write the code to do that.  
            // The List class has that code already built-in to the List class!
            // ----------------------------------------------------------------------------

            // Without using a List, adding data to an array is a lengthy process
            // I think I only need 3 months, so I'll make an array to hold 3 elements
            string[] months = new string[3];
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";

            // OOPS JUST KIDDING. I actually need to add April to the array, too.  
            // What is the process for doing this?
            // 1. Make a new, larger array
            // 2. Copy all data from the original array to the new, larger array
            // 3. Add in the new data you need
            // 4. Set the original array identifier = new, longer array
            string[] newMonths = new string[4];             // New array
            for (int i = 0; i < months.Length; i++)          // Copy data to larger
            {
                newMonths[i] = months[i];
            }
            newMonths[3] = "April";                         // Add data to larger
            months = newMonths;                             // Reset identifier

            // OH NO I FORGOT I NEED MAY TOO! Do it all again!
            newMonths = new string[5];                      // New, larger array
            for (int i = 0; i < months.Length; i++)         // Copy data to larger
            {
                newMonths[i] = months[i];
            }
            newMonths[4] = "May";                           // Add data to larger
            months = newMonths;                             // Reset identifier


            // Keep window open
            Console.ReadLine();
        }
    }
}
