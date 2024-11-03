using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Demo: Text File IO using the Split method
// A demo that reads data from one file (people.txt)
//   and splits that data based on "delimiters"
//   and creates a Person object based on the data
// Person data is then printed to the console window.  
//
// The text file can be found here:
// Project folder > bin > Debug

namespace Sec3_TextFileIO_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------- Data/Variable setup ------------------
            // List to hold Person objects
            // We don't know how many people are in the file yet
            //   and we don't know their data yet, so we'll just initialize
            //   the list for now. Won't add any Person instances. 
            // Will create Person objects as we read data from the file.
            List<Person> people = new List<Person>();

            // Stream for file reading
            // Declared as null so it can be initialized in try blocks later
            StreamReader reader = null;

            // Saving the filename as a string
            string filenameReading = "people.txt";
            // --------------------------------------------------------


            // --------------------- File Reading ---------------------
            // Reading data from people.txt

            try
            {
                // Initialize stream reader
                reader = new StreamReader(filenameReading);

                // String ready to grab the next line of text from the file.
                string lineOfText = null;

                // This loop continuously reads data from a text file
                //   and will stop when there is no more data to read.
                // Ultimately, this loop will execute for 5 iterations
                //   because there are 5 lines of data in the file
                // But you won't always know how many iterations are needed
                //   so a while loop works way better than a for loop here.
                while ((lineOfText = reader.ReadLine()) != null)
                {
                    // Print out for confirmation of reading
                    // JUST FOR A TEST SO WE KNOW IT WORKS
                    Console.WriteLine("Line read from the file: " + lineOfText);

                    // If I want the data to be separated by the "pipes", 
                    //   I can split it and use that data to create a Person object.
                    // data[0] is a person's name
                    // data[1] is their hometown
                    string[] data = lineOfText.Split('|');

                    // Print out for confirmation of reading
                    // JUST FOR A TEST SO WE KNOW IT WORKS
                    Console.WriteLine("Split Name: " + data[0]);
                    Console.WriteLine("Split Hometown: " + data[1]);

                    // Now create a Person object with that data
                    //   and add it to the list of people!
                    Person newPerson = new Person(data[0], data[1]);
                    people.Add(newPerson);
                }
            }
            catch(Exception e)
            {
                // Print error message to console
                Console.WriteLine("File error when reading " + e.Message);
            }
            finally
            {
                // Close the stream as long as it was initialized
                if (reader != null)
                {
                    reader.Close();
                }
            }
            // --------------------------------------------------------


            // Line break for spacing in the console window
            Console.WriteLine();


            // ----------------Print People list---------------------
            // Check out the people list to verify that this all worked!
            foreach (Person p in people)
            {
                p.Print();
            }
            // --------------------------------------------------------

        }
    }
}
