using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Child of an abstract parent class
// Inherits from ParentThing
// Overrides parent's abstract DoSomething() method

namespace Abstract_Sec7
{
    class ChildThing : ParentThing
    {
        // Child constructor must call the parent constructor and pass in
        //   any information the parent constructor may need. 
        // Since the parent constructor needs a number, this child
        //   constructor will receive the number as a param and then 
        //   pass it along to the parent. 
        public ChildThing(int number) : base(number)
        {
            // No need for any code here, since ParentThing assigns
            //   the value of number to the field number.
            // See the ParentThing constructor. 
        }


        // Overriding abstract method from parent class
        // Parent method is abstract so this child MUST override it
        public override void DoSomething()
        {
            // In this method, you can write code to do whatever this child
            //   needs to do in this method.  
            // In this case, maybe we scale the number by a factor of 5. 
            Console.WriteLine("Number scaled by 5 is " + number * 5);

            // When you override an abstract method, Visual Studio
            //   will automatically enter this exception.  
            // This is a reminder for YOU to write code inside this method!
            // This code is NOT needed!  
            // Delete this line and write whatever code is needed in this method.  
            throw new NotImplementedException();
        }

        // Children can write their own methods, too.
        // Child classes are not limited to only use methods from their parents
        public void DoMyOwnTask()
        {
            Console.WriteLine("Method in child class only. This method is not in the parent class.");
        }
    }
}
