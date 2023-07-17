using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The chef made Chiken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The chef made Salad");
        }

        public virtual void MakeSpecial()  // virtual allows the subclasses to override this method
        {
            Console.WriteLine("The chef made their secret recipe");
        }


    }
}
