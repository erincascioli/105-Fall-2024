using System;
using System.Collections.Generic;
using System.IO;

namespace Sec7_Abstract_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                StreamReader reader = new StreamReader("someFile.txt");

                string lineFromFile = reader.ReadLine();

                reader.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("The file did not exist in the specified location.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("File reading went wrong!");
            }
            
        }
    }
}
