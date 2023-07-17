using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Movie
    {
        //class attributes
        public string title;     //public - open to everybody
        public string director;
        private string rating;    // private - closes access to the variable. Only code inside the Movie class is able to access the rating

        //constructor
        public Movie(string _title, string _director, string _rating)
        {

            title = _title;
            director = _director;
            Rating = _rating;    //USING A CAPITAL R CALLS THE SETTER BELOW

        }


        //class setters and getters control the access of user to the attributes of a class
        //makes the objects more secure
       
        //setters and getters can access and modify the private variables
        public string Rating
        {
            get 
            { 
                return rating; 
            }
            set
            { 
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                rating = value;
                } else
                {
                    rating = "NR";
                }
            }
        }

    }
}
