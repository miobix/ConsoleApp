using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Book
    {
        //blueprint for a data type within a program
        //to create class, right click on App -> new -> Class

        //class attributes
        public string title;
        public string author;
        public int pages;

        //constructor  -- special method called when creating an object for the class
        public Book(string aTitle, string aAuthor, int aPages)
        {
            Console.WriteLine("Creating Book...");
            title = aTitle;
            author = aAuthor;
                pages = aPages;
            Console.WriteLine("Book Created: " + title + " - " + author + " - " + pages);

        }

    }
}
