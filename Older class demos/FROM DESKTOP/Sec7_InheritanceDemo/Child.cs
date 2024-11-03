using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec7_InheritanceDemo
{
    class Child : Parent
    {
        // ALL members of the parent class are inherited to this child class
        // Private members are not accessible, BUT they are still part of the child class
        // All protected and public members are accessible in this Child class.

        // Child classes can also have their own unique fields that exist within
        //   the child only, and not in the parent. 
        // This Child class has 2 unique fields: an integer array and also a bool
        //   describing whether this class is particularly useful or not. 
        //   (Hint: it's useful for syntax but not really designed for a purpose)

        // Child fields are still typically private
        private int[] nums;
        private bool isUseful;

        // Child properties are still generally public.
        public bool Useful
        {
            get { return isUseful; }
        }


        // All child class constructors should call a parent class constructor
        //   whether it's the default parent or the parameterized parent.
        // Any information the parent parameterized needs MUST be passed
        //   in to the base() call here in the child class.
        // Therefore, if a parent parameterized constructor required 4 
        //   parameters, this child class constructor is required to 
        //   pass all 4 on to the parent class constructor.
        // The way it gets that information is up to the programmer:
        //   it could be passed into the child which then passes it on to the
        //   parent, or it could be defined inside the child class as a 
        //   literal inside the base() call. 
        public Child(bool isUseful, int number, string word) 
            : base(number, word)
        {
            // Parent is taking care of initializing the word and number
            // We don't need to repeat that code here since it's being
            //   done already behind the scenes. 

            // These are initializing the unique child fields
            // First one is initialized via a param
            this.isUseful = isUseful;

            // Second one is initialized to be the same for all Child class
            //   objects: they all contain an integer array with 0, 1, 2 
            //   as the values in the array. 
            nums = new int[3];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
            }

            // This statement is here to see the order that constructors
            //   are being called. 
            //Console.WriteLine("Running child param constructor");
        }


        // Child classes can have unique methods, too. 
        // The parent class doesn't have access to this method because it's in
        //   a child class.  But the child class can call this method
        //   whenever desired.  
        public override void PrintInformation()
        {
            // Calling parent version to use here in the child
            base.PrintInformation();

            // This is here to see which methods are being called
            Console.WriteLine("Calling child method:");

            // Loop through the nums array to see all the values
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }

        public void UniqueMethod()
        {
            Console.WriteLine("This is a unique method that only exists" +
                " within the child class.");
        }

    }
}
