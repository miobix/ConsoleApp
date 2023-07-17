using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //get and set created when attributes are declared
        //
        //prop -tab- -tab- autocompletes for a shorthand attribute
        //propfull -tab- -tab- autocompletes with a longer version

        /*
        {get, set} are automimplemented properties
        just assign a value or retrieve a value

        ex:
          public string Name
        {
        get => _name;
        set => _name = value;
        }

        public decimal Price
        {
        get => _cost;
        set => _cost = value;
        }

                is shortened to 

                  public string Name
            { get; set; }

            public decimal Price
            { get; set; }

                */

        public string Country;
        public string OriginCountry
        {
            get { return Country; }
            set { Country = value; }
        }
        //values can be initialized on the constructor.
        //this pattern is done when the Country property is prvate
        //and the OriginCountry property is used with Country as a
        //backing field

        //constructor - can pull information from DB for example
        public Car(string _make, string _model, int _year, string _color, string _country)
        {
            Make = _make;
            Model = _model;
            Year = _year;
            Color = _color;
            Country = _country;

        }


        //static: No need to create an instance of the class
        //you can just call the method
        public static string WhoAreYou()
        {
            return "I am a static method of the Car class";
        }



        public decimal DetermineValue()
        {
            decimal value;
            if (Year > 1990)
            {
                value = 10000;
            }
            else
            {
                value = 2000;
            }
            return value;
        }


    }
}
