using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPluralSight
{
    public class AutoFactory
    {
        private readonly IAutoFactory _factory;

        public AutoFactory(string factoryType)
        {
            if (factoryType == "bmw") _factory = new BmwFactory();

            if (factoryType == "tesla") _factory = new TeslaFactory();
        }

        public IAuto CreateCar(string model)
        {
            if (model == "basic") return _factory.CreateBasicCar();
            if (model == "sports") return _factory.CreateSportsCar();
            return null; //could use null object pattern here
        }
    }
}
