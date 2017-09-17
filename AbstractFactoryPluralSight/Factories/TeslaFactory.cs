using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPluralSight
{
    public class TeslaFactory : IAutoFactory
    {
        public IAuto CreateBasicCar()
        {
            return new TeslaBasic();
        }

        public IAuto CreateSportsCar()
        {
            return new TeslaSports();
        }
    }
}
