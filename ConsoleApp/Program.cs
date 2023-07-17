
using ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calling methods on main
            /*
            SayHi("Mike", 22);
            SayHi("Cris", 32);

            Console.WriteLine(cube(2));
            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);

            Console.WriteLine(squared(5)[0]);
            Console.WriteLine(squared(5)[1]);
            

            Console.WriteLine("Bigger Number is " + GetMax(6, 2, 1));
            */

            //switch case
            //program receives a number as input, returns the name of the day of the week
            //Console.WriteLine(GetDay(1));



        }



        static void SayHi(string name, int age)
        {
            //static, for now
            //void --> does not return a value
            //name - other than Main, PascalCase

            //method receives parameter "name"

            Console.WriteLine("Hi " + name + ", you are " + age + " years old");

            //only the code on Main runs when runnin the application
        }

        static void DataTypes()
            {
            //Basic Data Types
            /*
            string phrase = "a long string lol";
            char grade = 'A';    // only one character -- uses a single quote
            int age = 30;
            int minusValue = -10;
            float gpa = 3.2;               //least accurate - 7 digits, 32bit
            double gpa = 3.5;                                       //15 16 digits, 64bits
            decimal percentage = 60.351;    //most accurate  - 28 29 digits, 128 bit
            bool isMale = true;       // or false hhh  
            */
        }

        static void StringPractice()
        {
            //string methods practice
            
            string phrase = "a very Long String";
            string anotherPhrase = "with escaping\ncharacters";
            Console.WriteLine(phrase);
            Console.WriteLine(anotherPhrase);
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("Long"));
            Console.WriteLine(phrase[3]);
            Console.WriteLine(phrase.IndexOf("very"));
            Console.WriteLine(phrase.IndexOf("Very"));
            Console.WriteLine(phrase.Substring(5));
            Console.WriteLine(phrase.Substring(5,3));
           

            //using parameters on strings
            
            string word = "Cris";
            int age = 32;
            Console.WriteLine("my name is " + word);
            string result = string.Format("my name is {0} and i am {1} years old", word, age);
            Console.WriteLine(result);
            
            //working with numbers
            //operation between integers return integer

            
            Console.WriteLine(5 / 2);
            Console.WriteLine(5 / 2.0);

            int num = 6;
            Console.WriteLine(num);
            num++;
            Console.WriteLine(num);
            

        }

        static void WorkingWithNumbers()
        {
            //methods
            
            Console.WriteLine(Math.Abs(-40));   // absolute value
            Console.WriteLine(Math.Pow(3, 2));  // 3 to the 2nd power
            Console.WriteLine(Math.Sqrt(36));   //square root, duh
            Console.WriteLine(Math.Max(4, 90)); //return which number is bigger
            Console.WriteLine(Math.Min(4, 90));  
            Console.WriteLine(Math.Round(5.12));  //Rounds to the next int
            Console.WriteLine(Math.Round(5.72));
            


            //save user input to variable
            //Console.Write -- does not move to a new line
            
            Console.Write("Enter your Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Age: ");
            string age = Console.ReadLine();
            Console.WriteLine("You are " + name + " and You are " + age + " years old");
            

        }

        static void Arrays()
        {

            //ARRAYS
            
            //declaration
            int[] arrayOfInts = { 4 , 5 , 10 , 15 , 22 };

            //access elements of the array
            Console.WriteLine(arrayOfInts[1]);

            //update the array
            Console.WriteLine(arrayOfInts[3]);
            arrayOfInts[3] = -2;
            Console.WriteLine(arrayOfInts[3]);

            //with strings - another way to declare
            string[] regualarStrings = { "one", "two", "three" };
            Console.WriteLine(regualarStrings[1]);
            string[] friends = new string[5];   //specify length on declaration
            friends[0] = "Jim";
            Console.WriteLine(friends[0]);
            
        }

        static void DatesAndTImes()
        {
            Console.WriteLine("----DateTime basics----");
            DateTime moment = DateTime.Now;  //this instant
            Console.WriteLine(moment.ToString());
            Console.WriteLine(moment.ToShortDateString()); // only date
            Console.WriteLine(moment.ToShortTimeString());  // only time of the day
            Console.WriteLine(moment.ToLongDateString()); // date in words
            Console.WriteLine(moment.ToLongTimeString()); // hh/mm/ss

            //Date and time math
            Console.WriteLine("----date and time math----");
            Console.WriteLine("adding days: " + moment.AddDays(3).ToLongDateString());
            Console.WriteLine("adding days: " + moment.AddHours(3).ToLongTimeString());
            Console.WriteLine("substracting days: " + moment.AddDays(-5).ToLongDateString());


            Console.WriteLine("this is month number: " + moment.Month);
            Console.WriteLine("----Create date, parse date----");
            DateTime birthday = new DateTime(1990, 8, 6);
            Console.WriteLine(birthday.ToShortDateString());

            DateTime birthday2 = DateTime.Parse("8/6/1990");  // format for locale is mm/dd/yyyy
            Console.WriteLine(birthday2.ToShortDateString());


            Console.WriteLine("----Time in Between----");
            TimeSpan myAge = DateTime.Now.Subtract(birthday);
            Console.WriteLine("alive for " + myAge.TotalDays + " days");
            Console.WriteLine("alive for " + myAge.TotalHours + " hours");

        }

        static int GetMax(int num1, int num2, int num3)
        {
            //return the bigger number
            int result;

            if (num1 >= num2 && num1 >= num3)
            {

                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }
        static int cube(int num)
        {
            //int instead of void, the method will return an int
            int result = num * num * num;
            return result;
        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            }

            return result;
        }


        static double[] squared(int num)
        {
            //returning an array
            double[] result = { num * num, (num + 1) * (num + 1) };
            return result;
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }

            return dayName;
        }

        static void Loops()
        {
            //While Loops
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            //do while loops
            int index2 = 6;
            do
            {
                Console.WriteLine(index2);
                index2++;
            } while (index2 <= 5);


            //for loops
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            //print the elements of an array
            int[] numbers = { 4, 8, 12, 20, 100 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }

        static void IfElse()
        {
            //if-else statements
            //define a boolean
            bool isMale = false;
            bool isTall = true;

            //logical operators
            if (isMale && isTall)
            {
                Console.WriteLine("You are tall Male");
            }
            else
            {
                Console.WriteLine("You are not male nor tall");
            }

            if (isMale || isTall)
            {
                Console.WriteLine("You are tall or Male");
            }
            else
            {
                Console.WriteLine("You are not male nor tall");
            }

            //else-if statements, 
            if (!isMale && isTall)
            {
                Console.WriteLine("You are tall Male");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short Male");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not Male, but tall");
            }
            else if (!isMale && !isTall)
            {
                Console.WriteLine("You are not Male nor tall");
            }

        }

        static void MatrixAsArray()
        {

            //2d arrays
            //predefined
            int[,] numberGrid =
            {
                { 2,3}, {4,5 }, {7,1 }, { 7,2}, { 5,4}, { 6,5}
            };
            //access elements of the 2d array
            Console.WriteLine(numberGrid[1, 0]);  //prints 4

            //declaration
            int[,] myArray = new int[2, 4];
            myArray[0, 0] = 1;
            Console.WriteLine(myArray[0, 0]);



        }

        static void TryCatch()
        {
            //try-catch

            try
            {
                Console.Write("Enter a Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);   // this throws exception if divided by zero, of if input is not an int
            }
            /*
            catch(Exception err)  // catches  all exceptions
            {
                Console.WriteLine(err.Message);
            }*/
            catch (DivideByZeroException err)    // catches only DBzero exceptions
            {
                Console.WriteLine(err.Message);
            }
            catch (FormatException err)    // catches only format exceptions
            {
                Console.WriteLine(err.Message);
            }
            finally   //code here executes no matter what
            {
                Console.WriteLine("end!");
            }

        }

        static void InstancesAndClasses()
        {

            //using Class Book to create elements

            Book book1 = new Book("Harry Potter 1", "TERF lady", 250);    //this is an instance of the book class

            /*
                        Book book2 = new Book("cris");    //this is an instance of the book class
                        book1.title = "1984";
                        book1.pages = 400;
                        book1.author = "George Orwell";
            */
            Book book2 = new Book("1984", "George Orwell", 400);    //this is an instance of the book class

            //check the value created by the contructor
            Console.WriteLine(book2.title);

            //the variable can be updated later
            book2.title = "Animal Farm";
            Console.WriteLine(book2.title);



            //class methods practice
            Student student1 = new Student("Cris", "Dev", 4.5);
            Student student2 = new Student("Sebastian", "Eng", 2);

            Console.WriteLine(student1.IsHonorRoll());
            Console.WriteLine(student2.IsHonorRoll());


            //setters and getters 
            Movie avengers = new Movie("Avengers", "Josh Whedon", "dog");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            //problem, movie ratings can only be G, PG, PG13, R, NR
            //we want all the movies to be rated as one of the above, so this must be enforced on constructor and later modifications

            Console.WriteLine(avengers.Rating);  // this will set to NR becase an invalid rating was passed to the constructort
            avengers.Rating = "PG-13";
            Console.WriteLine(avengers.Rating);



            //static class attributes
            //static attributes in a class is shared by all instances of the class, contained on the class itself instead of every object.


            Song butter = new Song("Butter", "BTS", 300);
            Song weekend = new Song("Weekend", "Taeyeong", 350);

            //accessing a static class attribute
            Console.WriteLine(Song.songCount);


            //static methods and classes
            UsefulTools.SayHi("Cristian");
            //UsefulTools myTools = new UsefulTools();
            //the class is marked as static, so new objects cannot created from it




            //Inheritance - new classes / subclasses can inherit parts of another class / superclass

            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecial();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakeSpecial();

            italianChef.MakePasta();



        }

        public static void ListsAndDictionaries()
        {
            Car myCar = new Car("Nissan", "One", 1995, "Silver", "Japan");
            myCar.Year = 1992;
            //Console.WriteLine("{0:C}", myCar.DetermineValue());
            Console.WriteLine(myCar.DetermineValue());
            Car myOtherCar = myCar;
            //Creating an object like this COPIES THE REFERENCE
            //and not the info on memory
            Console.WriteLine(myOtherCar.Year);
            myOtherCar.Year = 2005;
            Console.WriteLine(myCar.Year);
            //careful when copying objects

            //calling static methods
            Console.WriteLine(Car.WhoAreYou());

            //working with Collections
            //List<T>

            List<Car> myList = new List<Car>();

            Car car1 = new Car("Suzuki", "Two", 2001, "Silver", "Japan");
            Car car2 = new Car("SSanyong", "Three", 2010, "Black", "Korea");
            myList.Add(myCar);
            myList.Add(car1);
            myList.Add(car2);

            //can only add Car objects to the list
            Bike myBike = new Bike(2000, "red", "mountain");
            //myList.Add(myBike);   //this throws exception


            foreach (Car car in myList)
            {
                Console.WriteLine(car.Make);
            }


            //Working with dictionaries
            //Dictionary <TKey, TValue>

            Dictionary<int, Car> myDictionary = new Dictionary<int, Car>();

            //makes easy to find objects by its key
            myDictionary.Add(1, myCar);
            myDictionary.Add(2, car1);
            myDictionary.Add(3, car2);

            Console.WriteLine(myDictionary.Count);
            Console.WriteLine(myDictionary[1].Make);


            //Collection initializer
            List<Car> myCarList = new List<Car>()
            {
                new Car("Nissan", "Altime" , 2006, "White", "Japan"),
                new Car("Mitsubishi", "Uno", 2001, "Blue", "Japan")
            };
        }

        public static void LINQQueriesAndMethods()
        {

            List<Car> myList = new List<Car>();

            Car myCar = new Car("Nissan", "One", 1995, "Silver", "Japan");
            Car car1 = new Car("Suzuki", "Two", 2001, "Silver", "Japan");
            Car car2 = new Car("SSanyong", "Three", 2010, "Black", "Korea");
            Car car4 = new Car("Suzuki", "Ten", 1990, "Black", "Japan");
            Car car5 = new Car("SSanyong", "Twenty", 2019, "Red", "Korea");
            Car car6 = new Car("Suzuki", "Two", 2001, "Silver", "Japan");
            Car car7 = new Car("SSanyong", "Ten", 1995, "Silver", "Korea");
            Car car8 = new Car("Nissan", "Altime", 2006, "White", "Japan");
            myList.Add(myCar);
            myList.Add(car1);
            myList.Add(car2);
            myList.Add(car4);
            myList.Add(car5);
            myList.Add(car6);
            myList.Add(car7);
            myList.Add(car8);


            //LINQ Query
            // - 1 - select by one filter
            var ssanyongs = from car in myList
                            where car.Make == "SSanyong"
                            select car;

            foreach (var car in ssanyongs)
            {
                Console.WriteLine("LINQ Query 1: {0} {1}", car.Model, car.Year);
            }

            // - 2 - select a combination of parameters
            var ssYear = from car in myList
                         where car.Make == "SSanyong"
                         && car.Year == 1995
                         select car;

            foreach (var car in ssYear)
            {
                Console.WriteLine("LINQ Query 2: {0} {1}", car.Model, car.Year);
            }

            var orderedCars = from car in myList
                              orderby car.Year descending
                              select car;

            foreach (var car in orderedCars)
            {
                Console.WriteLine("Ordered List: {0} {1}", car.Model, car.Year);
            }

            //Only certain elements from the query can be returned
            var newCars = from car in myList
                          where car.Make == "Ssanyong"
                          select new { car.Make, car.Model };
            //this is a collection of annonymous types



            //LINQ Method
            //same as Query, in method syntax
            var ssayongsMethod = myList.Where(p => p.Make == "SSanyong" && p.Year == 1995);
            //.Where returns a collection of smth

            foreach (var car in ssayongsMethod)
            {
                Console.WriteLine("With LINQ method: " + car.Model + ", year " + car.Year);
            }

            var orderedMethod = myList.OrderByDescending(p => p.Year);  //note that ths is not a filter! not being compared
            foreach (var car in orderedMethod)
            {
                Console.WriteLine("Ordered Method: " + car.Model + ", year " + car.Year);
            }

            var firstSuzuki = myList.First(p => p.Make == "Suzuki");
            Console.WriteLine("First Suzuki of the List: " + firstSuzuki.Model + " " + firstSuzuki.Year);

            //combine together
            var oldestSuzuki = myList.OrderByDescending(p => p.Year).Last(p => p.Make == "Suzuki");
            Console.WriteLine("Oldest Suzuki: " + oldestSuzuki.Model + " " + oldestSuzuki.Year);


            //assessments
            Console.WriteLine(myList.TrueForAll(p => p.Year > 1989));
            Console.WriteLine(myList.TrueForAll(p => p.Year > 1999));

            //shorthand to print elements
            myList.ForEach(p => Console.WriteLine("Shorthand console: {0}, {1}, {2}", p.Make, p.Model, p.Year));

            //exists
            Console.WriteLine(myList.Exists(p => p.Model == "Two"));
            Console.WriteLine(myList.Exists(p => p.Make == "Mitsubishi"));
            Console.WriteLine(myList.Exists(p => p.Make == "SSanyong"));


            //Aggregate values -- just an example
            Console.WriteLine(myList.Sum(p => p.Year));



            //using "var" makes easier to handle the results of the query
            //it is not easy to guess what type will be returned
            //checking data types of lists
            Console.WriteLine(myList.GetType());
            Console.WriteLine(orderedMethod.GetType());
            Console.WriteLine(ssayongsMethod.GetType());
            Console.WriteLine(newCars.GetType());
        }


        public static void Enums()
        {
            //enumerations: Limit and constrains data to ensure
            //its validity inside the system. 
            /*
             * Example: TODO list of tasks:
             * One can represent tasks with an id
             * Or a string for "Started" or "finished" etc
             * But numbers can lose meaning in future revisions
             * or strings can be mistyped, etc
             * 
             * To avoid confusions, a Enum is introduced
             */

            List<Todo> todos = new List<Todo>()
            {
                new Todo { Description = "Task 1", EstimatedHours = 5 , Status = Status.NotStarted },
                new Todo { Description = "Task 2", EstimatedHours = 1 , Status = Status.OnHold },
                new Todo { Description = "Task 3", EstimatedHours = 3 , Status = Status.InProgress },
                new Todo { Description = "Task 4", EstimatedHours = 2 , Status = Status.Completed },
                new Todo { Description = "Task 5", EstimatedHours = 6 , Status = Status.Deleted },

                //visually, it is much easier to work with status like this
            };

            PrintAssessments(todos);
        }
        public static void PrintAssessments(List<Todo> todos)
        {
            foreach (var todo in todos)
            {
                switch (todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(todo.Description);
            }
        }

        public void ElapsedTimeEvents()
        {
            //working with Events, Time passed
            Timer myTimer = new Timer(2000);  //2 seconds

            //adds some extra everytime the Elapsed event occurrs
            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;
            //note that these two execute simultaneously, not 2 seconds apart of each other

            myTimer.Start();

            Console.WriteLine("Press enter to remove Red event");
            Console.ReadLine();

            //remove an event
            myTimer.Elapsed -= MyTimer_Elapsed;

            Console.ReadLine();
        }

        private static void MyTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed: {0:HH:MM:ss.fff}", e.SignalTime);

        }

        private static void MyTimer_Elapsed1(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Elapsed One: {0:HH:MM:ss.fff}", e.SignalTime);

        }
    }
}