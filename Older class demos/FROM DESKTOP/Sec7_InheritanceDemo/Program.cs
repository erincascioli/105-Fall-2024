using System;

// Demo: Polymorphism
// 11/19/2021

namespace Sec7_InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Polymorphism Demo Here:
            // ----------------------------------------------------------------
            // BTW: Variable declaration looks nice when it's at the top of your program. 
            //
            // GOOD TO ONLY EVER HAVE ONE RANDOM IN THE ENTIRE PROJECT!  
            // Pass it in to class constructors anytime that those classes
            //   need a Random object.  
            // A new Random object isn't being made in the heap...
            //   a reference (pointer/arrow) to that Random object is being passed
            //   to the class that needs to generate Random numbers, and they can
            //   use the Random generator as many times as they need! 
            //
            // NOTE: don't actually give your random ibject this identifier.

            Random thisIsTheOnlyRandomThatThisNamespaceShouldHaveNoMoreThanThis = 
                new Random();
            ThingCollection tc = 
                new ThingCollection(thisIsTheOnlyRandomThatThisNamespaceShouldHaveNoMoreThanThis);

            // Use a method from the ThingCollection class to return a random
            //   parent or child to this Main method. 
            // A new Parent or new Child isn't being made in memory.  The method simply
            //   returns a reference (pointer/arrow) to the current Parent or Child
            //   in the heap.  Once Main receives this reference, then it can access
            //   any method/property in the class.  
            Parent thingFromTheArray = tc.ReturnRandomObjectFromArray();
            Console.WriteLine(thingFromTheArray.ToString());

            // Since the one Random is here inside of the Main method, I can use
            //   that Random object here anytime a random value is necessary. 
            // Again, please don't use this looooooong identifier for the Random object. 
            Console.WriteLine("A random value is " + 
                thisIsTheOnlyRandomThatThisNamespaceShouldHaveNoMoreThanThis.Next());


            // ----------------------------------------------------------------
            // Overriding Methods Demo Here:
            // ----------------------------------------------------------------

            /*
            p1.PrintInformation();
            p2.PrintInformation();
            Console.WriteLine("--------------------------------------");

            // Create a Child instance
            // This Child uses the "true" boolean inside its class,
            //   but sends 245989 and "wegjhbsk" to the parent
            //   constructor, and the parent constructor initializes
            //   the word and number fields with that data. 
            Child c = new Child(true, 245989, "wegjhbsk");
            Console.WriteLine("--------------------------------------");

            // Child objects can call methods/properties from the parent class
            //   and also methods/properties from the child class.
            c.PrintInformation();               // CHILD method
            //Console.WriteLine("My word is: " + c.Word);
            //Console.WriteLine("My unique field is: " + c.Useful);
            Console.WriteLine("--------------------------------------");
            */
        }
    }
}
