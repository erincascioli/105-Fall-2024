using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Second child of an abstract parent class
// Inherits from ParentThing
// Overrides parent's abstract DoSomething() method

namespace Abstract_Sec7
{
    class SecondChildThing : ParentThing
    {
        // Child classes of abstract parents can still have their own fields
        private string myOwnFieldThatNobodyElseHas;

        public string UniqueField
        {
            get { return myOwnFieldThatNobodyElseHas; }
        }

        // Child constructor must call the parent constructor and pass in
        //   any information the parent constructor may need. 
        // Since the parent constructor needs a number, this child
        //   constructor will receive the number as a param and then 
        //   pass it along to the parent. 
        public SecondChildThing(string word, int number) : base(number)
        {
            // Assign the field thats unique to this child class
            myOwnFieldThatNobodyElseHas = word;

            // No need to assign number, since ParentThing assigns
            //   the value of number to the field number.
            // See the ParentThing constructor. 
        }


        // Overriding abstract method from parent class
        // Parent method is abstract so this child MUST override it
        public override void DoSomething()
        {
            // This child wants to multiply the number by a factor of 20
            //   and then add 2 to it.
            // This is different than the other child.  
            Console.WriteLine("Number * 20 + 2 is " + (number * 20) + 2);

            // When you override an abstract method, Visual Studio
            //   will automatically enter this exception.  
            // This is a reminder for YOU to write code inside this method!
            // This code is NOT needed!  
            // Delete this line and write whatever code is needed in this method.  
            throw new NotImplementedException();
        }
    }
}
