using System;

namespace ArraysOfObjects_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            // Declare/init array of 100 empty Thing objects
            Thing[] stuff = new Thing[100];

            //Thing t0 = new Thing(0, "a");
            //Thing t1 = new Thing(1, "a");
            //Thing t2 = new Thing(2, "a");
            //Thing t3 = new Thing(3, "a");

            //stuff[0] = t0;
            //stuff[1] = t1;
            //stuff[2] = t2;
            //stuff[3] = t3;




            // Create an array of 100 Thing objects with random numbers
            for (int i = 0; i < 100; i++)
            {
                stuff[i] = new Thing(rng.Next(1, 21), "something");
            }

            // Iterate through all 100 Thing objects and call their Print method
            for (int i = 0; i < 100; i++)
            {
                stuff[i].Print();
            }

            Console.WriteLine(  );
        }
    }
}
