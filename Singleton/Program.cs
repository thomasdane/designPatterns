using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInstance = Singleton.GetInstance();
            firstInstance.PrintMessage("First message");

            var secondInstance = Singleton.GetInstance();
            secondInstance.PrintMessage("Second message");

            Console.ReadKey();

            //Counter Value: 1
            //First message
            //Second message
        }
    }
}