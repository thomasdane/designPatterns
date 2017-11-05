//Provide a non-functional object in place of a null reference
//Rid programming logic of null checks where possible - callers don't care if they get a null object or a real object
//Could be considered a special case of the command or strategy pattern


//Questions: why singleton? why static readonly singleton? 

//Puts singleton inside base class so that we can compare the value to null
// if(car == CarBase.null) ...

using System;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();

            var carRepository = new CarRepository();

            var car = carRepository.GetCarByName(name);

            car.Drive();

            Console.ReadKey();
        }
    }
}
