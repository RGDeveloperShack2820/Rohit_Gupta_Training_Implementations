using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Prototype_Pattern
{
    internal class BookShop : Prototype
    {
        private String name;
        private int noOfBooks;
        private String location;

        public BookShop(String name, int noOfBooks, String location)
        {
            this.name = name;
            this.noOfBooks = noOfBooks;
            this.location = location;
        }

        public Prototype getClone()
        {
            return new BookShop(name,noOfBooks,location);
        }

        public void show()
        {
            Console.WriteLine($"BookShop Name: {name} , No. of Books: {noOfBooks} , Location: {location}");
        }
    }
}
