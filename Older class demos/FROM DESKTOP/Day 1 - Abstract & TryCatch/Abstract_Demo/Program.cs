using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Demo: Abstract classes and methods
// Abstract classes allow parent classes to share all of their code with child classes
//   but with the limitation that instances of the parent class cannot be made.
// Abstract is always used with inheritance... no need for an abstract class
//   if there is no need for inheritance. 

namespace Abstract_Sec7
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------- Abstract limitations --------------------------
            // CANNOT instantiate objects of the Parent type if it's declared abstract
            // CAN instantiate objects of the child type
            // -----------------------------------------------------------------------

            //ParentThing pt = new ParentThing(10);         // ERROR!
            ChildThing ct = new ChildThing(2);              // FINE!
            SecondChildThing sct = 
                new SecondChildThing("cake", 1);            // FINE!


            // ----------------------- Abstract limitations --------------------------
            // Objects of the child type can call abstract methods
            // And they can call their own methods, too
            // -----------------------------------------------------------------------

            ct.DoSomething();                               // Calling abstract method
            ct.DoMyOwnTask();                               // Calling child method
            sct.DoSomething();                              // Calling abstract method


            // --------------------- Abstract and Polymorphism -----------------------
            // Although objects of an abstract parent type cannot be instantiated,
            //   the datatype can still be used with data structures to hold multiple
            //   instances of child type objects!
            // Downcasting still occurs when working with an abstract parent if a child
            //   object contains fields, properties, or methods that the parent class
            //   does not contain. 
            // -----------------------------------------------------------------------

            // Can put objects of the child type in a list/collection of the parent type
            List<ParentThing> childrenTypes = new List<ParentThing>();

            // Add child objects
            childrenTypes.Add(ct);
            childrenTypes.Add(sct);
            childrenTypes.Add(new ChildThing(46));
            childrenTypes.Add(new SecondChildThing("some word", 4));

            // Cannot add parent objects
            //childrenTypes.Add(new ParentThing(927));         // ERROR!

            // Call DoSomething() on every child object - since this abstract method is
            //   part of the parent class, the IDE can "see" it and "knows" it exists
            //   so no downcasting is needed.  
            // Call DoMyOwnTask() only on ChildThing objects - the parent class does NOT
            //   contain the DoMyOwnTask() method, and the IDE doesn't "see" that method
            //   as part of the parent class, so downcasting must occur to call it. 
            // Call the UniqueField property only on SecondChildThing objects - 
            //   the parent class does NOT contain that field, so the IDE doesn't "see" it
            //   as part of the parent class, so downcasting must occur to call it. 
            for (int i = 0; i < childrenTypes.Count; i++)
            {
                // Can be called on every child object in list
                childrenTypes[i].DoSomething();       
                
                // Only call DoMyOwnTask() if the child is of type ChildThing
                if(childrenTypes[i] is ChildThing)
                {
                    ChildThing child = (ChildThing)childrenTypes[i];
                    child.DoMyOwnTask();
                }

                // Only use UniqueField property if the child is of type SecondChildThing
                if (childrenTypes[i] is SecondChildThing)
                {
                    SecondChildThing child = (SecondChildThing)childrenTypes[i];
                    Console.WriteLine(child.UniqueField);
                }
            }


            // Keep window open
            Console.ReadLine();
        }
    }
}
