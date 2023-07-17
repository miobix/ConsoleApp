using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Student
    {
        //class attributes
        public string name;
        public string major;
        public double gpa;

        //constructor
        public Student(string _name, string _major, double _gpa)
        {
          
            name = _name;
            major = _major;
            gpa = _gpa;
            
        }


        //object methods
        public bool IsHonorRoll()
        {
            if(gpa >= 3.5)
            {
                return true;
            }
            return false;
        }

    }
}
