using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
        string OrderType { get; }
    }
    class OrderService : ISubject
    {
        private readonly List<IObserver> Observers = new List<IObserver>();
        public string OrderType { get; private set; }

        public void ReceiveOrder(string orderType)
        {
            OrderType = orderType;
            Console.WriteLine($"Received an order for {orderType}");
            Notify();
        }

        public void Attach(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(var observer in Observers)
            {
                observer.Update(this);
            }
        }
    }
}
