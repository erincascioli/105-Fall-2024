using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Abstract parent class ParentThing
// Abstract because we'll never need an instance of it, 
//   but need the ability to share its code with any child classes
//   that inherit from this parent class.  
// Abstract classes cannot be instantiated
// They can contain abstract and non-abstract methods
// Polymorphism works just fine, even with an abstract parent class!

namespace Abstract_Sec7
{
    abstract class ParentThing
    {
        // For now, let's put in a field for a number.
        // This number doesn't really "stand" for anything - 
        //   it's just an example of using a field in a parent class.
        // Remember: inheritance encourages the use of "protected" modifier
        protected int number;


        /// Pass in the number so this ParentThing can set the value of the field
        public ParentThing(int number)
        {
            this.number = number;
        }


        // Abstract classes can contain both abstract and non-abstract methods
        // Abstract methods MUST be overridden by all child classes
        public abstract void DoSomething();


        // This regular method is shared with all child classes
        public void Print()
        {
            Console.WriteLine("This regular method is shared with all child classes" + 
                "and doesn't need to be overridden");
        }
    }
}
