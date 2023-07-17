
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Bike
    {
        public int Year { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }


        public Bike(int _year, string _color, string _type)
        {
            Year = _year;
            Color = _color;
            Type = _type;
        }

        public void Pedal()
        {
            Console.WriteLine("Moved the bike a bit");
        }
    }
}
