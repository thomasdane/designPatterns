// Creational pattern

// When to use: when you want to eliminate the option of instantiating more than one object

// Example: Logging. If you don't use a singleton, you can have multiple objects writing to the same log at different times
// You could also use a static class, but harder to mock for unit testing. 

// Key features: 
// Private constructor
// Static method that returns an instance of the class
// The instance is stored as a private static variable

using System;

namespace Singleton
{
    public class Singleton
    {
        private static int _counter; //to show that the object is created only once
        private static Singleton _firstInstance;

        private Singleton()
        {
            _counter++;
            Console.WriteLine("Counter Value: " + _counter);
        }

        public static Singleton GetInstance()
        {
            if (_firstInstance == null)
            {
                _firstInstance = new Singleton();
            }

            return _firstInstance;
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
