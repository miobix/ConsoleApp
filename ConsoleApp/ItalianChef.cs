using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ItalianChef : Chef
    {
        //the italian chef can make everythin the regular chef can do - so this class inherits the skills from the regular chef
        //syntax: subclass : superclass

        //the subclass can have their own methods
        public void MakePasta()
        {
            Console.WriteLine("The chef made Pasta");
        }

        public void MakePesto()
        {
            Console.WriteLine("The Chef made pesto");
        }

        //overwriting a method
        public override void MakeSpecial()
        {
            Console.WriteLine("The chef made Pizza");
        }

    }
}
