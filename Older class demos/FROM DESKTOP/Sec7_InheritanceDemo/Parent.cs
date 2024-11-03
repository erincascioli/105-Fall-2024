using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// PARENT class is being inherited from in the CHILD class

namespace Sec7_InheritanceDemo
{
    // A parent class shares ALL of its code with a child class
    // All class members (fields, properties, constructors, methods)
    //   are "passed down" to the child class. 
    // Anything private is inaccessible to a child class
    // Anything public or protected is accessible to a child class. 

    // Parent classes cannot see any code in a child class; that is, 
    //   a parent cannot see what specific values are inside of a child
    //   class's number or word fields, and a parent class cannot access
    //   any unique fields/properties/methods in the child class. 


    class Parent
    {
        // Protected means the data is only available to the parent and its children.
        // Outside classes cannot see it. 
        protected int number;
        protected string word;
        
        // All public data/methods are accessible to the child classes, too.
        public string Word
        {
            get { return word; }
        }

        // Child classes have the option of running either of these constructors.
        // They do that by calling base().
        public Parent()
        {
            // Initialize the fields of this class with default data
            number = 0;
            word = "Empty";

            // Here so you can see the order that constructors run!
            //Console.WriteLine("Running parent default constructor");
        }

        public Parent(int number, string word)
        {
            // Initialize the fields of this class with parameterized data
            this.number = number;
            this.word = word;

            // Here so you can see the order that constructors run!
            //Console.WriteLine("Running parent param constructor");
        }


        // This method is available to all child classes
        // Both child classes and this parent class can call whenever desired.
        public virtual void PrintInformation()
        {
            Console.WriteLine("Calling parent method: " + 
                number + " " + word);
        }

        public override string ToString()
        {
            return "This object's word is " + word;
        }
    }
}
