using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderService = new OrderService();
            orderService.Attach(new Logger());
            orderService.Attach(new Email());
            orderService.ReceiveOrder("Surfboard");
            Console.ReadKey();
        }
    }
}
