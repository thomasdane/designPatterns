using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//What is it:

//When a method returns one of several classes that share a common super class
//class is chosen at run time

//Define an interface for object creation, but let subclass decide which class to instantiate


//When to use: 

//don't know ahead of time what object you need
//centralise class selection code
//encapsulate object creation

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of plane do you want to make?");
            var input = Console.ReadLine();

            var factory = new PlaneFactory();
            var plane = factory.CreatePlane(input);
            
            Console.WriteLine("Can people board the " + plane.Name);
            Console.WriteLine(CanPeopleBoardThePlane(plane, 100));

            Console.ReadKey();
        }

        public static bool CanPeopleBoardThePlane(IPlane plane, int people)
        {
            return plane.IsFull(people);
        }
    }
}
