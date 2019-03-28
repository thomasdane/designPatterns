using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface IObserver
    {
        void Update(ISubject sender);
    }
    class Logger : IObserver
    {
        public void Update(ISubject sender)
        {
            Console.WriteLine($"Logging data about {sender.OrderType} order");
        }
    }

    class Email : IObserver
    {
        public void Update(ISubject sender)
        {
            Console.WriteLine($"Sending email about {sender.OrderType} order");
        }
    }
}
