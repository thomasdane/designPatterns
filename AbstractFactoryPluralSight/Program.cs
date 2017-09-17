using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPluralSight
{
    class Program
    {
        static void Main(string[] args)
        {
            var factoryA = new AutoFactory("bmw");
            var carA = factoryA.CreateCar("basic");
            var sportsCarA = factoryA.CreateCar("sports");
            carA.Drive();
            sportsCarA.Drive();

            var factoryB = new AutoFactory("tesla");
            var carB = factoryB.CreateCar("basic");
            var sportsCarB = factoryB.CreateCar("sports");
            carB.Drive();
            sportsCarB.Drive();

            Console.ReadKey();
        }
    }
}
