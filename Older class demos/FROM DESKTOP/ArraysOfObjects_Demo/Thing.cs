using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysOfObjects_Demo
{
    class Thing
    {
        // Fields
        private int number;
        private string word;
       

        // Property
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public bool Done
        {
            get { return word == "done"; }
        }



        // Constructor
        public Thing(int number, string word)
        {
            this.number = number;
            this.word = word;
        }

        public void Print()
        {
            Console.WriteLine(this.number);
        }
    }
}
