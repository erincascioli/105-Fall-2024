using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShape
{
    // Shape Class
    // Parent class of Circle and Rectangle
    //
    // Why do I exist?
    //  - To share code with my children
    //  - Gives a common datatype to all child classes
    //
    // Am I useful on my own? 
    // Will I ever need an instance of a Shape?
    // Or might I only every need Circles and Rectangles?

    abstract class Shape
    {
        // Fields (shared with children)
        protected ConsoleColor color;
        protected double area;

        // Property (shared with children)
        public double Area
        {
            get { return area; }
        }

        // Constructor
        public Shape(ConsoleColor color)
        {
            this.color = color;
            this.area = 0;
        }

        // What does a Shape do - what are its behaviors?
        // Nothing!

        public void AllChildrenDoThis()
        {

        }

        public virtual void AllChildrenCanOverride()
        {

        }

        public abstract double CalculateArea();
        //{
        //    // I have no idea what the area of a shape is so I have
        //    //   this awesome placeholder to return a value
        //    //   because the method requires returning a value.
        //    // No, this is not an error.
        //    return 0;
        //}

        public abstract void Draw();
        //{
        //    // I don't know what to do here so 
        //    //   I'm leaving it blank.
        //    // Not a mistake.
        //    // Yes, I look like a silly person.
        //    // Deal with it.
        //}
    }
}





        
//        // Print method can be overridden by children
//        public virtual void Print()
//        {
//            Console.ForegroundColor = color;
//            Console.WriteLine("I am a shape. My area is " + area);
//            Console.ForegroundColor = ConsoleColor.White;
//        }

//        // CalculateArea method should be overridden by children, too. 
//        public virtual double CalculateArea()
//        {
//            // What is the area of a "shape"?  I don't know!
//            // What should I return if I don't know how to calculate my area?  
//            return 0;
//        }        
//    }
//}
