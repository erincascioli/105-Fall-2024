using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec3_TextFileIO_Demo
{
    class Person
    {
        private string name;
        private string hometown;

        public string Name
        {
            get { return name; }
        }

        public string Hometown
        {
            get { return hometown; }
        }

        public Person()
        {
            name = "name";
            hometown = "place";
        }

        public Person(string name, string hometown)
        {
            this.name = name;
            this.hometown = hometown;
        }

        public void Print()
        {
            Console.WriteLine("Personal data");
            Console.WriteLine("  Name: " + name);
            Console.WriteLine("  Hometown: " + hometown);
        }
    }
}
