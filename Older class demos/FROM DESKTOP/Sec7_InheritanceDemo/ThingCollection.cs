using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec7_InheritanceDemo
{
    class ThingCollection
    {
        // FIELDS
        private Parent[] objectsFromBothClasses;
        private Random rng;


        // CONSTRUCTOR
        // The constructor receives a Random reference from Main.  
        // The Random object was created in Main and lives in the heap.
        // By passing Random to this class, this class receives a reference
        //   (pointer/arrow) to that Random object in the heap. 
        // It can call Next() as many times as you need within the class
        //   that receives the Random object reference. 
        public ThingCollection(Random rngReferenceFromMainThatMainPassedIn)
        {
            // Instantiate the Random object from the parameter
            // NOTE: Please use a smaller identifier for the parameter.
            this.rng = rngReferenceFromMainThatMainPassedIn;

            // Generate some objects of the type Parent and Child
            Parent p1 = new Parent();
            Parent p2 = new Parent(28, "hi");
            Child c1 = new Child(true, 245989, "wegjhbsk");
            Child c2 = new Child(false, 734, "hkgjhfgdf");

            // Place those objects in an array of the Parent type.
            // An array/list of a parent type can hold both objects of the Parent
            //   AND object of the Child!
            // Something to be aware of:
            //    At run-time all of these objects are seen as Parent type and
            //    not Child type.
            objectsFromBothClasses = new Parent[4];
            objectsFromBothClasses[0] = p1;
            objectsFromBothClasses[1] = p2;
            objectsFromBothClasses[2] = c1;
            objectsFromBothClasses[3] = c2;
        }

        // METHODS:

        // Call any appropriate methods of the objects in the array:
        // Uses the IS keyword to determine whether an object is of
        //   a parent or a child type. 
        public void CallMethods()
        {
            // Call the PrintInformation method on each of the 
            //   objects in the array
            foreach (Parent thing in objectsFromBothClasses)
            {
                // This method will run the correct version for both
                //   Parent and Child objects.
                thing.PrintInformation();

                // However, unique methods/properties are not accessible
                //   of the child types because they are stored in a Parent
                //   type array/list. 
                // To gain access to anything specific, downcasting must be utilized.
                
                // Downcasting must occur when an object seen as a parent at run-time
                //   needs to be temporarily "seen" as a child type at run-time.
                // This most often occurs when a child object needs to run a unique
                //   property or method, but the child object is part of a parent
                //   data collection (list or array).

                // You could downcast on one line:
                if (thing is Child)
                {
                    ((Child)thing).UniqueMethod();
                    Console.WriteLine(((Child)thing).Useful);
                }

                //OR you can downcast by saving the object in a variable
                //   and then use that variable as many times as needed. 
                //if (thing is Child)
                //{
                //    Child childType = (Child)thing;
                //    childType.UniqueMethod();
                //}
            }
        }


        // Methods can return objects!
        // This method returnd a random object from the array of Parent/Child
        //   objects. 
        public Parent ReturnRandomObjectFromArray()
        {
            // Return a Random object from the array by:
            // 1) Generating a random index
            // 2) Retrieving the object from the array at that random index, and
            // 3) Return the retrieved object.

            int randomIndex = rng.Next(0, 4); 
            Parent randomObjectFromTheArray = objectsFromBothClasses[randomIndex];
            return randomObjectFromTheArray;
        }
    }
}
