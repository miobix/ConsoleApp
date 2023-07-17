using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Song
    {
        //class attributes
        public string title;     
        public string artist;
        public int duration;

        //static class attribute  -- relevant to the class itself, not a specific object of the class
        public static int songCount = 0;

        //constructor
        public Song(string _title, string _artist, int _duration)
        {

            title = _title;
            artist = _artist;
            duration = _duration; 

            songCount = songCount + 1;
            Console.WriteLine("Song Created, Total: " + songCount);

        }



       
    }
}
