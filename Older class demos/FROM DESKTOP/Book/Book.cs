using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    internal class Book
    {
        private int numPages;
        private string author;
        private string title;
        private string owner;
        private int timesRead;

        public int NumPages
        {
            get { return numPages; }
        }

        public string Author
        {
            get { return author; }
        }

        public string Title
        {
            get { return title; }
        }

        public string Owner
        {
            get { return owner; }
            set
            {
                if(value.Length > 0 || value != null)
                {
                    owner = value;
                }

                //if (value.Length == 0 || value == null)
                //{

                //}
                //else
                //{
                //    owner = value;
                //}
            }
        }

        public bool IsUsed
        {
            get 
            { 
                if(timesRead > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

                return (timesRead > 0);
            }
        }
    }
}
