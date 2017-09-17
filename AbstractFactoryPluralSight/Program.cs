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
            IAutoFactory factoryA = LoadFactory("bmw");
            var carA = factoryA.CreateCar("basic");
            var sportsCarA = factoryA.CreateCar("sports");
            carA.Drive();
            sportsCarA.Drive();

            IAutoFactory factoryB = LoadFactory("tesla");
            var carB = factoryB.CreateCar("basic");
            var sportsCarB = factoryB.CreateCar("sports");
            carB.Drive();
            sportsCarB.Drive();

            Console.ReadKey();
        }

        static IAutoFactory LoadFactory(string factoryType)
        {
            if (factoryType == "bmw") return new BmwFactory();

            if (factoryType == "tesla") return new TeslaFactory();

            return null;
        }
    }
}
