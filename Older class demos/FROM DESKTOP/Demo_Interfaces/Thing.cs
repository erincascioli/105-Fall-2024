using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interfaces
{
    internal class Thing : IInterfaceable
    {
        private string word;
        private int someNumber;
        private bool isNiceOutside;


        public string Something
        {
            get { return "something"; }
            set { word = value; }
        }

        public Thing()
        {
            word = null;
        }

        public Thing(bool isNiceOut)
        {
            this.isNiceOutside = isNiceOut;
        }

        public void Print()
        {
            Console.WriteLine("Hi");
        }

        public int Adds(int n, int m)
        {
            return n + m;
        }
    }
}
