using System.ComponentModel;
using System.Xml.Linq;

namespace oopAssign_01
{

    internal class Program
    {
        #region Fn Distance
        /*
        static double CalculateDistance(Point P01,Point P02)
        {
            return Math.Sqrt(Math.Pow(P02.X - P01.X, 2) + Math.Pow(P02.Y - P01.Y, 2)); 
        }
        */
        #endregion
        #region Fn person
        //fn to find oldest person
        //static Person FindOldestPerson(Person[] people)
        //{
        //    Person oldest = people[0];
        //    foreach (var person in people)
        //    {
        //        if (person.Age > oldest.Age)
        //        {
        //            oldest = person;
        //        }
        //    }
        //    return oldest;
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Part 01
            #region Q 01
            /* 1.Create a struct called "Point" to represent a 2D point with 
         properties "X" and "Y". Write a C# program that takes two points 
         as input from the user and calculates the distance between them.*/

            // Input for Point A 

            //Point P01, P02;
            //Console.WriteLine("Enter the X coordinate for the 1st Point (A): ");
            //int xA = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Y coordinate for the 1st Point (A): ");
            //int yA = int.Parse(Console.ReadLine());
            //P01 = new Point(xA, yA);

            // Input for Point B 

            //Console.WriteLine("Enter the X coordinate for the 2nd Point (B): ");
            //int xB = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Y coordinate for the 2nd Point (B): ");
            //int yB = int.Parse(Console.ReadLine());
            //P02 = new Point(xB, yB);

            // Calculate the distance between the two points  

            //double distance = CalculateDistance(P01, P02);

            //Console.WriteLine($"The distance between Point A({P01.X}, {P01.Y}) and Point B({P02.X}, {P02.Y}) is: {distance}");
            #endregion
            #region Q02
            /*
             2.Create a struct called "Person" with properties "Name" and "Age". 
               Write a C# program that takes details of 3 persons as input from the user 
               and displays the name and age of the oldest person.
             */

            //p01
            //Console.WriteLine("Enter the name of person 1");
            //string name01 = Console.ReadLine();
            //Console.WriteLine("Enter the age of person 1");
            //int age01 = int.Parse(Console.ReadLine()) ;

            ////p02
            //Console.WriteLine("Enter the name of person 2");
            //string name02 = Console.ReadLine();
            //Console.WriteLine("Enter the age of person 2");
            //int age02 = int.Parse(Console.ReadLine());

            ////p03
            //Console.WriteLine("Enter the name of person 3");
            //string name03 = Console.ReadLine();
            //Console.WriteLine("Enter the age of person 3");
            //int age03 = int.Parse(Console.ReadLine());

            //if (age01>age02 && age01 > age03)
            //{
            //    Console.WriteLine($"Name of the oldest one is : {name01}");
            //    Console.WriteLine($"Age of the oldest one is : {age01}");
            //}
            //else if (age02 > age01 && age02 > age03)
            //{
            //    Console.WriteLine($"Name of the oldest one is : {name02}");
            //    Console.WriteLine($"Age of the oldest one is : {age02}");
            //}
            //else if (age03 > age01 && age03 > age02)
            //{
            //    Console.WriteLine($"Name of the oldest one is : {name03}");
            //    Console.WriteLine($"Age of the oldest one is : {age03}");
            //}

            #endregion
            #region Another Solution Q02
            //  an array to create 3 Person instances
            //Person[] people = new Person[3];
            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.WriteLine($"Enter Details For Person {i+1}");
            //    Console.Write("Enter Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Enter Age: ");
            //    int age = int.Parse(Console.ReadLine());

            //    // Create a new Person and add to the array  
            //    people[i] = new Person(name, age);
            //}

             
            //Person oldestPerson = FindOldestPerson(people);

            // Display the oldest person's details  
            //Console.WriteLine($"\nThe oldest person is: {oldestPerson.Name}, Age: {oldestPerson.Age}");
            #endregion

            #endregion

        }
    }
}
