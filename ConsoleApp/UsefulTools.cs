using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    static class UsefulTools  //static class does not allow to create objects from the class
    {

        //static methods are methods that belongs to the class, no need to create an object for a class in order to access it

        public static void SayHi(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

    }
}
